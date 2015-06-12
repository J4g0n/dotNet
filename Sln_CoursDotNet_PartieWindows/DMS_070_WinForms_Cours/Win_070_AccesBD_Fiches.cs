using BiblioAccesBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_WinForms_Cours
{
    public partial class Win_070_AccesBD_Fiches : Form
    {
        public Win_070_AccesBD_Fiches()
        {
            InitializeComponent();

            this.Text = ParametresIHM.TitreAppli;
            this.BackColor = ParametresIHM.CouleurFond;


        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            string requeteEmploye = 
                "select * from employees where EmployeeID='" + txt_Numero.Text + "';";
            ParametresBD_SQLServer par = new ParametresBD_SQLServer(Program.nomServeur, Program.nomBase);

            SqlDataReader reader = par.ExecuterRequete(requeteEmploye);

            if (reader.Read())
            {
                txt_Prenom.Text = reader["FirstName"].ToString();
                txt_Nom.Text = reader["LastName"].ToString();
            }
            else
            {
                MessageBox.Show("L'employé dont l'identifiant est " + txt_Numero.Text + " n'existe pas dans la base de donnée!");
            }
        }

        private void btn_Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
