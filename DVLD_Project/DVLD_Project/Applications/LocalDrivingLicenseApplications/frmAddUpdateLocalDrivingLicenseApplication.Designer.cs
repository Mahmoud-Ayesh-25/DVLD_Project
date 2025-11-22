namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    partial class frmAddUpdateLocalDrivingLicenseApplication
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
            this.lblTitle = new CuoreUI.Controls.cuiLabel();
            this.pnlFindUser = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.btnNext = new CuoreUI.Controls.cuiButton();
            this.cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            this.lblAppID = new CuoreUI.Controls.cuiLabel();
            this.pnlAppDetails = new CuoreUI.Controls.cuiPanel();
            this.cbxLicenseClass = new CuoreUI.Controls.cuiComboBox();
            this.lblCreatedBy = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.lblAppFees = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.lblAppDate = new CuoreUI.Controls.cuiLabel();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.btnSave = new CuoreUI.Controls.cuiButton();
            this.btnBack = new CuoreUI.Controls.cuiButton();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.ctrlFindPerson = new DVLD_Project.People.ctrlFindPerson();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.pnlFindUser.SuspendLayout();
            this.pnlAppDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Add\\ Local\\ Driving\\ License\\ Application";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 25);
            this.lblTitle.TabIndex = 16;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlFindUser
            // 
            this.pnlFindUser.Controls.Add(this.cuiLabel2);
            this.pnlFindUser.Controls.Add(this.btnNext);
            this.pnlFindUser.Controls.Add(this.ctrlFindPerson);
            this.pnlFindUser.ImeMode = System.Windows.Forms.ImeMode.On;
            this.pnlFindUser.Location = new System.Drawing.Point(0, 43);
            this.pnlFindUser.Name = "pnlFindUser";
            this.pnlFindUser.OutlineThickness = 1F;
            this.pnlFindUser.PanelColor = System.Drawing.Color.White;
            this.pnlFindUser.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlFindUser.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlFindUser.Size = new System.Drawing.Size(804, 460);
            this.pnlFindUser.TabIndex = 17;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel2.Content = "Find\\ Person";
            this.cuiLabel2.Enabled = false;
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 4);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(780, 25);
            this.cuiLabel2.TabIndex = 15;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.CheckButton = false;
            this.btnNext.Checked = false;
            this.btnNext.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.CheckedForeColor = System.Drawing.Color.White;
            this.btnNext.CheckedImageTint = System.Drawing.Color.White;
            this.btnNext.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnNext.Content = "Next";
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnNext.ForeColor = System.Drawing.Color.DimGray;
            this.btnNext.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnNext.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnNext.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnNext.HoverOutline = System.Drawing.Color.DimGray;
            this.btnNext.Image = global::DVLD_Project.Properties.Resources.right_arrow;
            this.btnNext.ImageAutoCenter = true;
            this.btnNext.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnNext.ImageOffset = new System.Drawing.Point(32, 0);
            this.btnNext.Location = new System.Drawing.Point(639, 416);
            this.btnNext.Name = "btnNext";
            this.btnNext.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnNext.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnNext.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnNext.NormalOutline = System.Drawing.Color.Transparent;
            this.btnNext.OutlineThickness = 1F;
            this.btnNext.PressedBackground = System.Drawing.Color.LightGray;
            this.btnNext.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnNext.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnNext.PressedOutline = System.Drawing.Color.DimGray;
            this.btnNext.Rounding = new System.Windows.Forms.Padding(15);
            this.btnNext.Size = new System.Drawing.Size(153, 32);
            this.btnNext.TabIndex = 4;
            this.btnNext.TextAlignment = System.Drawing.StringAlignment.Near;
            this.btnNext.TextOffset = new System.Drawing.Point(42, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // cuiLabel3
            // 
            this.cuiLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel3.Content = "Application\\ Details";
            this.cuiLabel3.Enabled = false;
            this.cuiLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel3.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel3.Location = new System.Drawing.Point(12, 4);
            this.cuiLabel3.Name = "cuiLabel3";
            this.cuiLabel3.Size = new System.Drawing.Size(780, 25);
            this.cuiLabel3.TabIndex = 35;
            this.cuiLabel3.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAppID
            // 
            this.lblAppID.Content = "LDL\\ Application\\ ID\\ :\\ ";
            this.lblAppID.Enabled = false;
            this.lblAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppID.Location = new System.Drawing.Point(50, 42);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(742, 32);
            this.lblAppID.TabIndex = 40;
            this.lblAppID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // pnlAppDetails
            // 
            this.pnlAppDetails.Controls.Add(this.cbxLicenseClass);
            this.pnlAppDetails.Controls.Add(this.lblCreatedBy);
            this.pnlAppDetails.Controls.Add(this.cuiPictureBox4);
            this.pnlAppDetails.Controls.Add(this.lblAppFees);
            this.pnlAppDetails.Controls.Add(this.cuiPictureBox3);
            this.pnlAppDetails.Controls.Add(this.cuiPictureBox2);
            this.pnlAppDetails.Controls.Add(this.lblAppDate);
            this.pnlAppDetails.Controls.Add(this.cuiPictureBox1);
            this.pnlAppDetails.Controls.Add(this.lblAppID);
            this.pnlAppDetails.Controls.Add(this.cuiPictureBox5);
            this.pnlAppDetails.Controls.Add(this.cuiLabel3);
            this.pnlAppDetails.Controls.Add(this.btnSave);
            this.pnlAppDetails.Controls.Add(this.btnBack);
            this.pnlAppDetails.Location = new System.Drawing.Point(0, 42);
            this.pnlAppDetails.Name = "pnlAppDetails";
            this.pnlAppDetails.OutlineThickness = 1F;
            this.pnlAppDetails.PanelColor = System.Drawing.Color.White;
            this.pnlAppDetails.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlAppDetails.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlAppDetails.Size = new System.Drawing.Size(804, 460);
            this.pnlAppDetails.TabIndex = 18;
            // 
            // cbxLicenseClass
            // 
            this.cbxLicenseClass.BackColor = System.Drawing.Color.Transparent;
            this.cbxLicenseClass.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.cbxLicenseClass.ButtonCursor = System.Windows.Forms.Cursors.Arrow;
            this.cbxLicenseClass.ButtonHoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.cbxLicenseClass.ButtonHoverOutline = System.Drawing.Color.Transparent;
            this.cbxLicenseClass.ButtonNormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cbxLicenseClass.ButtonNormalOutline = System.Drawing.Color.Empty;
            this.cbxLicenseClass.ButtonPressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.cbxLicenseClass.ButtonPressedOutline = System.Drawing.Color.Empty;
            this.cbxLicenseClass.DropDownBackgroundColor = System.Drawing.Color.Transparent;
            this.cbxLicenseClass.DropDownOutlineColor = System.Drawing.Color.Transparent;
            this.cbxLicenseClass.ExpandArrowColor = System.Drawing.Color.DimGray;
            this.cbxLicenseClass.ForeColor = System.Drawing.Color.DimGray;
            this.cbxLicenseClass.Items = new string[0];
            this.cbxLicenseClass.Location = new System.Drawing.Point(50, 155);
            this.cbxLicenseClass.Name = "cbxLicenseClass";
            this.cbxLicenseClass.NoSelectionDropdownText = "Empty";
            this.cbxLicenseClass.NoSelectionText = "License Class";
            this.cbxLicenseClass.OutlineColor = System.Drawing.Color.Gainsboro;
            this.cbxLicenseClass.OutlineThickness = 1F;
            this.cbxLicenseClass.Rounding = 15;
            this.cbxLicenseClass.Size = new System.Drawing.Size(265, 32);
            this.cbxLicenseClass.TabIndex = 41;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.Content = "Created\\ By\\ :\\ ";
            this.lblCreatedBy.Enabled = false;
            this.lblCreatedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.ForeColor = System.Drawing.Color.DimGray;
            this.lblCreatedBy.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblCreatedBy.Location = new System.Drawing.Point(50, 269);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(742, 32);
            this.lblCreatedBy.TabIndex = 40;
            this.lblCreatedBy.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 269);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 36;
            // 
            // lblAppFees
            // 
            this.lblAppFees.Content = "Application\\ Fees\\ :\\ ";
            this.lblAppFees.Enabled = false;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppFees.Location = new System.Drawing.Point(50, 212);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(742, 32);
            this.lblAppFees.TabIndex = 40;
            this.lblAppFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 212);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 36;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.driving_license__1_;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 155);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 36;
            // 
            // lblAppDate
            // 
            this.lblAppDate.Content = "Application\\ Date\\ :\\ ";
            this.lblAppDate.Enabled = false;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppDate.Location = new System.Drawing.Point(50, 98);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(742, 32);
            this.lblAppDate.TabIndex = 40;
            this.lblAppDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 98);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 36;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.id;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 41);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 1F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 36;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CheckButton = false;
            this.btnSave.Checked = false;
            this.btnSave.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.Content = "Save Applicaiton";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnSave.ForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnSave.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnSave.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnSave.HoverOutline = System.Drawing.Color.DimGray;
            this.btnSave.Image = global::DVLD_Project.Properties.Resources.save;
            this.btnSave.ImageAutoCenter = true;
            this.btnSave.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnSave.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnSave.Location = new System.Drawing.Point(480, 416);
            this.btnSave.Name = "btnSave";
            this.btnSave.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnSave.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnSave.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnSave.NormalOutline = System.Drawing.Color.Transparent;
            this.btnSave.OutlineThickness = 1F;
            this.btnSave.PressedBackground = System.Drawing.Color.LightGray;
            this.btnSave.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnSave.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnSave.PressedOutline = System.Drawing.Color.DimGray;
            this.btnSave.Rounding = new System.Windows.Forms.Padding(15);
            this.btnSave.Size = new System.Drawing.Size(153, 32);
            this.btnSave.TabIndex = 34;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.CheckButton = false;
            this.btnBack.Checked = false;
            this.btnBack.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.CheckedForeColor = System.Drawing.Color.White;
            this.btnBack.CheckedImageTint = System.Drawing.Color.White;
            this.btnBack.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnBack.Content = "Back";
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnBack.ForeColor = System.Drawing.Color.DimGray;
            this.btnBack.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnBack.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnBack.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnBack.HoverOutline = System.Drawing.Color.DimGray;
            this.btnBack.Image = global::DVLD_Project.Properties.Resources.left_arrow;
            this.btnBack.ImageAutoCenter = true;
            this.btnBack.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnBack.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnBack.Location = new System.Drawing.Point(639, 416);
            this.btnBack.Name = "btnBack";
            this.btnBack.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnBack.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnBack.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnBack.NormalOutline = System.Drawing.Color.Transparent;
            this.btnBack.OutlineThickness = 1F;
            this.btnBack.PressedBackground = System.Drawing.Color.LightGray;
            this.btnBack.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnBack.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnBack.PressedOutline = System.Drawing.Color.DimGray;
            this.btnBack.Rounding = new System.Windows.Forms.Padding(15);
            this.btnBack.Size = new System.Drawing.Size(153, 32);
            this.btnBack.TabIndex = 34;
            this.btnBack.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBack.TextOffset = new System.Drawing.Point(2, 0);
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.btnClose.Location = new System.Drawing.Point(767, 12);
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
            this.btnClose.TabIndex = 14;
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
            this.btnMinimize.Location = new System.Drawing.Point(736, 12);
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
            this.btnMinimize.TabIndex = 15;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // ctrlFindPerson
            // 
            this.ctrlFindPerson.BackColor = System.Drawing.Color.White;
            this.ctrlFindPerson.Location = new System.Drawing.Point(12, 41);
            this.ctrlFindPerson.Name = "ctrlFindPerson";
            this.ctrlFindPerson.Size = new System.Drawing.Size(780, 368);
            this.ctrlFindPerson.TabIndex = 0;
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
            // frmAddUpdateLocalDrivingLicenseApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 503);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnlAppDetails);
            this.Controls.Add(this.pnlFindUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddUpdateLocalDrivingLicenseApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateLocalDrivingLicenseApplication";
            this.Load += new System.EventHandler(this.frmAddUpdateLocalDrivingLicenseApplication_Load);
            this.pnlFindUser.ResumeLayout(false);
            this.pnlAppDetails.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private CuoreUI.Controls.cuiPanel pnlFindUser;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiButton btnNext;
        private People.ctrlFindPerson ctrlFindPerson;
        private CuoreUI.Controls.cuiButton btnBack;
        private CuoreUI.Controls.cuiButton btnSave;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiLabel lblAppID;
        private CuoreUI.Controls.cuiPanel pnlAppDetails;
        private CuoreUI.Controls.cuiLabel lblCreatedBy;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiLabel lblAppFees;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel lblAppDate;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiComboBox cbxLicenseClass;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
    }
}