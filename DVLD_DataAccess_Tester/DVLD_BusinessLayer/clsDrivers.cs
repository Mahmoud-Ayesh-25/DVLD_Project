using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDrivers
    {
        enum enMode { Add = 1, Update }
        enMode Mode;

        public int DriverID { get; set; }
        public int PersonID { get; set; }
        public clsPerson Person { get; set; }
        public DateTime Date {  get; set; }
        public int CreatedByUser { get; set; }

        public clsDrivers()
        {
            Mode = enMode.Add;

            DriverID = -1;
            PersonID = -1;
            Person = new clsPerson();
            Date = new DateTime();
            CreatedByUser = -1;
        }

        clsDrivers(int driverID, int personID, DateTime date, int createdByUser)
        {
            Mode = enMode.Update;

            DriverID = driverID;
            PersonID = personID;
            Person = clsPerson.Find(PersonID);
            Date = date;
            CreatedByUser = createdByUser;
        }

        bool Add()
        {
            DriverID = DVLD_DataLayer.clsDrivers.AddDriver(PersonID, CreatedByUser);

            return (DriverID != -1);
        }

        bool Update()
        {
            return DVLD_DataLayer.clsDrivers.UpdateDriver(DriverID, PersonID, CreatedByUser);
        }

        public static clsDrivers FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            DateTime Date = new DateTime();
            int CreatedByUserID = -1;

            if (DVLD_DataLayer.clsDrivers.FindByDriverID(DriverID, ref PersonID, ref Date, ref CreatedByUserID))
            {
                return new clsDrivers(DriverID, PersonID, Date, CreatedByUserID);
            }
            else return null;
        }

        public static clsDrivers FindByPersonID(int PersonID)
        {
            int DriverID = -1;
            DateTime Date = new DateTime();
            int CreatedByUserID = -1;

            if (DVLD_DataLayer.clsDrivers.FindByPerosnID(PersonID, ref DriverID, ref Date, ref CreatedByUserID))
            {
                return new clsDrivers(DriverID, PersonID, Date, CreatedByUserID);
            }
            else return null;
        }

        public bool Save()
        {
            switch(Mode)
            {
                case enMode.Add:
                    {
                        if (Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return (Update());
                    }
                default: return false;
            }
        }

        public static DataTable GetAllDrivers()
        {
            return DVLD_DataLayer.clsDrivers.GetAllDrivers();
        }

        public DataTable GetDriverLocalLicenses()
        {
            return clsLicenses.GetDriverLicenses(DriverID);
        }
    }
}
