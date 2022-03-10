using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using elib_business.Abstract;
using elib_entity;
using Microsoft.AspNetCore.Mvc;

namespace elib_mvc.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        public ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"] != null)
            {
                ViewBag.SelectedCategory = RouteData?.Values["category"];
            }
            return View(_categoryService.GetAll());

        }
    }
}