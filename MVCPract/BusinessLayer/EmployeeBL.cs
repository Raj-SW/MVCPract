using MVCPract.DataAccessLayer;
using MVCPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPract.BusinessLayer
{
    public static class EmployeeBL
    {
        public static List<EmployeeModel> GetEmployeeModels()
        {
            return EmployeeDAL.GetEmployees();
        }
    }
}