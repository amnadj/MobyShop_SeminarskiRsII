using MobyShop.Model.Requests;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface IKorisniciService
    {
        List<Korisnici> Get(KorisniciSearchRequest search);

        Korisnici GetById(int id);

        void Insert(KorisniciInsertRequest request);

        void Update(int id, KorisniciInsertRequest request);

        Korisnici Authenticiraj(string username, string pass);
    }
}
