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
    public partial class AddEmployee : UserControl
    {
        private static AddEmployee _instance;
        public static AddEmployee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddEmployee();
                return _instance;
            }
        }
        public AddEmployee()
        {
            InitializeComponent();
        }
    }
}
