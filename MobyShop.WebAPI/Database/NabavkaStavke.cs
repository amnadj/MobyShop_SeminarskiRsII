using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class NabavkaStavke
    {
        [Key]
        public int NabavkaStavkeId { get; set; }
        public int NabavkaId { get; set; }
        public int ArtikalId { get; set; }
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }

        public Artikli Artikal { get; set; }
        public Nabavka Nabavka { get; set; }
    }
}
