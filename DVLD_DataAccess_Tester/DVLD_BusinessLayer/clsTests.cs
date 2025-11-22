using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTests
    {
        enum enMode { Add = 1, Update}
        enMode Mode;

        public int TestID {  get; set; }
        public int TestAppointmentID { get; set; }
        public clsTestAppointments TestAppointment { get; set; }
        public bool TestResult { get; set; }
        public string TestNotes { get; set; }
        public int CreatedByUserID { get; set; }

        public clsTests()
        {
            Mode = enMode.Add;
            TestID = -1;
            TestAppointmentID = -1;
            TestAppointment = new clsTestAppointments();
            TestResult = false;
            TestNotes = string.Empty;
            CreatedByUserID = -1;
        }

        clsTests(int testID, int testAppointmentID, bool testResult, string testNotes, int createdByUserID)
        {
            Mode = enMode.Update;
            TestID = testID;
            TestAppointmentID = testAppointmentID;
            TestAppointment = clsTestAppointments.Find(TestAppointmentID);
            TestResult = testResult;
            TestNotes = testNotes;
            CreatedByUserID = createdByUserID;
        }

        bool _Add()
        {
            TestID = DVLD_DataLayer.clsTests.AddTest(TestAppointmentID, TestResult, TestNotes, CreatedByUserID);

            return (TestID != -1);
        }

        bool _Update()
        {
            return DVLD_DataLayer.clsTests.UpdateTest(TestID, TestAppointmentID, TestResult, TestNotes, CreatedByUserID);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.Add:
                    {
                        if (_Add())
                        {
                            Mode = enMode.Update;
                            return true;
                        }
                        else return false;
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
                default: return false;
            }
        }

        public static DataTable GetAllTests()
        {
            return DVLD_DataLayer.clsTests.GetAllTests();
        }

        public static clsTests Find(int ID)
        {
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;

            if (DVLD_DataLayer.clsTests.GetTestInfoByID(ID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTests(ID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static clsTests GetLastTestByPersonIDAndTestTypeIDAndLicenseClassID(int PersonID, int TestTypeID, int LicenseClassID)
        {
            int TestID = -1;
            int TestAppointmentID = -1;
            bool TestResult = false;
            string Notes = string.Empty;
            int CreatedByUserID = -1;

            if (DVLD_DataLayer.clsTests.GetLastTestByPersonIDAndTestTypeIDAndLicenseClassID(PersonID, TestTypeID, LicenseClassID,
                ref TestID, ref TestAppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
            {
                return new clsTests(TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID);
            }
            else
            {
                return null;
            }
        }

        public static int GetPassedTestCount(int LDLAppID)
        {
            return DVLD_DataLayer.clsTests.GetPassedTestCount(LDLAppID);
        }
    }
}
