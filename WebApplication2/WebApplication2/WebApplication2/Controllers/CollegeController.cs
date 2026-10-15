using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class CollegeController : Controller
    {
        // GET: College
        public ActionResult Index(college c)
        {
            var college = new college
            {
                collegeName = "GPM Kheri",
                city = "lakhimpur",
                course = "Diploma"
            };
            return View(college);
        }
    }
}