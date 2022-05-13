using Bus_Ticket_Booking.Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICityService _cityService;

        public HomeController(ICityService cityService)
        {
            _cityService = cityService;
        }
        public IActionResult Index()
        {
            return View(_cityService.GetAll());
        }

    }
}
