using Bus_Ticket_Booking.Business.Abstract;
using Bus_Ticket_Booking.Data.Abstract;
using Bus_Ticket_Booking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Business.Concrete
{
    public class RouteManager : IRouteService
    {
        private IRouteRepository _routeRepository;
        public RouteManager(IRouteRepository routeRepository)
        {
            _routeRepository = routeRepository;
        }
        public void Create(Route entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Route entity)
        {
            throw new NotImplementedException();
        }

        public List<Route> GetAll()
        {
            throw new NotImplementedException();
        }

        public Route GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Route> GetDestination(string startLocation, string endLocation)
        {
            return _routeRepository.GetDestination(startLocation, endLocation);
        }

        public string GetEndLocation(string endLocation)
        {
            return _routeRepository.GetEndLocation(endLocation);
        }

        public int GetRouteByStartToEnd(string startLocation, string firstRoute, string secondRoute, string thirdRoute, string endLocation)
        {
            return _routeRepository.GetRouteByStartToEnd(startLocation, firstRoute, secondRoute, thirdRoute, endLocation);
        }

        public Route GetRouteDetails(int id)
        {
            throw new NotImplementedException();
        }

        public string GetStartLocation(string startLocation)
        {
            return _routeRepository.GetStartLocation(startLocation);
        }

        public void Update(Route entity)
        {
            throw new NotImplementedException();
        }
    }
}
