using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Dobavljaci
    {
        public Dobavljaci()
        {
            Nabavka = new HashSet<Nabavka>();
        }

        [Key]
        public int DobavljacId { get; set; }
        public string Naziv { get; set; }
        public string KontaktOsoba { get; set; }
        public string Adresa { get; set; }
        public string Telefon { get; set; }
        public string Fax { get; set; }
        public string Web { get; set; }
        public string Email { get; set; }
        public string ZiroRacuni { get; set; }
        public string Napomena { get; set; }
        public bool Status { get; set; }

        public ICollection<Nabavka> Nabavka { get; set; }
    }
}
