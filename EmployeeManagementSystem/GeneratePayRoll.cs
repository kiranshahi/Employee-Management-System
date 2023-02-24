using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    /***********
     * *
     *  This class will help to calculate the and display payroll of employee
     * *
     **********/
    partial class GeneratePayRoll : Form
    {
        private bool _dragging = false;
        private Point _start_point = new(0, 0);


        private List<CalculateTotalWage> list;

        public GeneratePayRoll(List<CalculateTotalWage> list)
        {
            InitializeComponent();
            this.list = list;
            AddEmployeeToDataGridView();

        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Method to add calculated vlues from list to dataGridView
        /// </summary>
        public void AddEmployeeToDataGridView()
        {
            foreach (CalculateTotalWage emloyeeList in list)
            {
                payrollDataGridView.Rows.Add(emloyeeList.EmpName, emloyeeList.EmpDepartment, emloyeeList.EmpWageRate, emloyeeList.EmpWorkedHours, emloyeeList.EmpTotalWage);
            }
        }

        /// <summary>
        /// Method to sort rows based on TotalWage
        /// </summary>
        private void SortByTotalAscending()
        {
            int row = payrollDataGridView.Rows.Count - 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < row; j++)
                {
                    if (Convert.ToInt32(payrollDataGridView.Rows[i].Cells[4].Value) > Convert.ToInt32(payrollDataGridView.Rows[j].Cells[4].Value))
                    {
                        var tempName = payrollDataGridView.Rows[i].Cells[0].Value;
                        var tempDepartment = payrollDataGridView.Rows[i].Cells[1].Value;
                        var tempWageRate = payrollDataGridView.Rows[i].Cells[2].Value;
                        var tempWorkedHour = payrollDataGridView.Rows[i].Cells[3].Value;
                        var tempTotalWage = payrollDataGridView.Rows[i].Cells[4].Value;

                        payrollDataGridView.Rows[i].Cells[0].Value = payrollDataGridView.Rows[j].Cells[0].Value;
                        payrollDataGridView.Rows[i].Cells[1].Value = payrollDataGridView.Rows[j].Cells[1].Value;
                        payrollDataGridView.Rows[i].Cells[2].Value = payrollDataGridView.Rows[j].Cells[2].Value;
                        payrollDataGridView.Rows[i].Cells[3].Value = payrollDataGridView.Rows[j].Cells[3].Value;
                        payrollDataGridView.Rows[i].Cells[4].Value = payrollDataGridView.Rows[j].Cells[4].Value;


                        payrollDataGridView.Rows[j].Cells[0].Value = tempName;
                        payrollDataGridView.Rows[j].Cells[1].Value = tempDepartment;
                        payrollDataGridView.Rows[j].Cells[2].Value = tempWageRate;
                        payrollDataGridView.Rows[j].Cells[3].Value = tempWorkedHour;
                        payrollDataGridView.Rows[j].Cells[4].Value = tempTotalWage;

                    }
                }
            }
        }


        private void SortByTotalDescending()
        {
            int row = payrollDataGridView.Rows.Count - 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < row; j++)
                {
                    if (Convert.ToInt32(payrollDataGridView.Rows[i].Cells[4].Value) < Convert.ToInt32(payrollDataGridView.Rows[j].Cells[4].Value))
                    {
                        var tempName = payrollDataGridView.Rows[i].Cells[0].Value;
                        var tempDepartment = payrollDataGridView.Rows[i].Cells[1].Value;
                        var tempWageRate = payrollDataGridView.Rows[i].Cells[2].Value;
                        var tempWorkedHour = payrollDataGridView.Rows[i].Cells[3].Value;
                        var tempTotalWage = payrollDataGridView.Rows[i].Cells[4].Value;

                        payrollDataGridView.Rows[i].Cells[0].Value = payrollDataGridView.Rows[j].Cells[0].Value;
                        payrollDataGridView.Rows[i].Cells[1].Value = payrollDataGridView.Rows[j].Cells[1].Value;
                        payrollDataGridView.Rows[i].Cells[2].Value = payrollDataGridView.Rows[j].Cells[2].Value;
                        payrollDataGridView.Rows[i].Cells[3].Value = payrollDataGridView.Rows[j].Cells[3].Value;
                        payrollDataGridView.Rows[i].Cells[4].Value = payrollDataGridView.Rows[j].Cells[4].Value;


                        payrollDataGridView.Rows[j].Cells[0].Value = tempName;
                        payrollDataGridView.Rows[j].Cells[1].Value = tempDepartment;
                        payrollDataGridView.Rows[j].Cells[2].Value = tempWageRate;
                        payrollDataGridView.Rows[j].Cells[3].Value = tempWorkedHour;
                        payrollDataGridView.Rows[j].Cells[4].Value = tempTotalWage;

                    }
                }
            }
        }

        /// <summary>
        /// Method to sort rows based on Name
        /// </summary>
        private void SortByNameAscending()
        {
            int row = payrollDataGridView.Rows.Count - 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < row; j++)
                {
                    if (string.Compare(payrollDataGridView.Rows[i].Cells[0].Value.ToString(), payrollDataGridView.Rows[j].Cells[0].Value.ToString()) > 0)
                    {
                        var tempName = payrollDataGridView.Rows[i].Cells[0].Value;
                        var tempDepartment = payrollDataGridView.Rows[i].Cells[1].Value;
                        var tempWageRate = payrollDataGridView.Rows[i].Cells[2].Value;
                        var tempWorkedHour = payrollDataGridView.Rows[i].Cells[3].Value;
                        var tempTotalWage = payrollDataGridView.Rows[i].Cells[4].Value;

                        payrollDataGridView.Rows[i].Cells[0].Value = payrollDataGridView.Rows[j].Cells[0].Value;
                        payrollDataGridView.Rows[i].Cells[1].Value = payrollDataGridView.Rows[j].Cells[1].Value;
                        payrollDataGridView.Rows[i].Cells[2].Value = payrollDataGridView.Rows[j].Cells[2].Value;
                        payrollDataGridView.Rows[i].Cells[3].Value = payrollDataGridView.Rows[j].Cells[3].Value;
                        payrollDataGridView.Rows[i].Cells[4].Value = payrollDataGridView.Rows[j].Cells[4].Value;


                        payrollDataGridView.Rows[j].Cells[0].Value = tempName;
                        payrollDataGridView.Rows[j].Cells[1].Value = tempDepartment;
                        payrollDataGridView.Rows[j].Cells[2].Value = tempWageRate;
                        payrollDataGridView.Rows[j].Cells[3].Value = tempWorkedHour;
                        payrollDataGridView.Rows[j].Cells[4].Value = tempTotalWage;

                    }
                }
            }
        }

        private void SortByNameDescending()
        {
            int row = payrollDataGridView.Rows.Count - 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = i + 1; j < row; j++)
                {
                    if (string.Compare(payrollDataGridView.Rows[i].Cells[0].Value.ToString(), payrollDataGridView.Rows[j].Cells[0].Value.ToString()) < 0)
                    {
                        var tempName = payrollDataGridView.Rows[i].Cells[0].Value;
                        var tempDepartment = payrollDataGridView.Rows[i].Cells[1].Value;
                        var tempWageRate = payrollDataGridView.Rows[i].Cells[2].Value;
                        var tempWorkedHour = payrollDataGridView.Rows[i].Cells[3].Value;
                        var tempTotalWage = payrollDataGridView.Rows[i].Cells[4].Value;

                        payrollDataGridView.Rows[i].Cells[0].Value = payrollDataGridView.Rows[j].Cells[0].Value;
                        payrollDataGridView.Rows[i].Cells[1].Value = payrollDataGridView.Rows[j].Cells[1].Value;
                        payrollDataGridView.Rows[i].Cells[2].Value = payrollDataGridView.Rows[j].Cells[2].Value;
                        payrollDataGridView.Rows[i].Cells[3].Value = payrollDataGridView.Rows[j].Cells[3].Value;
                        payrollDataGridView.Rows[i].Cells[4].Value = payrollDataGridView.Rows[j].Cells[4].Value;


                        payrollDataGridView.Rows[j].Cells[0].Value = tempName;
                        payrollDataGridView.Rows[j].Cells[1].Value = tempDepartment;
                        payrollDataGridView.Rows[j].Cells[2].Value = tempWageRate;
                        payrollDataGridView.Rows[j].Cells[3].Value = tempWorkedHour;
                        payrollDataGridView.Rows[j].Cells[4].Value = tempTotalWage;

                    }
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SortByTotalWageAsc_Click(object sender, EventArgs e)
        {
            SortByTotalAscending();
        }

        private void SortByTotalWageDsc_Click(object sender, EventArgs e)
        {
            SortByTotalDescending();
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - _start_point.X, p.Y - _start_point.Y);
            }
        }
        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void BtnNameAsc_Click(object sender, EventArgs e)
        {
            SortByNameAscending();
        }

        private void BtnNameDsc_Click(object sender, EventArgs e)
        {
            SortByNameDescending();
        }
    }
}
