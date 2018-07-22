using System;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public interface IMainForm
    {
        string Path { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            butOpenFile.Click += ButOpenFile_Click;
            butSaveFile.Click += ButSaveFile_Click;
            textContent.TextChanged += TextContent_TextChanged;
            butSelectFile.Click += ButSelectFile_Click;
            numFont.ValueChanged += NumFont_ValueChanged;
        }

        #region Events
        private void TextContent_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            FileSaveClick?.Invoke(this, EventArgs.Empty);
        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            FileOpenClick?.Invoke(this, EventArgs.Empty);
        }
        #endregion

        #region IMainForm
        public string Path
        {
            get { return textFilePath.Text; }
        }

        public string Content
        {
            get { return textContent.Text; }
            set { textContent.Text = value; }
        }

        public event EventHandler FileOpenClick;
        public event EventHandler FileSaveClick;
        public event EventHandler ContentChanged;

        public void SetSymbolCount(int count)
        {
            textCountSymbol.Text = count.ToString();
        }
        #endregion

        private void ButSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "Текстовые файлы|*.txt|Все файлы|*.*"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textFilePath.Text = dialog.FileName;

                ButOpenFile_Click(this, EventArgs.Empty);
            }
        }

        private void NumFont_ValueChanged(object sender, EventArgs e)
        {
            textContent.Font = new Font("Microsoft Sans Serif", (int)numFont.Value);
        }
    }
}