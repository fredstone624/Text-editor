using AppBusLogic;
using System;

namespace App
{
    public class MainPresenter
    {
        private readonly IMainForm _view;
        private readonly IFileManager _manager;
        private readonly IMessageService _service;
        private string _currentPath;

        public MainPresenter(IMainForm view, IFileManager manager, IMessageService service)
        {
            _view = view;
            _manager = manager;
            _service = service;
            
            _view.SetSymbolCount(0);

            _view.ContentChanged += _view_ContentChanged;
            _view.FileOpenClick += _view_FileOpenClick;
            _view.FileSaveClick += _view_FileSaveClick;
        }

        private void _view_ContentChanged(object sender, System.EventArgs e)
        {
            _view.SetSymbolCount(_manager.GetSymbolCount(_view.Content));
        }

        private void _view_FileOpenClick(object sender, System.EventArgs e)
        {
            try
            {
                string path = _view.Path;

                if (!_manager.IsExist(path))
                {
                    _service.ShowExclamation("Выбраного файла не существует.");
                    return;
                }

                _currentPath = path;
                _view.Content = _manager.GetContent(path);
                _view.SetSymbolCount(_manager.GetSymbolCount(_view.Content));
            }
            catch(Exception ex)
            {
                _service.ShowError(ex.Message);
            }
        }

        private void _view_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                _manager.SaveContent(_currentPath, _view.Content);

                _service.ShowMessage("Файл успешно сохранён.");
            }
            catch (Exception ex)
            {
                _service.ShowError(ex.Message);
            }
        }
    }
}