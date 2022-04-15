using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EF_Kütüphane_03.Models;

namespace EF_Kütüphane_03.Controllers
{
    public class OduncsController : Controller
    {
        private readonly KutuphaneAksamContext _context;

        public OduncsController(KutuphaneAksamContext context)
        {
            _context = context;
        }

        // GET: Oduncs
        public async Task<IActionResult> Index()
        {
            var kutuphaneAksamContext = _context.Oduncs.Include(o => o.KitaplarIsbnNavigation).Include(o => o.Uye);
            return View(await kutuphaneAksamContext.ToListAsync());
        }

        // GET: Oduncs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odunc = await _context.Oduncs
                .Include(o => o.KitaplarIsbnNavigation)
                .Include(o => o.Uye)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odunc == null)
            {
                return NotFound();
            }

            return View(odunc);
        }

        // GET: Oduncs/Create
        public IActionResult Create()
        {
            ViewData["KitaplarIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn");
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "AdSoyad");
            return View();
        }

        // POST: Oduncs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UyeId,KitaplarIsbn,VerilisTarihi,TeslimTarihi,Iptal")] Odunc odunc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odunc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KitaplarIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn", odunc.KitaplarIsbn);
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id", odunc.UyeId);
            return View(odunc);
        }

        // GET: Oduncs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odunc = await _context.Oduncs.FindAsync(id);
            if (odunc == null)
            {
                return NotFound();
            }
            ViewData["KitaplarIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn", odunc.KitaplarIsbn);
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id", odunc.UyeId);
            return View(odunc);
        }

        // POST: Oduncs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UyeId,KitaplarIsbn,VerilisTarihi,TeslimTarihi,Iptal")] Odunc odunc)
        {
            if (id != odunc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odunc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OduncExists(odunc.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["KitaplarIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn", odunc.KitaplarIsbn);
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id", odunc.UyeId);
            return View(odunc);
        }

        // GET: Oduncs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odunc = await _context.Oduncs
                .Include(o => o.KitaplarIsbnNavigation)
                .Include(o => o.Uye)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odunc == null)
            {
                return NotFound();
            }

            return View(odunc);
        }

        // POST: Oduncs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var odunc = await _context.Oduncs.FindAsync(id);
            _context.Oduncs.Remove(odunc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OduncExists(int id)
        {
            return _context.Oduncs.Any(e => e.Id == id);
        }
    }
}
