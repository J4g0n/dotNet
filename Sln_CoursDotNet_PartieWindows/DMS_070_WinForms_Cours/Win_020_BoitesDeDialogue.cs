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
    public partial class Win_020_BoitesDeDialogue : Form
    {
        public Win_020_BoitesDeDialogue()
        {
            InitializeComponent();

            this.BackColor = ParametresIHM.CouleurFond;
            this.Text = ParametresIHM.TitreAppli;

            this.Width = 400;
            this.Height = 400;
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Messages_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Message Info", ParametresIHM.TitreAppli);
            //DialogResult d = MessageBox.Show("Facturation terminée", "titre", MessageBoxButtons.OKCancel);
            //switch (d) {
            //    case DialogResult.Cancel: MessageBox.Show("Clic sur Annuler"); break;
            //    case DialogResult.OK: MessageBox.Show("Clic sur OK"); break;
            //    default: break;
            //}

            MessageBox.Show("Message", "titre", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
