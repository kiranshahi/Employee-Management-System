using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Data
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string fullName, string address, string contact, string email, string designation, string department, string dateOfJoin,
            string wageRate, string workedHour, string id = null)
        {
            this.Id = string.IsNullOrEmpty(id) ? Guid.NewGuid()
                .ToString() : id;
            this.FullName = fullName;
            this.Address = address;
            this.Contact = contact;
            this.Email = email;
            this.Designation = designation;
            this.Department = department;
            this.DateOfJoin = string.IsNullOrEmpty(dateOfJoin) ? DateTime.Now.ToShortDateString() : dateOfJoin;
            this.WageRate = wageRate;
            this.WorkedHour = workedHour;
        }

        [Key]
        [Required]
        public string Id { get; set; }

        public string FullName { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Designation { get; set; }
        public string Department { get; set; }
        public string DateOfJoin { get; set; }
        public string WageRate { get; set; }
        public string WorkedHour { get; set; }
    }
}