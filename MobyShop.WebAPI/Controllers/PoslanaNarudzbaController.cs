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
    public class PoslanaNarudzbaController : BaseCRUDController<Models.PoslanaNarudzba, object, PoslanaNarudzbaInsertRequest, PoslanaNarudzbaUpdateRequest>
    {
        public PoslanaNarudzbaController(ICRUDService<Models.PoslanaNarudzba, object, PoslanaNarudzbaInsertRequest, PoslanaNarudzbaUpdateRequest> service) : base(service)
        {

        }
    }
}
