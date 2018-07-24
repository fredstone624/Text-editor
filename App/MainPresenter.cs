using AppBusLogic;
using System;

namespace App
{
    public class MainPresenter
    {
        private readonly IMainForm view;
        private readonly IFileManager manager;
        private readonly IMessageService service;
        private string currentPath;

        public MainPresenter(IMainForm view, IFileManager manager, IMessageService service)
        {
            this.view = view;
            this.manager = manager;
            this.service = service;
            this.view.SetSymbolCount(0);

            this.view.FileOpenClick += View_FileOpenClick;
            this.view.FileSaveClick += View_FileSaveClick;
            this.view.ContentChanged += View_ContentChanged;
        }

        private void View_FileOpenClick(object sender, System.EventArgs e)
        {
            try
            {
                string path = view.Path;

                if (!manager.IsExist(path))
                {
                    service.ShowExclamation("Выбраного файла не существует.");
                    return;
                }

                currentPath = path;
                view.Content = manager.GetContent(path);
                view.SetSymbolCount(manager.GetSymbolCount(view.Content));
            }
            catch(Exception ex)
            {
                service.ShowError(ex.Message);
            }
        }

        private void View_FileSaveClick(object sender, EventArgs e)
        {
            try
            {
                manager.SaveContent(currentPath, view.Content);
                service.ShowMessage("Файл успешно сохранён.");
            }
            catch (Exception ex)
            {
                service.ShowError(ex.Message);
            }
        }

        private void View_ContentChanged(object sender, System.EventArgs e)
        {
            view.SetSymbolCount(manager.GetSymbolCount(view.Content));
        }
    }
}