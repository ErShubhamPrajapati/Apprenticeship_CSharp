using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index(product p)
        {
            var product = new product
            {
                id = 420,
                name = "Samsung",
                price = 25000
            };
            return View(product);
        }
    }
}