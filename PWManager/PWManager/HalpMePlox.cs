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
    public partial class HalpMePlox : Form
    {
        private int count = 1;
        private List<string> listExplanations = new List<string>();
        public HalpMePlox()
        {
            InitializeComponent();
            pictureBox.Image = Image.FromFile("../../res/Help1.png");
            listExplanations.Add("Un domaine est le nom du site ou de l'application pour laquelle vous désirez enregistrer des comptes.\nPour ajouter un domaine, cliquez sur le bouton indiqué par la flèche.");
            listExplanations.Add("Entrez le nom que vous souhaitez donner au domaine et appuyez sur la touche \"OK\" pour valider \nou \"Annuler\" pour quitter sans créer de nouveau domaine.");
            listExplanations.Add("Pour ajouter un compte à un domaine, soyez bien sûr d'avoir sélectionné le domaine en question (il sera surligné en bleu)\net cliquez ensuite sur le bouton \"Ajouter un compte\"");
            listExplanations.Add("Entrez le nom de compte que vous souhaitez enregistrer ainsi que le mot de passe qui lui est lié dans les champs\nqui y sont réservés (ils ne peuvent pas être vide) et appuyez ensuite sur \"OK\" pour valider et ajouter le compte\nou sur \"Annuler\" pour fermer la fenêtre sans ajouter de compte.");
            listExplanations.Add("Alternativement, vous pouvez aussi générer un mot de passe de la taille que vous voulez.\nPour ce faire, indiquez une taille valide dans le champ \"Taille\" et cliquez sur \"Générer\".");
            listExplanations.Add("Pour sauvegarder vos domaines et les comptes qui y sont liés, \ncliquez sur l'onglet \"Fichier\" et cliquez ensuite sur \"Enregistrer\".");
            listExplanations.Add("Pour charger les domaines et les comptes qui y sont liés que vous avez préalablement sauvegardé\ncliquez sur l'onglet \"Fichier\" et cliquez ensuite sur \"Charger\".");

            Explanations.Text = listExplanations[count - 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (count < 7)
                count++;

            string Path = "../../res/Help" + count + ".png"; //Might need to rethink that
            pictureBox.Image = Image.FromFile(Path);
            Explanations.Text = listExplanations[count-1];
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (count > 1)
                count--;
            string Path = "../../res/Help" + count + ".png";
            pictureBox.Image = Image.FromFile(Path);
            Explanations.Text = listExplanations[count-1];
        }
    }
}
