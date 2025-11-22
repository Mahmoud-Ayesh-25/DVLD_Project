using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsGeneralApplications
    {
        enum enModes { AddNew = 1, Update}
        enModes Mode;

        public int LDLAppID {  get; set; }
        public int LicenseClassID { get; set; }
        public string PersonFullName
        {
            get
            {
                return base.PersonInfo.FullName;
            }
        }

        public clsLocalDrivingLicenseApplication()
        {
            this.LDLAppID = -1;
            this.LicenseClassID = -1;

            this.Mode = enModes.AddNew;
        }

        clsLocalDrivingLicenseApplication(int LDLAppID, int LicenseClass, int GAppID, int PersonID, DateTime Date, enApplicationTypes Type,
            enApplicationStatuses Status, DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            this.LDLAppID = LDLAppID;
            this.LicenseClassID = LicenseClass;

            base.GAppID = GAppID;
            base.PersonID = PersonID;
            base.Date = Date;
            base.TypeID = (int)Type;
            base.Status = (int)Status;
            base.LastStatusDate = LastStatusDate;
            base.PaidFees = PaidFees;
            base.CreatedByUserID = CreatedByUserID;

            this.Mode = enModes.Update;
        }

        public static clsLocalDrivingLicenseApplication FindByLDLAppID(int ID)
        {
            int GAppID = -1, LicenseClassID = -1;

            if (DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.GetLDLAppInfoByID(ID, ref GAppID, ref LicenseClassID))
            {
                clsGeneralApplications GApp = clsGeneralApplications.Find(GAppID);

                return new clsLocalDrivingLicenseApplication(ID, LicenseClassID, GAppID, GApp.PersonID, GApp.Date, (enApplicationTypes)GApp.TypeID,
                    (enApplicationStatuses)GApp.Status, GApp.LastStatusDate, GApp.PaidFees, GApp.CreatedByUserID);
            }
            else { return null; }
        }

        public static clsLocalDrivingLicenseApplication FindByGAppID(int ID)
        {
            int LDLAppID = -1, LicenseClassID = -1;

            if (DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.GetLDLAppInfoByGeneralAppID(ID, ref LDLAppID, ref LicenseClassID))
            {
                clsGeneralApplications GApp = clsGeneralApplications.Find(ID);

                return new clsLocalDrivingLicenseApplication(LDLAppID, LicenseClassID, ID, GApp.PersonID, GApp.Date, (enApplicationTypes)GApp.TypeID,
                    (enApplicationStatuses)GApp.Status, GApp.LastStatusDate, GApp.PaidFees, GApp.CreatedByUserID);
            }
            else { return null; }
        }

        bool AddNew()
        {
            int ID = DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.AddNewLDLApp(GAppID, LicenseClassID);

            if (ID != -1)
            { LDLAppID = ID; return true; }
            else { return false; }
        }

        bool Update()
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.UpdateLDLApp(LDLAppID, GAppID, LicenseClassID);
        }

        public bool Save()
        {
            base.Mode = (clsGeneralApplications.enModes)this.Mode;

            if (!base.Save()) return false;

            switch (this.Mode)
            {
                case enModes.AddNew:
                    {
                        if (AddNew())
                        {
                            this.Mode = enModes.Update;
                            return true;
                        }
                        else return false;
                    }
                case enModes.Update:
                    {
                        return Update();
                    }
                default: return false;
            }
        }

        public static bool DeleteLDLApp(int ID)
        {
            int GID = clsLocalDrivingLicenseApplication.FindByLDLAppID(ID).GAppID;

            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.DeleteLDLApp(ID) && DVLD_DataLayer.clsGeneralApplications.DeleteApplication(GID);
        }

        public static DataTable GetAllLDLApps()
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.GetAllLDLApps();
        }

        public static bool DoesPassTestType(int LDLAppID, int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.DoesPassTestType(LDLAppID, TestTypeID);
        }

        public bool DoesPassTestType(int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.DoesPassTestType(LDLAppID, TestTypeID);
        }

        public static bool DoesAttendTestType(int LDLAppID, int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.DoesAttendTestType(LDLAppID, TestTypeID);
        }

        public bool DoesAttendTestType(int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.DoesAttendTestType(LDLAppID, TestTypeID);
        }

        public static bool IsThereAnActiveScheduleTest(int LDLAppID, int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.IsThereAnActiveScheduleTest(LDLAppID, TestTypeID);
        }

        public bool IsThereAnActiveScheduleTest(int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.IsThereAnActiveScheduleTest(LDLAppID, TestTypeID);
        }

        public static int TotalTrailsPerTestType(int LDLAppID, int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.TotalTrailsPerTestType(LDLAppID, TestTypeID);
        }

        public int TotalTrailsPerTestType(int TestTypeID)
        {
            return DVLD_DataLayer.clsLocalDrivingLicenseApplicaiton.TotalTrailsPerTestType(LDLAppID, TestTypeID);
        }

        public int IssueDrivingLicenseForFirstTime(string Notes, int CreatedByUserID)
        {
            int DriverID = -1;
            clsDrivers driver = clsDrivers.FindByPersonID(this.PersonID);

            if (driver == null)
            {
                clsDrivers newDriver = new clsDrivers();

                newDriver.CreatedByUser = CreatedByUserID;
                newDriver.Date = DateTime.Now;
                newDriver.PersonID = this.PersonID;
                
                if (newDriver.Save())
                {
                    DriverID = newDriver.DriverID;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                DriverID = driver.DriverID;
            }


            clsLicenses license = new clsLicenses();

            license.DriverID = DriverID;
            license.ApplicaitonID = GAppID;
            license.CreatedByUserID = CreatedByUserID;
            license.IssueDate = DateTime.Now;
            license.ExpDate = DateTime.Now.AddYears(clsLicenseClasses.Find(this.LicenseClassID).DefaultValidityLength);
            license.IsActive = true;
            license.PaidFees = clsLicenseClasses.Find(this.LicenseClassID).ClassFees;
            license._IssueReason = clsLicenses.enIssueReason.FirstTime;
            license.LicenseClassID = this.LicenseClassID;
            license.Notes = Notes;
            
            if (license.Save())
            {
                this.SetComplete();
                return license.LicenseID;
            }
            else
            {
                return -1;
            }
        }

        public bool DoesPassAllTests()
        {
            return (DVLD_DataLayer.clsTests.GetPassedTestCount(LDLAppID) == 3);
        }

        public int GetActiveLicenseID()
        {
            return DVLD_DataLayer.clsLicenses.GetActiveLicenseIDByPersonID(PersonID, LicenseClassID);
        }
    }
}
