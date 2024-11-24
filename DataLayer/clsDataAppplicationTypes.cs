using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class clsDataAppplicationTypes
    {
        public static bool GetFindApplicationTypesInfoByID(int ID, ref string ApplicationName, ref decimal ApplicationFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM ApplicationTypes WHERE ID= @ID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID ", ID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true; ApplicationName = (string)reader["ApplicationName"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];
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

        public static DataTable GetAllByID()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM ApplicationTypes  ";

           SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }
                reader.Close();
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
               

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

    }
}
