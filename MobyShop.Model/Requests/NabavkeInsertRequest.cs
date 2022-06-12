using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class NabavkeInsertRequest
    {

        public string BrojNabavke { get; set; }

        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }

        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }


        public List<StavkeNabavkeInsertRequest> stavke { get; set; } = new List<StavkeNabavkeInsertRequest>();
    }
}
