using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Modeli
    {
        public Modeli()
        {
            Artikli = new HashSet<Artikli>();
        }
        [Key]
        public int ModelId { get; set; }
        public string Naziv { get; set; }


        public ICollection<Artikli> Artikli { get; set; }
    }
}
