using BiblioAccesBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DMS_070_Exercices
{
    public partial class Exo060 : Form
    {
        public string photosPath =
                "C:\\Users\\ipi\\Desktop\\dotNet\\Sln_CoursDotNet_PartieWindows\\DMS_070_Exercices\\ressources\\photos\\";
        public ParametresBD bd;

        public Exo060()
        {
            InitializeComponent();

            bd = new ParametresBD_SQLServer("S24POSTE09", "BDContacts");
            SqlDataReader reader = bd.ExecuterRequete("select * from contacts;");

            while (reader.Read())
            {
                lst_Personnes.Items.Add(reader.GetInt32(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }
        }

        private void lst_Personnes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = (string) lst_Personnes.SelectedItem;
            string contactId = str.Split(' ')[0];
            string requete = "select photo from contacts where id like " + contactId + ";";

            SqlDataReader reader = bd.ExecuterRequete(requete);
            if (reader.Read())
            {
                pbox_Photo.Image = new Bitmap(photosPath + reader.GetString(0) + ".gif");
            }
        }
    }
}
