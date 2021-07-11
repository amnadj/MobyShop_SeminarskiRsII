using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class ZahtjeviStavke
    {
        [Key]
        public int Id { get; set; }
        public string Odgovor { get; set; }
        public int ZahtjevId { get; set; }
        public int KorisnikId { get; set; }


        public Zahtjevi Zahtjev { get; set; }
        public Korisnici Korisnik { get; set; }

    }
}
