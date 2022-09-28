using MVCPract.BusinessLayer;
using MVCPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPract.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Authenticate(LoginModel model)
        {
            var IsUserValid = AppUserBL.AuthenticateUser(model);
            return Json(new { result = IsUserValid, url = Url.Action("Index", "Employee") });
        }
    }
}