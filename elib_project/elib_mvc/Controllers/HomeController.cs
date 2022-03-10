using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using elib_mvc.Models;
using elib_data.Abstract;
using elib_business.Abstract;

namespace elib_mvc.Controllers
{
    public class HomeController : Controller
    {
        public IBookService _bookService;
        public HomeController(IBookService bookService)
        {
            this._bookService = bookService;
        }
        public IActionResult Index()
        {
            var bookListModel = new BookListModel()
            {
                books = _bookService.GetAll()
            };

            return View(bookListModel.books);
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
