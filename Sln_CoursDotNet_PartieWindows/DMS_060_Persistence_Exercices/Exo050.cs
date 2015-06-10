using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMS_060_Persistence_Exercices
{
    public class Exo050
    {
        public static void main() {
            string customerId = "VINET";
            string procedureName = "SalesRevenueByCustomer";
            string requete = 
                "select * from sysobjects where id = object_id(N'" + procedureName + "')" +
			    " and OBJECTPROPERTY(id, N'IsProcedure') = 1";
            
            SqlConnection MyConnection = new SqlConnection();
            MyConnection.ConnectionString = ParametresBD.ChaineConnexionNorthwind;


            SqlDataAdapter MyDataAdapter = new SqlDataAdapter(procedureName, MyConnection);

            //Set the command type as StoredProcedure.
            MyDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            //Create and add a parameter to Parameters collection for the stored procedure.
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.VarChar, 5));
            //Assign the search value to the parameter.
            MyDataAdapter.SelectCommand.Parameters["@CustomerID"].Value = customerId.Trim();

            //Create and add an output parameter to the Parameters collection. 
            MyDataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@Sales", SqlDbType.Int, 4));
            //Set the direction for the parameter. This parameter returns the Rows that are returned.
            MyDataAdapter.SelectCommand.Parameters["@Sales"].Direction = ParameterDirection.Output;

            //Create a new DataSet to hold the records.
            DataSet DS = new DataSet();
            //Fill the DataSet with the rows that are returned.
            MyDataAdapter.Fill(DS, "RevenueSalesByCustomerID");

            Console.WriteLine("Le chiffre d'affaire pour le client " + customerId + " est de " + MyDataAdapter.SelectCommand.Parameters[1].Value);

            MyDataAdapter.Dispose(); 
            MyConnection.Close();
        }
    }
}
