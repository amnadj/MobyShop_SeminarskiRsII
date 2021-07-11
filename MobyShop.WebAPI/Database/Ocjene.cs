using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Ocjene
    {
        [Key]
        public int OcjenaId { get; set; }
        public int ArtikalId { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public int Ocjena { get; set; }

        public Klijenti Klijent { get; set; }
        public Artikli Artikal { get; set; }
    }
}
