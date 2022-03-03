using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuDuPendu
{
    public partial class Form1 : Form
    {
        
        string[] tabMots = new string[10] { "adherente", "coktail", "delation", "dahlia", "nationale",
        "rafteur", "macchabee", "schlitteur","talquer","twister" };

        string motADeviner;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int generePlace()
        {
            Random rnd = new Random();
            int pos = rnd.Next(0, 10);
            return pos;
        }

        public string choixDuMot()
        {
            int endroit = generePlace();
            string motChoisi = tabMots[endroit];
            return motChoisi;
        }

        public void genererJeu()
        {
            int position = generePlace();
            motADeviner = tabMots[position];
            char lettres = motADeviner[0];
            char derniereLettre = motADeviner[motADeviner.Length - 1];
            string proposition = txtProposition.Text;
            int left = 0;
            int top = 20;
            int nbElements = motADeviner.Length;

            for (int i = 0; i < nbElements; i++)
            {
                Label lblPendu = new Label();
                lblPendu.Tag = i;
                int emplacement = (int)lblPendu.Tag;
                if (emplacement == 0)
                {
                    lblPendu.Text = lettres.ToString();
                }

                if (emplacement == nbElements - 1)
                {
                    lblPendu.Text = derniereLettre.ToString();
                }

                lblPendu.Size = new System.Drawing.Size(50, 20);
                lblPendu.Left = left;
                lblPendu.Top = top;
                lblPendu.BackColor = Color.White;
                pnlMot.Controls.Add(lblPendu);
                left += 80;

            }
        }

        public void verifLettres()
        {
            int elementsDuMot = motADeviner.Length;
            char propJoueur = txtProposition.Text[0];
          

            for (int i = 0; i < elementsDuMot; i++)
            {
                if (motADeviner[i] == propJoueur)
                {
                    Label lbl = (Label)pnlMot.Controls[i];
                    lbl.Text = propJoueur.ToString();
                }

                else
                {
                    for (int j = 1; j < 9; j++)
                    {
                        PictureBox pbPendu = new PictureBox();
                        pbPendu.Image = Image.FromFile(@"C:\Users\Océane\source\repos\JeuDuPendu\images\" + j.ToString() + ".png");
                        pbPendu.Location = new System.Drawing.Point(350, 10);
                        pbPendu.Size = new System.Drawing.Size(242, 258);
                        pnlImage.Controls.Add(pbPendu);
                    }
                }
            }

            txtProposition.Clear();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genererJeu();

        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Êtes-vous sûr de recommencer ?", "Recommencer", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                MessageBox.Show("Je suis bloquée je ne sais pas comment faire, à l'aide !");
            
            }

        }

        private void txtProposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtProposition.MaxLength = 1;
            if (e.KeyChar == 13 && txtProposition.TextLength != 0)
            {
                verifLettres();
            }

            else if (char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            txtProposition.Clear();



        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)pnlMot.Controls[1];
            lbl.Text = motADeviner[1].ToString();
        }
    }
}