using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TopEmployee.Models;
using TopEmployee.ViewModel;

namespace TopEmployee.Controllers
{
    public class EmployeeController : Controller
    {
        AplicationDBContext _context;
        public EmployeeController()
        {
            _context = new AplicationDBContext();
        }
        // GET: Employee
        public ActionResult Login()
        {
            return View();
        }
        public ViewResult Register()
        {
            EmployeeViewModel evm = new EmployeeViewModel() { Employee = new Employee() };
            return View(evm);
        }
        [HttpPost]
        public ActionResult Create(EmployeeViewModel evm)
        {
            //_context.Employees.Add(evm.Employee);
            //_context.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }
    }
}