using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    public partial class frmAddUpdateLocalDrivingLicenseApplication : Form
    {
        clsLocalDrivingLicenseApplication app = new clsLocalDrivingLicenseApplication();

        enum enMode { Add = 1, Update}
        enMode Mode;

        void SetUpdate()
        {
            lblTitle.Content = "Update Local Driving License Applicaiton";
            ctrlFindPerson.Enabled = false;
            Mode = enMode.Update;
        }

        void LoadLicneseClasses()
        {
            DataTable dtClasses = clsLicenseClasses.GetAllLicenseClasses();

            foreach (DataRow row in dtClasses.Rows)
            {
                cbxLicenseClass.AddItem(row[1].ToString());
            }

            if (cbxLicenseClass.Items.Length > 0)
            {
                cbxLicenseClass.SelectedItem = cbxLicenseClass.Items[2];
            }
        }

        void LoadData(int ID)
        {
            app = clsLocalDrivingLicenseApplication.FindByLDLAppID(ID);

            if (app == null)
            {
                MessageBox.Show("Error while retrieving local driving license application data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ctrlFindPerson.FindByPersonID(app.PersonID);
            lblAppID.Content = $"LDL Application ID : {app.LDLAppID}";
            lblAppDate.Content = $"Application Date : {app.Date}";
            lblAppFees.Content = $"Application Fees : {clsApplicationTypes.GetApplicationTypeByID(app.TypeID).ApplicationTypeFees}";
            lblCreatedBy.Content = $"Created By : {clsUser.FindByID(app.CreatedByUserID).Username}";
        }

        void LoadDefaultData()
        {
            lblAppFees.Content = $"Application Fees : {clsApplicationTypes.GetApplicationTypeByID(1).ApplicationTypeFees}";
            lblCreatedBy.Content = $"Created By : {clsSettings.CurrentUser.Username}";
        }

        void PutDataInApp()
        {
            if (Mode == enMode.Add)
            {
                app.PersonID = ctrlFindPerson.PersonID;
                app.TypeID = 1;
                app.Status = 1;
                app.PaidFees = clsApplicationTypes.GetApplicationTypeByID(1).ApplicationTypeFees;
                app.CreatedByUserID = clsSettings.CurrentUser.UserID;
            }
            app.LicenseClassID = cbxLicenseClass.SelectedIndex + 1;
        }

        public frmAddUpdateLocalDrivingLicenseApplication()
        {
            InitializeComponent();

            pnlFindUser.BringToFront();
            Mode = enMode.Add;
            LoadDefaultData();
        }

        public frmAddUpdateLocalDrivingLicenseApplication(int ID)
        {
            InitializeComponent();

            pnlAppDetails.BringToFront();
            SetUpdate();
            LoadData(ID);
        }

        private void frmAddUpdateLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            LoadLicneseClasses();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to cancel {Mode.ToString()} local driving license application? All the modifications you made will be deleted.";

            if (MessageBox.Show(message, "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlFindPerson.PersonID != -1)
                pnlAppDetails.BringToFront();
            else
            {
                MessageBox.Show("You must choose a person first.", "Not Available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlFindUser.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int id = clsLocalDrivingLicenseApplication.GetActiveApplicationIDForLicenseClass(ctrlFindPerson.PersonID,
                clsGeneralApplications.enApplicationTypes.NewLocal, cbxLicenseClass.SelectedIndex + 1);

            if (id != -1)
            {
                MessageBox.Show("This person already has an active application with the same type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            PutDataInApp();

            if (app.Save())
            {
                if (Mode == enMode.Add)
                {
                    SetUpdate();
                    LoadData(app.LDLAppID);
                }
                MessageBox.Show("The applicaiton has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error while saving the applicaiton.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}