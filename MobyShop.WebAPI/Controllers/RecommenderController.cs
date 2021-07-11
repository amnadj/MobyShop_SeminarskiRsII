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
    public class RecommenderController : ControllerBase
    {
        private readonly IRecommender _service;

        public RecommenderController(IRecommender service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetSlicneArtikle/{artikalID}")]
        public List<Artikli> GetSlicneArtikle(int artikalID)
        {
            return _service.GetSlicneArtikle(artikalID);
        }
    }
}
