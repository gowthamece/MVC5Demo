using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee employee = new Employee();
            employee.FirstName = "Gowtham";
            employee.LastName = "K";
            employee.Age = "26";
            return View("EmployeeIndex",employee);
        }

        [HttpPost]
        public ActionResult AddEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                return View("AddEmployee_Success");
            }
            else
            {
                return View("EmployeeIndex");
            }
        }
       
    }
}