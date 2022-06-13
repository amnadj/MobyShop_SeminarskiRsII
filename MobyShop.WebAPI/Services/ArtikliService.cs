using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MobyShop.Model.Requests;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public class ArtikliService : IArtikliService
    {
        private readonly IMapper _mapper;
        private readonly MyContext _context;
        public ArtikliService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<Artikli> Get(ArtikliSearchRequest search)
        {
            var query = _context.Artikli.Include(y => y.Proizvodjaci).Include(z => z.Modeli).AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Naziv))
            {
                query = query.Where(x => x.Naziv.StartsWith(search.Naziv));
            }
            if ((!string.IsNullOrWhiteSpace((search?.ProizvodjacId).ToString())) && search?.ProizvodjacId != 0)
            {
                query = query.Where(x => x.ProizvodjacId == search.ProizvodjacId);
            }

            var list = query.ToList();
            List<Artikli> result = new List<Artikli>();

            foreach (var item in list)
            {

                Artikli nova = new Artikli();

                nova.ArtikalId = item.ArtikalId;
                nova.Cijena = item.Cijena;
                nova.KarakteristikeId = item.KarakteristikeId;
                nova.ModelId = item.ModelId;
                nova.Naziv = item.Naziv;
                nova.ProizvodjacId = item.ProizvodjacId;
                nova.Sifra = item.Sifra;
                nova.Slika = item.Slika;
                nova.SlikaThumb = item.SlikaThumb;
                nova.Status = item.Status;
                nova.Model = item.Modeli.Naziv;
                nova.Proizvodjac = item.Proizvodjaci.Naziv;



                result.Add(nova);
            }
            return result;
        }
        public void Insert(ArtikliInsertRequest request)
        {
            Database.Artikli entity = _mapper.Map<Database.Artikli>(request);


            _context.Artikli.Add(entity);
            _context.SaveChanges();

        }

        public Models.Artikli GetById(int id)
        {
            var entity = _context.Artikli.Find(id);

            return _mapper.Map<Models.Artikli>(entity);
        }
        public Models.Artikli GetBySifra(string sifra)
        {
            var entity = _context.Artikli.Where(x => x.Sifra.Equals(sifra)).FirstOrDefault();

            return _mapper.Map<Models.Artikli>(entity);
        }

        public void Update(int id, ArtikliInsertRequest request)
        {
            var entity = _context.Artikli.Find(id);
            _context.Artikli.Attach(entity);
            _context.Artikli.Update(entity);



            _mapper.Map(request, entity);

            _context.SaveChanges();


        }
    }
}