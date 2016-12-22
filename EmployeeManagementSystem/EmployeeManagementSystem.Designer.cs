namespace EmployeeManagementSystem
{
    partial class EmployeeManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagementSystem));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.systemName = new System.Windows.Forms.Label();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.minimize = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel.SuspendLayout();
            this.logoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.sidebarPanel.Controls.Add(this.logoPanel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(172, 659);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.sidebarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.sidebarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // logoPanel
            // 
            this.logoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(120)))), ((int)(((byte)(53)))));
            this.logoPanel.Controls.Add(this.pictureBox1);
            this.logoPanel.Controls.Add(this.systemName);
            this.logoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(172, 68);
            this.logoPanel.TabIndex = 1;
            this.logoPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.logoPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.logoPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // systemName
            // 
            this.systemName.AutoSize = true;
            this.systemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemName.ForeColor = System.Drawing.Color.White;
            this.systemName.Location = new System.Drawing.Point(42, 20);
            this.systemName.Name = "systemName";
            this.systemName.Size = new System.Drawing.Size(128, 20);
            this.systemName.TabIndex = 0;
            this.systemName.Text = "Emp Mgmt Sys";
            this.systemName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.systemName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.systemName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.White;
            this.headerPanel.Controls.Add(this.minimize);
            this.headerPanel.Controls.Add(this.close);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(172, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(940, 68);
            this.headerPanel.TabIndex = 1;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // minimize
            // 
            this.minimize.AutoSize = true;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimize.Location = new System.Drawing.Point(892, 3);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(16, 24);
            this.minimize.TabIndex = 0;
            this.minimize.Text = "-";
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            this.minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.minimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(916, 3);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(20, 24);
            this.close.TabIndex = 0;
            this.close.Text = "x";
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.close.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // containerPanel
            // 
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(172, 68);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(940, 591);
            this.containerPanel.TabIndex = 2;
            this.containerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.containerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.containerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            // 
            // EmployeeManagementSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1112, 659);
            this.Controls.Add(this.containerPanel);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.sidebarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmployeeManagementSystem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeManagementSystem";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.EmployeeManagementSystem_MouseUp);
            this.sidebarPanel.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label systemName;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Label minimize;
        private System.Windows.Forms.Label close;
    }
}