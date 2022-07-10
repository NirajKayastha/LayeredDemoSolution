using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eclerx.LayeredDemo.Dal
{
    public class Employee
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private DataTable dt = null;

        public DataTable GetEmployees(string state)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnHR"].ConnectionString))
            {
                using (cmd = new SqlCommand("usp_GetEmployeeDepartmentByCity", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@State", SqlDbType.VarChar, 50));
                    cmd.Parameters["@state"].Value = state ;
                    if (con.State == ConnectionState.Closed)
                    { 
                      con.Open();
                    }
                    SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (reader.HasRows)
                    { 
                        dt =new DataTable();
                        dt.Load(reader);    
                    }
                    reader.Close();

                }
                
            
            }
            return dt;
        }
        

    }
}
