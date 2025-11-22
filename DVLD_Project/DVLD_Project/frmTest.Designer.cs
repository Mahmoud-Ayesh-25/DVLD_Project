namespace DVLD_Project
{
    partial class frmTest
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
            this.ctrlScheduleTest1 = new DVLD_Project.TestAppointments.ScheduleTest.ctrlScheduleTest();
            this.SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            this.ctrlScheduleTest1.BackColor = System.Drawing.Color.White;
            this.ctrlScheduleTest1.Location = new System.Drawing.Point(136, 70);
            this.ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            this.ctrlScheduleTest1.Size = new System.Drawing.Size(497, 523);
            this.ctrlScheduleTest1.TabIndex = 0;
            this.ctrlScheduleTest1.TestType = DVLD_Project.TestAppointments.frmManageTestAppointments.enTestType.Vision;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 773);
            this.Controls.Add(this.ctrlScheduleTest1);
            this.Name = "frmTest";
            this.Text = "frmTest";
            this.ResumeLayout(false);

        }

        #endregion

        private TestAppointments.ScheduleTest.ctrlScheduleTest ctrlScheduleTest1;
    }
}