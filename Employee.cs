using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using EmployeeObjects;

namespace DataAccessLogic
{
    public class EmployeeData
    {
        public string EpmpID { get; set; }        

        SqlConnection sqlCon = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        public int AddEmployee(EmployeeObjects.Employee employee)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlCommand sqlCmd = new SqlCommand("spSaveRecords", sqlCon)
            {
                CommandType = CommandType.StoredProcedure
            };
            sqlCmd.Parameters.AddWithValue("@EmployeeID",employee.EmployeeID);
            sqlCmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
            sqlCmd.Parameters.AddWithValue("@Desigantion", employee.Designation);
            sqlCmd.Parameters.AddWithValue("@Department", employee.Department);
            sqlCmd.Parameters.AddWithValue("@Salary", employee.Salary);
            int i = sqlCmd.ExecuteNonQuery();
            sqlCon.Close();
            return i;
        }

        public DataSet GetEmployee(EmployeeObjects.Employee employee)
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("GetEmployees",sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@EmployeeID", employee.EmployeeID);
            DataSet dt = new DataSet();
            sqlDa.Fill(dt,"Employee");
            return dt;
        }

    }
}
