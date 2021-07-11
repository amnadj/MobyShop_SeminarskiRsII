using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Klijenti
    {
        public Klijenti()
        {
            Narudzbe = new HashSet<Narudzba>();
            Ocjene = new HashSet<Ocjene>();
            Zahtjevi = new HashSet<Zahtjevi>();
            PoslanaNarudzba = new HashSet<PoslanaNarudzba>();
        }

        [Key]
        public int KlijentId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }

        public ICollection<Zahtjevi> Zahtjevi { get; set; }
        public ICollection<Narudzba> Narudzbe { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<PoslanaNarudzba> PoslanaNarudzba { get; set; }
    }
}
