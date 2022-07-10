using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Eclerx.LayeredDemo.BLL;


namespace Eclerx.LayeredDemo.PresentaionLogic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            EmployeeBLL emp  =new EmployeeBLL();
            var dt = emp.GetEmployees(txtState.Text);
                if (dt != null)
            {
                dataGridViewEmployee.DataSource = dt;


            }
            else
            {

                MessageBox.Show("Invalid State Name");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
