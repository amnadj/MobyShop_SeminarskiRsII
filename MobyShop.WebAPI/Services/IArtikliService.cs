using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface IArtikliService
    {
        List<Models.Artikli> Get(ArtikliSearchRequest search);

        Models.Artikli GetById(int id);

        Models.Artikli GetBySifra(string sifra);

        void Insert(ArtikliInsertRequest request);
        void Update(int id, ArtikliInsertRequest request);
    }
}
