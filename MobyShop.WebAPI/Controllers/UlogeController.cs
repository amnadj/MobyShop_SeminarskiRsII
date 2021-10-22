using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.WebAPI.Services;
using MobyShop.Models;
using Microsoft.AspNetCore.Authorization;

namespace MobyShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class UlogeController : ControllerBase
    {
        private readonly IUlogeService _service;

        public UlogeController(IUlogeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Uloge> Get()
        {
            return _service.Get();
        }
        [HttpGet]
        [Route("ProvjeriAdmin/{UlogaId}")]
        public Uloge ProvjeriAdmin(int UlogaId)
        {
            return _service.ProvjeriAdmin(UlogaId);
        }

        [HttpGet]
        [Route("SveUloge/{korisnikId}")]
        public List<KorisniciUloge> SveUloge(int korisnikId)
        {
            return _service.SveUloge(korisnikId);
        }
    }
}
