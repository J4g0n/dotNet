using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public class SalarieMensuel:Salarie
    {
        private double FRemunerationTotale;

        public double MontantPaie
        {
            get { return FRemunerationTotale; }
            set { FRemunerationTotale = value; }
        }
        private double FPrime;

        public SalarieMensuel()
        {
            throw new System.NotImplementedException();
        }
    }
}
