using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_060_Persistence_Exercices
{
    public class Exo040
    {
        static public void testReadDB()
        {
            string requete = "select * from Customers;";

            SqlDataReader reader = ParametresBD.ExecuterRequete(requete);

            while (reader.Read()) Console.WriteLine(reader.GetString(1));
        }

        static public void testWriteDB()
        {
            string codeClient = "ZZZZZ";
            string nmClient = "Zonzon";
            string requete =
                "insert into Customers (" +
                    "CustomerID," +
                    "CompanyName" +
                ") values (" +
                    "'" + codeClient + "'," +
                    "'" + nmClient + "'" +
                ");";

            int retour = ParametresBD.MajBD(requete);

            if (retour == -1)
            {
                Console.WriteLine("Une erreur s'est produite lors de la requete!");
            }
            else
            {
                Console.WriteLine("La requete s'est bien déroulé, " + retour + " lignes modifiées!");
            }
        }

        static public void testGenericSerializationFromDB()
        {
            List<EmployeeTerritories> empTerr = ParametresBD.ListObjects<EmployeeTerritories>();

            foreach (EmployeeTerritories et in empTerr)
            {
                Console.WriteLine(et.EmployeeID + " and " + et.TerritoryID);
            }
        }
    }

    public class EmployeeTerritories
    {
        private string employeeID;
        private string territoryID;

        public string EmployeeID
        {
            get;
            set;
        }

        public string TerritoryID
        {
            get;
            set;
        }
    }
}
