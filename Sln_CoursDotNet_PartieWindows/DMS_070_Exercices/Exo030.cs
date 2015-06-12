using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_Exercices
{
    public partial class Exo030 : Form
    {
        List<string> lstDishes = new List<string>();

        public Exo030()
        {
            InitializeComponent();
        }

        private void cmb_Entrees_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = (string) cmb_Entrees.SelectedItem.ToString();
            cmb_Entrees.Enabled = false;
            lstDishes.Add(item);
            refresh();
        }

        private void cmb_Plats_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = (string) cmb_Plats.SelectedItem.ToString();
            cmb_Plats.Enabled = false;
            lstDishes.Add(item);
            refresh();
        }

        private void cmb_Desserts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = (string) cmb_Desserts.SelectedItem.ToString();
            cmb_Desserts.Enabled = false;
            lstDishes.Add(item);
            refresh();
        }

        private void refresh()
        {
            lst_Menu.Clear();
            foreach (string s in lstDishes)
            {
                ListViewItem lstViewItem = new ListViewItem(new string[1] { s });
                lst_Menu.Items.Add(lstViewItem);
            }
        }

        private void Exo030_Load(object sender, EventArgs e)
        {
            
        }
    }
}
