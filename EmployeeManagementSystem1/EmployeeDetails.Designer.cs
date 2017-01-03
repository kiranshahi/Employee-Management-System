namespace EmployeeManagementSystem1
{
    partial class EmployeeSysMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSysMainForm));
            this.sideBarPanel = new System.Windows.Forms.Panel();
            this.payroll = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.employeeDetails = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.importEmployees = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sideBarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sideBarPanel
            // 
            this.sideBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sideBarPanel.Controls.Add(this.payroll);
            this.sideBarPanel.Controls.Add(this.addEmployee);
            this.sideBarPanel.Controls.Add(this.employeeDetails);
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(176, 555);
            this.sideBarPanel.TabIndex = 0;
            this.sideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.sideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.sideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // payroll
            // 
            this.payroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.payroll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.payroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.payroll.FlatAppearance.BorderSize = 0;
            this.payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.payroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payroll.ForeColor = System.Drawing.Color.White;
            this.payroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payroll.Location = new System.Drawing.Point(2, 164);
            this.payroll.Name = "payroll";
            this.payroll.Size = new System.Drawing.Size(173, 40);
            this.payroll.TabIndex = 1;
            this.payroll.Text = "Generate Payroll";
            this.payroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payroll.UseVisualStyleBackColor = true;
            // 
            // addEmployee
            // 
            this.addEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.addEmployee.FlatAppearance.BorderSize = 0;
            this.addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmployee.ForeColor = System.Drawing.Color.White;
            this.addEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee.Location = new System.Drawing.Point(2, 118);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(173, 40);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
            // 
            // employeeDetails
            // 
            this.employeeDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.employeeDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employeeDetails.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.employeeDetails.FlatAppearance.BorderSize = 0;
            this.employeeDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employeeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeDetails.ForeColor = System.Drawing.Color.White;
            this.employeeDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeDetails.Location = new System.Drawing.Point(3, 75);
            this.employeeDetails.Name = "employeeDetails";
            this.employeeDetails.Size = new System.Drawing.Size(173, 40);
            this.employeeDetails.TabIndex = 1;
            this.employeeDetails.Text = "Employee Details";
            this.employeeDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.employeeDetails.UseVisualStyleBackColor = true;
            this.employeeDetails.Click += new System.EventHandler(this.employeeDetails_Click);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            this.logoPanel.Controls.Add(this.picBoxLogo);
            this.logoPanel.Controls.Add(this.lblLogo);
            this.logoPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(176, 53);
            this.logoPanel.TabIndex = 0;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // picBoxLogo
            // 
            this.picBoxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxLogo.Image")));
            this.picBoxLogo.Location = new System.Drawing.Point(3, 1);
            this.picBoxLogo.Name = "picBoxLogo";
            this.picBoxLogo.Size = new System.Drawing.Size(60, 50);
            this.picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxLogo.TabIndex = 1;
            this.picBoxLogo.TabStop = false;
            this.picBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.picBoxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.picBoxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(67, 8);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(80, 33);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "EMS";
            this.lblLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.lblLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.lblLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // importEmployees
            // 
            this.importEmployees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.importEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.importEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.importEmployees.FlatAppearance.BorderSize = 0;
            this.importEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.importEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importEmployees.ForeColor = System.Drawing.Color.White;
            this.importEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.importEmployees.Location = new System.Drawing.Point(627, 453);
            this.importEmployees.Name = "importEmployees";
            this.importEmployees.Size = new System.Drawing.Size(134, 40);
            this.importEmployees.TabIndex = 1;
            this.importEmployees.Text = "Import Data";
            this.importEmployees.UseVisualStyleBackColor = false;
            this.importEmployees.Click += new System.EventHandler(this.importEmployees_Click);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.header);
            this.headerPanel.Controls.Add(this.lblMinimize);
            this.headerPanel.Controls.Add(this.lblClose);
            this.headerPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(176, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1046, 53);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.header.Location = new System.Drawing.Point(229, 8);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(428, 33);
            this.header.TabIndex = 2;
            this.header.Text = "Employee Management System";
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinimize.Location = new System.Drawing.Point(995, 3);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(19, 25);
            this.lblMinimize.TabIndex = 1;
            this.lblMinimize.Text = "-";
            this.lblMinimize.Click += new System.EventHandler(this.lblMinimize_Click);
            this.lblMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.lblMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1018, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 25);
            this.lblClose.TabIndex = 0;
            this.lblClose.Text = "x";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.lblClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.panel1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(176, 53);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1046, 502);
            this.containerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.importEmployees);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 502);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Address,
            this.Contact,
            this.Email,
            this.Designation,
            this.Department,
            this.WageRate});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1046, 440);
            this.dataGridView.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(773, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 40);
            this.button2.TabIndex = 6;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(906, 453);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 40);
            this.button1.TabIndex = 5;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Id
            // 
            this.Id.FillWeight = 30F;
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // FullName
            // 
            this.FullName.FillWeight = 83.94669F;
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            // 
            // Address
            // 
            this.Address.FillWeight = 83.94669F;
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Contact
            // 
            this.Contact.FillWeight = 83.94669F;
            this.Contact.HeaderText = "Contact";
            this.Contact.Name = "Contact";
            // 
            // Email
            // 
            this.Email.FillWeight = 83.94669F;
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Designation
            // 
            this.Designation.FillWeight = 83.94669F;
            this.Designation.HeaderText = "Designation";
            this.Designation.Name = "Designation";
            // 
            // Department
            // 
            this.Department.FillWeight = 83.94669F;
            this.Department.HeaderText = "Department";
            this.Department.Name = "Department";
            // 
            // WageRate
            // 
            this.WageRate.FillWeight = 83.94669F;
            this.WageRate.HeaderText = "Wage Rate";
            this.WageRate.Name = "WageRate";
            // 
            // EmployeeSysMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1222, 555);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sideBarPanel);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeSysMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management System";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeSysMainForm_MouseUp);
            this.sideBarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxLogo)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.containerPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideBarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblMinimize;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.PictureBox picBoxLogo;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button employeeDetails;
        private System.Windows.Forms.Button payroll;
        private System.Windows.Forms.Button importEmployees;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn WageRate;
    }
}

