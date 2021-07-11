using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MobyShop.Model.Requests;
using MobyShop.Models;

namespace MobyShop.WebAPI.Services
{
    public class NabavkeService : INabavkeService
    {
        private readonly MyContext _context;
        public NabavkeService(MyContext context)
        {
            _context = context;
        }
        public List<Nabavke> Get()
        {
            var list = _context.Nabavka
                .Include(x => x.Dobavljac).Include(y => y.Skladiste)
                .ToList();

            var listanabavki = new List<Nabavke>();

            foreach (var item in list)
            {


                Nabavke nabavka = new Nabavke();

                nabavka.BrojNabavke = item.BrojNabavke;
                nabavka.Datum = item.Datum;
                nabavka.DobavljacId = item.DobavljacId;
                nabavka.IznosRacuna = item.IznosRacuna;
                nabavka.KontaktOsoba = item.Dobavljac.KontaktOsoba;
                nabavka.NabavkaId = item.NabavkaId;
                nabavka.Napomena = item.Napomena;
                nabavka.NazivDobavljaca = item.Dobavljac.Naziv;
                nabavka.NazivSkladista = item.Skladiste.Naziv;
                nabavka.Pdv = item.Pdv;
                nabavka.SkladisteId = item.SkladisteId;
                nabavka.Telefon = item.Dobavljac.Telefon;

                listanabavki.Add(nabavka);

            }

            return listanabavki;

        }

        public Nabavke GetById(int id)
        {
            Database.Nabavka item = _context.Nabavka.Where(x => x.NabavkaId == id)
                .Include(y => y.Skladiste).Include(z => z.Dobavljac)
                .SingleOrDefault();


            Nabavke nabavka = new Nabavke();

            nabavka.BrojNabavke = item.BrojNabavke;
            nabavka.Datum = item.Datum;
            nabavka.DobavljacId = item.DobavljacId;
            nabavka.IznosRacuna = item.IznosRacuna;
            nabavka.KontaktOsoba = item.Dobavljac.KontaktOsoba;
            nabavka.NabavkaId = item.NabavkaId;
            nabavka.Napomena = item.Napomena;
            nabavka.NazivDobavljaca = item.Dobavljac.Naziv;
            nabavka.NazivSkladista = item.Skladiste.Naziv;
            nabavka.Pdv = item.Pdv;
            nabavka.SkladisteId = item.SkladisteId;
            nabavka.Telefon = item.Dobavljac.Telefon;

            return nabavka;
        }

        public void Insert(NabavkeInsertRequest request)
        {
            Database.Nabavka nova = new Database.Nabavka();

            nova.BrojNabavke = request.BrojNabavke;
            nova.Datum = request.Datum;
            nova.DobavljacId = request.DobavljacId;
            nova.IznosRacuna = request.IznosRacuna;
            nova.KorisnikId = request.KorisnikId;
            nova.Napomena = request.Napomena;
            nova.Pdv = request.Pdv;
            nova.SkladisteId = request.SkladisteId;

            _context.Nabavka.Add(nova);
            _context.SaveChanges();

            foreach (var item in request.stavke)
            {
                Database.NabavkaStavke stavka = new Database.NabavkaStavke();

                stavka.NabavkaId = nova.NabavkaId;
                stavka.ArtikalId = item.ArtikalId;
                stavka.Cijena = item.Cijena;
                stavka.Kolicina = item.Kolicina;

                _context.NabavkaStavke.Add(stavka);
                _context.SaveChanges();
            }


        }
    }
}
