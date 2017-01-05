using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
     partial class GeneratePayRoll : Form
     {
        private List<CalculateTotalWage> list;

        public GeneratePayRoll(List<CalculateTotalWage> list)
        {
            InitializeComponent();
            this.list = list;
            //MessageBox.Show(list.Count.ToString());
            //this.payrollDataGridView.DataSource = this.list;
            AddEmployeeToDataGridView();

        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         public void AddEmployeeToDataGridView()
         {
                foreach (CalculateTotalWage emloyeeList in list)
                {
                    int row = payrollDataGridView.Rows.Count - 1;
                    payrollDataGridView.Rows.Add();
                    payrollDataGridView.Rows[row].Cells[0].Value = (emloyeeList.EmpName);
                    payrollDataGridView.Rows[row].Cells[1].Value = (emloyeeList.EmpDepartment);
                    payrollDataGridView.Rows[row].Cells[2].Value = (emloyeeList.EmpWageRate);
                    payrollDataGridView.Rows[row].Cells[3].Value = (emloyeeList.EmpWorkedHours);
                    payrollDataGridView.Rows[row].Cells[4].Value = (emloyeeList.EmpTotalWage);
                }
         }
    }
}
