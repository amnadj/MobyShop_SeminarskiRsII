using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Narudzbe
    {
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KlijentId { get; set; }
        public string KlijentKorisnickoIme { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int SkladisteId { get; set; }
        public string NazivSkladista { get; set; }
        public int KorisnikId { get; set; }
        public string KorisnikKorisnickoIme { get; set; }
    }
}
