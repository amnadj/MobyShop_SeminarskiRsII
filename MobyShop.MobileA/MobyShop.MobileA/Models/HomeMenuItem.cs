using System;
using System.Collections.Generic;
using System.Text;

namespace MobyShop.MobileA.Models
{
    public enum MenuItemType
    {
        Browse,
        Kontakt,
        Artikli,
        Narudzba,
        Obavijesti,
        Zahtjevi,
        HistorijaZahtjeva,
        HistorijaNarudzbi
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
