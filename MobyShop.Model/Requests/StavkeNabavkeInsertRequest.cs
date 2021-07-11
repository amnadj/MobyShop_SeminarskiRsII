using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class StavkeNabavkeInsertRequest
    {
        public int ArtikalId { get; set; }
        public string Artikal { get; set; }
        [Required]
        [MinLength(5)]
        public string Sifra { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]*$")]
        public int Kolicina { get; set; }
        public decimal Cijena { get; set; }
        public int NabavkaId { get; set; }
    }
}
