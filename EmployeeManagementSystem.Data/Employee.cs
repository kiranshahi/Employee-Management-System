using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementSystem.Data
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(int id, string fullName, string address, string contact, string email, string designation, string department, string dateOfJoin,
            string wageRate, string workedHour)
        {
            EmployeeID = id;
            FullName = fullName;
            Address = address;
            Contact = contact;
            Email = email;
            Designation = designation;
            Department = department;
            DateOfJoin = string.IsNullOrEmpty(dateOfJoin) ? DateTime.Now.ToShortDateString() : dateOfJoin;
            WageRate = wageRate;
            WorkedHour = workedHour;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int EmployeeID { get; set; }
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