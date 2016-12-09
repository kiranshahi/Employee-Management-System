namespace EmployeeManagementSystem
{
    partial class EmployeeDetails
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
            this.EmployeeDetailsRecord = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDetailsRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeDetailsRecord
            // 
            this.EmployeeDetailsRecord.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeDetailsRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDetailsRecord.Location = new System.Drawing.Point(12, 12);
            this.EmployeeDetailsRecord.Name = "EmployeeDetailsRecord";
            this.EmployeeDetailsRecord.Size = new System.Drawing.Size(1168, 512);
            this.EmployeeDetailsRecord.TabIndex = 0;
            // 
            // EmployeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 536);
            this.Controls.Add(this.EmployeeDetailsRecord);
            this.Name = "EmployeeDetails";
            this.Text = "Employee Details";
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDetailsRecord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EmployeeDetailsRecord;
    }
}

