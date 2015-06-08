using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS_060_Persistence_Cours
{
    public class Joueurs:List<Joueur>
    {
        public void sauver (string path) {
            XmlSerializer unSerializer = new XmlSerializer(typeof(Joueurs));
            StreamWriter ecrire = new StreamWriter(path, false);
            unSerializer.Serialize(ecrire, this);
            ecrire.Close();
        }

        public static Joueurs recuperer()
        {
            XmlSerializer unSerializer = new XmlSerializer(typeof(Joueurs));
            StreamReader reader = new StreamReader("SauverJoueur.xml");
            Joueurs lesJoueurs = (Joueurs)unSerializer.Deserialize(reader);
            reader.Close();

            return lesJoueurs;
        }
    }
}
