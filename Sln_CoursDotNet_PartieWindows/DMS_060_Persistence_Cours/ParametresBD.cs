using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_060_Persistence_Cours
{
    public class ParametresBD
    {
        private readonly static string nomBD = "northwind";
        private readonly static string nomServeur = "S24POSTE09";
        private readonly static string chaineConnexionNorthwind =
            "integrated security = SSPI;" +
            "data source = " + nomServeur + ";" +
            "persist security info = false;" +
            "initial catalog = " + nomBD;

        public static string ChaineConnexionNorthwind
        {
            get { return ParametresBD.chaineConnexionNorthwind; }
        } 
    }
}
