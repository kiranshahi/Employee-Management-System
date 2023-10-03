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
            sideBarPanel = new System.Windows.Forms.Panel();
            btnGenerateReport = new System.Windows.Forms.Button();
            payroll = new System.Windows.Forms.Button();
            addEmployee = new System.Windows.Forms.Button();
            logoPanel = new System.Windows.Forms.Panel();
            picBoxLogo = new System.Windows.Forms.PictureBox();
            lblLogo = new System.Windows.Forms.Label();
            importEmployees = new System.Windows.Forms.Button();
            exportData = new System.Windows.Forms.Button();
            headerPanel = new System.Windows.Forms.Panel();
            header = new System.Windows.Forms.Label();
            lblMinimize = new System.Windows.Forms.Label();
            lblClose = new System.Windows.Forms.Label();
            containerPanel = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            dataGridView = new System.Windows.Forms.DataGridView();
            Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Designation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            dateOfJoin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            WageRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            workedHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnEdit = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            sideBarPanel.SuspendLayout();
            logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).BeginInit();
            headerPanel.SuspendLayout();
            containerPanel.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // sideBarPanel
            // 
            sideBarPanel.BackColor = System.Drawing.Color.FromArgb(41, 53, 65);
            sideBarPanel.Controls.Add(btnGenerateReport);
            sideBarPanel.Controls.Add(payroll);
            sideBarPanel.Controls.Add(addEmployee);
            sideBarPanel.Controls.Add(logoPanel);
            sideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            sideBarPanel.Location = new System.Drawing.Point(0, 0);
            sideBarPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sideBarPanel.Name = "sideBarPanel";
            sideBarPanel.Size = new System.Drawing.Size(205, 640);
            sideBarPanel.TabIndex = 0;
            sideBarPanel.MouseDown += OnMouseDown;
            sideBarPanel.MouseMove += OnMouseMove;
            sideBarPanel.MouseUp += OnMouseUp;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            btnGenerateReport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnGenerateReport.ForeColor = System.Drawing.Color.White;
            btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGenerateReport.Location = new System.Drawing.Point(2, 174);
            btnGenerateReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new System.Drawing.Size(202, 46);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += BtnGenerateReport_Click;
            // 
            // payroll
            // 
            payroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            payroll.Cursor = System.Windows.Forms.Cursors.Hand;
            payroll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            payroll.FlatAppearance.BorderSize = 0;
            payroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            payroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            payroll.ForeColor = System.Drawing.Color.White;
            payroll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            payroll.Location = new System.Drawing.Point(2, 121);
            payroll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            payroll.Name = "payroll";
            payroll.Size = new System.Drawing.Size(202, 46);
            payroll.TabIndex = 1;
            payroll.Text = "Generate Payroll";
            payroll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            payroll.UseVisualStyleBackColor = true;
            payroll.Click += Payroll_Click;
            // 
            // addEmployee
            // 
            addEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            addEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            addEmployee.FlatAppearance.BorderSize = 0;
            addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            addEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            addEmployee.ForeColor = System.Drawing.Color.White;
            addEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addEmployee.Location = new System.Drawing.Point(2, 68);
            addEmployee.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new System.Drawing.Size(202, 46);
            addEmployee.TabIndex = 1;
            addEmployee.Text = "Add Employee";
            addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += AddEmployee_Click;
            // 
            // logoPanel
            // 
            logoPanel.BackColor = System.Drawing.Color.FromArgb(222, 120, 53);
            logoPanel.Controls.Add(picBoxLogo);
            logoPanel.Controls.Add(lblLogo);
            logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            logoPanel.Location = new System.Drawing.Point(0, 0);
            logoPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            logoPanel.Name = "logoPanel";
            logoPanel.Size = new System.Drawing.Size(205, 61);
            logoPanel.TabIndex = 0;
            logoPanel.MouseDown += OnMouseDown;
            logoPanel.MouseMove += OnMouseMove;
            logoPanel.MouseUp += OnMouseUp;
            // 
            // picBoxLogo
            // 
            picBoxLogo.Image = (System.Drawing.Image)resources.GetObject("picBoxLogo.Image");
            picBoxLogo.Location = new System.Drawing.Point(4, 1);
            picBoxLogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            picBoxLogo.Name = "picBoxLogo";
            picBoxLogo.Size = new System.Drawing.Size(70, 58);
            picBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picBoxLogo.TabIndex = 1;
            picBoxLogo.TabStop = false;
            picBoxLogo.MouseDown += OnMouseDown;
            picBoxLogo.MouseMove += OnMouseMove;
            picBoxLogo.MouseUp += OnMouseUp;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lblLogo.ForeColor = System.Drawing.Color.White;
            lblLogo.Location = new System.Drawing.Point(78, 9);
            lblLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new System.Drawing.Size(80, 33);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "EMS";
            lblLogo.MouseDown += OnMouseDown;
            lblLogo.MouseMove += OnMouseMove;
            lblLogo.MouseUp += OnMouseUp;
            // 
            // importEmployees
            // 
            importEmployees.BackColor = System.Drawing.Color.FromArgb(236, 151, 31);
            importEmployees.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            importEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            importEmployees.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            importEmployees.FlatAppearance.BorderSize = 0;
            importEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            importEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            importEmployees.ForeColor = System.Drawing.Color.White;
            importEmployees.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            importEmployees.Location = new System.Drawing.Point(732, 523);
            importEmployees.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            importEmployees.Name = "importEmployees";
            importEmployees.Size = new System.Drawing.Size(156, 46);
            importEmployees.TabIndex = 1;
            importEmployees.Text = "Import Data";
            importEmployees.UseVisualStyleBackColor = false;
            importEmployees.Click += ImportEmployees_Click;
            importEmployees.MouseDown += OnMouseDown;
            importEmployees.MouseMove += OnMouseMove;
            importEmployees.MouseUp += OnMouseUp;
            // 
            // exportData
            // 
            exportData.BackColor = System.Drawing.Color.FromArgb(31, 151, 31);
            exportData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            exportData.Cursor = System.Windows.Forms.Cursors.Hand;
            exportData.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            exportData.FlatAppearance.BorderSize = 0;
            exportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exportData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            exportData.ForeColor = System.Drawing.Color.White;
            exportData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            exportData.Location = new System.Drawing.Point(560, 523);
            exportData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            exportData.Name = "exportData";
            exportData.Size = new System.Drawing.Size(156, 46);
            exportData.TabIndex = 1;
            exportData.Text = "Export Data";
            exportData.UseVisualStyleBackColor = false;
            exportData.Click += ExportData_Click;
            exportData.MouseDown += OnMouseDown;
            exportData.MouseMove += OnMouseMove;
            exportData.MouseUp += OnMouseUp;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = System.Drawing.Color.White;
            headerPanel.Controls.Add(header);
            headerPanel.Controls.Add(lblMinimize);
            headerPanel.Controls.Add(lblClose);
            headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            headerPanel.Location = new System.Drawing.Point(205, 0);
            headerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new System.Drawing.Size(1221, 61);
            headerPanel.TabIndex = 1;
            headerPanel.MouseDown += OnMouseDown;
            headerPanel.MouseMove += OnMouseMove;
            headerPanel.MouseUp += OnMouseUp;
            // 
            // header
            // 
            header.AutoSize = true;
            header.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            header.ForeColor = System.Drawing.Color.FromArgb(31, 43, 55);
            header.Location = new System.Drawing.Point(267, 9);
            header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            header.Name = "header";
            header.Size = new System.Drawing.Size(428, 33);
            header.TabIndex = 2;
            header.Text = "Employee Management System";
            header.MouseDown += OnMouseDown;
            header.MouseMove += OnMouseMove;
            header.MouseUp += OnMouseUp;
            // 
            // lblMinimize
            // 
            lblMinimize.AutoSize = true;
            lblMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            lblMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblMinimize.Location = new System.Drawing.Point(1161, 3);
            lblMinimize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMinimize.Name = "lblMinimize";
            lblMinimize.Size = new System.Drawing.Size(19, 25);
            lblMinimize.TabIndex = 1;
            lblMinimize.Text = "-";
            lblMinimize.Click += LblMinimize_Click;
            lblMinimize.MouseDown += OnMouseDown;
            lblMinimize.MouseMove += OnMouseMove;
            lblMinimize.MouseUp += OnMouseUp;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClose.Location = new System.Drawing.Point(1188, 3);
            lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new System.Drawing.Size(23, 25);
            lblClose.TabIndex = 0;
            lblClose.Text = "x";
            lblClose.Click += LblClose_Click;
            lblClose.MouseDown += OnMouseDown;
            lblClose.MouseMove += OnMouseMove;
            lblClose.MouseUp += OnMouseUp;
            // 
            // containerPanel
            // 
            containerPanel.Controls.Add(panel1);
            containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            containerPanel.Location = new System.Drawing.Point(205, 61);
            containerPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            containerPanel.Name = "containerPanel";
            containerPanel.Size = new System.Drawing.Size(1221, 579);
            containerPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(exportData);
            panel1.Controls.Add(importEmployees);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnDelete);
            panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1221, 579);
            panel1.TabIndex = 0;
            panel1.MouseDown += OnMouseDown;
            panel1.MouseMove += OnMouseMove;
            panel1.MouseUp += OnMouseUp;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Id, FullName, Address, Contact, Email, Designation, Department, dateOfJoin, WageRate, workedHour });
            dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            dataGridView.ImeMode = System.Windows.Forms.ImeMode.Off;
            dataGridView.Location = new System.Drawing.Point(0, 0);
            dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridView.Name = "dataGridView";
            dataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridView.RowHeadersVisible = false;
            dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new System.Drawing.Size(1220, 508);
            dataGridView.TabIndex = 4;
            dataGridView.MouseDown += OnMouseDown;
            dataGridView.MouseMove += OnMouseMove;
            dataGridView.MouseUp += OnMouseUp;
            // 
            // Id
            // 
            Id.FillWeight = 30F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            // 
            // FullName
            // 
            FullName.FillWeight = 83.94669F;
            FullName.HeaderText = "Name";
            FullName.Name = "FullName";
            // 
            // Address
            // 
            Address.FillWeight = 83.94669F;
            Address.HeaderText = "Address";
            Address.Name = "Address";
            // 
            // Contact
            // 
            Contact.FillWeight = 83.94669F;
            Contact.HeaderText = "Contact";
            Contact.Name = "Contact";
            // 
            // Email
            // 
            Email.FillWeight = 83.94669F;
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Designation
            // 
            Designation.FillWeight = 83.94669F;
            Designation.HeaderText = "Designation";
            Designation.Name = "Designation";
            // 
            // Department
            // 
            Department.FillWeight = 83.94669F;
            Department.HeaderText = "Department";
            Department.Name = "Department";
            // 
            // dateOfJoin
            // 
            dateOfJoin.HeaderText = "Date Of Join";
            dateOfJoin.Name = "dateOfJoin";
            // 
            // WageRate
            // 
            WageRate.FillWeight = 83.94669F;
            WageRate.HeaderText = "Wage Rate";
            WageRate.Name = "WageRate";
            // 
            // workedHour
            // 
            workedHour.HeaderText = "WorkedHour";
            workedHour.Name = "workedHour";
            // 
            // btnEdit
            // 
            btnEdit.BackColor = System.Drawing.Color.FromArgb(236, 151, 31);
            btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnEdit.ForeColor = System.Drawing.Color.White;
            btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEdit.Location = new System.Drawing.Point(902, 523);
            btnEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new System.Drawing.Size(140, 46);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += BtnEdit_Click;
            btnEdit.MouseDown += OnMouseDown;
            btnEdit.MouseMove += OnMouseMove;
            btnEdit.MouseUp += OnMouseUp;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.FromArgb(201, 48, 44);
            btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDelete.Location = new System.Drawing.Point(1057, 523);
            btnDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(140, 46);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += BtnDelete_Click;
            btnDelete.MouseDown += OnMouseDown;
            btnDelete.MouseMove += OnMouseMove;
            btnDelete.MouseUp += OnMouseUp;
            // 
            // EmployeeSysMainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Silver;
            ClientSize = new System.Drawing.Size(1426, 640);
            Controls.Add(containerPanel);
            Controls.Add(headerPanel);
            Controls.Add(sideBarPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "EmployeeSysMainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Employee Management System";
            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
            MouseUp += OnMouseUp;
            sideBarPanel.ResumeLayout(false);
            logoPanel.ResumeLayout(false);
            logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxLogo).EndInit();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            containerPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
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

