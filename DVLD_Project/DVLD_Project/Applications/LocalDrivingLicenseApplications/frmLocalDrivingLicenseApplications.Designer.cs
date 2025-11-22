namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    partial class frmLocalDrivingLicenseApplications
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalDrivingLicenseApplications));
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.lblEmpty = new CuoreUI.Controls.cuiLabel();
            this.tbxFilter = new CuoreUI.Controls.cuiTextBox();
            this.cbxFilter = new CuoreUI.Controls.cuiComboBox();
            this.lblRecords = new CuoreUI.Controls.cuiLabel();
            this.dgvLDLApps = new System.Windows.Forms.DataGridView();
            this.cxmAppliations = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicaitonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jkToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemVisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemWrittenTest = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemStreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuiResizeGrip = new CuoreUI.Controls.cuiResizeGrip();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.MaximizedImgBox = new System.Windows.Forms.ImageList(this.components);
            this.cbxStatus = new CuoreUI.Controls.cuiComboBox();
            this.btnLDLApp = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnMaximize = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).BeginInit();
            this.cxmAppliations.SuspendLayout();
            this.SuspendLayout();
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
            // lblEmpty
            // 
            this.lblEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmpty.Content = "Empty";
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblEmpty.Location = new System.Drawing.Point(387, 230);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(426, 101);
            this.lblEmpty.TabIndex = 27;
            this.lblEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbxFilter
            // 
            this.tbxFilter.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxFilter.Content = "";
            this.tbxFilter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFilter.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxFilter.FocusImageTint = System.Drawing.Color.White;
            this.tbxFilter.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFilter.ForeColor = System.Drawing.Color.Black;
            this.tbxFilter.Image = null;
            this.tbxFilter.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxFilter.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxFilter.Location = new System.Drawing.Point(178, 70);
            this.tbxFilter.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFilter.Multiline = false;
            this.tbxFilter.Name = "tbxFilter";
            this.tbxFilter.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxFilter.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxFilter.PasswordChar = false;
            this.tbxFilter.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFilter.PlaceholderText = "Search...";
            this.tbxFilter.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxFilter.Size = new System.Drawing.Size(222, 32);
            this.tbxFilter.TabIndex = 19;
            this.tbxFilter.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFilter.UnderlinedStyle = false;
            this.tbxFilter.Visible = false;
            this.tbxFilter.ContentChanged += new System.EventHandler(this.tbxFilter_ContentChanged);
            // 
            // cbxFilter
            // 
            this.cbxFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbxFilter.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxFilter.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxFilter.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxFilter.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxFilter.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxFilter.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxFilter.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxFilter.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxFilter.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxFilter.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxFilter.ExpandArrowColor = System.Drawing.Color.DimGray;
            this.cbxFilter.ForeColor = System.Drawing.Color.DimGray;
            this.cbxFilter.Items = new string[] {
        "None",
        "ID",
        "National No.",
        "License Class",
        "Full Name",
        "Status"};
            this.cbxFilter.Location = new System.Drawing.Point(12, 71);
            this.cbxFilter.Name = "cbxFilter";
            this.cbxFilter.NoSelectionDropdownText = "Empty";
            this.cbxFilter.NoSelectionText = "Filter By";
            this.cbxFilter.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxFilter.OutlineThickness = 1F;
            this.cbxFilter.Rounding = 15;
            this.cbxFilter.Size = new System.Drawing.Size(159, 32);
            this.cbxFilter.TabIndex = 17;
            this.cbxFilter.SelectedIndexChanged += new System.EventHandler(this.cbxFilter_SelectedIndexChanged);
            // 
            // lblRecords
            // 
            this.lblRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecords.Content = "Records\\ :\\ 0";
            this.lblRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecords.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRecords.Location = new System.Drawing.Point(12, 624);
            this.lblRecords.Name = "lblRecords";
            this.lblRecords.Size = new System.Drawing.Size(210, 14);
            this.lblRecords.TabIndex = 26;
            this.lblRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dgvLDLApps
            // 
            this.dgvLDLApps.AllowUserToAddRows = false;
            this.dgvLDLApps.AllowUserToDeleteRows = false;
            this.dgvLDLApps.AllowUserToResizeColumns = false;
            this.dgvLDLApps.AllowUserToResizeRows = false;
            this.dgvLDLApps.BackgroundColor = System.Drawing.Color.White;
            this.dgvLDLApps.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApps.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLDLApps.ColumnHeadersHeight = 25;
            this.dgvLDLApps.ContextMenuStrip = this.cxmAppliations;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLDLApps.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLDLApps.EnableHeadersVisualStyles = false;
            this.dgvLDLApps.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLDLApps.Location = new System.Drawing.Point(12, 109);
            this.dgvLDLApps.MultiSelect = false;
            this.dgvLDLApps.Name = "dgvLDLApps";
            this.dgvLDLApps.ReadOnly = true;
            this.dgvLDLApps.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLDLApps.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLDLApps.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLDLApps.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLDLApps.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLDLApps.Size = new System.Drawing.Size(1176, 509);
            this.dgvLDLApps.TabIndex = 16;
            this.dgvLDLApps.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLDLApps_DataBindingComplete);
            // 
            // cxmAppliations
            // 
            this.cxmAppliations.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.cancelApplicaitonToolStripMenuItem,
            this.jkToolStripMenuItem,
            this.scheduleTestToolStripMenuItem,
            this.issueDrivingLicenseFirstTimeToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.toolStripMenuItem1,
            this.addNewToolStripMenuItem});
            this.cxmAppliations.Name = "cxmPeople";
            this.cxmAppliations.Size = new System.Drawing.Size(246, 236);
            this.cxmAppliations.Opening += new System.ComponentModel.CancelEventHandler(this.cxmAppliations_Opening);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showDetailsToolStripMenuItem.Text = "Show Details";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.updateToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.pencil;
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.updateToolStripMenuItem.Text = "Edit";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.deleteToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.trash_bin;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // cancelApplicaitonToolStripMenuItem
            // 
            this.cancelApplicaitonToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cancelApplicaitonToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.cancel__1_;
            this.cancelApplicaitonToolStripMenuItem.Name = "cancelApplicaitonToolStripMenuItem";
            this.cancelApplicaitonToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.cancelApplicaitonToolStripMenuItem.Text = "Cancel";
            this.cancelApplicaitonToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicaitonToolStripMenuItem_Click);
            // 
            // jkToolStripMenuItem
            // 
            this.jkToolStripMenuItem.Name = "jkToolStripMenuItem";
            this.jkToolStripMenuItem.Size = new System.Drawing.Size(242, 6);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemVisionTest,
            this.toolStripMenuItemWrittenTest,
            this.toolStripMenuItemStreetTest});
            this.scheduleTestToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.scheduleTestToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.time;
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Tests";
            // 
            // toolStripMenuItemVisionTest
            // 
            this.toolStripMenuItemVisionTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.toolStripMenuItemVisionTest.Image = global::DVLD_Project.Properties.Resources.show;
            this.toolStripMenuItemVisionTest.Name = "toolStripMenuItemVisionTest";
            this.toolStripMenuItemVisionTest.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItemVisionTest.Text = "Schedule Vision Test";
            this.toolStripMenuItemVisionTest.Click += new System.EventHandler(this.toolStripMenuItemVisionTest_Click);
            // 
            // toolStripMenuItemWrittenTest
            // 
            this.toolStripMenuItemWrittenTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.toolStripMenuItemWrittenTest.Image = global::DVLD_Project.Properties.Resources.writing_tool;
            this.toolStripMenuItemWrittenTest.Name = "toolStripMenuItemWrittenTest";
            this.toolStripMenuItemWrittenTest.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItemWrittenTest.Text = "Schedule Written Test";
            this.toolStripMenuItemWrittenTest.Click += new System.EventHandler(this.toolStripMenuItemWrittenTest_Click);
            // 
            // toolStripMenuItemStreetTest
            // 
            this.toolStripMenuItemStreetTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.toolStripMenuItemStreetTest.Image = global::DVLD_Project.Properties.Resources.sports_car;
            this.toolStripMenuItemStreetTest.Name = "toolStripMenuItemStreetTest";
            this.toolStripMenuItemStreetTest.Size = new System.Drawing.Size(187, 22);
            this.toolStripMenuItemStreetTest.Text = "Schedule Street Test";
            this.toolStripMenuItemStreetTest.Click += new System.EventHandler(this.toolStripMenuItemStreetTest_Click);
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.driving_license;
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseFirstTimeToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showPersonLicenseHistoryToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(242, 6);
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.addNewToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.add_sign__1_;
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(245, 22);
            this.addNewToolStripMenuItem.Text = "Add Application";
            this.addNewToolStripMenuItem.Click += new System.EventHandler(this.btnLDLApp_Click);
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip.GripSize = 2;
            this.cuiResizeGrip.GripTexture = true;
            this.cuiResizeGrip.Location = new System.Drawing.Point(1188, 450);
            this.cuiResizeGrip.Name = "cuiResizeGrip";
            this.cuiResizeGrip.Size = new System.Drawing.Size(12, 200);
            this.cuiResizeGrip.SkipBottomRightSquare = true;
            this.cuiResizeGrip.TabIndex = 23;
            this.cuiResizeGrip.TargetForm = this;
            this.cuiResizeGrip.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Local\\ Driving\\ License\\ Applications";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(1176, 25);
            this.cuiLabel1.TabIndex = 25;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // MaximizedImgBox
            // 
            this.MaximizedImgBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MaximizedImgBox.ImageStream")));
            this.MaximizedImgBox.TransparentColor = System.Drawing.Color.Transparent;
            this.MaximizedImgBox.Images.SetKeyName(0, "expand.png");
            this.MaximizedImgBox.Images.SetKeyName(1, "minimize.png");
            // 
            // cbxStatus
            // 
            this.cbxStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbxStatus.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxStatus.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxStatus.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxStatus.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxStatus.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxStatus.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxStatus.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxStatus.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxStatus.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxStatus.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxStatus.ExpandArrowColor = System.Drawing.Color.DimGray;
            this.cbxStatus.ForeColor = System.Drawing.Color.DimGray;
            this.cbxStatus.Items = new string[] {
        "None",
        "New",
        "Completed",
        "Cancelled"};
            this.cbxStatus.Location = new System.Drawing.Point(178, 71);
            this.cbxStatus.Name = "cbxStatus";
            this.cbxStatus.NoSelectionDropdownText = "Empty";
            this.cbxStatus.NoSelectionText = "Status";
            this.cbxStatus.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxStatus.OutlineThickness = 1F;
            this.cbxStatus.Rounding = 15;
            this.cbxStatus.Size = new System.Drawing.Size(116, 32);
            this.cbxStatus.TabIndex = 18;
            this.cbxStatus.Visible = false;
            this.cbxStatus.SelectedIndexChanged += new System.EventHandler(this.cbxStatus_SelectedIndexChanged);
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
            this.btnLDLApp.Content = "Add Application";
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
            this.btnLDLApp.Location = new System.Drawing.Point(1035, 71);
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
            this.btnLDLApp.TabIndex = 20;
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
            this.btnClose.Location = new System.Drawing.Point(1163, 12);
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
            this.btnClose.TabIndex = 21;
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
            this.btnMinimize.Location = new System.Drawing.Point(1101, 12);
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
            this.btnMinimize.TabIndex = 24;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.CheckButton = false;
            this.btnMaximize.Checked = false;
            this.btnMaximize.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMaximize.CheckedForeColor = System.Drawing.Color.White;
            this.btnMaximize.CheckedImageTint = System.Drawing.Color.White;
            this.btnMaximize.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnMaximize.Content = "";
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnMaximize.ForeColor = System.Drawing.Color.Black;
            this.btnMaximize.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.HoverForeColor = System.Drawing.Color.Black;
            this.btnMaximize.HoverImageTint = System.Drawing.Color.White;
            this.btnMaximize.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.Image = global::DVLD_Project.Properties.Resources.expand;
            this.btnMaximize.ImageAutoCenter = true;
            this.btnMaximize.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnMaximize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Location = new System.Drawing.Point(1132, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.NormalBackground = System.Drawing.Color.White;
            this.btnMaximize.NormalForeColor = System.Drawing.Color.Black;
            this.btnMaximize.NormalImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnMaximize.OutlineThickness = 1F;
            this.btnMaximize.PressedBackground = System.Drawing.Color.Black;
            this.btnMaximize.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMaximize.PressedImageTint = System.Drawing.Color.White;
            this.btnMaximize.PressedOutline = System.Drawing.Color.Black;
            this.btnMaximize.Rounding = new System.Windows.Forms.Padding(12);
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 22;
            this.btnMaximize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // frmLocalDrivingLicenseApplications
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 650);
            this.Controls.Add(this.btnLDLApp);
            this.Controls.Add(this.lblEmpty);
            this.Controls.Add(this.cbxStatus);
            this.Controls.Add(this.tbxFilter);
            this.Controls.Add(this.cbxFilter);
            this.Controls.Add(this.lblRecords);
            this.Controls.Add(this.dgvLDLApps);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.cuiResizeGrip);
            this.Controls.Add(this.cuiLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "frmLocalDrivingLicenseApplications";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLocalDrivingLicenseApplications";
            this.SizeChanged += new System.EventHandler(this.frmLocalDrivingLicenseApplications_SizeChanged);
            this.Resize += new System.EventHandler(this.frmLocalDrivingLicenseApplications_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLDLApps)).EndInit();
            this.cxmAppliations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiButton btnLDLApp;
        private CuoreUI.Controls.cuiLabel lblEmpty;
        private CuoreUI.Controls.cuiTextBox tbxFilter;
        private CuoreUI.Controls.cuiComboBox cbxFilter;
        private CuoreUI.Controls.cuiLabel lblRecords;
        private System.Windows.Forms.DataGridView dgvLDLApps;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiButton btnMaximize;
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private System.Windows.Forms.ImageList MaximizedImgBox;
        private CuoreUI.Controls.cuiComboBox cbxStatus;
        private System.Windows.Forms.ContextMenuStrip cxmAppliations;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator jkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicaitonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemVisionTest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStreetTest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemWrittenTest;
    }
}