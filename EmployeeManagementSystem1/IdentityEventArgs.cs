using System;

namespace EmployeeManagementSystem1
{
    public class IdentityEventArgs : EventArgs
    {
        private string id;
        private string fullName;
        private string address;
        private string contact;
        private string email;
        private string designation;
        private string department;
        private string wageRate;

        public IdentityEventArgs(string id, string fullName, string address, string contact, string email,
            string designation, string department, string wageRate)
        {
            this.id = id;
            this.fullName = fullName;
            this.address = address;
            this.contact = contact;
            this.email = email;
            this.designation = designation;
            this.department = department;
            this.wageRate = wageRate;
        }
    }
}
