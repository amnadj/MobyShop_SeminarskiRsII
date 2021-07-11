using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface INabavkeService
    {
        List<Models.Nabavke> Get();

        Models.Nabavke GetById(int id);

        void Insert(NabavkeInsertRequest request);
    }
}
