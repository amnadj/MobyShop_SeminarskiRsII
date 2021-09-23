using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.Models
{
    public class NarudzbePracenjeInfo
    {
        public int Id { get; set; }
        public int NarudzbaId { get; set; }
        public Narudzbe Narudzba { get; set; }
        public StatusPracenja StatusPracenja { get; set; }
        public DateTime Datum { get; set; }
    }


    public enum StatusPracenja
    {
        Kreirana,
        Potvrđena,
        Poslana,
        Stigla,
        Otkazana
    }
}
