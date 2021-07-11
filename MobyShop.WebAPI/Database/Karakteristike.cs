using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Karakteristike
    {
        public Karakteristike()
        {
            Artikli = new HashSet<Artikli>();
        }
        [Key]
        public int KarakteristikeId { get; set; }
        public bool Novo { get; set; }
        public string OperativniSistem { get; set; }
        public decimal Kamera { get; set; }
        public decimal Ram { get; set; }
        public decimal Memorija { get; set; }
        public decimal Procesor { get; set; }


        public ICollection<Artikli> Artikli { get; set; }
    }
}
