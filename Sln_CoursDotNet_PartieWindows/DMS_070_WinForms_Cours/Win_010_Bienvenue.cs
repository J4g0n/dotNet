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
    public partial class Win_010_Bienvenue : Form
    {
        public Win_010_Bienvenue()
        {
            InitializeComponent();

            this.BackColor = ParametresIHM.CouleurFond;
            this.Text = ParametresIHM.TitreAppli;

            this.Width = 400;
            this.Height = 400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Bienvenue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenue");
        }
    }
}
