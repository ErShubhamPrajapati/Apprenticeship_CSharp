using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index(employee e)
        {
            var employee = new employee
            {
                id = 15,
                name = "Abhay",
                salary = 20000
            };
            return View(employee);
        }
    }
}