using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Ocjene
    {
        public int OcjenaId { get; set; }
        public int ArtikalId { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

    }
}
