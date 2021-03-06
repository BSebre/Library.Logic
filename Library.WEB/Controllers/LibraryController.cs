using Library.Logic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.WEB.Controllers
{
    public class LibraryController : Controller
    {
        private static BookManager manager = new BookManager();
        
        public IActionResult Index()
        {
            var books = manager.GetAvailableBooks();
            return View(books);
        }
        public IActionResult MyBooks()
        {
            var books = manager.GetUserBooks();
            return View(books);
        }
        public IActionResult TakeBook(string title)
        {
            manager.TakeBook(title);

            return RedirectToAction(nameof(MyBooks));
        }
        public IActionResult ReturnBook(string title)
        {
            manager.ReturnBook(title);
            return RedirectToAction(nameof(MyBooks));

        }
    }
}
