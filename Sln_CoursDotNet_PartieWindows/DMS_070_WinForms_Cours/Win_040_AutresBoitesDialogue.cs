using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_WinForms_Cours
{
    public partial class Win_040_AutresBoitesDialogue : Form
    {
        public Win_040_AutresBoitesDialogue()
        {
            InitializeComponent();
        }

        private void btn_SelecteurFichier_Click(object sender, EventArgs e)
        {
            if (SelecteurFichier.ShowDialog() == DialogResult.OK)
            {
                img_Article.Image = new Bitmap(SelecteurFichier.FileName);
            }
        }

        private void btn_ChoisirCouleur_Click(object sender, EventArgs e)
        {
            if (SelecteurCouleur.ShowDialog() == DialogResult.OK)
            {
                lbl_Couleur.BackColor = SelecteurCouleur.Color;
            }
        }

        private void Win_040_AutresBoitesDialogue_Load(object sender, EventArgs e)
        {

        }
    }
}
