using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public class SalarieHoraire : Salarie
    {
        private double FHeuresTravaillees;
        private double FTauxHoraire;

        override public double MontantPaie
        {
            get { return FTauxHoraire * FHeuresTravaillees + FMerite; }
        }

        public double HeuresTravaillees
        {
            get { return FHeuresTravaillees; }
            set { FHeuresTravaillees = value; }
        }

        public SalarieHoraire(int id, string nom, string prenom, CategoriePerso categoriePerso, string insee, int indice, double coeffPrime): base(id, nom, prenom, categoriePerso, insee, indice, coeffPrime)
        {
        }
    }
}
