namespace DVLD_Project.Licenses
{
    partial class frmRenewLicense
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
            this.lblRLAppID = new CuoreUI.Controls.cuiLabel();
            this.lblLicenseFees = new CuoreUI.Controls.cuiLabel();
            this.lblAppFees = new CuoreUI.Controls.cuiLabel();
            this.lblTotalFees = new CuoreUI.Controls.cuiLabel();
            this.lblIssueDate = new CuoreUI.Controls.cuiLabel();
            this.lblCreatedByUser = new CuoreUI.Controls.cuiLabel();
            this.lblNewLicneseID = new CuoreUI.Controls.cuiLabel();
            this.lblExpDate = new CuoreUI.Controls.cuiLabel();
            this.lblOldLicenseID = new CuoreUI.Controls.cuiLabel();
            this.lblAppDate = new CuoreUI.Controls.cuiLabel();
            this.tbxNotes = new CuoreUI.Controls.cuiTextBox();
            this.btnRenew = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox6 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox12 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox11 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox3 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox9 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox8 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox13 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox2 = new CuoreUI.Controls.cuiPictureBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnShowLicenseHistory = new CuoreUI.Controls.cuiButton();
            this.btnShowLicenseInfo = new CuoreUI.Controls.cuiButton();
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.ctrlLocalLicenseCardWithFilter = new DVLD_Project.Licenses.LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Renew\\ License";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 25);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblRLAppID
            // 
            this.lblRLAppID.Content = "R\\.L\\.Application\\ ID\\ :\\ ";
            this.lblRLAppID.Enabled = false;
            this.lblRLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLAppID.ForeColor = System.Drawing.Color.DimGray;
            this.lblRLAppID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRLAppID.Location = new System.Drawing.Point(50, 527);
            this.lblRLAppID.Name = "lblRLAppID";
            this.lblRLAppID.Size = new System.Drawing.Size(263, 32);
            this.lblRLAppID.TabIndex = 55;
            this.lblRLAppID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblLicenseFees
            // 
            this.lblLicenseFees.Content = "License\\ Fees\\ :\\ ";
            this.lblLicenseFees.Enabled = false;
            this.lblLicenseFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblLicenseFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblLicenseFees.Location = new System.Drawing.Point(50, 715);
            this.lblLicenseFees.Name = "lblLicenseFees";
            this.lblLicenseFees.Size = new System.Drawing.Size(263, 32);
            this.lblLicenseFees.TabIndex = 54;
            this.lblLicenseFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAppFees
            // 
            this.lblAppFees.Content = "Application\\ Fees\\ :\\ ";
            this.lblAppFees.Enabled = false;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppFees.Location = new System.Drawing.Point(50, 668);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(263, 32);
            this.lblAppFees.TabIndex = 53;
            this.lblAppFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Content = "Total\\ Fees\\ :\\ ";
            this.lblTotalFees.Enabled = false;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblTotalFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblTotalFees.Location = new System.Drawing.Point(357, 715);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(249, 32);
            this.lblTotalFees.TabIndex = 51;
            this.lblTotalFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.Content = "Issue\\ Date\\ :\\ ";
            this.lblIssueDate.Enabled = false;
            this.lblIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIssueDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblIssueDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblIssueDate.Location = new System.Drawing.Point(50, 621);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(263, 32);
            this.lblIssueDate.TabIndex = 52;
            this.lblIssueDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Content = "Created\\ By\\ User\\ :\\ ";
            this.lblCreatedByUser.Enabled = false;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblCreatedByUser.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblCreatedByUser.Location = new System.Drawing.Point(357, 668);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(249, 32);
            this.lblCreatedByUser.TabIndex = 50;
            this.lblCreatedByUser.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblNewLicneseID
            // 
            this.lblNewLicneseID.Content = "New\\ License\\ ID\\ :\\ ";
            this.lblNewLicneseID.Enabled = false;
            this.lblNewLicneseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewLicneseID.ForeColor = System.Drawing.Color.DimGray;
            this.lblNewLicneseID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblNewLicneseID.Location = new System.Drawing.Point(357, 527);
            this.lblNewLicneseID.Name = "lblNewLicneseID";
            this.lblNewLicneseID.Size = new System.Drawing.Size(249, 32);
            this.lblNewLicneseID.TabIndex = 58;
            this.lblNewLicneseID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblExpDate
            // 
            this.lblExpDate.Content = "Exp\\ Date\\ :\\ ";
            this.lblExpDate.Enabled = false;
            this.lblExpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblExpDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblExpDate.Location = new System.Drawing.Point(357, 621);
            this.lblExpDate.Name = "lblExpDate";
            this.lblExpDate.Size = new System.Drawing.Size(249, 32);
            this.lblExpDate.TabIndex = 57;
            this.lblExpDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.Content = "Old\\ License\\ ID\\ :\\ ";
            this.lblOldLicenseID.Enabled = false;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lblOldLicenseID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblOldLicenseID.Location = new System.Drawing.Point(357, 574);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(249, 32);
            this.lblOldLicenseID.TabIndex = 59;
            this.lblOldLicenseID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAppDate
            // 
            this.lblAppDate.Content = "Applicaiton\\ Date\\ :\\ ";
            this.lblAppDate.Enabled = false;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppDate.Location = new System.Drawing.Point(50, 574);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(263, 32);
            this.lblAppDate.TabIndex = 56;
            this.lblAppDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // tbxNotes
            // 
            this.tbxNotes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.tbxNotes.Content = "";
            this.tbxNotes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNotes.FocusBackgroundColor = System.Drawing.Color.White;
            this.tbxNotes.FocusImageTint = System.Drawing.Color.White;
            this.tbxNotes.FocusOutlineColor = System.Drawing.Color.Black;
            this.tbxNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNotes.ForeColor = System.Drawing.Color.Black;
            this.tbxNotes.Image = null;
            this.tbxNotes.ImageExpand = new System.Drawing.Point(0, 0);
            this.tbxNotes.ImageOffset = new System.Drawing.Point(0, 0);
            this.tbxNotes.Location = new System.Drawing.Point(49, 762);
            this.tbxNotes.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNotes.Multiline = true;
            this.tbxNotes.Name = "tbxNotes";
            this.tbxNotes.NormalImageTint = System.Drawing.Color.DimGray;
            this.tbxNotes.OutlineColor = System.Drawing.Color.Gainsboro;
            this.tbxNotes.Padding = new System.Windows.Forms.Padding(15, 8, 15, 8);
            this.tbxNotes.PasswordChar = false;
            this.tbxNotes.PlaceholderColor = System.Drawing.Color.DimGray;
            this.tbxNotes.PlaceholderText = "Notes";
            this.tbxNotes.Rounding = new System.Windows.Forms.Padding(15);
            this.tbxNotes.Size = new System.Drawing.Size(742, 81);
            this.tbxNotes.TabIndex = 71;
            this.tbxNotes.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNotes.UnderlinedStyle = false;
            // 
            // btnRenew
            // 
            this.btnRenew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRenew.CheckButton = false;
            this.btnRenew.Checked = false;
            this.btnRenew.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRenew.CheckedForeColor = System.Drawing.Color.White;
            this.btnRenew.CheckedImageTint = System.Drawing.Color.White;
            this.btnRenew.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnRenew.Content = "Renew";
            this.btnRenew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRenew.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnRenew.ForeColor = System.Drawing.Color.DimGray;
            this.btnRenew.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnRenew.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnRenew.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnRenew.HoverOutline = System.Drawing.Color.DimGray;
            this.btnRenew.Image = global::DVLD_Project.Properties.Resources.refresh;
            this.btnRenew.ImageAutoCenter = true;
            this.btnRenew.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnRenew.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnRenew.Location = new System.Drawing.Point(639, 861);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnRenew.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnRenew.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnRenew.NormalOutline = System.Drawing.Color.Transparent;
            this.btnRenew.OutlineThickness = 1F;
            this.btnRenew.PressedBackground = System.Drawing.Color.LightGray;
            this.btnRenew.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnRenew.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnRenew.PressedOutline = System.Drawing.Color.DimGray;
            this.btnRenew.Rounding = new System.Windows.Forms.Padding(15);
            this.btnRenew.Size = new System.Drawing.Size(153, 32);
            this.btnRenew.TabIndex = 72;
            this.btnRenew.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnRenew.TextOffset = new System.Drawing.Point(2, 0);
            this.btnRenew.Visible = false;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // cuiPictureBox6
            // 
            this.cuiPictureBox6.Content = global::DVLD_Project.Properties.Resources.notes__1_;
            this.cuiPictureBox6.Enabled = false;
            this.cuiPictureBox6.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox6.Location = new System.Drawing.Point(12, 762);
            this.cuiPictureBox6.Name = "cuiPictureBox6";
            this.cuiPictureBox6.OutlineThickness = 1F;
            this.cuiPictureBox6.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox6.Rotation = 0;
            this.cuiPictureBox6.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox6.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox6.TabIndex = 60;
            // 
            // cuiPictureBox12
            // 
            this.cuiPictureBox12.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox12.Enabled = false;
            this.cuiPictureBox12.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox12.Location = new System.Drawing.Point(12, 715);
            this.cuiPictureBox12.Name = "cuiPictureBox12";
            this.cuiPictureBox12.OutlineThickness = 0F;
            this.cuiPictureBox12.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox12.Rotation = 0;
            this.cuiPictureBox12.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox12.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox12.TabIndex = 62;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 668);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 0F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 61;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 621);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 63;
            // 
            // cuiPictureBox11
            // 
            this.cuiPictureBox11.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox11.Enabled = false;
            this.cuiPictureBox11.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox11.Location = new System.Drawing.Point(319, 715);
            this.cuiPictureBox11.Name = "cuiPictureBox11";
            this.cuiPictureBox11.OutlineThickness = 1F;
            this.cuiPictureBox11.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox11.Rotation = 0;
            this.cuiPictureBox11.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox11.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox11.TabIndex = 66;
            // 
            // cuiPictureBox3
            // 
            this.cuiPictureBox3.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox3.Enabled = false;
            this.cuiPictureBox3.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox3.Location = new System.Drawing.Point(12, 574);
            this.cuiPictureBox3.Name = "cuiPictureBox3";
            this.cuiPictureBox3.OutlineThickness = 1F;
            this.cuiPictureBox3.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox3.Rotation = 0;
            this.cuiPictureBox3.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox3.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox3.TabIndex = 64;
            // 
            // cuiPictureBox9
            // 
            this.cuiPictureBox9.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox9.Enabled = false;
            this.cuiPictureBox9.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox9.Location = new System.Drawing.Point(319, 668);
            this.cuiPictureBox9.Name = "cuiPictureBox9";
            this.cuiPictureBox9.OutlineThickness = 1F;
            this.cuiPictureBox9.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox9.Rotation = 0;
            this.cuiPictureBox9.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox9.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox9.TabIndex = 65;
            // 
            // cuiPictureBox8
            // 
            this.cuiPictureBox8.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox8.Enabled = false;
            this.cuiPictureBox8.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox8.Location = new System.Drawing.Point(319, 621);
            this.cuiPictureBox8.Name = "cuiPictureBox8";
            this.cuiPictureBox8.OutlineThickness = 1F;
            this.cuiPictureBox8.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox8.Rotation = 0;
            this.cuiPictureBox8.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox8.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox8.TabIndex = 67;
            // 
            // cuiPictureBox13
            // 
            this.cuiPictureBox13.Content = global::DVLD_Project.Properties.Resources.driving_license__1_;
            this.cuiPictureBox13.Enabled = false;
            this.cuiPictureBox13.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox13.Location = new System.Drawing.Point(319, 527);
            this.cuiPictureBox13.Name = "cuiPictureBox13";
            this.cuiPictureBox13.OutlineThickness = 1F;
            this.cuiPictureBox13.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox13.Rotation = 0;
            this.cuiPictureBox13.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox13.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox13.TabIndex = 68;
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.Content = global::DVLD_Project.Properties.Resources.driving_license__1_;
            this.cuiPictureBox7.Enabled = false;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox7.Location = new System.Drawing.Point(319, 574);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox7.TabIndex = 69;
            // 
            // cuiPictureBox2
            // 
            this.cuiPictureBox2.Content = global::DVLD_Project.Properties.Resources.id;
            this.cuiPictureBox2.Enabled = false;
            this.cuiPictureBox2.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox2.Location = new System.Drawing.Point(12, 527);
            this.cuiPictureBox2.Name = "cuiPictureBox2";
            this.cuiPictureBox2.OutlineThickness = 1F;
            this.cuiPictureBox2.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox2.Rotation = 0;
            this.cuiPictureBox2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox2.TabIndex = 70;
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
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(12, 861);
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
            this.btnShowLicenseHistory.TabIndex = 72;
            this.btnShowLicenseHistory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowLicenseHistory.TextOffset = new System.Drawing.Point(2, 0);
            this.btnShowLicenseHistory.Visible = false;
            this.btnShowLicenseHistory.Click += new System.EventHandler(this.btnShowLicenseHistory_Click);
            // 
            // btnShowLicenseInfo
            // 
            this.btnShowLicenseInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowLicenseInfo.CheckButton = false;
            this.btnShowLicenseInfo.Checked = false;
            this.btnShowLicenseInfo.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowLicenseInfo.CheckedForeColor = System.Drawing.Color.White;
            this.btnShowLicenseInfo.CheckedImageTint = System.Drawing.Color.White;
            this.btnShowLicenseInfo.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnShowLicenseInfo.Content = "Show New License Info";
            this.btnShowLicenseInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowLicenseInfo.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnShowLicenseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnShowLicenseInfo.ForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnShowLicenseInfo.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.HoverOutline = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.Image = global::DVLD_Project.Properties.Resources.show__1_;
            this.btnShowLicenseInfo.ImageAutoCenter = true;
            this.btnShowLicenseInfo.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnShowLicenseInfo.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(215, 861);
            this.btnShowLicenseInfo.Name = "btnShowLicenseInfo";
            this.btnShowLicenseInfo.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnShowLicenseInfo.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.NormalOutline = System.Drawing.Color.Transparent;
            this.btnShowLicenseInfo.OutlineThickness = 1F;
            this.btnShowLicenseInfo.PressedBackground = System.Drawing.Color.LightGray;
            this.btnShowLicenseInfo.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.PressedOutline = System.Drawing.Color.DimGray;
            this.btnShowLicenseInfo.Rounding = new System.Windows.Forms.Padding(15);
            this.btnShowLicenseInfo.Size = new System.Drawing.Size(197, 32);
            this.btnShowLicenseInfo.TabIndex = 72;
            this.btnShowLicenseInfo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowLicenseInfo.TextOffset = new System.Drawing.Point(2, 0);
            this.btnShowLicenseInfo.Visible = false;
            this.btnShowLicenseInfo.Click += new System.EventHandler(this.btnShowLicenseInfo_Click);
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Appliction\\ New\\ License\\ Info\\ :\\ ";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 502);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(183, 20);
            this.cuiLabel2.TabIndex = 74;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(184, 502);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(607, 20);
            this.cuiSeparator1.TabIndex = 73;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // ctrlLocalLicenseCardWithFilter
            // 
            this.ctrlLocalLicenseCardWithFilter.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCardWithFilter.Location = new System.Drawing.Point(12, 52);
            this.ctrlLocalLicenseCardWithFilter.Name = "ctrlLocalLicenseCardWithFilter";
            this.ctrlLocalLicenseCardWithFilter.Size = new System.Drawing.Size(780, 444);
            this.ctrlLocalLicenseCardWithFilter.TabIndex = 0;
            this.ctrlLocalLicenseCardWithFilter.OnLicenseSelected += new System.Action<int>(this.ctrlLocalLicenseCardWithFilter_OnLicenseSelected);
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
            // frmRenewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 905);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicenseHistory);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.tbxNotes);
            this.Controls.Add(this.cuiPictureBox6);
            this.Controls.Add(this.cuiPictureBox12);
            this.Controls.Add(this.cuiPictureBox5);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiPictureBox11);
            this.Controls.Add(this.cuiPictureBox3);
            this.Controls.Add(this.cuiPictureBox9);
            this.Controls.Add(this.cuiPictureBox8);
            this.Controls.Add(this.cuiPictureBox13);
            this.Controls.Add(this.cuiPictureBox7);
            this.Controls.Add(this.cuiPictureBox2);
            this.Controls.Add(this.lblRLAppID);
            this.Controls.Add(this.lblLicenseFees);
            this.Controls.Add(this.lblAppFees);
            this.Controls.Add(this.lblTotalFees);
            this.Controls.Add(this.lblIssueDate);
            this.Controls.Add(this.lblCreatedByUser);
            this.Controls.Add(this.lblNewLicneseID);
            this.Controls.Add(this.lblExpDate);
            this.Controls.Add(this.lblOldLicenseID);
            this.Controls.Add(this.lblAppDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlLocalLicenseCardWithFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRenewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRenewLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter ctrlLocalLicenseCardWithFilter;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox6;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox12;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox11;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox3;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox9;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox8;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox13;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox2;
        private CuoreUI.Controls.cuiLabel lblRLAppID;
        private CuoreUI.Controls.cuiLabel lblLicenseFees;
        private CuoreUI.Controls.cuiLabel lblAppFees;
        private CuoreUI.Controls.cuiLabel lblTotalFees;
        private CuoreUI.Controls.cuiLabel lblIssueDate;
        private CuoreUI.Controls.cuiLabel lblCreatedByUser;
        private CuoreUI.Controls.cuiLabel lblNewLicneseID;
        private CuoreUI.Controls.cuiLabel lblExpDate;
        private CuoreUI.Controls.cuiLabel lblOldLicenseID;
        private CuoreUI.Controls.cuiLabel lblAppDate;
        private CuoreUI.Controls.cuiTextBox tbxNotes;
        private CuoreUI.Controls.cuiButton btnRenew;
        private CuoreUI.Controls.cuiButton btnShowLicenseHistory;
        private CuoreUI.Controls.cuiButton btnShowLicenseInfo;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
    }
}