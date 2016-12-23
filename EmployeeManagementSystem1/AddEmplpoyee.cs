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
    public partial class AddEmplpoyee : UserControl
    {
        public AddEmplpoyee()
        {
            InitializeComponent();
        }
        private static AddEmplpoyee _instance;

        public static AddEmplpoyee Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AddEmplpoyee();
                return _instance;
            }
        }
    }
}
