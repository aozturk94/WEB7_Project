using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.ViewComponents
{
    public class CategoriesViewComponent : ViewComponent
    {
        private ICategoryService _categoryService;
        public CategoriesViewComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public IViewComponentResult Invoke()
        {
            if (RouteData.Values["category"] !=null)
            {
                ViewBag.SelectedCategory = RouteData.Values["category"];
            }
            if (RouteData.Values["category"] == null)
            {
                ViewBag.SelectedCategory = "";
            }
            return View(_categoryService.GetAll());
        }
    }
}
