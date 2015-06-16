using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_Exercices
{
    public partial class Exo050 : Form
    {
        public string [] photosName;
        public string photosPath =
                "C:\\Users\\ipi\\Desktop\\dotNet\\Sln_CoursDotNet_PartieWindows\\DMS_070_Exercices\\ressources\\photos\\";

        public Exo050()
        {
            InitializeComponent();

            photosName = Directory.GetFiles(photosPath);
        }

        private void Exo050_Load(object sender, EventArgs e)
        {
            
        }

        private void lst_Noms_SelectedIndexChanged(object sender, EventArgs e)
        {
            int userIndex = lst_Noms.SelectedIndex;
            pbox_Photo.Image = new Bitmap(photosName[userIndex]);
        }
    }
}
