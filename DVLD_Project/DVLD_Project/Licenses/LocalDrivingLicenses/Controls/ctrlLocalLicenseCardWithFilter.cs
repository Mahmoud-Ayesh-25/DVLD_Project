using DVLD_BusinessLayer;
using DVLD_Project.MainSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Licenses.LocalDrivingLicenses.Controls
{
    public partial class ctrlLocalLicenseCardWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;

        protected virtual void LicenseSelected(int licenseId)
        {
            Action<int> handler = OnLicenseSelected;
            if (handler != null)
            {
                handler(licenseId);
            }
        }

        int LicenseID = -1;
        clsLicenses license = new clsLicenses();

        public clsLicenses LicenseInfo { get { return license; } }

        public void EnableFilter(bool status)
        {
            tbxFilter.Enabled = status;
            btnFind.Enabled = status;
        }

        public bool LoadData(int LicenseID)
        {
            tbxFilter.Content = LicenseID.ToString();
            
            if (ctrlLocalLicenseCard1.LoadData(LicenseID))
            {
                EnableFilter(false);
                if (OnLicenseSelected != null)
                    OnLicenseSelected?.Invoke(LicenseID);

                this.LicenseID = LicenseID;
                license = clsLicenses.Find(LicenseID);

                return true;
            }
            else
            {
                ctrlLocalLicenseCard1.LoadDefaultData();
                return false;
            }
        }

        void Find()
        {
            int LicenseID = int.Parse(tbxFilter.Content);

            license = clsLicenses.Find(LicenseID);

            if (license == null)
            {
                MessageBox.Show("Error while fetching license data", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }

            if (ctrlLocalLicenseCard1.LoadData(LicenseID))
            {
                if (OnLicenseSelected != null)
                    OnLicenseSelected?.Invoke(LicenseID);

                this.LicenseID = LicenseID;
                license = clsLicenses.Find(LicenseID);
            }
        }

        public ctrlLocalLicenseCardWithFilter()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!clsValidation.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == (char)13)
                {
                    Find();
                }
                e.Handled = true;
            }
        }
    }
}
