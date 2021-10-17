using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmployeeObjects;
using BusinessLogic;

namespace CodingTest1
{
    public partial class EmpRecords : System.Web.UI.Page
    {
        //SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-P4PLEO7;Initial Catalog=EmpRecords;Integrated Security=SSPI;");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            EmployeeObjects.Employee employee = new EmployeeObjects.Employee();
            employee.EmployeeID = getEmpID.Text;

            BusinessLogic.Employee employee1 = new BusinessLogic.Employee();
            DataSet dt = new DataSet();
            dt = employee1.GetEmployee(employee);
            myDataGrid.DataSource = dt;
            myDataGrid.DataBind();

            getEmpID.Text = "";
            //if (sqlCon.State == ConnectionState.Closed)
            //    sqlCon.Open();

            //SqlDataAdapter sqlDA = new SqlDataAdapter("GetEmployees",sqlCon);
            //sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
            //sqlDA.SelectCommand.Parameters.AddWithValue("@EmployeeID", getEmpID.Text);
            //DataTable dt = new DataTable();
            //sqlDA.Fill(dt);
            //myDataGrid.DataSource = dt;
            //myDataGrid.DataBind();
            //getEmpID.Text = "";
        }
    }
}