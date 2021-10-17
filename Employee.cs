using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataAccessLogic;


namespace BusinessLogic
{
    public class Employee
    {
        DataAccessLogic.EmployeeData employeeData = new DataAccessLogic.EmployeeData();
        public int AddEmployee(EmployeeObjects.Employee employee)
        {
            int i = employeeData.AddEmployee(employee);
            return i;
        }

        public DataSet GetEmployee(EmployeeObjects.Employee employee)
        {
            DataSet ds= employeeData.GetEmployee(employee);
            return ds;
        }
    }
}
