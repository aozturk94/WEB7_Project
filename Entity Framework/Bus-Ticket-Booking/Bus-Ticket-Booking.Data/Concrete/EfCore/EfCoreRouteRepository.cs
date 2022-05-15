using Bus_Ticket_Booking.Data.Abstract;
using Bus_Ticket_Booking.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Concrete.EfCore
{
    public class EfCoreRouteRepository : EfCoreGenericRepository<Route, Bus_Ticket_BookingContext>, IRouteRepository
    {
        public List<Route> GetDestination(string startLocation, string endLocation)
        {
            using (var context = new Bus_Ticket_BookingContext())
            {
                var start = context.Cities
                    .Where(i => i.CityName == startLocation)
                    .Select(i => i.CityName)
                    .ToList();

                var end = context.Cities
                    .Where(i => i.CityName == endLocation)
                    .Select(i => i.CityName)
                    .ToList();
                var routes = context.Routes
                    .FromSqlRaw($"Select * From Routes Where ((StartLocation='{start[0]}' or FirstRoute='{start[0]}' or SecondRoute='{start[0]}' or ThirdRoute='{start[0]}' ) and (EndLocation='{end[0]}' or ThirdRoute='{end[0]}' or SecondRoute='{end[0]}' or FirstRoute='{end[0]}' ))")
                    .ToList();

                return routes;
            }
        }

        public string GetEndLocation(string endLocation)
        {
            using (var context = new Bus_Ticket_BookingContext())
            {
                var end = context.Cities
                    .Where(i => i.CityName == endLocation)
                    .Select(i => i.CityName)
                    .ToList();
                return end[0];
            }
        }

        public int GetRouteByStartToEnd(string startLocation, string firstRoute, string secondRoute, string thirdRoute, string endLocation)
        {
            throw new NotImplementedException();
        }

        public Route GetRouteDetails(int id)
        {
            using (var context = new Bus_Ticket_BookingContext())
            {
                return context.Routes
                    .Where(i => i.RouteId == id)
                    .FirstOrDefault();
            }
        }

        public string GetStartLocation(string startLocation)
        {
            using (var context = new Bus_Ticket_BookingContext())
            {
                var start = context.Cities
                    .Where(i => i.CityName == startLocation)
                    .Select(i => i.CityName)
                    .ToList();
                return start[0];
            }
        }
    }
}
