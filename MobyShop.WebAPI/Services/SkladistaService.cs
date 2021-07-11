using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using MobyShop.Model.Requests;
using MobyShop.Models;

namespace MobyShop.WebAPI.Services
{
    public class SkladistaService : ISkladistaService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public SkladistaService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Skladista> Get(SkladistaSearchRequest search)
        {
            {
                var query = _context.Skladista.AsQueryable();

                if (!string.IsNullOrWhiteSpace(search?.Naziv))
                {
                    query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
                }

                if (!string.IsNullOrWhiteSpace(search?.Adresa))
                {
                    query = query.Where(x => x.Adresa.StartsWith(search.Adresa));
                }



                var list = query.ToList();

                return _mapper.Map<List<Skladista>>(list);

            }
        }
        public Skladista GetById(int id)
        {
            var entity = _context.Skladista.Find(id);

            return _mapper.Map<Skladista>(entity);

        }
        public void Insert(SkladistaInsertRequest request)
        {
            Database.Skladista novo = new Database.Skladista();

            novo.Naziv = request.Naziv;
            novo.Adresa = request.Adresa;
            novo.Opis = request.Opis;

            _context.Skladista.Add(novo);
            _context.SaveChanges();

        }
    }
}
