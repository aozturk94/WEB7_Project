using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Entity
{
    public class Route
    {
        public int RouteId { get; set; }
        public string StartLocation { get; set; }
        public string FirstRoute { get; set; }
        public string SecondRoute { get; set; }
        public string ThirdRoute { get; set; }
        public string EndLocation { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Time { get; set; }
        public double Price { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
