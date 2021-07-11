﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Uloge
    {
        public Uloge()
        {
            KorisniciUloge = new HashSet<KorisniciUloge>();
        }

        [Key]
        public int UlogaId { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }
    }
}
