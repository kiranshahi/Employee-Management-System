namespace EmployeeManagementSystem
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
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.payroll = new System.Windows.Forms.Button();
            this.addEmployee = new System.Windows.Forms.Button();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.picBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.importEmployees = new System.Windows.Forms.Button();
            this.exportData = new System.Windows.Forms.Button();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.lblMinimize = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.sideBarPanel.Controls.Add(this.btnGenerateReport);
            this.sideBarPanel.Controls.Add(this.payroll);
            this.sideBarPanel.Controls.Add(this.addEmployee);
            this.sideBarPanel.Controls.Add(this.logoPanel);
            this.sideBarPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.sideBarPanel.Name = "sideBarPanel";
            this.sideBarPanel.Size = new System.Drawing.Size(176, 555);
            this.sideBarPanel.TabIndex = 0;
            this.sideBarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.sideBarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.sideBarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.Location = new System.Drawing.Point(2, 151);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(173, 40);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
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
            this.payroll.Location = new System.Drawing.Point(2, 105);
            this.payroll.Name = "payroll";
            this.payroll.Size = new System.Drawing.Size(173, 40);
            this.payroll.TabIndex = 1;
            this.payroll.Text = "Generate Payroll";
            this.payroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.payroll.UseVisualStyleBackColor = true;
            this.payroll.Click += new System.EventHandler(this.payroll_Click);
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
            this.addEmployee.Location = new System.Drawing.Point(2, 59);
            this.addEmployee.Name = "addEmployee";
            this.addEmployee.Size = new System.Drawing.Size(173, 40);
            this.addEmployee.TabIndex = 1;
            this.addEmployee.Text = "Add Employee";
            this.addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addEmployee.UseVisualStyleBackColor = true;
            this.addEmployee.Click += new System.EventHandler(this.addEmployee_Click);
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
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.picBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.picBoxLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.picBoxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.lblLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.importEmployees.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.importEmployees.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.importEmployees.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // exportData
            // 
            this.exportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.exportData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exportData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exportData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.exportData.FlatAppearance.BorderSize = 0;
            this.exportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportData.ForeColor = System.Drawing.Color.White;
            this.exportData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportData.Location = new System.Drawing.Point(480, 453);
            this.exportData.Name = "exportData";
            this.exportData.Size = new System.Drawing.Size(134, 40);
            this.exportData.TabIndex = 1;
            this.exportData.Text = "Export Data";
            this.exportData.UseVisualStyleBackColor = false;
            this.exportData.Click += new System.EventHandler(this.exportData_Click);
            this.exportData.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.exportData.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.exportData.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.lblMinimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblMinimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.lblClose.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.lblClose.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.lblClose.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.panel1.Controls.Add(this.exportData);
            this.panel1.Controls.Add(this.importEmployees);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 502);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.dateOfJoin,
            this.WageRate,
            this.workedHour});
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(1046, 440);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.dataGridView.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.dataGridView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            // dateOfJoin
            // 
            this.dateOfJoin.HeaderText = "Date Of Join";
            this.dateOfJoin.Name = "dateOfJoin";
            // 
            // WageRate
            // 
            this.WageRate.FillWeight = 83.94669F;
            this.WageRate.HeaderText = "Wage Rate";
            this.WageRate.Name = "WageRate";
            // 
            // workedHour
            // 
            this.workedHour.HeaderText = "WorkedHour";
            this.workedHour.Name = "workedHour";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(151)))), ((int)(((byte)(31)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(773, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            this.btnEdit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnEdit.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnEdit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(906, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.btnDelete.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.btnDelete.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
        private System.Windows.Forms.Button payroll;
        private System.Windows.Forms.Button importEmployees;
        private System.Windows.Forms.Button exportData;
        private System.Windows.Forms.Button addEmployee;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Designation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfJoin;
        private System.Windows.Forms.DataGridViewTextBoxColumn WageRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn workedHour;
        private System.Windows.Forms.Button btnGenerateReport;
    }
}

