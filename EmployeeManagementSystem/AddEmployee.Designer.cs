namespace EmployeeManagementSystem
{
    partial class AddEmployee
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
            comboBoxDepartment = new System.Windows.Forms.ComboBox();
            dateTimePicker = new System.Windows.Forms.DateTimePicker();
            txtDesignation = new System.Windows.Forms.TextBox();
            txtAddress = new System.Windows.Forms.TextBox();
            txtWorkedHour = new System.Windows.Forms.TextBox();
            txtWage = new System.Windows.Forms.TextBox();
            txtEmail = new System.Windows.Forms.TextBox();
            txtContact = new System.Windows.Forms.TextBox();
            txtFullName = new System.Windows.Forms.TextBox();
            txtIdNo = new System.Windows.Forms.TextBox();
            lblWorkedHour = new System.Windows.Forms.Label();
            lblWage = new System.Windows.Forms.Label();
            lblEmail = new System.Windows.Forms.Label();
            lblFullName = new System.Windows.Forms.Label();
            lblDepartment = new System.Windows.Forms.Label();
            lblContact = new System.Windows.Forms.Label();
            lblJoinedDate = new System.Windows.Forms.Label();
            lblDesignation = new System.Windows.Forms.Label();
            lblAddress = new System.Windows.Forms.Label();
            lblIdNo = new System.Windows.Forms.Label();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblClose = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // comboBoxDepartment
            // 
            comboBoxDepartment.BackColor = System.Drawing.Color.LightGray;
            comboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            comboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            comboBoxDepartment.FormattingEnabled = true;
            comboBoxDepartment.Location = new System.Drawing.Point(43, 358);
            comboBoxDepartment.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBoxDepartment.Name = "comboBoxDepartment";
            comboBoxDepartment.Size = new System.Drawing.Size(326, 33);
            comboBoxDepartment.TabIndex = 49;
            comboBoxDepartment.MouseDown += OnMouseDown;
            comboBoxDepartment.MouseMove += OnMouseMove;
            comboBoxDepartment.MouseUp += OnMouseUp;
            // 
            // dateTimePicker
            // 
            dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker.CustomFormat = "MM-dd-yyyy";
            dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dateTimePicker.Location = new System.Drawing.Point(43, 473);
            dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new System.Drawing.Size(223, 26);
            dateTimePicker.TabIndex = 48;
            dateTimePicker.MouseDown += OnMouseDown;
            dateTimePicker.MouseMove += OnMouseMove;
            dateTimePicker.MouseUp += OnMouseUp;
            // 
            // txtDesignation
            // 
            txtDesignation.BackColor = System.Drawing.Color.LightGray;
            txtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtDesignation.Location = new System.Drawing.Point(831, 187);
            txtDesignation.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new System.Drawing.Size(326, 31);
            txtDesignation.TabIndex = 47;
            txtDesignation.MouseDown += OnMouseDown;
            txtDesignation.MouseMove += OnMouseMove;
            txtDesignation.MouseUp += OnMouseUp;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = System.Drawing.Color.LightGray;
            txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtAddress.Location = new System.Drawing.Point(831, 54);
            txtAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new System.Drawing.Size(326, 31);
            txtAddress.TabIndex = 46;
            txtAddress.MouseDown += OnMouseDown;
            txtAddress.MouseMove += OnMouseMove;
            txtAddress.MouseUp += OnMouseUp;
            // 
            // txtWorkedHour
            // 
            txtWorkedHour.BackColor = System.Drawing.Color.LightGray;
            txtWorkedHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtWorkedHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtWorkedHour.Location = new System.Drawing.Point(831, 358);
            txtWorkedHour.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtWorkedHour.Name = "txtWorkedHour";
            txtWorkedHour.Size = new System.Drawing.Size(326, 31);
            txtWorkedHour.TabIndex = 45;
            txtWorkedHour.MouseDown += OnMouseDown;
            txtWorkedHour.MouseMove += OnMouseMove;
            txtWorkedHour.MouseUp += OnMouseUp;
            // 
            // txtWage
            // 
            txtWage.BackColor = System.Drawing.Color.LightGray;
            txtWage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtWage.Location = new System.Drawing.Point(438, 358);
            txtWage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtWage.Name = "txtWage";
            txtWage.Size = new System.Drawing.Size(326, 31);
            txtWage.TabIndex = 44;
            txtWage.MouseDown += OnMouseDown;
            txtWage.MouseMove += OnMouseMove;
            txtWage.MouseUp += OnMouseUp;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = System.Drawing.Color.LightGray;
            txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtEmail.Location = new System.Drawing.Point(438, 187);
            txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(326, 31);
            txtEmail.TabIndex = 43;
            txtEmail.MouseDown += OnMouseDown;
            txtEmail.MouseMove += OnMouseMove;
            txtEmail.MouseUp += OnMouseUp;
            // 
            // txtContact
            // 
            txtContact.BackColor = System.Drawing.Color.LightGray;
            txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtContact.Location = new System.Drawing.Point(43, 187);
            txtContact.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtContact.Name = "txtContact";
            txtContact.Size = new System.Drawing.Size(326, 31);
            txtContact.TabIndex = 41;
            txtContact.MouseDown += OnMouseDown;
            txtContact.MouseMove += OnMouseMove;
            txtContact.MouseUp += OnMouseUp;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = System.Drawing.Color.LightGray;
            txtFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtFullName.Location = new System.Drawing.Point(438, 54);
            txtFullName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(326, 31);
            txtFullName.TabIndex = 42;
            txtFullName.TextChanged += TxtFullName_TextChanged;
            txtFullName.MouseDown += OnMouseDown;
            txtFullName.MouseMove += OnMouseMove;
            txtFullName.MouseUp += OnMouseUp;
            // 
            // txtIdNo
            // 
            txtIdNo.BackColor = System.Drawing.Color.LightGray;
            txtIdNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txtIdNo.Enabled = false;
            txtIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtIdNo.Location = new System.Drawing.Point(43, 54);
            txtIdNo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            txtIdNo.Name = "txtIdNo";
            txtIdNo.Size = new System.Drawing.Size(326, 31);
            txtIdNo.TabIndex = 40;
            txtIdNo.MouseDown += OnMouseDown;
            txtIdNo.MouseMove += OnMouseMove;
            txtIdNo.MouseUp += OnMouseUp;
            // 
            // lblWorkedHour
            // 
            lblWorkedHour.AutoSize = true;
            lblWorkedHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWorkedHour.Location = new System.Drawing.Point(845, 323);
            lblWorkedHour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWorkedHour.Name = "lblWorkedHour";
            lblWorkedHour.Size = new System.Drawing.Size(123, 24);
            lblWorkedHour.TabIndex = 38;
            lblWorkedHour.Text = "Worked Hour";
            lblWorkedHour.MouseDown += OnMouseDown;
            lblWorkedHour.MouseMove += OnMouseMove;
            lblWorkedHour.MouseUp += OnMouseUp;
            // 
            // lblWage
            // 
            lblWage.AutoSize = true;
            lblWage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblWage.Location = new System.Drawing.Point(433, 323);
            lblWage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblWage.Name = "lblWage";
            lblWage.Size = new System.Drawing.Size(103, 24);
            lblWage.TabIndex = 37;
            lblWage.Text = "Wage Rate";
            lblWage.MouseDown += OnMouseDown;
            lblWage.MouseMove += OnMouseMove;
            lblWage.MouseUp += OnMouseUp;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblEmail.Location = new System.Drawing.Point(433, 152);
            lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new System.Drawing.Size(57, 24);
            lblEmail.TabIndex = 36;
            lblEmail.Text = "Email";
            lblEmail.MouseDown += OnMouseDown;
            lblEmail.MouseMove += OnMouseMove;
            lblEmail.MouseUp += OnMouseUp;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblFullName.Location = new System.Drawing.Point(433, 20);
            lblFullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new System.Drawing.Size(97, 24);
            lblFullName.TabIndex = 35;
            lblFullName.Text = "Full Name";
            lblFullName.MouseDown += OnMouseDown;
            lblFullName.MouseMove += OnMouseMove;
            lblFullName.MouseUp += OnMouseUp;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDepartment.Location = new System.Drawing.Point(38, 323);
            lblDepartment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new System.Drawing.Size(107, 24);
            lblDepartment.TabIndex = 34;
            lblDepartment.Text = "Department";
            lblDepartment.MouseDown += OnMouseDown;
            lblDepartment.MouseMove += OnMouseMove;
            lblDepartment.MouseUp += OnMouseUp;
            // 
            // lblContact
            // 
            lblContact.AutoSize = true;
            lblContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblContact.Location = new System.Drawing.Point(38, 152);
            lblContact.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblContact.Name = "lblContact";
            lblContact.Size = new System.Drawing.Size(73, 24);
            lblContact.TabIndex = 33;
            lblContact.Text = "Contact";
            lblContact.MouseDown += OnMouseDown;
            lblContact.MouseMove += OnMouseMove;
            lblContact.MouseUp += OnMouseUp;
            // 
            // lblJoinedDate
            // 
            lblJoinedDate.AutoSize = true;
            lblJoinedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblJoinedDate.Location = new System.Drawing.Point(38, 440);
            lblJoinedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblJoinedDate.Name = "lblJoinedDate";
            lblJoinedDate.Size = new System.Drawing.Size(110, 24);
            lblJoinedDate.TabIndex = 32;
            lblJoinedDate.Text = "Joined Date";
            lblJoinedDate.MouseDown += OnMouseDown;
            lblJoinedDate.MouseMove += OnMouseMove;
            lblJoinedDate.MouseUp += OnMouseUp;
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblDesignation.Location = new System.Drawing.Point(826, 152);
            lblDesignation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new System.Drawing.Size(109, 24);
            lblDesignation.TabIndex = 31;
            lblDesignation.Text = "Designation";
            lblDesignation.MouseDown += OnMouseDown;
            lblDesignation.MouseMove += OnMouseMove;
            lblDesignation.MouseUp += OnMouseUp;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblAddress.Location = new System.Drawing.Point(826, 20);
            lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new System.Drawing.Size(80, 24);
            lblAddress.TabIndex = 39;
            lblAddress.Text = "Address";
            lblAddress.MouseDown += OnMouseDown;
            lblAddress.MouseMove += OnMouseMove;
            lblAddress.MouseUp += OnMouseUp;
            // 
            // lblIdNo
            // 
            lblIdNo.AutoSize = true;
            lblIdNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblIdNo.Location = new System.Drawing.Point(38, 17);
            lblIdNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblIdNo.Name = "lblIdNo";
            lblIdNo.Size = new System.Drawing.Size(55, 24);
            lblIdNo.TabIndex = 30;
            lblIdNo.Text = "Id No";
            lblIdNo.MouseDown += OnMouseDown;
            lblIdNo.MouseMove += OnMouseMove;
            lblIdNo.MouseUp += OnMouseUp;
            // 
            // btnSave
            // 
            btnSave.BackColor = System.Drawing.Color.FromArgb(68, 157, 68);
            btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnSave.ForeColor = System.Drawing.Color.White;
            btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSave.Location = new System.Drawing.Point(1017, 516);
            btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(140, 46);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            btnSave.MouseDown += OnMouseDown;
            btnSave.MouseMove += OnMouseMove;
            btnSave.MouseUp += OnMouseUp;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.FromArgb(201, 48, 44);
            btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(31, 43, 55);
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnCancel.Location = new System.Drawing.Point(831, 516);
            btnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(140, 46);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            btnCancel.MouseDown += OnMouseDown;
            btnCancel.MouseMove += OnMouseMove;
            btnCancel.MouseUp += OnMouseUp;
            // 
            // lblClose
            // 
            lblClose.AutoSize = true;
            lblClose.Cursor = System.Windows.Forms.Cursors.Hand;
            lblClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblClose.Location = new System.Drawing.Point(1191, 1);
            lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClose.Name = "lblClose";
            lblClose.Size = new System.Drawing.Size(23, 25);
            lblClose.TabIndex = 50;
            lblClose.Text = "x";
            lblClose.Click += LblClose_Click;
            // 
            // AddEmployee
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1220, 579);
            Controls.Add(lblClose);
            Controls.Add(comboBoxDepartment);
            Controls.Add(dateTimePicker);
            Controls.Add(txtDesignation);
            Controls.Add(txtAddress);
            Controls.Add(txtWorkedHour);
            Controls.Add(txtWage);
            Controls.Add(txtEmail);
            Controls.Add(txtContact);
            Controls.Add(txtFullName);
            Controls.Add(txtIdNo);
            Controls.Add(lblWorkedHour);
            Controls.Add(lblWage);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(lblDepartment);
            Controls.Add(lblContact);
            Controls.Add(lblJoinedDate);
            Controls.Add(lblDesignation);
            Controls.Add(lblAddress);
            Controls.Add(lblIdNo);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "AddEmployee";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "AddEmployee";
            MouseDown += OnMouseDown;
            MouseMove += OnMouseMove;
            MouseUp += OnMouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDepartment;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtWorkedHour;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtIdNo;
        private System.Windows.Forms.Label lblWorkedHour;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblJoinedDate;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblIdNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblClose;
    }
}