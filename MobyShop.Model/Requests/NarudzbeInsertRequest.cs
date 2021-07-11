using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class NarudzbeInsertRequest
    {
        public string BrojNarudzbe { get; set; }
        public int KlijentId { get; set; }
        public DateTime Datum { get; set; }
        public bool Status { get; set; }
        public bool? Otkazano { get; set; }
        public decimal IznosBezPdv { get; set; }
        public decimal IznosSaPdv { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }

        public List<StavkeNarudzbeInsertRequest> stavke { get; set; } = new List<StavkeNarudzbeInsertRequest>();
    }
}
