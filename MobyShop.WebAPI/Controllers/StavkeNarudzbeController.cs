using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class StavkeNarudzbeController : ControllerBase
    {
        private readonly IStavkeNarudzbeService _service;
        public StavkeNarudzbeController(IStavkeNarudzbeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<Models.StavkeNarudzbe> Get()
        {
            return _service.Get();
        }
        [HttpGet("{id}")]
        public Models.StavkeNarudzbe GetById(int id)
        {
            return _service.GetById(id);
        }
    }
}
