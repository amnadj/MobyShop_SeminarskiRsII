using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Korisnici
    {
        public Korisnici()
        {
            Narudzba = new HashSet<Narudzba>();
            KorisniciUloge = new HashSet<KorisniciUloge>();
            Nabavka = new HashSet<Nabavka>();
            ZahtjeviStavke = new HashSet<ZahtjeviStavke>();
            Obavijesti = new HashSet<Obavijesti>();
            PoslanaNarudzba = new HashSet<PoslanaNarudzba>();
        }

        [Key]
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public string LozinkaHash { get; set; }
        public string LozinkaSalt { get; set; }


        public ICollection<ZahtjeviStavke> ZahtjeviStavke { get; set; }
        public ICollection<Narudzba> Narudzba { get; set; }
        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
        public ICollection<Nabavka> Nabavka { get; set; }
        public ICollection<Obavijesti> Obavijesti { get; set; }
        public ICollection<PoslanaNarudzba> PoslanaNarudzba { get; set; }
    }
}
