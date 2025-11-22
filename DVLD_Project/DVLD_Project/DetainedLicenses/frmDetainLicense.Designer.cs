namespace DVLD_Project.DetainedLicenses
{
    partial class frmDetainLicense
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
            this.ctrlLocalLicenseCardWithFilter1 = new DVLD_Project.Licenses.LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.lblDetainDate = new CuoreUI.Controls.cuiLabel();
            this.lblCreatedByUser = new CuoreUI.Controls.cuiLabel();
            this.lblLicenseID = new CuoreUI.Controls.cuiLabel();
            this.lblDetainID = new CuoreUI.Controls.cuiLabel();
            this.btnShowLicenseHistory = new CuoreUI.Controls.cuiButton();
            this.btnDetain = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox8 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.tbxFineFees = new CuoreUI.Controls.cuiTextBox();
            this.SuspendLayout();
            // 
            // ctrlLocalLicenseCardWithFilter1
            // 
            this.ctrlLocalLicenseCardWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCardWithFilter1.Location = new System.Drawing.Point(12, 52);
            this.ctrlLocalLicenseCardWithFilter1.Name = "ctrlLocalLicenseCardWithFilter1";
            this.ctrlLocalLicenseCardWithFilter1.Size = new System.Drawing.Size(780, 444);
            this.ctrlLocalLicenseCardWithFilter1.TabIndex = 0;
            this.ctrlLocalLicenseCardWithFilter1.OnLicenseSelected += new System.Action<int>(this.ctrlLocalLicenseCardWithFilter1_OnLicenseSelected);
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
            // cuiLabel1
            // 
            this.cuiLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cuiLabel1.Content = "Detain\\ License";
            this.cuiLabel1.Enabled = false;
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(12, 12);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(780, 25);
            this.cuiLabel1.TabIndex = 22;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(85, 498);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(707, 27);
            this.cuiSeparator1.TabIndex = 46;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Detain\\ Info\\ :\\ ";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 502);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(210, 20);
            this.cuiLabel2.TabIndex = 45;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.lblDetainDate.TabIndex = 49;
            this.lblDetainDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.lblCreatedByUser.TabIndex = 51;
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
            this.lblLicenseID.TabIndex = 52;
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
            this.lblDetainID.TabIndex = 50;
            this.lblDetainID.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(12, 672);
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
            this.btnShowLicenseHistory.TabIndex = 73;
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
            this.btnDetain.Content = "Detain";
            this.btnDetain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetain.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDetain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnDetain.ForeColor = System.Drawing.Color.DimGray;
            this.btnDetain.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnDetain.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnDetain.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnDetain.HoverOutline = System.Drawing.Color.DimGray;
            this.btnDetain.Image = global::DVLD_Project.Properties.Resources.cancel;
            this.btnDetain.ImageAutoCenter = true;
            this.btnDetain.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnDetain.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnDetain.Location = new System.Drawing.Point(639, 672);
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
            this.btnDetain.TabIndex = 74;
            this.btnDetain.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDetain.TextOffset = new System.Drawing.Point(2, 0);
            this.btnDetain.Visible = false;
            this.btnDetain.Click += new System.EventHandler(this.btnDetain_Click);
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
            this.cuiPictureBox5.TabIndex = 53;
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
            this.cuiPictureBox4.TabIndex = 54;
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
            this.cuiPictureBox3.TabIndex = 55;
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
            this.cuiPictureBox8.TabIndex = 56;
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
            this.cuiPictureBox7.TabIndex = 57;
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
            this.btnClose.TabIndex = 20;
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
            this.btnMinimize.TabIndex = 21;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // tbxFineFees
            // 
            this.tbxFineFees.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxFineFees.Content = "";
            this.tbxFineFees.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxFineFees.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxFineFees.FocusImageTint = System.Drawing.Color.White;
            this.tbxFineFees.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxFineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFineFees.ForeColor = System.Drawing.Color.Black;
            this.tbxFineFees.Image = null;
            this.tbxFineFees.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxFineFees.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxFineFees.Location = new System.Drawing.Point(51, 622);
            this.tbxFineFees.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFineFees.Multiline = false;
            this.tbxFineFees.Name = "tbxFineFees";
            this.tbxFineFees.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxFineFees.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxFineFees.Padding = new System.Windows.Forms.Padding(15, 9, 15, 0);
            this.tbxFineFees.PasswordChar = false;
            this.tbxFineFees.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxFineFees.PlaceholderText = "Fine Fees";
            this.tbxFineFees.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxFineFees.Size = new System.Drawing.Size(222, 32);
            this.tbxFineFees.TabIndex = 58;
            this.tbxFineFees.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxFineFees.UnderlinedStyle = false;
            this.tbxFineFees.Validating += new System.ComponentModel.CancelEventHandler(this.tbxFineFees_Validating);
            // 
            // frmDetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 716);
            this.Controls.Add(this.btnShowLicenseHistory);
            this.Controls.Add(this.btnDetain);
            this.Controls.Add(this.tbxFineFees);
            this.Controls.Add(this.cuiPictureBox5);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.cuiPictureBox8);
            this.Controls.Add(this.cuiPictureBox7);
            this.Controls.Add(this.lblDetainDate);
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
            this.Name = "frmDetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetainLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private Licenses.LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter ctrlLocalLicenseCardWithFilter1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiLabel lblDetainDate;
        private CuoreUI.Controls.cuiLabel lblCreatedByUser;
        private CuoreUI.Controls.cuiLabel lblLicenseID;
        private CuoreUI.Controls.cuiLabel lblDetainID;
        private CuoreUI.Controls.cuiButton btnShowLicenseHistory;
        private CuoreUI.Controls.cuiButton btnDetain;
        private CuoreUI.Controls.cuiTextBox tbxFineFees;
    }
}