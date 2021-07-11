using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class ZahtjeviStavke
    {
        public int Id { get; set; }
        public string Odgovor { get; set; }
        public int ZahtjevId { get; set; }
        public int KorisnikId { get; set; }


    }
}
