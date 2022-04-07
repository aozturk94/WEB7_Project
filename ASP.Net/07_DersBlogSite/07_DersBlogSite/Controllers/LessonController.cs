using _07_DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _07_DersBlogSite.Controllers
{
    public class LessonController : Controller
    {
        public IActionResult Index()
        {
            var lessons = new List<Lesson>
            {
                new Lesson{ID=1, LessonName="HTML", CategoryName="FrontEnd"},
                new Lesson{ID=2, LessonName="CSS", CategoryName="FrontEnd"},
                new Lesson{ID=3, LessonName="Bootstrap", CategoryName="FrontEnd"},
                new Lesson{ID=4, LessonName="JavaScript", CategoryName="FrontEnd"},
                new Lesson{ID=5, LessonName="jQuery", CategoryName="FrontEnd"},
                new Lesson{ID=6, LessonName="React", CategoryName="FrontEnd"},
                new Lesson{ID=7, LessonName="C#", CategoryName="BackEnd"},
                new Lesson{ID=8, LessonName="PHP", CategoryName="BackEnd"}
            };

            return View(lessons);
        }
    }
}
