using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public interface IPositionHierarchie
    {
        double Coeff_Prime
        {
            get;
            set;
        }

        int Indice_Hierarchique
        {
            get;
            set;
        }

        DateTime IndiceDepuis
        {
            get;
            set;
        }
    }
}
