using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Business.Concrete
{
    public class JobManager
    {   
        //Burada genel olarak tanımlamak istediğimiz her yerde ihtiyaç duyma ihtimalimiz olan metotlar yazılacak.
        public string MakeUrl(string url)
        {
            //Kendisie gelen string değerin içindeki Türkçe karakterler yerine Latin alfabesindeki karşılıklarını koyacak, boşlukların yerine "-" işareti koyacak, Nokta (.)ları kaldıracak. 
            url = url.Replace("I", "i");
            url = url.Replace("İ", "i");
            url = url.Replace("ı", "i");

            url = url.ToLower();

            url = url.Replace("ö", "o");
            url = url.Replace("ğ", "g");
            url = url.Replace("ş", "s");
            url = url.Replace("ü", "u");
            url = url.Replace("ç", "c");

            url = url.Replace(" ", "-");
            url = url.Replace(".", "");

            return url;
        }

        public string UploadImage(IFormFile file, string url)
        {
            var extension = Path.GetExtension(file.FileName);
            var randomName = $"{url}-{Guid.NewGuid()}{extension}";
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img", randomName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            return randomName;
        }
    }
}
