using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Code.Controllers
{
    public class YayinevlerisController : Controller
    {
        private readonly KutuphaneAksamContext _context;

        public YayinevlerisController(KutuphaneAksamContext context)
        {
            _context = context;
        }
        
        //GET-Listeleme
        public IActionResult Index()
        {
            return View(_context.Yayinevleris.ToList()); //List tipinde değerler gönderiliyor.
        }

        //GET-Detay Gösterme
        public IActionResult Details(int id)
        {
            Yayinevleri yayinevi = _context.Yayinevleris.Find(id);
            return View(yayinevi);
        }

        //GET-Düzeltme Sayfası
        public IActionResult Edit(int id)
        {
            var yayinevi = _context.Yayinevleris.Find(id);
            return View(yayinevi);
        }

        //POST-Düzeltme İşlemi
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Ad,Adres,Tel")] Yayinevleri yayinevi)
        {

            _context.Update(yayinevi); //Bu satır contexti güncelledi.
            _context.SaveChanges(); //Bu satır database'i güncelledi.
            return RedirectToAction("Index");
            //return View(tur);
        }

        public IActionResult Delete(int id)
        {
            var silinecekYayinEvi = _context.Yayinevleris.Find(id);
            return View(silinecekYayinEvi);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekYayinEvi = _context.Yayinevleris.Find(id);
            _context.Yayinevleris.Remove(silinecekYayinEvi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Yayinevleri yayinevi)
        {
            _context.Add(yayinevi);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}