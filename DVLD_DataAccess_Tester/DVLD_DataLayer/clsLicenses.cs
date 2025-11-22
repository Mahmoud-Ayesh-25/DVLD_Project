using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_DataLayer
{
    public class clsLicenses
    {
        public static DataTable GetAllLicenses()
        {
            DataTable dtLicenses = new DataTable();

            string query = @"SELECT * FROM Licenses;";

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
                                dtLicenses.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtLicenses;
        }

        public static DataTable GetDriverLicenses(int DriverID)
        {
            DataTable dtLicenses = new DataTable();

            string query = @"SELECT Licenses.LicenseID, Licenses.ApplicationID, LicenseClasses.ClassName, Licenses.IssueDate,
                            Licenses.ExpirationDate, Licenses.IsActive FROM Licenses INNER JOIN LicenseClasses ON
                            Licenses.LicenseClass = LicenseClasses.LicenseClassID
                            WHERE DriverID = @DriverID
                            ORDER BY Licenses.LicenseID DESC;";

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
                                dtLicenses.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtLicenses;
        }

        public static bool GetLicenseByID(int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClass, ref DateTime IssueDate,
            ref DateTime ExpirationDate, ref string Notes, ref float PaidFees, ref bool IsActive, ref int IssueReason, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Licenses WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@LicenseID", LicenseID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ApplicationID = int.Parse(reader[1].ToString());
                                DriverID = int.Parse(reader[2].ToString());
                                LicenseClass = int.Parse(reader[3].ToString());
                                IssueDate = DateTime.Parse(reader[4].ToString());
                                ExpirationDate = DateTime.Parse(reader[5].ToString());
                                PaidFees = float.Parse(reader[7].ToString());
                                IsActive = bool.Parse(reader[8].ToString());
                                IssueReason = int.Parse(reader[9].ToString());
                                CreatedByUserID = int.Parse(reader[10].ToString());

                                if (reader[6] == DBNull.Value)
                                {
                                    Notes = string.Empty;
                                }
                                else
                                {
                                    Notes = reader[6].ToString();
                                }
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddLicense(int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
            string Notes, float PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            int LicenseID = -1;

            string query = @"INSERT INTO Licenses
                            VALUES
                            (
	                            @ApplicationID, @DriverID, @LicenseClass, @IssueDate, @ExpirationDate, @Notes, @PaidFees,
                                @IsActive, @IssueReason, @CreatedByUserID
                            )
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
                        command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@IssueReason", IssueReason);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", Notes);
                        }

                            object obj = command.ExecuteScalar();
                        if (obj != null && int .TryParse(obj.ToString(), out int ID))
                        {
                            LicenseID = ID;
                        }
                    }
                    catch {}
                }
            }

            return LicenseID;
        }

        public static bool UpdateLicense(int LicenseID, int ApplicationID, int DriverID, int LicenseClass, DateTime IssueDate, DateTime ExpirationDate,
            string Notes, float PaidFees, bool IsActive, int IssueReason, int CreatedByUserID)
        {
            bool IsUpdate = false;

            string query = @"UPDATE Licenses
                            SET
                            ApplicationID = @ApplicationID,
                            DriverID = @DriverID,
                            LicenseClass = @LicenseClass,
                            IssueDate = @IssueDate,
                            ExpirationDate = @ExpirationDate,
                            Notes = @Notes,
                            PaidFees = @PaidFees,
                            IsActive = @IsActive,
                            IssueReason = @IssueReason,
                            CreatedByUserID = @CreatedByUserID
                            WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);
                        command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                        command.Parameters.AddWithValue("@DriverID", DriverID);
                        command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
                        command.Parameters.AddWithValue("@IssueDate", IssueDate);
                        command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@IsActive", IsActive);
                        command.Parameters.AddWithValue("@IssueReason", IssueReason);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                        {
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@Notes", Notes);
                        }

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdate = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdate;
        }

        public static bool DeactivateLicense(int LicenseID)
        {
            bool IsDeactiveted = false;

            string query = @"UPDATE Licenses
                            SET
                            IsActive = 0
                            WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LicenseID", LicenseID);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsDeactiveted = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsDeactiveted;
        }

        public static int GetActiveLicenseIDByPersonID(int PersonID, int LicenseClassID) 
        {
            int LicenseID = -1;

            string query = @"SELECT Licenses.LicenseID FROM Licenses INNER JOIN Drivers ON
                            Licenses.DriverID = Drivers.DriverID WHERE Drivers.PersonID = @PersonID
                            AND Licenses.LicenseClass = @LicenseClass AND Licenses.IsActive = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

                        object obj = command.ExecuteScalar();
                        if (obj != null && int.TryParse(obj.ToString(), out int ID))
                        {
                            LicenseID = ID;
                        }
                    }
                    catch { }
                }
            }

            return LicenseID;
        }
    }
}
