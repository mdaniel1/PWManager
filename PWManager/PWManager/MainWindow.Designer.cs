namespace PWManager
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.SortASCButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SortDESCButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DomainListbox = new System.Windows.Forms.ListBox();
            this.AccountListbox = new System.Windows.Forms.ListBox();
            this.AddDomainButton = new System.Windows.Forms.Button();
            this.DelDomainButton = new System.Windows.Forms.Button();
            this.AddAccountButton = new System.Windows.Forms.Button();
            this.DelAccountButton = new System.Windows.Forms.Button();
            this.ModAccountButton = new System.Windows.Forms.Button();
            this.ModDomainButton = new System.Windows.Forms.Button();
            this.separator_line = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.AccountTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sauvegarderToolStripMenuItem,
            this.chargerToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // chargerToolStripMenuItem
            // 
            this.chargerToolStripMenuItem.Name = "chargerToolStripMenuItem";
            this.chargerToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.chargerToolStripMenuItem.Text = "Charger";
            this.chargerToolStripMenuItem.Click += new System.EventHandler(this.chargerToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SortASCButton,
            this.toolStripSeparator1,
            this.SortDESCButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(974, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // SortASCButton
            // 
            this.SortASCButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortASCButton.Image = ((System.Drawing.Image)(resources.GetObject("SortASCButton.Image")));
            this.SortASCButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortASCButton.Name = "SortASCButton";
            this.SortASCButton.Size = new System.Drawing.Size(164, 22);
            this.SortASCButton.Text = "Trier les domaines (croissant)";
            this.SortASCButton.Click += new System.EventHandler(this.SortASCButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SortDESCButton
            // 
            this.SortDESCButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SortDESCButton.Image = ((System.Drawing.Image)(resources.GetObject("SortDESCButton.Image")));
            this.SortDESCButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SortDESCButton.Name = "SortDESCButton";
            this.SortDESCButton.Size = new System.Drawing.Size(177, 22);
            this.SortDESCButton.Text = "Trier les domaines (décroissant)";
            this.SortDESCButton.Click += new System.EventHandler(this.SortDESCButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(40, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Liste des domaines";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(357, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liste des domaines";
            // 
            // DomainListbox
            // 
            this.DomainListbox.FormattingEnabled = true;
            this.DomainListbox.Location = new System.Drawing.Point(17, 100);
            this.DomainListbox.Name = "DomainListbox";
            this.DomainListbox.Size = new System.Drawing.Size(202, 576);
            this.DomainListbox.TabIndex = 4;
            this.DomainListbox.SelectedIndexChanged += new System.EventHandler(this.DomainListbox_SelectedIndexChanged);
            // 
            // AccountListbox
            // 
            this.AccountListbox.FormattingEnabled = true;
            this.AccountListbox.Location = new System.Drawing.Point(253, 100);
            this.AccountListbox.Name = "AccountListbox";
            this.AccountListbox.Size = new System.Drawing.Size(364, 576);
            this.AccountListbox.TabIndex = 5;
            this.AccountListbox.SelectedIndexChanged += new System.EventHandler(this.AccountListbox_SelectedIndexChanged);
            // 
            // AddDomainButton
            // 
            this.AddDomainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDomainButton.Location = new System.Drawing.Point(653, 100);
            this.AddDomainButton.Name = "AddDomainButton";
            this.AddDomainButton.Size = new System.Drawing.Size(140, 44);
            this.AddDomainButton.TabIndex = 6;
            this.AddDomainButton.Text = "Ajouter un domaine";
            this.AddDomainButton.UseVisualStyleBackColor = true;
            this.AddDomainButton.Click += new System.EventHandler(this.AddDomainButton_Click);
            // 
            // DelDomainButton
            // 
            this.DelDomainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelDomainButton.Location = new System.Drawing.Point(799, 100);
            this.DelDomainButton.Name = "DelDomainButton";
            this.DelDomainButton.Size = new System.Drawing.Size(140, 44);
            this.DelDomainButton.TabIndex = 7;
            this.DelDomainButton.Text = "Supprimer un domaine";
            this.DelDomainButton.UseVisualStyleBackColor = true;
            this.DelDomainButton.Click += new System.EventHandler(this.DelDomainButton_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddAccountButton.Location = new System.Drawing.Point(653, 241);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(140, 44);
            this.AddAccountButton.TabIndex = 8;
            this.AddAccountButton.Text = "Ajouter un compte";
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // DelAccountButton
            // 
            this.DelAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DelAccountButton.Location = new System.Drawing.Point(799, 241);
            this.DelAccountButton.Name = "DelAccountButton";
            this.DelAccountButton.Size = new System.Drawing.Size(140, 44);
            this.DelAccountButton.TabIndex = 9;
            this.DelAccountButton.Text = "Supprimer un compte";
            this.DelAccountButton.UseVisualStyleBackColor = true;
            this.DelAccountButton.Click += new System.EventHandler(this.DelAccountButton_Click);
            // 
            // ModAccountButton
            // 
            this.ModAccountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModAccountButton.Location = new System.Drawing.Point(653, 291);
            this.ModAccountButton.Name = "ModAccountButton";
            this.ModAccountButton.Size = new System.Drawing.Size(140, 44);
            this.ModAccountButton.TabIndex = 10;
            this.ModAccountButton.Text = "Modifier un compte";
            this.ModAccountButton.UseVisualStyleBackColor = true;
            this.ModAccountButton.Click += new System.EventHandler(this.ModAccountButton_Click);
            // 
            // ModDomainButton
            // 
            this.ModDomainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ModDomainButton.Location = new System.Drawing.Point(653, 150);
            this.ModDomainButton.Name = "ModDomainButton";
            this.ModDomainButton.Size = new System.Drawing.Size(140, 44);
            this.ModDomainButton.TabIndex = 11;
            this.ModDomainButton.Text = "Modifier un domaine";
            this.ModDomainButton.UseVisualStyleBackColor = true;
            this.ModDomainButton.Click += new System.EventHandler(this.ModDomainButton_Click);
            // 
            // separator_line
            // 
            this.separator_line.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.separator_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator_line.Location = new System.Drawing.Point(653, 215);
            this.separator_line.Name = "separator_line";
            this.separator_line.Size = new System.Drawing.Size(286, 23);
            this.separator_line.TabIndex = 12;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 700);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(974, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(33, 17);
            this.statusLabel.Text = "TEST";
            // 
            // AccountTextbox
            // 
            this.AccountTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountTextbox.Location = new System.Drawing.Point(703, 516);
            this.AccountTextbox.Name = "AccountTextbox";
            this.AccountTextbox.Size = new System.Drawing.Size(236, 20);
            this.AccountTextbox.TabIndex = 14;
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextbox.Location = new System.Drawing.Point(703, 542);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(236, 20);
            this.PasswordTextbox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(699, 467);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Accès rapide aux données ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(623, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Compte :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Mot de passe :";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 722);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.AccountTextbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.separator_line);
            this.Controls.Add(this.ModDomainButton);
            this.Controls.Add(this.ModAccountButton);
            this.Controls.Add(this.DelAccountButton);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.DelDomainButton);
            this.Controls.Add(this.AddDomainButton);
            this.Controls.Add(this.AccountListbox);
            this.Controls.Add(this.DomainListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Password Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton SortASCButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SortDESCButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox DomainListbox;
        private System.Windows.Forms.ListBox AccountListbox;
        private System.Windows.Forms.Button AddDomainButton;
        private System.Windows.Forms.Button DelDomainButton;
        private System.Windows.Forms.Button AddAccountButton;
        private System.Windows.Forms.Button DelAccountButton;
        private System.Windows.Forms.Button ModAccountButton;
        private System.Windows.Forms.Button ModDomainButton;
        private System.Windows.Forms.Label separator_line;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.TextBox AccountTextbox;
        private System.Windows.Forms.TextBox PasswordTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    }
}

