using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_040_lesBasesCSharp_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> lst = new List<double>() { 0.5, 12, 1.8, 10.99 };
            Console.WriteLine(somme(2, 7).ToString());
            Console.WriteLine(moyenne(lst).ToString());
            printList(multiple3et5(60));
            Console.WriteLine(sommeList(multiple3et5(60)).ToString());
            Console.WriteLine(crypt("i need to see my mommy"));
            convert();
            Console.ReadKey();
        }

        static int somme(int dbt, int fin)
        {
            int res = 0;
            for (int i = dbt; i <= fin; i++) res += i;
            return res;
        }

        static int listSize<T>(List<T> l)
        {
            int res = 0;
            foreach (T o in l) {
                res += 1;
            }
            return res;
        }

        static double moyenne(List<double> list)
        {
            double len = (double)listSize(list);
            double sum = list.Sum();

            return sum / len;
        }

        delegate bool PropertyFunction(int x);

        static void printList<T>(List<T> list) 
        {
            foreach (T t in list) Console.Write(t);
            Console.WriteLine();
        }

        static List<int> listFactory(int listSize, List<PropertyFunction> pfs)
        {
            List<int> listInt = new List<int>();
            for (int i = 0; i <= listSize; i++)
            {
                if (pfs.All(pf => pf(i))) listInt.Add(i);
            }
            return listInt;
        }

        static List<int> multiple3et5(int listSize)
        {
            List<PropertyFunction> pfs = new List<PropertyFunction>() { x => x % 3 == 0, x => x % 5 == 0 };
            List<int> listResults = listFactory(listSize, pfs);
            return listResults;
        }

        static double sommeList(List<int> list)
        {
            return list.Sum();
        }

        static string processCrypting(char [] text, Dictionary<char, char> d)
        {
            char[] textProcessed = new char[text.Length];
            Console.WriteLine("BEFORE ");
            char c;
            for (int i = 0; i < text.Length; i++)
            {
                d.TryGetValue(text[i], out c);
                text[i] = c;
            }
            return new string(text);
        }

        static Dictionary<T, U> buildDictionary<T, U>(List<T> alphabet, List<U> encoder)
        {
            List<Tuple<T, U>> translator = alphabet.Zip<T, U, Tuple<T, U>>(encoder, (a, b) => new Tuple<T, U>(a, b)).ToList();
            Dictionary<T, U> dictionary = translator.ToDictionary(x => x.Item1, x => x.Item2);
            return dictionary;
        }

        static string crypt(string text) {
            char [] textToProcess = text.ToCharArray();
            List<char> alphabet = "abcdefghijklmnopqrstuvwxyz ".ToList();
            List<char> coder = "azertyuiopqsdfghjklmwxcvbn_".ToList();
            Dictionary<char, char> dictionary = buildDictionary<char, char>(alphabet, coder);

            return processCrypting(textToProcess, dictionary);
        }

        static string decrypt(string text)
        {
            char[] textToProcess = text.ToCharArray();
            List<char> alphabet = "abcdefghijklmnopqrstuvwxyz ".ToList();
            List<char> coder = "azertyuiopqsdfghjklmwxcvbn_".ToList();
            Dictionary<char, char> dictionary = buildDictionary<char, char>(alphabet, coder);

            return processCrypting(textToProcess, dictionary);
        }

        static int hexaToInt(string hexadecimal)
        {
            char [] symbols = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F'};
            char [] text = hexadecimal.ToCharArray();
            int res = 0;
            for (int i = 0; i < text.Length; i++)
            {
                res = 16 * res + Array.IndexOf(symbols, text[i]);
            }
            return res;
        }

        static int decimalToInt(string decimals)
        {
            char[] numbers = new char[10] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            char[] text = decimals.ToCharArray();
            int res = 0;
            for (int i = 0; i < text.Length; i++)
            {
                res = 10 * res + (int)Char.GetNumericValue(text[i]);
            }
            return res;
        }

        static string intToHexadecimal(int number)
        {
            char[] symbols = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            Stack<char> listRes = new Stack<char>();

            int quotient = number;
            int rest = 0;
            do
            {
                rest = quotient % 16;
                quotient = quotient / 16;
                listRes.Push(symbols[rest]);
            } while (quotient > 0) ;

            return new string(listRes.ToArray());
        }

        static string convertToDecimal(string number) 
        {
            return hexaToInt(number).ToString();
        }

        static string convertToHexadecimal(string number)
        {
            return intToHexadecimal(decimalToInt(number));
        }

        static void convert()
        {
            Console.WriteLine("Entrez un nombre: ");
            string number = Console.ReadLine();
            string res = "";
            Console.WriteLine("Convertir en (H pour hexa, D pour decimal): ");
            string convertTo = Console.ReadLine();

            if (convertTo.Contains('H'))
            {
                res = convertToHexadecimal(number);
            }
            else
            {
                res = convertToDecimal(number);
            }

            Console.WriteLine("Le résultat est: " + res);
        }
    }
}
