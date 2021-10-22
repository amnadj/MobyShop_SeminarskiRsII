using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using MobyShop.WebAPI.Services;
using MobyShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace MobyShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class KorisniciController : ControllerBase
    {
        private readonly IKorisniciService _service;
        public KorisniciController(IKorisniciService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Korisnici> Get([FromQuery] KorisniciSearchRequest request)
        {
            return _service.Get(request);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Korisnici Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }


        [HttpPost]
        public void Insert(KorisniciInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KorisniciInsertRequest request)
        {
            _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Korisnici GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
