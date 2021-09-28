using Bookish.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Bookish.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Catalogue()
        {
            ViewBag.Message = "Your catalogue page.";
            var booksRepository = new BookRepository();
            var allBooks = booksRepository.GetAllBooks();
           
            return View(allBooks);
        }
        public ActionResult ()
        {
            ViewBag.Message = "Your catalogue page.";
            var booksRepository = new BookRepository();
            var allBooks = booksRepository.GetAllBooks();

            return View(allBooks);
        }
    }
}