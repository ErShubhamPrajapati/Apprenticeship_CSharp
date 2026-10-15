using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        public ActionResult Index(course c)
        {
            var course = new course
            {
                courseId = 576,
                courseName = "Diploma",
                duration = 3
            };
            return View(course);
        }
    }
}