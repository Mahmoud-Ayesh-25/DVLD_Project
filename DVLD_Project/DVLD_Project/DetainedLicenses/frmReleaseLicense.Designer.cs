namespace DVLD_Project.DetainedLicenses
{
    partial class frmReleaseLicense
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
            this.lblAppID = new CuoreUI.Controls.cuiLabel();
            this.lblTotalFees = new CuoreUI.Controls.cuiLabel();
            this.lblAppFees = new CuoreUI.Controls.cuiLabel();
            this.lblDetainDate = new CuoreUI.Controls.cuiLabel();
            this.lblFineFees = new CuoreUI.Controls.cuiLabel();
            this.lblCreatedByUser = new CuoreUI.Controls.cuiLabel();
            this.lblLicenseID = new CuoreUI.Controls.cuiLabel();
            this.lblDetainID = new CuoreUI.Controls.cuiLabel();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.ctrlLocalLicenseCardWithFilter1 = new DVLD_Project.Licenses.LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.btnShowLicenseHistory = new CuoreUI.Controls.cuiButton();
            this.btnDetain = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox8 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.SuspendLayout();
            // 
            // lblAppID
            // 
            this.lblAppID.Content = "Applicaiton\\ ID\\ :\\ ";
            this.lblAppID.Enabled = false;
            this.lblAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppID.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppID.Location = new System.Drawing.Point(357, 669);
            this.lblAppID.Name = "lblAppID";
            this.lblAppID.Size = new System.Drawing.Size(249, 32);
            this.lblAppID.TabIndex = 99;
            this.lblAppID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Content = "Total\\ Fees\\ :\\ ";
            this.lblTotalFees.Enabled = false;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblTotalFees.Location = new System.Drawing.Point(50, 669);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(263, 32);
            this.lblTotalFees.TabIndex = 86;
            this.lblTotalFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAppFees
            // 
            this.lblAppFees.Content = "Application\\ Fees\\ :\\ ";
            this.lblAppFees.Enabled = false;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppFees.Location = new System.Drawing.Point(50, 622);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(263, 32);
            this.lblAppFees.TabIndex = 85;
            this.lblAppFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDetainDate
            // 
            this.lblDetainDate.Content = "Detain\\ Date\\ :\\ ";
            this.lblDetainDate.Enabled = false;
            this.lblDetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblDetainDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblDetainDate.Location = new System.Drawing.Point(50, 575);
            this.lblDetainDate.Name = "lblDetainDate";
            this.lblDetainDate.Size = new System.Drawing.Size(263, 32);
            this.lblDetainDate.TabIndex = 84;
            this.lblDetainDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblFineFees
            // 
            this.lblFineFees.Content = "Fine\\ Fees\\ :\\ ";
            this.lblFineFees.Enabled = false;
            this.lblFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFineFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblFineFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblFineFees.Location = new System.Drawing.Point(357, 622);
            this.lblFineFees.Name = "lblFineFees";
            this.lblFineFees.Size = new System.Drawing.Size(249, 32);
            this.lblFineFees.TabIndex = 88;
            this.lblFineFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Content = "Created\\ By\\ User\\ :\\ ";
            this.lblCreatedByUser.Enabled = false;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblCreatedByUser.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblCreatedByUser.Location = new System.Drawing.Point(357, 575);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(249, 32);
            this.lblCreatedByUser.TabIndex = 89;
            this.lblCreatedByUser.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblLicenseID
            // 
            this.lblLicenseID.Content = "License\\ ID\\ :\\ ";
            this.lblLicenseID.Enabled = false;
            this.lblLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lblLicenseID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblLicenseID.Location = new System.Drawing.Point(357, 528);
            this.lblLicenseID.Name = "lblLicenseID";
            this.lblLicenseID.Size = new System.Drawing.Size(249, 32);
            this.lblLicenseID.TabIndex = 90;
            this.lblLicenseID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblDetainID
            // 
            this.lblDetainID.Content = "Detain\\ ID\\ :\\ ";
            this.lblDetainID.Enabled = false;
            this.lblDetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetainID.ForeColor = System.Drawing.Color.DimGray;
            this.lblDetainID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblDetainID.Location = new System.Drawing.Point(50, 528);
            this.lblDetainID.Name = "lblDetainID";
            this.lblDetainID.Size = new System.Drawing.Size(263, 32);
            this.lblDetainID.TabIndex = 87;
            this.lblDetainID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(96, 498);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(696, 27);
            this.cuiSeparator1.TabIndex = 83;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Release\\ Info\\ :\\ ";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 502);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(210, 20);
            this.cuiLabel2.TabIndex = 82;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Release\\ License";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(780, 25);
            this.cuiLabel1.TabIndex = 81;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlLocalLicenseCardWithFilter1
            // 
            this.ctrlLocalLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 52);
            this.ctrlLocalLicenseCardWithFilter1.Name = "ctrlLocalLicenseCardWithFilter1";
            this.ctrlLocalLicenseCardWithFilter1.Size = new System.Drawing.Size(780, 444);
            this.ctrlLocalLicenseCardWithFilter1.TabIndex = 78;
            this.ctrlLocalLicenseCardWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLocalLicenseCardWithFilter1_OnLicenseSelected);
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.id;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(319, 669);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 100;
            // 
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox6.Enabled = false;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox6.Location = new System.Drawing.Point(319, 622);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox6.TabIndex = 101;
            // 
            // btnShowLicenseHistory
            // 
            this.btnShowLicenseHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowLicenseHistory.CheckButton = false;
            this.btnShowLicenseHistory.Checked = false;
            this.btnShowLicenseHistory.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowLicenseHistory.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowLicenseHistory.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowLicenseHistory.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowLicenseHistory.Content = "Show License History";
            this.btnShowLicenseHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLicenseHistory.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowLicenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowLicenseHistory.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowLicenseHistory.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowLicenseHistory.ImageAutoCenter = true;
            this.btnShowLicenseHistory.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnShowLicenseHistory.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(12, 725);
            this.btnShowLicenseHistory.Name = "btnShowLicenseHistory";
            this.btnShowLicenseHistory.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowLicenseHistory.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowLicenseHistory.OutlineThickness = 1F;
            this.btnShowLicenseHistory.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowLicenseHistory.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowLicenseHistory.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowLicenseHistory.Size = new System.Drawing.Size(197, 32);
            this.btnShowLicenseHistory.TabIndex = 97;
            this.btnShowLicenseHistory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowLicenseHistory.TextOffset = new System.Drawing.Point(2, 0);
            this.btnShowLicenseHistory.Visible = false;
            this.btnShowLicenseHistory.Click += new System.EventHandler(this.btnShowLicenseHistory_Click);
            // 
            // btnDetain
            // 
            this.btnDetain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDetain.CheckButton = false;
            this.btnDetain.Checked = false;
            this.btnDetain.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDetain.CheckedForeColor = System.Drawing.Color.White;
            this.btnDetain.CheckedImageTint = System.Drawing.Color.White;
            this.btnDetain.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDetain.Content = "Release";
            this.btnDetain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDetain.ForeColor = System.Drawing.Color.DimGray;
            this.btnDetain.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnDetain.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnDetain.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnDetain.HoverOutline = System.Drawing.Color.DimGray;
            this.btnDetain.Image = global::DVLD_Project.Properties.Resources.approve;
            this.btnDetain.ImageAutoCenter = true;
            this.btnDetain.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnDetain.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnDetain.Location = new System.Drawing.Point(639, 725);
            this.btnDetain.Name = "btnDetain";
            this.btnDetain.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnDetain.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnDetain.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnDetain.NormalOutline = System.Drawing.Color.Transparent;
            this.btnDetain.OutlineThickness = 1F;
            this.btnDetain.PressedBackground = System.Drawing.Color.LightGray;
            this.btnDetain.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnDetain.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnDetain.PressedOutline = System.Drawing.Color.DimGray;
            this.btnDetain.Rounding = new System.Windows.Forms.Padding(15);
            this.btnDetain.Size = new System.Drawing.Size(153, 32);
            this.btnDetain.TabIndex = 98;
            this.btnDetain.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDetain.TextOffset = new System.Drawing.Point(2, 0);
            this.btnDetain.Visible = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 669);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 0F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 92;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 622);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 0F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 91;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 575);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 93;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.id;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 528);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 94;
            // 
            // cuiPictureBox8
            // 
            this.cuiPictureBox8.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox8.Enabled = false;
            this.cuiPictureBox8.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox8.Location = new System.Drawing.Point(319, 575);
            this.cuiPictureBox8.Name = "cuiPictureBox8";
            this.cuiPictureBox8.OutlineThickness = 1F;
            this.cuiPictureBox8.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox8.Rotation = 0;
            this.cuiPictureBox8.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox8.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox8.TabIndex = 95;
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.Content = global::DVLD_Project.Properties.Resources.driving_license__1_;
            this.cuiPictureBox7.Enabled = false;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox7.Location = new System.Drawing.Point(319, 528);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox7.TabIndex = 96;
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
            this.btnClose.TabIndex = 79;
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
            this.btnMinimize.TabIndex = 80;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            // frmReleaseLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 769);
            this.Controls.Add(this.cuiPictureBox2);
            this.Controls.Add(this.cuiPictureBox6);
            this.Controls.Add(this.lblAppID);
            this.Controls.Add(this.btnShowLicenseHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.cuiPictureBox5);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.cuiPictureBox8);
            this.Controls.Add(this.cuiPictureBox7);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblAppFees);
            this.Controls.Add(this.lblDetainDate);
            this.Controls.Add(this.lblFineFees);
            this.Controls.Add(this.lblCreatedByUser);
            this.Controls.Add(this.lblLicenseID);
            this.Controls.Add(this.lblDetainID);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.ctrlLocalLicenseCardWithFilter1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReleaseLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReleaseLicense";
            this.Load += new System.EventHandler(this.frmReleaseLicense_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiLabel lblAppID;
        private CuoreUI.Controls.cuiButton btnShowLicenseHistory;
        private CuoreUI.Controls.cuiButton btnDetain;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiLabel lblTotalFees;
        private CuoreUI.Controls.cuiLabel lblAppFees;
        private CuoreUI.Controls.cuiLabel lblDetainDate;
        private CuoreUI.Controls.cuiLabel lblFineFees;
        private CuoreUI.Controls.cuiLabel lblCreatedByUser;
        private CuoreUI.Controls.cuiLabel lblLicenseID;
        private CuoreUI.Controls.cuiLabel lblDetainID;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Licenses.LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter ctrlLocalLicenseCardWithFilter1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
    }
}