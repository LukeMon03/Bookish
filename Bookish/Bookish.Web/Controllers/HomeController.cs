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
        //cataloge page, duh
        public ActionResult Catalogue()
        {
            ViewBag.Message = "Your catalogue page.";
            var booksRepository = new BookRepository();
            var allBooks = booksRepository.GetAllBooks();
           
            return View(allBooks);
        }
        //requires input - maybe wait- need to add form
        public ActionResult Search()
        {
            ViewBag.Message = "search";
            var booksRepository = new BookRepository();
            var searchbook = booksRepository.SearchForBooks("");

            return View(searchbook);
        }
        //This is needed for the homepage
        public ActionResult GetAllUserCopies()
        {
            ViewBag.Message = "get all borrowed copies";
            var booksRepository = new BookRepository();
            // based on userid 
            int Kangaroo = 10000000;
            var getcopies = booksRepository.GetAllUserCopies(Kangaroo); 

            return View(getcopies);
        }
        /*
        public ActionResult GetAllUserCopies()
        {
            ViewBag.Message = "get all borrowed copies";
            var booksRepository = new BookRepository();
            var getcopies = booksRepository.GetAllUserCopies(); //so vwhat goes here

            return View(getcopies);
        }
        */
    }
}