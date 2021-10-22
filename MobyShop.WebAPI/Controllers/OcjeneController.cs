using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.Models;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    [Authorize]
    public class OcjeneController : BaseCRUDController<Ocjene, object, Model.Requests.OcjeneInsertRequest, object>
    {
        public OcjeneController(ICRUDService<Ocjene, object, OcjeneInsertRequest, object> service) : base(service)
        {

        }
    }
}
