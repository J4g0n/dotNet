using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DMS_060_Persistence_Exercices
{
    public class Exo020:ReadWriteFromFile<List<Participant>>
    {
        static string pathToFile = "C:\\Users\\ipi\\Desktop\\";
        static string fileNameParticipants = "participants.xml";

        public Exo020()
            : base(pathToFile + fileNameParticipants)
        {
            StreamWriter write = new StreamWriter(pathToFile + fileNameParticipants);
            serializer.Serialize(write, new List<Participant>());
            write.Close();
        }

        public void main()
        {
            char input = ' ';
            while (input != 'Q')
            {
                Console.WriteLine("Souhaitez vous: \n 1) lister les participants (tapez L) \n 2) Enregistrer des participants (tapez E) \n 3) Verifier qu'un participant est inscrit à la course (tapez V) \n Quitter (tapez Q)");
                input = Console.ReadKey().KeyChar;

                switch (input)
                {
                    case 'V': verifier(); break;
                    case 'E': enregistrer(); break;
                    case 'L': lister(); break;
                    default: Console.WriteLine("Traitement inconnu... réessayez."); break;
                }
            }
        }

        public void verifier()
        {
            List<Participant> lst = readFromFile();
            Console.WriteLine("Entrer le nom d'un participant");
            string Nom = Console.ReadLine();
            bool b = false;

            foreach (Participant p in lst) {
                if (p.Nom == Nom) {
                    b = true;
                    break;
                }
            }

            if (b)
            {
                Console.WriteLine(Nom + " participe à la course");
            }
            else
            {
                Console.WriteLine(Nom + " ne participe pas à la course");
            }
        }

        public void enregistrer()
        {
            char input = ' ';
            while (input != 'Q')
            {
                Participant p = new Participant();
                Console.WriteLine("Entrer le nom");
                p.Nom = Console.ReadLine();
                Console.WriteLine("Entrer le prenom");
                p.Prenom = Console.ReadLine();

                // TODO we could improve this by only add one participant at the end of the file
                List<Participant> lst = readFromFile();
                lst.Add(p);
                writeToFile(lst);
                Console.WriteLine("Tapez Q pour terminer");
                input = Console.ReadKey().KeyChar;
            }
        }

        public void lister()
        {
            List<Participant> lst = readFromFile();
            foreach (Participant p in lst) Console.WriteLine(p.Nom + " " + p.Prenom);
        }
    }

    public class Participant
    {
        [XmlAttribute()]
        public string Nom { get; set; }
        [XmlAttribute()]
        public string Prenom { get; set; }
    } 
}
