using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index(student s)
        {
            var student = new student
            {
                id = 1,
                name = "Suraj Verma",
                age = 21
            };
            return View(student);
        }
    }
}