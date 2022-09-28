using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPract.Models
{
    public class AppUserModel
    {
        public int EmployeeId { get; set; }
        public string Password { get; set; }
        public AppUserModel() { }
        public AppUserModel(int employeeId, string password)
        {
            EmployeeId = employeeId;
            Password = password;
        }
    }
}