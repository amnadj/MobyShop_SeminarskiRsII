using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class KarakteristikeInsertRequest
    {
        
        public bool Novo { get; set; }
        public string OperativniSistem { get; set; }
        public decimal Kamera { get; set; }
        public decimal Ram { get; set; }
        public decimal Memorija { get; set; }
        public decimal Procesor { get; set; }
    }
}
