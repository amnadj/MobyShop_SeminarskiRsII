using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }


        public List<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
