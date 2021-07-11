using MobyShop.Model.Requests;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface IKlijentiService
    {
        List<Models.Klijenti> Get(KlijentiSearchRequest search);
        Klijenti GetById(int id);
        void Insert(KlijentiInsertRequest request);

        void Update(int id, KlijentiInsertRequest request);

        Models.Klijenti Authenticiraj(string username, string pass);
    }
}
