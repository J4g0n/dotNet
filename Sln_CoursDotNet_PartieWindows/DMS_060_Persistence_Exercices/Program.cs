using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_060_Persistence_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exo_010();
            //Exo_020();
            Exo_030();

            Console.ReadKey();
        }

        static void Exo_010()
        {
            Exo010.enregistrerPays();
            Exo010.enregistrerVille();
        }

        static void Exo_020()
        {
            Exo020 program = new Exo020();
            program.main();
        }

        static void Exo_030()
        {
            Exo030.main();
        }
    }
}
