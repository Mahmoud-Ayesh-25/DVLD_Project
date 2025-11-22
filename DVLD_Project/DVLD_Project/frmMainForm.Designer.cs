using System.Threading.Tasks;

namespace DVLD_Project
{
    partial class frmMainForm
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
        private async Task InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.MessageDialog = new CuoreUI.Components.cuiMessageDialog();
            this.MainFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.MainFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.MainFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.cuiResizeGrip = new CuoreUI.Controls.cuiResizeGrip();
            this.cuiResizeGrip1 = new CuoreUI.Controls.cuiResizeGrip();
            this.MaximizedImgBox = new System.Windows.Forms.ImageList(this.components);
            this.pnlMainMenu = new CuoreUI.Controls.cuiGradientPanel();
            this.btnAccountSettings = new CuoreUI.Controls.cuiButton();
            this.btnUsers = new CuoreUI.Controls.cuiButton();
            this.btnApplications = new CuoreUI.Controls.cuiButton();
            this.btnPeople = new CuoreUI.Controls.cuiButton();
            this.btnDrivers = new CuoreUI.Controls.cuiButton();
            this.cuiPanel2 = new CuoreUI.Controls.cuiPanel();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnMaximize = new CuoreUI.Controls.cuiButton();
            this.cuiPanel1 = new CuoreUI.Controls.cuiPanel();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.cxmApplicaitons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivingLicenseServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceForLostOrDamageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detaineLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cxmAccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.currentUserInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMainMenu.SuspendLayout();
            this.cuiPanel2.SuspendLayout();
            this.cuiPanel1.SuspendLayout();
            this.cxmApplicaitons.SuspendLayout();
            this.cxmAccountSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // MessageDialog
            // 
            this.MessageDialog.BackColor = System.Drawing.Color.White;
            this.MessageDialog.ButtonSize = new System.Drawing.Size(80, 32);
            this.MessageDialog.CancelText = "Cancel";
            this.MessageDialog.DialogPadding = new System.Windows.Forms.Padding(20);
            this.MessageDialog.DialogSize = new System.Drawing.Size(300, 200);
            this.MessageDialog.DimColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MessageDialog.ForeColor = System.Drawing.Color.Black;
            this.MessageDialog.NoText = "No";
            this.MessageDialog.OKText = "OK";
            this.MessageDialog.Rounding = 8;
            this.MessageDialog.YesText = "Yes";
            // 
            // MainFormDrag
            // 
            this.MainFormDrag.TargetForm = this;
            // 
            // MainFormAnimator
            // 
            this.MainFormAnimator.AnimateOnStart = true;
            this.MainFormAnimator.Duration = 150;
            this.MainFormAnimator.EasingType = CuoreUI.Drawing.EasingTypes.QuadIn;
            this.MainFormAnimator.StartOpacity = 0D;
            this.MainFormAnimator.TargetForm = this;
            this.MainFormAnimator.TargetOpacity = 1D;
            // 
            // MainFormRounder
            // 
            this.MainFormRounder.OutlineColor = System.Drawing.Color.Silver;
            this.MainFormRounder.Rounding = 8;
            this.MainFormRounder.TargetForm = this;
            // 
            // cuiResizeGrip
            // 
            this.cuiResizeGrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip.GripSize = 2;
            this.cuiResizeGrip.GripTexture = true;
            this.cuiResizeGrip.Location = new System.Drawing.Point(1782, 773);
            this.cuiResizeGrip.Margin = new System.Windows.Forms.Padding(4);
            this.cuiResizeGrip.Name = "cuiResizeGrip";
            this.cuiResizeGrip.Size = new System.Drawing.Size(18, 15);
            this.cuiResizeGrip.SkipBottomRightSquare = true;
            this.cuiResizeGrip.TabIndex = 1;
            this.cuiResizeGrip.TargetForm = this;
            this.cuiResizeGrip.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // cuiResizeGrip1
            // 
            this.cuiResizeGrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiResizeGrip1.Cursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.cuiResizeGrip1.GripColor = System.Drawing.Color.Gray;
            this.cuiResizeGrip1.GripSize = 2;
            this.cuiResizeGrip1.GripTexture = true;
            this.cuiResizeGrip1.Location = new System.Drawing.Point(1188, 440);
            this.cuiResizeGrip1.Name = "cuiResizeGrip1";
            this.cuiResizeGrip1.Size = new System.Drawing.Size(12, 200);
            this.cuiResizeGrip1.SkipBottomRightSquare = true;
            this.cuiResizeGrip1.TabIndex = 4;
            this.cuiResizeGrip1.TargetForm = this;
            this.cuiResizeGrip1.TextureOffset = new System.Drawing.Size(-2, -2);
            // 
            // MaximizedImgBox
            // 
            this.MaximizedImgBox.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MaximizedImgBox.ImageStream")));
            this.MaximizedImgBox.TransparentColor = System.Drawing.Color.Transparent;
            this.MaximizedImgBox.Images.SetKeyName(0, "expand.png");
            this.MaximizedImgBox.Images.SetKeyName(1, "minimize.png");
            // 
            // pnlMainMenu
            // 
            this.pnlMainMenu.Controls.Add(this.btnAccountSettings);
            this.pnlMainMenu.Controls.Add(this.btnUsers);
            this.pnlMainMenu.Controls.Add(this.btnApplications);
            this.pnlMainMenu.Controls.Add(this.btnPeople);
            this.pnlMainMenu.Controls.Add(this.btnDrivers);
            this.pnlMainMenu.Controls.Add(this.cuiPanel2);
            this.pnlMainMenu.Controls.Add(this.cuiPanel1);
            this.pnlMainMenu.GradientAngle = -90F;
            this.pnlMainMenu.Location = new System.Drawing.Point(12, 12);
            this.pnlMainMenu.Name = "pnlMainMenu";
            this.pnlMainMenu.OutlineThickness = 1F;
            this.pnlMainMenu.PanelColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.pnlMainMenu.PanelColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.pnlMainMenu.PanelOutlineColor1 = System.Drawing.Color.Transparent;
            this.pnlMainMenu.PanelOutlineColor2 = System.Drawing.Color.Transparent;
            this.pnlMainMenu.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlMainMenu.Size = new System.Drawing.Size(1176, 117);
            this.pnlMainMenu.TabIndex = 5;
            // 
            // btnAccountSettings
            // 
            this.btnAccountSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAccountSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnAccountSettings.CheckButton = false;
            this.btnAccountSettings.Checked = false;
            this.btnAccountSettings.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAccountSettings.CheckedForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.CheckedImageTint = System.Drawing.Color.White;
            this.btnAccountSettings.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnAccountSettings.Content = "Account Settings";
            this.btnAccountSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccountSettings.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAccountSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccountSettings.ForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnAccountSettings.HoverForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.HoverImageTint = System.Drawing.Color.White;
            this.btnAccountSettings.HoverOutline = System.Drawing.Color.Transparent;
            this.btnAccountSettings.Image = global::DVLD_Project.Properties.Resources.setting;
            this.btnAccountSettings.ImageAutoCenter = false;
            this.btnAccountSettings.ImageExpand = new System.Drawing.Point(27, 27);
            this.btnAccountSettings.ImageOffset = new System.Drawing.Point(49, -15);
            this.btnAccountSettings.Location = new System.Drawing.Point(758, 2);
            this.btnAccountSettings.Name = "btnAccountSettings";
            this.btnAccountSettings.NormalBackground = System.Drawing.Color.Transparent;
            this.btnAccountSettings.NormalForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.NormalImageTint = System.Drawing.Color.White;
            this.btnAccountSettings.NormalOutline = System.Drawing.Color.Transparent;
            this.btnAccountSettings.OutlineThickness = 0F;
            this.btnAccountSettings.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.btnAccountSettings.PressedForeColor = System.Drawing.Color.White;
            this.btnAccountSettings.PressedImageTint = System.Drawing.Color.White;
            this.btnAccountSettings.PressedOutline = System.Drawing.Color.Transparent;
            this.btnAccountSettings.Rounding = new System.Windows.Forms.Padding(0);
            this.btnAccountSettings.Size = new System.Drawing.Size(114, 114);
            this.btnAccountSettings.TabIndex = 4;
            this.btnAccountSettings.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnAccountSettings.TextOffset = new System.Drawing.Point(-69, 40);
            this.btnAccountSettings.Click += new System.EventHandler(this.btnAccountSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnUsers.CheckButton = false;
            this.btnUsers.Checked = false;
            this.btnUsers.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUsers.CheckedForeColor = System.Drawing.Color.White;
            this.btnUsers.CheckedImageTint = System.Drawing.Color.White;
            this.btnUsers.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnUsers.Content = "Users";
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.ForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnUsers.HoverForeColor = System.Drawing.Color.White;
            this.btnUsers.HoverImageTint = System.Drawing.Color.White;
            this.btnUsers.HoverOutline = System.Drawing.Color.Transparent;
            this.btnUsers.Image = global::DVLD_Project.Properties.Resources.user_engagement;
            this.btnUsers.ImageAutoCenter = false;
            this.btnUsers.ImageExpand = new System.Drawing.Point(27, 27);
            this.btnUsers.ImageOffset = new System.Drawing.Point(50, -15);
            this.btnUsers.Location = new System.Drawing.Point(644, 2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.NormalBackground = System.Drawing.Color.Transparent;
            this.btnUsers.NormalForeColor = System.Drawing.Color.White;
            this.btnUsers.NormalImageTint = System.Drawing.Color.White;
            this.btnUsers.NormalOutline = System.Drawing.Color.Transparent;
            this.btnUsers.OutlineThickness = 0F;
            this.btnUsers.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.btnUsers.PressedForeColor = System.Drawing.Color.White;
            this.btnUsers.PressedImageTint = System.Drawing.Color.White;
            this.btnUsers.PressedOutline = System.Drawing.Color.Transparent;
            this.btnUsers.Rounding = new System.Windows.Forms.Padding(0);
            this.btnUsers.Size = new System.Drawing.Size(114, 114);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnUsers.TextOffset = new System.Drawing.Point(-69, 40);
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnApplications
            // 
            this.btnApplications.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApplications.BackColor = System.Drawing.Color.Transparent;
            this.btnApplications.CheckButton = false;
            this.btnApplications.Checked = false;
            this.btnApplications.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnApplications.CheckedForeColor = System.Drawing.Color.White;
            this.btnApplications.CheckedImageTint = System.Drawing.Color.White;
            this.btnApplications.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnApplications.Content = "Applications";
            this.btnApplications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplications.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnApplications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplications.ForeColor = System.Drawing.Color.White;
            this.btnApplications.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnApplications.HoverForeColor = System.Drawing.Color.White;
            this.btnApplications.HoverImageTint = System.Drawing.Color.White;
            this.btnApplications.HoverOutline = System.Drawing.Color.Transparent;
            this.btnApplications.Image = global::DVLD_Project.Properties.Resources.form;
            this.btnApplications.ImageAutoCenter = false;
            this.btnApplications.ImageExpand = new System.Drawing.Point(27, 27);
            this.btnApplications.ImageOffset = new System.Drawing.Point(50, -15);
            this.btnApplications.Location = new System.Drawing.Point(296, 2);
            this.btnApplications.Name = "btnApplications";
            this.btnApplications.NormalBackground = System.Drawing.Color.Transparent;
            this.btnApplications.NormalForeColor = System.Drawing.Color.White;
            this.btnApplications.NormalImageTint = System.Drawing.Color.White;
            this.btnApplications.NormalOutline = System.Drawing.Color.Transparent;
            this.btnApplications.OutlineThickness = 0F;
            this.btnApplications.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.btnApplications.PressedForeColor = System.Drawing.Color.White;
            this.btnApplications.PressedImageTint = System.Drawing.Color.White;
            this.btnApplications.PressedOutline = System.Drawing.Color.Transparent;
            this.btnApplications.Rounding = new System.Windows.Forms.Padding(0);
            this.btnApplications.Size = new System.Drawing.Size(114, 114);
            this.btnApplications.TabIndex = 0;
            this.btnApplications.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnApplications.TextOffset = new System.Drawing.Point(-69, 40);
            this.btnApplications.Click += new System.EventHandler(this.btnApplications_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.CheckButton = false;
            this.btnPeople.Checked = false;
            this.btnPeople.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPeople.CheckedForeColor = System.Drawing.Color.White;
            this.btnPeople.CheckedImageTint = System.Drawing.Color.White;
            this.btnPeople.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnPeople.Content = "People";
            this.btnPeople.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPeople.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.ForeColor = System.Drawing.Color.White;
            this.btnPeople.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnPeople.HoverForeColor = System.Drawing.Color.White;
            this.btnPeople.HoverImageTint = System.Drawing.Color.White;
            this.btnPeople.HoverOutline = System.Drawing.Color.Transparent;
            this.btnPeople.Image = global::DVLD_Project.Properties.Resources.group;
            this.btnPeople.ImageAutoCenter = false;
            this.btnPeople.ImageExpand = new System.Drawing.Point(27, 27);
            this.btnPeople.ImageOffset = new System.Drawing.Point(50, -15);
            this.btnPeople.Location = new System.Drawing.Point(416, 2);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.NormalBackground = System.Drawing.Color.Transparent;
            this.btnPeople.NormalForeColor = System.Drawing.Color.White;
            this.btnPeople.NormalImageTint = System.Drawing.Color.White;
            this.btnPeople.NormalOutline = System.Drawing.Color.Transparent;
            this.btnPeople.OutlineThickness = 0F;
            this.btnPeople.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.btnPeople.PressedForeColor = System.Drawing.Color.White;
            this.btnPeople.PressedImageTint = System.Drawing.Color.White;
            this.btnPeople.PressedOutline = System.Drawing.Color.Transparent;
            this.btnPeople.Rounding = new System.Windows.Forms.Padding(0);
            this.btnPeople.Size = new System.Drawing.Size(114, 114);
            this.btnPeople.TabIndex = 1;
            this.btnPeople.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnPeople.TextOffset = new System.Drawing.Point(-69, 40);
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnDrivers
            // 
            this.btnDrivers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDrivers.BackColor = System.Drawing.Color.Transparent;
            this.btnDrivers.CheckButton = false;
            this.btnDrivers.Checked = false;
            this.btnDrivers.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDrivers.CheckedForeColor = System.Drawing.Color.White;
            this.btnDrivers.CheckedImageTint = System.Drawing.Color.White;
            this.btnDrivers.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnDrivers.Content = "Drivers";
            this.btnDrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDrivers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDrivers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDrivers.ForeColor = System.Drawing.Color.White;
            this.btnDrivers.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(110)))));
            this.btnDrivers.HoverForeColor = System.Drawing.Color.White;
            this.btnDrivers.HoverImageTint = System.Drawing.Color.White;
            this.btnDrivers.HoverOutline = System.Drawing.Color.Transparent;
            this.btnDrivers.Image = global::DVLD_Project.Properties.Resources.steering_wheel;
            this.btnDrivers.ImageAutoCenter = false;
            this.btnDrivers.ImageExpand = new System.Drawing.Point(27, 27);
            this.btnDrivers.ImageOffset = new System.Drawing.Point(50, -15);
            this.btnDrivers.Location = new System.Drawing.Point(530, 2);
            this.btnDrivers.Name = "btnDrivers";
            this.btnDrivers.NormalBackground = System.Drawing.Color.Transparent;
            this.btnDrivers.NormalForeColor = System.Drawing.Color.White;
            this.btnDrivers.NormalImageTint = System.Drawing.Color.White;
            this.btnDrivers.NormalOutline = System.Drawing.Color.Transparent;
            this.btnDrivers.OutlineThickness = 0F;
            this.btnDrivers.PressedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(130)))));
            this.btnDrivers.PressedForeColor = System.Drawing.Color.White;
            this.btnDrivers.PressedImageTint = System.Drawing.Color.White;
            this.btnDrivers.PressedOutline = System.Drawing.Color.Transparent;
            this.btnDrivers.Rounding = new System.Windows.Forms.Padding(0);
            this.btnDrivers.Size = new System.Drawing.Size(114, 114);
            this.btnDrivers.TabIndex = 2;
            this.btnDrivers.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnDrivers.TextOffset = new System.Drawing.Point(-69, 40);
            this.btnDrivers.Click += new System.EventHandler(this.btnDrivers_Click);
            // 
            // cuiPanel2
            // 
            this.cuiPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cuiPanel2.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel2.Controls.Add(this.btnClose);
            this.cuiPanel2.Controls.Add(this.btnMinimize);
            this.cuiPanel2.Controls.Add(this.btnMaximize);
            this.cuiPanel2.Location = new System.Drawing.Point(1028, 32);
            this.cuiPanel2.Name = "cuiPanel2";
            this.cuiPanel2.OutlineThickness = 1F;
            this.cuiPanel2.PanelColor = System.Drawing.Color.White;
            this.cuiPanel2.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel2.Rounding = new System.Windows.Forms.Padding(25);
            this.cuiPanel2.Size = new System.Drawing.Size(136, 53);
            this.cuiPanel2.TabIndex = 7;
            // 
            // btnClose
            // 
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
            this.btnClose.Location = new System.Drawing.Point(87, 14);
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
            this.btnClose.TabIndex = 5;
            this.btnClose.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnClose.TextOffset = new System.Drawing.Point(0, 0);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
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
            this.btnMinimize.Location = new System.Drawing.Point(25, 14);
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
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMinimize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
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
            this.btnMaximize.Location = new System.Drawing.Point(56, 14);
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
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnMaximize.TextOffset = new System.Drawing.Point(0, 0);
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // cuiPanel1
            // 
            this.cuiPanel1.BackColor = System.Drawing.Color.Transparent;
            this.cuiPanel1.Controls.Add(this.cuiLabel1);
            this.cuiPanel1.Location = new System.Drawing.Point(12, 32);
            this.cuiPanel1.Name = "cuiPanel1";
            this.cuiPanel1.OutlineThickness = 1F;
            this.cuiPanel1.PanelColor = System.Drawing.Color.White;
            this.cuiPanel1.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiPanel1.Rounding = new System.Windows.Forms.Padding(25);
            this.cuiPanel1.Size = new System.Drawing.Size(136, 53);
            this.cuiPanel1.TabIndex = 6;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "DVLD";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.cuiLabel1.Location = new System.Drawing.Point(1, 3);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(136, 53);
            this.cuiLabel1.TabIndex = 6;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // cxmApplicaitons
            // 
            this.cxmApplicaitons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicenseServicesToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.detainLicensesToolStripMenuItem,
            this.manageApplicationsTypesToolStripMenuItem,
            this.manageTestTypesToolStripMenuItem});
            this.cxmApplicaitons.Name = "cxmApplicaitons";
            this.cxmApplicaitons.Size = new System.Drawing.Size(267, 376);
            // 
            // drivingLicenseServicesToolStripMenuItem
            // 
            this.drivingLicenseServicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replaceForLostOrDamageToolStripMenuItem,
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem,
            this.retakeToolStripMenuItem});
            this.drivingLicenseServicesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.drivingLicenseServicesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drive__1_;
            this.drivingLicenseServicesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.drivingLicenseServicesToolStripMenuItem.Name = "drivingLicenseServicesToolStripMenuItem";
            this.drivingLicenseServicesToolStripMenuItem.Size = new System.Drawing.Size(266, 70);
            this.drivingLicenseServicesToolStripMenuItem.Text = "Driving Licenses Services";
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalDrivingLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.newDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drive__1_;
            this.newDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(343, 70);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            this.localDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.localDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.home_button;
            this.localDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(272, 70);
            this.localDrivingLicenseToolStripMenuItem.Text = "Local Driving License";
            this.localDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseToolStripMenuItem_Click);
            // 
            // internationalDrivingLicenseToolStripMenuItem
            // 
            this.internationalDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.internationalDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.earth;
            this.internationalDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internationalDrivingLicenseToolStripMenuItem.Name = "internationalDrivingLicenseToolStripMenuItem";
            this.internationalDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(272, 70);
            this.internationalDrivingLicenseToolStripMenuItem.Text = "International Driving License";
            this.internationalDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.renewDrivingLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drive__1_;
            this.renewDrivingLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(343, 70);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replaceForLostOrDamageToolStripMenuItem
            // 
            this.replaceForLostOrDamageToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.replaceForLostOrDamageToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drive__1_;
            this.replaceForLostOrDamageToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replaceForLostOrDamageToolStripMenuItem.Name = "replaceForLostOrDamageToolStripMenuItem";
            this.replaceForLostOrDamageToolStripMenuItem.Size = new System.Drawing.Size(343, 70);
            this.replaceForLostOrDamageToolStripMenuItem.Text = "Replacement for Lost or Damage License";
            this.replaceForLostOrDamageToolStripMenuItem.Click += new System.EventHandler(this.replaceForLostOrDamageToolStripMenuItem_Click);
            // 
            // relaiseDetainedDrivingLIcenseToolStripMenuItem
            // 
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.drive__1_;
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.Name = "relaiseDetainedDrivingLIcenseToolStripMenuItem";
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.Size = new System.Drawing.Size(343, 70);
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.Text = "Release Detained Driving License";
            this.relaiseDetainedDrivingLIcenseToolStripMenuItem.Click += new System.EventHandler(this.relaiseDetainedDrivingLIcenseToolStripMenuItem_Click);
            // 
            // retakeToolStripMenuItem
            // 
            this.retakeToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.retakeToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.exam;
            this.retakeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.retakeToolStripMenuItem.Name = "retakeToolStripMenuItem";
            this.retakeToolStripMenuItem.Size = new System.Drawing.Size(343, 70);
            this.retakeToolStripMenuItem.Text = "Retake Test";
            this.retakeToolStripMenuItem.Click += new System.EventHandler(this.retakeToolStripMenuItem_Click);
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseApplicationsToolStripMenuItem,
            this.internaToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.manageApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.curriculum_vitae__1_;
            this.manageApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(266, 70);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseApplicationsToolStripMenuItem
            // 
            this.localDrivingLicenseApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.localDrivingLicenseApplicationsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.home_button;
            this.localDrivingLicenseApplicationsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.localDrivingLicenseApplicationsToolStripMenuItem.Name = "localDrivingLicenseApplicationsToolStripMenuItem";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Size = new System.Drawing.Size(336, 70);
            this.localDrivingLicenseApplicationsToolStripMenuItem.Text = "Local Driving License Applications";
            this.localDrivingLicenseApplicationsToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseApplicationsToolStripMenuItem_Click);
            // 
            // internaToolStripMenuItem
            // 
            this.internaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.internaToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.earth;
            this.internaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.internaToolStripMenuItem.Name = "internaToolStripMenuItem";
            this.internaToolStripMenuItem.Size = new System.Drawing.Size(336, 70);
            this.internaToolStripMenuItem.Text = "International Driving License Application";
            this.internaToolStripMenuItem.Click += new System.EventHandler(this.internaToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detaineLicenseToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.detainLicensesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.block;
            this.detainLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(266, 70);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.manageDetainedLicensesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.block;
            this.manageDetainedLicensesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(262, 70);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detaineLicenseToolStripMenuItem
            // 
            this.detaineLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.detaineLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.block;
            this.detaineLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.detaineLicenseToolStripMenuItem.Name = "detaineLicenseToolStripMenuItem";
            this.detaineLicenseToolStripMenuItem.Size = new System.Drawing.Size(262, 70);
            this.detaineLicenseToolStripMenuItem.Text = "Detain License";
            this.detaineLicenseToolStripMenuItem.Click += new System.EventHandler(this.detaineLicenseToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.releaseDetainedLicenseToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.car_insurance;
            this.releaseDetainedLicenseToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(262, 70);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained License";
            this.releaseDetainedLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseDetainedLicenseToolStripMenuItem_Click);
            // 
            // manageApplicationsTypesToolStripMenuItem
            // 
            this.manageApplicationsTypesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.manageApplicationsTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.curriculum_vitae__1_;
            this.manageApplicationsTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageApplicationsTypesToolStripMenuItem.Name = "manageApplicationsTypesToolStripMenuItem";
            this.manageApplicationsTypesToolStripMenuItem.Size = new System.Drawing.Size(266, 70);
            this.manageApplicationsTypesToolStripMenuItem.Text = "Manage Applications Types";
            this.manageApplicationsTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypesToolStripMenuItem_Click);
            // 
            // manageTestTypesToolStripMenuItem
            // 
            this.manageTestTypesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.manageTestTypesToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.exam;
            this.manageTestTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.manageTestTypesToolStripMenuItem.Name = "manageTestTypesToolStripMenuItem";
            this.manageTestTypesToolStripMenuItem.Size = new System.Drawing.Size(266, 70);
            this.manageTestTypesToolStripMenuItem.Text = "Manage Test Types";
            this.manageTestTypesToolStripMenuItem.Click += new System.EventHandler(this.manageTestTypesToolStripMenuItem_Click);
            // 
            // cxmAccountSettings
            // 
            this.cxmAccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentUserInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.cxmAccountSettings.Name = "cxmAccountSettings";
            this.cxmAccountSettings.Size = new System.Drawing.Size(286, 214);
            // 
            // currentUserInfoToolStripMenuItem
            // 
            this.currentUserInfoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.currentUserInfoToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.user;
            this.currentUserInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.currentUserInfoToolStripMenuItem.Name = "currentUserInfoToolStripMenuItem";
            this.currentUserInfoToolStripMenuItem.Size = new System.Drawing.Size(285, 70);
            this.currentUserInfoToolStripMenuItem.Text = "Current User Info";
            this.currentUserInfoToolStripMenuItem.Click += new System.EventHandler(this.currentUserInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.changePasswordToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.pin_code;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(285, 70);
            this.changePasswordToolStripMenuItem.Text = "Change Current User Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.signOutToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.log_out;
            this.signOutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(285, 70);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 640);
            this.Controls.Add(this.pnlMainMenu);
            this.Controls.Add(this.cuiResizeGrip1);
            this.Controls.Add(this.cuiResizeGrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(950, 141);
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.LocationChanged += new System.EventHandler(this.frmMainForm_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.frmMainForm_SizeChanged);
            this.Resize += new System.EventHandler(this.frmMainForm_Resize);
            this.pnlMainMenu.ResumeLayout(false);
            this.cuiPanel2.ResumeLayout(false);
            this.cuiPanel1.ResumeLayout(false);
            this.cxmApplicaitons.ResumeLayout(false);
            this.cxmAccountSettings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CuoreUI.Components.cuiMessageDialog MessageDialog;
        private CuoreUI.Components.cuiFormDrag MainFormDrag;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Components.cuiFormAnimator MainFormAnimator;
        private CuoreUI.Components.cuiFormRounder MainFormRounder;
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip;
        private CuoreUI.Controls.cuiResizeGrip cuiResizeGrip1;
        private CuoreUI.Controls.cuiButton btnMaximize;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private System.Windows.Forms.ImageList MaximizedImgBox;
        private CuoreUI.Controls.cuiGradientPanel pnlMainMenu;
        private CuoreUI.Controls.cuiPanel cuiPanel1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiPanel cuiPanel2;
        private CuoreUI.Controls.cuiButton btnDrivers;
        private CuoreUI.Controls.cuiButton btnUsers;
        private CuoreUI.Controls.cuiButton btnAccountSettings;
        private CuoreUI.Controls.cuiButton btnApplications;
        private CuoreUI.Controls.cuiButton btnPeople;
        private System.Windows.Forms.ContextMenuStrip cxmApplicaitons;
        private System.Windows.Forms.ToolStripMenuItem drivingLicenseServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceForLostOrDamageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relaiseDetainedDrivingLIcenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaineLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cxmAccountSettings;
        private System.Windows.Forms.ToolStripMenuItem currentUserInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
    }
}

