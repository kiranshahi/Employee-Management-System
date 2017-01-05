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
                    payrollDataGridView.Rows.Add(emloyeeList);
                }
         }

    }
}
