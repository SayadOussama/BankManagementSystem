using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class clsDataClientAccount
    {
        public static bool GetFindAccountInfoByAccountID(int AccountID, ref int PersonID, ref int ApplicationID, ref decimal LocalDeposit, ref decimal EuroDeposit, ref DateTime CreationDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); string query = "SELECT * FROM ClientsAccount WHERE AccountID= @AccountID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID ", AccountID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    PersonID = (int)reader["PersonID"];
                    
                    LocalDeposit = (decimal)reader["LocalDeposit"];

                    if (reader["EuroDeposit"] != DBNull.Value)
                        EuroDeposit = (decimal)reader["EuroDeposit"];
                    else
                        EuroDeposit = -1;

                    CreationDate = (DateTime)reader["CreationDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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
        public static bool GetFindInfoByPersonID(ref int AccountID, int PersonID, ref int ApplicationID, ref decimal LocalDeposit, ref decimal EuroDeposit, ref DateTime CreationDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); string query = "SELECT * FROM ClientsAccount WHERE PersonID= @PersonID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID ", PersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true; AccountID = (int)reader["AccountID"];
                    ApplicationID = (int)reader["ApplicationID"];
                    LocalDeposit = (decimal)reader["LocalDeposit"];

                    if (reader["EuroDeposit"] != DBNull.Value)
                        EuroDeposit = (decimal)reader["EuroDeposit"];
                    else
                        EuroDeposit = -1;

                    CreationDate = (DateTime)reader["CreationDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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
        public static bool GetFindInfoByApplicationID(ref int AccountID, ref int PersonID,  int ApplicationID, ref decimal LocalDeposit, ref decimal EuroDeposit, ref DateTime CreationDate, ref DateTime ExpirationDate, ref bool IsActive, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString); string query = "SELECT * FROM ClientsAccount WHERE ApplicationID= @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID ", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true; 
                    AccountID = (int)reader["AccountID"];
                    PersonID = (int)reader["PersonID"];
                    LocalDeposit = (decimal)reader["LocalDeposit"];

                    if (reader["EuroDeposit"] != DBNull.Value)
                        EuroDeposit = (decimal)reader["EuroDeposit"];
                    else
                        EuroDeposit = -1;

                    CreationDate = (DateTime)reader["CreationDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    IsActive = (bool)reader["IsActive"];
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
        public static int AddNewClient(int PersonID, int ApplicationID, decimal LocalDeposit, decimal EuroDeposit, DateTime CreationDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int AccountID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO ClientsAccount ( PersonID ,ApplicationID ,LocalDeposit ,EuroDeposit ,CreationDate ,ExpirationDate ,IsActive ,CreatedByUserID )
VALUES ( @PersonID , @ApplicationID , @LocalDeposit , @EuroDeposit , @CreationDate , @ExpirationDate , @IsActive , @CreatedByUserID )
SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection); 
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LocalDeposit", LocalDeposit);
            if (EuroDeposit != -1 && EuroDeposit != null)
                command.Parameters.AddWithValue("@EuroDeposit", EuroDeposit);
            else
                command.Parameters.AddWithValue("@EuroDeposit", System.DBNull.Value);
            command.Parameters.AddWithValue("@CreationDate", CreationDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AccountID = insertedID;
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
            return AccountID;
}

        public static bool UpdateClientInfoByAccountID(int AccountID, int PersonID, int ApplicationID, decimal LocalDeposit, decimal EuroDeposit, DateTime CreationDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update ClientsAccount  
set  
PersonID  = @PersonID ,
ApplicationID  = @ApplicationID ,
LocalDeposit  = @LocalDeposit ,
EuroDeposit  = @EuroDeposit ,
CreationDate  = @CreationDate ,
ExpirationDate  = @ExpirationDate ,
IsActive  = @IsActive ,
CreatedByUserID  = @CreatedByUserID 
where AccountID = @AccountID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID", AccountID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LocalDeposit", LocalDeposit);
            if (EuroDeposit != -1 && EuroDeposit != null)
                command.Parameters.AddWithValue("@EuroDeposit", EuroDeposit);
            else
                command.Parameters.AddWithValue("@EuroDeposit", System.DBNull.Value);
            command.Parameters.AddWithValue("@CreationDate", CreationDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
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
        public static bool DeleteAccountByAccountID(int AccountID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"Delete ClientsAccount  
                            where AccountID  = @AccountID";

            ; SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID ", AccountID);
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
        public static DataTable GetAllClientsAccount()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"select ClientsAccount.AccountID ,ClientsAccount.ApplicationID, People.LastName +' '+
                people.FirstName as FullName ,ClientsAccount.CreationDate,ClientsAccount.LocalDeposit,ClientsAccount.EuroDeposit, ClientsAccount.ExpirationDate, ClientsAccount.IsActive ,Users.UserName as CreatedbyUser
                from ClientsAccount
                inner join People  on ClientsAccount.PersonID =    People.PersonID 
				inner join Applications on ClientsAccount.ApplicationID = Applications.ApplicationID
				inner join Users on ClientsAccount.CreatedByUserID =  Users.UserID
				Order By ClientsAccount.AccountID Desc";
  






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
        public static bool IsAccountExistInfoByAccountID(int AccountID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM ClientsAccount  
             where AccountID = @AccountID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountID ", AccountID);

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
        public static bool IsAccountExistInfoByPersonID(int PersonID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM ClientsAccount  
             where PersonID = @PersonID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID ", PersonID);

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
        public static bool IsAccountExistInfoByPersonIDAndAppType(int PersonID , int ApplicationTypeID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM ClientsAccount  
             inner join People on ClientsAccount.PersonID = People.PersonID
			 inner join Applications on ClientsAccount.ApplicationID = Applications.ApplicationID
			  where People.PersonID = @PersonID and Applications.ApplicationTypeID =ApplicationTypeID ;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID ", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID ", ApplicationTypeID);

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
        public static int GetAccountIDByApplicationID(int ApplicationID)

        {
            //** You Must declare var string To Loaded With First Name You Looking For

            int  AccountID = -1;

            //SqlConnection they there Objective Doing the Connectivity with Data Base


            //the Necessary information To Get Access To Database 
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            //Write Your Query                                          //the parametrize (will Looking For)

            string Query = @"select AccountID from ClientsAccount inner join 
				Applications on ClientsAccount.ApplicationID = Applications.ApplicationID
				where Applications.ApplicationID = @ApplicationID";


            //Prepare To Execute Comment 

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                //Open the Gate to Get Access to Database 
                connection.Open();

                //**
                //**We Use Here Execute Scalar
                //**

                object result = command.ExecuteScalar();

                if  (result != null && int.TryParse(result.ToString(), out int insertedID))//IF Find 
                    {
                    AccountID = insertedID;
                }
                else//If Not Find
                {
                    AccountID = -1;
                }

            
            }
            //Must Apply catch Because if the Data base Get ERROR Will Display it on the Screen 
            catch (Exception ex)
            {
                Console.WriteLine("Error " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            
            return AccountID;

        }







        public static bool DeactivateClientAccount(int AccountID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE CLientsAccount
                           SET 
                              IsActive = 0
                             
                         WHERE AccountID=@AccountID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@AccountID", AccountID);


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
    }
}
