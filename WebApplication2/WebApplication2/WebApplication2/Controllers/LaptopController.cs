using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class LaptopController : Controller
    {
        // GET: Laptop
        public ActionResult Index(laptop l)
        {
            var laptop = new laptop
            {
                brand = "Apple",
                processor = "Intel",
                ram = 16
            };
            return View(laptop);
        }
    }
}