using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.Model.Requests
{
    public class NarudzbePracenjeInfoInsertRequest
    {
        public int NarudzbaId { get; set; }
        public StatusPracenja StatusPracenja { get; set; }
        public DateTime Datum { get; set; }
    }
}
