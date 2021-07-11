using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MobyShop.Model.Requests;
using MobyShop.Models;
namespace MobyShop.WebAPI.Services
{
    public class DobavljaciService : IDobavljaciService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public DobavljaciService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Dobavljaci> Get(DobavljaciSearchRequest search)
        {
            {
                var query = _context.Dobavljaci.AsQueryable();

                if (!string.IsNullOrWhiteSpace(search?.Naziv))
                {
                    query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
                }



                var list = query.ToList();

                return _mapper.Map<List<Dobavljaci>>(list);

            }
        }
        public Dobavljaci GetById(int id)
        {
            var entity = _context.Dobavljaci.Find(id);

            return _mapper.Map<Models.Dobavljaci>(entity);

        }

        public void Insert(DobavljaciInsertRequest request)
        {
            Database.Dobavljaci novo = new Database.Dobavljaci();

            novo.Naziv = request.Naziv;
            novo.KontaktOsoba = request.KontaktOsoba;
            novo.Adresa = request.Adresa;
            novo.Telefon = request.Telefon;
            novo.Fax = request.Fax;
            novo.Web = request.Web;
            novo.Email = request.Email;
            novo.ZiroRacuni = request.ZiroRacuni;
            novo.Napomena = request.Napomena;
            novo.Status = request.Status;

            _context.Dobavljaci.Add(novo);
            _context.SaveChanges();
        }

        public void Update(int id, DobavljaciInsertRequest request)
        {
            var entity = _context.Dobavljaci.Find(id);
            _context.Dobavljaci.Attach(entity);
            _context.Dobavljaci.Update(entity);

            _mapper.Map(request, entity);

            _context.SaveChanges();

        }
    }
}
