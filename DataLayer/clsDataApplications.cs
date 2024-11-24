using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DataLayer
{
    public  class clsDataApplications
    {
        public static bool GetApplicationInfoByApplicationID(int ApplicationID, ref int PersonID, ref int ApplicationTypeID, ref DateTime ApplicationDate, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Applications WHERE ApplicationID= @ApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID ", ApplicationID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    isFound = true;
                    PersonID = (int)reader["PersonID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
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
        public static int AddNewApplicationID(int PersonID, int ApplicationTypeID, DateTime ApplicationDate, int CreatedByUserID)
        {
            int ApplicationID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Applications ( PersonID ,ApplicationTypeID ,ApplicationDate ,CreatedByUserID )
             VALUES ( @PersonID , @ApplicationTypeID , @ApplicationDate , @CreatedByUserID )
             SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
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


            return ApplicationID;
                
}

        public static bool UpdateByApplicationID(int ApplicationID, int PersonID, int ApplicationTypeID, DateTime ApplicationDate, int CreatedByUserID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update Applications  
                              set  
                              PersonID  = @PersonID ,
                              ApplicationTypeID  = @ApplicationTypeID ,
                              ApplicationDate  = @ApplicationDate ,
                              CreatedByUSerID  = @CreatedByUserID 
                              where ApplicationID = @ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
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

        public static bool IsApplicationExistByAppID(int ApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"SELECT Found=1 FROM Applications  
             where ApplicationID = @ApplicationID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID ", ApplicationID);

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

        public static bool DeleteApplicationByAppID(int ApplicationID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"Delete Applications  
                      where ApplicationID  = @ApplicationID";

            ; SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID ", ApplicationID);
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

        public static DataTable GetApplicationsList()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
              @"select Applications.ApplicationID , People.LastName +' '+
                people.FirstName as FullName ,ApplicationTypes.ApplicationName , ApplicationTypes.ApplicationFees,Users.UserName
                from Applications
                inner join People  on Applications.PersonID = People.PersonID 
				inner join ApplicationTypes on Applications.ApplicationTypeID = ApplicationTypes.ID
				inner join Users on Applications.CreatedByUserID = Users.UserID 
				Order by ApplicationID desc ";
 






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
        public  static bool IsApplicationExist(int PersonID , int ApplicationType)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select Found=1 from Applications
				inner join People on People.PersonID  = Applications.ApplicationID
				inner Join ApplicationTypes on Applications.ApplicationTypeID = ApplicationTypes.ID
				
				where Applications.PersonID =@PersonID and ApplicationTypes.ID = @ApplicationType;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID ", PersonID);
            command.Parameters.AddWithValue("@ApplicationType ", ApplicationType);
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
