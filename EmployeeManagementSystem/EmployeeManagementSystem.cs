using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class EmployeeManagementSystem : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);


        public EmployeeManagementSystem()
        {
            InitializeComponent();
        }

        private void EmployeeManagementSystem_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void EmployeeManagementSystem_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void EmployeeManagementSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void EmployeeManagementSystem_Load(object sender, EventArgs e)
        {
            
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {
            contentPanel.Controls.Add(EmployeeDetails.Instance);
            EmployeeDetails.Instance.Dock = DockStyle.Fill;
            EmployeeDetails.Instance.BringToFront();
        }

        private void employeeDetailsButton_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(EmployeeDetails.Instance);
            EmployeeDetails.Instance.Dock = DockStyle.Fill;
            EmployeeDetails.Instance.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Add(AddEmployee.Instance);
            AddEmployee.Instance.Dock = DockStyle.Fill;
            AddEmployee.Instance.BringToFront();
        }
    }
}
