using DMS_050_POO_Exercices_Animaux;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_050_POO_Exercices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> lstAnimal = new List<Animal>();
            Crocodile c = new Crocodile();
            Requin r = new Requin();
            Ours o = new Ours();

            lstAnimal.Add(c);
            lstAnimal.Add(r);
            lstAnimal.Add(o);

            foreach (Animal a in lstAnimal) a.Manger();
            Console.ReadKey();
        }
    }
}
