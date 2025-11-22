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

namespace DVLD_Project.Tests
{
    public partial class frmManageTestTypes : Form
    {
        DataTable dtTypes = new DataTable();

        void dgvTestTypes_Refresh()
        {
            dtTypes = clsTestTypes.GetAllTestTypes();
            dgvTestTypes.DataSource = dtTypes;
        }

        void OrganizeSizeChanged()
        {
            dgvTestTypes.Width = this.Width - 24;
            dgvTestTypes.Height = this.Height - 84;

            if (this.WindowState == FormWindowState.Normal)
            {
                btnMaximize.Image = MaximizedImgBox.Images[0];
                cuiResizeGrip1.Visible = true;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Image = MaximizedImgBox.Images[1];
                cuiResizeGrip1.Visible = false;
            }
        }

        void Organize_dgvTestTypesColumnsWidth()
        {
            dgvTestTypes.Columns["TestTypeID"].Width = ((dgvTestTypes.Width * 10)/ 100) - 5;
            dgvTestTypes.Columns["TestTypeTitle"].Width = ((dgvTestTypes.Width * 20) / 100) - 5;
            dgvTestTypes.Columns["TestTypeDescription"].Width = ((dgvTestTypes.Width * 60) / 100) - 5;
            dgvTestTypes.Columns["TestTypeFees"].Width = ((dgvTestTypes.Width * 10) / 100) - 5;
        }
        void LoadData()
        {
            dgvTestTypes_Refresh();

            if (!(dgvTestTypes.Rows.Count > 0)) return;

            dgvTestTypes.Columns["TestTypeID"].HeaderText = "ID";
            dgvTestTypes.Columns["TestTypeTitle"].HeaderText = "Title";
            dgvTestTypes.Columns["TestTypeDescription"].HeaderText = "Description";
            dgvTestTypes.Columns["TestTypeFees"].HeaderText = "Fees";

            Organize_dgvTestTypesColumnsWidth();
        }

        public frmManageTestTypes()
        {
            InitializeComponent();

            lblEmpty.Parent = dgvTestTypes;
            cxmTestTypes.Renderer = new MyMenuRenderer();
            LoadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void dgvTestTypes_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            lblRecords.Content = $"Records : {dgvTestTypes.RowCount}";
            lblEmpty.Visible = (!(dgvTestTypes.Rows.Count > 0));
        }

        private void frmManageTestTypes_SizeChanged(object sender, EventArgs e)
        {
            OrganizeSizeChanged();

            if (!(dgvTestTypes.Rows.Count > 0)) return;
            Organize_dgvTestTypesColumnsWidth();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateTestType updateTestType = new frmUpdateTestType(int.Parse(dgvTestTypes.CurrentRow.Cells[0].Value.ToString()));
            updateTestType.ShowDialog();
            dgvTestTypes_Refresh();
        }
    }
}
