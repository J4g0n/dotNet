using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_WinForms_Cours
{
    static class Program
    {
        public static readonly string nomServeur = "S24POSTE09";
        public static readonly string nomBase = "northwind";
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Win_070_AccesBD_Grille());
        }
    }
}
