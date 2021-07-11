using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Zahtjevi
    {
        public int Id { get; set; }
        public DateTime DatumZahtjeva { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int KlijentId { get; set; }
        public string Klijent { get; set; }


    }
}
