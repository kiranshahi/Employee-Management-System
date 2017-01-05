namespace EmployeeManagementSystem1
{
    partial class GeneratePayRoll
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
            this.payrollPanel = new System.Windows.Forms.Panel();
            this.payrollDataGridView = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.payrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // payrollPanel
            // 
            this.payrollPanel.Controls.Add(this.payrollDataGridView);
            this.payrollPanel.Location = new System.Drawing.Point(0, 59);
            this.payrollPanel.Name = "payrollPanel";
            this.payrollPanel.Size = new System.Drawing.Size(1046, 444);
            this.payrollPanel.TabIndex = 0;
            // 
            // payrollDataGridView
            // 
            this.payrollDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.payrollDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payrollDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Name,
            this.Department,
            this.WageRate,
            this.WorkedHour,
            this.TotalWage});
            this.payrollDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.payrollDataGridView.Location = new System.Drawing.Point(0, 0);
            this.payrollDataGridView.Name = "payrollDataGridView";
            this.payrollDataGridView.RowHeadersVisible = false;
            this.payrollDataGridView.Size = new System.Drawing.Size(1046, 444);
            this.payrollDataGridView.TabIndex = 0;
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Department
            // 
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // WageRate
            // 
            this.WageRate.HeaderText = "Wage Rate";
            this.WageRate.Name = "WageRate";
            // 
            // WorkedHour
            // 
            this.WorkedHour.HeaderText = "Worked Hour";
            this.WorkedHour.Name = "WorkedHour";
            // 
            // TotalWage
            // 
            this.TotalWage.HeaderText = "TotalWage";
            this.TotalWage.Name = "TotalWage";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblClose);
            this.panel1.Controls.Add(this.header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 53);
            this.panel1.TabIndex = 1;
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1019, 1);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 1;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.header.Location = new System.Drawing.Point(309, 14);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(341, 33);
            this.header.TabIndex = 3;
            this.header.Text = "Employee Payroll Details";
            this.header.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GeneratePayRoll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 502);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.payrollPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "GeneratePayRoll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratePayRoll";
            this.payrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.payrollDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel payrollPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.DataGridView payrollDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn WageRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkedHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWage;
    }
}