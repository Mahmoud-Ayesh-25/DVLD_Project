using DVLD_BusinessLayer;
using DVLD_Project.People;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls
{
    public partial class ctrlBaseApplicationInfo : UserControl
    {
        clsGeneralApplications app = new clsGeneralApplications();

        public bool LoadData(int ID)
        {
            app = clsGeneralApplications.Find(ID);

            if (app == null) return false;

            lblID.Content += ID;
            lblName.Content += app.PersonInfo.FullName;
            lblType.Content += app.Type.ApplicationTypeTitle;
            lblFees.Content += app.PaidFees;
            lblStatus.Content += app.StatusText;
            lblDate.Content += app.Date.ToLongDateString();
            lblStatusDate.Content += app.LastStatusDate.ToLongDateString();
            lblCreatedBy.Content += app.User.Username;

            return true;
        }

        public void LoadDefaultData()
        {
            lblID.Content = "ID : ";
            lblName.Content = "Name : ";
            lblType.Content = "Type : ";
            lblFees.Content = "Fees : ";
            lblStatus.Content = "Status : ";
            lblDate.Content = "Date : ";
            lblStatusDate.Content = "Status Date : ";
            lblCreatedBy.Content = "Created By : ";
        }

        public ctrlBaseApplicationInfo()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (app.GAppID == -1) { LoadDefaultData(); return; }

            frmPersonInformation personInfo = new frmPersonInformation(app.PersonID);
            personInfo.ShowDialog();
            LoadDefaultData();
            LoadData(app.GAppID);
        }
    }
}
