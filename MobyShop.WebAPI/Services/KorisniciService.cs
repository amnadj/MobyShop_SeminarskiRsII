using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MobyShop.Model.Requests;
using MobyShop.Models;
using MobyShop.WebAPI;
using MobyShop.WebAPI.Services;
namespace MobyShop.WebAPI.Services
{
    public class KorisniciService : IKorisniciService
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public KorisniciService(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Korisnici Authenticiraj(string username, string pass)
        {
            var user = _context.Korisnici.FirstOrDefault(x => x.KorisnickoIme == username);

            if (user != null)
            {
                var hashedPass = GenerateHash(user.LozinkaSalt, pass);

                if (hashedPass == user.LozinkaHash)
                {
                    var uloge = _context.KorisniciUloge.Where(x => x.KorisnikId == user.KorisnikId);
                    Korisnici novikorisnik = new Korisnici();

                    foreach (var item in uloge)
                    {

                        novikorisnik.KorisniciUloge = new List<KorisniciUloge>();
                        novikorisnik.KorisniciUloge.Add(new KorisniciUloge
                        {
                            DatumIzmjene = item.DatumIzmjene,
                            KorisnikId = item.KorisnikId,
                            UlogaId = item.UlogaId,
                            KorisnikUlogaId = item.KorisnikUlogaId
                        });
                    }
                    novikorisnik.Ime = user.Ime;
                    novikorisnik.Prezime = user.Prezime;
                    novikorisnik.KorisnickoIme = user.KorisnickoIme;
                    novikorisnik.Email = user.Email;
                    novikorisnik.KorisnikId = user.KorisnikId;
                    novikorisnik.Telefon = user.Telefon;

                    return novikorisnik;

                }
            }

            return null;
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }

        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }


        public List<Korisnici> Get(KorisniciSearchRequest search)
        {
            var query = _context.Korisnici.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Ime))
            {
                query = query.Where(x => x.Ime.StartsWith(search.Ime));
            }

            if (!string.IsNullOrWhiteSpace(search?.Prezime))
            {
                query = query.Where(x => x.Prezime.StartsWith(search.Prezime));
            }

            if (search?.IsUlogeLoadingEnabled == true)
            {
                query = query.Include(x => x.KorisniciUloge);
            }

            var list = query.ToList();

            return _mapper.Map<List<Korisnici>>(list);

        }

        public Korisnici GetById(int id)
        {
            var entity = _context.Korisnici.Find(id);

            return _mapper.Map<Korisnici>(entity);

        }
        public void Insert(KorisniciInsertRequest request)
        {
            MobyShop.WebAPI.Database.Korisnici entity = _mapper.Map<MobyShop.WebAPI.Database.Korisnici>(request);

            if (request.Password != request.PasswordPotvrda)
            {
                throw new Exception("Passwordi se ne slažu");
            }

            entity.LozinkaSalt = GenerateSalt();
            entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);

            _context.Korisnici.Add(entity);
            _context.SaveChanges();

            foreach (var uloga in request.Uloge)
            {
                MobyShop.WebAPI.Database.KorisniciUloge korisniciUloge = new MobyShop.WebAPI.Database.KorisniciUloge();
                korisniciUloge.KorisnikId = entity.KorisnikId;
                korisniciUloge.UlogaId = uloga;
                korisniciUloge.DatumIzmjene = DateTime.Now;
                _context.KorisniciUloge.Add(korisniciUloge);

            }

            _context.SaveChanges();



        }

        public void Update(int id, KorisniciInsertRequest request)
        {
            var entity = _context.Korisnici.Where(x=>x.KorisnikId == id).FirstOrDefault();
          
            if (!string.IsNullOrWhiteSpace(request.Password))
            {
                if (request.Password != request.PasswordPotvrda)
                {
                    throw new Exception("Passwordi se ne slažu");
                }

                entity.LozinkaSalt = GenerateSalt();
                entity.LozinkaHash = GenerateHash(entity.LozinkaSalt, request.Password);
            }

            var ulogeKorisnik = _context.KorisniciUloge.Where(x => x.KorisnikId == id).ToList();

            foreach (int item in request.Uloge)
            {
                var uloga = _context.Uloge.Where(x => x.UlogaId == item).FirstOrDefault();

                var imaUlogu = ulogeKorisnik.Where(x => x.KorisnikUlogaId == uloga.UlogaId).FirstOrDefault();

                if(imaUlogu == null)
                {
                    var korisnikUloga = new MobyShop.WebAPI.Database.KorisniciUloge() { KorisnikId = entity.KorisnikId, UlogaId = uloga.UlogaId, DatumIzmjene = DateTime.Now };
                   
                    entity.KorisniciUloge.Add(korisnikUloga);
                }
            }

            _context.Korisnici.Attach(entity);
            _context.Korisnici.Update(entity);
            _mapper.Map(request, entity);

            _context.SaveChanges();

        }
    }
}
