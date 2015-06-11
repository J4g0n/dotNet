using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
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

        public static List<T> ListObjects<T>()
        {
            Type type = typeof(T);
            ConstructorInfo constructor = type.GetConstructor(Type.EmptyTypes);

            SqlDataReader datas = ExecuterRequete("select * from " + type.Name + ";");
            List<T> resultList = new List<T>();
            while (datas.Read())
            {
                T instance = (T)Activator.CreateInstance(type);
                for (int i = 0; i < datas.FieldCount; i++)
                {
                    PropertyInfo prop = instance.GetType().GetProperty(datas.GetName(i), BindingFlags.Public | BindingFlags.Instance);
                    if (null != prop && prop.CanWrite)
                    {
                        string value = "";
                        switch (datas.GetFieldType(i).Name)
                        {
                            case "Int32": value = (string)datas.GetInt32(i).ToString(); break;
                            case "String": value = datas.GetString(i); break;
                            default: break;
                        }
                        
                        prop.SetValue(instance, value, null);
                    }
                }
                resultList.Add(instance);
            }

            return resultList;
        }
    }
}
