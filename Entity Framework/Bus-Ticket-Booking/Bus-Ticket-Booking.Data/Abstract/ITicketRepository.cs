using Bus_Ticket_Booking.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking.Data.Abstract
{
    public interface ITicketRepository : IRepository<Ticket>
    {
        int GetCountBySeat(int guzergahId);
        List<int> GetKoltuk(int guzergahId);
        Ticket GetSonKayit();
        int GetId();
        string GetTarih(int id);
        string GetSaat(int id);
    }
}
