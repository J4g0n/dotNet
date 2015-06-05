using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public class ClasseUsesSalarie
    {
        public void InfoSalarie()
        {
            throw new System.NotImplementedException();
        }

        public void Main()
        {
            Salarie anne = new SalarieMensuel(123456, "Galion", "Anne", CategoriePerso.Cadre_Sup, "2780258123456", 700, 0.5, 50000);
            anne.Merite = 6;
            Salarie patrick = new SalarieMensuel(123457, "Renaud", "Patrick", CategoriePerso.Cadre, "1821113896452", 520, 0.42, 30000);
            anne.Merite = 5;
            Salarie marie = new SalarieMensuel(123458, "Ziha", "Marie", CategoriePerso.Maitrise, "2801037853781", 678, 0.6, 30000);
            anne.Merite = 2;
            Salarie beatrice = new SalarieMensuel(123459, "Lougene", "Beatrice", CategoriePerso.Agent, "2790469483167", 805, 0.25, 30000);
            anne.Merite = 4;

            List<Salarie> salaries = new List<Salarie>() { anne, patrick, marie, beatrice };
        }
    }
}
