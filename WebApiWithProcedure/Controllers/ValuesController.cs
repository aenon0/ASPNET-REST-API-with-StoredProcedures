using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiWithProcedure.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;

namespace WebApiWithProcedure.Controllers
{
    public class ValuesController : ApiController
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["webapi_conn"].ConnectionString);
        Employee emp = new Employee();
        
        
        
        // GET api/values
        public List<Employee> Get()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_GetAllEmployees", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);

            List<Employee> employeeList = new List<Employee>();

            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    Employee emp = new Employee();
                    emp.Id = Convert.ToInt32(dt.Rows[i]["Id"]); 
                    emp.Name = dt.Rows[i]["Name"].ToString();
                    emp.Age = Convert.ToInt32(dt.Rows[i]["Age"]);
                    emp.Active = Convert.ToInt32(dt.Rows[i]["Active"]);
                    employeeList.Add(emp);
                }
                   
            }

            if(employeeList.Count > 0)
            {
                return employeeList;
            }
            return null;
        }

        
        // GET api/values/5
        public Employee Get(int Id)
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_GetEmployeeById", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@Id", Id);
            DataTable dt = new DataTable();
            da.Fill(dt);

            Employee emp = new Employee();

            if (dt.Rows.Count > 0)
            {
                emp.Id = Convert.ToInt32(dt.Rows[0]["Id"]);
                emp.Name = dt.Rows[0]["Name"].ToString();
                emp.Age = Convert.ToInt32(dt.Rows[0]["Age"]);
                emp.Active = Convert.ToInt32(dt.Rows[0]["Active"]);
                return emp;
            }

            return null;
        }


        // POST api/values
        public String Post(Employee emp)
        {
            int i = 0;
            if(emp != null)
            {
                SqlCommand cmd = new SqlCommand("usp_AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Age", emp.Age);
                cmd.Parameters.AddWithValue("@Active", emp.Active);

                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }

            if (i > 0)
            {
                return "Data has been inserted.";
            }
            return "Error Adding Data!!";
        }


        // PUT api/values/5
        public String Put(int Id, Employee emp)
        {
            int i = 0;
            if (emp != null)
            {
                SqlCommand cmd = new SqlCommand("usp_UpdateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Age", emp.Age);
                cmd.Parameters.AddWithValue("@Active", emp.Active);
                con.Open();
                i = cmd.ExecuteNonQuery();
                con.Close();
            }

            if (i > 0)
            {
                return "Data has been updated.";
            }
            return "Error Updating Data!!";
        }


        // DELETE api/values/5
        public String Delete(int Id)
        {
            int i = 0;
            SqlCommand cmd = new SqlCommand("usp_DeleteEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            con.Open();
            i = cmd.ExecuteNonQuery();
            con.Close();
            if (i > 0)
            {
                return "Data has been deleted.";
            }
            return "Error Deleting Data!!";
        }
    }
}

