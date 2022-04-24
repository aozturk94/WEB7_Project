using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_CodeFirst.Models.Context;
using EF_CodeFirst.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Controllers
{
    public class AuthorController : Controller
    {
        private readonly LibraryContext _context;

        public AuthorController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var authors = _context.Authors.Where(x => x.IsDeleted == false).ToList();
            return View(authors);
        }

        public IActionResult GetDeletedAuthors()
        {
            var authors = _context.Authors.Where(x => x.IsDeleted == true).ToList();
            return View("Index", authors);
        }

        public IActionResult Details(int id)
        {
            Author author = _context.Authors.Find(id);
            return View(author);
        }

        public IActionResult Edit(int id)
        {
            Author author = _context.Authors.Find(id);
            return View(author);
        }

        [HttpPost]
        public IActionResult Edit(int id, Author author)
        {
            _context.Authors.Update(author);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            Author deletedAuthor = _context.Authors.Find(id);
            return View(deletedAuthor);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deletedAuthor = _context.Authors.Find(id);
            deletedAuthor.IsDeleted = true;
            _context.Authors.Update(deletedAuthor);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _context.Add(author);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}