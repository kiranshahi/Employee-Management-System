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
            EmpName = name;
            EmpDepartment = department;
            EmpWageRate = rate;
            EmpWorkedHours = workedHour;
            EmpTotalWage = workedHour * rate;
        }
    }
}
