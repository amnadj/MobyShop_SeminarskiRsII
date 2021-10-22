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
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class KlijentiController : ControllerBase
    {
        private readonly IKlijentiService _service;
        public KlijentiController(IKlijentiService service)
        {
            _service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public List<Models.Klijenti> Get([FromQuery] KlijentiSearchRequest request)
        {
            return _service.Get(request);
        }
        [HttpGet]
        [AllowAnonymous]
        [Route("Authenticiraj/{username},{password}")]
        public Models.Klijenti Authenticiraj(string username, string password)
        {
            return _service.Authenticiraj(username, password);
        }


        [HttpPost]
        [AllowAnonymous]
        public void Insert(KlijentiInsertRequest request)
        {
            _service.Insert(request);
        }

        [HttpPut("{id}")]
        public void Update(int id, [FromBody] KlijentiInsertRequest request)
        {
            _service.Update(id, request);
        }

        [HttpGet("{id}")]
        public Models.Klijenti GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
