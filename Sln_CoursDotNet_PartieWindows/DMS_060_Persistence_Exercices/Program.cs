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
            //Exo_040();
            //Exo_050();

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

        static void Exo_040()
        {
            Exo040.testReadDB();
            Exo040.testWriteDB();
            Exo040.testReadDB();
        }

        static void Exo_050()
        {
            Exo050.main();
        }
    }
}
