using BiblioAccesBD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMS_070_Exercices
{
    public partial class Exo070 : Form
    {
        ParametresBD bd = new ParametresBD_SQLServer("S24POSTE09", "Northwind");
        SqlConnection connection = new SqlConnection();
        DataSet dataSet;

        public Exo070()
        {
            InitializeComponent();
            
            dataSet = bd.ExecuterRequete("select * from customers", new DataSet("Customers"), "Customers");

            grid_Customers.DataSource = dataSet; // dataset
            grid_Customers.DataMember = "Customers"; // table name you need to show
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            grid_Customers.EndEdit();
            DataTable dataTable = (DataTable) grid_Customers.DataSource;

            DataTable changedTable = dataTable.GetChanges();

            bd.MajBD(dataTable);
        }
    }
}
