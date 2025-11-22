using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsTestAppointments
    {
        public static bool GetTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LocalDrivingLicenseAppID,
            ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestAppointment)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                TestTypeID = int.Parse(reader[1].ToString());
                                LocalDrivingLicenseAppID = int.Parse(reader[2].ToString());
                                AppointmentDate = DateTime.Parse(reader[3].ToString());
                                PaidFees = float.Parse(reader[4].ToString());
                                CreatedByUserID = int.Parse(reader[5].ToString());
                                IsLocked = bool.Parse(reader[6].ToString());

                                if (reader[7] != DBNull.Value)
                                    RetakeTestAppointment = int.Parse(reader[7].ToString());
                                else
                                    RetakeTestAppointment = -1;
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static bool GetLastTestAppointment(int LocalDrivingLicenseAppID, int TestTypeID, ref int TestAppointmentID,
            ref DateTime AppointmentDate, ref float PaidFees, ref int CreatedByUserID, ref bool IsLocked, ref int RetakeTestAppointment)
        {
            bool IsFound = false;

            string query = @"SELECT TOP 1 * FROM TestAppointments WHERE TestTypeID = @TestTypeID
                            AND LocalDrivingLicenseApplicationID = @LDLAppID ORDER BY TestAppointmentID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseAppID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                TestAppointmentID = int.Parse(reader[0].ToString());
                                AppointmentDate = DateTime.Parse(reader[3].ToString());
                                PaidFees = float.Parse(reader[4].ToString());
                                CreatedByUserID = int.Parse(reader[5].ToString());
                                IsLocked = bool.Parse(reader[6].ToString());

                                if (reader[7] != DBNull.Value)
                                    RetakeTestAppointment = int.Parse(reader[7].ToString());
                                else
                                    RetakeTestAppointment = -1;
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static DataTable GetAllTestAppointments()
        {
            DataTable dtAppointments = new DataTable();

            string query = @"SELECT TestAppointments.TestAppointmentID, TestAppointments.LocalDrivingLicenseApplicationID,
                            TestTypes.TestTypeTitle, LicenseClasses.ClassName, TestAppointments.AppointmentDate, TestAppointments.PaidFees,
                            (People.FirstName + ' ' + People.SecondName + ' ' + CASE WHEN People.ThirdName IS NULL THEN '' ELSE People.ThirdName
                            + ' ' END + People.LastName)AS FullName,
                            TestAppointments.IsLocked FROM TestAppointments INNER JOIN TestTypes ON TestAppointments.TestTypeID
                            = TestTypes.TestTypeID INNER JOIN
                            LocalDrivingLicenseApplications ON TestAppointments.LocalDrivingLicenseApplicationID = 
                            LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID INNER JOIN LicenseClasses
                            ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID INNER JOIN Applications
                            ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID INNER JOIN
                            People ON Applications.ApplicantPersonID = People.PersonID;";

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
                                dtAppointments.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtAppointments;
        }

        public static DataTable GetApplicaitonTestAppointmentByTestType(int LDLAppID, int TestType)
        {
            DataTable dtAppointment = new DataTable();

            string query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked
                            FROM TestAppointments WHERE 
                            LocalDrivingLicenseApplicationID = @LDLAppID AND 
                            TestTypeID = @TestTypeID ORDER BY TestAppointmentID DESC;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@LDLAppID", LDLAppID);
                        cmd.Parameters.AddWithValue("@TestTypeID", TestType);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtAppointment.Load(reader);
                            }
                        }
                    }
                    catch {}
                }
            }

            return dtAppointment;
        }

        public static int AddTestAppointment(int TestTypeID, int LocalDrivingLicenseAppID, DateTime AppointmentDate,
            float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestAppointment)
        {
            int appointmentID = -1;

            string query = @"INSERT INTO TestAppointments
                            VALUES
                            (
	                            @TestTypeID, @LDLAppID, @Date, @PaidFees, @CreatedBy, @IsLocked, @Retake
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseAppID);
                        command.Parameters.AddWithValue("@Date", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestAppointment == -1)
                            command.Parameters.AddWithValue("@Retake", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Retake", RetakeTestAppointment);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            appointmentID = id;
                        }
                    }
                    catch { }
                }
            }

            return appointmentID;
        }

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LocalDrivingLicenseAppID, DateTime AppointmentDate,
            float PaidFees, int CreatedByUserID, bool IsLocked, int RetakeTestAppointment)
        {
            bool IsUpdated = false;

            string query = @"UPDATE TestAppointments
                            SET
                            TestTypeID = @TestTypeID,
                            LocalDrivingLicenseApplicationID = @LDLAppID,
                            AppointmentDate = @Date,
                            PaidFees = @PaidFees,
                            CreatedByUserID = @CreatedBy,
                            IsLocked = @IsLocked,
                            RetakeTestApplicationID = @Retake
                            WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
                        command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
                        command.Parameters.AddWithValue("@LDLAppID", LocalDrivingLicenseAppID);
                        command.Parameters.AddWithValue("@Date", AppointmentDate);
                        command.Parameters.AddWithValue("@PaidFees", PaidFees);
                        command.Parameters.AddWithValue("@CreatedBy", CreatedByUserID);
                        command.Parameters.AddWithValue("@IsLocked", IsLocked);

                        if (RetakeTestAppointment == -1)
                            command.Parameters.AddWithValue("@Retake", DBNull.Value);
                        else
                            command.Parameters.AddWithValue("@Retake", RetakeTestAppointment);

                        int rowsEffected = command.ExecuteNonQuery();
                        IsUpdated = (rowsEffected > 0);
                    }
                    catch { }
                }
            }

            return IsUpdated;
        }

        public static int GetTestID(int TestAppointmentID)
        {
            int TestID = -1;

            string query = @"SELECT TestID FROM Tests WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    try
                    {
                        command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            TestID = id;
                        }
                    }
                    catch { }
                }
            }
            return TestID;
        }
    }
}
