using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.Entity;
using Bus_Ticket_Booking.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.WebUI.Controllers
{
    public class TicketController : Controller
    {
        private IRouteService _routeService;
        private ITicketService _ticketService;
        private IBusService _busService;

        public TicketController(IRouteService routeService, ITicketService ticketService, IBusService busService)
        {
            _routeService = routeService;
            _ticketService = ticketService;
            _busService = busService;
        }
        public IActionResult Details(int id)
        {
            Route route = _routeService.GetRouteDetails(id);
            int seatNumber = _ticketService.GetSeatNumber(id);
            List<int> takenSeat = _ticketService.GetSeat(id);
            List<int> seatNumbers = new List<int>();
            int seats = _busService.GetSeatCapacity(id);

            for (int i = 1; i <= seats; i++)
            {
                seatNumbers.Add(i);
            }

            foreach (var item in takenSeat)
            {
                seatNumbers.Remove(item);
            }

            ViewBag.SeatNumber = seatNumber;
            ViewBag.SeatNumbers = new SelectList(seatNumbers);

            return View(route);

        }

        [HttpPost]
        public IActionResult Details(int routeId, double price, string startLocation, string endLocation, int seatNumber, string phoneNumber, string firstName, string lastName)
        {
            var entity = new Ticket()
            {
                CostumerName = firstName,
                CosturmerSurname = lastName,
                PhoneNumber = phoneNumber,
                TravelFrom = startLocation,
                TravelTo = endLocation,
                SeatNumber = seatNumber,
                Price = price,
                RouteId = routeId
            };

            _ticketService.Create(entity);
            return RedirectToAction("TicketDetails");
        }

        public IActionResult TicketDetails()
        {
            Ticket lastTicket = _ticketService.GetLastTicket();
            int routeId = _ticketService.GetId();
            string Time = _ticketService.GetTime(routeId);
            string Date = _ticketService.GetDate(routeId);

            var routeTicket = new RouteTicket()
            {
                Date = Date,
                Time = Time,
                Ticket = lastTicket
            };
            return View(routeTicket);
        }

    }
}
