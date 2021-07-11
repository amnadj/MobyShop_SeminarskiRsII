using AutoMapper;
using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
        public class ProizvodjaciService : BaseCRUDService<Models.Proizvodjaci, object, Database.Proizvodjaci, ProizvodjaciInsertRequest, object>
        {
            public ProizvodjaciService(MyContext context, IMapper mapper) : base(context, mapper)
            {

            }
        }
    
}
