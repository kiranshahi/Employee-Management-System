using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
    public partial class EmployeeSysMainForm : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);
        private int row;

        List<GeneratePayRoll> payrollList = new List<GeneratePayRoll>();
        List<ChartItem> itemList = new List<ChartItem>();

        //DataGridView myDataGridView = new DataGridView();
        //DataTable myDataTable = new DataTable();

        public EmployeeSysMainForm()
        {
            InitializeComponent();
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

        private void EmployeeSysMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void EmployeeSysMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void EmployeeSysMainForm_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }


        private void addEmployee_Click(object sender, EventArgs e)
        {
            AddEmployee addEmp = new AddEmployee();
            addEmp.IdentityUpdated += new AddEmployee.IdentityHandler(this.SaveRecord);
            addEmp.ShowDialog();
        }

        private void SaveRecord(object sender, IdentityEventArgs e)
        {
            try
            {

                int count = dataGridView.Rows.Count-1;
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
            Stream myStream = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    char sepChar = ',';
                    char quoteChar = '"';
                    List<string[]> listA = new List<string[]>();
                    try
                    {
                        using (myStream)
                        {
                            string[] rows = File.ReadAllLines("" + openFileDialog1.FileName + "");
                            foreach (string csvRow in rows)
                            {
                                bool inQuotes = false;
                                List<string> fields = new List<string>();
                                string field = "";
                                for (int i = 0; i < csvRow.Length; i++)
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
                                listA.Add(fields.ToArray());
                            }
                        }
                    }
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach(string[] value in listA)
                    {
                        dataGridView.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7], value[8], value[9]);
                    }
                }

            }
            
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
                int row = dataGridView.CurrentCell.RowIndex;
                string id = Convert.ToString(dataGridView.Rows[row].Cells[0].Value);
                string name = Convert.ToString(dataGridView.Rows[row].Cells[1].Value);
                string address = Convert.ToString(dataGridView.Rows[row].Cells[2].Value);
                string contact = Convert.ToString(dataGridView.Rows[row].Cells[3].Value);
                string email = Convert.ToString(dataGridView.Rows[row].Cells[4].Value);
                string desigination = Convert.ToString(dataGridView.Rows[row].Cells[5].Value);
                string department = Convert.ToString(dataGridView.Rows[row].Cells[6].Value);
                string dateOfJoin = Convert.ToString(dataGridView.Rows[row].Cells[7].Value);
                string wageRate = Convert.ToString(dataGridView.Rows[row].Cells[8].Value);
                string hourWorked = Convert.ToString(dataGridView.Rows[row].Cells[9].Value);


                AddEmployee addEmp = new AddEmployee();
                addEmp.loadData(id, name, address, contact, email, desigination, department, dateOfJoin, wageRate, hourWorked);
                addEmp.IdentityUpdated += new AddEmployee.IdentityHandler(this.UpdateRecord);
                addEmp.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRecord(object sender, IdentityEventArgs e)
        {
            dataGridView.Rows[row].Cells[0].Value = e.Id;
            dataGridView.Rows[row].Cells[1].Value = e.FullName;
            dataGridView.Rows[row].Cells[2].Value = e.Address;
            dataGridView.Rows[row].Cells[3].Value = e.Contact;
            dataGridView.Rows[row].Cells[4].Value = e.Email;
            dataGridView.Rows[row].Cells[5].Value = e.Designation;
            dataGridView.Rows[row].Cells[6].Value = e.Department;
            dataGridView.Rows[row].Cells[7].Value = e.DateOfJoin;
            dataGridView.Rows[row].Cells[8].Value = e.WageRate;
            dataGridView.Rows[row].Cells[9].Value = e.WorkedHour;

        }

        private void payroll_Click(object sender, EventArgs e)
        {
            GeneratePayroll();
        }

        public void GeneratePayroll()
        {
            List<CalculateTotalWage> wageDetailsList = new List<CalculateTotalWage>();
            try
            {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    string name = dataGridView.Rows[i].Cells[1].Value.ToString();
                    string department = dataGridView.Rows[i].Cells[6].Value.ToString();
                    int wageRate = Int32.Parse(dataGridView.Rows[i].Cells[8].Value.ToString());
                    int workedHour = Int32.Parse(dataGridView.Rows[i].Cells[9].Value.ToString());

                    wageDetailsList.Add(new CalculateTotalWage(name, department, wageRate, workedHour));
                }
                GeneratePayRoll generatePayroll = new GeneratePayRoll(wageDetailsList);
                generatePayroll.ShowDialog();
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            GenerateChartDetails();
        }
        public void GenerateChartDetails()
        {
            List<ChartItem> itemList = new List<ChartItem>();
            try
            {
                for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
                {
                    string department = dataGridView.Rows[i].Cells[1].Value.ToString();
                    int totalWage = Int32.Parse(dataGridView.Rows[i].Cells[8].Value.ToString());

                    itemList.Add(new ChartItem(department, totalWage));
                }
                DisplayChart generatePayroll = new DisplayChart(itemList);
                generatePayroll.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
