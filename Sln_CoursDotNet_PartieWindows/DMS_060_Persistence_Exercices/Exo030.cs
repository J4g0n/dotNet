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
            string [] directoriesNames = Directory.GetDirectories(rootPath);
            foreach (String s in directoriesNames) Console.WriteLine(s);
        }
    }
}
