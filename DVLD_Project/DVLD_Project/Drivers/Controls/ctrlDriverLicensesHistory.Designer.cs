namespace DVLD_Project.Drivers.Controls
{
    partial class ctrlDriverLicensesHistory
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlLocalLicenses = new CuoreUI.Controls.cuiPanel();
            this.lblLocalEmpty = new CuoreUI.Controls.cuiLabel();
            this.lblLocalRecords = new CuoreUI.Controls.cuiLabel();
            this.dgvLocalLicenses = new System.Windows.Forms.DataGridView();
            this.cxmLocal = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbtnInternatinal = new CuoreUI.Controls.cuiButtonGroup();
            this.cbtnLocal = new CuoreUI.Controls.cuiButtonGroup();
            this.pnlInternational = new CuoreUI.Controls.cuiPanel();
            this.lblInternationalEmpty = new CuoreUI.Controls.cuiLabel();
            this.lblInternationalRecords = new CuoreUI.Controls.cuiLabel();
            this.dgvInternational = new System.Windows.Forms.DataGridView();
            this.cxmInternational = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLocalLicenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).BeginInit();
            this.cxmLocal.SuspendLayout();
            this.pnlInternational.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).BeginInit();
            this.cxmInternational.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLocalLicenses
            // 
            this.pnlLocalLicenses.Controls.Add(this.lblLocalEmpty);
            this.pnlLocalLicenses.Controls.Add(this.lblLocalRecords);
            this.pnlLocalLicenses.Controls.Add(this.dgvLocalLicenses);
            this.pnlLocalLicenses.Location = new System.Drawing.Point(0, 38);
            this.pnlLocalLicenses.Name = "pnlLocalLicenses";
            this.pnlLocalLicenses.OutlineThickness = 1F;
            this.pnlLocalLicenses.PanelColor = System.Drawing.Color.White;
            this.pnlLocalLicenses.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlLocalLicenses.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlLocalLicenses.Size = new System.Drawing.Size(780, 260);
            this.pnlLocalLicenses.TabIndex = 0;
            this.pnlLocalLicenses.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLocalLicenses_Paint);
            // 
            // lblLocalEmpty
            // 
            this.lblLocalEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLocalEmpty.Content = "Empty";
            this.lblLocalEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalEmpty.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblLocalEmpty.Location = new System.Drawing.Point(177, 68);
            this.lblLocalEmpty.Name = "lblLocalEmpty";
            this.lblLocalEmpty.Size = new System.Drawing.Size(426, 101);
            this.lblLocalEmpty.TabIndex = 35;
            this.lblLocalEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblLocalRecords
            // 
            this.lblLocalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLocalRecords.Content = "Records\\ :\\ 0";
            this.lblLocalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalRecords.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblLocalRecords.Location = new System.Drawing.Point(3, 243);
            this.lblLocalRecords.Name = "lblLocalRecords";
            this.lblLocalRecords.Size = new System.Drawing.Size(210, 14);
            this.lblLocalRecords.TabIndex = 36;
            this.lblLocalRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dgvLocalLicenses
            // 
            this.dgvLocalLicenses.AllowUserToAddRows = false;
            this.dgvLocalLicenses.AllowUserToDeleteRows = false;
            this.dgvLocalLicenses.AllowUserToResizeColumns = false;
            this.dgvLocalLicenses.AllowUserToResizeRows = false;
            this.dgvLocalLicenses.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocalLicenses.ColumnHeadersHeight = 25;
            this.dgvLocalLicenses.ContextMenuStrip = this.cxmLocal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocalLicenses.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocalLicenses.EnableHeadersVisualStyles = false;
            this.dgvLocalLicenses.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvLocalLicenses.Location = new System.Drawing.Point(3, 3);
            this.dgvLocalLicenses.MultiSelect = false;
            this.dgvLocalLicenses.Name = "dgvLocalLicenses";
            this.dgvLocalLicenses.ReadOnly = true;
            this.dgvLocalLicenses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocalLicenses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLocalLicenses.RowHeadersVisible = false;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLocalLicenses.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLocalLicenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocalLicenses.Size = new System.Drawing.Size(774, 234);
            this.dgvLocalLicenses.TabIndex = 35;
            this.dgvLocalLicenses.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvLocalLicenses_DataBindingComplete);
            // 
            // cxmLocal
            // 
            this.cxmLocal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDetailsToolStripMenuItem});
            this.cxmLocal.Name = "cxmPeople";
            this.cxmLocal.Size = new System.Drawing.Size(170, 26);
            // 
            // showDetailsToolStripMenuItem
            // 
            this.showDetailsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            this.showDetailsToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showDetailsToolStripMenuItem.Name = "showDetailsToolStripMenuItem";
            this.showDetailsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.showDetailsToolStripMenuItem.Text = "Show License Info";
            this.showDetailsToolStripMenuItem.Click += new System.EventHandler(this.showDetailsToolStripMenuItem_Click);
            // 
            // cbtnInternatinal
            // 
            this.cbtnInternatinal.Checked = false;
            this.cbtnInternatinal.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnInternatinal.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnInternatinal.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.Content = "International Licenses";
            this.cbtnInternatinal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnInternatinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnInternatinal.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.Group = 0;
            this.cbtnInternatinal.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnInternatinal.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.Image = null;
            this.cbtnInternatinal.ImageAutoCenter = true;
            this.cbtnInternatinal.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnInternatinal.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnInternatinal.Location = new System.Drawing.Point(174, 3);
            this.cbtnInternatinal.Name = "cbtnInternatinal";
            this.cbtnInternatinal.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnInternatinal.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnInternatinal.OutlineThickness = 1F;
            this.cbtnInternatinal.PressedBackground = System.Drawing.Color.LightGray;
            this.cbtnInternatinal.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnInternatinal.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnInternatinal.Size = new System.Drawing.Size(165, 32);
            this.cbtnInternatinal.TabIndex = 108;
            this.cbtnInternatinal.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnInternatinal.TextOffset = new System.Drawing.Point(1, 0);
            this.cbtnInternatinal.Click += new System.EventHandler(this.cbtnInternational_Click);
            // 
            // cbtnLocal
            // 
            this.cbtnLocal.Checked = true;
            this.cbtnLocal.CheckedBackground = System.Drawing.Color.DimGray;
            this.cbtnLocal.CheckedForeColor = System.Drawing.Color.White;
            this.cbtnLocal.CheckedImageTint = System.Drawing.Color.White;
            this.cbtnLocal.CheckedOutline = System.Drawing.Color.DimGray;
            this.cbtnLocal.Content = "Local Licenses";
            this.cbtnLocal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbtnLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cbtnLocal.ForeColor = System.Drawing.Color.DimGray;
            this.cbtnLocal.Group = 0;
            this.cbtnLocal.HoverBackground = System.Drawing.Color.Gainsboro;
            this.cbtnLocal.HoverForeColor = System.Drawing.Color.DimGray;
            this.cbtnLocal.HoverImageTint = System.Drawing.Color.DimGray;
            this.cbtnLocal.HoverOutline = System.Drawing.Color.DimGray;
            this.cbtnLocal.Image = null;
            this.cbtnLocal.ImageAutoCenter = true;
            this.cbtnLocal.ImageExpand = new System.Drawing.Point(0, 0);
            this.cbtnLocal.ImageOffset = new System.Drawing.Point(-1, 0);
            this.cbtnLocal.Location = new System.Drawing.Point(3, 3);
            this.cbtnLocal.Name = "cbtnLocal";
            this.cbtnLocal.NormalBackground = System.Drawing.Color.Gainsboro;
            this.cbtnLocal.NormalForeColor = System.Drawing.Color.DimGray;
            this.cbtnLocal.NormalImageTint = System.Drawing.Color.DimGray;
            this.cbtnLocal.NormalOutline = System.Drawing.Color.Gainsboro;
            this.cbtnLocal.OutlineThickness = 1F;
            this.cbtnLocal.PressedBackground = System.Drawing.Color.LightGray;
            this.cbtnLocal.PressedForeColor = System.Drawing.Color.DimGray;
            this.cbtnLocal.PressedImageTint = System.Drawing.Color.DimGray;
            this.cbtnLocal.PressedOutline = System.Drawing.Color.DimGray;
            this.cbtnLocal.Rounding = new System.Windows.Forms.Padding(15);
            this.cbtnLocal.Size = new System.Drawing.Size(165, 32);
            this.cbtnLocal.TabIndex = 109;
            this.cbtnLocal.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cbtnLocal.TextOffset = new System.Drawing.Point(1, 0);
            this.cbtnLocal.Click += new System.EventHandler(this.cbtnLocal_Click);
            // 
            // pnlInternational
            // 
            this.pnlInternational.Controls.Add(this.lblInternationalEmpty);
            this.pnlInternational.Controls.Add(this.lblInternationalRecords);
            this.pnlInternational.Controls.Add(this.dgvInternational);
            this.pnlInternational.Location = new System.Drawing.Point(0, 38);
            this.pnlInternational.Name = "pnlInternational";
            this.pnlInternational.OutlineThickness = 1F;
            this.pnlInternational.PanelColor = System.Drawing.Color.White;
            this.pnlInternational.PanelOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlInternational.Rounding = new System.Windows.Forms.Padding(8);
            this.pnlInternational.Size = new System.Drawing.Size(780, 260);
            this.pnlInternational.TabIndex = 37;
            // 
            // lblInternationalEmpty
            // 
            this.lblInternationalEmpty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblInternationalEmpty.Content = "Empty";
            this.lblInternationalEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalEmpty.HorizontalAlignment = System.Drawing.StringAlignment.Center;
            this.lblInternationalEmpty.Location = new System.Drawing.Point(177, 68);
            this.lblInternationalEmpty.Name = "lblInternationalEmpty";
            this.lblInternationalEmpty.Size = new System.Drawing.Size(426, 101);
            this.lblInternationalEmpty.TabIndex = 37;
            this.lblInternationalEmpty.VerticalAlignment = System.Drawing.StringAlignment.Center;
            // 
            // lblInternationalRecords
            // 
            this.lblInternationalRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblInternationalRecords.Content = "Records\\ :\\ 0";
            this.lblInternationalRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInternationalRecords.HorizontalAlignment = System.Drawing.StringAlignment.Near;
            this.lblInternationalRecords.Location = new System.Drawing.Point(3, 243);
            this.lblInternationalRecords.Name = "lblInternationalRecords";
            this.lblInternationalRecords.Size = new System.Drawing.Size(210, 14);
            this.lblInternationalRecords.TabIndex = 39;
            this.lblInternationalRecords.VerticalAlignment = System.Drawing.StringAlignment.Near;
            // 
            // dgvInternational
            // 
            this.dgvInternational.AllowUserToAddRows = false;
            this.dgvInternational.AllowUserToDeleteRows = false;
            this.dgvInternational.AllowUserToResizeColumns = false;
            this.dgvInternational.AllowUserToResizeRows = false;
            this.dgvInternational.BackgroundColor = System.Drawing.Color.White;
            this.dgvInternational.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternational.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvInternational.ColumnHeadersHeight = 25;
            this.dgvInternational.ContextMenuStrip = this.cxmInternational;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInternational.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvInternational.EnableHeadersVisualStyles = false;
            this.dgvInternational.GridColor = System.Drawing.Color.Gainsboro;
            this.dgvInternational.Location = new System.Drawing.Point(3, 3);
            this.dgvInternational.MultiSelect = false;
            this.dgvInternational.Name = "dgvInternational";
            this.dgvInternational.ReadOnly = true;
            this.dgvInternational.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInternational.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvInternational.RowHeadersVisible = false;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInternational.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvInternational.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInternational.Size = new System.Drawing.Size(774, 234);
            this.dgvInternational.TabIndex = 38;
            this.dgvInternational.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvInternational_DataBindingComplete);
            // 
            // cxmInternational
            // 
            this.cxmInternational.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseInfoToolStripMenuItem});
            this.cxmInternational.Name = "cxmPeople";
            this.cxmInternational.Size = new System.Drawing.Size(181, 48);
            // 
            // showLicenseInfoToolStripMenuItem
            // 
            this.showLicenseInfoToolStripMenuItem.Image = global::DVLD_Project.Properties.Resources.show;
            this.showLicenseInfoToolStripMenuItem.Name = "showLicenseInfoToolStripMenuItem";
            this.showLicenseInfoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showLicenseInfoToolStripMenuItem.Text = "Show License Info";
            this.showLicenseInfoToolStripMenuItem.Click += new System.EventHandler(this.showLicenseInfoToolStripMenuItem_Click);
            // 
            // ctrlDriverLicensesHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbtnInternatinal);
            this.Controls.Add(this.cbtnLocal);
            this.Controls.Add(this.pnlLocalLicenses);
            this.Controls.Add(this.pnlInternational);
            this.Name = "ctrlDriverLicensesHistory";
            this.Size = new System.Drawing.Size(780, 298);
            this.pnlLocalLicenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalLicenses)).EndInit();
            this.cxmLocal.ResumeLayout(false);
            this.pnlInternational.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInternational)).EndInit();
            this.cxmInternational.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CuoreUI.Controls.cuiPanel pnlLocalLicenses;
        private System.Windows.Forms.DataGridView dgvLocalLicenses;
        private CuoreUI.Controls.cuiLabel lblLocalRecords;
        private CuoreUI.Controls.cuiLabel lblLocalEmpty;
        private CuoreUI.Controls.cuiButtonGroup cbtnInternatinal;
        private CuoreUI.Controls.cuiButtonGroup cbtnLocal;
        private CuoreUI.Controls.cuiPanel pnlInternational;
        private CuoreUI.Controls.cuiLabel lblInternationalEmpty;
        private CuoreUI.Controls.cuiLabel lblInternationalRecords;
        private System.Windows.Forms.DataGridView dgvInternational;
        private System.Windows.Forms.ContextMenuStrip cxmLocal;
        private System.Windows.Forms.ToolStripMenuItem showDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cxmInternational;
        private System.Windows.Forms.ToolStripMenuItem showLicenseInfoToolStripMenuItem;
    }
}
