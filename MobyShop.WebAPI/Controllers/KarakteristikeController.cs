using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    [Authorize]
    public class KarakteristikeController : BaseCRUDController<Models.Karakteristike, object, KarakteristikeInsertRequest, object>
    {
        public KarakteristikeController(ICRUDService<Models.Karakteristike, object, KarakteristikeInsertRequest, object> service) : base(service)
        {

        }
    }
}