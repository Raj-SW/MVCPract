using MVCPract.BusinessLayer;
using MVCPract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCPract.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            var  data = EmployeeBL.GetEmployeeModels();
            ViewBag.EmployeeList = data;
            return View();
        }
    }
}