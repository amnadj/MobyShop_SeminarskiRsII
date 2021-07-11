using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    public class ProizvodjaciController : BaseCRUDController<Models.Proizvodjaci, object, ProizvodjaciInsertRequest, object>
    {
        public ProizvodjaciController(ICRUDService<Models.Proizvodjaci, object, ProizvodjaciInsertRequest, object> service) : base(service)
        {

        }
    }
}
