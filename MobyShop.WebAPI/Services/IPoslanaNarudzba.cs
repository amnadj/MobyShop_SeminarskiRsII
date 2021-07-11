using AutoMapper;
using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public class IPoslanaNarudzba : BaseCRUDService<Models.PoslanaNarudzba, object, Database.PoslanaNarudzba, PoslanaNarudzbaInsertRequest, PoslanaNarudzbaUpdateRequest>
    {
        public IPoslanaNarudzba(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }

    }
}
