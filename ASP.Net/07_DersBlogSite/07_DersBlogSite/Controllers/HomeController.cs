using _07_DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var articles = new List<Article>
            {
                new Article{ID=1, ArticleName="HTML", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=2, ArticleName="CSS", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=3, ArticleName="Bootstrap", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=4, ArticleName="JavaScript", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=5, ArticleName="jQuery", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=6, ArticleName="React", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=7, ArticleName="C#", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=8, ArticleName="PHP", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=8, ArticleName="PHP", Content="With supporting text below as a natural lead-in to additional content"}
            };

            //Model bazlı veri taşıma.
            //return View(articles);


            //ViewBag kullanımı
            //ViewBag.Articles = articles;
            //return View();

            //ViewData kullanımı
            //ViewData["makaleler"] = articles;
            //return View();

            //TempData ile veri taşıma
            TempData["articles"] = articles;
            return View();
        }

        public ActionResult Detail()
        {
            var articles = new List<Article>
            {
                new Article{ID=1, ArticleName="HTML", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=2, ArticleName="CSS", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=3, ArticleName="Bootstrap", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=4, ArticleName="JavaScript", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=5, ArticleName="jQuery", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=6, ArticleName="React", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=7, ArticleName="C#", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=8, ArticleName="PHP", Content="With supporting text below as a natural lead-in to additional content"},
                new Article{ID=8, ArticleName="PHP", Content="With supporting text below as a natural lead-in to additional content"}
            };

            int id = Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            ViewBag.ID = articles[id - 1];
            return View();
        }
    }
}
