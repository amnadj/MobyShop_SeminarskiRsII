using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class PoslanaNarudzbaInsertRequest
    {
        public int KlijentId { get; set; }
        public int KorisnikId { get; set; }
        public bool Poslano { get; set; }
        public int NarudzbaId { get; set; }
        public DateTime Datum { get; set; }
    }
}
