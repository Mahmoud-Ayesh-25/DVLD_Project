using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsUser
    {
        public static DataTable GetAllUsers()
        {
            DataTable dtUsers = new DataTable();

            string query = @"SELECT Users.UserID, Users.UserName, Users.PersonID, 
                            (People.FirstName + ' ' + People.LastName) AS PersonName,
                            Users.IsActive
                            FROM Users INNER JOIN People
                            ON Users.PersonID = People.PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtUsers.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtUsers;
        }

        public static bool GetUserInfoByUserID(int ID, ref int PersonID, ref string Username, ref string Password,ref bool IsActive)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", ID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                PersonID = int.Parse(reader["PersonID"].ToString());
                                Username = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                                IsActive = (bool)reader["IsActive"];
                            }
                        }

                    }
                    catch { }
                }
            }

            return isFound;
        }

        public static bool GetUserInfoByPersonID(int PersonID, ref int ID, ref string Username, ref string Password,ref bool IsActive)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Users WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                ID = int.Parse(reader["UserID"].ToString());
                                Username = reader["UserName"].ToString();
                                Password = reader["Password"].ToString();
                                IsActive = (bool)reader["IsActive"];
                            }
                        }

                    }
                    catch { }
                }
            }

            return isFound;
        }

        public static bool GetUserInfoByUsernameAndPassword(string Username, string Password, ref int ID, ref int PersonID,ref bool IsActive)
        {
            bool isFound = false;

            string query = @"SELECT * FROM Users WHERE UserName = @UserName AND Password =  @Password;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;

                                ID = int.Parse(reader["UserID"].ToString());
                                PersonID = int.Parse(reader["PersonID"].ToString());
                                IsActive = (bool)reader["IsActive"];
                            }
                        }

                    }
                    catch { }
                }
            }

            return isFound;
        }

        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {
            int UserID = -1;

            string query = @"INSERT INTO Users
                            VALUES
                            (
	                            @PersonID,
	                            @Username,
	                            @Password,
	                            @IsActive
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);

                    try
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            UserID = id;
                        }
                    }
                    catch { }
                }
            }

            return UserID;
        }

        public static bool UpdateUser(int UserID, int PersonID, string Username, string Password, bool IsActive)
        {
            bool isUpdated = false;

            string query = @"Update Users
                            SET
                            PersonID = @PersonID,
                            UserName = @UserName,
                            Password = @Password,
                            IsActive = @IsActive
                            WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserName", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            isUpdated = true;
                        }

                    }
                    catch { }
                }
            }

            return isUpdated;
        }

        public static bool DeleteUser(int UserID)
        {
            bool isDeleted = false;

            string qruey = @"DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(qruey, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();

                        if (rowsEffected > 0)
                        {
                            isDeleted = true;
                        }
                    }
                    catch { }
                }
            }

            return isDeleted;
        }

        public static bool IsUserExist(int UserID)
        {
            bool isExist = false;

            string query = @"SELECT 0 FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isExist = true;
                        }
                    }
                    catch {}
                }
            }

            return isExist;
        }

        public static bool IsUserExist(string Username)
        {
            bool isExist = false;

            string query = @"SELECT 0 FROM Users WHERE UserName = @UserName";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserName", Username);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isExist = true;
                        }
                    }
                    catch { }
                }
            }

            return isExist;
        }

        public static bool IsUserExistByPersonID(int PersonID)
        {
            bool isExist = false;

            string query = @"SELECT 0 FROM Users WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            isExist = true;
                        }
                    }
                    catch { }
                }
            }

            return isExist;
        }
    }
}
