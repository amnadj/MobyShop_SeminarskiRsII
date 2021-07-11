using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Klijenti
    {
        public int KlijentId { get; set; }

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }

        public static explicit operator Klijenti(KlijentiInsertRequest v)
        {
            Klijenti k = new Klijenti
            {
                Ime = v.Ime,
                Prezime = v.Prezime,
                Email = v.Email,
                Telefon = v.Telefon,
                KorisnickoIme = v.KorisnickoIme
            };

            return k;
        }
    }
}
