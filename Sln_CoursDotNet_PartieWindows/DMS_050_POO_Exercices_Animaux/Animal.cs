using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_050_POO_Exercices_Animaux
{
    public class Animal
    {
        int poids;
        String color;

        public virtual void Manger()
        {
            Console.Write("Mange ");
        }
    }

    public class Vertebre:Animal
    {
        int nbVertebre = 0;
    }

    public class Invertebre:Animal
    {
        double taille = 0;
    }

    public class Insecte : Invertebre
    {
        int nbPattes = 0;
    }

    public class Abeille : Insecte
    {
        String role;
    }

    public class Mollusque : Invertebre
    {
        bool vieDansLaMer;
    }

    public class Calamar : Mollusque
    {
        int nbTentacules;
    }

    public class Mammifere : Vertebre
    {
        bool estCarnivore;
    }

    public class Tigre : Mammifere
    {
        bool estEnVoieDeDisparition = true;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("des animaux qu'il trouve, et occasionnellement des hommes");
        }
    }

    public class Ours : Mammifere
    {
        bool estApprivoise = false;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("de poisson, du miel, des baies sauvages, tout ce qui se mange en fait ");
        }
    }

    public class Oiseau : Vertebre
    {
        bool peutVoler = true;
    }

    public class Perroquet : Oiseau
    {
        bool estDresse;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("ce qu'on lui donne ");
        }
    }

    public class Toucan : Oiseau
    {
        double tailleDuBec;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("du poisson ");
        }
    }

    public class Poisson : Vertebre
    {
        bool vieDansLeauDouce = false;

        public override void Manger()
        {
            base.Manger();
            Console.Write("du plancton ");
        }
    }

    public class Requin : Poisson
    {
        bool estDangeureux = true;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("et des hommes parfois");
        }
    }

    public class Saumon : Poisson
    {
        bool estSauvage = true;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("et c'est tout");
        }
    }

    public class Amphibien : Vertebre
    {
        bool aDesPattes = true;
    }

    public class Grenouille : Amphibien
    {
        bool peutChangerDeSexe = true;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("des trucs dans l'eau");
        }
    }

    public class Crapaud : Amphibien
    {
        bool estToxique = true;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("des trucs dans l'eau");
        }
    }

    public class Reptile : Vertebre
    {
        String regionDuMonde;
    }

    public class Crocodile : Reptile
    {
        int nbDeDents;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("des gnous");
        }
    }

    public class Tortue : Reptile
    {
        int age;

        public override void Manger()
        {
            base.Manger();
            Console.WriteLine("de la salade");
        }
    }
}
