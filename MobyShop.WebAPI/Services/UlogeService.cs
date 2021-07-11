using AutoMapper;
using MobyShop.Model;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public class UlogeService : IUlogeService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public UlogeService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Uloge> Get()
        {
            List<Uloge> result = new List<Uloge>();
            var lista = _context.Uloge.ToList();

            foreach (var item in lista)
            {
                Uloge uloga = new Uloge();
                uloga.Naziv = item.Naziv;
                uloga.Opis = item.Opis;
                uloga.UlogaId = item.UlogaId;

                result.Add(uloga);
            }

            return result;
        }

        public Uloge ProvjeriAdmin(int UlogaId)
        {
            var lista = _context.Uloge.ToList();
            Uloge result = new Uloge();

            foreach (var item in lista)
            {
                if (item.UlogaId == UlogaId)
                {
                    if (item.Naziv.Contains("Admin"))
                    {
                        result.Naziv = item.Naziv;
                        result.Opis = item.Opis;
                        result.UlogaId = item.UlogaId;

                        return result;
                    }

                }
            }
            return null;
        }

        public List<KorisniciUloge> SveUloge(int korisnikId)
        {
            var lista = _context.KorisniciUloge.Where(x=>x.KorisnikId == korisnikId).ToList();

            return _mapper.Map<List<KorisniciUloge>>(lista);
        }

    }
}
