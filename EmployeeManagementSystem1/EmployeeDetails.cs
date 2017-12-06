using EmployeeManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
    /***********
     * *
     * *This class will show the employee details.
     * * Employee can be imported from CSV files and can be added manually.
     * *
     * ************/
    public partial class EmployeeSysMainForm : Form
    {
        private bool _dragging;
        private Point _startPoint = new Point(0, 0);
        private int _row; 

        public EmployeeSysMainForm()
        {
            InitializeComponent();
            GetEmployees();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            const string message = "You are about to close application. Are you sure you want to continue?";
            const string caption = "Confirm close";
            var result = MessageBox.Show(message, caption,
                                     MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question);
            if (result == DialogResult.OK)
                this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _startPoint = new Point(e.X, e.Y);
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (!_dragging) return;
            var p = PointToScreen(e.Location);
            Location = new Point(p.X - this._startPoint.X, p.Y - this._startPoint.Y);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        private void addEmployee_Click(object sender, EventArgs e)
        {
            var addEmp = new AddEmployee();
            addEmp.IdentityUpdated += this.SaveRecord;
            addEmp.ShowDialog();
        }

        private void SaveRecord(object sender, IdentityEventArgs e)
        {
            try
            {

                var count = dataGridView.Rows.Count-1;
                dataGridView.Rows.Add();
                dataGridView.Rows[count].Cells[0].Value = e.Id;
                dataGridView.Rows[count].Cells[1].Value = e.FullName;
                dataGridView.Rows[count].Cells[2].Value = e.Address;
                dataGridView.Rows[count].Cells[3].Value = e.Contact;
                dataGridView.Rows[count].Cells[4].Value = e.Email;
                dataGridView.Rows[count].Cells[5].Value = e.Designation;
                dataGridView.Rows[count].Cells[6].Value = e.Department;
                dataGridView.Rows[count].Cells[7].Value = e.DateOfJoin;
                dataGridView.Rows[count].Cells[8].Value = e.WageRate;
                dataGridView.Rows[count].Cells[9].Value = e.WorkedHour;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void importEmployees_Click(object sender, EventArgs e)
        {
            ImportEmployeeFromCsv();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.Rows.RemoveAt(dataGridView.CurrentCell.RowIndex);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView.CurrentCell.RowIndex;
                var id = Convert.ToString(dataGridView.Rows[row].Cells[0].Value);
                var name = Convert.ToString(dataGridView.Rows[row].Cells[1].Value);
                var address = Convert.ToString(dataGridView.Rows[row].Cells[2].Value);
                var contact = Convert.ToString(dataGridView.Rows[row].Cells[3].Value);
                var email = Convert.ToString(dataGridView.Rows[row].Cells[4].Value);
                var desigination = Convert.ToString(dataGridView.Rows[row].Cells[5].Value);
                var department = Convert.ToString(dataGridView.Rows[row].Cells[6].Value);
                var dateOfJoin = Convert.ToString(dataGridView.Rows[row].Cells[7].Value);
                var wageRate = Convert.ToString(dataGridView.Rows[row].Cells[8].Value);
                var hourWorked = Convert.ToString(dataGridView.Rows[row].Cells[9].Value);


                var addEmp = new AddEmployee();
                addEmp.LoadData(id, name, address, contact, email, desigination, department, dateOfJoin, wageRate, hourWorked);
                addEmp.IdentityUpdated += this.UpdateRecord;
                addEmp.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecord(object sender, IdentityEventArgs e)
        {
            dataGridView.Rows[_row].Cells[0].Value = e.Id;
            dataGridView.Rows[_row].Cells[1].Value = e.FullName;
            dataGridView.Rows[_row].Cells[2].Value = e.Address;
            dataGridView.Rows[_row].Cells[3].Value = e.Contact;
            dataGridView.Rows[_row].Cells[4].Value = e.Email;
            dataGridView.Rows[_row].Cells[5].Value = e.Designation;
            dataGridView.Rows[_row].Cells[6].Value = e.Department;
            dataGridView.Rows[_row].Cells[7].Value = e.DateOfJoin;
            dataGridView.Rows[_row].Cells[8].Value = e.WageRate;
            dataGridView.Rows[_row].Cells[9].Value = e.WorkedHour;

        }

        private void payroll_Click(object sender, EventArgs e)
        {
            GeneratePayroll();
        }


        //This method will add all the required values to generate payroll in wageDetails list
        public void GeneratePayroll()
        {
            var wageDetailsList = new List<CalculateTotalWage>();
            try
            {
                for (var i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    var name = Convert.ToString(dataGridView.Rows[i].Cells[1].Value);
                    var department = Convert.ToString(dataGridView.Rows[i].Cells[6].Value);
                    var wageRate = int.Parse(dataGridView.Rows[i].Cells[8].Value.ToString());
                    var workedHour = int.Parse(dataGridView.Rows[i].Cells[9].Value.ToString());

                    wageDetailsList.Add(new CalculateTotalWage(name, department, wageRate, workedHour));
                }
                var generatePayroll = new GeneratePayRoll(wageDetailsList);
                generatePayroll.ShowDialog();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            var report = new DisplayChart(dataGridView);
            report.ShowDialog();
        }
        

        /**
         * 
         * This method will help to import CSV file and set the values on dataGridView
         * 
         * **/
        public async void ImportEmployeeFromCsv()
        {
            using (var openFileDialog1 = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

                const char sepChar = ',';
                const char quoteChar = '"';
                var employeeList = new List<string[]>();
                try
                {
                    using (Stream stream = null)
                    {
                        var rows = File.ReadAllLines(openFileDialog1.FileName);
                        foreach (var csvRow in rows)
                        {
                            var inQuotes = false;
                            var fields = new List<string>();
                            var field = "";
                            for (var i = 0; i < csvRow.Length; i++)
                            {
                                if (inQuotes)
                                {
                                    if (i < csvRow.Length - 1 && csvRow[i] == quoteChar && csvRow[i + 1] == quoteChar)
                                    {
                                        i = i++;
                                        field += quoteChar;
                                    }
                                    else if (csvRow[i] == quoteChar)
                                    {
                                        inQuotes = false;
                                    }
                                    else
                                    {
                                        if (csvRow[i - 1] == quoteChar)
                                        {
                                            field = "";
                                            field += csvRow[i];
                                        }
                                        else
                                        {
                                            field += csvRow[i];
                                        }
                                    }
                                }
                                else
                                {
                                    if (csvRow[i] == quoteChar)
                                    {
                                        inQuotes = true;
                                    }
                                    if (csvRow[i] == sepChar)
                                    {
                                        fields.Add(field);
                                        field = "";
                                    }
                                    else
                                    {
                                        field += csvRow[i];
                                    }
                                }
                            }
                            if (!string.IsNullOrEmpty(field))
                            {
                                fields.Add(field);
                                field = "";
                            }
                            employeeList.Add(fields.ToArray());
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                foreach (var value in employeeList)
                {
                    using (var context = new EmployeeManagementContext())
                    {
                        dataGridView.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7], value[8], value[9]);
                        var emp = new Employee(value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7], value[8], value[9]);
                        context.Employees.Add(emp);
                        try
                        {
                            await context.SaveChangesAsync();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
            }

        }

        public void GetEmployees()
        {
            using(var context = new EmployeeManagementContext())
            {
                List<Employee> employees = context.Employees.ToList<Employee>();
                if (employees.Count > 1)
                {
                    foreach (Employee emp in employees)
                    {
                        var count = dataGridView.Rows.Count - 1;
                        dataGridView.Rows.Add();
                        dataGridView.Rows[count].Cells[0].Value = emp.EmployeeID;
                        dataGridView.Rows[count].Cells[1].Value = emp.FullName;
                        dataGridView.Rows[count].Cells[2].Value = emp.Address;
                        dataGridView.Rows[count].Cells[3].Value = emp.Contact;
                        dataGridView.Rows[count].Cells[4].Value = emp.Email;
                        dataGridView.Rows[count].Cells[5].Value = emp.Designation;
                        dataGridView.Rows[count].Cells[6].Value = emp.Department;
                        dataGridView.Rows[count].Cells[7].Value = emp.DateOfJoin;
                        dataGridView.Rows[count].Cells[8].Value = emp.WageRate;
                        dataGridView.Rows[count].Cells[9].Value = emp.WorkedHour;
                        count++;
                    }
                }
            }
        }
    }
}
