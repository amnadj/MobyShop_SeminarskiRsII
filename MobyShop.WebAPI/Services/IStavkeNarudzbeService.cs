using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface IStavkeNarudzbeService
    {
        List<Models.StavkeNarudzbe> Get();

        Models.StavkeNarudzbe GetById(int id);
    }
}
