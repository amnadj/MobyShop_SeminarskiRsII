using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    public class ModeliController : BaseCRUDController<Models.Modeli, object, ModeliInsertRequest, object>
    {
        public ModeliController(ICRUDService<Models.Modeli, object, ModeliInsertRequest, object> service) : base(service)
        {

        }
    }
}
