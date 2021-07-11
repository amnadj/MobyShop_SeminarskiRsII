using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Obavijesti
    {

        public int Id { get; set; }
        public string Naslov { get; set; }
        public string Text { get; set; }
        public byte[] Slika { get; set; }
        public int KorisnikId { get; set; }
    }
}
