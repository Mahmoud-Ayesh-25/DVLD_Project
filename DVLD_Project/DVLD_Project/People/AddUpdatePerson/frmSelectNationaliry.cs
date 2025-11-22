using CuoreUI.Controls;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Project
{
    public partial class frmSelectNationaliry : Form
    {
        public delegate void DataBackEventHandler(string countryName);
        public event DataBackEventHandler DataBack;

        int index = 0;
        DataTable dtCountries = clsCountries.GetAllCountries();

        void FilterApplied()
        {
            if (tbxFilter.Content.Length > 0)
            {
                DataView view = dtCountries.DefaultView;
                if (view != null)
                {
                    view.RowFilter = $"CountryName LIKE '%{tbxFilter.Content}' OR CountryName LIKE '{tbxFilter.Content}%' OR CountryName LIKE '%{tbxFilter.Content}%'";
                    dgvCountries.DataSource = view;
                }
            }
            else
            {
                dtCountries = clsCountries.GetAllCountries();
                GetAndSetCountries(index);
            }
        }

        bool OrganizeDataBack()
        {
            if (dgvCountries.CurrentRow != null)
            {
                if (dgvCountries.CurrentRow.Index == index) return true;

                DataBack.Invoke(dgvCountries.CurrentRow.Cells[1].Value.ToString());
                return true;
            }
            else
            {
                MessageBox.Show("Select a country first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        void GetAndSetCountries(int index)
        {
            if (dtCountries == null) return;

            dgvCountries.DataSource = dtCountries;

            dgvCountries.Columns["CountryID"].Visible = false;
            dgvCountries.Columns["CountryName"].Width = dgvCountries.Width - 20;

            dgvCountries.FirstDisplayedScrollingRowIndex = index;
        }

        public frmSelectNationaliry(int index)
        {
            InitializeComponent();
            this.index = index;
        }

        private void frmSelectNationaliry_Load(object sender, EventArgs e)
        {
            GetAndSetCountries(index);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCountries_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (OrganizeDataBack())
                {
                    this.Close();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (OrganizeDataBack())
            {
                this.Close();
            }
        }

        private void dgvCountries_DoubleClick(object sender, EventArgs e)
        {
            if (OrganizeDataBack())
            {
                this.Close();
            }
        }

        private void tbxFirstName_ContentChanged(object sender, EventArgs e)
        {
            FilterApplied();
        }
    }
}
