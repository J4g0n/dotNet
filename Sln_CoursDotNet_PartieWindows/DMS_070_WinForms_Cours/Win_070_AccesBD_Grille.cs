using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioAccesBD;
using System.Data.SqlClient;

namespace DMS_070_WinForms_Cours
{
    public partial class Win_070_AccesBD_Grille : Form
    {
        public Win_070_AccesBD_Grille()
        {
            InitializeComponent();
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            string requete = "select * from customers;";
            ParametresBD_SQLServer par = new ParametresBD_SQLServer(Program.nomServeur, Program.nomBase);
            SqlDataReader reader = par.ExecuterRequete(requete);

            grid_Customers.Rows.Clear();
            while (reader.Read())
            {
                string [] lignes = {
                    reader["CustomerID"].ToString(),
                    reader["CompanyName"].ToString(),
                    reader["City"].ToString(),
                    reader["Country"].ToString()
                };
                grid_Customers.Rows.Add(lignes);
            }
        }
    }
}
