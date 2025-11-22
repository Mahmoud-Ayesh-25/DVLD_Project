using System;
using System.Data;

namespace DVLD_BusinessLayer
{
    public class clsLicenses
    {
        enum enMode { Add = 1, Update}
        enMode Mode;

        public enum enIssueReason {FirstTime = 1, Renew, ReplacementForLost,  ReplacementForDamage }
        public enIssueReason _IssueReason;

        public int LicenseID { get; set; }
        public int ApplicaitonID { get; set; }
        public clsGeneralApplications Application { get; set; }
        public int DriverID { get; set; }
        public clsDrivers Driver { get; set; }
        public int LicenseClassID { get; set; }
        public clsLicenseClasses LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpDate { get; set; }
        public string Notes { get; set; }
        public float PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get { return ((int) _IssueReason); } }
        public string IssueReasonText { get { return (_IssueReason.ToString()); } }
        public int CreatedByUserID { get; set; }
        public clsDetainedLicenses DetainedLicenseInfo
        {
            get
            {
                return ((LicenseID != -1 && LicenseID != null) ? clsDetainedLicenses.FindByLicenseID(LicenseID) : null);
            }
        }


        public clsLicenses()
        {
            _IssueReason = enIssueReason.Renew;
            LicenseID = -1;
            ApplicaitonID = -1;
            Application = new clsGeneralApplications();
            DriverID = -1;
            Driver = new clsDrivers();
            LicenseClassID = -1;
            LicenseClass = new clsLicenseClasses();
            IssueDate = new DateTime();
            ExpDate = new DateTime();
            Notes = string.Empty;
            PaidFees = 0;
            IsActive = false;
            CreatedByUserID = -1;

            Mode = enMode.Add;
        }

        clsLicenses(enIssueReason issueReason, int licenseID, int applicaitonID, int driverID, int licenseClassID, DateTime issueDate,
            DateTime expDate, string notes, float paidFees, bool isActive, int createdByUserID)
        {
            _IssueReason = issueReason;
            LicenseID = licenseID;
            ApplicaitonID = applicaitonID;
            Application = clsGeneralApplications.Find(ApplicaitonID);
            DriverID = driverID;
            Driver = clsDrivers.FindByDriverID(DriverID);
            LicenseClassID = licenseClassID;
            LicenseClass = clsLicenseClasses.Find(LicenseClassID);
            IssueDate = issueDate;
            ExpDate = expDate;
            Notes = notes;
            PaidFees = paidFees;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;

            Mode = enMode.Update;
        }

        bool Add()
        {
            LicenseID = DVLD_DataLayer.clsLicenses.AddLicense(ApplicaitonID, DriverID, LicenseClassID, IssueDate, ExpDate, Notes,
                PaidFees, IsActive, IssueReason, CreatedByUserID);

            return (LicenseID != -1);
        }

