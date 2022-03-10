using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_entity;
using elib_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using static BookListModel;

namespace elib_mvc.Controllers
{
    public class LibraryController : Controller
    {
        public IBookService _bookService;
        public LibraryController(IBookService bookService)
        {
            this._bookService = bookService;
        }

        public IActionResult List(string category, int page = 1)
        {

            const int pageSize = 8; //To determine how many books will be showed in one page
            var bookListModel = new BookListModel()
            {
                pageInfo = new PageInfo()
                {
                    totalBooks = _bookService.GetCountByCategory(category),
                    currentPage = page,
                    bookPerPage = pageSize,
                    currentCategory = category
                },
                books = _bookService.GetBooksByCategory(category, page, pageSize)
            };

            return View(bookListModel);
        }
        public IActionResult Details(string url)
        {
            if (url == null)
            {
                return NotFound();
            }
            Book book = _bookService.GetBookDetails(url);
            if (book == null)
            {
                return NotFound();
            }
            //Console.WriteLine(book.name);
            return View(new BookDetailModel
            {
                Book = book,
                Categories = book.BookCategories.Select(i => i.category).ToList()
            });
        }
        public IActionResult Search(string searchWord)
        {

            var bookListModel = new BookListModel()
            {

                books = _bookService.GetSearchResults(searchWord)
            };

            return View(bookListModel);
        }
    }
}