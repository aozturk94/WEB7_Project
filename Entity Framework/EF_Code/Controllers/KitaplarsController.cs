using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class KitaplarsController : Controller
    {
        private readonly KutuphaneAksamContext _context;

        public KitaplarsController(KutuphaneAksamContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }

        public IActionResult Details(string id)
        {
            var seciliKitap = _context.Kitaplars
            .Include(k => k.Turler)
            .Include(k => k.YayinEvleri)
            .Include(k => k.Yazarlar)
            .First(s => s.Isbn == id);

            return View(seciliKitap);
        }

        public IActionResult Edit(string id)
        {
            var seciliKitap = _context.Kitaplars.Find(id);
            ViewData["Tür"] = new SelectList(_context.Turlers,"Id","TurAd",seciliKitap.TurlerId);
            ViewData["Yazar"] = new SelectList(_context.Yazarlars,"Id","AdSoyad",seciliKitap.YazarlarId);
            ViewData["Yayınevi"] = new SelectList(_context.Yayinevleris,"Id","Ad",seciliKitap.YayinEvleriId);
            return View(seciliKitap);
        }

        [HttpPost]
        public IActionResult Edit(Kitaplar kitap)
        {
            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}