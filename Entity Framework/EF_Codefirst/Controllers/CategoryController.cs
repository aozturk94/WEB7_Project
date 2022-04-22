using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class CategoryController : Controller
    {
        private readonly LibraryContext _context;

        public CategoryController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var categories = _context.Categories.Where(x => x.IsDeleted == false).ToList();
            return View(categories);
        }

        public IActionResult GetDeletedCategories()
        {
            var categories = _context.Categories.Where(x => x.IsDeleted == true).ToList();
            return View("Index",categories);
        }

        public IActionResult Details(int id)
        {
            Category category = _context.Categories.Find(id);
            return View(category);
        }

        public IActionResult Edit(int id)
        {
            var category = _context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(int id, Category category)
        {
            _context.Categories.Update(category); //Bu satır contexti güncelledi.
            _context.SaveChanges(); //Bu satır database'i güncelledi.
            return RedirectToAction("Index");
            //return View(tur);
        }

        public IActionResult Delete(int id)
        {
            var deletedCategory = _context.Categories.Find(id);
            return View(deletedCategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deletedCategory = _context.Categories.Find(id);
            deletedCategory.IsDeleted = true;
            _context.Categories.Update(deletedCategory);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            _context.Add(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}