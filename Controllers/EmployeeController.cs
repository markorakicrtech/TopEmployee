using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopEmployee.Models;

namespace TopEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Login()
        {
            return View();
        }
        public ViewResult Register()
        {
            Employee e = new Employee();
            return View(e);
        }
    }
}