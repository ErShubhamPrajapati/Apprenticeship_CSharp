using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class HospitalController : Controller
    {
        // GET: Hospital
        public ActionResult Index(hospital h)
        {
            var hospital = new hospital
            {
                name = "Jagrani Hospital",
                city = "Lucknow",
                totalBeds = 15
            };
            return View(hospital);
        }
    }
}