        bool Update()
        {
            return DVLD_DataLayer.clsLicenses.UpdateLicense(LicenseID, ApplicaitonID, DriverID, LicenseClassID, IssueDate, ExpDate, Notes,
                PaidFees, IsActive, IssueReason, CreatedByUserID);
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
                        return false;
                    }
                    case enMode.Update: return (Update());
                    default : return false;
            }
        }

        public static DataTable GetAllLicenses()
        {
            return DVLD_DataLayer.clsLicenses.GetAllLicenses();
        }
        public static DataTable GetDriverLicenses(int DriverID)
        {
            return DVLD_DataLayer.clsLicenses.GetDriverLicenses(DriverID);
        }

        public static clsLicenses Find(int ID)
        {
            int issueReason = 1;
            int applicaitonID = -1;
            int driverID = -1;
            int licenseClassID = -1;
            DateTime issueDate = new DateTime();
            DateTime expDate = new DateTime();
            string notes = string.Empty;
            float paidFees = 0;
            bool isActive = false;
            int createdByUserID = -1;

            if (DVLD_DataLayer.clsLicenses.GetLicenseByID(ID, ref applicaitonID, ref driverID, ref licenseClassID, ref issueDate, ref expDate,
                ref notes, ref paidFees, ref isActive, ref issueReason, ref createdByUserID))
            {
                return new clsLicenses((enIssueReason)issueReason, ID, applicaitonID, driverID, licenseClassID
                    , issueDate, expDate, notes, paidFees, isActive, createdByUserID);
            } else return null;
        }

        public static bool DeactivateLicense(int LicenseID)
        {
            return DVLD_DataLayer.clsLicenses.DeactivateLicense(LicenseID);
        }

        public bool DeactivateCurrentLicense()
        {
            return DVLD_DataLayer.clsLicenses.DeactivateLicense(LicenseID);
        }

        public static int GetActivateLicensesForPersonID(int PersonID, int LicenseClass)
        {
            return DVLD_DataLayer.clsLicenses.GetActiveLicenseIDByPersonID(PersonID, LicenseClass);
        }

        public static bool DoesThisPersonHaveActivateLicense(int LicenseID, int LicenseClass)
        {
            return GetActivateLicensesForPersonID(LicenseID, LicenseClass) != -1;
        }

        public bool IsLicenseExpired()
        {
            return (this.ExpDate < DateTime.Now);
        }

        public clsLicenses RenewLicense(string Notes, int CreatedByUserID)
        {
            clsGeneralApplications application = new clsGeneralApplications();

            application.PersonID = Driver.PersonID;
            application.Date = DateTime.Now;
            application.TypeID = 2;
            application.Status = 3;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = clsApplicationTypes.GetApplicationTypeByID(2).ApplicationTypeFees;
            application.CreatedByUserID = CreatedByUserID;

            if (!application.Save()) return null;

            clsLicenses license = new clsLicenses();

            license.ApplicaitonID = application.GAppID;
            license.DriverID = this.DriverID;
            license.LicenseClassID = this.LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpDate = DateTime.Now.AddYears(this.LicenseClass.DefaultValidityLength);
            license.Notes = Notes;
            license.PaidFees = this.LicenseClass.ClassFees;
            license.IsActive = true;
            license._IssueReason = enIssueReason.Renew;
            license.CreatedByUserID = CreatedByUserID;

            if (!license.Save()) return null;

            DeactivateCurrentLicense();

            return license;
        }

        public clsLicenses ReplaceLicense(enIssueReason IssueReason, int CreatedByUserID)
        {
            clsGeneralApplications application = new clsGeneralApplications();

            application.PersonID = Driver.PersonID;
            application.Date = DateTime.Now;
            if (IssueReason == enIssueReason.ReplacementForDamage)
                application.TypeID = 4;
            else if (IssueReason == enIssueReason.ReplacementForLost)
                application.TypeID = 3;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)IssueReason).ApplicationTypeFees;
            application.CreatedByUserID = CreatedByUserID;
            application.Status = 3;

            if (!application.Save()) return null;

            clsLicenses license = new clsLicenses();

            license.ApplicaitonID = application.GAppID;
            license.DriverID = this.DriverID;
            license.LicenseClassID = this.LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpDate = DateTime.Now.AddYears(this.LicenseClass.DefaultValidityLength);
            license.Notes = Notes;
            license.PaidFees = this.LicenseClass.ClassFees;
            license.IsActive = true;
            if (IssueReason == enIssueReason.ReplacementForDamage)
                license._IssueReason = enIssueReason.ReplacementForDamage;
            else if (IssueReason == enIssueReason.ReplacementForLost)
                license._IssueReason = enIssueReason.ReplacementForLost;
            license.CreatedByUserID = CreatedByUserID;

            if (!license.Save()) return null;

            DeactivateCurrentLicense();

            return license;
        }

        public int DetainLicense(int CreatedByUserID, float Fees)
        {
            if (clsDetainedLicenses.IsLicenseDetained(LicenseID)) return -1;

            clsDetainedLicenses detain = new clsDetainedLicenses();

            detain.LicenseID = LicenseID;
            detain.CreatedByUserID = CreatedByUserID;
            detain.DetainDate = DateTime.Now;
            detain.FineFees = Fees;

            if (!detain.Save())
            {
                return -1;
            }

            return detain.DetainID;
        }

        public bool IsLicenseDetained()
        {
            return DVLD_DataLayer.clsDetainedLicenses.IsLicenseDetained(LicenseID);
        }
    }
}
