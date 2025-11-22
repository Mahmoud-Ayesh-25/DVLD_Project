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

namespace DVLD_Project.People
{
    public partial class ctrlFindPerson : UserControl
    {
        clsPerson person = new clsPerson();

        public int PersonID { get { return ctrlPersonCard.PersonID; } }

        public void FindByPersonID(int ID)
        {
            person = clsPerson.Find(ID);

            if (person != null)
                LoadData();
            else
            {
                MessageBox.Show("The person was not found.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                person = new clsPerson();
                ResetDefaultValues();
            }
        }

        void FindByNationalNo(string NationalNo)
        {
            person = clsPerson.Find(NationalNo);

            if (person != null)
                LoadData();
            else
            {
                MessageBox.Show("The person was not found.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                person = new clsPerson();
                ResetDefaultValues();
            }
        }

        void Find()
        {
            if (string.IsNullOrEmpty(tbxFilter.Content)) return;

            if (cbxFilter.SelectedItem == "Person ID")
            {
                FindByPersonID(int.Parse(tbxFilter.Content));
            }
            else
            {
                FindByNationalNo(tbxFilter.Content);
            }
        }

        void LoadData()
        {
            ctrlPersonCard.LoadData(person.PersonID);
        }

        void ResetDefaultValues()
        {
            ctrlPersonCard.LoadDefaultData();
        }

        public ctrlFindPerson()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                Find();
                return;
            }    

            if (cbxFilter.SelectedItem == "Person ID")
            {
                if (!clsValidation.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdate = new frmAddUpdatePerson();
            frmAddUpdate.DataBack += FindByPersonID;
            frmAddUpdate.ShowDialog();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxFilter.Visible = (cbxFilter.SelectedIndex != -1);
        }
    }
}
