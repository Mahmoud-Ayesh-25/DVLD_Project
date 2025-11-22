using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsLocalDrivingLicenseApplicaiton
    {
        public static bool GetLDLAppInfoByID(int ID, ref int GeneralAppID, ref int LicenseClassID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE
                            LocalDrivingLicenseApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                GeneralAppID = int.Parse(reader[1].ToString());
                                LicenseClassID = int.Parse(reader[2].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static bool GetLDLAppInfoByGeneralAppID(int GeneralAppID, ref int ID, ref int LicenseClassID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM LocalDrivingLicenseApplications WHERE
                            ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", GeneralAppID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ID = int.Parse(reader[0].ToString());
                                LicenseClassID = int.Parse(reader[2].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static DataTable GetAllLDLApps()
        {
            DataTable dtApps = new DataTable();

            string query = @"SELECT LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID, LicenseClasses.ClassName,
                            People.NationalNo, (People.FirstName + ' ' + People.SecondName + ' ' +
                            (CASE WHEN People.ThirdName IS NULL THEN '' ELSE People.ThirdName + ' ' END) + People.LastName) AS FullName,
                            Applications.ApplicationDate, 
                            (SELECT COUNT(Tests.TestID) FROM Tests INNER JOIN TestAppointments ON
                            Tests.TestAppointmentID = TestAppointments.TestAppointmentID WHERE
                            TestAppointments.LocalDrivingLicenseApplicationID =
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID AND Tests.TestResult = 1) AS PasssedTests,
                            CASE
                            WHEN Applications.ApplicationStatus = 1 THEN 'New'
                            WHEN Applications.ApplicationStatus = 2 THEN 'Cancelled'
                            WHEN Applications.ApplicationStatus = 3 THEN 'Completed'
                            END AS Status
                            FROM LocalDrivingLicenseApplications INNER JOIN LicenseClasses ON
                            LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID
                            INNER JOIN Applications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                            INNER JOIN People ON Applications.ApplicantPersonID = People.PersonID;";

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
                    catch {}
                }
            }

            return dtApps;
        }

        public static int AddNewLDLApp(int GeneralAppID, int LicenseClassID)
        {
            int ID = -1;

            string query = @"INSERT INTO LocalDrivingLicenseApplications
                            VALUES
                            (
	                            @ApplicaitonID, @LicenseClass
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicaitonID", GeneralAppID);
                    command.Parameters.AddWithValue("@LicenseClass", LicenseClassID);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            ID = id;
                        }
                    }
                    catch {}
                }
            }

            return ID;
        }

        public static bool UpdateLDLApp(int ID, int GeneralAppID, int LicenseClassID)
        {
            bool IsUpdated = false;

            string query = @"UPDATE LocalDrivingLicenseApplications
                            SET
                            ApplicationID = @ApplicationID,
                            LicenseClassID = @LicenseClassID
                            WHERE LocalDrivingLicenseApplicationID = @LDLAppID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ApplicationID", GeneralAppID);
                    cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
                    cmd.Parameters.AddWithValue("@LDLAppID", ID);

                    try
                    {
                        int rowsEffected = cmd.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static bool DeleteLDLApp(int ID)
        {
            bool IsDeleted = false;

            string query = @"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @ID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using(SqlCommand cmd = new SqlCommand(query,connection))
                {
                    cmd.Parameters.AddWithValue("@ID", ID);

                    try
                    {
                        int rowsEffected = cmd.ExecuteNonQuery();
                        IsDeleted = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsDeleted;
        }

        public static bool DoesPassTestType(int LDLAppID, int TestTypeID)
        {
            bool Result = false;

            string query = @"SELECT TOP 1 Tests.TestResult FROM Tests INNER JOIN TestAppointments ON
                            Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                            LocalDrivingLicenseApplications ON
                            TestAppointments.LocalDrivingLicenseApplicationID
                            = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                            WHERE TestAppointments.TestTypeID = @TestTypeID AND
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID
                            ORDER BY TestAppointments.TestAppointmentID DESC;";

            using (SqlConnection connection = new SqlConnection (clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                        object result = cmd.ExecuteScalar();
                        if (result != null && bool.TryParse(result.ToString(), out bool finalRes))
                        {
                            Result = finalRes;
                        }
                    }
                    catch { }
                }
            }

            return Result;
        }

        public static bool DoesAttendTestType(int LDLAppID, int TestTypeID)
        {
            bool IsAttend = false;

            string query = @"SELECT TOP 1 FOUND = 1 FROM Tests INNER JOIN TestAppointments ON
                            Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                            LocalDrivingLicenseApplications ON
                            TestAppointments.LocalDrivingLicenseApplicationID
                            = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                            WHERE TestAppointments.TestTypeID = @TestTypeID AND
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LDLAppID
                            ORDER BY TestAppointments.TestAppointmentID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            IsAttend = true;
                        }
                    }
                    catch { }
                }
            }

            return IsAttend;
        }

        public static int TotalTrailsPerTestType(int LDLAppID, int TestTypeID)
        {
            int Trails = -1;

            string query = @"SELECT COUNT(Tests.TestID) AS Total FROM Tests
                            INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID INNER JOIN
                            LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = 
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
                            WHERE TestAppointments.TestTypeID = @TestTypeID AND TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                        object result = cmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int trails))
                        {
                            Trails = trails;
                        }
                    }
                    catch { }
                }
            }

            return Trails;
        }

        public static bool IsThereAnActiveScheduleTest(int LDLAppID, int TestTypeID)
        {
            bool IsThere = false;

            string query = @"SELECT TOP 1 FOUND = 1 FROM TestAppointments
                            WHERE LocalDrivingLicenseApplicationID = @LDLAppID
                            AND TestTypeID = @TestTypeID ORDER BY TestAppointmentID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);

                        object result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            IsThere = true;
                        }
                    }
                    catch { }
                }
            }

            return IsThere;
        }
    }
}
