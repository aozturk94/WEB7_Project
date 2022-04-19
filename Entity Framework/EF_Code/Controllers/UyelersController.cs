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
    }
}