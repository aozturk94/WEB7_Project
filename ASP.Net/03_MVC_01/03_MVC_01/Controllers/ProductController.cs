using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult GetProducts()
        {
            int a = 15;
            if (a < 10)
            {
                return View("UrunleriGetir");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
