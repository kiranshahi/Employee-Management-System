using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
    public partial class DisplayChart : Form
    {
        private List<ChartItem> itemList;

        List<string> departList = new List<string>();
        List<int> totalWageList = new List<int>();
        public DisplayChart(List<ChartItem> itemList)
        {
            InitializeComponent();
            this.itemList = itemList;
        }

        private void GenerateList()
        {
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

//        {
//            for (int i = 0; i<departments.Count; i++)
//            {
//                pieChart.Series[0].Points.AddY(totalWages[i]);
//                pieChart.Series[0].Points[i].LegendText = departments[i];
//            }
//}
    }

    public class ChartItem
    {
        public string Department { get; set; }
        public int TotalWage { get; set; }

        public ChartItem(string department, int totalWage)
        {
            this.Department = department;
            this.TotalWage = totalWage;
        }
    }
}
