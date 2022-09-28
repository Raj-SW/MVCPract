using MVCPract.DataAccessLayer;
using MVCPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MVCPract.BusinessLayer
{
    public class AppUserBL
    {
        public static bool AuthenticateUser(LoginModel model)
        {
            return AppUserDAL.AuthenticateUser(model);
        }
    }
}