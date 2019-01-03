using PWManager.classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWManager
{
    public partial class MainWindow : Form
    {
        private BindingList<Domain> DomainList { get; set; }
        private BindingList<string> AccountList { get; set; } //Is refreshed each time you select a different domain
        private PropertiesManager Config { get; set; }
        private Boolean UnsavedModifications { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            InitializeInternalComponents();
        }

        private void InitializeInternalComponents()
        {
            DomainList = new BindingList<Domain>();
            AccountList = new BindingList<string>();
            //DATABINDING
            DomainListbox.DataSource = DomainList;
            AccountListbox.DataSource = AccountList;
            //PROPERTIES HANDLING
            Config = new PropertiesManager("properties.dat");
            //MISCELLANOUS
            this.MinimumSize = new System.Drawing.Size(990, 761);
            separator_line.Height = 2;
            statusLabel.Text = "";
            DisableDomainButtons();
            DisableAccountButtons();
            AddAccountButton.Enabled = false;
            UnsavedModifications = false;
        }

        #region DOMAIN RELATED FUNCTIONS

        private void AddDomainButton_Click(object sender, EventArgs e)
        {
            AddDomainForm form = new AddDomainForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                Boolean ok = true;

                foreach(Domain d in DomainList)
                {
                    if (d.Name.Equals(form.domainName))
                    {
                        ok = false;
                    }
                } 
                
                if(DomainList.Count == 0 || ok)
                {
                    DomainList.Add(new Domain(form.domainName));
                    //DomainListbox_SelectedIndexChanged(this, null);
                    statusLabel.Text = "Le domaine \"" + form.domainName + "\" a été ajouté";
                    EnableDomainButtons();
                    AddAccountButton.Enabled = true;
                    UnsavedModifications = true;
                    DomainListbox.SelectedIndex = DomainList.Count - 1; //Set focus on last domain
                }
                else
                {
                    MessageBox.Show("Le domaine \"" + form.domainName + "\" existe déjà !", "Erreur", MessageBoxButtons.OK);
                    statusLabel.Text = "Le domaine \"" + form.domainName + "\" existe déjà !";
                }
            }
        }

        private void DelDomainButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Le domaine \"" + ((Domain)DomainListbox.SelectedValue).Name + "\" a été supprimé";
            DomainList.Remove(DomainList[DomainListbox.SelectedIndex]);
            UnsavedModifications = true;
        }

        private void ModDomainButton_Click(object sender, EventArgs e)
        {
            if(DomainListbox.SelectedIndex > -1)
            {
                AddDomainForm form = new AddDomainForm("Modifier un domaine", "Nouveau nom de domaine : ");
                if(form.ShowDialog() == DialogResult.OK)
                {
                    statusLabel.Text = "Le domaine \"" + ((Domain)DomainListbox.SelectedValue).Name + "\" a été modifié en \"" + form.domainName + "\"";
                    DomainList[DomainListbox.SelectedIndex].Name = form.domainName;
                    UnsavedModifications = true;
                }
            }
        }

        private void DomainListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DomainListbox.SelectedIndex >= 0)
            {
                Domain d = DomainList[DomainListbox.SelectedIndex];
                if (d != null)
                {
                    AccountList = d.ListAccount;
                    AccountListbox.DataSource = AccountList;
                    if (AccountList.Count == 0)
                        AccountListbox_SelectedIndexChanged(this, null); //Force the update of buttons when the list is empty and you come from a list with elements in it
                    EnableDomainButtons();
                    AddAccountButton.Enabled = true;
                }
            }
            else
            {
                DisableDomainButtons();
                DisableAccountButtons();
                AddAccountButton.Enabled = false;
            }    
        }

        #endregion

        #region ACCOUNT RELATED FUNCTIONS

        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            AddAccountForm form = new AddAccountForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                AccountList.Add(form.AccountName + ";" + form.Password);
                statusLabel.Text = "Un compte a été ajouté au domaine \"" + ((Domain)DomainListbox.SelectedValue).Name + "\"";
                EnableAccountButtons();
                UnsavedModifications = true;
            }
        }

        private void DelAccountButton_Click(object sender, EventArgs e)
        {
            AccountList.Remove((string)AccountListbox.SelectedValue);
            statusLabel.Text = "Un compte du domaine \"" + ((Domain)DomainListbox.SelectedValue).Name + "\" a été supprimé";
            UnsavedModifications = true;
        }

        private void ModAccountButton_Click(object sender, EventArgs e)
        {
            string item = (string)AccountListbox.SelectedValue;
            string[] values = item.Split(';');

            AddAccountForm form = new AddAccountForm(values[0], values[1], true);
            if (form.ShowDialog() == DialogResult.OK)
            {
                var listItem = AccountList.IndexOf(item);
                AccountList[listItem] = form.AccountName + ";" + form.Password;
                statusLabel.Text = "Un compte du domaine \"" + ((Domain)DomainListbox.SelectedValue).Name + "\" a été modifié";
                UnsavedModifications = true;
            }
        }

        #endregion

        #region TOOLSTRIP FUNCTIONS

        private void sauvegarderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DomainList.Count > 0)
            {
                FileManager fm = new FileManager(DomainList, Config.get("FILE_PATH"));
                fm.WriteDomains();
                fm.WriteAccounts();
                statusLabel.Text = "Sauvegarde réussie";
                UnsavedModifications = false;
            }
            else
            {
                MessageBox.Show("Il n'y a rien à enregistrer !");
            }
        }

        private void chargerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileManager fm = new FileManager(DomainList, Config.get("FILE_PATH"));
            DomainList = fm.ReadDomains();
            DomainListbox.DataSource = DomainList;
            statusLabel.Text = "Chargement réussi";
        }

        private void aideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HalpMePlox f = new HalpMePlox();
            f.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OptionWindow ow = new OptionWindow(Config);
            ow.Show();
        }

        #endregion

        private void DisableDomainButtons()
        {
            DelDomainButton.Enabled = false;
            ModDomainButton.Enabled = false;
        }

        private void DisableAccountButtons()
        {
            DelAccountButton.Enabled = false;
            ModAccountButton.Enabled = false;
        }

        private void EnableDomainButtons()
        {
            DelDomainButton.Enabled = true;
            ModDomainButton.Enabled = true;
        }

        private void EnableAccountButtons()
        {
            DelAccountButton.Enabled = true;
            ModAccountButton.Enabled = true;
        }

        private void SortDESCButton_Click(object sender, EventArgs e)
        {
            DomainList = new BindingList<Domain>(DomainList.OrderByDescending(x => x.Name).ToList());
            DomainListbox.DataSource = DomainList;
            UnsavedModifications = true;
        }

        private void SortASCButton_Click(object sender, EventArgs e)
        {
            DomainList = new BindingList<Domain>(DomainList.OrderBy(x => x.Name).ToList());
            DomainListbox.DataSource = DomainList;
            UnsavedModifications = true;
        }

        private void AccountListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(AccountListbox.SelectedIndex >= 0)
            {
                EnableAccountButtons();

                string[] items = ((string)AccountListbox.SelectedValue).Split(';');
                AccountTextbox.Text = items[0];
                PasswordTextbox.Text = items[1];
            }
            else
            {
                DisableAccountButtons();
            }
        }

        private void changeLanguage(int indexLanguage)
        {
            string culture;

            switch (indexLanguage)
            {
                //case 1: culture = "en"; break;
                case 0: 
                default: culture = "fr"; break;
            }

            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(MainWindow));
                resources.ApplyResources(c, c.Name, new CultureInfo(culture));
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (UnsavedModifications)
            {
                var result = MessageBox.Show("Vous avez des modifications non-enregistrées, souhaitez-vous tout de même fermer le programme?", "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                e.Cancel = (result == DialogResult.Cancel);
            }
        }
    }
}
