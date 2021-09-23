using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Model.Requests;
using MobyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace MobyShop.WebAPI.Services
{
    public class NarudzbePracenjeInfoService : BaseCRUDService<Models.NarudzbePracenjeInfo, NarudzbePracenjeInfoSearchRequest, Database.NarudzbePracenjeInfo, NarudzbePracenjeInfoInsertRequest, object>
    {
        public NarudzbePracenjeInfoService(MyContext context, IMapper mapper) : base(context, mapper)
        {

        }

        public override List<NarudzbePracenjeInfo> Get(NarudzbePracenjeInfoSearchRequest search)
        {
            var query = _context.NarudzbePracenjeInfo
                .AsQueryable();

            if (search?.NarudzbaId != 0)
            {
                query = query.Where(x => x.NarudzbaId == search.NarudzbaId);
            }

            var lista = query.ToList();
            return _mapper.Map<List<NarudzbePracenjeInfo>>(lista);
        }
    }
}
