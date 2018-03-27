using MVC5Demo.ActionFilters;
using MVC5Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5Demo.Controllers
{
    [LogActionFilter]
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

        [HttpGet]

        public ActionResult Demo()
        {
            return View();
        }
            //Authorization filters – Implements the IAuthorizationFilter attribute.
            //Action filters – Implements the IActionFilter attribute.
            //Result filters – Implements the IResultFilter attribute.
            //Exception filters – Implements the IExceptionFilter attribute.
        [HttpGet]
        
        [OutputCache(Duration =15)]
        public ActionResult GetDate()
        {
            return Content(DateTime.Now.ToLocalTime().ToString());
        }
       
    }
}