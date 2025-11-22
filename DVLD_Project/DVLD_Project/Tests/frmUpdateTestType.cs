using DVLD_BusinessLayer;
using DVLD_Project.MainSettings;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project.Tests
{
    public partial class frmUpdateTestType : Form
    {
        clsTestTypes testType = new clsTestTypes();

        void LoadData(int ID)
        {
            testType = clsTestTypes.Find(ID);

            if (testType == null) return;

            lblID.Content = $"Test Type ID : {testType.ID}";
            tbxTitle.Content = testType.Title;
            tbxDiscription.Content = testType.Description;
            tbxFees.Content = testType.Fees.ToString();
        }

        bool ReadyToSave()
        {
            if (string.IsNullOrEmpty(tbxTitle.Content)) return false;
            if (string.IsNullOrEmpty(tbxDiscription.Content)) return false;
            if (string.IsNullOrEmpty(tbxFees.Content)) return false;
            return true;
        }

        public frmUpdateTestType(int ID)
        {
            InitializeComponent();

            LoadData(ID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = $"Are you sure you want to cancel update test type? All the modifications you made will be deleted.";

            if (MessageBox.Show(message, "Cancel Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbxFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.') return;

            if (!clsValidation.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ReadyToSave())
            {
                MessageBox.Show("Make sure to fill in all the fields.", "Empty fields", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            testType.Title = tbxTitle.Content;
            testType.Description = tbxDiscription.Content;
            testType.Fees = float.Parse(tbxFees.Content);

            if (testType.Save())
            {
                MessageBox.Show("The application type has been successfully saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("An error occurred while saving the application type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
