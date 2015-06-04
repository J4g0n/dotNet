using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public abstract class Salarie:IPositionHierarchie
    {
        private double FBasePrime;
        private CategoriePerso FCategorie;
        private int FCodeEmploye;
        private double FCoeffPrime;
        private int FIndice;
        private DateTime FIndiceDetenu;
        private string FInsee;
        private int FMerite;
        private string FNom;
        private string FPrenom;

        public int Merite
        {
            get { return FMerite; }
            set { FMerite = value; }
        }

        public int Indice_Hierarchique
        {
            get { return FIndice; }
            set { FIndice = value; }
        }

        public string Nom
        {
            get { return FNom; }
            set { FNom = value; }
        }

        public string Prenom
        {
            get { return FPrenom; }
            set { FPrenom = value; }
        }

        public string Insee
        {
            get { return FInsee; }
            set { FInsee = value; }
        }

        public DateTime IndiceDepuis
        {
            get { return FIndiceDetenu; }
            set { FIndiceDetenu = value; }
        }

        public int Identifiant
        {
            get { return FCodeEmploye; }
            set { FCodeEmploye = value; }
        }

        public double Coeff_Prime
        {
            get { return FCoeffPrime; }
            set { FCoeffPrime = value; }
        }
       
        public CategoriePerso Categorie
        {
            get { return FCategorie; }
            set { FCategorie = value; }
        }

        public double Prime
        {
            get { return FBasePrime; }
            set { FBasePrime = value; }
        }

        public virtual double MontantPaie
        {
            get {
                throw new System.NotImplementedException();
            }
            set { 
            }
        }

        public Salarie(int id, string nom, string prenom, CategoriePerso categoriePerso, string insee, int indice, double coeffPrime)
        {
            FCodeEmploye = id;
            FNom = nom;
            FPrenom = prenom;
            FCategorie = categoriePerso;
            FInsee = insee; 
            FIndice = indice;
            FCoeffPrime = coeffPrime;
            FBasePrime = calculerPrimeDeBase(categoriePerso);
        }

        public Salarie(int id, string nom, string prenom, CategoriePerso categoriePerso, string insee)
        {
            FCodeEmploye = id;
            FNom = nom;
            FPrenom = prenom;
            FCategorie = categoriePerso;
            FInsee = insee;
            FIndice = 0;
            FCoeffPrime = 0;
            FBasePrime = 0;
        }

        private double calculerPrimeDeBase(CategoriePerso categorie)
        {
            switch (categorie)
            {
                case CategoriePerso.Cadre_Sup: return 2000;
                case CategoriePerso.Cadre: return 1000;
                case CategoriePerso.Maitrise: return 500;
                case CategoriePerso.Agent: return 200;
                default: throw new InvalidCastException(categorie + " is not a defined value for enum type ");
            }
        }

        protected void EvaluePrimeAgent()
        {
            throw new System.NotImplementedException();
        }

        protected void EvaluerPrimeCadre()
        {
            throw new System.NotImplementedException();
        }

        protected void EvaluerPrimeCadreSup()
        {
            throw new System.NotImplementedException();
        }

        protected void EvaluerPrimeMaitrise()
        {
            throw new System.NotImplementedException();
        }
    }
}
