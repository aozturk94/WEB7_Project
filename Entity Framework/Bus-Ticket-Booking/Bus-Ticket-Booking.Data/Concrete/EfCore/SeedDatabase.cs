using Bus_Ticket_Booking.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new BookingContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);
                }
                if (context.Buses.Count() == 0)
                {
                    context.Buses.AddRange(Buses);
                }
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }
                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);
                }
                context.SaveChanges();
            }
        }

        private static City[] Cities =
        {
            new City() { CityName = "İstanbul" },
            new City() { CityName = "Kocaeli" },
            new City() { CityName = "Kütahya" },
            new City() { CityName = "Afyon" },
            new City() { CityName = "Isparta" },
            new City() { CityName = "Samsun" },
            new City() { CityName = "Ordu" },
            new City() { CityName = "Rize" },
            new City() { CityName = "Tokat" },
            new City() { CityName = "Adana" }
        };

        private static Bus[] Buses =
        {
            new Bus() { BusSeatCapacity = 20 }
        };

        private static Route[] Routes =
        {
            new Route() { StartLocation = "İstanbul", FirstStation = "Kocaeli", SecondStation = "Kütahya", ThirdStation = "Afyon", EndLocation = "Isparta", Date = "15.06.2022", Time = "19.00", Price = 110 },
            new Route() { StartLocation = "Rize", FirstStation = "Ordu", SecondStation = "Samsun", ThirdStation = "Kocaeli", EndLocation = "İstanbul", Date = "16.06.2022", Time = "19.00", Price = 180 }
        };

        private static Ticket[] Tickets =
        {
            new Ticket() { CostumerName = "Ahmet", CosturmerSurname = "ÖZTÜRK", PhoneNumber = "+905315076460", TravelFrom = "İstanbul", TravelTo = "Isparta", SeatNumber = 11, Price=110, RouteId = 1}
        };
    }
}
