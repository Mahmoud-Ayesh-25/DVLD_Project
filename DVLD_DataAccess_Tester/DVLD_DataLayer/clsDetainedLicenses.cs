using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsDetainedLicenses
    {
        public static bool GetDetainedLicenseByID(int DetainID, ref int LicenseID, ref DateTime DetainDate, ref float FineFees,
            ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM DetainedLicenses WHERE DetainID = @DetainID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DetainID", DetainID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                LicenseID = int.Parse(reader[1].ToString());
                                DetainDate = DateTime.Parse(reader[2].ToString());
                                FineFees = float.Parse(reader[3].ToString());
                                CreatedByUserID = int.Parse(reader[4].ToString());
                                IsReleased = (bool)reader[5];

                                if (reader[6] == DBNull.Value)
                                    ReleaseDate = new DateTime();
                                else
                                    ReleaseDate = DateTime.Parse(reader[6].ToString());

                                if (reader[7] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = int.Parse(reader[7].ToString());

                                if (reader[8] == DBNull.Value)
                                    ReleaseApplicationID = -1;
                                else
                                    ReleasedByUserID = int.Parse(reader[8].ToString());

                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static bool GetDetainedLicenseByLicenseID(int LicenseID, ref int DetainID, ref DateTime DetainDate, ref float FineFees,
           ref int CreatedByUserID, ref bool IsReleased, ref DateTime ReleaseDate, ref int ReleasedByUserID, ref int ReleaseApplicationID)
        {
            bool IsFound = false;

            string query = @"SELECT TOP 1 * FROM DetainedLicenses WHERE LicenseID = @LicenseID ORDER BY DetainID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                DetainID = int.Parse(reader[0].ToString());
                                DetainDate = DateTime.Parse(reader[2].ToString());
                                FineFees = float.Parse(reader[3].ToString());
                                CreatedByUserID = int.Parse(reader[4].ToString());
                                IsReleased = (bool)reader[5];

                                if (reader[6] == DBNull.Value)
                                    ReleaseDate = new DateTime();
                                else
                                    ReleaseDate = DateTime.Parse(reader[6].ToString());

                                if (reader[7] == DBNull.Value)
                                    ReleasedByUserID = -1;
                                else
                                    ReleasedByUserID = int.Parse(reader[7].ToString());

                                if (reader[8] == DBNull.Value)
                                    ReleaseApplicationID = -1;
                                else
                                    ReleasedByUserID = int.Parse(reader[8].ToString());

                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            DataTable dtDetained = new DataTable();

            string query = @"SELECT * FROM DetainedLicenses_View;";

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
                                dtDetained.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtDetained;
        }

        public static bool ReleaseDetainedLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool IsReleased = false;

            string query = @"UPDATE DetainedLicenses
                            SET IsReleased = 1, 
                            ReleaseDate = @ReleaseDate,
                            ReleasedByUserID = @ReleasedByUserID,
                            ReleaseApplicationID = @ReleaseApplicationID   
                            WHERE DetainID = @DetainID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ReleaseDate", DateTime.Now);
                        command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);
                        command.Parameters.AddWithValue("@DetainID", DetainID);
                        command.Parameters.AddWithValue("@ReleasedByUserID", ReleasedByUserID);

                        int rowsEffected = command.ExecuteNonQuery();

                        IsReleased = (rowsEffected > 0);
                    }
                    catch {}
                }
            }

            return IsReleased;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            bool IsDetained = false;

            string query = @"select IsDetained=1 
                            from detainedLicenses 
                            where 
                            LicenseID=@LicenseID 
                            and IsReleased=0;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);

                    try
                    {
                        object result = command.ExecuteScalar();

                        IsDetained = (result != null);
                    }
                    catch {}
                }
            }

            return IsDetained;
        }

        public static int AddNewDetainedLicense(int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            int DetainID = -1;

            string query = @"INSERT INTO dbo.DetainedLicenses
                               (LicenseID,
                               DetainDate,
                               FineFees,
                               CreatedByUserID,
                               IsReleased
                               )
                            VALUES
                               (@LicenseID,
                               @DetainDate, 
                               @FineFees, 
                               @CreatedByUserID,
                               0
                             );
                            
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", DetainDate);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int insertedID))
                        {
                            DetainID = insertedID;
                        }
                    }

                    catch { }
                }

            }

            return DetainID;

        }

        public static bool UpdateDetainedLicense(int DetainID, int LicenseID, DateTime DetainDate, float FineFees, int CreatedByUserID)
        {
            bool IsDetained = false;

            string query = @"UPDATE dbo.DetainedLicenses
                              SET LicenseID = @LicenseID, 
                              DetainDate = @DetainDate, 
                              FineFees = @FineFees,
                              CreatedByUserID = @CreatedByUserID,   
                              WHERE DetainID=@DetainID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DetainedLicenseID", DetainID);
                    command.Parameters.AddWithValue("@LicenseID", LicenseID);
                    command.Parameters.AddWithValue("@DetainDate", DetainDate);
                    command.Parameters.AddWithValue("@FineFees", FineFees);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();

                        IsDetained = (rowsEffected > 0);
                    }
                    catch { }
                }

            }

            return IsDetained;

        }
    }
}
