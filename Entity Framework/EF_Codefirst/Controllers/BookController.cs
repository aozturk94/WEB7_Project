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
    public class BookController : Controller
    {
        private readonly LibraryContext _context;

        public BookController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var books = _context.Books.Where(x => x.IsDeleted == false).ToList();
            return View(books);
        }

        public IActionResult GetDeletedBooks()
        {
            var books = _context.Books.Where(x => x.IsDeleted == true).ToList();
            return View("DeleteFromDB", books);
        }

        public IActionResult Details(int id)
        {
            Book book = _context.Books
                        .Include(k => k.Category)
                        .Include(k => k.Publisher)
                        .Include(k => k.Author)
                        .First(s => s.BookId == id);
            return View(book);
        }

        public IActionResult Edit(int id)
        {
            Book book = _context.Books.Find(id);
            ViewData["Category"] = new SelectList(_context.Categories, "CategoryId", "CategoryName", book.CategoryId);
            ViewData["Author"] = new SelectList(_context.Authors, "AuthorId", "AuthorName", book.AuthorId);
            ViewData["Author2"] = new SelectList(_context.Authors, "AuthorId", "AuthorSurname", book.AuthorId);
            ViewData["Publisher"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName", book.PublisherId);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(int id, Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Book deletedBook = _context.Books
                            .Include(d => d.Category)
                            .Include(d => d.Publisher)
                            .Include(d => d.Author)
                            .First(m => m.BookId == id);
            return View(deletedBook);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deletedBook = _context.Books.Find(id);
            deletedBook.IsDeleted = true;
            _context.Books.Update(deletedBook);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpPost, ActionName("DeleteFromDB")]
        public IActionResult DeleteFromDB(int id)
        {
            var deletedBook = _context.Books.Find(id);
            _context.Remove(deletedBook);
            _context.SaveChanges();
            return View();
        }

        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            ViewData["PublisherId"] = new SelectList(_context.Publishers, "PublisherId", "PublisherName");
            ViewData["AuthorId"] = new SelectList(_context.Authors, "AuthorId", "AuthorName");
            ViewData["AuthorId2"] = new SelectList(_context.Authors, "AuthorId", "AuthorSurname");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}