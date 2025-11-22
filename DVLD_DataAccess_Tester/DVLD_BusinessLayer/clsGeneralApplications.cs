using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsGeneralApplications
    {
        public enum enModes { AddNew = 1, Update}
        public enModes Mode { get; set; }

        public enum enApplicationTypes { NewLocal = 1, Renew, ReplaceForLost, ReplaceForDamage, Release, NewInternational, RetakeTest}
        enApplicationTypes AppType;

        public enum enApplicationStatuses { New = 1, Cancelled, Completed}
        enApplicationStatuses AppStatus;

        public int GAppID {  get; set; }
        public int PersonID { get; set; }
        public clsPerson PersonInfo { get { return (PersonID == -1) ? new clsPerson() : clsPerson.Find(PersonID); } }
        public DateTime Date { get; set; }
        public int TypeID { get; set; }
        public clsApplicationTypes Type { get; set; }
        public int Status {  get; set; }
        public string StatusText { get; set; }
        public DateTime LastStatusDate { get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser User { get; set; }

        public clsGeneralApplications()
        {
            Mode = enModes.AddNew;
            AppType = enApplicationTypes.NewLocal;
            AppStatus = enApplicationStatuses.New;

            GAppID = -1;
            PersonID = -1;
            Date = new DateTime();
            TypeID = -1;
            Type = new clsApplicationTypes();
            Status = -1;
            StatusText = string.Empty;
            LastStatusDate = new DateTime();
            PaidFees = 0;
            CreatedByUserID = -1;
            User = new clsUser();
        }

        clsGeneralApplications(int ID, int PersonID, DateTime Date, enApplicationTypes Type, enApplicationStatuses Status, DateTime LastStatusDate,
            float PaidFees, int CreatedByUserID)
        {
            Mode = enModes.Update;
            AppType = Type;
            AppStatus = Status;

            this.GAppID = ID;
            this.PersonID = PersonID;
            this.Date = Date;
            this.TypeID = (int)Type;
            this.Type = clsApplicationTypes.GetApplicationTypeByID((int)Type);
            this.Status = (int)Status;
            this.StatusText = SetStatusText();
            this.LastStatusDate = LastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.User = clsUser.FindByID(CreatedByUserID);
        }

        string SetStatusText()
        {
            switch (AppStatus)
            {
                case enApplicationStatuses.New:
                    return "New";
                case enApplicationStatuses.Cancelled:
                    return "Cancelled";
                case enApplicationStatuses.Completed:
                    return "Completed";
                default: return string.Empty;
            }
        }

        public static DataTable GetAllApplications()
        {
            return DVLD_DataLayer.clsGeneralApplications.GetAllApplications();
        }

        public static clsGeneralApplications Find(int ID)
        {
            int PersonID = -1;
            DateTime Date = new DateTime();
            int TypeID = -1;
            int Status = -1;
            DateTime LastStatusDate = new DateTime();
            float PaidFees = 0;
            int CreatedByUserID = -1;

            if (DVLD_DataLayer.clsGeneralApplications.GetApplicationByID(ID, ref PersonID, ref Date, ref TypeID, ref Status, ref LastStatusDate,
                ref PaidFees, ref CreatedByUserID))
            {
                return new clsGeneralApplications(ID, PersonID, Date, (enApplicationTypes)TypeID, (enApplicationStatuses)Status, 
                    LastStatusDate, PaidFees, CreatedByUserID);
            }
            else return null;
        }

        bool AddNew()
        {
            int id = DVLD_DataLayer.clsGeneralApplications.AddNewApplication(PersonID, TypeID, Status, PaidFees, CreatedByUserID);

            if (id != -1)
            {
                this.GAppID = id;
                return true;
            }
            else return false;
        }

        bool Update()
        {
            return DVLD_DataLayer.clsGeneralApplications.UpdateApplication(GAppID, PersonID, TypeID, Status, PaidFees, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enModes.AddNew:
                    {
                        if (AddNew())
                        {
                            Mode = enModes.Update;
                            return true;
                        }
                        else { return false; }
                    }
                case enModes.Update:
                    return Update();
                default: return false;
            }
        }

        public bool Cancel()
        {
            return DVLD_DataLayer.clsGeneralApplications.UpdateStatus(GAppID, (int)enApplicationStatuses.Cancelled);
        }

        public bool SetComplete()
        {
            return DVLD_DataLayer.clsGeneralApplications.UpdateStatus(GAppID, (int)enApplicationStatuses.Completed);
        }

        public bool DoesPersonHaveActiveApplicationForLicenseClass(int LicenseClassID)
        {
            int ID = DVLD_DataLayer.clsGeneralApplications.GetActiveApplicationIDForLicenseClass(PersonID, TypeID, LicenseClassID);
            return ID != -1;
        }

        public static int GetActiveApplicationIDForLicenseClass(int PersonID,  enApplicationTypes Type, int LicenseClassID)
        {
            return DVLD_DataLayer.clsGeneralApplications.GetActiveApplicationIDForLicenseClass(PersonID, (int)Type, LicenseClassID);
        }

        public static bool IsApplicationExist(int ID)
        {
            return DVLD_DataLayer.clsGeneralApplications.IsApplicationExist(ID);
        }

        public static int GetActiveApplicationID(int PersonID, enApplicationTypes Type)
        {
            return DVLD_DataLayer.clsGeneralApplications.GetActiveApplicationID(PersonID, (int)Type);
        }

        public int GetActiveApplicationID(enApplicationTypes Type)
        {
            return DVLD_DataLayer.clsGeneralApplications.GetActiveApplicationID(PersonID, (int)Type);
        }

        public static bool DeleteApplicaiton(int ID)
        {
            return DVLD_DataLayer.clsGeneralApplications.DeleteApplication(ID);
        }
    }
}
