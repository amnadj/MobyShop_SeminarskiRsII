using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    public class NarudzbePracenjeInfoController : BaseCRUDController<Models.NarudzbePracenjeInfo, NarudzbePracenjeInfoSearchRequest, NarudzbePracenjeInfoInsertRequest, object>
    {
        public NarudzbePracenjeInfoController(ICRUDService<Models.NarudzbePracenjeInfo, NarudzbePracenjeInfoSearchRequest, NarudzbePracenjeInfoInsertRequest, object> service) : base(service)
        {

        }
    }
}