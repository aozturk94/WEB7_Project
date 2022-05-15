using Bus_Ticket_Booking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Abstract
{
    public interface IRouteRepository : IRepository<Route>
    {
        string GetStartLocation(string startLocation);
        string GetEndLocation(string endLocation);
        List<Route> GetDestination(string startLocation, string endLocation);
        int GetRouteByStartToEnd(string startLocation, string firstRoute, string secondRoute, string thirdRoute, string endLocation);
        Route GetRouteDetails(int id);
    }
}
