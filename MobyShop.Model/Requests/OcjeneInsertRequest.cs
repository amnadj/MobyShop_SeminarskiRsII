using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class OcjeneInsertRequest
    {
       
        public int ArtikalId { get; set; }
      
        public int KlijentId { get; set; }
       
        public DateTime Datum { get; set; }
  
        public int Ocjena { get; set; }
    }
}
