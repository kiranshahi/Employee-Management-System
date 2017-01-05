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
        private string dateOfJoin;
        private string wageRate;
        private string workedHour;

        public IdentityEventArgs(string id, string fullName, string address, string contact, string email,
            string designation, string department,string dateOfJoin, string wageRate, string workedHour)
        {
            this.id = id;
            this.fullName = fullName;
            this.address = address;
            this.contact = contact;
            this.email = email;
            this.designation = designation;
            this.department = department;
            this.dateOfJoin = dateOfJoin;
            this.wageRate = wageRate;
            this.workedHour = workedHour;
        }

        public string Id { get { return id; } }
        public string FullName { get { return fullName; } }
        public string Address { get { return address; } }
        public string Contact { get { return contact; } }
        public string Email { get { return email; } }
        public string Designation { get { return designation; } }
        public string Department { get { return department; } }
        public string DateOfJoin { get { return dateOfJoin; } }
        public string WageRate { get { return wageRate; } }
        public string WorkedHour { get { return workedHour; } }


    }
}
