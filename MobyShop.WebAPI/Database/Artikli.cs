using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MobyShop.WebAPI.Database
{
    public class Artikli
    {
        public Artikli()
        {
            NarudzbaStavke = new HashSet<NarudzbaStavke>();
            Ocjene = new HashSet<Ocjene>();
            NabavkaStavke = new HashSet<NabavkaStavke>();
        }

        [Key]
        public int ArtikalId { get; set; }
        public string Naziv { get; set; }
        public string Sifra { get; set; }
        public decimal Cijena { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public bool? Status { get; set; }
        public int KarakteristikeId { get; set; }
        public int ProizvodjacId { get; set; }
        public int ModelId { get; set; }




        public Proizvodjaci Proizvodjaci { get; set; }
        public Modeli Modeli { get; set; }
        public Karakteristike Karakteristike { get; set; }
        public ICollection<NarudzbaStavke> NarudzbaStavke { get; set; }
        public ICollection<Ocjene> Ocjene { get; set; }
        public ICollection<NabavkaStavke> NabavkaStavke { get; set; }
    }
}
