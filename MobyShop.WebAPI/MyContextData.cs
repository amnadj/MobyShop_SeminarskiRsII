using Microsoft.EntityFrameworkCore;
using MobyShop.WebAPI.Database;
using MobyShop.WebAPI.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MobyShop.WebAPI
{
    public partial class MyContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {
            List<string> Salt = new List<string>();
            for (int i = 0; i < 5; i++)
            {
                Salt.Add(KorisniciService.GenerateSalt());
            }

            for (int i = 0; i < 5; i++)
            {
                Salt.Add(KlijentiService.GenerateSalt());
            }

            #region Dodavanje korisnickih uloga
            modelBuilder.Entity<Uloge>().HasData(
                new Uloge()
                {
                    UlogaId = 1,
                    Naziv = "Admin",
                    Opis ="Upravljanje sistemom"
                },
                new Uloge()
                {
                    UlogaId = 2,
                    Naziv = "Prodavac",
                    Opis = "Rad na sistemu"
                },
                new Uloge()
                {
                    UlogaId = 3,
                    Naziv = "Skladistar",
                    Opis = "Upravljanje robom"
                });
            #endregion

            #region Dodavanje artikala
            modelBuilder.Entity<Artikli>().HasData(
                new Artikli()
                {
                    ArtikalId = 1,
                    Naziv = "Samsung Galaxy S20+",
                    Sifra = "12345",
                    Cijena =1200,
                    Slika = File.ReadAllBytes("Images/samsung20.jpg"),
                    SlikaThumb = File.ReadAllBytes("Images/samsung20.jpg"),
                    Status = true,
                    KarakteristikeId=1,
                    ProizvodjacId=1,
                    ModelId=1
                },
                new Artikli()
                {
                    ArtikalId = 2,
                    Naziv = "Iphone 12",
                    Sifra = "12346",
                    Cijena = 1800,
                    Slika = File.ReadAllBytes("Images/iphone.jpg"),
                    SlikaThumb = File.ReadAllBytes("Images/iphone.jpg"),
                    Status = true,
                    KarakteristikeId = 3,
                    ProizvodjacId = 3,
                    ModelId = 3
                },
                new Artikli()
                {
                    ArtikalId = 3,
                    Naziv = "Samsung Galaxy S10+",
                    Sifra = "2456",
                    Cijena = 900,
                    Slika = File.ReadAllBytes("Images/samsung10.png"),
                    SlikaThumb = File.ReadAllBytes("Images/samsung10.png"),
                    Status = true,
                    KarakteristikeId = 1,
                    ProizvodjacId = 1,
                    ModelId = 1
                });
            #endregion

            #region Dodavanje dobavljaca
            modelBuilder.Entity<Dobavljaci>().HasData(
                new Dobavljaci()
                {
                    DobavljacId = 1,
                    Naziv = "DobavljacMoby d.o.o",
                    KontaktOsoba = "Selma",
                    Adresa = "Muje Pasica 7",
                    Telefon = "062612612",
                    Fax = "030234342",
                    Web = "www.dobavljac1.com",
                    Email = "dobavljac1@mail.com",
                    ZiroRacuni = "123456789",
                    Napomena = "Napomena 1",
                    Status = true
                },
                new Dobavljaci()
                {
                    DobavljacId = 2,
                    Naziv = "Test",
                    KontaktOsoba = "Test",
                    Adresa = "Adresa Test",
                    Telefon = "062123123",
                    Fax = "030235352",
                    Web = "www.dobavljac2.com",
                    Email = "dobavljac2@mail.com",
                    ZiroRacuni = "123456546",
                    Napomena = "Napomena 2",
                    Status = true
                },
                new Dobavljaci()
                {
                    DobavljacId = 3,
                    Naziv = "Dobavljac 3",
                    KontaktOsoba = "Elma",
                    Adresa = "Adresa 3",
                    Telefon = "062612632",
                    Fax = "030234344",
                    Web = "www.dobavljac3.com",
                    Email = "dobavljac3@mail.com",
                    ZiroRacuni = "123456779",
                    Napomena = "Napomena 3",
                    Status = false
                });
            #endregion

            #region Dodavanje karakteristika
            modelBuilder.Entity<Karakteristike>().HasData(
                new Karakteristike()
                {
                    KarakteristikeId = 1,
                    Novo = true,
                    OperativniSistem = "Android",
                    Kamera = 48,
                    Ram = 8,
                    Memorija =256,
                    Procesor = 3
                },
                new Karakteristike()
                {
                    KarakteristikeId = 2,
                    Novo = true,
                    OperativniSistem = "Android",
                    Kamera = 32,
                    Ram = 6,
                    Memorija = 128,
                    Procesor = 2
                },
                new Karakteristike()
                {
                    KarakteristikeId = 3,
                    Novo = false,
                    OperativniSistem = "IOS",
                    Kamera = 12,
                    Ram = 4,
                    Memorija = 128,
                    Procesor = 2
                },
                new Karakteristike()
                {
                    KarakteristikeId = 4,
                    Novo = true,
                    OperativniSistem = "Android",
                    Kamera = 20,
                    Ram = 4,
                    Memorija = 128,
                    Procesor = 2
                });
            #endregion

            #region Dodavanje klijenata
            modelBuilder.Entity<Klijenti>().HasData(
                new Klijenti()
                {
                    KlijentId = 1,
                    Ime = "Admin",
                    Prezime = "Admin",
                    DatumRegistracije = DateTime.Now,
                    Email ="admin@mail.com",
                    Telefon = "063232213",
                    KorisnickoIme = "admin",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[0], "test")
                },
                new Klijenti()
                {
                    KlijentId = 2,
                    Ime = "User",
                    Prezime = "User",
                    DatumRegistracije = DateTime.Now,
                    Email = "user@mail.com",
                    Telefon = "063132233",
                    KorisnickoIme = "user",
                    LozinkaSalt = Salt[1],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[1], "test")
                },
                new Klijenti()
                {
                    KlijentId = 3,
                    Ime = "Amna",
                    Prezime = "Dj",
                    DatumRegistracije = DateTime.Now,
                    Email = "amna@mail.com",
                    Telefon = "063232245",
                    KorisnickoIme = "amna123",
                    LozinkaSalt = Salt[2],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[2], "amna123")
                });
            #endregion

            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnici>().HasData(
                new Korisnici()
                {
                    KorisnikId = 1,
                    Ime = "Admin",
                    Prezime = "Admin",
                    Email = "admin@mail.com",
                    Telefon = "063232983",
                    KorisnickoIme = "admin",
                    LozinkaSalt = Salt[0],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[0], "test")
                },
                new Korisnici()
                {
                    KorisnikId = 2,
                    Ime = "Prodavac",
                    Prezime = "Prodavac",
                    Email = "prodavac@mail.com",
                    Telefon = "063235785",
                    KorisnickoIme = "prodavac",
                    LozinkaSalt = Salt[1],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[1], "test")
                },
                new Korisnici()
                {
                    KorisnikId = 3,
                    Ime = "User",
                    Prezime = "User",
                    Email = "user@mail.com",
                    Telefon = "063132233",
                    KorisnickoIme = "user",
                    LozinkaSalt = Salt[2],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[2], "test123")
                },
                new Korisnici()
                {
                    KorisnikId = 4,
                    Ime = "Amna",
                    Prezime = "Dj",
                    Email = "amna@mail.com",
                    Telefon = "063132233",
                    KorisnickoIme = "amna136",
                    LozinkaSalt = Salt[3],
                    LozinkaHash = KlijentiService.GenerateHash(Salt[3], "test126")
                });
            #endregion

            #region Dodavanje korisnickih uloga korisnicima
            modelBuilder.Entity<KorisniciUloge>().HasData(
                new KorisniciUloge()
                {
                    KorisnikUlogaId = 1,
                    KorisnikId = 1,
                    UlogaId = 1,
                    DatumIzmjene = DateTime.Now
                },
                new KorisniciUloge()
                {
                    KorisnikUlogaId = 2,
                    KorisnikId = 2,
                    UlogaId = 2,
                    DatumIzmjene = DateTime.Now
                },
                new KorisniciUloge()
                {
                    KorisnikUlogaId = 3,
                    KorisnikId = 3,
                    UlogaId = 2,
                    DatumIzmjene = DateTime.Now
                });
            #endregion

            #region Dodavanje modela
            modelBuilder.Entity<Modeli>().HasData(
                new Modeli()
                {
                    ModelId = 1,
                    Naziv = "Samsung",
                },
                new Modeli()
                {
                    ModelId = 2,
                    Naziv = "Huawei",
                },
                new Modeli()
                {
                    ModelId = 3,
                    Naziv = "Iphone",
                },
                new Modeli()
                {
                    ModelId = 4,
                    Naziv = "Alcatel",
                });
            #endregion

            #region Dodavanje skladista
            modelBuilder.Entity<Skladista>().HasData(
                new Skladista()
                {
                    SkladisteId = 1,
                    Naziv = "Skladiste 1",
                    Adresa = "Adresa 1",
                    Opis = "Glavno skladiste"
                },
                new Skladista()
                {
                    SkladisteId = 2,
                    Naziv = "Skladiste 2",
                    Adresa = "Adresa 2",
                    Opis = "Sporedno skladiste"
                },
               new Skladista()
               {
                   SkladisteId = 3,
                   Naziv = "Skladiste 3",
                   Adresa = "Adresa 3",
                   Opis = "skladiste"
               });
            #endregion

            #region Dodavanje nabavki
            modelBuilder.Entity<Nabavka>().HasData(
                new Nabavka()
                {
                    NabavkaId = 1,
                    BrojNabavke = "1",
                    Datum = DateTime.Now,
                    IznosRacuna = 1500,
                    Pdv = 17,
                    Napomena = "Prva nabavka",
                    SkladisteId = 1,
                    KorisnikId = 1,
                    DobavljacId = 1
                },
                new Nabavka()
                {
                    NabavkaId = 2,
                    BrojNabavke = "2",
                    Datum = DateTime.Now,
                    IznosRacuna = 1000,
                    Pdv = 17,
                    Napomena = "Druga nabavka",
                    SkladisteId = 1,
                    KorisnikId = 1,
                    DobavljacId = 2
                },
                new Nabavka()
                {
                    NabavkaId = 3,
                    BrojNabavke = "3",
                    Datum = DateTime.Now,
                    IznosRacuna = 1404,
                    Pdv = 17,
                    Napomena = "Treca nabavka",
                    SkladisteId = 1,
                    KorisnikId = 2,
                    DobavljacId = 2
                });
            #endregion

            #region Dodavanje stavki nabavke
            modelBuilder.Entity<NabavkaStavke>().HasData(
                new NabavkaStavke()
                {
                    NabavkaStavkeId = 1,
                    NabavkaId =1,
                    ArtikalId = 1,
                    Kolicina = 1,
                    Cijena = 1200
                },
                new NabavkaStavke()
                {
                    NabavkaStavkeId = 2,
                    NabavkaId = 2,
                    ArtikalId = 2,
                    Kolicina = 1,
                    Cijena = 1200
                });
            #endregion

            #region Dodavanje narudzbi
            modelBuilder.Entity<Narudzba>().HasData(
                new Narudzba()
                {
                    NarudzbaId = 1,
                    BrojNarudzbe = "1",
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Status = true,
                    Otkazano = false,
                    IznosBezPdv = 1000,
                    IznosSaPdv = 1170,
                    KorisnikId = 1,
                    SkladisteId = 1
                },
                new Narudzba()
                {
                    NarudzbaId = 2,
                    BrojNarudzbe = "2",
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Status = true,
                    Otkazano = false,
                    IznosBezPdv = 900,
                    IznosSaPdv = 1053,
                    KorisnikId = 3,
                    SkladisteId = 2
                });
            #endregion

            #region Dodavanje stavki narudzbe
            modelBuilder.Entity<NarudzbaStavke>().HasData(
                new NarudzbaStavke()
                {
                    NarudzbaStavkaId = 1,
                    NarudzbaId = 1,
                    Kolicina = 1,
                    Cijena = 1200,
                    Popust = 10,
                    ArtikalId = 2,
                },
                new NarudzbaStavke()
                {
                    NarudzbaStavkaId = 2,
                    NarudzbaId = 2,
                    Kolicina = 1,
                    Cijena = 900,
                    Popust = 0,
                    ArtikalId = 1,
                },
                new NarudzbaStavke()
                {
                    NarudzbaStavkaId = 3,
                    NarudzbaId = 2,
                    Kolicina = 1,
                    Cijena = 1800,
                    Popust = 0,
                    ArtikalId = 3,
                });
            #endregion

            #region Dodavanje ocjena
            modelBuilder.Entity<Ocjene>().HasData(
                new Ocjene()
                {
                    OcjenaId = 1,
                    ArtikalId = 2,
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Ocjena = 5
                },
                new Ocjene()
                {
                    OcjenaId = 2,
                    ArtikalId = 1,
                    KlijentId = 1,
                    Datum = DateTime.Now,
                    Ocjena = 5
                });
            #endregion

            #region Dodavanje proizvodjaca
            modelBuilder.Entity<Proizvodjaci>().HasData(
                new Proizvodjaci()
                {
                    ProizvodjacId = 1,
                    Naziv = "Samsung"
                },
                new Proizvodjaci()
                {
                    ProizvodjacId = 2,
                    Naziv = "Huawei"
                },
                new Proizvodjaci()
                {
                    ProizvodjacId = 3,
                    Naziv = "Apple"
                },
                new Proizvodjaci()
                {
                    ProizvodjacId = 4,
                    Naziv = "Alcatel"
                });
            #endregion
        }
    }
}
