using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookstore.Models;
using BookStore.Models;


namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();


        public ActionResult Index()
        {
            IEnumerable<Book> books = db.Books;
            return View(db.Books);
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = getToday();
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return purchase.Person +", спасибо"   + " за покупку!";
        }
        private DateTime getToday()
        {
            return DateTime.Now;
        }
       public ActionResult Partial() 
{
    ViewBag.Message = "Это частичное представление.";
    return PartialView();
} 
    }
}