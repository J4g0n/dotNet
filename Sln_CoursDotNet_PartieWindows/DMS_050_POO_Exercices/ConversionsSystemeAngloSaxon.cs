using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_050_POO_Exercices
{
    class ConversionsSystemeAngloSaxon
    {
        public static double fahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5/9 ;
        }

        public static double poundToEuro(double pound)
        {
            return pound * 1.36;
        }

        public static double inchToCentimeters(double inch)
        {
            return 2.54 * inch;
        }

        public static double gallonToLitre(double gallon)
        {
            return gallon * 3.78;
        }
    }
}
