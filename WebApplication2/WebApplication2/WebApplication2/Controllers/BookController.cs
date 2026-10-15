using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
namespace WebApplication2.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult Index(book b)
        {
            var book = new book
            {
                id = 1,
                title = "Learning C#",
                author = "John"
            };
            return View(book);
        }
    }
}