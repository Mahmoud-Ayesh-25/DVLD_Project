using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.TestAppointments.ScheduleTest
{
    public partial class ctrlSheduledTest : UserControl
    {
        frmManageTestAppointments.enTestType _TestType = frmManageTestAppointments.enTestType.Vision;
        public frmManageTestAppointments.enTestType TestType
        {
            get { return _TestType; }
            set 
            {
                _TestType = value;
                lblTitle.Content = $"Take {_TestType.ToString()} Test";
            }
        }

        clsTestAppointments appointment = new clsTestAppointments();
        clsLocalDrivingLicenseApplication app = new clsLocalDrivingLicenseApplication();

        public int TestID { get; set; }

        public bool LoadData(int TestAppointmentID)
        {
            if (TestAppointmentID != -1)
            {
                appointment = clsTestAppointments.Find(TestAppointmentID);
                app = clsLocalDrivingLicenseApplication.FindByLDLAppID(appointment.LocalDrivingLicenseApplicationID);
            }
            else return false;

                lblLDLAppID.Content = $"L.D.L.Applicaiton ID : {app.LDLAppID}";
            lblLicenseClass.Content = $"License Class : {clsLicenseClasses.Find(app.LicenseClassID).ClassName}";
            lblName.Content = $"Name : {app.PersonFullName}";
            lblTrail.Content = $"Trail : {app.TotalTrailsPerTestType((int)_TestType)}";
            lblDate.Content = $"Date : {appointment.Date.ToLongDateString()}";
            lblFees.Content = $"Fees : {appointment.PaidFees}";

            TestID = appointment.TestID;
            if (TestID != -1)
            {
                lblTestID.Content = $"Test ID : {TestID}";
            }
            else
            {
                lblTestID.Content = $"Test ID : Not Taken Yet";
            }

            return true;
        }

        public ctrlSheduledTest()
        {
            InitializeComponent();
        }
    }
}
