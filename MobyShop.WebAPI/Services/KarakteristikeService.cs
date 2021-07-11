using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Model.Requests;

namespace MobyShop.WebAPI.Services
{
    public class KarakteristikeService : BaseCRUDService<Models.Karakteristike, object, Database.Karakteristike, KarakteristikeInsertRequest, object>
    {
        public KarakteristikeService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
