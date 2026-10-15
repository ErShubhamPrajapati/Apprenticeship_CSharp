using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index(teacher t)
        {
            var teacher = new teacher
            {
                id = 10,
                name = "Shubham",
                subject = "PHP"
            };
            return View(teacher);
        }
    }
}