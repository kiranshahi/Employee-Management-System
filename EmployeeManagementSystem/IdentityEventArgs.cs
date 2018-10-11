using System;

namespace EmployeeManagementSystem
{
    /*******
     * 
     * This class will the values from delegates and return the values through properties.
     * 
     *******/
    public class IdentityEventArgs : EventArgs
    {
        public IdentityEventArgs(string id, string fullName, string address, string contact, string email,
            string designation, string department,string dateOfJoin, string wageRate, string workedHour)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Address = address;
            this.Contact = contact;
            this.Email = email;
            this.Designation = designation;
            this.Department = department;
            this.DateOfJoin = dateOfJoin;
            this.WageRate = wageRate;
            this.WorkedHour = workedHour;
        }

        public string Id { get; }
        public string FullName { get; }
        public string Address { get; }
        public string Contact { get; }
        public string Email { get; }
        public string Designation { get; }
        public string Department { get; }
        public string DateOfJoin { get; }
        public string WageRate { get; }
        public string WorkedHour { get; }
    }
}
