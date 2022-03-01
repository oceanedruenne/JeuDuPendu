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

        public string recupererMot()
        {
            int position = generePlace();
            string motADeviner = tabMots[position];
            char lettres = motADeviner[0];
            char derniereLettre = motADeviner[motADeviner.Length - 1];
            int left = 20;
            int top = 10;
            int nbElements = motADeviner.Length;

            for (int i = 0; i < nbElements; i++)
            {
                TextBox txtBox = new TextBox();
                txtBox.Tag = i;
                int emplacement = (int)txtBox.Tag;
                if (emplacement == 0)
                {
                    txtBox.Text = lettres.ToString();
                }

                if (emplacement == nbElements - 1)
                {
                    txtBox.Text = derniereLettre.ToString();
                }

                txtBox.Size = new System.Drawing.Size(50, 10);
                txtBox.Left = left;
                txtBox.Top = top;
                pnlMot.Controls.Add(txtBox);
                left += 80;
            }
            return motADeviner;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            recupererMot();


        }

        private void btnRecommencer_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in pnlMot.Controls.OfType<TextBox>())
            {
                txt.Clear();
            }

        }

        private void txtProposition_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 10 || e.KeyChar == 13)
            {
                e.Handled = false;
            }

        }
    }
}