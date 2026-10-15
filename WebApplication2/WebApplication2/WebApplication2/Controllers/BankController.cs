using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class BankController : Controller
    {
        // GET: Bank
        public ActionResult Index(bank b)
        {
            var bank = new bank
            {
                bankName = "SBI",
                branch = "Lucknow",
                ifsc = "SBIN0001234"
            };
            return View(bank);
        }
    }
}