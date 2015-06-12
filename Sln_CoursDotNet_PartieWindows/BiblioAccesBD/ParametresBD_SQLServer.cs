using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioAccesBD
{
    public class ParametresBD_SQLServer: ParametresBD
    {
        public ParametresBD_SQLServer(string nomServ, string nomBD)
        {
            NomBD = nomBD;
            NomServeur = nomServ;
            ChaineConnexion = 
                "integrated security = SSPI;" +
                "data source = " + NomServeur + ";" +
                "persist security info = false;" +
                "initial catalog = " + NomBD;
        }
    }
}
