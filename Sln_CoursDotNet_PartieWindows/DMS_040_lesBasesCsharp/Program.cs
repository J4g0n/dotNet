using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_040_lesBasesCsharp
{
    class Program
    {
        enum situationFamiliale
        {
            celibataire,
            marie,
            mariee,
            divorce,
            divorcee,
            pacse,
            pacsee,
            veuf, 
            veuve
        }

        static void displayCountries(List<string> listePays)
        {
            foreach (string str in listePays)
            {
                colorierPays(str);
            }
            Console.WriteLine("\n");
        }

        static void colorierPays(string pays)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(pays);
            Console.ResetColor();
        }

        static void Main(string[] args)
        {
            int [] notes = new int[] {1, 9, 15, 7};
            Console.WriteLine("une note : {0}", notes[3]);

            string[] fetes = new string[] { "1", "fiojf" };

            List<string> listePays = new List<string>();
            listePays.Add("France");
            listePays.Add("Allemagne");
            listePays.Add("Italie");
            displayCountries(listePays);

            Console.WriteLine("Something");
            listePays.RemoveAt(1);
            displayCountries(listePays);
            
            Console.ReadKey();
        }
    }
}
