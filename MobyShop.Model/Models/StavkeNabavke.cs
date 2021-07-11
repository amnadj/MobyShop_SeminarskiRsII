using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class StavkeNabavke
    {
        public int StavkeNabavkeId { get; set; }
        public int ArtikalId { get; set; }
        public int NabavkaId { get; set; }
        public string Artikal { get; set; }
        public string Proizvodjac { get; set; }
        public string Model { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }

    }
}
