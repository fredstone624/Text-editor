namespace App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textSelectFile = new System.Windows.Forms.Label();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.butSelectFile = new System.Windows.Forms.Button();
            this.butOpenFile = new System.Windows.Forms.Button();
            this.textFont = new System.Windows.Forms.Label();
            this.numFont = new System.Windows.Forms.NumericUpDown();
            this.textContent = new System.Windows.Forms.TextBox();
            this.butSaveFile = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            this.textCountSymbol = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // textSelectFile
            // 
            this.textSelectFile.AutoSize = true;
            this.textSelectFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textSelectFile.Location = new System.Drawing.Point(12, 22);
            this.textSelectFile.Name = "textSelectFile";
            this.textSelectFile.Size = new System.Drawing.Size(101, 15);
            this.textSelectFile.TabIndex = 0;
            this.textSelectFile.Text = "Выберите файл";
            // 
            // textFilePath
            // 
            this.textFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilePath.Location = new System.Drawing.Point(119, 21);
            this.textFilePath.MaxLength = 300;
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(442, 20);
            this.textFilePath.TabIndex = 0;
            // 
            // butSelectFile
            // 
            this.butSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSelectFile.Location = new System.Drawing.Point(567, 19);
            this.butSelectFile.Name = "butSelectFile";
            this.butSelectFile.Size = new System.Drawing.Size(75, 23);
            this.butSelectFile.TabIndex = 4;
            this.butSelectFile.Text = "Выбрать\r\n";
            this.butSelectFile.UseVisualStyleBackColor = true;
            // 
            // butOpenFile
            // 
            this.butOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butOpenFile.Location = new System.Drawing.Point(648, 19);
            this.butOpenFile.Name = "butOpenFile";
            this.butOpenFile.Size = new System.Drawing.Size(75, 23);
            this.butOpenFile.TabIndex = 3;
            this.butOpenFile.Text = "Открыть";
            this.butOpenFile.UseVisualStyleBackColor = true;
            // 
            // textFont
            // 
            this.textFont.AutoSize = true;
            this.textFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textFont.Location = new System.Drawing.Point(12, 55);
            this.textFont.Name = "textFont";
            this.textFont.Size = new System.Drawing.Size(50, 15);
            this.textFont.TabIndex = 5;
            this.textFont.Text = "Шрифт";
            // 
            // numFont
            // 
            this.numFont.Location = new System.Drawing.Point(119, 55);
            this.numFont.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.numFont.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numFont.Name = "numFont";
            this.numFont.Size = new System.Drawing.Size(120, 20);
            this.numFont.TabIndex = 6;
            this.numFont.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // textContent
            // 
            this.textContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textContent.Location = new System.Drawing.Point(15, 93);
            this.textContent.Multiline = true;
            this.textContent.Name = "textContent";
            this.textContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textContent.Size = new System.Drawing.Size(718, 278);
            this.textContent.TabIndex = 7;
            // 
            // butSaveFile
            // 
            this.butSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butSaveFile.Location = new System.Drawing.Point(659, 377);
            this.butSaveFile.Name = "butSaveFile";
            this.butSaveFile.Size = new System.Drawing.Size(75, 23);
            this.butSaveFile.TabIndex = 8;
            this.butSaveFile.Text = "Сохранить";
            this.butSaveFile.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textSymbol,
            this.textCountSymbol});
            this.statusStrip.Location = new System.Drawing.Point(0, 412);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(746, 22);
            this.statusStrip.TabIndex = 9;
            this.statusStrip.Text = "statusStrip";
            // 
            // textSymbol
            // 
            this.textSymbol.Name = "textSymbol";
            this.textSymbol.Size = new System.Drawing.Size(107, 17);
            this.textSymbol.Text = "Кол-во символов:";
            // 
            // textCountSymbol
            // 
            this.textCountSymbol.Name = "textCountSymbol";
            this.textCountSymbol.Size = new System.Drawing.Size(0, 17);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(746, 434);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.butSaveFile);
            this.Controls.Add(this.textContent);
            this.Controls.Add(this.numFont);
            this.Controls.Add(this.textFont);
            this.Controls.Add(this.butSelectFile);
            this.Controls.Add(this.butOpenFile);
            this.Controls.Add(this.textSelectFile);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.numFont)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textSelectFile;
        private System.Windows.Forms.Button butOpenFile;
        private System.Windows.Forms.Button butSelectFile;
        private System.Windows.Forms.Label textFont;
        private System.Windows.Forms.NumericUpDown numFont;
        private System.Windows.Forms.TextBox textContent;
        private System.Windows.Forms.Button butSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel textSymbol;
        private System.Windows.Forms.ToolStripStatusLabel textCountSymbol;
        private System.Windows.Forms.TextBox textFilePath;
    }
}