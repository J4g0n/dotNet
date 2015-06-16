using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace DMS_070_Exercices
{
    public partial class Exo040 : Form
    {
        public Exo040()
        {
            InitializeComponent();
        }

        private void btn_OuvrirExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true;
        }

        private void txt_Notes_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.');
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook xlWorkBook;
            excelApp.Visible = true;
            string pathToExcelFile = "C:\\Users\\ipi\\Desktop\\dotNet\\Sln_CoursDotNet_PartieWindows\\DMS_070_Exercices\\ressources\\GestionDesNotes.xlsx";
            int note = Convert.ToInt32(txt_Notes.Text);
            xlWorkBook = excelApp.Workbooks.Open(pathToExcelFile, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            try
            {
                System.Data.OleDb.OleDbConnection MyConnection;
                System.Data.OleDb.OleDbCommand myCommand = new System.Data.OleDb.OleDbCommand();
                string sql = null;
                MyConnection = new System.Data.OleDb.OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + pathToExcelFile + "';Extended Properties=Excel 8.0;");
                MyConnection.Open();
                myCommand.Connection = MyConnection;
                sql = "insert into notes (Nom, Prenom, Note) values ('simon','andreux'," + note + ");";
                myCommand.CommandText = sql;
                myCommand.ExecuteNonQuery();
                MyConnection.Close();
                /*xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                int nbRows = xlWorkSheet.Cells.Rows.Count;
                xlWorkSheet.Cells.set_Item(nbRows + 1, 3, note);*/
            }
            catch (Exception err)
            {
                MessageBox.Show("Une erreur s'est produite: " + err.Message + "\n" + err.ToString());
            }
        }
    }
}
