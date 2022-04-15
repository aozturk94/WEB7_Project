using System;
using System.Collections.Generic;

#nullable disable

namespace EF_Core_02.Models
{
    public partial class Bolumler
    {
        public Bolumler()
        {
            Doktorlars = new HashSet<Doktorlar>();
        }

        public int Id { get; set; }
        public string BolumAd { get; set; }

        public virtual ICollection<Doktorlar> Doktorlars { get; set; }
    }
}
