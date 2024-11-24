using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class clsDataTransactions
    {
        public static bool GetFindTransactionInfoByTransationID(int TransationID, ref int TransactionTypeID, ref int AccountID, ref DateTime TransactionDate, ref decimal  TransactionFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); string query = "SELECT * FROM TransactionManagement WHERE TransationID= @TransationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransationID ", TransationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true; TransactionTypeID = (int)reader["TransactionTypeID"];
                    AccountID = (int)reader["AccountID"];
                    TransactionDate = (DateTime)reader["TransactionDate"];
                    TransactionFees = (decimal)reader["TransactionFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                        
                 
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
        public static int AddNewTransation(int TransactionTypeID, int AccountID, DateTime TransactionDate, decimal TransactionFees, int CreatedByUserID)
        {
            int TransationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO TransactionManagement ( TransactionTypeID ,AccountID ,TransactionDate ,TransactionFees ,CreatedByUserID )
VALUES ( @TransactionTypeID , @AccountID , @TransactionDate , @TransactionFees , @CreatedByUserID)
SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@TransactionFees", TransactionFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TransationID = insertedID;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return TransationID;
}
        public static bool UpdateTransaction(int TransationID, int TransactionTypeID, int AccountID, DateTime TransactionDate,  decimal TransactionFees, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update TransactionManagement  
set  
TransactionTypeID  = @TransactionTypeID ,
AccountID  = @AccountID ,
TransactionDate  = @TransactionDate ,
TransactionFees  = @TransactionFees ,
CreatedByUserID  = @CreatedByUserID 

where TransationID = @TransationID;";
            SqlCommand command = new SqlCommand(query, connection); command.Parameters.AddWithValue("@TransationID", TransationID);
            command.Parameters.AddWithValue("@TransactionTypeID", TransactionTypeID);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
            command.Parameters.AddWithValue("@TransactionFees", TransactionFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();


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
            return (rowsAffected > 0);
        }
        public static bool DeleteTransactionByTransationID(int TransationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"Delete TransactionManagement  
                     where TransationID  = @TransationID";

            ; SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransationID ", TransationID);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);


            }
            finally
            {
                connection.Close();
            }
            return (rowsAffected > 0);
        }
        public static bool IsTransationExistByTransationID(int TransationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM TransactionManagement  
             where TransationID = @TransationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransationID ", TransationID);

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
        public static DataTable GetAllByTransationID(int TransationID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT * FROM TransactionManagement  ";

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
               // return false;

            }
            finally
            {
                connection.Close();
            }
            return dt;
        }


        public static decimal GetTransactionFeesByID(int TransactionID)

        {
            //** You Must declare var string To Loaded With First Name You Looking For

            decimal TransactionFees = -1;

            //SqlConnection they there Objective Doing the Connectivity with Data Base


            //the Necessary information To Get Access To Database 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            //Write Your Query                                          //the parametrize (will Looking For)

            string Query = "select TransactionTypes.TransactionFees from TransactionTypes where TransactionID =@TransactionID";


            //Prepare To Execute Comment 

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@TransactionID", TransactionID);

            try
            {
                //Open the Gate to Get Access to Database 
                connection.Open();

                //**
                //**We Use Here Execute Scalar
                //**

                object Result = command.ExecuteScalar();

                if (Result != null)//IF Find 
                {
                    TransactionFees = decimal.Parse( Result.ToString());
                }
                else//If Not Find
                {
                    TransactionFees = -1;
                }

                connection.Close();

            }
            //Must Apply catch Because if the Data base Get ERROR Will Display it on the Screen 
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }
            //IMPORTANT:
            //Return First name Must Be At The End of function 
            return TransactionFees;

        }


        public static DataTable GetTransactionManagementList()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"select TransactionManagement.TransactionID ,TransactionTypes.TransactionName  ,    TransactionManagement.AccountID, People.LastName +' '+
                people.FirstName as FullName ,TransactionManagement.TransactionDate , TransactionManagement.TransactionFees,Users.UserName
                from TransactionManagement
                inner join TransactionTypes  on TransactionManagement.TransactionTypeID = TransactionTypes.TransactionID 
				inner join ClientsAccount on TransactionManagement.AccountID = ClientsAccount.AccountID
				inner join People on People.PersonID  = ClientsAccount.PersonID
				inner join Users on TransactionManagement.CreatedByUserID = Users.UserID
				Order By TransactionID Desc";







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
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }







    }
}
