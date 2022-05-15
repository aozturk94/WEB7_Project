using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        private IRouteService _routeService;

        public HomeController(ICityService cityService, IRouteService routeService)
        {
            _cityService = cityService;
            _routeService = routeService;
        }
        public IActionResult Index(string startLocation, string endLocation)
        {
            if (startLocation == null || endLocation == null || startLocation == endLocation)
            {
                var cityModel = new TicketRoute()
                {
                    Cities = _cityService.GetAll(),
                    Routes = null
                };

                ViewBag.Cities = new SelectList(cityModel.Cities, "CityId", "CityName");
                return View(cityModel);
            }
            else
            {
                var cityModel = new TicketRoute()
                {
                    Cities = _cityService.GetAll(),
                    Routes = _routeService.GetDestination(startLocation, endLocation)
                };
                TempData["TravelFrom"] = _routeService.GetStartLocation(startLocation);
                TempData["TravelTo"] = _routeService.GetEndLocation(endLocation);
                ViewBag.Cities = new SelectList(cityModel.Cities, "CityId", "CityName");
                return View(cityModel);
            }

        }
    }
}
