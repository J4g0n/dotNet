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
    public partial class Win_030_Menus : Form
    {
        public Win_030_Menus()
        {
            InitializeComponent();

            this.BackColor = ParametresIHM.CouleurFond;
            this.Text = ParametresIHM.TitreAppli;

        }

        private void formationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void opt_Quitter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quitter");
        }

        private void opt_Gerer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gérer");
        }

        private void opt_Imprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimer");
        }
    }
}
