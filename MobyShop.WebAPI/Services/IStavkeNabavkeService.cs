using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface IStavkeNabavkeService
    {
        List<Models.StavkeNabavke> Get();
    }
}
