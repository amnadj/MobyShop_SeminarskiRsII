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
    public class NarudzbeService : INarudzbeService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;


        public NarudzbeService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;

        }
        public List<Narudzbe> Get(NarudzbeSearchRequest search)
        {

            var query = _context.Narudzba
                .Include(y => y.Klijent).Include(z => z.Korisnik).Include(p => p.Skladiste)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.BrojNarudzbe))
            {
                query = query.Where(x => x.BrojNarudzbe.StartsWith(search.BrojNarudzbe));


            }

            var lista = query.ToList();

            List<Narudzbe> result = new List<Narudzbe>();

            foreach (var item in lista)
            {

                Narudzbe nova = new Narudzbe();

                nova.BrojNarudzbe = item.BrojNarudzbe;
                nova.Datum = item.Datum;
                nova.IznosBezPdv = item.IznosBezPdv;
                nova.IznosSaPdv = item.IznosSaPdv;
                nova.KlijentId = item.KlijentId;
                nova.KlijentKorisnickoIme = item.Klijent.KorisnickoIme;
                nova.KorisnikId = item.Korisnik.KorisnikId;
                nova.KorisnikKorisnickoIme = item.Korisnik.KorisnickoIme;
                nova.NarudzbaId = item.NarudzbaId;
                nova.NazivSkladista = item.Skladiste.Naziv;
                nova.Otkazano = item.Otkazano;
                nova.SkladisteId = item.SkladisteId;
                nova.Status = item.Status;


                result.Add(nova);


            }

            return result;
        }

        public Narudzbe GetById(int id)
        {
            var item = _context.Narudzba.Where(z => z.NarudzbaId == id)
                .Include(x => x.Klijent).Include(y => y.Korisnik).Include(p => p.Skladiste)
                .SingleOrDefault();

            Narudzbe nova = new Narudzbe();

            nova.BrojNarudzbe = item.BrojNarudzbe;
            nova.Datum = item.Datum;
            nova.IznosBezPdv = item.IznosBezPdv;
            nova.IznosSaPdv = item.IznosSaPdv;
            nova.KlijentId = item.KlijentId;
            nova.KlijentKorisnickoIme = item.Klijent.KorisnickoIme;
            nova.KorisnikId = item.Korisnik.KorisnikId;
            nova.KorisnikKorisnickoIme = item.Korisnik.KorisnickoIme;
            nova.NarudzbaId = item.NarudzbaId;
            nova.NazivSkladista = item.Skladiste.Naziv;
            nova.Otkazano = item.Otkazano;
            nova.SkladisteId = item.SkladisteId;
            nova.Status = item.Status;

            return nova;
        }

        public Models.Narudzbe Insert(NarudzbeInsertRequest request)
        {

            Database.Narudzba nova = new Database.Narudzba();

            nova.BrojNarudzbe = request.BrojNarudzbe;
            nova.Datum = request.Datum;

            if (request.IznosBezPdv > 0)
            {
                nova.IznosBezPdv = request.IznosBezPdv;
            }
            if (request.IznosSaPdv > 0)
            {
                nova.IznosSaPdv = request.IznosSaPdv;
            }

            nova.Otkazano = request.Otkazano;
            nova.Status = request.Status;


            nova.KorisnikId = request.KorisnikId;
            nova.KlijentId = request.KlijentId;
            nova.SkladisteId = request.SkladisteId;


            _context.Narudzba.Add(nova);
            _context.SaveChanges();

            foreach (var item in request.stavke)
            {

                Database.NarudzbaStavke stavka = new Database.NarudzbaStavke();
                stavka.NarudzbaId = nova.NarudzbaId;
                stavka.Popust = item.Popust;
                stavka.Kolicina = item.Kolicina;
                stavka.Cijena = item.Cijena;
                stavka.ArtikalId = item.ArtikalId;


                _context.NarudzbaStavke.Add(stavka);
                _context.SaveChanges();
            }

            return _mapper.Map<Narudzbe>(nova);
        }
        public void Update(int id, NarudzbeInsertRequest request)
        {

            Database.Narudzba nova = _context.Narudzba.Where(x => x.NarudzbaId == id).Include(x => x.Klijent).Include(y => y.Korisnik).Include(p => p.Skladiste)
                .SingleOrDefault();

            nova.BrojNarudzbe = request.BrojNarudzbe;
            nova.Datum = request.Datum;

            if (request.IznosBezPdv > 0)
            {
                nova.IznosBezPdv = request.IznosBezPdv;
            }
            if (request.IznosSaPdv > 0)
            {
                nova.IznosSaPdv = request.IznosSaPdv;
            }

            nova.Otkazano = request.Otkazano;
            nova.Status = request.Status;


            nova.KorisnikId = request.KorisnikId;
            nova.KlijentId = request.KlijentId;
            nova.SkladisteId = request.SkladisteId;

            _context.Narudzba.Attach(nova);
            _context.Narudzba.Update(nova);


            _context.SaveChanges();


        }
    }
}
