using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dobavljaci",
                columns: table => new
                {
                    DobavljacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    KontaktOsoba = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    Web = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    ZiroRacuni = table.Column<string>(nullable: true),
                    Napomena = table.Column<string>(nullable: true),
                    Status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dobavljaci", x => x.DobavljacId);
                });

            migrationBuilder.CreateTable(
                name: "Karakteristike",
                columns: table => new
                {
                    KarakteristikeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Novo = table.Column<bool>(nullable: false),
                    OperativniSistem = table.Column<string>(nullable: true),
                    Kamera = table.Column<decimal>(nullable: false),
                    Ram = table.Column<decimal>(nullable: false),
                    Memorija = table.Column<decimal>(nullable: false),
                    Procesor = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Karakteristike", x => x.KarakteristikeId);
                });

            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    KlijentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    DatumRegistracije = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.KlijentId);
                });

            migrationBuilder.CreateTable(
                name: "Korisnici",
                columns: table => new
                {
                    KorisnikId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Telefon = table.Column<string>(nullable: true),
                    KorisnickoIme = table.Column<string>(nullable: true),
                    LozinkaHash = table.Column<string>(nullable: true),
                    LozinkaSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korisnici", x => x.KorisnikId);
                });

            migrationBuilder.CreateTable(
                name: "Modeli",
                columns: table => new
                {
                    ModelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modeli", x => x.ModelId);
                });

            migrationBuilder.CreateTable(
                name: "Proizvodjaci",
                columns: table => new
                {
                    ProizvodjacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvodjaci", x => x.ProizvodjacId);
                });

            migrationBuilder.CreateTable(
                name: "Skladista",
                columns: table => new
                {
                    SkladisteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Adresa = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skladista", x => x.SkladisteId);
                });

            migrationBuilder.CreateTable(
                name: "Uloge",
                columns: table => new
                {
                    UlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uloge", x => x.UlogaId);
                });

            migrationBuilder.CreateTable(
                name: "Zahtjevi",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DatumZahtjeva = table.Column<DateTime>(nullable: false),
                    Naslov = table.Column<string>(nullable: true),
                    Opis = table.Column<string>(nullable: true),
                    KlijentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zahtjevi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zahtjevi_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Obavijesti",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naslov = table.Column<string>(nullable: true),
                    Text = table.Column<string>(nullable: true),
                    Slika = table.Column<byte[]>(nullable: true),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Obavijesti", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Obavijesti_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Artikli",
                columns: table => new
                {
                    ArtikalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Naziv = table.Column<string>(nullable: true),
                    Sifra = table.Column<string>(nullable: true),
                    Cijena = table.Column<decimal>(nullable: false),
                    Slika = table.Column<byte[]>(nullable: true),
                    SlikaThumb = table.Column<byte[]>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    KarakteristikeId = table.Column<int>(nullable: false),
                    ProizvodjacId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artikli", x => x.ArtikalId);
                    table.ForeignKey(
                        name: "FK_Artikli_Karakteristike_KarakteristikeId",
                        column: x => x.KarakteristikeId,
                        principalTable: "Karakteristike",
                        principalColumn: "KarakteristikeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artikli_Modeli_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Modeli",
                        principalColumn: "ModelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Artikli_Proizvodjaci_ProizvodjacId",
                        column: x => x.ProizvodjacId,
                        principalTable: "Proizvodjaci",
                        principalColumn: "ProizvodjacId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Nabavka",
                columns: table => new
                {
                    NabavkaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojNabavke = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    IznosRacuna = table.Column<decimal>(nullable: false),
                    Pdv = table.Column<decimal>(nullable: false),
                    Napomena = table.Column<string>(nullable: true),
                    SkladisteId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    DobavljacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nabavka", x => x.NabavkaId);
                    table.ForeignKey(
                        name: "FK_Nabavka_Dobavljaci_DobavljacId",
                        column: x => x.DobavljacId,
                        principalTable: "Dobavljaci",
                        principalColumn: "DobavljacId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Nabavka_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Nabavka_Skladista_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladista",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Narudzba",
                columns: table => new
                {
                    NarudzbaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrojNarudzbe = table.Column<string>(nullable: true),
                    KlijentId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Status = table.Column<bool>(nullable: false),
                    Otkazano = table.Column<bool>(nullable: true),
                    IznosBezPdv = table.Column<decimal>(nullable: false),
                    IznosSaPdv = table.Column<decimal>(nullable: false),
                    SkladisteId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Narudzba", x => x.NarudzbaId);
                    table.ForeignKey(
                        name: "FK_Narudzba_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Narudzba_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Narudzba_Skladista_SkladisteId",
                        column: x => x.SkladisteId,
                        principalTable: "Skladista",
                        principalColumn: "SkladisteId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "KorisniciUloge",
                columns: table => new
                {
                    KorisnikUlogaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KorisnikId = table.Column<int>(nullable: false),
                    UlogaId = table.Column<int>(nullable: false),
                    DatumIzmjene = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisniciUloge", x => x.KorisnikUlogaId);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_KorisniciUloge_Uloge_UlogaId",
                        column: x => x.UlogaId,
                        principalTable: "Uloge",
                        principalColumn: "UlogaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "ZahtjeviStavke",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Odgovor = table.Column<string>(nullable: true),
                    ZahtjevId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ZahtjeviStavke", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ZahtjeviStavke_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_ZahtjeviStavke_Zahtjevi_ZahtjevId",
                        column: x => x.ZahtjevId,
                        principalTable: "Zahtjevi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Ocjene",
                columns: table => new
                {
                    OcjenaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArtikalId = table.Column<int>(nullable: false),
                    KlijentId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Ocjena = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjene", x => x.OcjenaId);
                    table.ForeignKey(
                        name: "FK_Ocjene_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Ocjene_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NabavkaStavke",
                columns: table => new
                {
                    NabavkaStavkeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NabavkaId = table.Column<int>(nullable: false),
                    ArtikalId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NabavkaStavke", x => x.NabavkaStavkeId);
                    table.ForeignKey(
                        name: "FK_NabavkaStavke_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_NabavkaStavke_Nabavka_NabavkaId",
                        column: x => x.NabavkaId,
                        principalTable: "Nabavka",
                        principalColumn: "NabavkaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "NarudzbaStavke",
                columns: table => new
                {
                    NarudzbaStavkaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NarudzbaId = table.Column<int>(nullable: false),
                    Kolicina = table.Column<int>(nullable: false),
                    Cijena = table.Column<decimal>(nullable: false),
                    Popust = table.Column<decimal>(nullable: true),
                    ArtikalId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbaStavke", x => x.NarudzbaStavkaId);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                        column: x => x.ArtikalId,
                        principalTable: "Artikli",
                        principalColumn: "ArtikalId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_NarudzbaStavke_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PoslanaNarudzba",
                columns: table => new
                {
                    PoslanaNarudzbaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KlijentId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Poslano = table.Column<bool>(nullable: false),
                    NarudzbaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PoslanaNarudzba", x => x.PoslanaNarudzbaId);
                    table.ForeignKey(
                        name: "FK_PoslanaNarudzba_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "KlijentId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PoslanaNarudzba_Korisnici_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnici",
                        principalColumn: "KorisnikId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PoslanaNarudzba_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_KarakteristikeId",
                table: "Artikli",
                column: "KarakteristikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_ModelId",
                table: "Artikli",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Artikli_ProizvodjacId",
                table: "Artikli",
                column: "ProizvodjacId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_KorisniciUloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_DobavljacId",
                table: "Nabavka",
                column: "DobavljacId");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_KorisnikId",
                table: "Nabavka",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Nabavka_SkladisteId",
                table: "Nabavka",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_NabavkaStavke_ArtikalId",
                table: "NabavkaStavke",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_NabavkaStavke_NabavkaId",
                table: "NabavkaStavke",
                column: "NabavkaId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KlijentId",
                table: "Narudzba",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_KorisnikId",
                table: "Narudzba",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Narudzba_SkladisteId",
                table: "Narudzba",
                column: "SkladisteId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_ArtikalId",
                table: "NarudzbaStavke",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbaStavke_NarudzbaId",
                table: "NarudzbaStavke",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Obavijesti_KorisnikId",
                table: "Obavijesti",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_ArtikalId",
                table: "Ocjene",
                column: "ArtikalId");

            migrationBuilder.CreateIndex(
                name: "IX_Ocjene_KlijentId",
                table: "Ocjene",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PoslanaNarudzba_KlijentId",
                table: "PoslanaNarudzba",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_PoslanaNarudzba_KorisnikId",
                table: "PoslanaNarudzba",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_PoslanaNarudzba_NarudzbaId",
                table: "PoslanaNarudzba",
                column: "NarudzbaId");

            migrationBuilder.CreateIndex(
                name: "IX_Zahtjevi_KlijentId",
                table: "Zahtjevi",
                column: "KlijentId");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtjeviStavke_KorisnikId",
                table: "ZahtjeviStavke",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_ZahtjeviStavke_ZahtjevId",
                table: "ZahtjeviStavke",
                column: "ZahtjevId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KorisniciUloge");

            migrationBuilder.DropTable(
                name: "NabavkaStavke");

            migrationBuilder.DropTable(
                name: "NarudzbaStavke");

            migrationBuilder.DropTable(
                name: "Obavijesti");

            migrationBuilder.DropTable(
                name: "Ocjene");

            migrationBuilder.DropTable(
                name: "PoslanaNarudzba");

            migrationBuilder.DropTable(
                name: "ZahtjeviStavke");

            migrationBuilder.DropTable(
                name: "Uloge");

            migrationBuilder.DropTable(
                name: "Nabavka");

            migrationBuilder.DropTable(
                name: "Artikli");

            migrationBuilder.DropTable(
                name: "Narudzba");

            migrationBuilder.DropTable(
                name: "Zahtjevi");

            migrationBuilder.DropTable(
                name: "Dobavljaci");

            migrationBuilder.DropTable(
                name: "Karakteristike");

            migrationBuilder.DropTable(
                name: "Modeli");

            migrationBuilder.DropTable(
                name: "Proizvodjaci");

            migrationBuilder.DropTable(
                name: "Korisnici");

            migrationBuilder.DropTable(
                name: "Skladista");

            migrationBuilder.DropTable(
                name: "Klijenti");
        }
    }
}
