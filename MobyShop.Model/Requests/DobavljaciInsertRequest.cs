using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class DobavljaciInsertRequest
    {
        [Required(AllowEmptyStrings = false)]
        public string Naziv { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string KontaktOsoba { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Adresa { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        [MinLength(3)]
        public string Email { get; set; }
        public string ZiroRacuni { get; set; }
        public string Napomena { get; set; }
        public bool Status { get; set; }
    }
}
