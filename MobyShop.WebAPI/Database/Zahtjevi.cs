using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Zahtjevi
    {
        public Zahtjevi()
        {
            ZahtjeviStavke = new HashSet<ZahtjeviStavke>();
        }
        [Key]
        public int Id { get; set; }
        public DateTime DatumZahtjeva { get; set; }
        public string Naslov { get; set; }
        public string Opis { get; set; }
        public int KlijentId { get; set; }




        public Klijenti Klijent { get; set; }
        public ICollection<ZahtjeviStavke> ZahtjeviStavke { get; set; }

    }
}
