using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Models;
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

        public IActionResult List(string category, int page=1)
        {
            const int pageSize = 3;
            int totalItems = _productService.GetCountByCategory(category);

            var productListViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },
                Products = _productService.GetProductsByCategory(category, page, pageSize)
            };

            return View(productListViewModel);
        }

        public IActionResult Search(string searchString)
        {
            return View(_productService.GetSeachResult(searchString));
        }

        public IActionResult Details(string url)
        {   
            Product product = _productService.GetProductDetails(url);
            ProductDetailModel productDetail = new ProductDetailModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList()
            };
            return View(productDetail);
        }
    }
}
