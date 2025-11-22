using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsLicenseClasses
    {
        public static DataTable GetAllLicenseClasses()
        {
            DataTable dtClasses = new DataTable();

            string query = $"SELECT * FROM LicenseClasses;";

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
                                dtClasses.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return dtClasses;
        }

        public static bool GetLicenseClassByID(int LicenseClassID, ref string ClassName, ref string ClassDescription, ref int MinimumAllowedAge,
            ref int DefaultValidityLength, ref float ClassFees)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                ClassName = reader["ClassName"].ToString();
                                ClassDescription = reader["ClassDescription"].ToString();
                                MinimumAllowedAge = int.Parse(reader["MinimumAllowedAge"].ToString());
                                DefaultValidityLength = int.Parse(reader["DefaultValidityLength"].ToString());
                                ClassFees = float.Parse(reader["ClassFees"].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }

        public static bool GetLicenseClassByName(string ClassName, ref int LicenseClassID, ref string ClassDescription, ref int MinimumAllowedAge,
            ref int DefaultValidityLength, ref float ClassFees)
        {
            bool IsFound = false;

            string query = @"SELECT * FROM LicenseClasses WHERE ClassName = @ClassName;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    try
                    {
                        cmd.Parameters.AddWithValue("@ClassName", ClassName);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                IsFound = true;

                                LicenseClassID = int.Parse(reader[0].ToString());
                                ClassDescription = reader["ClassDescription"].ToString();
                                MinimumAllowedAge = int.Parse(reader["MinimumAllowedAge"].ToString());
                                DefaultValidityLength = int.Parse(reader["DefaultValidityLength"].ToString());
                                ClassFees = float.Parse(reader["ClassFees"].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return IsFound;
        }
    }
}
