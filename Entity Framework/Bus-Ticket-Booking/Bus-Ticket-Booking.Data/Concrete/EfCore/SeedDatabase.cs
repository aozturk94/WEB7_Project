using Bus_Ticket_Booking.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Concrete.EfCore
{
    public class SeedDatabase
    {
        public static void Seed()
        {
            var context = new Bus_Ticket_BookingContext();
            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Routes.Count() == 0)
                {
                    context.Routes.AddRange(Routes);
                }

                if (context.Tickets.Count() == 0)
                {
                    context.Tickets.AddRange(Tickets);

                }
                if (context.Cities.Count() == 0)
                {
                    context.Cities.AddRange(Cities);

                }
                if(context.Buses.Count() == 0)
                {
                    context.Buses.AddRange(BusSeats);
                }

                context.SaveChanges();
            }
        }
        private static City[] Cities =
{
            new City(){ CityName= "İstanbul"},
            new City(){ CityName= "Kocaeli"},
            new City(){ CityName= "Kütahya"},
            new City(){ CityName= "Afyon"},
            new City(){ CityName= "Isparta"},
            new City(){ CityName= "Samsun"},
            new City(){ CityName= "Ordu"},
            new City(){ CityName= "Rize"},
            new City(){ CityName= "Düzce"},
            new City(){ CityName= "Tokat"}

        };
        private static Route[] Routes =
        {
            new Route(){ StartLocation = "İstanbul", FirstRoute="Kocaeli", SecondRoute="Afyon", ThirdRoute="Kütahya", EndLocation="Isparta", Time="12:00", Price=75.0, CityId=1},
            new Route(){ StartLocation = "Isparta", FirstRoute="Kütahya", SecondRoute="Afyon", ThirdRoute="Kocaeli", EndLocation="İstanbul", Time="12:00", Price=75.0, CityId=5 }
        };

        private static Ticket[] Tickets =
        {
            new Ticket(){ PassengerFirstName="Abdullah", PassengerLastName="SEİSOĞLU", PassengerMail="aseisoglu@gmail.com", TravelFrom="Istanbul", TravelTo="Isparta", BusSeat=1, RouteId=1, BusId=1 },

            new Ticket(){ PassengerFirstName="Ahmet", PassengerLastName="ÖZTÜRK", PassengerMail="aozturk94@outlook.oom", TravelFrom="Isparta", TravelTo="Istanbul", BusSeat=2, RouteId=2, BusId=2 }
        };

        private static Bus[] BusSeats =
        {
            new Bus(){ BusSeatCapacity=30 },
            new Bus(){ BusSeatCapacity=30 },
        };              
    }
}
