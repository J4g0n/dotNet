using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_Exercices
{
    public partial class Exo010 : Form
    {
        private static readonly int nbToGuess = (int)(new Random().NextDouble() * 100);
        private static int nbTries = 0;

        public static int NbTries
        {
            get { return nbTries; }
            set { nbTries = value; }
        }

        public static int NbToGuess
        {
            get { return nbToGuess; }
        } 
        public Exo010()
        {
            InitializeComponent();
        }

        private void btn_Valider_Click(object sender, EventArgs e)
        {
            Exo010.NbTries += 1;
            int nb = Convert.ToInt32(txt_Nombre.Text);
            if (nb == Exo010.NbToGuess)
            {
                lbl_Reponse.Text = "Bravo, vous avez trouvé en " + Exo010.NbTries + " essais";
            }
            else if (nb < Exo010.NbToGuess)
            {
                lbl_Reponse.Text = "Essayez plus !";
            }
            else
            {
                lbl_Reponse.Text = "Essayez moins !";
            }
        }
    }
}
