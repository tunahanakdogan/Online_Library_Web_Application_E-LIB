using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_mvc.Identity;
using elib_mvc.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace elib_mvc.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> _userManager;
        private SignInManager<User> _signInManager;
        private IFavListService _favListService;
        public AccountController(UserManager<User> userManager, SignInManager<User> signInManager, IFavListService favListService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _favListService = favListService;
        }
        [HttpGet]
        public IActionResult Login(string url = null)
        {
            return View(new LoginModel()
            {
                urlToGo = url
            });
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = await _userManager.FindByNameAsync(model.userName);
            if (user == null)
            {
                ModelState.AddModelError("", "There isn't a user with this informations please register");
                return View(model);
            }
            var result = await _signInManager.PasswordSignInAsync(user, model.password, false, false);
            if (result.Succeeded)
            {
                if (model.urlToGo == null)
                {
                    return RedirectToAction("Index", "Home");
                }
                return Redirect(model.urlToGo);
            }
            ModelState.AddModelError("", "Password is incorrect please check it.");
            return View(model);
        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/home/index");
        }
        [HttpGet]
        public IActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var user = new User()
            {
                UserName = model.userName,
                Email = model.email,
                firstName = model.firstName,
                lastName = model.lastName
            };
            var result = await _userManager.CreateAsync(user, model.password);
            if (result.Succeeded)
            {
                _favListService.InitializeList(user.Id);
                return RedirectToAction("Login", "Account");
            }

            return View(model);
        }
    }
}