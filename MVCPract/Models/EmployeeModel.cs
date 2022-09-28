using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCPract.Models
{
    public class EmployeeModel
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public int HomePhone { get; set; }
        public string EmailAddress { get; set; }

        public EmployeeModel() { }
        public EmployeeModel(int employeeId, string firstName, string lastName, string address, string address2, int homePhone, string emailAddress)
        {
            EmployeeId = employeeId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Address2 = address2;
            HomePhone = homePhone;
            EmailAddress = emailAddress;
        }
    }
}