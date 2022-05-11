using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class MiniShopAppController : Controller
    {
        private IProductService _productService;
        public MiniShopAppController(IProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category)
        {
            return View(_productService.GetAll());
        }
    }
}
