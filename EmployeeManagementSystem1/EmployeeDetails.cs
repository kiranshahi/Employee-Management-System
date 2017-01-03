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
                Environment.Exit(0);
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

        private void employeeDetails_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(panel1);
            panel1.Dock = DockStyle.Fill;
            panel1.BringToFront();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            containerPanel.Controls.Add(AddEmplpoyee.Instance);
            AddEmplpoyee.Instance.Dock = DockStyle.Fill;
            AddEmplpoyee.Instance.BringToFront();
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
                        //if ((myStream = openFileDialog1.OpenFile()) !=null)
                        //{
                            using (myStream)
                            {
                                string[] rows = File.ReadAllLines("" + openFileDialog1.FileName + "");

                                foreach(string csvRow in rows)
                                {
                                    bool inQuotes = false;
                                    List<string> fields = new List<string>();
                                    string field = "";
                                    for (int i = 0; i < csvRow.Length; i++)
                                    {
                                        if (inQuotes)
                                        {
                                            if (i<csvRow.Length - 1 && csvRow[i] == quoteChar && csvRow[i + 1] == quoteChar)
                                            {
                                                i = i++;
                                                field += quoteChar;
                                            }
                                            else if(csvRow[i]== quoteChar)
                                            {
                                                inQuotes = false;
                                            } else
                                            {
                                                if (csvRow[i - 1] == quoteChar)
                                                {
                                                    field = "";
                                                    field += csvRow[i];
                                                } else
                                                {
                                                    field += csvRow[i];
                                                }
                                            }
                                        }else
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
                    //}
                    catch (Exception er)
                    {
                        MessageBox.Show(er.Message, "Somthing went wrong. Could not read File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach(string[] value in listA)
                    {
                        dataGridView.Rows.Add(value[0], value[1], value[2], value[3], value[4], value[5], value[6], value[7]);
                    }
                }

            }
            
        }
    }
}
