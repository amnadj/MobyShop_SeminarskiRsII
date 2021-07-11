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
    public class DobavljaciController : ControllerBase
    {
        private readonly IDobavljaciService _service;

        public DobavljaciController(IDobavljaciService service)
        {
            _service = service;
        }
        [HttpGet]
        public List<Dobavljaci> Get([FromQuery] DobavljaciSearchRequest request)
        {
            var list = _service.Get(request);
            return list;
        }
        [HttpGet("{id}")]
        public Dobavljaci GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public void Insert(DobavljaciInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] DobavljaciInsertRequest request)
        {
            _service.Update(id, request);
        }
    }
}
