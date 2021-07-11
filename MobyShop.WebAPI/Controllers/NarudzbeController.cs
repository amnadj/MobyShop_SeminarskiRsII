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
    public class NarudzbeController : ControllerBase
    {
        private readonly INarudzbeService _service;
        public NarudzbeController(INarudzbeService service)
        {
            _service = service;

        }
        [HttpGet]
        public List<Narudzbe> Get([FromQuery] NarudzbeSearchRequest search)
        {
            return _service.Get(search);
        }
        [HttpGet("{id}")]
        public Narudzbe GetById(int id)
        {
            return _service.GetById(id);
        }
        [HttpPost]
        public void Insert(NarudzbeInsertRequest request)
        {
            _service.Insert(request);
        }
        [HttpPut("{id}")]
        public void Update(int id, NarudzbeInsertRequest request)
        {
            _service.Update(id, request);
        }
    }
}
