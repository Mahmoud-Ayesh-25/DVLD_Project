using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsCountries
    {
        static public DataTable GetAllCountries()
        {
            DataTable countries = new DataTable();

            string quiry = @"SELECT * FROM Countries";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                countries.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return countries;
        }

        static public bool GetCountryInfoByID(int ID, ref string CountryName)
        {
            bool isFound = false;

            string quiry = @"SELECT * FROM Countries
                            WHERE CountryID = @CountryID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    command.Parameters.AddWithValue("@CountryID", ID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                CountryName = reader[1].ToString();
                            }
                        }
                    }
                    catch {}
                }
            }

            return isFound;
        }

        static public bool GetCountryInfoByName(string CountryName, ref int ID)
        {
            bool isFound = false;

            string quiry = @"SELECT * FROM Countries
                            WHERE CountryName = @CountryName";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    command.Parameters.AddWithValue("@CountryName", CountryName);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ID = int.Parse(reader[0].ToString());
                            }
                        }
                    }
                    catch { }
                }
            }

            return isFound;
        }
    }
}
