using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_entity;
using elib_mvc.Identity;
using elib_mvc.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace elib_mvc.Controllers
{
    [Authorize(Roles = "Admin")]


    public class AdminController : Controller
    {
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private RoleManager<IdentityRole> _roleManager;
        private UserManager<User> _userManager;
        public AdminController(IBookService bookService, ICategoryService categoryService, RoleManager<IdentityRole> roleManager, UserManager<User> userManager)
        {
            _bookService = bookService;
            _categoryService = categoryService;
            _roleManager = roleManager;
            _userManager = userManager;
        }
        public IActionResult List()
        {
            return View(new BookListModel()
            {
                books = _bookService.GetAll()
            });
        }
        public IActionResult RoleList()
        {
            return View(_roleManager.Roles);
        }
        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }

        public async Task<IActionResult> DeleteRole(RoleEditModel model)
        {
            var role = await _roleManager.FindByIdAsync(model.RoleId);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return RedirectToAction("RoleList");
        }


        public async Task<IActionResult> EditRole(string id)
        {
            var role = await _roleManager.FindByIdAsync(id);

            var members = new List<User>();
            var nonMembers = new List<User>();
            List<User> users = _userManager.Users.ToList();
            foreach (var user in users)
            {

                if (await _userManager.IsInRoleAsync(user, role.Name.ToString()))
                {
                    members.Add(user);
                }
                else
                {
                    nonMembers.Add(user);
                }
            }
            var model = new RoleDetails()
            {
                Role = role,
                Members = members,
                NonMembers = nonMembers
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(RoleEditModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var userId in model.IdsToAdd ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.AddToRoleAsync(user, model.RoleName);

                    }
                }
                foreach (var userId in model.IdsToDelete ?? new string[] { })
                {
                    var user = await _userManager.FindByIdAsync(userId);
                    if (user != null)
                    {
                        var result = await _userManager.RemoveFromRoleAsync(user, model.RoleName);

                    }
                }

            }
            return RedirectToAction("rolelist");
        }



        [HttpPost]
        public async Task<IActionResult> AddRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await _roleManager.CreateAsync(new IdentityRole(model.name));
                if (result.Succeeded)
                {
                    return RedirectToAction("RoleList");
                }

            }
            return View(model);
        }

        public IActionResult CategoryList()
        {
            return View(new CategoryListModel()
            {
                Categories = _categoryService.GetAll()
            });
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(BookModel bookModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new Book()
                {
                    name = bookModel.name,
                    bookUrl = bookModel.bookUrl,
                    author = bookModel.author,
                    description = bookModel.description,
                    imgUrl = bookModel.imgUrl,
                    url = bookModel.url
                };
                _bookService.Create(entity);

                TempData["notification"] = $"{entity.name} is added";
                return RedirectToAction("list");
            }
            return View(bookModel);

        }


        public IActionResult UserList()
        {
            return View(_userManager.Users);
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCategory(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category()
                {
                    name = categoryModel.name,

                    url = categoryModel.url
                };
                _categoryService.Create(entity);

                TempData["notification"] = $"{entity.name} is added";
                return RedirectToAction("CategoryList");
            }
            return View(categoryModel);

        }






        [HttpGet]
        public IActionResult EditBook(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _bookService.GetBookByIdWithCategories((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new BookModel()
            {
                bookId = entity.bookId,
                bookUrl = entity.bookUrl,
                name = entity.name,
                author = entity.author,
                description = entity.description,
                imgUrl = entity.imgUrl,
                url = entity.url,
                CategoriesOfBook = entity.BookCategories.Select(b => b.category).ToList()

            };
            ViewBag.AllCategories = _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult EditBook(BookModel bookModel, int[] categoryId)
        {
            if (ModelState.IsValid)
            {
                var entity = _bookService.GetById(bookModel.bookId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.bookUrl = bookModel.bookUrl;
                entity.name = bookModel.name;
                entity.author = bookModel.author;
                entity.description = bookModel.description;
                entity.imgUrl = bookModel.imgUrl;
                entity.url = bookModel.url;
                _bookService.Update(entity, categoryId);
                return RedirectToAction("List");
            }
            ViewBag.AllCategories = _categoryService.GetAll();
            return View(bookModel);
        }

        ///
        [HttpGet]
        public IActionResult EditCategory(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var entity = _categoryService.GetByIdWithBooksList((int)id);
            if (entity == null)
            {
                return NotFound();
            }
            var model = new CategoryModel()
            {
                categoryId = entity.categoryId,
                name = entity.name,
                url = entity.url,
                Books = entity.BookCategories.Select(b => b.Book).ToList()

            };
            return View(model);
        }
        [HttpPost]
        public IActionResult EditCategory(CategoryModel categoryModel)
        {
            if (ModelState.IsValid)
            {
                var entity = _categoryService.GetById(categoryModel.categoryId);
                if (entity == null)
                {
                    return NotFound();
                }
                entity.name = categoryModel.name;

                entity.url = categoryModel.url;
                _categoryService.Update(entity);
                return RedirectToAction("CategoryList");
            }
            return View(categoryModel);
        }
        /// 


        public IActionResult DeleteBook(int bookId)
        {
            var entity = _bookService.GetById(bookId);
            if (entity != null)
            {
                _bookService.Delete(entity);
            }
            return RedirectToAction("List");
        }

        public IActionResult DeleteCategory(int categoryId)
        {
            var entity = _categoryService.GetById(categoryId);
            if (entity != null)
            {
                _categoryService.Delete(entity);
            }
            return RedirectToAction("CategoryList");
        }
        [HttpPost]
        public IActionResult DeleteBookFromCategory(int bookId, int categoryId)
        {
            _categoryService.DeleteBookFromCategory(bookId, categoryId);
            return RedirectToAction("CategoryList");
        }







    }
}