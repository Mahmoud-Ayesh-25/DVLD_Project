using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccess_Tester
{
    internal class Program
    {
        static void TestGetAll()
        {
            DataTable dt = clsDrivers.GetAllDrivers();

            if (dt.Rows.Count > 0)
            {
                foreach(DataRow row in dt.Rows)
                {
                    Console.WriteLine($"{row[0]} - {row[1]} - {row[2]}");
                }
            }
        }
        static void TestFindPerson()
        {
            clsTests person = clsTests.GetLastTestByPersonIDAndTestTypeIDAndLicenseClassID(1,2,1);

            if (person != null)
            {
                Console.WriteLine($"Saved The ID = {person.TestID}");
            }
        }

        static void TestAddUpdate()
        {
            clsDrivers appType = clsDrivers.FindByPersonID(2036);

            appType.PersonID = 2035;
            appType.CreatedByUser = 25;

            if (appType.Save())
            {
                Console.WriteLine($"Saved ID : {appType.DriverID}");
            }
        }
        static void TestDeletePerson()
        {
            if (clsLocalDrivingLicenseApplication.DeleteLDLApp(44))
            {
                Console.WriteLine("Deleted");
            }
        }
        static void TestIsPersonExist()
        {
            if (clsGeneralApplications.IsApplicationExist(132))
            {
                Console.WriteLine("Exist");
            }
        }

        static void TestGetID()
        {
            int id = clsGeneralApplications.GetActiveApplicationID(1025, clsGeneralApplications.enApplicationTypes.NewLocal);
            Console.WriteLine(id);
        }

        static void TestSetComplete()
        {
            clsGeneralApplications appType = clsGeneralApplications.Find(119);

            if (appType.Cancel())
            {
                Console.WriteLine($"{clsTestAppointments.GetLastTestAppointment(41, 1)}");
            }
        }

        static void TestAdditional()
        {
            Console.WriteLine(clsTests.GetPassedTestCount(36));
        }

        static void Main(string[] args)
        {
            TestAddUpdate();
        }
    }
}
