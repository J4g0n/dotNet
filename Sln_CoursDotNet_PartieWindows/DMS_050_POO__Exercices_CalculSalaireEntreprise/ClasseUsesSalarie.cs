﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DMS_050_POO__Exercices_CalculSalaireEntreprise
{
    public class ClasseUsesSalarie
    {
        static public void InfoSalarie(Salarie s)
        {
            Console.WriteLine("Employe n°" + s.Identifiant + ": " + s.Nom + " / " + s.Prenom);
            Console.WriteLine("n° SS : " + s.Insee);
            Console.WriteLine("categorie: " + s.Categorie);
            Console.WriteLine("indice hierarchique : " + s.Indice_Hierarchique + ", détenu depuis : " + s.IndiceDepuis);
            Console.WriteLine("coeff merite: " + s.Merite);
        }

        static public void Main()
        {
            Salarie anne = new SalarieMensuel(123456, "Galion", "Anne", CategoriePerso.Cadre_Sup, "2780258123456", 700, 0.5, 50000);
            anne.Merite = 6;
            Salarie patrick = new SalarieMensuel(123457, "Renaud", "Patrick", CategoriePerso.Cadre, "1821113896452", 520, 0.42, 30000);
            patrick.Merite = 5;
            Salarie marie = new SalarieMensuel(123458, "Ziha", "Marie", CategoriePerso.Maitrise, "2801037853781", 678, 0.6, 20000);
            marie.Merite = 2;
            Salarie beatrice = new SalarieMensuel(123459, "Lougene", "Beatrice", CategoriePerso.Agent, "2790469483167", 805, 0.25, 20000);
            beatrice.Merite = 4;

            List<Salarie> salaries = new List<Salarie>() { anne, patrick, marie, beatrice };

            foreach (Salarie s in salaries)
            {
                InfoSalarie(s);
                double initCoeff = s.Coeff_Prime;
                int initMerite = s.Merite;
                s.Coeff_Prime = 0.5;
                while (s.Coeff_Prime < 1)
                {
                    s.Merite = initMerite;
                    Console.WriteLine("Coeff prime " + s.Coeff_Prime);
                    Console.WriteLine("Montant prime annuelle " + s.Prime);
                    Console.WriteLine("Salaire mensuelle " + s.MontantPaie);
                    s.Coeff_Prime += 0.1;
                }
                s.Coeff_Prime = initCoeff;
                s.Merite = 0;
                while (s.Merite < 10)
                {
                    Console.WriteLine("Mérite " + s.Merite);
                    Console.WriteLine("Montant prime annuelle " + s.Prime);
                    Console.WriteLine("Salaire mensuelle " + s.MontantPaie);
                    s.Merite += 1;
                }
            }

            Console.ReadKey();
        }
    }
}
