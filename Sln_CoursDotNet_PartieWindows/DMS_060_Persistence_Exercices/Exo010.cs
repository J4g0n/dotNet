using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS_060_Persistence_Exercices
{
    public class Exo010
    {
        static string pathToFile = "C:\\Users\\ipi\\Desktop\\";
        static string readFileNamePays = "pays.csv";
        static string readFileNameVilleFrance = "villes_france.csv";
        static string writeFileNamePays = "Pays.xml";
        static string writeFileNameVilleFrance = "VillesFrance.xml";

        public Exo010()
        {

        }

        public static void enregistrerPays()
        {
            string lineRead;
            StreamReader reader = new StreamReader(pathToFile + readFileNamePays);
            List<Pays> pays = new List<Pays>();
            Pays paysTemp;
            while ((lineRead = reader.ReadLine()) != null)
            {
                string[] infoPays = lineRead.Replace("\"", "").Split(new char[] { ',' });
                paysTemp = new Pays();
                paysTemp.NomAnglais = infoPays[5];
                paysTemp.NomFrancais = infoPays[4];
                paysTemp.Code = infoPays[3];
                pays.Add(paysTemp);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Pays>));
            StreamWriter write = new StreamWriter(pathToFile + writeFileNamePays);
            serializer.Serialize(write, pays);
            write.Close();
        }

        public static void enregistrerVille()
        {
            string lineRead;
            StreamReader reader = new StreamReader(pathToFile + readFileNameVilleFrance);
            List<VilleFrance> pays = new List<VilleFrance>();
            VilleFrance villeTemp;
            while ((lineRead = reader.ReadLine()) != null)
            {
                string[] infoVille = lineRead.Replace("\"", "").Split(new char[] { ',' });
                villeTemp = new VilleFrance();
                villeTemp.Nom = infoVille[2];
                villeTemp.CodePostal = infoVille[8];
                villeTemp.Departement = infoVille[1];
                villeTemp.CodeVille = infoVille[0];
                pays.Add(villeTemp);
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<VilleFrance>));
            StreamWriter write = new StreamWriter(pathToFile + writeFileNameVilleFrance);
            serializer.Serialize(write, pays);
            write.Close();
        }
    }

    public class Pays
    {
        [XmlAttribute()]
        public string Code { get; set; }
        [XmlAttribute()]
        public string NomFrancais { get; set; }
        [XmlAttribute()]
        public string NomAnglais { get; set; }
    }

    public class VilleFrance
    {
        [XmlAttribute()]
        public string CodePostal { get; set; }
        [XmlAttribute()]
        public string Nom { get; set; }
        [XmlAttribute()]
        public string Departement { get; set; }
        [XmlAttribute()]
        public string CodeVille { get; set; }
    }
}
