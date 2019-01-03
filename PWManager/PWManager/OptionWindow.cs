using PWManager.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWManager
{
    public partial class OptionWindow : Form
    {
        public PropertiesManager Config { get; set; }

        public OptionWindow(PropertiesManager config)
        {
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(432, 171);
            LanguageLabel.Hide(); //for now
            LanguageCB.Hide();
            Config = config;
            LanguageCB.Items.Add("Français");
            LanguageCB.SelectedIndex = 0; //Convert.ToInt32(Config.get("LANGUAGE"));
            SaveDirectoryTB.Text = Config.get("FILE_PATH");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Config.set("FILE_PATH", SaveDirectoryTB.Text);
            Config.Save("properties.dat");
            DialogResult = DialogResult.OK;
            Close();
        }

        private void fileDialogButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                if(fbd.SelectedPath.Substring(fbd.SelectedPath.Length - "\\PWManager".Length).Equals("\\PWManager"))
                {
                    SaveDirectoryTB.Text = fbd.SelectedPath;
                }
                else
                {
                    SaveDirectoryTB.Text = fbd.SelectedPath + "\\PWManager";
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
