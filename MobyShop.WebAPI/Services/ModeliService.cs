using AutoMapper;
using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public class ModeliService : BaseCRUDService<Models.Modeli, object, Database.Modeli, ModeliInsertRequest, object>
    {
        public ModeliService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
