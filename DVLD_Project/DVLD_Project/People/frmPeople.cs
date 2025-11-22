using CuoreUI.Controls;
using DVLD_BusinessLayer;
using DVLD_Project.MainSettings;
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

namespace DVLD_Project
{
    public partial class frmPeople : Form
    {
        DataTable dtPeople = clsPerson.GetAllPeople();

        void dgvPeople_Refresh()
        {
            dtPeople = clsPerson.GetAllPeople();
            dgvPeople.DataSource = dtPeople;
        }

        void SetMaximized()
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = MaximizedImgBox.Images[0];
                cuiResizeGrip.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = MaximizedImgBox.Images[1];
                cuiResizeGrip.Visible = false;
            }
        }

        void Organize_SizeChanged()
        {
            dgvPeople.Width = this.Width - 24;
            dgvPeople.Height = this.Height - 141;
        }

        void Organize_dgvPeopleColumnsWidth()
        {
            dgvPeople.Columns["PersonID"].Width = (dgvPeople.Width * 5) / 100;
            dgvPeople.Columns["NationalNo"].Width = (dgvPeople.Width * 5) / 100;
            dgvPeople.Columns["FirstName"].Width = ((dgvPeople.Width * 8) / 100) - 2;
            dgvPeople.Columns["SecondName"].Width = ((dgvPeople.Width * 8) / 100) - 2;
            dgvPeople.Columns["ThirdName"].Width = ((dgvPeople.Width * 8) / 100) - 2;
            dgvPeople.Columns["LastName"].Width = ((dgvPeople.Width * 8) / 100) - 2;
            dgvPeople.Columns["DateOfBirth"].Width = ((dgvPeople.Width * 9) / 100) - 2;
            dgvPeople.Columns["GendorName"].Width = ((dgvPeople.Width * 4) / 100) - 2;
            dgvPeople.Columns["CountryName"].Width = ((dgvPeople.Width * 7) / 100) - 2;
            dgvPeople.Columns["Address"].Width = ((dgvPeople.Width * 19) / 100) - 2;
            dgvPeople.Columns["Phone"].Width = ((dgvPeople.Width * 8) / 100) - 2;
            dgvPeople.Columns["Email"].Width = ((dgvPeople.Width * 11) / 100) - 2;
        }

        void Organize_dgvPeople()
        {
            dgvPeople.DataSource = dtPeople;

            if (!(dgvPeople.Columns.Count > 0)) return;

            dgvPeople.Columns["Gendor"].Visible = false;
            dgvPeople.Columns["NationalityCountryID"].Visible = false;
            dgvPeople.Columns["ImagePath"].Visible = false;

            dgvPeople.Columns["PersonID"].HeaderText = "ID";
            dgvPeople.Columns["NationalNo"].HeaderText = "No.";
            dgvPeople.Columns["FirstName"].HeaderText = "First Name";
            dgvPeople.Columns["SecondName"].HeaderText = "Second Name";
            dgvPeople.Columns["ThirdName"].HeaderText = "Third Name";
            dgvPeople.Columns["LastName"].HeaderText = "Last Name";
            dgvPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
            dgvPeople.Columns["GendorName"].HeaderText = "Gendor";
            dgvPeople.Columns["CountryName"].HeaderText = "Nationality";

            Organize_dgvPeopleColumnsWidth();
        }

        string GetMainColumnName(int index)
        {
            string columnName = "";

            switch (index)
            {
                case 1:
                    columnName = "PersonID"; break;
                case 2:
                    columnName = "NationalNo"; break;
                case 3:
                    columnName = "FirstName"; break;
                case 4:
                    columnName = "SecondName"; break;
                case 5:
                    columnName = "ThirdName"; break;
                case 6:
                    columnName = "LastName"; break;
                case 8:
                    columnName = "Address"; break;
                case 9:
                    columnName = "Phone"; break;
                case 10:
                    columnName = "Email"; break;
                case 11:
                    columnName = "CountryName"; break;
            }

            return columnName;
        }

        void Organize_Filter()
        {
            if (tbxFilter.Content.Length > 0)
            {
                DataView view = dtPeople.DefaultView;

                if (cbxFilter.SelectedIndex == 1)
                {
                    view.RowFilter = $"{GetMainColumnName(cbxFilter.SelectedIndex)} = {tbxFilter.Content}";
                    dgvPeople.DataSource = view;
                }
                else
                {
                    if (cbxFilter.SelectedIndex != 7)
                    {
                        view.RowFilter = $"{GetMainColumnName(cbxFilter.SelectedIndex)} Like '{tbxFilter.Content}%'";
                        dgvPeople.DataSource = view;
                    }
                }
            }
            else
            {
                dgvPeople_Refresh();
            }
        }

        void Organize_GendorFilter()
        {
            DataView view = dtPeople.DefaultView;
            view.RowFilter = $"Gendor = {cbxGendor.SelectedIndex - 1}";
        }

        public frmPeople()
        {
            InitializeComponent();

            cxmPeople.Renderer = new MyMenuRenderer();
        }

        private void frmPeople_Load(object sender, EventArgs e)
        {
            Organize_dgvPeople();

            lblEmpty.Parent = dgvPeople;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void frmPeople_Resize(object sender, EventArgs e)
        {
            SetMaximized();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPeople_SizeChanged(object sender, EventArgs e)
        {
            Organize_SizeChanged();

            if (dgvPeople.Columns.Count == 0) return;
            Organize_dgvPeopleColumnsWidth();
        }

        private void dgvPeople_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblEmpty.Visible = !(dgvPeople.RowCount > 0);
            lblRecords.Content = $"Records : {dgvPeople.Rows.Count}";
            if ((dgvPeople.Columns.Count > 0))
                Organize_dgvPeopleColumnsWidth();
        }

        private void cbxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPeople_Refresh();
            tbxFilter.Visible = !(cbxFilter.SelectedIndex == 0 || cbxFilter.SelectedIndex == 7);
            cbxGendor.Visible = (cbxFilter.SelectedIndex != 0 && cbxFilter.SelectedIndex == 7);
        }

        private void tbxFilter_ContentChanged(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex != -1)
            {
                Organize_Filter();
            }
        }

        private void cbxGendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvPeople_Refresh();
            if (cbxGendor.SelectedIndex != -1 && cbxGendor.SelectedIndex != 0)
            {
                Organize_GendorFilter();
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            frmAddUpdatePerson frmAddUpdate = new frmAddUpdatePerson();
            frmAddUpdate.ShowDialog();
            dgvPeople_Refresh();
        }

        private void tbxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 9)
            {
                e.Handled = !(clsValidation.IsDigit(e.KeyChar));
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.Rows.Count == 0) return;
            
            frmAddUpdatePerson frmAddUpdate = new frmAddUpdatePerson(int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString()));
            frmAddUpdate.ShowDialog();
            dgvPeople_Refresh();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.Rows.Count == 0) return;

            if (MessageBox.Show($"Are you sure you want to delete the person with ID [{int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString())}].", "Confirm deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (clsPerson.DeletePerson(int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString())))
                {
                    MessageBox.Show("The person has been successfully deleted.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPeople_Refresh();
                }
                else
                {
                    MessageBox.Show("This person cannot be deleted because it is linked to data in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Deletion of the person has been canceled.", "Deletion canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeople.Rows.Count == 0) return;

            frmPersonInformation personInfo = new frmPersonInformation(int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString()));
            personInfo.ShowDialog();
            dgvPeople_Refresh();
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPeople.Rows.Count == 0) return;

            frmPersonInformation personInfo = new frmPersonInformation(int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString()));
            personInfo.ShowDialog();
            dgvPeople_Refresh();
        }

        private void dgvPeople_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (dgvPeople.Rows.Count == 0) return;

                frmPersonInformation personInfo = new frmPersonInformation(int.Parse(dgvPeople.CurrentRow.Cells[0].Value.ToString()));
                personInfo.ShowDialog();
                dgvPeople_Refresh();
            }
        }
    }
}
