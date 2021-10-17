using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;
using EmployeeObjects;

namespace CodingTest1
{
    public partial class Employee : System.Web.UI.Page
    {
        //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-P4PLEO7;Initial Catalog=EmpRecords;Integrated Security=SSPI;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            EmployeeObjects.Employee employee = new EmployeeObjects.Employee();
            employee.EmployeeID = txtEmpID.Text;
            employee.EmployeeName = txtEmpName.Text;
            employee.Designation = txtDesignation.Text;
            employee.Department = txtDepartment.Text;
            employee.Salary = int.Parse(txtSalary.Text);

            BusinessLogic.Employee employee1 = new BusinessLogic.Employee();
            int i = employee1.AddEmployee(employee);
            if(i==1)
                statusLbl.Text = "Saved Successfully";

            Clear();

            //if (sqlCon.State == ConnectionState.Closed)
            //    sqlCon.Open();

            //SqlCommand sqlCmd = new SqlCommand("spSaveRecords", sqlCon)
            //{
            //    CommandType = CommandType.StoredProcedure
            //};
            //sqlCmd.Parameters.AddWithValue("@EmployeeID", txtEmpID.Text.Trim());
            //sqlCmd.Parameters.AddWithValue("@EmployeeName", txtEmpName.Text.Trim());
            //sqlCmd.Parameters.AddWithValue("@Desigantion", txtDesignation.Text.Trim());
            //sqlCmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());
            //sqlCmd.Parameters.AddWithValue("@Salary", int.Parse(txtSalary.Text));
            //sqlCmd.ExecuteNonQuery();
            //sqlCon.Close();
            //statusLbl.Text = "Saved Successfully";
            //Clear();
        }

        void Clear()
        {
            txtEmpID.Text = txtEmpName.Text = txtDesignation.Text = txtDepartment.Text = txtSalary.Text = "";
        }
    }
}