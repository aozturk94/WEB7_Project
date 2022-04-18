using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Code.Models;
using Microsoft.AspNetCore.Mvc;

namespace EF_Code.Controllers
{
    public class TurlersController : Controller
    {
        private readonly KutuphaneAksamContext _context;

        public TurlersController(KutuphaneAksamContext context)
        {
            _context = context;
        }

        //GET-Listeleme
        public IActionResult Index()
        {
            return View(_context.Turlers.ToList()); //List tipinde değerler gönderiliyor.
        }

        //GET-Detay Gösterme
        public IActionResult Details(int id)
        {
            Turler tur = _context.Turlers.Find(id);
            return View(tur);
        }

        //GET-Düzeltme Sayfası
        public IActionResult Edit(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }

        //POST-Düzeltme İşlemi
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,TurAd")] Turler tur)
        {

            _context.Update(tur); //Bu satır contexti güncelledi.
            _context.SaveChanges(); //Bu satır database'i güncelledi.
            return RedirectToAction("Index");
            //return View(tur);
        }
    }
}