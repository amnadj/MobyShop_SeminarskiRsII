using Microsoft.AspNetCore.Mvc;
using MobyShop.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public interface IDobavljaciService
    {
        List<Models.Dobavljaci> Get(DobavljaciSearchRequest search);

        Models.Dobavljaci GetById(int id);
        void Insert(DobavljaciInsertRequest request);
        void Update(int id, [FromBody] DobavljaciInsertRequest request);
    }
}
