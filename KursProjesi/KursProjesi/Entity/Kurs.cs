using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursProjesi.Entity
{
   public class Kurs
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Sorumlu { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public int Sure { get; set; }
    }
}
