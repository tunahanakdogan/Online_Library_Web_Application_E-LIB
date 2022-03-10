using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_mvc.Identity;
using elib_mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace elib_mvc.Controllers
{
    //[Authorize]
    public class FavListController : Controller
    {
        private IFavListService _favListService;
        private UserManager<User> _userManager;
        public FavListController(IFavListService favListService, UserManager<User> userManager)
        {
            _favListService = favListService;
            _userManager = userManager;
        }
        [HttpPost]
        public IActionResult DeleteFromFavList(int bookId)
        {
            var userId = _userManager.GetUserId(User);
            _favListService.DeleteFromFavList(userId, bookId);
            return RedirectToAction("index");
        }
        public IActionResult Index()
        {
            var favList = _favListService.GetFavListByUserId(_userManager.GetUserId(User));
            return View(new FavListModel()
            {
                favListId = favList.Id,
                FavListBooks = favList.favListItems.Select(i => new FavListItemModel()
                {
                    FavListItemId = i.Id,
                    bookName = i.book.name,
                    bookImgUrl = i.book.imgUrl,
                    bookAuthor = i.book.author,
                    bookId = i.book.bookId
                }).ToList()
            });
        }
        [HttpPost]
        public IActionResult AddToFavList(int bookId)
        {
            _favListService.AddToList(_userManager.GetUserId(User), bookId);
            return RedirectToAction("Index");
        }


    }
}