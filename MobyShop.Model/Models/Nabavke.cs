using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Models
{
    public class Nabavke
    {

        public int NabavkaId { get; set; }
        public string BrojNabavke { get; set; }
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }
        public string Napomena { get; set; }

        public int DobavljacId { get; set; }
        public string NazivDobavljaca { get; set; }
        public string Telefon { get; set; }
        public string KontaktOsoba { get; set; }


        public int SkladisteId { get; set; }
        public string NazivSkladista { get; set; }

    }
}
