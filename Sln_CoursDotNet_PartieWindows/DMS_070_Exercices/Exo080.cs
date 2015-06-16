using BiblioAccesBD;
using MySql.Data.MySqlClient;
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

namespace DMS_070_Exercices
{
    public partial class Exo080 : Form
    {
        ParametresBD_MySQL bd = new ParametresBD_MySQL("localhost", "gestionpersonnel");

        public Exo080()
        {
            InitializeComponent();
        }

        private void btn_Rechercher_Click(object sender, EventArgs e)
        {
            string id = txt_ID.Text;
            string requete = "select email, telephone from Salaries where id=" + id + ";";
            MySqlDataReader reader = bd.ExecuterRequeteMySQL(requete);

            try
            {
                if (reader.Read())
                {
                    lbl_Email.Text = reader.GetString(0);
                    lbl_Telephone.Text = reader.GetString(1);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
