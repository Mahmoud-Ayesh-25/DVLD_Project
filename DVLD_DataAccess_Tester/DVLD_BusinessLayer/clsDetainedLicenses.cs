using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDetainedLicenses
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;


        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }

        public float FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public clsUser CreatedByUserInfo { set; get; }
        public bool IsReleased { set; get; }
        public DateTime ReleaseDate { set; get; }
        public int ReleasedByUserID { set; get; }
        public clsUser ReleasedByUserInfo { set; get; }
        public int ReleaseApplicationID { set; get; }

        public clsDetainedLicenses()

        {
            this.DetainID = -1;
            this.LicenseID = -1;
            this.DetainDate = DateTime.Now;
            this.FineFees = 0;
            this.CreatedByUserID = -1;
            this.IsReleased = false;
            this.ReleaseDate = DateTime.MaxValue;
            this.ReleasedByUserID = 0;
            this.ReleaseApplicationID = -1;



            Mode = enMode.AddNew;

        }

        clsDetainedLicenses(int DetainID,
            int LicenseID, DateTime DetainDate,
            float FineFees, int CreatedByUserID,
            bool IsReleased, DateTime ReleaseDate,
            int ReleasedByUserID, int ReleaseApplicationID)

        {
            this.DetainID = DetainID;
            this.LicenseID = LicenseID;
            this.DetainDate = DetainDate;
            this.FineFees = FineFees;
            this.CreatedByUserID = CreatedByUserID;
            this.CreatedByUserInfo = clsUser.FindByID(this.CreatedByUserID);
            this.IsReleased = IsReleased;
            this.ReleaseDate = ReleaseDate;
            this.ReleasedByUserID = ReleasedByUserID;
            this.ReleaseApplicationID = ReleaseApplicationID;
            this.ReleasedByUserInfo = clsUser.FindByPersonID(this.ReleasedByUserID);
            Mode = enMode.Update;
        }

        public static DataTable GetAllDetainedLicenses()
        {
            return DVLD_DataLayer.clsDetainedLicenses.GetAllDetainedLicenses();
        }

        public static clsDetainedLicenses Find(int ID)
        {
            int LicenseID = -1; DateTime DetainDate = DateTime.Now;
            float FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (DVLD_DataLayer.clsDetainedLicenses.GetDetainedLicenseByID(ID, ref LicenseID, ref DetainDate, ref FineFees
                , ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(ID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                    ReleasedByUserID, ReleaseApplicationID);
            }
            else return null;
        }

        public static clsDetainedLicenses FindByLicenseID(int LicenseID)
        {
            int ID = -1; DateTime DetainDate = DateTime.Now;
            float FineFees = 0; int CreatedByUserID = -1;
            bool IsReleased = false; DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1; int ReleaseApplicationID = -1;

            if (DVLD_DataLayer.clsDetainedLicenses.GetDetainedLicenseByLicenseID(LicenseID, ref ID, ref DetainDate, ref FineFees
                , ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID))
            {
                return new clsDetainedLicenses(ID, LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased, ReleaseDate,
                    ReleasedByUserID, ReleaseApplicationID);
            }
            else return null;
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return DVLD_DataLayer.clsDetainedLicenses.IsLicenseDetained(LicenseID);
        }

        public bool ReleaseDetainLicense(int ReleasedByUserID, int ReleaseApplicationID)
        {
            return DVLD_DataLayer.clsDetainedLicenses.ReleaseDetainedLicense(DetainID, ReleasedByUserID, ReleaseApplicationID);
        }

        bool Add()
        {
            DetainID = DVLD_DataLayer.clsDetainedLicenses.AddNewDetainedLicense(LicenseID, DetainDate, FineFees, CreatedByUserID);

            return (DetainID != -1);
        }

        bool Update()
        {
            return DVLD_DataLayer.clsDetainedLicenses.UpdateDetainedLicense(DetainID, LicenseID, DetainDate, FineFees, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else { return false; }
                    }
                case enMode.Update: return (Update());
                default: return false;
            }
        }

        public static int ReleaseLicense(int LicenseID, int CreatedByUserID)
        {
            clsLicenses license = clsLicenses.Find(LicenseID);
            if (license == null) return -1;

            if (!license.IsLicenseDetained()) return -1;

            clsGeneralApplications app = new clsGeneralApplications();

            app.PersonID = license.Driver.PersonID;
            app.Date = DateTime.Now;
            app.TypeID = 5;
            app.Status = 3;
            app.LastStatusDate = DateTime.Now;
            app.PaidFees = clsApplicationTypes.GetApplicationTypeByID(5).ApplicationTypeFees;
            app.CreatedByUserID = CreatedByUserID;

            if (!app.Save()) return -1;

            clsDetainedLicenses detained = clsDetainedLicenses.FindByLicenseID(license.LicenseID);
            if (detained == null) return -1;

            if (!detained.ReleaseDetainLicense(CreatedByUserID, app.GAppID)) return -1;

            return app.GAppID;
        }
    }
}
