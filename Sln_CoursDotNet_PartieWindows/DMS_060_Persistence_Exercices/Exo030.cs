using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_060_Persistence_Exercices
{
    public class Exo030
    {
        static string rootPath = "c:\\";

        static public void main()
        {
            Console.WriteLine(rootPath);
            printFoldersRecursively(rootPath, 1);
        }

        static public void printFoldersRecursively(string path, int depth)
        {
            if (depth >= 5) return;

            try
            {
                string[] directoriesNames = Directory.GetDirectories(path);
                foreach (String s in directoriesNames)
                {
                    for (int i = 0; i < depth; i++) Console.Write("\t");
                    Console.WriteLine(s.Replace(path, ""));
                    printFoldersRecursively(s, depth + 1);
                }
            }
            catch (System.UnauthorizedAccessException e)
            {
                Console.WriteLine("We can't print what is inside this document, it seems that you have no right on it or you may need an authentication: " + e.Message);
            }
        }
    }
}
