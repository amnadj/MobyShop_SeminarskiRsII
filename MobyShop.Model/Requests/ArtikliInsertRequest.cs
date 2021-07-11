using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class ArtikliInsertRequest
    {
        [Required]
        public string Naziv { get; set; }
        [Required]
        public string Sifra { get; set; }
        [Required]
        public decimal Cijena { get; set; }
        [Required]
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Status { get; set; }
        [Required]
        public int KarakteristikeId { get; set; }
        [Required]
        public int ModelId { get; set; }
        [Required]
        public int ProizvodjacId { get; set; }
    }
}
