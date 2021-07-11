using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.Models;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkladistaController : ControllerBase
    {

        private readonly ISkladistaService _service;

        public SkladistaController(ISkladistaService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Skladista> Get([FromQuery] SkladistaSearchRequest request)
        {
            var list = _service.Get(request);
            return list;
        }
        [HttpGet("{id}")]
        public Skladista GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public void Insert(SkladistaInsertRequest request)
        {
            _service.Insert(request);
        }
    }
}
