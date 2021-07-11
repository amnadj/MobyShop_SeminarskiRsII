using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class NabavkeInsertRequest
    {
        [Required]
        [MinLength(4)]
        [RegularExpression(@"^[0-9]*$")]
        public string BrojNabavke { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime Datum { get; set; }
        public decimal IznosRacuna { get; set; }
        public decimal Pdv { get; set; }
        [MinLength(2)]
        public string Napomena { get; set; }
        public int SkladisteId { get; set; }
        public int KorisnikId { get; set; }
        public int DobavljacId { get; set; }


        public List<StavkeNabavkeInsertRequest> stavke { get; set; } = new List<StavkeNabavkeInsertRequest>();
    }
}
