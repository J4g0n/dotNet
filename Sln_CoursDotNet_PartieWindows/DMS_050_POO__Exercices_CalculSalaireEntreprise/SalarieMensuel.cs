using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public class SalarieMensuel:Salarie
    {
        private double FRemunerationTotale;
        private double FPrime;

        override public int Merite
        {
            get { return base.Merite; }
            set { 
                base.FMerite = value;
            }
        }

        public double MontantPaie
        {
            get { return (FRemunerationTotale + FPrime) / 12; }
        }

        public SalarieMensuel(int id, string nom, string prenom, CategoriePerso categoriePerso, string insee, int indice, double coeffPrime, double remunerationTotale)
            : base(id, nom, prenom, categoriePerso, insee, indice, coeffPrime)
        {
            FRemunerationTotale = remunerationTotale;
        }
    }
}
