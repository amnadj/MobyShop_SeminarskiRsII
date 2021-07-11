using Microsoft.EntityFrameworkCore;
using MobyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI.Services
{
    public class StavkeNarudzbeService : IStavkeNarudzbeService
    {
        private readonly MyContext _context;
        public StavkeNarudzbeService(MyContext context)
        {
            _context = context;
        }
        public List<StavkeNarudzbe> Get()
        {
            var result = _context.NarudzbaStavke.Include(y => y.Artikal).ToList();

            List<StavkeNarudzbe> lista = new List<StavkeNarudzbe>();


            foreach (var item in result)
            {
                StavkeNarudzbe nova = new StavkeNarudzbe();
                nova.ArtikalId = item.Artikal.ArtikalId;
                nova.Cijena = item.Cijena;
                nova.Kolicina = item.Kolicina;
                nova.NarudzbaId = item.NarudzbaId;
                nova.NarudzbaStavkaId = item.NarudzbaStavkaId;
                nova.Naziv = item.Artikal.Naziv;
                nova.Popust = item.Popust;
                nova.Sifra = item.Artikal.Sifra;

                lista.Add(nova);
            }

            return lista;

        }

        public StavkeNarudzbe GetById(int id)
        {
            var item = _context.NarudzbaStavke.Where(x => x.NarudzbaStavkaId == id).Include(y => y.Artikal).SingleOrDefault();

            StavkeNarudzbe nova = new StavkeNarudzbe();
            nova.ArtikalId = item.Artikal.ArtikalId;
            nova.Cijena = item.Cijena;
            nova.Kolicina = item.Kolicina;
            nova.NarudzbaId = item.NarudzbaId;
            nova.NarudzbaStavkaId = item.NarudzbaStavkaId;
            nova.Naziv = item.Artikal.Naziv;
            nova.Popust = item.Popust;
            nova.Sifra = item.Artikal.Sifra;

            return nova;
        }
    }
}
