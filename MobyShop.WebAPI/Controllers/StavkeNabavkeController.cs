using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MobyShop.Models;
using MobyShop.WebAPI.Services;

namespace MobyShop.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StavkeNabavkeController : ControllerBase
    {
        private readonly IStavkeNabavkeService _service;

        public StavkeNabavkeController(IStavkeNabavkeService service)
        {
            _service = service;
        }

        [HttpGet]
        public List<StavkeNabavke> Get()
        {
            return _service.Get();
        }
    }
}
