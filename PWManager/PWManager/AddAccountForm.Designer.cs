namespace PWManager
{
    partial class AddAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAccountForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.separator_line = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nameTF = new System.Windows.Forms.TextBox();
            this.pwdTF = new System.Windows.Forms.TextBox();
            this.tailleTF = new System.Windows.Forms.TextBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom du compte : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Génération d\'un mot de passe";
            // 
            // separator_line
            // 
            this.separator_line.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator_line.Location = new System.Drawing.Point(12, 77);
            this.separator_line.Name = "separator_line";
            this.separator_line.Size = new System.Drawing.Size(389, 10);
            this.separator_line.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Taille : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Générer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameTF
            // 
            this.nameTF.Location = new System.Drawing.Point(143, 20);
            this.nameTF.MaximumSize = new System.Drawing.Size(257, 20);
            this.nameTF.MinimumSize = new System.Drawing.Size(257, 20);
            this.nameTF.Name = "nameTF";
            this.nameTF.Size = new System.Drawing.Size(257, 20);
            this.nameTF.TabIndex = 16;
            // 
            // pwdTF
            // 
            this.pwdTF.Location = new System.Drawing.Point(143, 49);
            this.pwdTF.Name = "pwdTF";
            this.pwdTF.Size = new System.Drawing.Size(257, 20);
            this.pwdTF.TabIndex = 17;
            // 
            // tailleTF
            // 
            this.tailleTF.Location = new System.Drawing.Point(63, 129);
            this.tailleTF.Name = "tailleTF";
            this.tailleTF.Size = new System.Drawing.Size(132, 20);
            this.tailleTF.TabIndex = 18;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(249, 155);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 19;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 155);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // AddAccountForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 195);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.tailleTF);
            this.Controls.Add(this.pwdTF);
            this.Controls.Add(this.nameTF);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.separator_line);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(433, 234);
            this.MinimumSize = new System.Drawing.Size(433, 234);
            this.Name = "AddAccountForm";
            this.Text = "AddAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label separator_line;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nameTF;
        private System.Windows.Forms.TextBox pwdTF;
        private System.Windows.Forms.TextBox tailleTF;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button button3;
    }
}