using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EF_Core_02.Models;

namespace EF_Core_02.Controllers
{
    public class DoktorlarsController : Controller
    {
        private readonly HastaneAksamContext _context;

        public DoktorlarsController(HastaneAksamContext context)
        {
            _context = context;
        }

        // GET: Doktorlars
        public async Task<IActionResult> Index()
        {
            var hastaneAksamContext = _context.Doktorlars.Include(d => d.Bolum);
            return View(await hastaneAksamContext.ToListAsync());
        }

        // GET: Doktorlars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doktorlar = await _context.Doktorlars
                .Include(d => d.Bolum)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doktorlar == null)
            {
                return NotFound();
            }

            return View(doktorlar);
        }

        // GET: Doktorlars/Create
        public IActionResult Create()
        {
            ViewData["BolumId"] = new SelectList(_context.Bolumlers, "Id", "BolumAd");
            return View();
        }

        // POST: Doktorlars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SicilNo,AdSoyad,Tel,Mail,BolumId")] Doktorlar doktorlar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(doktorlar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BolumId"] = new SelectList(_context.Bolumlers, "Id", "BolumAd", doktorlar.BolumId);
            return View(doktorlar);
        }

        // GET: Doktorlars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doktorlar = await _context.Doktorlars.FindAsync(id);
            if (doktorlar == null)
            {
                return NotFound();
            }
            ViewData["BolumId"] = new SelectList(_context.Bolumlers, "Id", "BolumAd", doktorlar.BolumId);
            return View(doktorlar);
        }

        // POST: Doktorlars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SicilNo,AdSoyad,Tel,Mail,BolumId")] Doktorlar doktorlar)
        {
            if (id != doktorlar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(doktorlar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DoktorlarExists(doktorlar.Id))
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
            ViewData["BolumId"] = new SelectList(_context.Bolumlers, "Id", "BolumAd", doktorlar.BolumId);
            return View(doktorlar);
        }

        // GET: Doktorlars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var doktorlar = await _context.Doktorlars
                .Include(d => d.Bolum)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (doktorlar == null)
            {
                return NotFound();
            }

            return View(doktorlar);
        }

        // POST: Doktorlars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var doktorlar = await _context.Doktorlars.FindAsync(id);
            _context.Doktorlars.Remove(doktorlar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DoktorlarExists(int id)
        {
            return _context.Doktorlars.Any(e => e.Id == id);
        }
    }
}
