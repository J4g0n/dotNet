using BiblioAccesBD;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesBiblioTest
{
    class Program
    {
        static void Main(string[] args)
        {
            ParametresBD_SQLServer par = new ParametresBD_SQLServer("S24POSTE09", "northwind");
            string requeteDeTest = "select * from employees";
            SqlDataReader reader = par.ExecuterRequete(requeteDeTest);

            while (reader.Read())
            {
                Console.WriteLine(reader["LastName"]);
            }

            Console.ReadKey();
        }
    }
}
