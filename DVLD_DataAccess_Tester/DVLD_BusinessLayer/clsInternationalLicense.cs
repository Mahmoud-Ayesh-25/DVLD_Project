using DVLD_DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static DVLD_BusinessLayer.clsGeneralApplications;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicense : clsGeneralApplications
    {
        enum enMode { Add = 1, Update}
        enMode Mode;

        public clsDrivers DriverInfo;
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        public clsInternationalLicense()
        {
            base.TypeID = (int)clsGeneralApplications.enApplicationTypes.NewInternational;

            this.InternationalLicenseID = -1;
            this.DriverID = -1;
            this.IssuedUsingLocalLicenseID = -1;
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;

            this.IsActive = true;

            Mode = enMode.Add;
        }

        clsInternationalLicense(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
             clsGeneralApplications.enApplicationStatuses ApplicationStatus, DateTime LastStatusDate,
             float PaidFees, int CreatedByUserID, int InternationalLicenseID, int DriverID,
             int IssuedUsingLocalLicenseID, DateTime IssueDate, DateTime ExpirationDate, bool IsActive)
        {
            base.GAppID = ApplicationID;
            base.PersonID = ApplicantPersonID;
            base.Date = ApplicationDate;
            base.Status = (int)ApplicationStatus;
            base.TypeID = (int)clsGeneralApplications.enApplicationTypes.NewInternational;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            this.DriverInfo = clsDrivers.FindByPersonID(ApplicantPersonID);
            this.InternationalLicenseID = InternationalLicenseID;
            this.GAppID = ApplicationID;
            this.DriverID = DriverID;
            this.IssuedUsingLocalLicenseID = IssuedUsingLocalLicenseID;
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.IsActive = IsActive;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        public static DataTable GetAllInterLicenses()
        {
            return DVLD_DataLayer.clsInternationalLicense.GetAllInternationalLicenses();
        }

        public static clsInternationalLicense FindInterLicense(int ID)
        {
            int DriverID = -1;
            int AppID = -1;
            int IssuedUsingLicenseID = -1;
            DateTime IssueDate = new DateTime();
            DateTime ExDate = new DateTime();
            bool IsActive = true;
            int CreatedByUserID = -1;

            if (DVLD_DataLayer.clsInternationalLicense.GetInternationalLicenseByID(ID, ref AppID, ref DriverID, ref IssuedUsingLicenseID,
                ref IssueDate, ref ExDate, ref IsActive, ref CreatedByUserID))
            {
                clsGeneralApplications gApp = clsGeneralApplications.Find(AppID);

                return new clsInternationalLicense(AppID, gApp.PersonID, gApp.Date, (enApplicationStatuses)gApp.Status, gApp.LastStatusDate
                    , gApp.PaidFees, gApp.CreatedByUserID, ID, DriverID, IssuedUsingLicenseID, IssueDate, ExDate, IsActive);
            }
            else return null;
        }

        public static DataTable GetDriverInterLicenses(int DriverID)
        {
            return DVLD_DataLayer.clsInternationalLicense.GetDriverInternationalLicense(DriverID);
        }

        public static int GetDriverActiveInterLicenseID(int DriverID)
        {
            return DVLD_DataLayer.clsInternationalLicense.GetDriverActiveInternationalLicenseID(DriverID);
        }

        bool Add()
        {
            InternationalLicenseID = DVLD_DataLayer.clsInternationalLicense.AddNewInterLicense(GAppID, DriverID, IssuedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);

            return (InternationalLicenseID != -1);
        }

        bool Update()
        {
            return DVLD_DataLayer.clsInternationalLicense.UpdateInterLicense(InternationalLicenseID, GAppID, DriverID, IssuedUsingLocalLicenseID,
                IssueDate, ExpirationDate, IsActive, CreatedByUserID);
        }

        public bool Save()
        {
            base.Mode = (clsGeneralApplications.enModes)this.Mode;
            if (!base.Save()) return false;

            switch (this.Mode)
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
    }
}
