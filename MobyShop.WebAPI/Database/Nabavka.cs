using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Nabavka
    {
        public Nabavka()
        {
            NabavkaStavke = new HashSet<NabavkaStavke>();
        }

        [Key]
        public int NabavkaId { get; set; }
        public string BrojNabavke { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }
        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }

        public Dobavljaci Dobavljac { get; set; }
        public Korisnici Korisnik { get; set; }
        public Skladista Skladiste { get; set; }
        public ICollection<NabavkaStavke> NabavkaStavke { get; set; }
    }
}
