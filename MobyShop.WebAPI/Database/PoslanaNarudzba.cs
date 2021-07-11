using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class PoslanaNarudzba
    {
        public int PoslanaNarudzbaId { get; set; }
        public int KlijentId { get; set; }
        public int KorisnikId { get; set; }
        public DateTime Datum { get; set; }
        public bool Poslano { get; set; }
        public int NarudzbaId { get; set; }


        public Klijenti Klijent { get; set; }
        public Korisnici Korisnik { get; set; }
        public Narudzba Narudzba { get; set; }
    }
}
