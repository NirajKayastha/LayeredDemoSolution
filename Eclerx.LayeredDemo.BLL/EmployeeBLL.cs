using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eclerx.LayeredDemo.Dal;
using System.Data;

namespace Eclerx.LayeredDemo.BLL
{
    public class EmployeeBLL
    {
        public DataTable GetEmployees(string state)
        { 
          Employee employee = new Employee();
            var dt = employee.GetEmployees(state);
             return dt;
        }

    }
}
