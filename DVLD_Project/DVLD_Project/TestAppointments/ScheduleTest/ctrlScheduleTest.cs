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
    public partial class ctrlScheduleTest : UserControl
    {
        frmManageTestAppointments.enTestType _TestType = frmManageTestAppointments.enTestType.Vision;
        public frmManageTestAppointments.enTestType TestType
        {
            get { return _TestType; }
            set 
            {
                _TestType = value;

                lblTitle.Content = "Schedule " + _TestType.ToString() + " Test";
            }
        }

        enum enMode { Add = 1, Update}
        enMode Mode = enMode.Add;

        enum enCreationMode { FirstTime = 1, RetakeTest}
        enCreationMode CreationMode = enCreationMode.FirstTime;

        clsTestAppointments appointment = new clsTestAppointments();
        clsLocalDrivingLicenseApplication app = new clsLocalDrivingLicenseApplication();

        float TotalFees = 0;

        void EnableControls(bool status)
        {
            dtpAppointment.Enabled = status;
            btnSave.Enabled = status;
        }

        public void LoadDefaultData()
        {
            TotalFees = clsTestTypes.Find((int)_TestType).Fees;
            lblFees.Content = $"Fees : {TotalFees}";
            dtpAppointment.Content = DateTime.Now;
        }

        public bool LoadData(int LDLAppID, int TestAppointment = -1)
        {
            LoadDefaultData();

            if (TestAppointment != -1)
            {
                appointment = clsTestAppointments.Find(TestAppointment);
                Mode = enMode.Update;
            }

            app = clsLocalDrivingLicenseApplication.FindByLDLAppID(LDLAppID);

            if (app == null) return false;

            if (app.DoesAttendTestType((int)_TestType)) 
            {
                CreationMode = enCreationMode.RetakeTest;
                lblTitle.Content = $"Retake {_TestType.ToString()} Test";
            }

            HandleConstraints();

            lblLDLAppID.Content = $"L.D.L.Applicaiton ID : {app.LDLAppID}";
            lblLicenseClass.Content = $"License Class : {clsLicenseClasses.Find(app.LicenseClassID).ClassName}";
            lblName.Content = $"Name : {app.PersonFullName}";
            lblTrail.Content = $"Trail : {app.TotalTrailsPerTestType((int)_TestType)}";
            if (Mode == enMode.Update)
                dtpAppointment.Content = appointment.Date;

            float Fees = clsTestTypes.Find((int)_TestType).Fees;
            lblFees.Content = $"Fees : {Fees}";

            if (CreationMode == enCreationMode.RetakeTest)
            {
                float RetakeTestFees = clsApplicationTypes.GetApplicationTypeByID(7).ApplicationTypeFees;
                TotalFees = Fees + RetakeTestFees;

                lblRAppFees.Content = $"R.Applicaiton Fees : {RetakeTestFees}";
                lblTotalFees.Content = $"Total Fees : {TotalFees}";
            }

            return true;
        }

        bool HandlePreviousTestConstraint()
        {
            switch (_TestType)
            {
                case frmManageTestAppointments.enTestType.Vision:
                    {
                        return true;
                    }
                case frmManageTestAppointments.enTestType.Written:
                    {
                        return (app.DoesPassTestType(1));
                    }
                case frmManageTestAppointments.enTestType.Street:
                    {
                        return (app.DoesPassTestType(2));
                    }
                default: return false;

            }
        }

        void HandleConstraints()
        {
            EnableControls(false);
            lblMessage.Visible = true;

            if (appointment.IsLocked)
            {
                lblMessage.Content = $"This person has already taken the test, the appointment is closed.";
                return;
            }

            if (!HandlePreviousTestConstraint())
            {
                lblMessage.Content = $"This person did not pass the previous test.";
                return;
            }

            if (app.DoesPassTestType((int)_TestType))
            {
                lblMessage.Content = $"This person has already passed the {_TestType.ToString().ToLower()} test.";
                return;
            }

            if (Mode == enMode.Add)
            {
                clsTestAppointments testAppointments = clsTestAppointments.GetLastTestAppointment(app.LDLAppID, (int)_TestType);

                if (testAppointments != null)
                {
                    if (!testAppointments.IsLocked)
                    {
                        lblMessage.Content = $"This person already has an active appointment for the {_TestType.ToString().ToLower()} test.";
                        return;
                    }
                }
            }

            lblMessage.Visible = false;
            EnableControls(true);
        }

        bool HandleRetakeTest()
        {
            if (Mode == enMode.Add && CreationMode == enCreationMode.RetakeTest)
            {
                
                clsGeneralApplications Application = new clsGeneralApplications();

                Application.PersonID = app.PersonID;
                Application.Date = DateTime.Now;
                Application.TypeID = (int)clsGeneralApplications.enApplicationTypes.RetakeTest;
                Application.Status = (int)clsGeneralApplications.enApplicationStatuses.Completed;
                Application.LastStatusDate = DateTime.Now;
                Application.PaidFees = clsApplicationTypes.GetApplicationTypeByID((int)clsGeneralApplications.enApplicationTypes.RetakeTest).ApplicationTypeFees;
                Application.CreatedByUserID = clsSettings.CurrentUser.UserID;

                if (!Application.Save())
                {
                    appointment.RetakeTestAppointmentID = -1;
                    MessageBox.Show("Faild to Create application", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                appointment.RetakeTestAppointmentID = Application.GAppID;

            }
            return true;
        }

        bool HandleDateTime()
        {
            return (dtpAppointment.Content >= DateTime.Now.AddDays(-1));
        }

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!HandleDateTime())
            {
                MessageBox.Show("You cannot set a date before today's date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!HandleRetakeTest()) return;

            appointment.LocalDrivingLicenseApplicationID = app.LDLAppID;
            appointment.TestTypeID = (int)_TestType;
            appointment.Date = dtpAppointment.Content;
            appointment.PaidFees = TotalFees;
            if (Mode == enMode.Add)
            {
                appointment.CreatedByUserID = clsSettings.CurrentUser.UserID;
            }

            if (appointment.Save())
            {
                Mode = enMode.Update;

                if (appointment.RetakeTestAppointmentID != -1)
                    lblReTakeTestAppID.Content = $"R.Applicaiotn ID : {appointment.RetakeTestAppointmentID}";

                MessageBox.Show("The appointment has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving the appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
