using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public interface IMainForm
    {
        string Path { get; }
        string Content { get; set; }
        void SetSymbolCount(int count);
        void SetWordCount(int count);
        event EventHandler FileOpenClick;
        event EventHandler FileSaveClick;
        event EventHandler ContentChanged;
        event EventHandler ClosingForm;
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
            FormClosing += MainForm_FormClosing;
        }

        private void ButOpenFile_Click(object sender, EventArgs e)
        {
            FileOpenClick?.Invoke(this, EventArgs.Empty);
            if (!string.IsNullOrEmpty(Content)) textContent.ReadOnly = false;
        }

        private void ButSaveFile_Click(object sender, EventArgs e)
        {
            FileSaveClick?.Invoke(this, EventArgs.Empty);
        }

        private void TextContent_TextChanged(object sender, EventArgs e)
        {
            ContentChanged?.Invoke(this, EventArgs.Empty);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClosingForm?.Invoke(this, EventArgs.Empty);
        }
        #region Events



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
        public event EventHandler ClosingForm;

        public void SetSymbolCount(int count)
        {
            textSymbolCount.Text = count.ToString();
        }

        public void SetWordCount(int count)
        {
            textWordCount.Text = count.ToString();
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