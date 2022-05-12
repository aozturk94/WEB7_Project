using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Entity
{
    public class Ticket
    {
        public int TicketId { get; set; }
        public string PassengerFirstName { get; set; }
        public string PassengerLastName { get; set; }
        public string PassengerMail { get; set; }
        public string TravelFrom { get; set; }
        public string TravelTo { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int BusSeatId { get; set; }
        public double TicketPrice { get; set; }
        public int RouteId { get; set; }
        public Route Route { get; set; }
    }
}
