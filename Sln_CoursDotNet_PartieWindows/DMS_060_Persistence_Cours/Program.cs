using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS_060_Persistence_Cours
{
    class Program
    {
        private const string filePath = "SauverJoueur.xml";

        static void Main(string[] args)
        {
            //Joueur j = new Joueur()
            //{
            //    Nom = "Zidane",
            //    Prenom = "Zinedine",
            //    Address = "Avda. de concha Madrid"
            //};

            //XmlSerializer unSerializer = new XmlSerializer(typeof(Joueur));
            //StreamWriter ecrire = new StreamWriter("SauverJoueur.xml");
            //unSerializer.Serialize(ecrire, j);
            //ecrire.Close();


            //XmlSerializer unSerializer = new XmlSerializer(typeof(Joueur));
            //StreamReader reader = new StreamReader("SauverJoueur.xml");
            //Joueur joueurRecupere = (Joueur) unSerializer.Deserialize(reader);
            //Console.WriteLine("Joueur {0} {1}", joueurRecupere.Prenom, joueurRecupere.Nom);
            //reader.Close();

            //Joueurs desJoueurs = null;

            //if (File.Exists(filePath))
            //{
            //    desJoueurs = Joueurs.recuperer();
            //    foreach (Joueur jr in desJoueurs) Console.WriteLine("Joueur {0} {1}", jr.Prenom, jr.Nom);
            //}
            //else
            //{
            //    desJoueurs = new Joueurs();
            //    desJoueurs.Add(new Joueur() { Nom = "Messi", Prenom = "Lionel" });
            //    desJoueurs.Add(new Joueur() { Nom = "Ronaldo", Prenom = "Cristiano" });
            //    desJoueurs.Add(new Joueur() { Nom = "Pogba", Prenom = "Paul" });
            //    desJoueurs.Add(new Joueur() { Nom = "Carlos", Prenom = "Roberto" });
            //    desJoueurs.Add(new Joueur() { Nom = "Ibrahimovic", Prenom = "Zlatan" });
            //    desJoueurs.sauver(filePath);
            //}

            //int nbrePresidents = 0;
            //string ligneLue;

            //StreamReader lecteur = new StreamReader(@"PresidentsFrancais.txt");
            //while((ligneLue = lecteur.ReadLine()) != null) {
            //    string[] infoPresidents = ligneLue.Split(new char[] { ';' });
            //    Console.WriteLine("President {0} {1}", infoPresidents[0], infoPresidents[1]);
            //    nbrePresidents++;
            //}
            //Console.WriteLine("{0} présidents affichés", nbrePresidents);


            //StreamWriter writer = new StreamWriter(@"Celebrities.txt");
            //writer.WriteLine("Michael;Jackson");
            //writer.Close();


            /* 5) Persistence de données
             * Accès aux BDR via ADO.Net
             */

            //string demandeListeClients = "Select * from Customers;";
            //SqlConnection maConnexion = new SqlConnection();
            //SqlCommand monInstructionSQL;
            //SqlDataReader donneesRenvoyeesParBD;

            //maConnexion.ConnectionString = ParametresBD.ChaineConnexionNorthwind;
            //maConnexion.Open();

            //if (maConnexion.State == ConnectionState.Open)
            //{
            //    Console.WriteLine("Ca marche!!");
            //    monInstructionSQL = new SqlCommand(demandeListeClients, maConnexion);
            //    donneesRenvoyeesParBD = monInstructionSQL.ExecuteReader();
            //    while (donneesRenvoyeesParBD.Read())
            //    {
            //        Console.WriteLine(donneesRenvoyeesParBD.GetString(0));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Echec de connexion à la base de donnée");
            //}

            /*
             *  
             */

            SqlConnection maConnexion = new SqlConnection();
            SqlCommand monInstructionSQL;
            maConnexion.ConnectionString = ParametresBD.ChaineConnexionNorthwind;

            string codeClient = "DUPON";
            string nmClient = "Dupont";
            string requete =
                "insert into Customers (" +
                    "CustomerID," +
                    "CompanyName" +
                ") values (" +
                    "'" + codeClient + "'," +
                    "'" + nmClient + "'" +
                ");";

            try
            {
                maConnexion.Open();

                monInstructionSQL = new SqlCommand(requete, maConnexion);
                monInstructionSQL.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine("Problème lors de la base de donnée à échouée: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
