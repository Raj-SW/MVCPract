using MVCPract.DataAccessLayer.Common;
using MVCPract.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVCPract.DataAccessLayer
{
    public class AppUserDAL
    {
        public const string AuthenticateUserQuery = @"select emp.* from Employee emp with(nolock) inner join AppUser au with(nolock) on emp.EmployeeId = au.EmployeeId
        WHERE emp.EmailAddress = @EmailAddress and au.Password = @Password";

        public static bool AuthenticateUser(LoginModel model)
        {
            List<SqlParameter> parameters= new List<SqlParameter>();
            parameters.Add(new SqlParameter("@EmailAddress",model.EmailAddress));
            parameters.Add(new SqlParameter("Password",model.Password));    
            var dt = DBCommand.GetDataWithConditions(AuthenticateUserQuery,parameters);
           
            return dt.Rows.Count>0;
        }
    }
}