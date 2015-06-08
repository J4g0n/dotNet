using System;
using System.Collections.Generic;
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

            Joueurs desJoueurs = null;

            if (File.Exists(filePath))
            {
                desJoueurs = Joueurs.recuperer();
                foreach (Joueur jr in desJoueurs) Console.WriteLine("Joueur {0} {1}", jr.Prenom, jr.Nom);
            }
            else
            {
                desJoueurs = new Joueurs();
                desJoueurs.Add(new Joueur() { Nom = "Messi", Prenom = "Lionel" });
                desJoueurs.Add(new Joueur() { Nom = "Ronaldo", Prenom = "Cristiano" });
                desJoueurs.Add(new Joueur() { Nom = "Pogba", Prenom = "Paul" });
                desJoueurs.Add(new Joueur() { Nom = "Carlos", Prenom = "Roberto" });
                desJoueurs.Add(new Joueur() { Nom = "Ibrahimovic", Prenom = "Zlatan" });
                desJoueurs.sauver(filePath);
            }

            Console.ReadKey();
        }
    }
}
