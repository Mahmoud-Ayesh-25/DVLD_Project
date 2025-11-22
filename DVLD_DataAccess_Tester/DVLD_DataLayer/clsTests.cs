using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsTests
    {
        public static bool GetTestInfoByID(int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM Tests WHERE TestID = @TestID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestID", TestID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                TestAppointmentID = int.Parse(reader[1].ToString());
                                TestResult = bool.Parse(reader[2].ToString());
                                CreatedByUserID = int.Parse(reader[4].ToString());

                                if (reader[3] == DBNull.Value)
                                    Notes = string.Empty;
                                else
                                    Notes = reader[3].ToString();
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static DataTable GetAllTests()
        {
            DataTable dtTests = new DataTable();

            string query = @"SELECT * FROM Tests;";

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
                                dtTests.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtTests;
        }

        public static bool GetLastTestByPersonIDAndTestTypeIDAndLicenseClassID(int PersonID, int TestTypeID, int LicenseClassID,
            ref int TestID, ref int TestAppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string query = @"SELECT TOP 1 Tests.TestID, Tests.TestAppointmentID, Tests.TestResult, Tests.Notes, Tests.CreatedByUserID
                            FROM Tests INNER JOIN TestAppointments ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                            INNER JOIN LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = 
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN Applications ON
                            LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID WHERE
                            Applications.ApplicantPersonID = @PersonID AND TestAppointments.TestTypeID = @TestTypeID
                            AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
                            ORDER BY Tests.TestID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@PersonID", PersonID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                TestID = int.Parse(reader[0].ToString());
                                TestAppointmentID = int.Parse(reader[1].ToString());
                                TestResult = bool.Parse(reader[2].ToString());
                                CreatedByUserID = int.Parse(reader[4].ToString());

                                if (reader[3] == DBNull.Value)
                                    Notes = string.Empty;
                                else
                                    Notes = reader[3].ToString();
                            }
                        }
                    }
                    catch {}
                }
            }

            return IsFound;
        }

        public static int GetPassedTestCount(int LocalDrivingLicenseApplicationID)
        {
            int Count = -1;

            string query = @"SELECT TestCount = COUNT(Tests.TestID) FROM Tests INNER JOIN TestAppointments ON
                            Tests.TestAppointmentID = TestAppointments.TestAppointmentID WHERE 
                            TestAppointments.LocalDrivingLicenseApplicationID = @LDLAppID AND Tests.TestResult = 1;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseApplicationID);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int count))
                        {
                            Count = count;
                        }
                    }
                    catch { }
                }
            }

            return Count;
        }

        public static int AddTest(int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int ID = -1;

            string query = @"INSERT INTO Tests
                            VALUES
                            (
	                            @TestAppointmentID, @TestResult, @Notes, @CreatedByUserID 
                            )
                            SELECT SCOPE_IDENTITY();

                            UPDATE TestAppointments
                            SET
                            IsLocked = 1
                            WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query,connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

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

        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            bool IsUpdate = false;

            string query = @"UPDATE Tests
                            SET
                            TestAppointmentID = @TestAppointmentID,
                            TestResult = @TestResult,
                            Notes = @Notes,
                            CreatedByUserID = @CreatedByUserID
                            WHERE TestID = @TestID;";

            using (SqlConnection connection = new SqlConnection (clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestID", TestID);
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestResult", TestResult);
                        command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

                        if (string.IsNullOrEmpty(Notes))
                            command.Parameters.AddWithValue("@Notes", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Notes", Notes);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdate = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdate;
        }
    }
}
