using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class SkladistaInsertRequest
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }

        public string Opis { get; set; }
    }
}
