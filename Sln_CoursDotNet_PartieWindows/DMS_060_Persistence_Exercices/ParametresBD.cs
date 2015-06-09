using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_060_Persistence_Exercices
{
    public class ParametresBD
    {
        private readonly static string nomBD = "northwind";
        private readonly static string nomServeur = "S24POSTE09";
        private readonly static string chaineConnexionNorthwind =
            "integrated security = SSPI;" +
            "data source = " + nomServeur + ";" +
            "persist security info = false;" +
            "initial catalog = " + nomBD;

        public static string ChaineConnexionNorthwind
        {
            get { return ParametresBD.chaineConnexionNorthwind; }
        }

        public static SqlDataReader ExecuterRequete(string requete)
        {
            SqlConnection maConnexion = new SqlConnection();
            SqlCommand monInstructionSQL;
            SqlDataReader donneesRenvoyeesParBD = null;

            maConnexion.ConnectionString = ParametresBD.ChaineConnexionNorthwind;
            
            try {
                maConnexion.Open();
                monInstructionSQL = new SqlCommand(requete, maConnexion);
                donneesRenvoyeesParBD = monInstructionSQL.ExecuteReader();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Echec de connexion à la base de donnée avec l'erreur: " + e.Message);
            }

            return donneesRenvoyeesParBD;
        }

        public static int MajBD(string action) 
        {
            SqlConnection maConnexion = new SqlConnection();
            SqlCommand monInstructionSQL;
            maConnexion.ConnectionString = ParametresBD.ChaineConnexionNorthwind;
            int error = -1;

            try
            {
                maConnexion.Open();

                monInstructionSQL = new SqlCommand(action, maConnexion);
                return monInstructionSQL.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Problème lors de la base de donnée à échouée: " + e.Message);
            }

            return error;
        }
    }
}
