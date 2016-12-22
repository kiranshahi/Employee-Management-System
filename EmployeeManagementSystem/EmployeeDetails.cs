using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class EmployeeDetails : UserControl
    {
        private static EmployeeDetails _instance;
        public static EmployeeDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmployeeDetails();
                return _instance;
            }
        }

        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
