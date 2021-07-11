using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class NarudzbaStavke
    {
        [Key]
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int ArtikalId { get; set; }

        public Narudzba Narudzba { get; set; }
        public Artikli Artikal { get; set; }
    }
}
