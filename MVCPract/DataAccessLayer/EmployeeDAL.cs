using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using MVCPract.Models;
using MVCPract.DataAccessLayer.Common;
using System.Net.Mail;

namespace MVCPract.DataAccessLayer
{
    public static class EmployeeDAL
    {
        public const string GetEmployeeQuery = @"SELECT EmployeeId , FirstName, LastName , Address , Address2 , HomePhone , EmailAddress FROM Employee";
        public const string UpdateEmployeeQuery = "";

        public static List<EmployeeModel> GetEmployees()
        {
            List<EmployeeModel> employees = new List<EmployeeModel>();

            EmployeeModel employee;
            
             var dt = DBCommand.GetData(GetEmployeeQuery);
            foreach(DataRow row in dt.Rows )
            {
                employee = new EmployeeModel();
                employee.Address = row["Address"].ToString();
                employee.Address2 = row["Address2"].ToString();
                employee.EmployeeId = (int) row["EmployeeId"];
                employee.FirstName = row["FirstName"].ToString();
                employee.LastName = row["LastName"].ToString();
                employee.HomePhone = (int) row["HomePhone"];

                employees.Add(employee);
            }
            return employees;
        }
    }
}