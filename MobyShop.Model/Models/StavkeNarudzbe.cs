using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class StavkeNarudzbe
    {
        public int NarudzbaStavkaId { get; set; }
        public int NarudzbaId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public decimal? Popust { get; set; }
        public int ArtikalId { get; set; }
        public string Sifra { get; set; }
        public string Naziv { get; set; }
    }
}
