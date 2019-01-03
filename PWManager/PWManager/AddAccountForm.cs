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
    public partial class AddAccountForm : Form
    {
        public string Password { get; set; }
        public string AccountName { get; set; }

        public AddAccountForm()
        {
            InitializeComponent();
            Text = "Ajouter un compte";
            separator_line.Height = 2;
        }

        public AddAccountForm(string accountName, string password, bool modif) //used for modifying
        {
            InitializeComponent();
            pwdTF.Text = password;
            nameTF.Text = accountName;
            separator_line.Height = 2;

            if (modif)
            {
                label1.Text = "Nouveau nom de compte : ";
                label2.Text = "Nouveau mot de passe : ";
                Text = "Modifier le compte";
            }
            else
            {
                Text = "Ajouter un compte";
            }
        }

        private string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder res = new StringBuilder();
            Random Rand = new Random();

            while (length > 0)
            {
                res.Append(validChars[Rand.Next(validChars.Length)]);
                length--;
            }

            return res.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(nameTF.Text) || String.IsNullOrWhiteSpace(pwdTF.Text))
            {
                MessageBox.Show("Veuillez remplir les champs 'Nom de compte' et 'Mot de passe'");
            }
            else
            {
                if (!nameTF.Text.Contains(";") && !pwdTF.Text.Contains(";"))
                {
                    DialogResult = DialogResult.OK;
                    Password = pwdTF.Text;
                    AccountName = nameTF.Text;
                    Close();
                }
                else
                {
                    MessageBox.Show("Les champs 'Nom de compte' et/ou 'Mot de passe' contiennent des caractères non-permis");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tailleTF.Text)){
                int parsedValue;
                if (int.TryParse(tailleTF.Text, out parsedValue))
                {
                    pwdTF.Text = GeneratePassword(Convert.ToInt32(tailleTF.Text));
                }
                else
                {
                    MessageBox.Show("Le champ 'Taille' contient des caractères interdits");
                }
            }
            else
            {
                MessageBox.Show("Entrez un nombre valide dans le champ 'Taille'");
            }
        }
    }
}
