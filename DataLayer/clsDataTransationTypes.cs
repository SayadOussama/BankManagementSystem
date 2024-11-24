using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class clsDataTransationTypes
    {
        public static bool GetTransactionInfoByTransactionID(int TransactionID, ref string TransactionName, ref decimal TransactionFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); string query = "SELECT * FROM TransactionTypes WHERE TransactionID= @TransactionID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID ", TransactionID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true; TransactionName = (string)reader["TransactionName"];
                    TransactionFees = (decimal)reader["TransactionFees"];
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetTransactionInfoByTransactionID(int TransactionID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM TransactionTypes  
             where TransactionID = @TransactionID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID ", TransactionID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                isFound = reader.HasRows;

                reader.Close();

            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
                return false;

            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }



    }
}
