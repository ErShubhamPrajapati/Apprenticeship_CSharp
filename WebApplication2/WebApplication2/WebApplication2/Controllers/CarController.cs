using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class CarController : Controller
    {
        // GET: Car
        public ActionResult Index(car c)
        {
            var car = new car
            {
                company = "Maruti Sujki",
                model = "Toyota",
                price = 1000000
            };
            return View(car);
        }
    }
}