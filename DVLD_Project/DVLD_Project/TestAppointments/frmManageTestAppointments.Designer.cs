namespace DVLD_Project.TestAppointments
{
    partial class frmManageTestAppointments
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new CuoreUI.Controls.cuiLabel();
            this.lblEmpty = new CuoreUI.Controls.cuiLabel();
            this.dgvTestAppointments = new System.Windows.Forms.DataGridView();
            this.cxmAppointments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRecords = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.btnLDLApp = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.ctrlApplicaitonInfo = new DVLD_Project.Applications.LocalDrivingLicenseApplications.ctrlApplicaitonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).BeginInit();
            this.cxmAppointments.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Test\\ Appointments";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(838, 25);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblEmpty
            // 
            this.lblEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpty.Content = "Empty";
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblEmpty.Location = new System.Drawing.Point(218, 593);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(426, 101);
            this.lblEmpty.TabIndex = 29;
            this.lblEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // dgvTestAppointments
            // 
            this.dgvTestAppointments.AllowUserToAddRows = false;
            this.dgvTestAppointments.AllowUserToDeleteRows = false;
            this.dgvTestAppointments.AllowUserToResizeColumns = false;
            this.dgvTestAppointments.AllowUserToResizeRows = false;
            this.dgvTestAppointments.BackgroundColor = System.Drawing.Color.White;
            this.dgvTestAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTestAppointments.ColumnHeadersHeight = 25;
            this.dgvTestAppointments.ContextMenuStrip = this.cxmAppointments;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTestAppointments.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTestAppointments.EnableHeadersVisualStyles = false;
            this.dgvTestAppointments.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvTestAppointments.Location = new System.Drawing.Point(12, 527);
            this.dgvTestAppointments.MultiSelect = false;
            this.dgvTestAppointments.Name = "dgvTestAppointments";
            this.dgvTestAppointments.ReadOnly = true;
            this.dgvTestAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTestAppointments.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTestAppointments.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTestAppointments.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTestAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTestAppointments.Size = new System.Drawing.Size(838, 231);
            this.dgvTestAppointments.TabIndex = 28;
            this.dgvTestAppointments.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTestAppointments_DataBindingComplete);
            // 
            // cxmAppointments
            // 
            this.cxmAppointments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateToolStripMenuItem,
            this.takeTestToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewToolStripMenuItem});
            this.cxmAppointments.Name = "cxmPeople";
            this.cxmAppointments.Size = new System.Drawing.Size(181, 98);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.updateToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.pencil;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.takeTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.test__1_;
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.addNewToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.add_sign__1_;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewToolStripMenuItem.Text = "Add Appointment";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.btnLDLApp_Click);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.Content = "Records\\ :\\ 0";
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRecords.Location = new System.Drawing.Point(12, 764);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(210, 14);
            this.lblRecords.TabIndex = 30;
            this.lblRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Appointments\\ :\\ ";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 453);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(210, 20);
            this.cuiLabel1.TabIndex = 32;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiFormAnimator
            // 
            this.cuiFormAnimator.AnimateOnStart = true;
            this.cuiFormAnimator.Duration = 150;
            this.cuiFormAnimator.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.cuiFormAnimator.StartOpacity = 0D;
            this.cuiFormAnimator.TargetForm = this;
            this.cuiFormAnimator.TargetOpacity = 1D;
            // 
            // cuiFormDrag
            // 
            this.cuiFormDrag.TargetForm = this;
            // 
            // cuiFormRounder
            // 
            this.cuiFormRounder.OutlineColor = System.Drawing.Color.Silver;
            this.cuiFormRounder.Rounding = 8;
            this.cuiFormRounder.TargetForm = this;
            // 
            // btnLDLApp
            // 
            this.btnLDLApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLDLApp.CheckButton = false;
            this.btnLDLApp.Checked = false;
            this.btnLDLApp.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLDLApp.CheckedForeColor = System.Drawing.Color.White;
            this.btnLDLApp.CheckedImageTint = System.Drawing.Color.White;
            this.btnLDLApp.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnLDLApp.Content = "Add Appointment";
            this.btnLDLApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLDLApp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLDLApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnLDLApp.ForeColor = System.Drawing.Color.DimGray;
            this.btnLDLApp.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnLDLApp.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnLDLApp.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnLDLApp.HoverOutline = System.Drawing.Color.DimGray;
            this.btnLDLApp.Image = global::DVLD_Project.Properties.Resources.add_sign;
            this.btnLDLApp.ImageAutoCenter = true;
            this.btnLDLApp.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnLDLApp.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnLDLApp.Location = new System.Drawing.Point(697, 489);
            this.btnLDLApp.Name = "btnLDLApp";
            this.btnLDLApp.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnLDLApp.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnLDLApp.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnLDLApp.NormalOutline = System.Drawing.Color.Transparent;
            this.btnLDLApp.OutlineThickness = 1F;
            this.btnLDLApp.PressedBackground = System.Drawing.Color.LightGray;
            this.btnLDLApp.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnLDLApp.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnLDLApp.PressedOutline = System.Drawing.Color.DimGray;
            this.btnLDLApp.Rounding = new System.Windows.Forms.Padding(15);
            this.btnLDLApp.Size = new System.Drawing.Size(153, 32);
            this.btnLDLApp.TabIndex = 31;
            this.btnLDLApp.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLDLApp.TextOffset = new System.Drawing.Point(2, 0);
            this.btnLDLApp.Click += new System.EventHandler(this.btnLDLApp_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.CheckButton = false;
            this.btnClose.Checked = false;
            this.btnClose.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnClose.CheckedForeColor = System.Drawing.Color.White;
            this.btnClose.CheckedImageTint = System.Drawing.Color.White;
            this.btnClose.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnClose.Content = "";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.HoverForeColor = System.Drawing.Color.Black;
            this.btnClose.HoverImageTint = System.Drawing.Color.White;
            this.btnClose.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.Image = global::DVLD_Project.Properties.Resources.cancel;
            this.btnClose.ImageAutoCenter = true;
            this.btnClose.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Location = new System.Drawing.Point(825, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.NormalBackground = System.Drawing.Color.White;
            this.btnClose.NormalForeColor = System.Drawing.Color.Black;
            this.btnClose.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.OutlineThickness = 1F;
            this.btnClose.PressedBackground = System.Drawing.Color.Maroon;
            this.btnClose.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnClose.PressedImageTint = System.Drawing.Color.White;
            this.btnClose.PressedOutline = System.Drawing.Color.Maroon;
            this.btnClose.Rounding = new System.Windows.Forms.Padding(12);
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 17;
            this.btnClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.CheckButton = false;
            this.btnMinimize.Checked = false;
            this.btnMinimize.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMinimize.CheckedImageTint = System.Drawing.Color.White;
            this.btnMinimize.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMinimize.Content = "";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMinimize.ForeColor = System.Drawing.Color.Black;
            this.btnMinimize.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.HoverForeColor = System.Drawing.Color.Black;
            this.btnMinimize.HoverImageTint = System.Drawing.Color.White;
            this.btnMinimize.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.Image = global::DVLD_Project.Properties.Resources.down_chevron;
            this.btnMinimize.ImageAutoCenter = true;
            this.btnMinimize.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Location = new System.Drawing.Point(794, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.NormalBackground = System.Drawing.Color.White;
            this.btnMinimize.NormalForeColor = System.Drawing.Color.Black;
            this.btnMinimize.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.OutlineThickness = 1F;
            this.btnMinimize.PressedBackground = System.Drawing.Color.Black;
            this.btnMinimize.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMinimize.PressedImageTint = System.Drawing.Color.White;
            this.btnMinimize.PressedOutline = System.Drawing.Color.Black;
            this.btnMinimize.Rounding = new System.Windows.Forms.Padding(12);
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 18;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(103, 451);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(747, 24);
            this.cuiSeparator1.TabIndex = 42;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // ctrlApplicaitonInfo
            // 
            this.ctrlApplicaitonInfo.BackColor = System.Drawing.Color.White;
            this.ctrlApplicaitonInfo.Location = new System.Drawing.Point(12, 60);
            this.ctrlApplicaitonInfo.Name = "ctrlApplicaitonInfo";
            this.ctrlApplicaitonInfo.Size = new System.Drawing.Size(838, 374);
            this.ctrlApplicaitonInfo.TabIndex = 20;
            // 
            // frmManageTestAppointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 790);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.btnLDLApp);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.dgvTestAppointments);
            this.Controls.Add(this.ctrlApplicaitonInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageTestAppointments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageTestAppointments";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestAppointments)).EndInit();
            this.cxmAppointments.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Applications.LocalDrivingLicenseApplications.ctrlApplicaitonInfo ctrlApplicaitonInfo;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private CuoreUI.Controls.cuiLabel lblEmpty;
        private System.Windows.Forms.DataGridView dgvTestAppointments;
        private CuoreUI.Controls.cuiLabel lblRecords;
        private CuoreUI.Controls.cuiButton btnLDLApp;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private System.Windows.Forms.ContextMenuStrip cxmAppointments;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    }
}