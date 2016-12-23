using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem1
{
    public partial class EmployeeDetails : UserControl
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

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
    }
}
