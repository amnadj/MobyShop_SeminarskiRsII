using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Model.Requests;

namespace MobyShop.WebAPI.Services
{
    public interface INarudzbeService
    {
        List<Models.Narudzbe> Get(NarudzbeSearchRequest search);

        Models.Narudzbe GetById(int id);

        Models.Narudzbe Insert(NarudzbeInsertRequest request);

        void Update(int id, NarudzbeInsertRequest request);
    }
}
