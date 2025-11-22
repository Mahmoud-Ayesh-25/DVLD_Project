using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsTestTypes
    {
        public static DataTable GetAllTestTypes()
        {
            DataTable dtTestTypes = new DataTable();

            string query = $"SELECT * FROM TestTypes;";

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
                                dtTestTypes.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtTestTypes;
        }

        public static bool FindTestTypeByID(int ID, ref string Title, ref string Description, ref float Fees)
        {
            bool IsFound = false;

            string query = $"SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TestTypeID", ID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                Title = reader[1].ToString();
                                Description = reader[2].ToString();
                                Fees = float.Parse(reader[3].ToString());
                            }
                        }
                    }
                    catch {}
                }
            }

            return IsFound;
        }

        public static int AddNewTestType(string Title, string Description, float Fees)
        {
            int testTypeID = -1;

            string query = @"INSERT INTO TestTypes
                            VALUES
                            (
	                            @Title, @Description, @Fees
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Title", Title);
                    command.Parameters.AddWithValue("@Description", Description);
                    command.Parameters.AddWithValue("@Fees", Fees);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            testTypeID = id;
                        }
                    }
                    catch { }
                }
            }

            return testTypeID;
        }

        public static bool UpdateTestType(int ID, string Title, string Description, float Fees)
        {
            bool IsUpdated = false;

            string query = @"UPDATE TestTypes
                            SET
                            TestTypeTitle = @TestTypeTitle,
                            TestTypeDescription = @TestTypeDescription,
                            TestTypeFees = @TestTypeFees
                            WHERE TestTypeID = @TestTypeID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@TestTypeTitle", Title);
                    cmd.Parameters.AddWithValue("@TestTypeDescription", Description);
                    cmd.Parameters.AddWithValue("@TestTypeFees", Fees);
                    cmd.Parameters.AddWithValue("@TestTypeID", ID);

                    try
                    {
                        int rowsEffected = cmd.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            IsUpdated = true;
                        }
                    }
                    catch {}
                }
            }

            return IsUpdated;
        }
    }
}
