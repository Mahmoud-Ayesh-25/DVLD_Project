using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsGeneralApplications
    {
        public static DataTable GetAllApplications()
        {
            DataTable dtApps = new DataTable();

            string query = $"SELECT * FROM Applications;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtApps.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtApps;
        }

        public static bool GetApplicationByID(int ID, ref int PersonID, ref DateTime Date, ref int TypeID, ref int Status,
            ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM Applications WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", ID);

                    try
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = int.Parse(reader[1].ToString());
                                Date = (DateTime)reader[2];
                                TypeID = int.Parse(reader[3].ToString());
                                Status = int.Parse(reader[4].ToString());
                                LastStatusDate = (DateTime)reader[5];
                                PaidFees = float.Parse(reader[6].ToString());
                                CreatedByUserID = int.Parse(reader[7].ToString());

                                IsFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static int AddNewApplication(int PersonID, int TypeID, int Status, float PaidFees, int CreatedByUserID)
        {
            int ID = -1;

            string query = @"INSERT INTO Applications
                            VALUES
                            (
	                            @PersonID, @Date, @Type, @Status, @LastStatusDate, @PaidFees, @CreatedByUserID
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PersonID", PersonID);
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Type", TypeID);
                    cmd.Parameters.AddWithValue("@Status", Status);
                    cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                    try
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            ID = id;
                        }
                    }
                    catch { }
                }
            }

            return ID;
        }

        public static bool UpdateApplication(int ID, int PersonID, int TypeID, int Status, float PaidFees, int CreatedByUserID)
        {
            bool IsUpdate = false;

            string query = @"UPDATE Applications
                            SET
                            ApplicantPersonID = @ApplicantPersonID,
                            ApplicationTypeID = @ApplicationTypeID,
                            ApplicationStatus = @ApplicationStatus,
                            LastStatusDate = @LastStatusDate,
                            PaidFees = @PaidFees,
                            CreatedByUserID = @CreatedByUserID
                            WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", TypeID);
                    cmd.Parameters.AddWithValue("@ApplicationStatus", Status);
                    cmd.Parameters.AddWithValue("@LastStatusDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
                    cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    cmd.Parameters.AddWithValue("@ApplicationID", ID);

                    try
                    {
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            IsUpdate = true;
                        }
                    }
                    catch { }
                }
            }

            return IsUpdate;
        }

        public static bool DeleteApplication(int ID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", ID);

                    try
                    {
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            IsDeleted = true;
                        }
                    }
                    catch {}
                }
            }

            return IsDeleted;
        }

        public static bool IsApplicationExist(int ID)
        {
            bool isExist = false;

            string query = @"SELECT 1 FROM Applications WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", ID);

                    try
                    {
                        object result = cmd.ExecuteScalar();
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

        public static int GetActiveApplicationID(int PersonID, int TypeID)
        {
            int ActiveAppID = -1;

            string query = @"SELECT ApplicationID FROM Applications WHERE ApplicantPersonID = @ApplicantPersonID
                            AND ApplicationTypeID = @ApplicationTypeID AND ApplicationStatus = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", TypeID);

                    try
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            ActiveAppID = id;
                        }
                    }
                    catch { }
                }
            }

            return ActiveAppID;
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID, int TypeID,  int LicenseClassID)
        {
            int ActiveAppID = -1;

            string query = @"SELECT Applications.ApplicationID FROM Applications
                            INNER JOIN LocalDrivingLicenseApplications ON
                            Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            WHERE Applications.ApplicantPersonID = @ApplicantPersonID
                            AND Applications.ApplicationTypeID = @ApplicationTypeID
                            AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            AND Applications.ApplicationStatus = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicantPersonID", PersonID);
                    cmd.Parameters.AddWithValue("@ApplicationTypeID", TypeID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                    try
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            ActiveAppID = id;
                        }
                    }
                    catch { }
                }
            }

            return ActiveAppID;
        }

        public static bool UpdateStatus(int ID, int Status)
        {
            bool isUpdate = false;

            string query = @"UPDATE Applications
                            SET ApplicationStatus = @ApplicationStatus
                            WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue ("@ApplicationStatus", Status);
                    cmd.Parameters.AddWithValue ("@ApplicationID", ID);

                    try
                    {
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            isUpdate = true;
                        }
                    }
                    catch {}
                }
            }

            return isUpdate;
        }
    }
}
