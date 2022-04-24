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
    public class PublisherController : Controller
    {
        private readonly LibraryContext _context;

        public PublisherController(LibraryContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var publisher = _context.Publishers.Where(x => x.IsDeleted == false).ToList();
            return View(publisher);
        }

        public IActionResult GetDeletedPublisher()
        {
            var publisher = _context.Publishers.Where(x => x.IsDeleted == true).ToList();
            return View("Index", publisher);
        }

        public IActionResult Details(int id)
        {
            Publisher publisher = _context.Publishers.Find(id);
            return View(publisher);
        }

        public IActionResult Edit(int id)
        {
            Publisher publisher = _context.Publishers.Find(id);
            return View(publisher);
        }

        [HttpPost]
        public IActionResult Edit(int id, Publisher publisher)
        {
            _context.Publishers.Update(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Delete(int id)
        {
            Publisher deletedPublisher = _context.Publishers.Find(id);
            return View(deletedPublisher);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deletedPublisher = _context.Publishers.Find(id);
            deletedPublisher.IsDeleted = true;
            _context.Publishers.Update(deletedPublisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Publisher publisher)
        {
            _context.Add(publisher);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
