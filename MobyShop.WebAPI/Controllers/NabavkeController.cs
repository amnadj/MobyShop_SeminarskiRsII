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
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class NabavkeController : ControllerBase
    {
        private readonly INabavkeService _service;

        public NabavkeController(INabavkeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Nabavke> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Nabavke GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public void Insert(NabavkeInsertRequest request)
        {
            _service.Insert(request);
        }
    }
}
