using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _03_MVC_01.Controllers
{
    //Tüm controllerlar controller sınıfından miras alırlar.
    //Öyleyse classın bir requesti karşılayacak bir özellik kazanmasını
    //istiyorsak ilgili classı controller sınıfından türetmeliyiz.
    public class HomeController : Controller
    {
        //Action Metod: Eğer bir metot bir Controller içinde ise ona
        //Action method diyeceğiz, hatta çoğu kez Action deriz.

        //Bu Action uygulamanın ana dizinine istek gönderildiğinde tetiklenir.
        public IActionResult Index()
        {
            //Eğer view metodu bu şekilde kullanılırsa
            //(yani parantez içi boş bıraklırsa, parametresiz kullalınırsa)
            //İçinde bulunduğu Action'ın adındaki View 'ı arar ve onu döndürür.
            return View();
        }
    }
}
