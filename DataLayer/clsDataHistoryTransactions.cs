using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDataHistoryTransactions
    {
        public static bool FindHistoryInfoByHitstoryID(int HitstoryID,ref int TransactionID, ref int TransacionType, ref int AccountID, ref int AccountReceiveID, ref int CurrencyType, ref decimal LocalAmount, ref decimal EuroAmount)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); string query = "SELECT * FROM HistoryTransactions WHERE HitstoryID= @HitstoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HitstoryID ", HitstoryID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    TransactionID = (int)reader["TransactionID"];
                    TransacionType = (int)reader["TransacionType"];
                    AccountID = (int)reader["AccountID"];

                    if (reader["AccountReceiveID"] != DBNull.Value)
                        AccountReceiveID = (int)reader["AccountReceiveID"];
                    else
                        AccountReceiveID = -1;

                    CurrencyType = (int)reader["CurrencyType"];

                    if (reader["LocalAmount"] != DBNull.Value)
                        LocalAmount = (decimal)reader["LocalAmount"];
                    else
                        LocalAmount = -1;


                    if (reader["EuroAmount"] != DBNull.Value)
                        EuroAmount = (decimal)reader["EuroAmount"];
                    else
                        EuroAmount = -1;

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
        public static int AddNewHitstory(int TransactionID, int TransactionType, int AccountID, int AccountReceiveID, int CurrencyType, decimal LocalAmount, decimal EuroAmount)
        {
            int HitstoryID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO HistoryTransactions (TransactionID, TransactionType ,AccountID ,AccountReceiveID ,CurrencyType ,LocalAmount ,EuroAmount )
VALUES (@TransactionID, @TransactionType , @AccountID , @AccountReceiveID , @CurrencyType , @LocalAmount , @EuroAmount )
SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TransactionID", TransactionID);
            command.Parameters.AddWithValue("@TransactionType", TransactionType);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            if (AccountReceiveID != -1 )
                command.Parameters.AddWithValue("@AccountReceiveID", AccountReceiveID);
            else
                command.Parameters.AddWithValue("@AccountReceiveID", System.DBNull.Value);

            command.Parameters.AddWithValue("@CurrencyType", CurrencyType);
            if (LocalAmount != -1 )
                command.Parameters.AddWithValue("@LocalAmount", LocalAmount);
            else
                command.Parameters.AddWithValue("@LocalAmount", System.DBNull.Value);
            if (EuroAmount != -1 )
                command.Parameters.AddWithValue("@EuroAmount", EuroAmount);
            else
                command.Parameters.AddWithValue("@EuroAmount", System.DBNull.Value);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    HitstoryID = insertedID;
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
            return HitstoryID;
}
        public static bool UpdateInfoByHitstoryID(int HitstoryID,int TransactionID, int TransacionType, int AccountID, int AccountReceiveID, int CurrencyType, decimal LocalAmount, decimal EuroAmount)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update HistoryTransactions  
set  
TransactionID = @TransactionID,
TransacionType  = @TransacionType ,
AccountID  = @AccountID ,
AccountReceiveID  = @AccountReceiveID ,
CurrencyType  = @CurrencyType ,
LocalAmount  = @LocalAmount ,
EuroAmount  = @EuroAmount 
where HitstoryID = @HitstoryID;";
            SqlCommand command = new SqlCommand(query, connection); command.Parameters.AddWithValue("@HitstoryID", HitstoryID);
            command.Parameters.AddWithValue("@TransactionID", TransacionType);
            command.Parameters.AddWithValue("@TransacionType", TransacionType);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            if (AccountReceiveID != -1)
                command.Parameters.AddWithValue("@AccountReceiveID", AccountReceiveID);
            else
                command.Parameters.AddWithValue("@AccountReceiveID", System.DBNull.Value);
            command.Parameters.AddWithValue("@CurrencyType", CurrencyType);
            if (LocalAmount != -1)
                command.Parameters.AddWithValue("@LocalAmount", LocalAmount);
            else
                command.Parameters.AddWithValue("@LocalAmount", System.DBNull.Value);
            if (EuroAmount != -1)
                command.Parameters.AddWithValue("@EuroAmount", EuroAmount);
            else
                command.Parameters.AddWithValue("@EuroAmount", System.DBNull.Value);

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

        public static bool DeleteHistoryInfoByHitstoryID(int HitstoryID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"Delete HistoryTransactions  
                     where HitstoryID  = @HitstoryID";

             SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HitstoryID ", HitstoryID);
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
        public static bool IsHistoryExistByID(int HitstoryID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM HistoryTransactions  
             where HitstoryID = @HitstoryID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@HitstoryID ", HitstoryID);

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
        public static DataTable GetHitoryList()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"Select HistoryTransactions.HitstoryID,HistoryTransactions.TransactionID ,TransactionTypes.TransactionName ,HistoryTransactions.AccountID
,HistoryTransactions.AccountReceiveID ,     CASE WHEN HistoryTransactions.CurrencyType = 1 THEN 'Local' WHEN HistoryTransactions.CurrencyType = 2 THEN 'Euro'  END as CurrencyType ,HistoryTransactions.LocalAmount,HistoryTransactions.EuroAmount
from HistoryTransactions
inner join TransactionTypes on HistoryTransactions.TransactionType = TransactionTypes.TransactionID ";







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
