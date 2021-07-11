using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class migracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Karakteristike_KarakteristikeId",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Modeli_ModelId",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK_Artikli_Proizvodjaci_ProizvodjacId",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Korisnici_KorisnikId",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_KorisniciUloge_Uloge_UlogaId",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK_Nabavka_Dobavljaci_DobavljacId",
                table: "Nabavka");

            migrationBuilder.DropForeignKey(
                name: "FK_Nabavka_Korisnici_KorisnikId",
                table: "Nabavka");

            migrationBuilder.DropForeignKey(
                name: "FK_Nabavka_Skladista_SkladisteId",
                table: "Nabavka");

            migrationBuilder.DropForeignKey(
                name: "FK_NabavkaStavke_Artikli_ArtikalId",
                table: "NabavkaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_NabavkaStavke_Nabavka_NabavkaId",
                table: "NabavkaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Klijenti_KlijentId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Skladista_SkladisteId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                table: "NarudzbaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_NarudzbaStavke_Narudzba_NarudzbaId",
                table: "NarudzbaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijesti_Korisnici_KorisnikId",
                table: "Obavijesti");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_Artikli_ArtikalId",
                table: "Ocjene");

            migrationBuilder.DropForeignKey(
                name: "FK_Ocjene_Klijenti_KlijentId",
                table: "Ocjene");

            migrationBuilder.DropForeignKey(
                name: "FK_PoslanaNarudzba_Klijenti_KlijentId",
                table: "PoslanaNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_PoslanaNarudzba_Korisnici_KorisnikId",
                table: "PoslanaNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_PoslanaNarudzba_Narudzba_NarudzbaId",
                table: "PoslanaNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Zahtjevi_Klijenti_KlijentId",
                table: "Zahtjevi");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahtjeviStavke_Korisnici_KorisnikId",
                table: "ZahtjeviStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahtjeviStavke_Zahtjevi_ZahtjevId",
                table: "ZahtjeviStavke");

            migrationBuilder.AlterColumn<bool>(
                name: "Otkazano",
                table: "Narudzba",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrojNarudzbe",
                table: "Narudzba",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BrojNabavke",
                table: "Nabavka",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Modeli",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Artikli",
                nullable: false,
                oldClrType: typeof(bool),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Sifra",
                table: "Artikli",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Artikli",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK__KarakteristikeArtikli__KarakteristikaId__267ABA7A",
                table: "Artikli",
                column: "KarakteristikeId",
                principalTable: "Karakteristike",
                principalColumn: "KarakteristikeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__ModeliArtikli__ModelId__267ABA7A",
                table: "Artikli",
                column: "ModelId",
                principalTable: "Modeli",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__ProizvodjaciArtikli__ProizvodjacId__267ABA7A",
                table: "Artikli",
                column: "ProizvodjacId",
                principalTable: "Proizvodjaci",
                principalColumn: "ProizvodjacId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__KorisnikUloga_KorisnikId__267ABA7A",
                table: "KorisniciUloge",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__KorisnikUloga_UlogaId__267ABA7A",
                table: "KorisniciUloge",
                column: "UlogaId",
                principalTable: "Uloge",
                principalColumn: "UlogaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NabavkaDobavljaci_DobavljacId__267ABA7A",
                table: "Nabavka",
                column: "DobavljacId",
                principalTable: "Dobavljaci",
                principalColumn: "DobavljacId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NabavkaKorisnik_KorisnikId__267ABA7A",
                table: "Nabavka",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nabavka_Skladista_SkladisteId",
                table: "Nabavka",
                column: "SkladisteId",
                principalTable: "Skladista",
                principalColumn: "SkladisteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NabavkaStavkeArtikal__ArtikalId__267ABA7A",
                table: "NabavkaStavke",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NabavkaStavke__NabavkaId__267ABA7A",
                table: "NabavkaStavke",
                column: "NabavkaId",
                principalTable: "Nabavka",
                principalColumn: "NabavkaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__KlijentiNarudzbe_KlijentId__267ABA7A",
                table: "Narudzba",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__KorisnikNarudzbe_KorisnikId__267ABA7A",
                table: "Narudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Skladista_SkladisteId",
                table: "Narudzba",
                column: "SkladisteId",
                principalTable: "Skladista",
                principalColumn: "SkladisteId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NarudzbaStavkeArtikal__ArtikaId__267ABA7A",
                table: "NarudzbaStavke",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__NarudzbaStavke__NarudzbaId__267ABA7A",
                table: "NarudzbaStavke",
                column: "NarudzbaId",
                principalTable: "Narudzba",
                principalColumn: "NarudzbaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijesti_Korisnici_KorisnikId",
                table: "Obavijesti",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__OcjeneArtikli_ArtikalId__267ABA7A",
                table: "Ocjene",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__OcjeneKlijent_KlijentId__267ABA7A",
                table: "Ocjene",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__KlijentiPoslanaNarudzba_KlijentId__267ABA7A",
                table: "PoslanaNarudzba",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__KorisniciPoslanaNarudzba_KorisnikId__267ABA7A",
                table: "PoslanaNarudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK__PoslanaNarudzba_NarudzbaId__267ABA7A",
                table: "PoslanaNarudzba",
                column: "NarudzbaId",
                principalTable: "Narudzba",
                principalColumn: "NarudzbaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Zahtjevi_Klijenti_KlijentId",
                table: "Zahtjevi",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahtjeviStavke_Korisnici_KorisnikId",
                table: "ZahtjeviStavke",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahtjeviStavke_Zahtjevi_ZahtjevId",
                table: "ZahtjeviStavke",
                column: "ZahtjevId",
                principalTable: "Zahtjevi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__KarakteristikeArtikli__KarakteristikaId__267ABA7A",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK__ModeliArtikli__ModelId__267ABA7A",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK__ProizvodjaciArtikli__ProizvodjacId__267ABA7A",
                table: "Artikli");

            migrationBuilder.DropForeignKey(
                name: "FK__KorisnikUloga_KorisnikId__267ABA7A",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK__KorisnikUloga_UlogaId__267ABA7A",
                table: "KorisniciUloge");

            migrationBuilder.DropForeignKey(
                name: "FK__NabavkaDobavljaci_DobavljacId__267ABA7A",
                table: "Nabavka");

            migrationBuilder.DropForeignKey(
                name: "FK__NabavkaKorisnik_KorisnikId__267ABA7A",
                table: "Nabavka");

            migrationBuilder.DropForeignKey(
                name: "FK_Nabavka_Skladista_SkladisteId",
                table: "Nabavka");

            migrationBuilder.DropForeignKey(
                name: "FK__NabavkaStavkeArtikal__ArtikalId__267ABA7A",
                table: "NabavkaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK__NabavkaStavke__NabavkaId__267ABA7A",
                table: "NabavkaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK__KlijentiNarudzbe_KlijentId__267ABA7A",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK__KorisnikNarudzbe_KorisnikId__267ABA7A",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Narudzba_Skladista_SkladisteId",
                table: "Narudzba");

            migrationBuilder.DropForeignKey(
                name: "FK__NarudzbaStavkeArtikal__ArtikaId__267ABA7A",
                table: "NarudzbaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK__NarudzbaStavke__NarudzbaId__267ABA7A",
                table: "NarudzbaStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_Obavijesti_Korisnici_KorisnikId",
                table: "Obavijesti");

            migrationBuilder.DropForeignKey(
                name: "FK__OcjeneArtikli_ArtikalId__267ABA7A",
                table: "Ocjene");

            migrationBuilder.DropForeignKey(
                name: "FK__OcjeneKlijent_KlijentId__267ABA7A",
                table: "Ocjene");

            migrationBuilder.DropForeignKey(
                name: "FK__KlijentiPoslanaNarudzba_KlijentId__267ABA7A",
                table: "PoslanaNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK__KorisniciPoslanaNarudzba_KorisnikId__267ABA7A",
                table: "PoslanaNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK__PoslanaNarudzba_NarudzbaId__267ABA7A",
                table: "PoslanaNarudzba");

            migrationBuilder.DropForeignKey(
                name: "FK_Zahtjevi_Klijenti_KlijentId",
                table: "Zahtjevi");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahtjeviStavke_Korisnici_KorisnikId",
                table: "ZahtjeviStavke");

            migrationBuilder.DropForeignKey(
                name: "FK_ZahtjeviStavke_Zahtjevi_ZahtjevId",
                table: "ZahtjeviStavke");

            migrationBuilder.AlterColumn<bool>(
                name: "Otkazano",
                table: "Narudzba",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "BrojNarudzbe",
                table: "Narudzba",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "BrojNabavke",
                table: "Nabavka",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Modeli",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<bool>(
                name: "Status",
                table: "Artikli",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<string>(
                name: "Sifra",
                table: "Artikli",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Artikli",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Karakteristike_KarakteristikeId",
                table: "Artikli",
                column: "KarakteristikeId",
                principalTable: "Karakteristike",
                principalColumn: "KarakteristikeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Modeli_ModelId",
                table: "Artikli",
                column: "ModelId",
                principalTable: "Modeli",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artikli_Proizvodjaci_ProizvodjacId",
                table: "Artikli",
                column: "ProizvodjacId",
                principalTable: "Proizvodjaci",
                principalColumn: "ProizvodjacId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Korisnici_KorisnikId",
                table: "KorisniciUloge",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_KorisniciUloge_Uloge_UlogaId",
                table: "KorisniciUloge",
                column: "UlogaId",
                principalTable: "Uloge",
                principalColumn: "UlogaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nabavka_Dobavljaci_DobavljacId",
                table: "Nabavka",
                column: "DobavljacId",
                principalTable: "Dobavljaci",
                principalColumn: "DobavljacId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nabavka_Korisnici_KorisnikId",
                table: "Nabavka",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Nabavka_Skladista_SkladisteId",
                table: "Nabavka",
                column: "SkladisteId",
                principalTable: "Skladista",
                principalColumn: "SkladisteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NabavkaStavke_Artikli_ArtikalId",
                table: "NabavkaStavke",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NabavkaStavke_Nabavka_NabavkaId",
                table: "NabavkaStavke",
                column: "NabavkaId",
                principalTable: "Nabavka",
                principalColumn: "NabavkaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Klijenti_KlijentId",
                table: "Narudzba",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Korisnici_KorisnikId",
                table: "Narudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Narudzba_Skladista_SkladisteId",
                table: "Narudzba",
                column: "SkladisteId",
                principalTable: "Skladista",
                principalColumn: "SkladisteId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavke_Artikli_ArtikalId",
                table: "NarudzbaStavke",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NarudzbaStavke_Narudzba_NarudzbaId",
                table: "NarudzbaStavke",
                column: "NarudzbaId",
                principalTable: "Narudzba",
                principalColumn: "NarudzbaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Obavijesti_Korisnici_KorisnikId",
                table: "Obavijesti",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_Artikli_ArtikalId",
                table: "Ocjene",
                column: "ArtikalId",
                principalTable: "Artikli",
                principalColumn: "ArtikalId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ocjene_Klijenti_KlijentId",
                table: "Ocjene",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoslanaNarudzba_Klijenti_KlijentId",
                table: "PoslanaNarudzba",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoslanaNarudzba_Korisnici_KorisnikId",
                table: "PoslanaNarudzba",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PoslanaNarudzba_Narudzba_NarudzbaId",
                table: "PoslanaNarudzba",
                column: "NarudzbaId",
                principalTable: "Narudzba",
                principalColumn: "NarudzbaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Zahtjevi_Klijenti_KlijentId",
                table: "Zahtjevi",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "KlijentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahtjeviStavke_Korisnici_KorisnikId",
                table: "ZahtjeviStavke",
                column: "KorisnikId",
                principalTable: "Korisnici",
                principalColumn: "KorisnikId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ZahtjeviStavke_Zahtjevi_ZahtjevId",
                table: "ZahtjeviStavke",
                column: "ZahtjevId",
                principalTable: "Zahtjevi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
