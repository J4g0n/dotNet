using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_050_POO_Exercices
{

    // Ce programme génère une exception de type stack overflow
    class TestPlantage
    {
        public static int compteur = 0;

        static void Main(string[] args)
        {
            MaClasse c = new MaClasse();
        }
    }

    class MaClasse
    {
        public string nom;
        public SaClasse saClasse;

        public MaClasse()
        {
            TestPlantage.compteur++;
            Console.WriteLine("Creation objet MaClasse n°: " + TestPlantage.compteur);
            saClasse = new SaClasse();
        }
        
    }

    class SaClasse
    {
        public string nom;
        public MaClasse maClasse;

        public SaClasse()
        {
            TestPlantage.compteur++;
            Console.WriteLine("Creation objet SaClasse n°: " + TestPlantage.compteur);
            maClasse = new MaClasse();
        }

    }
}
