using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Database
{
    public class NarudzbePracenjeInfo
    {
        public int Id { get; set; }
        public int NarudzbaId { get; set; }
        public Narudzba Narudzba { get; set; }
        public StatusPracenja StatusPracenja { get; set; }
        public DateTime Datum { get; set; }
    }


    public enum StatusPracenja
    {
        Potvrđena,
        Poslana,
        Stigla,
        Otkazana
    }
}
