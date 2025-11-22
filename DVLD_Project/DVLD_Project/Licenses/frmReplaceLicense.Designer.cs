namespace DVLD_Project.Licenses
{
    partial class frmReplaceLicense
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
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.btnShowLicenseInfo = new CuoreUI.Controls.cuiButton();
            this.btnShowLicenseHistory = new CuoreUI.Controls.cuiButton();
            this.btnReplace = new CuoreUI.Controls.cuiButton();
            this.cuiPictureBox12 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox5 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox4 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox11 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox9 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox8 = new CuoreUI.Controls.cuiPictureBox();
            this.lblAppFees = new CuoreUI.Controls.cuiLabel();
            this.lblAppDate = new CuoreUI.Controls.cuiLabel();
            this.lblCreatedByUser = new CuoreUI.Controls.cuiLabel();
            this.lblRLAppID = new CuoreUI.Controls.cuiLabel();
            this.lblOldLicenseID = new CuoreUI.Controls.cuiLabel();
            this.lblReplacedLicenseID = new CuoreUI.Controls.cuiLabel();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.lblTitle = new CuoreUI.Controls.cuiLabel();
            this.cbtnDamage = new CuoreUI.Controls.cuiButtonGroup();
            this.cbtnLost = new CuoreUI.Controls.cuiButtonGroup();
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.ctrlLocalLicenseCardWithFilter = new DVLD_Project.Licenses.LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter();
            this.SuspendLayout();
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Application\\ Info\\ For\\ License\\ Replacement\\ :\\ ";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(12, 502);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(260, 20);
            this.cuiLabel2.TabIndex = 105;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(258, 502);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(533, 20);
            this.cuiSeparator1.TabIndex = 104;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
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
            this.btnShowLicenseInfo.Location = new System.Drawing.Point(215, 670);
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
            this.btnShowLicenseInfo.TabIndex = 103;
            this.btnShowLicenseInfo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowLicenseInfo.TextOffset = new System.Drawing.Point(2, 0);
            this.btnShowLicenseInfo.Visible = false;
            this.btnShowLicenseInfo.Click += new System.EventHandler(this.btnShowLicenseInfo_Click);
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
            this.btnShowLicenseHistory.Location = new System.Drawing.Point(12, 670);
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
            this.btnShowLicenseHistory.TabIndex = 102;
            this.btnShowLicenseHistory.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnShowLicenseHistory.TextOffset = new System.Drawing.Point(2, 0);
            this.btnShowLicenseHistory.Visible = false;
            this.btnShowLicenseHistory.Click += new System.EventHandler(this.btnShowLicenseHistory_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReplace.CheckButton = false;
            this.btnReplace.Checked = false;
            this.btnReplace.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnReplace.CheckedForeColor = System.Drawing.Color.White;
            this.btnReplace.CheckedImageTint = System.Drawing.Color.White;
            this.btnReplace.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnReplace.Content = "Replace";
            this.btnReplace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReplace.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnReplace.ForeColor = System.Drawing.Color.DimGray;
            this.btnReplace.HoverBackground = System.Drawing.Color.Gainsboro;
            this.btnReplace.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnReplace.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnReplace.HoverOutline = System.Drawing.Color.DimGray;
            this.btnReplace.Image = global::DVLD_Project.Properties.Resources.refresh;
            this.btnReplace.ImageAutoCenter = true;
            this.btnReplace.ImageExpand = new System.Drawing.Point(1, 1);
            this.btnReplace.ImageOffset = new System.Drawing.Point(-2, 0);
            this.btnReplace.Location = new System.Drawing.Point(639, 670);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.NormalBackground = System.Drawing.Color.Gainsboro;
            this.btnReplace.NormalForeColor = System.Drawing.Color.DimGray;
            this.btnReplace.NormalImageTint = System.Drawing.Color.DimGray;
            this.btnReplace.NormalOutline = System.Drawing.Color.Transparent;
            this.btnReplace.OutlineThickness = 1F;
            this.btnReplace.PressedBackground = System.Drawing.Color.LightGray;
            this.btnReplace.PressedForeColor = System.Drawing.Color.DimGray;
            this.btnReplace.PressedImageTint = System.Drawing.Color.DimGray;
            this.btnReplace.PressedOutline = System.Drawing.Color.DimGray;
            this.btnReplace.Rounding = new System.Windows.Forms.Padding(15);
            this.btnReplace.Size = new System.Drawing.Size(153, 32);
            this.btnReplace.TabIndex = 101;
            this.btnReplace.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnReplace.TextOffset = new System.Drawing.Point(2, 0);
            this.btnReplace.Visible = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // cuiPictureBox12
            // 
            this.cuiPictureBox12.Content = global::DVLD_Project.Properties.Resources.cash_money;
            this.cuiPictureBox12.Enabled = false;
            this.cuiPictureBox12.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox12.Location = new System.Drawing.Point(12, 623);
            this.cuiPictureBox12.Name = "cuiPictureBox12";
            this.cuiPictureBox12.OutlineThickness = 0F;
            this.cuiPictureBox12.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox12.Rotation = 0;
            this.cuiPictureBox12.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox12.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox12.TabIndex = 91;
            // 
            // cuiPictureBox5
            // 
            this.cuiPictureBox5.Content = global::DVLD_Project.Properties.Resources.calendar__1_;
            this.cuiPictureBox5.Enabled = false;
            this.cuiPictureBox5.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox5.Location = new System.Drawing.Point(12, 576);
            this.cuiPictureBox5.Name = "cuiPictureBox5";
            this.cuiPictureBox5.OutlineThickness = 0F;
            this.cuiPictureBox5.PanelOutlineColor = System.Drawing.Color.Transparent;
            this.cuiPictureBox5.Rotation = 0;
            this.cuiPictureBox5.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox5.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox5.TabIndex = 90;
            // 
            // cuiPictureBox4
            // 
            this.cuiPictureBox4.Content = global::DVLD_Project.Properties.Resources.id;
            this.cuiPictureBox4.Enabled = false;
            this.cuiPictureBox4.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox4.Location = new System.Drawing.Point(12, 529);
            this.cuiPictureBox4.Name = "cuiPictureBox4";
            this.cuiPictureBox4.OutlineThickness = 1F;
            this.cuiPictureBox4.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox4.Rotation = 0;
            this.cuiPictureBox4.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox4.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox4.TabIndex = 92;
            // 
            // cuiPictureBox11
            // 
            this.cuiPictureBox11.Content = global::DVLD_Project.Properties.Resources.id_card;
            this.cuiPictureBox11.Enabled = false;
            this.cuiPictureBox11.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox11.Location = new System.Drawing.Point(319, 623);
            this.cuiPictureBox11.Name = "cuiPictureBox11";
            this.cuiPictureBox11.OutlineThickness = 1F;
            this.cuiPictureBox11.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox11.Rotation = 0;
            this.cuiPictureBox11.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox11.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox11.TabIndex = 95;
            // 
            // cuiPictureBox9
            // 
            this.cuiPictureBox9.Content = global::DVLD_Project.Properties.Resources.driving_license__1_;
            this.cuiPictureBox9.Enabled = false;
            this.cuiPictureBox9.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox9.Location = new System.Drawing.Point(319, 576);
            this.cuiPictureBox9.Name = "cuiPictureBox9";
            this.cuiPictureBox9.OutlineThickness = 1F;
            this.cuiPictureBox9.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox9.Rotation = 0;
            this.cuiPictureBox9.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox9.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox9.TabIndex = 94;
            // 
            // cuiPictureBox8
            // 
            this.cuiPictureBox8.Content = global::DVLD_Project.Properties.Resources.driving_license__1_;
            this.cuiPictureBox8.Enabled = false;
            this.cuiPictureBox8.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox8.Location = new System.Drawing.Point(319, 529);
            this.cuiPictureBox8.Name = "cuiPictureBox8";
            this.cuiPictureBox8.OutlineThickness = 1F;
            this.cuiPictureBox8.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox8.Rotation = 0;
            this.cuiPictureBox8.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox8.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox8.TabIndex = 96;
            // 
            // lblAppFees
            // 
            this.lblAppFees.Content = "Applicaiton\\ Fees\\ :\\ ";
            this.lblAppFees.Enabled = false;
            this.lblAppFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppFees.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppFees.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppFees.Location = new System.Drawing.Point(50, 623);
            this.lblAppFees.Name = "lblAppFees";
            this.lblAppFees.Size = new System.Drawing.Size(263, 32);
            this.lblAppFees.TabIndex = 83;
            this.lblAppFees.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblAppDate
            // 
            this.lblAppDate.Content = "Applicaiton\\ Date\\ :\\ ";
            this.lblAppDate.Enabled = false;
            this.lblAppDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppDate.ForeColor = System.Drawing.Color.DimGray;
            this.lblAppDate.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblAppDate.Location = new System.Drawing.Point(50, 576);
            this.lblAppDate.Name = "lblAppDate";
            this.lblAppDate.Size = new System.Drawing.Size(263, 32);
            this.lblAppDate.TabIndex = 82;
            this.lblAppDate.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblCreatedByUser
            // 
            this.lblCreatedByUser.Content = "Created\\ By\\ User\\ :\\ ";
            this.lblCreatedByUser.Enabled = false;
            this.lblCreatedByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUser.ForeColor = System.Drawing.Color.DimGray;
            this.lblCreatedByUser.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblCreatedByUser.Location = new System.Drawing.Point(357, 623);
            this.lblCreatedByUser.Name = "lblCreatedByUser";
            this.lblCreatedByUser.Size = new System.Drawing.Size(249, 32);
            this.lblCreatedByUser.TabIndex = 80;
            this.lblCreatedByUser.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblRLAppID
            // 
            this.lblRLAppID.Content = "R\\.L\\.Application\\ ID\\ :\\ ";
            this.lblRLAppID.Enabled = false;
            this.lblRLAppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRLAppID.ForeColor = System.Drawing.Color.DimGray;
            this.lblRLAppID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblRLAppID.Location = new System.Drawing.Point(50, 529);
            this.lblRLAppID.Name = "lblRLAppID";
            this.lblRLAppID.Size = new System.Drawing.Size(263, 32);
            this.lblRLAppID.TabIndex = 81;
            this.lblRLAppID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblOldLicenseID
            // 
            this.lblOldLicenseID.Content = "Old\\ License\\ ID\\ :\\ ";
            this.lblOldLicenseID.Enabled = false;
            this.lblOldLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lblOldLicenseID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblOldLicenseID.Location = new System.Drawing.Point(357, 576);
            this.lblOldLicenseID.Name = "lblOldLicenseID";
            this.lblOldLicenseID.Size = new System.Drawing.Size(249, 32);
            this.lblOldLicenseID.TabIndex = 79;
            this.lblOldLicenseID.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblReplacedLicenseID
            // 
            this.lblReplacedLicenseID.Content = "Replaced\\ License\\ ID\\ :\\ ";
            this.lblReplacedLicenseID.Enabled = false;
            this.lblReplacedLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplacedLicenseID.ForeColor = System.Drawing.Color.DimGray;
            this.lblReplacedLicenseID.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblReplacedLicenseID.Location = new System.Drawing.Point(357, 529);
            this.lblReplacedLicenseID.Name = "lblReplacedLicenseID";
            this.lblReplacedLicenseID.Size = new System.Drawing.Size(249, 32);
            this.lblReplacedLicenseID.TabIndex = 86;
            this.lblReplacedLicenseID.VerticalAlignment = System.Drawing.StringAlignment.Center;
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
            this.btnClose.TabIndex = 76;
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
            this.btnMinimize.TabIndex = 77;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Replace\\ License\\ For\\ Lost";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(780, 25);
            this.lblTitle.TabIndex = 78;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cbtnDamage
            // 
            this.cbtnDamage.Checked = false;
            this.cbtnDamage.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnDamage.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnDamage.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnDamage.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnDamage.Content = "Damage";
            this.cbtnDamage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnDamage.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnDamage.Group = 0;
            this.cbtnDamage.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnDamage.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnDamage.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnDamage.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnDamage.Image = null;
            this.cbtnDamage.ImageAutoCenter = true;
            this.cbtnDamage.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnDamage.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnDamage.Location = new System.Drawing.Point(710, 52);
            this.cbtnDamage.Name = "cbtnDamage";
            this.cbtnDamage.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnDamage.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnDamage.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnDamage.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnDamage.OutlineThickness = 1F;
            this.cbtnDamage.PressedBackground = System.Drawing.Color.LightGray;
            this.cbtnDamage.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnDamage.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnDamage.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnDamage.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnDamage.Size = new System.Drawing.Size(82, 32);
            this.cbtnDamage.TabIndex = 106;
            this.cbtnDamage.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnDamage.TextOffset = new System.Drawing.Point(1, 0);
            this.cbtnDamage.Click += new System.EventHandler(this.cbtnDamage_Click);
            // 
            // cbtnLost
            // 
            this.cbtnLost.Checked = true;
            this.cbtnLost.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnLost.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnLost.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnLost.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnLost.Content = "Lost";
            this.cbtnLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnLost.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnLost.Group = 0;
            this.cbtnLost.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnLost.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnLost.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnLost.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnLost.Image = null;
            this.cbtnLost.ImageAutoCenter = true;
            this.cbtnLost.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnLost.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnLost.Location = new System.Drawing.Point(617, 52);
            this.cbtnLost.Name = "cbtnLost";
            this.cbtnLost.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnLost.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnLost.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnLost.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnLost.OutlineThickness = 1F;
            this.cbtnLost.PressedBackground = System.Drawing.Color.LightGray;
            this.cbtnLost.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnLost.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnLost.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnLost.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnLost.Size = new System.Drawing.Size(82, 32);
            this.cbtnLost.TabIndex = 107;
            this.cbtnLost.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnLost.TextOffset = new System.Drawing.Point(1, 0);
            this.cbtnLost.Click += new System.EventHandler(this.cbtnLost_Click);
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
            // ctrlLocalLicenseCardWithFilter
            // 
            this.ctrlLocalLicenseCardWithFilter.BackColor = System.Drawing.Color.White;
            this.ctrlLocalLicenseCardWithFilter.Location = new System.Drawing.Point(12, 52);
            this.ctrlLocalLicenseCardWithFilter.Name = "ctrlLocalLicenseCardWithFilter";
            this.ctrlLocalLicenseCardWithFilter.Size = new System.Drawing.Size(780, 444);
            this.ctrlLocalLicenseCardWithFilter.TabIndex = 75;
            this.ctrlLocalLicenseCardWithFilter.OnLicenseSelected += new System.Action<int>(this.ctrlLocalLicenseCardWithFilter_OnLicenseSelected);
            // 
            // frmReplaceLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(804, 714);
            this.Controls.Add(this.cbtnDamage);
            this.Controls.Add(this.cbtnLost);
            this.Controls.Add(this.cuiLabel2);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.btnShowLicenseInfo);
            this.Controls.Add(this.btnShowLicenseHistory);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.cuiPictureBox12);
            this.Controls.Add(this.cuiPictureBox5);
            this.Controls.Add(this.cuiPictureBox4);
            this.Controls.Add(this.cuiPictureBox11);
            this.Controls.Add(this.cuiPictureBox9);
            this.Controls.Add(this.cuiPictureBox8);
            this.Controls.Add(this.lblAppFees);
            this.Controls.Add(this.lblAppDate);
            this.Controls.Add(this.lblCreatedByUser);
            this.Controls.Add(this.lblRLAppID);
            this.Controls.Add(this.lblOldLicenseID);
            this.Controls.Add(this.lblReplacedLicenseID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.ctrlLocalLicenseCardWithFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReplaceLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReplaceLicense";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiButton btnShowLicenseInfo;
        private CuoreUI.Controls.cuiButton btnShowLicenseHistory;
        private CuoreUI.Controls.cuiButton btnReplace;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox12;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox5;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox4;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox11;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox9;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox8;
        private CuoreUI.Controls.cuiLabel lblAppFees;
        private CuoreUI.Controls.cuiLabel lblAppDate;
        private CuoreUI.Controls.cuiLabel lblCreatedByUser;
        private CuoreUI.Controls.cuiLabel lblRLAppID;
        private CuoreUI.Controls.cuiLabel lblOldLicenseID;
        private CuoreUI.Controls.cuiLabel lblReplacedLicenseID;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private LocalDrivingLicenses.Controls.ctrlLocalLicenseCardWithFilter ctrlLocalLicenseCardWithFilter;
        private CuoreUI.Controls.cuiButtonGroup cbtnDamage;
        private CuoreUI.Controls.cuiButtonGroup cbtnLost;
        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
    }
}