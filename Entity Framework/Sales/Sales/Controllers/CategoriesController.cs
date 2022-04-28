using Microsoft.AspNetCore.Mvc;
using Sales.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new CategoryDAL();
            return View(categories.GetAll());
        }
    }
}
