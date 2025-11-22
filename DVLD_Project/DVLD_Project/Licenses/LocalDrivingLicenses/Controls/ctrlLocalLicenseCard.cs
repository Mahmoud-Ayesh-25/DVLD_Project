using DVLD_BusinessLayer;
using DVLD_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.LocalDrivingLicenses
{
    public partial class ctrlLocalLicenseCard : UserControl
    {
        int _LicenseID = -1;
        clsLicenses _License = new clsLicenses();

        public int LicenseID { get { return _LicenseID; } }
        public clsLicenses License { get { return _License; } }


        void LoadImage()
        {
            if (_License.Driver.Person.Gendor == 0)
                pbxPersonImage.BackgroundImage = Resources.man;
            else
                pbxPersonImage.BackgroundImage = Resources.woman;

            string imagePath = _License.Driver.Person.ImagePath;

            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath))
                {
                    pbxPersonImage.BackgroundImage = null;
                    pbxPersonImage.ImageLocation = imagePath;
                }
            }
        }

        public void LoadDefaultData()
        {
            _LicenseID = -1;
            _License = new clsLicenses();

            lblLicenseClass.Content = "License Class : ";
            lblName.Content = "Name : ";
            lblLicenseID.Content = "License ID : ";
            lblNationalNo.Content = "National No : ";
            lblGendor.Content = "Gendor : ";
            lblIssueDate.Content = "Issue Date : ";
            lblIssueReason.Content = "Issue Reason : ";
            lblNotes.Content = "Notes : ";
            lblIsAvtive.Content = "Is Active : ";
            lblDateOfBirth.Content = "Date Of Birth : ";
            lblDriverID.Content = "Driver ID : ";
            lblExpDate.Content = "Exp Date : ";
            lblIsDetained.Content = "Is Detained : ";

            LoadImage();
        }

        public bool LoadData(int LicenseID)
        {
            LoadDefaultData();

            _LicenseID = LicenseID;

            _License = clsLicenses.Find(LicenseID);

            if (_License == null) { MessageBox.Show("Error while fetching license data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); return false; }

            lblLicenseClass.Content += _License.LicenseClass.ClassName;
            lblName.Content += _License.Driver.Person.FullName;
            lblLicenseID.Content += LicenseID.ToString();
            lblNationalNo.Content += _License.Driver.Person.NationalNo;
            lblGendor.Content += (_License.Driver.Person.Gendor == 0) ? "Male" : "Female";
            lblIssueDate.Content += _License.IssueDate.ToShortDateString();
            lblIssueReason.Content += _License.IssueReasonText;
            lblNotes.Content += _License.Notes;
            lblIsAvtive.Content += (_License.IsActive == true)? "Yes" : "No";
            lblDateOfBirth.Content += License.Driver.Person.DateOfBirth.ToShortDateString();
            lblDriverID.Content += _License.DriverID.ToString();
            lblExpDate.Content += _License.ExpDate.ToShortDateString();
            lblIsDetained.Content += (_License.IsLicenseDetained())? "Yes" : "No";

            LoadImage();

            return true;
        }

        public ctrlLocalLicenseCard()
        {
            InitializeComponent();
        }
    }
}
