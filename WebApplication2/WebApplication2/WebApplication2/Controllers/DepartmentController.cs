using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        public ActionResult Index(department d)
        {
            var department = new department
            {
                id = 501,
                name = "Computer Science",
                hodName = "Shubham Kumar"
            };
            return View(department);
        }
    }
}