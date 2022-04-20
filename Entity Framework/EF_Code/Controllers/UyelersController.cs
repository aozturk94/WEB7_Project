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

    public class UyelersController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public UyelersController(KutuphaneAksamContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Uyelers.ToList());
        }

        public IActionResult Detail(int id)
        {
            Uyeler uye = _context.Uyelers.Find(id);
            return View(uye);
        }
               //GET-Düzeltme Sayfası
        public IActionResult Edit(int id)
        {
            var uye = _context.Uyelers.Find(id);
            return View(uye);
        }

        //POST-Düzeltme İşlemi
        [HttpPost]
        public IActionResult Edit(int id, [Bind("Id,Ad,Adres,Tel")] Uyeler uye)
        {

            _context.Update(uye); //Bu satır contexti güncelledi.
            _context.SaveChanges(); //Bu satır database'i güncelledi.
            return RedirectToAction("Index");
            //return View(tur);
        }
        public IActionResult Delete(int id)
        {
            var silinecekUye = _context.Uyelers.Find(id);
            return View(silinecekUye);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekUye = _context.Uyelers.Find(id);
            _context.Uyelers.Remove(silinecekUye);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Uyeler uye)
        {
            _context.Add(uye);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}