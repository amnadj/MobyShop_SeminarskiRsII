using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Obavijesti
    {
        [Key]
        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }


        public Korisnici Korisnik { get; set; }
    }
}
