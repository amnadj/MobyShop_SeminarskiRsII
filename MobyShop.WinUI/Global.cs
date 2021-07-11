using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobyShop.Models;
namespace MobyShop.WinUI
{
    public class Global
    {
        public static Models.Korisnici PrijavljeniKorisnik { get; set; }

        public static bool Admin { get; set; }
    }
}
