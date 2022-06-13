using Microsoft.EntityFrameworkCore;
using MobyShop.WebAPI.Database;
using System;
using System.Linq;

namespace MobyShop.WebAPI
{
    public partial class MyContext : DbContext
    {
        public MyContext()
        {
        }

        //public MyContext(DbContextOptions<MyContext> x) : base(x)
        //{

        //}

        public MyContext(DbContextOptions<MyContext> options)
            : base(options)
        {
        }

        

        

        public DbSet<Database.Klijenti> Klijenti { get; set; }
        public DbSet<Database.Ocjene> Ocjene { get; set; }
        public DbSet<Database.Artikli> Artikli { get; set; }
        public DbSet<Database.Proizvodjaci> Proizvodjaci { get; set; }
        public DbSet<Database.Modeli> Modeli { get; set; }
        public DbSet<Database.Karakteristike> Karakteristike { get; set; }
        public DbSet<Database.Dobavljaci> Dobavljaci { get; set; }
        public DbSet<Database.Korisnici> Korisnici { get; set; }
        public DbSet<Database.KorisniciUloge> KorisniciUloge { get; set; }
        public DbSet<Database.Nabavka> Nabavka { get; set; }
        public DbSet<Database.NabavkaStavke> NabavkaStavke { get; set; }
        public DbSet<Database.Narudzba> Narudzba { get; set; }
        public DbSet<Database.NarudzbaStavke> NarudzbaStavke { get; set; }
        public DbSet<Database.Skladista> Skladista { get; set; }
        public DbSet<Database.Uloge> Uloge { get; set; }
        public DbSet<Database.Zahtjevi> Zahtjevi { get; set; }
        public DbSet<Database.ZahtjeviStavke> ZahtjeviStavke { get; set; }
        public DbSet<Database.Obavijesti> Obavijesti { get; set; }
        public DbSet<Database.PoslanaNarudzba> PoslanaNarudzba { get; set; }
        public DbSet<Database.NarudzbePracenjeInfo> NarudzbePracenjeInfo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes()
               .SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            modelBuilder.Entity<Modeli>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

            });

            modelBuilder.Entity<Korisnici>(entity =>
            {
                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email);

                entity.Property(e => e.Telefon);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired();

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired();

            });



            modelBuilder.Entity<Artikli>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Naziv)
                    .IsRequired();

                entity.Property(e => e.Sifra)
                    .IsRequired();

                entity.Property(e => e.Cijena)
                    .IsRequired();

                entity.Property(e => e.Slika);

                entity.Property(e => e.SlikaThumb);

                entity.Property(e => e.Status)
                    .IsRequired();

                entity.HasOne(d => d.Modeli)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.ModelId)
                    .HasConstraintName("FK__ModeliArtikli__ModelId__267ABA7A");

                entity.HasOne(d => d.Karakteristike)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.KarakteristikeId)
                    .HasConstraintName("FK__KarakteristikeArtikli__KarakteristikaId__267ABA7A");

                entity.HasOne(d => d.Proizvodjaci)
                    .WithMany(p => p.Artikli)
                    .HasForeignKey(d => d.ProizvodjacId)
                    .HasConstraintName("FK__ProizvodjaciArtikli__ProizvodjacId__267ABA7A");
            });

            modelBuilder.Entity<Karakteristike>(entity =>
            {
                entity.Property(e => e.Novo);

                entity.Property(e => e.OperativniSistem)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Kamera)
                    .IsRequired();

                entity.Property(e => e.Ram).IsRequired();

                entity.Property(e => e.Memorija).IsRequired();

                entity.Property(e => e.Procesor)
                    .IsRequired();

            });

            modelBuilder.Entity<Klijenti>(entity =>
            {
                entity.Property(e => e.Ime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Prezime)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KorisnickoIme)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DatumRegistracije);

                entity.Property(e => e.Email);

                entity.Property(e => e.Telefon);

                entity.Property(e => e.LozinkaHash)
                    .IsRequired();

                entity.Property(e => e.LozinkaSalt)
                    .IsRequired();

            });

            modelBuilder.Entity<Ocjene>(entity =>
            {
                entity.Property(e => e.Datum);

                entity.Property(e => e.Ocjena)
                    .IsRequired();

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.ArtikalId)
                    .HasConstraintName("FK__OcjeneArtikli_ArtikalId__267ABA7A");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Ocjene)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__OcjeneKlijent_KlijentId__267ABA7A");
            });

            modelBuilder.Entity<Nabavka>(entity =>
            {
                entity.Property(e => e.BrojNabavke)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum)
                    .IsRequired();

                entity.Property(e => e.IznosRacuna)
                    .IsRequired();

                entity.Property(e => e.Pdv)
                    .IsRequired(); ;

                entity.Property(e => e.Napomena);

                entity.HasOne(d => d.Dobavljac)
                    .WithMany(p => p.Nabavka)
                    .HasForeignKey(d => d.DobavljacId)
                    .HasConstraintName("FK__NabavkaDobavljaci_DobavljacId__267ABA7A");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Nabavka)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__NabavkaKorisnik_KorisnikId__267ABA7A");

            });

            modelBuilder.Entity<NabavkaStavke>(entity =>
            {
                entity.Property(e => e.Kolicina)
                    .IsRequired();

                entity.Property(e => e.Cijena)
                    .IsRequired();

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.NabavkaStavke)
                    .HasForeignKey(d => d.ArtikalId)
                    .HasConstraintName("FK__NabavkaStavkeArtikal__ArtikalId__267ABA7A");

                entity.HasOne(d => d.Nabavka)
                    .WithMany(p => p.NabavkaStavke)
                    .HasForeignKey(d => d.NabavkaId)
                    .HasConstraintName("FK__NabavkaStavke__NabavkaId__267ABA7A");
            });

            modelBuilder.Entity<Narudzba>(entity =>
            {
                entity.Property(e => e.BrojNarudzbe)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Datum);

                entity.Property(e => e.Status);

                entity.Property(e => e.Otkazano)
                    .IsRequired();

                entity.Property(e => e.IznosBezPdv).IsRequired();

                entity.Property(e => e.IznosSaPdv).IsRequired();

                entity.Property(e => e.Status)
                    .IsRequired();

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.Narudzbe)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__KlijentiNarudzbe_KlijentId__267ABA7A");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.Narudzba)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__KorisnikNarudzbe_KorisnikId__267ABA7A");
            });

            modelBuilder.Entity<NarudzbaStavke>(entity =>
            {
                entity.Property(e => e.Kolicina)
                    .IsRequired();

                entity.Property(e => e.Cijena)
                    .IsRequired();

                entity.Property(e => e.Popust);

                entity.HasOne(d => d.Artikal)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.ArtikalId)
                    .HasConstraintName("FK__NarudzbaStavkeArtikal__ArtikaId__267ABA7A");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.NarudzbaStavke)
                    .HasForeignKey(d => d.NarudzbaId)
                    .HasConstraintName("FK__NarudzbaStavke__NarudzbaId__267ABA7A");
            });

            modelBuilder.Entity<PoslanaNarudzba>(entity =>
            {
                entity.Property(e => e.Datum)
                    .IsRequired();

                entity.Property(e => e.Poslano);


                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.PoslanaNarudzba)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__KlijentiPoslanaNarudzba_KlijentId__267ABA7A");

                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.PoslanaNarudzba)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__KorisniciPoslanaNarudzba_KorisnikId__267ABA7A");

                entity.HasOne(d => d.Narudzba)
                    .WithMany(p => p.PoslanaNarudzba)
                    .HasForeignKey(d => d.NarudzbaId)
                    .HasConstraintName("FK__PoslanaNarudzba_NarudzbaId__267ABA7A");
            });

            modelBuilder.Entity<Uloge>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(25);

                entity.Property(e => e.Opis)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<KorisniciUloge>(entity =>
            {
                entity.Property(e => e.DatumIzmjene)
                    .IsRequired();


                entity.HasOne(d => d.Korisnik)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.KorisnikId)
                    .HasConstraintName("FK__KorisnikUloga_KorisnikId__267ABA7A");

                entity.HasOne(d => d.Uloga)
                    .WithMany(p => p.KorisniciUloge)
                    .HasForeignKey(d => d.UlogaId)
                    .HasConstraintName("FK__KorisnikUloga_UlogaId__267ABA7A");
            });

            modelBuilder.Entity<Proizvodjaci>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Skladista>(entity =>
            {
                entity.Property(e => e.Naziv)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Adresa)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Opis)
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);

    }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
