using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class DisplayChart : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);


        List<string> departList = new List<string>();
        List<int> totalWageList = new List<int>();

        public DisplayChart(DataGridView dataGridView)
        {
            InitializeComponent();

            GenerateList(dataGridView);
            MakeChart();
        }
        //Method to seprate unique departments are added in departList
        private void GenerateList(DataGridView dataGridView)
        {
            for (int  i = 0;  i < dataGridView.Rows.Count-1 ;  i++)
            {
                string department = dataGridView.Rows[i].Cells[6].Value.ToString();
                if (!departList.Contains(department))
                {
                    departList.Add(department);
                    totalWageList.Add(0);
                }
            }

            for (int i = 0; i < dataGridView.Rows.Count -1 ; i++)
            {
                string employeeDepartment = dataGridView.Rows[i].Cells[6].Value.ToString();
                for (int j = 0; j < departList.Count; j++)
                {
                    if (departList[j] == employeeDepartment)
                    {
                        totalWageList[j] += Convert.ToInt32(dataGridView.Rows[i].Cells[8].Value)* Convert.ToInt32(dataGridView.Rows[i].Cells[9].Value);
                    }
                }
            }
        }

        private void MakeChart()
        {
            for (int i = 0; i < departList.Count; i++)
            {
                pieChart.Series[0].Points.AddY(totalWageList[i]);
                pieChart.Series[0].Points[i].LegendText = departList[i];
                pieChart.Series[0].Points[i].Label = totalWageList[i].ToString();
            }
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }
    }
}
