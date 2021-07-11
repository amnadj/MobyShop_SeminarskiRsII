using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Models;

namespace MobyShop.WebAPI.Services
{
    public interface IUlogeService
    {
        List<Uloge> Get();

        Uloge ProvjeriAdmin(int UlogaId);
        List<KorisniciUloge> SveUloge(int korisnikId);
    }
}
