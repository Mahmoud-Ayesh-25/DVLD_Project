using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsInternationalLicense
    {
        public static bool GetInternationalLicenseByID(int InternationalLicenseID, ref int ApplicationID, ref int DriverID,
            ref int IssuedUsingLocalLicenseID, ref DateTime IssueDate, ref DateTime ExpirationDate, ref bool IsActive,
            ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @InternationalLicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationID = int.Parse(reader[1].ToString());
                                DriverID = int.Parse(reader[2].ToString());
                                IssuedUsingLocalLicenseID = int.Parse(reader[3].ToString());
                                IssueDate = DateTime.Parse(reader[4].ToString());
                                ExpirationDate = DateTime.Parse(reader[5].ToString());
                                IsActive = (bool)reader[6];
                                CreatedByUserID = int.Parse(reader[7].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static DataTable GetAllInternationalLicenses()
        {
            DataTable dtInterLicenses = new DataTable();

            string query = @"SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                            IssueDate, ExpirationDate, IsActive
                            FROM InternationalLicenses ORDER BY IsActive, ExpirationDate DESC;";

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
                                dtInterLicenses.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtInterLicenses;
        }

        public static DataTable GetDriverInternationalLicense(int DriverID)
        {
            DataTable dtInterLicenses = new DataTable();

            string query = @"SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                            IssueDate, ExpirationDate, IsActive
                            FROM InternationalLicenses WHERE DriverID = @DriverID 
                            ORDER BY IsActive, ExpirationDate DESC;";

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
                            if (reader.HasRows)
                            {
                                dtInterLicenses.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtInterLicenses;
        }

        public static int GetDriverActiveInternationalLicenseID(int DriverID)
        {
            int InterLicenseID = -1;

            string query = @"SELECT TOP 1 InternationalLicenseID
                            FROM InternationalLicenses 
                            WHERE DriverID=@DriverID AND GetDate() BETWEEN IssueDate AND ExpirationDate 
                            ORDER BY ExpirationDate DESC";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@DriverID", DriverID);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            InterLicenseID = id;
                        }
                    }
                    catch {}
                }
            }

            return InterLicenseID;
        }

        public static int AddNewInterLicense(int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID, DateTime IssueDate,
            DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            int InterLicID = -1;

            string query = @"UPDATE InternationalLicenses 
                            SET IsActive=0
                            WHERE DriverID=@DriverID;

                            INSERT INTO InternationalLicenses
                               (ApplicationID,
                                DriverID,
                                IssuedUsingLocalLicenseID,
                                IssueDate,
                                ExpirationDate,
                                IsActive,
                                CreatedByUserID)
                                VALUES
                               (@ApplicationID,
                                @DriverID,
                                @IssuedUsingLocalLicenseID,
                                @IssueDate,
                                @ExpirationDate,
                                @IsActive,
                                @CreatedByUserID);
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            InterLicID = id;
                        }
                    }
                    catch { }
                }
            }

            return InterLicID;
        }

        public static bool UpdateInterLicense(int InternationalLicenseID, int ApplicationID, int DriverID, int IssuedUsingLocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive, int CreatedByUserID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE InternationalLicenses
                            SET 
                                ApplicationID = @ApplicationID,
                                DriverID = @DriverID,
                                IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                                IssueDate = @IssueDate,
                                ExpirationDate = @ExpirationDate,
                                IsActive = @IsActive,
                                CreatedByUserID = @CreatedByUserID
                            WHERE InternationalLicenseID = @InternationalLicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", IssuedUsingLocalLicenseID);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
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
