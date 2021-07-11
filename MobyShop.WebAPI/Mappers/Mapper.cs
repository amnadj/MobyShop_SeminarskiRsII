using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Models;
using MobyShop.Model.Requests;

namespace MobyShop.WebAPI.Mappers
{
    public class Mapper : Profile
    {
        public Mapper()
        {


            //CreateMap<Model.Database.Zahtjevi, Model.Models.Zahtjevi>();
            //CreateMap<Model.Database.Zahtjevi, Model.Requests.ZahtjeviInsertRequest>().ReverseMap();
            CreateMap<Database.Uloge, Uloge>();

            CreateMap<Database.Korisnici, KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Korisnici, Korisnici>();

            CreateMap<Database.KorisniciUloge, KorisniciUloge>();


            CreateMap<Database.Klijenti, Klijenti>();
            CreateMap<Database.Klijenti, KlijentiInsertRequest>().ReverseMap();


            CreateMap<Database.Artikli, Artikli>();
            CreateMap<Database.Artikli, ArtikliInsertRequest>().ReverseMap();

            CreateMap<Database.Modeli, Modeli>();
            CreateMap<Database.Modeli, ModeliInsertRequest>().ReverseMap();

            CreateMap<Database.Proizvodjaci, Proizvodjaci>();
            CreateMap<Database.Proizvodjaci, ProizvodjaciInsertRequest>().ReverseMap();

            CreateMap<Database.Karakteristike, Karakteristike>();
            CreateMap<Database.Karakteristike, KarakteristikeInsertRequest>().ReverseMap();

            CreateMap<Database.Dobavljaci, Dobavljaci>();

            CreateMap<Database.Skladista, Skladista>();

            CreateMap<Database.PoslanaNarudzba, PoslanaNarudzba>();
            CreateMap<Database.PoslanaNarudzba, PoslanaNarudzbaUpdateRequest>().ReverseMap();
            CreateMap<Database.PoslanaNarudzba, PoslanaNarudzbaInsertRequest>().ReverseMap();

            CreateMap<Database.Ocjene, Ocjene>();
            CreateMap<Database.Ocjene, OcjeneInsertRequest>().ReverseMap();

            //CreateMap<Model.Database.ZahtjeviStavke, Model.Models.ZahtjeviStavke>();
            //CreateMap<Model.Database.ZahtjeviStavke, Model.Requests.ZahtjeviStavkeInsertRequest>().ReverseMap();





        }
    }
}
