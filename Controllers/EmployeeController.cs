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
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        public ActionResult Login()
        {
            EmployeeViewModel evm = new EmployeeViewModel();
            return View();
        }
        public ViewResult Register()
        {
            EmployeeViewModel evm = new EmployeeViewModel() { Employee = new Employee() };
            return View(evm);
        }
        [HttpPost]
        public ActionResult Save(EmployeeViewModel evm)
        {
            if (!ModelState.IsValid)
            {

            }
            _context.Employees.Add(evm.Employee);
            _context.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }
        
      
        public ActionResult CheckEmployee(EmployeeViewModel evm)
        {
            //var employee = _context.Employees.FirstOrDefault(x => x.Username == evm.Employee.Username 
            //                                        && x.Password == evm.Employee.Password);

            
            return View();
        }

    }
}