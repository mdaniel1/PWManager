namespace PWManager
{
    partial class OptionWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionWindow));
            this.LanguageLabel = new System.Windows.Forms.Label();
            this.LanguageCB = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.FilePathLabel = new System.Windows.Forms.Label();
            this.SaveDirectoryTB = new System.Windows.Forms.TextBox();
            this.fileDialogButton = new System.Windows.Forms.Button();
            this.NoteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(9, 83);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(52, 13);
            this.LanguageLabel.TabIndex = 0;
            this.LanguageLabel.Text = "Langue : ";
            // 
            // LanguageCB
            // 
            this.LanguageCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LanguageCB.FormattingEnabled = true;
            this.LanguageCB.Location = new System.Drawing.Point(12, 99);
            this.LanguageCB.Name = "LanguageCB";
            this.LanguageCB.Size = new System.Drawing.Size(121, 21);
            this.LanguageCB.TabIndex = 1;
            // 
            // OKButton
            // 
            this.OKButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OKButton.Location = new System.Drawing.Point(234, 97);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 2;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(313, 97);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Annuler";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FilePathLabel
            // 
            this.FilePathLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.FilePathLabel.AutoSize = true;
            this.FilePathLabel.Location = new System.Drawing.Point(15, 20);
            this.FilePathLabel.Name = "FilePathLabel";
            this.FilePathLabel.Size = new System.Drawing.Size(131, 13);
            this.FilePathLabel.TabIndex = 4;
            this.FilePathLabel.Text = "Dossier d\'enregistrement : ";
            // 
            // SaveDirectoryTB
            // 
            this.SaveDirectoryTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SaveDirectoryTB.Location = new System.Drawing.Point(152, 17);
            this.SaveDirectoryTB.Name = "SaveDirectoryTB";
            this.SaveDirectoryTB.Size = new System.Drawing.Size(220, 20);
            this.SaveDirectoryTB.TabIndex = 5;
            // 
            // fileDialogButton
            // 
            this.fileDialogButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.fileDialogButton.Location = new System.Drawing.Point(377, 15);
            this.fileDialogButton.Name = "fileDialogButton";
            this.fileDialogButton.Size = new System.Drawing.Size(27, 23);
            this.fileDialogButton.TabIndex = 6;
            this.fileDialogButton.Text = "...";
            this.fileDialogButton.UseVisualStyleBackColor = true;
            this.fileDialogButton.Click += new System.EventHandler(this.fileDialogButton_Click);
            // 
            // NoteLabel
            // 
            this.NoteLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NoteLabel.AutoSize = true;
            this.NoteLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NoteLabel.Location = new System.Drawing.Point(18, 57);
            this.NoteLabel.Name = "NoteLabel";
            this.NoteLabel.Size = new System.Drawing.Size(391, 15);
            this.NoteLabel.TabIndex = 7;
            this.NoteLabel.Text = "Note : Le dossier \"PWManager\" sera automatiquement créé s\'il n\'existe pas déjà.";
            // 
            // OptionWindow
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 132);
            this.Controls.Add(this.NoteLabel);
            this.Controls.Add(this.fileDialogButton);
            this.Controls.Add(this.SaveDirectoryTB);
            this.Controls.Add(this.FilePathLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.LanguageCB);
            this.Controls.Add(this.LanguageLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OptionWindow";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageCB;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label FilePathLabel;
        private System.Windows.Forms.TextBox SaveDirectoryTB;
        private System.Windows.Forms.Button fileDialogButton;
        private System.Windows.Forms.Label NoteLabel;
    }
}