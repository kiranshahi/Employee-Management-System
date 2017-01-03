using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
    public partial class AddEmplpoyee : UserControl
    {
        public delegate void IdentityHandler(object sender, IdentityEventArgs e);

        public event IdentityHandler IdentityUpdated;
        public AddEmplpoyee()
        {
            InitializeComponent();
        }
        private static AddEmplpoyee _instance;

        public static AddEmplpoyee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddEmplpoyee();
                return _instance;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtIdNo.Text;
            string fullName = txtFullName.Text;
            string address = txtAddress.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            string designation = txtDesignation.Text;
            string department = txtDepartment.Text;
            string wageRate = txtWage.Text;

            IdentityEventArgs args = new IdentityEventArgs(id, fullName, address, contact, email,designation, department, wageRate);

            IdentityUpdated(this, args);
        }
    }
}
