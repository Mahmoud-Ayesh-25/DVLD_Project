using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsApplicationTypes
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dtTypes = new DataTable();

            string query = $"SELECT * FROM ApplicationTypes";

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
                                dtTypes.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtTypes;
        }

        public static bool GetApplicationTypeByID(int ID, ref string ApplicationTypeTitle, ref float ApplicationTypeFees)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM ApplicationTypes WHERE ApplicationTypeID = @ApplicationTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ID);
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;
                                ApplicationTypeTitle = reader[1].ToString();
                                ApplicationTypeFees = float.Parse(reader[2].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddNewApplicationType(string ApplicationTypeTitle, float ApplicationTypeFees)
        {
            int appTypeID = -1;

            string query = @"INSERT INTO ApplicationTypes
                            VALUES
                            (
	                            @ApplicationTypeTitle, @ApplicationTypeFees
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

                    try
                    {
                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int id))
                        {
                            appTypeID = id;
                        }
                    }
                    catch {}
                }
            }

            return appTypeID;
        }

        public static bool UpdateApplicationType(int ID, string ApplicationTypeTitle, float ApplicationTypeFees)
        {
            bool IsUpdated = false;

            string query = @"UPDATE ApplicationTypes
                            SET
	                            ApplicationTypeTitle = @ApplicationTypeTitle,
	                            ApplicationFees = @ApplicationTypeFees
                            WHERE ApplicationTypeID = @ApplicationTypeID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationTypeID", ID);
                    command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);
                    command.Parameters.AddWithValue("@ApplicationTypeFees", ApplicationTypeFees);

                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            IsUpdated = true;
                        }
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }
    }
}
