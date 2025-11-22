using DVLD_BusinessLayer;
using DVLD_Project.MainSettings;
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

namespace DVLD_Project.Applications
{
    public partial class frmUpdateApplicationType : Form
    {
        clsApplicationTypes appType = new clsApplicationTypes();

        void LoadData(int ID)
        {
            appType = clsApplicationTypes.GetApplicationTypeByID(ID);

            if (appType == null ) return;

            lblID.Content = $"Application Type ID : {appType.ApplicationTypeID}";
            tbxTitle.Content = appType.ApplicationTypeTitle;
            tbxFees.Content = appType.ApplicationTypeFees.ToString();
        }

        bool ReadyToSave()
        {
            if (string.IsNullOrEmpty(tbxTitle.Content)) return false;
            if (string.IsNullOrEmpty(tbxFees.Content)) return false;
            return true;
        }

        public frmUpdateApplicationType(int ID)
        {
            InitializeComponent();

            LoadData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to cancel update application type? All the modifications you made will be deleted.";

            if (MessageBox.Show(message, "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ReadyToSave())
            {
                MessageBox.Show("Make sure to fill in all the fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            appType.ApplicationTypeTitle = tbxTitle.Content;
            appType.ApplicationTypeFees = float.Parse(tbxFees.Content);

            if (appType.Save())
            {
                MessageBox.Show("The application type has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the application type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') return;

            if (!clsValidation.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
