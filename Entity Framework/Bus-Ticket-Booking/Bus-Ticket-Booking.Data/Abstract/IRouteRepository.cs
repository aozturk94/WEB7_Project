using Bus_Ticket_Booking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Abstract
{
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
    public interface IRouteRepository
    {
        string GetNereden(string nereden);
        string GetNereye(string nereye);
        List<Route> GetYolculuk(string nereden, string nereye);
        int GetGuzergahByBslBts(string basl, string gz1, string gz2, string gz3, string bts);
        Route GetGuzergahDetails(int id);
=======
>>>>>>> Stashed changes
    public interface IRouteRepository : IRepository<Route>
    {
        string GetStartLocation(string startLocation);
        string GetEndLocation(string endLocation);
        List<Route> GetDestination(string startLocation, string endLocation);
        int GetRouteByStartToEnd(string startLocation, string firstRoute, string secondRoute, string thirdRoute, string endLocation);
        Route GetRouteDetails(int id);
<<<<<<< Updated upstream
=======
>>>>>>> 843b403cb27078a6be2db88d675a87b9c625b11d
>>>>>>> Stashed changes
    }
}
