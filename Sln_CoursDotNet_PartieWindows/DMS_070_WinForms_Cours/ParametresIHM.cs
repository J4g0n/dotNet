using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_070_WinForms_Cours
{
    public class ParametresIHM
    {
        private static string titreAppli = "Mes applications WinForm";
        private static Color couleurFond = Color.Gold;

        public static Color CouleurFond
        {
            get { return ParametresIHM.couleurFond; }
            set { ParametresIHM.couleurFond = value; }
        }

        public static string TitreAppli
        {
            get { return ParametresIHM.titreAppli; }
            set { ParametresIHM.titreAppli = value; }
        }
    }
}
