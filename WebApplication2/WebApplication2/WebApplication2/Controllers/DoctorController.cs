using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class DoctorController : Controller
    {
        // GET: Doctor
        public ActionResult Index(doctor c)
        {
            var doctor = new doctor
            {
                id = 601,
                name = "Dr. Ankur",
                specialization = "Heart"
            };
            return View(doctor);
        }
    }
}