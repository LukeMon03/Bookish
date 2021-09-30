using Bookish.Net;
using Bookish.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookish.Web.Controllers
{
    public class CatalogueController : Controller
    {
        // GET: Catalogue_
        //cataloge page, duh
        public ActionResult Catalogue()
        {
            ViewBag.Message = "Your catalogue page.";
            var booksRepository = new BookRepository();
            var allBooks = booksRepository.GetAllBooks();

            return View(allBooks);
        }

        [HttpPost]
        public ActionResult Catalogue(SearchData searchData)
        {
            var bookRepository = new BookRepository();
            var searchbooks = bookRepository.SearchForBooks(searchData.SearchText);

            return View(searchbooks);
        }

        //This is needed for the homepage
        /*
        public ActionResult GetAllUserCopies()
        {
            ViewBag.Message = "get all borrowed copies";
            var booksRepository = new BookRepository();
            // based on userid 
            int Kangaroo = 10000000;
            var getcopies = booksRepository.GetAllUserCopies(Kangaroo);

            return View(getcopies);
        }
        */
    }
}