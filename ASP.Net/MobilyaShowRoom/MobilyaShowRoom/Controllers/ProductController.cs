using Microsoft.AspNetCore.Mvc;
using MobilyaShowRoom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobilyaShowRoom.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = Repository.AllProduct();
            return View(products);
        }

        public IActionResult GetProductDetail()
        {
            int id = Convert.ToInt32(ControllerContext.RouteData.Values["id"]);
            List<Product> products = Repository.AllProduct();
            Product resultProduct = null;

            foreach (var product in products)
            {
                if (product.ID==id)
                {
                    resultProduct = product;
                    break;
                }
            }

            ViewBag.ResultProduct = resultProduct;
            return View();
        }
    }
}
