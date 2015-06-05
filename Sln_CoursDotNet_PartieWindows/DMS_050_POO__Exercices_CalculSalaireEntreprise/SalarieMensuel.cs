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
            get {
                switch (Categorie) {
                    case CategoriePerso.Cadre_Sup:
                        FPrime = EvaluerPrimeCadreSup(); break;
                    case CategoriePerso.Cadre:
                        FPrime = EvaluerPrimeCadre(); break;
                    case CategoriePerso.Maitrise:
                        FPrime = EvaluerPrimeMaitrise(); break;
                    case CategoriePerso.Agent:
                        FPrime = EvaluePrimeAgent(); break;
                    default: break;
                }
                return base.Merite; }
            set { 
                base.FMerite = value;
                switch (Categorie)
                {
                    case CategoriePerso.Cadre_Sup:
                        FPrime = EvaluerPrimeCadreSup(); break;
                    case CategoriePerso.Cadre:
                        FPrime = EvaluerPrimeCadre(); break;
                    case CategoriePerso.Maitrise:
                        FPrime = EvaluerPrimeMaitrise(); break;
                    case CategoriePerso.Agent:
                        FPrime = EvaluePrimeAgent(); break;
                    default: break;
                }
            }
        }

        override public double MontantPaie
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
