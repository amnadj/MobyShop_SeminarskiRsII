using AutoMapper;
using MobyShop.Model.Requests;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public class OcjeneService : BaseCRUDService<Ocjene, object, Database.Ocjene, OcjeneInsertRequest, object>
    {
        public OcjeneService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
