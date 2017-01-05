using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem1
{

    class CalculateTotalWage
    {
        public string EmpName;
        public string EmpDepartment;
        public int EmpWageRate;
        public int EmpWorkedHours;
        public int EmpTotalWage;

        public CalculateTotalWage(string name, string department, int rate, int workedHour)
        {
            this.EmpName = name;
            this.EmpDepartment = department;
            this.EmpWageRate = rate;
            this.EmpWorkedHours = workedHour;
            this.EmpTotalWage = workedHour * rate;
        }
    }
}
