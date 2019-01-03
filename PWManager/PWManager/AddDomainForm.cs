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
    public partial class AddDomainForm : Form
    {
        public string domainName {get; set;}

        public AddDomainForm()
        {
            InitializeComponent();
        }

        public AddDomainForm(string Title, string label)
        {
            InitializeComponent();
            Text = Title;
            label1.Text = label;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(textBox1.Text))
            {
                domainName = textBox1.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Le nom de domaine ne peut pas être vide ou composé d'espaces blancs");
            }
        }
    }
}
