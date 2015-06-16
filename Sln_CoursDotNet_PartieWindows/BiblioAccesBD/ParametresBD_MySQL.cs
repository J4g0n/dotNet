using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAccesBD
{
    public class ParametresBD_MySQL : ParametresBD
    {
        public ParametresBD_MySQL(string nomServ, string nomBD)
        {
            NomBD = nomBD;
            NomServeur = nomServ;
            ChaineConnexion = 
                "SERVER=" + NomServeur + ";" + 
                "DATABASE=" + NomBD + ";" + 
                "UID=root;" + 
                "PASSWORD=";
        }

        public MySqlDataReader ExecuterRequeteMySQL(string requete)
        {
            MySqlDataReader donneesRenvoyeesParBD = null;

            try
            {
                MySqlConnection maConnexion = new MySqlConnection();
                MySqlCommand monInstructionSQL;

                maConnexion.ConnectionString = ChaineConnexion;

                maConnexion.Open();
                monInstructionSQL = new MySqlCommand(requete, maConnexion);
                donneesRenvoyeesParBD = monInstructionSQL.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine("Echec de connexion à la base de donnée avec l'erreur: " + e.Message);
            }

            return donneesRenvoyeesParBD;
        }
    }
}
