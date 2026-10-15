using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index(customer c)
        {
            var customer = new customer
            {
                id = 502,
                name = "Abhay Kumar",
                city = "Lakhimpur"
            };
            return View(customer);
        }
    }
}