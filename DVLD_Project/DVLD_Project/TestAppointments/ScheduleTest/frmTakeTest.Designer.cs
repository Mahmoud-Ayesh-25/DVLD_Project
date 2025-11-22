namespace DVLD_Project.TestAppointments.ScheduleTest
{
    partial class frmTakeTest
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
            this.cuiFormAnimator = new CuoreUI.Components.cuiFormAnimator(this.components);
            this.cuiFormDrag = new CuoreUI.Components.cuiFormDrag(this.components);
            this.cuiFormRounder = new CuoreUI.Components.cuiFormRounder();
            this.lblTitle = new CuoreUI.Controls.cuiLabel();
            this.ctrlSheduledTest = new DVLD_Project.TestAppointments.ScheduleTest.ctrlSheduledTest();
            this.tbxNotes = new CuoreUI.Controls.cuiTextBox();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.lblMessage = new CuoreUI.Controls.cuiLabel();
            this.cbtnFail = new CuoreUI.Controls.cuiButtonGroup();
            this.cbtnPass = new CuoreUI.Controls.cuiButtonGroup();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.cuiPictureBox7 = new CuoreUI.Controls.cuiPictureBox();
            this.btnClose = new CuoreUI.Controls.cuiButton();
            this.btnMinimize = new CuoreUI.Controls.cuiButton();
            this.btnSave = new CuoreUI.Controls.cuiButton();
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
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.Content = "Take\\ Test";
            this.lblTitle.Enabled = false;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblTitle.Location = new System.Drawing.Point(12, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(497, 25);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlSheduledTest
            // 
            this.ctrlSheduledTest.BackColor = System.Drawing.Color.White;
            this.ctrlSheduledTest.Location = new System.Drawing.Point(12, 52);
            this.ctrlSheduledTest.Name = "ctrlSheduledTest";
            this.ctrlSheduledTest.Size = new System.Drawing.Size(497, 386);
            this.ctrlSheduledTest.TabIndex = 26;
            this.ctrlSheduledTest.TestID = 0;
            this.ctrlSheduledTest.TestType = DVLD_Project.TestAppointments.frmManageTestAppointments.enTestType.Vision;
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
            this.tbxNotes.Location = new System.Drawing.Point(50, 532);
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
            this.tbxNotes.Size = new System.Drawing.Size(458, 87);
            this.tbxNotes.TabIndex = 49;
            this.tbxNotes.TextOffset = new System.Drawing.Size(0, 0);
            this.tbxNotes.UnderlinedStyle = false;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(12, 444);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(497, 27);
            this.cuiSeparator1.TabIndex = 53;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMessage.Content = "You\\ cannot\\ edit\\ the\\ result\\.";
            this.lblMessage.Enabled = false;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMessage.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblMessage.Location = new System.Drawing.Point(230, 477);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(278, 32);
            this.lblMessage.TabIndex = 54;
            this.lblMessage.VerticalAlignment = System.Drawing.StringAlignment.Center;
            this.lblMessage.Visible = false;
            // 
            // cbtnFail
            // 
            this.cbtnFail.Checked = false;
            this.cbtnFail.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnFail.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnFail.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnFail.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnFail.Content = "Fail";
            this.cbtnFail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnFail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnFail.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnFail.Group = 0;
            this.cbtnFail.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnFail.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnFail.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnFail.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnFail.Image = global::DVLD_Project.Properties.Resources.cross__1_;
            this.cbtnFail.ImageAutoCenter = true;
            this.cbtnFail.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnFail.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnFail.Location = new System.Drawing.Point(143, 477);
            this.cbtnFail.Name = "cbtnFail";
            this.cbtnFail.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnFail.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnFail.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnFail.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnFail.OutlineThickness = 1F;
            this.cbtnFail.PressedBackground = System.Drawing.Color.Silver;
            this.cbtnFail.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnFail.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnFail.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnFail.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnFail.Size = new System.Drawing.Size(82, 32);
            this.cbtnFail.TabIndex = 52;
            this.cbtnFail.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnFail.TextOffset = new System.Drawing.Point(1, 0);
            // 
            // cbtnPass
            // 
            this.cbtnPass.Checked = true;
            this.cbtnPass.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnPass.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnPass.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnPass.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnPass.Content = "Pass";
            this.cbtnPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnPass.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnPass.Group = 0;
            this.cbtnPass.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnPass.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnPass.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnPass.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnPass.Image = global::DVLD_Project.Properties.Resources.check;
            this.cbtnPass.ImageAutoCenter = true;
            this.cbtnPass.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnPass.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnPass.Location = new System.Drawing.Point(50, 477);
            this.cbtnPass.Name = "cbtnPass";
            this.cbtnPass.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnPass.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnPass.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnPass.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnPass.OutlineThickness = 1F;
            this.cbtnPass.PressedBackground = System.Drawing.Color.Silver;
            this.cbtnPass.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnPass.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnPass.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnPass.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnPass.Size = new System.Drawing.Size(82, 32);
            this.cbtnPass.TabIndex = 51;
            this.cbtnPass.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnPass.TextOffset = new System.Drawing.Point(1, 0);
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.Content = global::DVLD_Project.Properties.Resources.notes__1_;
            this.cuiPictureBox1.Enabled = false;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox1.Location = new System.Drawing.Point(12, 532);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox1.TabIndex = 48;
            // 
            // cuiPictureBox7
            // 
            this.cuiPictureBox7.Content = global::DVLD_Project.Properties.Resources.checklist__1_;
            this.cuiPictureBox7.Enabled = false;
            this.cuiPictureBox7.ImageTint = System.Drawing.Color.DimGray;
            this.cuiPictureBox7.Location = new System.Drawing.Point(12, 477);
            this.cuiPictureBox7.Name = "cuiPictureBox7";
            this.cuiPictureBox7.OutlineThickness = 1F;
            this.cuiPictureBox7.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox7.Rotation = 0;
            this.cuiPictureBox7.Rounding = new System.Windows.Forms.Padding(0);
            this.cuiPictureBox7.Size = new System.Drawing.Size(32, 32);
            this.cuiPictureBox7.TabIndex = 48;
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
            this.btnClose.Location = new System.Drawing.Point(484, 12);
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
            this.btnClose.TabIndex = 23;
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
            this.btnMinimize.Location = new System.Drawing.Point(453, 12);
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
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.CheckButton = false;
            this.btnSave.Checked = false;
            this.btnSave.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.CheckedForeColor = System.Drawing.Color.White;
            this.btnSave.CheckedImageTint = System.Drawing.Color.White;
            this.btnSave.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btnSave.Content = "Save";
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
            this.btnSave.Location = new System.Drawing.Point(356, 635);
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
            this.btnSave.TabIndex = 55;
            this.btnSave.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnSave.TextOffset = new System.Drawing.Point(2, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmTakeTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(521, 679);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.cbtnFail);
            this.Controls.Add(this.cbtnPass);
            this.Controls.Add(this.tbxNotes);
            this.Controls.Add(this.cuiPictureBox1);
            this.Controls.Add(this.cuiPictureBox7);
            this.Controls.Add(this.ctrlSheduledTest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTakeTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTakeTest";
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Components.cuiFormAnimator cuiFormAnimator;
        private CuoreUI.Components.cuiFormDrag cuiFormDrag;
        private CuoreUI.Components.cuiFormRounder cuiFormRounder;
        private CuoreUI.Controls.cuiButton btnClose;
        private CuoreUI.Controls.cuiButton btnMinimize;
        private CuoreUI.Controls.cuiLabel lblTitle;
        private ctrlSheduledTest ctrlSheduledTest;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox7;
        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private CuoreUI.Controls.cuiTextBox tbxNotes;
        private CuoreUI.Controls.cuiButtonGroup cbtnFail;
        private CuoreUI.Controls.cuiButtonGroup cbtnPass;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
        private CuoreUI.Controls.cuiLabel lblMessage;
        private CuoreUI.Controls.cuiButton btnSave;
    }
}