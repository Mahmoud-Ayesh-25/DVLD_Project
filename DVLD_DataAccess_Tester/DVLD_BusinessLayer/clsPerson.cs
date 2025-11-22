using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        enum Modes { AddNew = 1, Update }
        Modes Mode = Modes.AddNew;

        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string FullName { get; }

        public DateTime DateOfBirth { get; set; }
        public byte Gendor { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public int NationalityID { get; set; }
        public clsCountries Country { get; }

        public string ImagePath { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = new DateTime();
            Gendor = 0;
            Address = "";
            Phone = "";
            Email = "";
            NationalityID = -1;
            ImagePath = "";

            Mode = Modes.AddNew;
        }

        private clsPerson(int PersonID, string NationalNo, string FirtName, string SecondName, string ThirdName, string LastName
            , DateTime DateOfBirth, byte Gendor, string Address, string Phone, string Email, int NationalityID, string ImagePath)
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirtName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;

            this.FullName = _SetFullName();

            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;

            this.NationalityID = NationalityID;
            this.Country = clsCountries.Find(NationalityID);

            this.ImagePath = ImagePath;

            Mode = Modes.Update;
        }

        string _SetFullName()
        {
            return $"{FirstName} {SecondName}{((ThirdName != "" && ThirdName != null) ? $" {ThirdName}" : "")} {LastName}";
        }

        static public DataTable GetAllPeople()
        {
            return DVLD_DataLayer.clsPerson.GetAllPeople();
        }

        bool _AddNewPerosn()
        {
            PersonID = DVLD_DataLayer.clsPerson.AddNewPerson(NationalNo, FirstName, SecondName, ThirdName, LastName,
                        DateOfBirth, Gendor, Address, Phone, Email, NationalityID, ImagePath);

            return (PersonID != -1);
        }

        bool _UpdatePerosn()
        {
            return DVLD_DataLayer.clsPerson.UpdatePerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName,
                        DateOfBirth, Gendor, Address, Phone, Email, NationalityID, ImagePath);
        }

        public bool Save()
        {
            switch (Mode)
            {  
                case Modes.AddNew:
                    {
                        if (_AddNewPerosn())
                        {
                            Mode = Modes.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case Modes.Update:
                    {
                        return _UpdatePerosn();
                    }
                default: return false;
            }
        }

        public static clsPerson Find(int PersonID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityID = -1;
            string ImagePath = "";

            if (DVLD_DataLayer.clsPerson.GetPersonInfoByID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor
                    , Address, Phone, Email, NationalityID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static clsPerson Find(string NationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = new DateTime();
            byte Gendor = 0;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityID = -1;
            string ImagePath = "";

            if (DVLD_DataLayer.clsPerson.GetPersonInfoByNationalNo(NationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName,
                ref LastName, ref DateOfBirth, ref Gendor, ref Address, ref Phone, ref Email, ref NationalityID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gendor
                    , Address, Phone, Email, NationalityID, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static bool DeletePerson(int PersonID)
        {
            return DVLD_DataLayer.clsPerson.DeletePerson(PersonID);
        }

        public static bool IsPersonExist(int PersonID)
        {
            return DVLD_DataLayer.clsPerson.IsPersonExist(PersonID);
        }

        public static bool IsPersonExist(string NationalNo)
        {
            return DVLD_DataLayer.clsPerson.IsPersonExist(NationalNo);
        }

    }
}
