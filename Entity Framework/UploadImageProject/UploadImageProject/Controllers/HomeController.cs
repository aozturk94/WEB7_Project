using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace UploadImageProject.Controllers
{
    public class HomeController : Controller
    {   
        public IActionResult Index()
        {
            return View();
        }  
        
        public IActionResult UploadImage()
        {

            return View();
        }

        [HttpPost]
        public IActionResult UploadImage(IFormFile file)
        {
            if(file != null && file.ContentType == "image/png")//eğer file boş değilse, yani dosya seçilmişse
            {
                string imageExtension = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageExtension;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");

                var stream = new FileStream(path,FileMode.Create);

                file.CopyTo(stream);
            }

            return RedirectToAction("UploadImage");
        }
    }
}
