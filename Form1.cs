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

        public string recupererMot()
        {
            int position = generePlace();
            string motADeviner = tabMots[position];
            return motADeviner;
        }

        public void constructionMot()
        {
            string motChoisi = recupererMot();
            char[] lettres = new char[motChoisi.Length];
            motChoisi.Split();
            for (int i = 0; i < motChoisi.Length; i++)
            {
                MessageBox.Show(motChoisi.Split().ToString());

            }

        }
    }
}
