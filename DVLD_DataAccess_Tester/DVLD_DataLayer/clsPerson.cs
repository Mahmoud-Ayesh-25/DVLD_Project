using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataLayer
{
    public class clsPerson
    {
        public static DataTable GetAllPeople()
        {
            DataTable people = new DataTable();

            string quiry = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName,
                            People.ThirdName, People.LastName, People.DateOfBirth, People.Gendor,
                            CASE
                            WHEN Gendor = 0 THEN 'Male'
                            ELSE 'Female'
                            END AS GendorName,
                            People.Address, People.Phone, People.Email, People.NationalityCountryID, Countries.CountryName,
                            People.ImagePath
                            FROM People INNER JOIN Countries ON
                            People.NationalityCountryID = Countries.CountryID
                            ORDER BY People.FirstName;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                people.Load(reader);
                            }
                        }
                    }
                    catch { }
                }
            }

            return people;
        }

        public static int AddNewPerson(string NationalNo, string FirtName, string SecondName, string ThirdName, string LastName
            , DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int Nationality, string ImagePath)
        {
            int PersonID = -1;

            string quiry = @"INSERT INTO People
                            VALUES
                            (
	                            @NationalNo, @FirtName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gendor,
                                @Address,  @Phone, @Email, @Nationality, @ImagePath
                            )
                            SELECT SCOPE_IDENTITY();";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirtName", FirtName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@Nationality", Nationality);

                    if (ThirdName != "" && ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (Email != "" && Email != null)
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    if (ImagePath != "" && ImagePath != null)
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    try
                    {
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int id))
                        {
                            PersonID = id;
                        }
                    }
                    catch {}
                }
            }

            return PersonID;
        }

        public static bool UpdatePerson(int PersonID, string NationalNo, string FirtName, string SecondName, string ThirdName,
            string LastName, DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int Nationality,
            string ImagePath)
        {
            bool isUpdated = false;

            string quiry = @"UPDATE People
                            SET 
                            NationalNo = @NationalNo,
                            FirstName = @FirtName,
                            SecondName = @SecondName,
                            ThirdName = @ThirdName,
                            LastName = @LastName,
                            DateOfBirth = @DateOfBirth,
                            Gendor = @Gendor,
                            Address = @Address,
                            Phone = @Phone,
                            Email = @Email,
                            NationalityCountryID = @NationalityCountryID,
                            ImagePath = @ImagePath
                            WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(quiry, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);
                    command.Parameters.AddWithValue("@FirtName", FirtName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
                    command.Parameters.AddWithValue("@Address", Address);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@NationalityCountryID", Nationality);

                    if (ThirdName != "" && ThirdName != null)
                        command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    else
                        command.Parameters.AddWithValue("@ThirdName", DBNull.Value);

                    if (Email != "" && Email != null)
                        command.Parameters.AddWithValue("@Email", Email);
                    else
                        command.Parameters.AddWithValue("@Email", DBNull.Value);

                    if (ImagePath != "" && ImagePath != null)
                        command.Parameters.AddWithValue("@ImagePath", ImagePath);
                    else
                        command.Parameters.AddWithValue("@ImagePath", DBNull.Value);

                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            isUpdated = true;
                        }
                    }
                    catch { }
                }
            }

            return isUpdated;
        }

        public static bool GetPersonInfoByID(int PersonID, ref string NationalNo, ref string FirtName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address,
            ref string Phone, ref string Email, ref int Nationality, ref string ImagePath)
        {
            bool isFound = false;

            string query = @"SELECT * FROM People WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NationalNo = reader[1].ToString();
                                FirtName = reader[2].ToString();
                                SecondName = reader[3].ToString();
                                LastName = reader[5].ToString();
                                DateOfBirth = DateTime.Parse(reader[6].ToString());
                                Gendor = byte.Parse(reader[7].ToString());
                                Address = reader[8].ToString();
                                Phone = reader[9].ToString();
                                Nationality = int.Parse(reader[11].ToString());

                                if (reader[4] != DBNull.Value)
                                    ThirdName = reader[4].ToString();
                                else
                                    ThirdName = "";

                                if (reader[10] != DBNull.Value)
                                    Email = reader[10].ToString();
                                else
                                    Email = "";

                                if (reader[12] != DBNull.Value)
                                    ImagePath = reader[12].ToString();
                                else
                                    ImagePath = "";

                                isFound = true;
                            }
                        }
                    }
                    catch { }
                }

                return isFound;
            }
        }

        public static bool GetPersonInfoByNationalNo(string NationalNo, ref int PersonID, ref string FirtName, ref string SecondName,
            ref string ThirdName, ref string LastName, ref DateTime DateOfBirth, ref byte Gendor, ref string Address,
            ref string Phone, ref string Email, ref int Nationality, ref string ImagePath)
        {
            bool isFound = false;

            string query = @"SELECT * FROM People WHERE NationalNo = @NationalNo";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    try
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PersonID = int.Parse(reader[0].ToString());
                                FirtName = reader[2].ToString();
                                SecondName = reader[3].ToString();
                                LastName = reader[5].ToString();
                                DateOfBirth = DateTime.Parse(reader[6].ToString());
                                Gendor = byte.Parse(reader[7].ToString());
                                Address = reader[8].ToString();
                                Phone = reader[9].ToString();
                                Nationality = int.Parse(reader[11].ToString());

                                if (reader[4] != DBNull.Value)
                                    ThirdName = reader[4].ToString();
                                else
                                    ThirdName = "";

                                if (reader[10] != DBNull.Value)
                                    Email = reader[10].ToString();
                                else
                                    Email = "";

                                if (reader[12] != DBNull.Value)
                                    ImagePath = reader[12].ToString();
                                else
                                    ImagePath = "";

                                isFound = true;
                            }
                        }
                    }
                    catch { }
                }
            }

            return isFound;
        }

        public static bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;

            string query = "DELETE FROM People WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        int rowsEffected = command.ExecuteNonQuery();
                        if (rowsEffected > 0)
                        {
                            isDeleted = true;
                        }
                    }
                    catch { }
                }
            }

            return isDeleted;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isExist = false;

            string query = "SELECT 1 AS Found FROM People WHERE PersonID = @PersonID;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        isExist = true;
                    }
                }
            }

            return isExist;
        }

        public static bool IsPersonExist(string NationalNo)
        {
            bool isExist = false;

            string query = "SELECT 1 AS Found FROM People WHERE NationalNo = @NationalNo;";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@NationalNo", NationalNo);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        isExist = true;
                    }
                }
            }

            return isExist;
        }
    }
}

