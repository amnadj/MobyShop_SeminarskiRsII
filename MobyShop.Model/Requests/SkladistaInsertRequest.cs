using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class SkladistaInsertRequest
    {
        [Required]
        [MinLength(4)]
        public string Naziv { get; set; }
        [Required]
        [MinLength(4)]
        public string Adresa { get; set; }

        public string Opis { get; set; }
    }
}
