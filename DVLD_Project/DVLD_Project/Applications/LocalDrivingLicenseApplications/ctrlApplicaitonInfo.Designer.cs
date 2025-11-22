namespace DVLD_Project.Applications.LocalDrivingLicenseApplications
{
    partial class ctrlApplicaitonInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            this.ctrlLDLApplicationInfo = new DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls.ctrlLDLApplicationInfo();
            this.cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            this.ctrlBaseApplicationInfo = new DVLD_Project.Applications.LocalDrivingLicenseApplications.Controls.ctrlBaseApplicationInfo();
            this.cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
            this.SuspendLayout();
            // 
            // cuiLabel2
            // 
            this.cuiLabel2.Content = "Local\\ Driving\\ License\\ Application\\ Info\\ :\\ ";
            this.cuiLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel2.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel2.Location = new System.Drawing.Point(0, 0);
            this.cuiLabel2.Name = "cuiLabel2";
            this.cuiLabel2.Size = new System.Drawing.Size(259, 20);
            this.cuiLabel2.TabIndex = 17;
            this.cuiLabel2.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlLDLApplicationInfo
            // 
            this.ctrlLDLApplicationInfo.BackColor = System.Drawing.Color.White;
            this.ctrlLDLApplicationInfo.Location = new System.Drawing.Point(0, 26);
            this.ctrlLDLApplicationInfo.Name = "ctrlLDLApplicationInfo";
            this.ctrlLDLApplicationInfo.Size = new System.Drawing.Size(838, 80);
            this.ctrlLDLApplicationInfo.TabIndex = 18;
            // 
            // cuiLabel1
            // 
            this.cuiLabel1.Content = "Basic\\ Application\\ Info\\ :\\ ";
            this.cuiLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuiLabel1.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.cuiLabel1.Location = new System.Drawing.Point(0, 126);
            this.cuiLabel1.Name = "cuiLabel1";
            this.cuiLabel1.Size = new System.Drawing.Size(210, 20);
            this.cuiLabel1.TabIndex = 19;
            this.cuiLabel1.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // ctrlBaseApplicationInfo
            // 
            this.ctrlBaseApplicationInfo.BackColor = System.Drawing.Color.White;
            this.ctrlBaseApplicationInfo.Location = new System.Drawing.Point(0, 152);
            this.ctrlBaseApplicationInfo.Name = "ctrlBaseApplicationInfo";
            this.ctrlBaseApplicationInfo.Size = new System.Drawing.Size(838, 222);
            this.ctrlBaseApplicationInfo.TabIndex = 20;
            // 
            // cuiSeparator1
            // 
            this.cuiSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiSeparator1.Location = new System.Drawing.Point(136, 122);
            this.cuiSeparator1.Name = "cuiSeparator1";
            this.cuiSeparator1.SeparatorMargin = 8;
            this.cuiSeparator1.Size = new System.Drawing.Size(702, 27);
            this.cuiSeparator1.TabIndex = 42;
            this.cuiSeparator1.Thickness = 0.5F;
            this.cuiSeparator1.Vertical = false;
            // 
            // ctrlApplicaitonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cuiSeparator1);
            this.Controls.Add(this.ctrlBaseApplicationInfo);
            this.Controls.Add(this.cuiLabel1);
            this.Controls.Add(this.ctrlLDLApplicationInfo);
            this.Controls.Add(this.cuiLabel2);
            this.Name = "ctrlApplicaitonInfo";
            this.Size = new System.Drawing.Size(838, 374);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private Controls.ctrlLDLApplicationInfo ctrlLDLApplicationInfo;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private Controls.ctrlBaseApplicationInfo ctrlBaseApplicationInfo;
        private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    }
}
