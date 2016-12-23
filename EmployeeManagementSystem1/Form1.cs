using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
    public partial class EmployeeSysMainForm : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public EmployeeSysMainForm()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EmployeeSysMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void EmployeeSysMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void EmployeeSysMainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void employeeDetails_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(EmployeeDetails.Instance);
            EmployeeDetails.Instance.Dock = DockStyle.Fill;
            EmployeeDetails.Instance.BringToFront();
        }

        private void containerPanel_Paint(object sender, PaintEventArgs e)
        {
            containerPanel.Controls.Add(EmployeeDetails.Instance);
            EmployeeDetails.Instance.Dock = DockStyle.Fill;
            EmployeeDetails.Instance.BringToFront();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(AddEmplpoyee.Instance);
            AddEmplpoyee.Instance.Dock = DockStyle.Fill;
            AddEmplpoyee.Instance.BringToFront();
        }
    }
}
