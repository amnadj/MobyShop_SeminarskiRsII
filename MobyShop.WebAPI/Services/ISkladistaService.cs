using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobyShop.Model.Requests;
using MobyShop.Models;

namespace MobyShop.WebAPI.Services
{
    public interface ISkladistaService
    {
        List<Skladista> Get(SkladistaSearchRequest search);

        Skladista GetById(int id);
        void Insert(SkladistaInsertRequest request);
    }
}
