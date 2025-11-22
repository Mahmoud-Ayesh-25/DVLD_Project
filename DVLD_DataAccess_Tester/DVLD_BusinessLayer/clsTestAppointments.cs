using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestAppointments
    {
        enum enMode { Add = 1, Update}
        enMode Mode;

        public int TestAppointmentID {  get; set; }
        public int TestTypeID { get; set; }
        public clsTestTypes TestType { get { return (TestTypeID == -1) ? null : clsTestTypes.Find(TestTypeID); } }
        public int TestID { get { return GetTestID(); } }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime Date {  get; set; }
        public float PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestAppointmentID { get; set; }

        public clsTestAppointments()
        {
            TestAppointmentID = -1;
            TestTypeID = -1;
            LocalDrivingLicenseApplicationID = -1;
            Date = new DateTime();
            PaidFees = 0;
            CreatedByUserID = -1;
            IsLocked = false;
            RetakeTestAppointmentID = -1;

            Mode = enMode.Add;
        }

        clsTestAppointments(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime date,
            float paidFees, int createdByUserID, bool isLocked, int retakeTestAppointmentID)
        {
            TestAppointmentID = testAppointmentID;
            TestTypeID = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            Date = date;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestAppointmentID = retakeTestAppointmentID;

            Mode = enMode.Update;
        }

        public static DataTable GetAllTestAppointments()
        {
            return DVLD_DataLayer.clsTestAppointments.GetAllTestAppointments();
        }

        public static clsTestAppointments Find(int ID)
        {
            int TestTypeID = -1;
            int LDLAppID = -1;
            DateTime Date = new DateTime();
            float PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestAppointmentID = -1;

            if (DVLD_DataLayer.clsTestAppointments.GetTestAppointmentByID(ID, ref TestTypeID, ref LDLAppID, ref Date, ref PaidFees, ref CreatedByUserID,
                ref IsLocked, ref RetakeTestAppointmentID))
            {
                return new clsTestAppointments(ID, TestTypeID, LDLAppID, Date, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            }
            else { return null; }
        }

        public static clsTestAppointments GetLastTestAppointment(int LDLAppID, int TestTypeID)
        {
            int ID = -1;
            DateTime Date = new DateTime();
            float PaidFees = 0;
            int CreatedByUserID = -1;
            bool IsLocked = false;
            int RetakeTestAppointmentID = -1;

            if (DVLD_DataLayer.clsTestAppointments.GetLastTestAppointment(LDLAppID, TestTypeID, ref ID, ref Date, ref PaidFees, ref CreatedByUserID,
                ref IsLocked, ref RetakeTestAppointmentID))
            {
                return new clsTestAppointments(ID, TestTypeID, LDLAppID, Date, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
            }
            else { return null; }
        }

        bool Add()
        {
            int id = DVLD_DataLayer.clsTestAppointments.AddTestAppointment(TestTypeID, LocalDrivingLicenseApplicationID, Date, PaidFees,
                CreatedByUserID, IsLocked, RetakeTestAppointmentID);

            if (id != -1)
            {
                TestAppointmentID = id;
                return true;
            }
            else return false;
        }

        bool Update()
        {
            return DVLD_DataLayer.clsTestAppointments.UpdateTestAppointment(TestAppointmentID, TestTypeID, LocalDrivingLicenseApplicationID,
                Date, PaidFees, CreatedByUserID, IsLocked, RetakeTestAppointmentID);
        }

        public bool Save()
        {
            switch (Mode)
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
                        return Update();
                    }
                default: return false;
            }
        }

        public static DataTable GetApplicaitonTestAppointmentByTestType(int LDLAppID, int TestTypeID)
        {
            return DVLD_DataLayer.clsTestAppointments.GetApplicaitonTestAppointmentByTestType(LDLAppID, TestTypeID);
        }

        public DataTable GetApplicaitonTestAppointmentByTestType(int TestTypeID)
        {
            return DVLD_DataLayer.clsTestAppointments.GetApplicaitonTestAppointmentByTestType(LocalDrivingLicenseApplicationID, TestTypeID);
        }

        int GetTestID()
        {
            return DVLD_DataLayer.clsTestAppointments.GetTestID(TestAppointmentID);
        }
    }
}
