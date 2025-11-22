using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsDrivers
    {
        public static DataTable GetAllDrivers()
        {
            DataTable dtDrivers = new DataTable();

            string query = @"SELECT * FROM Drivers_View;";
            
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
                                dtDrivers.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtDrivers;
        }

        public static bool FindByDriverID(int DriverID, ref int PersonID, ref DateTime Date, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Drivers WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                PersonID = int.Parse(reader[1].ToString());
                                Date = DateTime.Parse(reader[2].ToString());
                                CreatedByUserID = int.Parse(reader[3].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static bool FindByPerosnID(int PersonID, ref int DriverID, ref DateTime Date, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Drivers WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                DriverID = int.Parse(reader[0].ToString());
                                Date = DateTime.Parse(reader[2].ToString());
                                CreatedByUserID = int.Parse(reader[3].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddDriver(int PersonID, int CreatedByUserID)
        {
            int DriverID = -1;

            string query = @"INSERT INTO Drivers
                            VALUES
                            (
	                            @PersonID, @CreatedByUserID, @Date
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                        command.Parameters.AddWithValue("@Date", DateTime.Now);

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            DriverID = id;
                        }
                    }
                    catch {}
                }
            }

            return DriverID;
        }

        public static bool UpdateDriver(int DriverID, int PersonID, int CreatedByUserID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE Drivers
                            SET
                            PersonID = @PersonID,
                            CreatedByUserID = @CreatedByUserID
                            WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        int rowsEffected = command.ExecuteNonQuery();

                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }
    }
}
