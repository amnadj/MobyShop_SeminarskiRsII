using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using MobyShop.Models;

namespace MobyShop.WebAPI.Database
{
    public class Narudzba
    {
        public Narudzba()
        {

            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            PoslanaNarudzba = new HashSet<PoslanaNarudzba>();

        }

        [Key]
        public int NarudzbaId { get; set; }
        public string BrojNarudzbe { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }

        public Korisnici Korisnik { get; set; }
        public Klijenti Klijent { get; set; }
        public Skladista Skladiste { get; set; }


        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<PoslanaNarudzba> PoslanaNarudzba { get; set; }
    }
}
