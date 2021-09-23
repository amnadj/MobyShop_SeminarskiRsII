using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Model.Requests;

namespace MobyShop.WebAPI.Services
{
    public class NarudzbePracenjeInfoService : BaseCRUDService<Models.NarudzbePracenjeInfo, NarudzbePracenjeInfoSearchRequest, Database.NarudzbePracenjeInfo, NarudzbePracenjeInfoInsertRequest, object>
    {
        public NarudzbePracenjeInfoService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }
    }
}
