using System;
using System.Drawing;
using System.Windows.Forms;
using EmployeeManagementSystem.Data;

namespace EmployeeManagementSystem
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
        private Point _startPoint = new(0, 0);

        //Delegate has been added
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);


        //Event of the delegate type has been added. i.e. Object of delegate created
        public event IdentityHandler IdentityUpdated;

        public AddEmployee(int nextEmployeID)
        {
            InitializeComponent();
            comboBoxDepartment.Items.Add("Administrative");
            comboBoxDepartment.Items.Add("Finance");
            comboBoxDepartment.Items.Add("Customer service");
            comboBoxDepartment.Items.Add("Marketing");
            comboBoxDepartment.Items.Add("IT");
            comboBoxDepartment.SelectedIndex = 0;
            if (nextEmployeID != 0)
            {
                txtIdNo.Text = nextEmployeID.ToString();
            }
        }

        //This method will set the values on controls received from the selected row.
        public void LoadData(string id, string name, string address, string contact, string email, string desigination, string department, string dateOfJoin, string wageRate, string workedHour)
        {
            txtIdNo.Text = id;
            txtFullName.Text = name;
            txtAddress.Text = address;
            txtContact.Text = contact;
            txtEmail.Text = email;
            txtDesignation.Text = desigination;
            comboBoxDepartment.Text = department;
            string[] dateParts = dateOfJoin.Split('/');
            dateTimePicker.Value = new DateTime(int.Parse(dateParts[2]), int.Parse(dateParts[0]), int.Parse(dateParts[1]));
            txtWage.Text = wageRate;
            txtWorkedHour.Text = workedHour;
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
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

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {

                int EmployeeNo = int.Parse(txtIdNo.Text);
                string name = txtFullName.Text;
                string address = txtAddress.Text;
                string contactNo = txtContact.Text;
                string email = txtEmail.Text;
                string desigination = txtDesignation.Text;
                string department = comboBoxDepartment.Text;
                string dateOfJoin = dateTimePicker.Value.ToString("MM-dd-yyyy");
                string wageRate = txtWage.Text;
                string hourWorked = txtWorkedHour.Text;

                using (var context = new EmployeeManagementContext())
                {
                    var emp = new Employee(EmployeeNo, name, address, contactNo, email, desigination, department, dateOfJoin, wageRate, hourWorked);
                    context.Employees.Add(emp);
                    await context.SaveChangesAsync();
                }

                //instance event args and value has been passed 
                var args = new IdentityEventArgs(EmployeeNo, name, address, contactNo, email, desigination, department, dateOfJoin, wageRate, hourWorked);

                //Event has be raised with update arguments of delegate
                IdentityUpdated?.Invoke(this, args);

                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //This method valid the textoBox full name, if you put a number it return an error
        private bool Validation(TextBox t, string name)
        {
            bool error = false;

            if (int.TryParse(t.Text, out int n))
            {
                error = true;
                MessageBox.Show("Invalid character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return error;

        }
        private void TxtFullName_TextChanged(object sender, EventArgs e)
        {
            Validation(txtFullName, "Full name");
        }
    }
}
