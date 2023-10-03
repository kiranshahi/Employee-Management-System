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
        public IdentityEventArgs(int id, string fullName, string address, string contact, string email,
            string designation, string department,string dateOfJoin, string wageRate, string workedHour)
        {
            Id = id;
            FullName = fullName;
            Address = address;
            Contact = contact;
            Email = email;
            Designation = designation;
            Department = department;
            DateOfJoin = dateOfJoin;
            WageRate = wageRate;
            WorkedHour = workedHour;
        }

        public int Id { get; }
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
