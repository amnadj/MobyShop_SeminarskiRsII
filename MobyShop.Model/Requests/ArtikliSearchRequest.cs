using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class ArtikliSearchRequest
    {
        public string Naziv { get; set; }
        public int ProizvodjacId { get; set; }
    }
}
