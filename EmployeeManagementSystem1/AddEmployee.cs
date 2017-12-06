using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem1
{
    /***********
     * *
     * *
     * *This class will add and edit employee details.
     * *
     * * 
     * ***********/


    public partial class AddEmployee : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);

        //Delegate has been added
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);

        
        //Event of the delegate type has been added. i.e. Object of delegate created
        public event IdentityHandler IdentityUpdated;

        public AddEmployee()
        {
            InitializeComponent();
            comboBoxDepartment.Items.Add("Administrative");
            comboBoxDepartment.Items.Add("Finance");
            comboBoxDepartment.Items.Add("Customer service");
            comboBoxDepartment.Items.Add("Marketing");
            comboBoxDepartment.Items.Add("IT");
            comboBoxDepartment.SelectedIndex = 0;
        }

        //This method will set the values on controls received from the selected row.
        public void LoadData(string id, string name, string address, string contact, string email, string desigination,
           string department, string dateOfJoin, string wageRate, string workedHour)
        {
            txtIdNo.Text = id;
            txtFullName.Text = name;
            txtAddress.Text = address;
            txtContact.Text = contact;
            txtEmail.Text = email;
            txtDesignation.Text = desigination;
            comboBoxDepartment.Text = department;
            dateTimePicker.Text = dateOfJoin;
            txtWage.Text = wageRate;
            txtWorkedHour.Text = workedHour;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var id = txtIdNo.Text;
            var name = txtFullName.Text;
            var address = txtAddress.Text;
            var contactNo = txtContact.Text;
            var email = txtEmail.Text;
            var desigination = txtDesignation.Text;
            var department = comboBoxDepartment.Text;
            var dateOfJoin = dateTimePicker.Text;
            var wageRate = txtWage.Text;
            var hourWorked = txtWorkedHour.Text;

            using (var context = new EmployeeManagementContext())
            {
                var emp = new Employee(id, name, address, contactNo, email, desigination, department, dateOfJoin, wageRate, hourWorked);
                context.Employees.Add(emp);
                await context.SaveChangesAsync();
            }

            //instance event args and value has been passed 
            var args = new IdentityEventArgs(id, name, address, contactNo, email, desigination, department, dateOfJoin, wageRate, hourWorked);

            //Event has be raised with update arguments of delegate
            IdentityUpdated?.Invoke(this, args);

            this.Hide();
        }
    }
}
