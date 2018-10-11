namespace EmployeeManagementSystem
{
    /***********
     * *
     * *
     * *This class will calculate the total wagae based on the parameter send from GeneratePayroll 
     * * method of EmployeeSysMainForm class.
     * *
     * * 
     * ***********/

    class CalculateTotalWage
    {
        public string EmpName;
        public string EmpDepartment;
        public int EmpWageRate;
        public int EmpWorkedHours;
        public int EmpTotalWage;

        /******
         * * 
         * * Method will Calculate the total wage of employee.
         * * 
         * *******/

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
