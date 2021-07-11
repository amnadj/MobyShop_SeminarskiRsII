using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class podaci : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Skladista",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Skladista",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Skladista",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Proizvodjaci",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisnici",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaSalt",
                table: "Korisnici",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaHash",
                table: "Korisnici",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnici",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisnici",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Klijenti",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaSalt",
                table: "Klijenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaHash",
                table: "Klijenti",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "KorisnickoIme",
                table: "Klijenti",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Klijenti",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "OperativniSistem",
                table: "Karakteristike",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Dobavljaci",
                columns: new[] { "DobavljacId", "Adresa", "Email", "Fax", "KontaktOsoba", "Napomena", "Naziv", "Status", "Telefon", "Web", "ZiroRacuni" },
                values: new object[,]
                {
                    { 1, "Muje Pasica 7", "dobavljac1@mail.com", "030234342", "Selma", "Napomena 1", "DobavljacMoby d.o.o", true, "062612612", "www.dobavljac1.com", "123456789" },
                    { 2, "Adresa Test", "dobavljac2@mail.com", "030235352", "Test", "Napomena 2", "Test", true, "062123123", "www.dobavljac2.com", "123456546" },
                    { 3, "Adresa 3", "dobavljac3@mail.com", "030234344", "Elma", "Napomena 3", "Dobavljac 3", false, "062612632", "www.dobavljac3.com", "123456779" }
                });

            migrationBuilder.InsertData(
                table: "Karakteristike",
                columns: new[] { "KarakteristikeId", "Kamera", "Memorija", "Novo", "OperativniSistem", "Procesor", "Ram" },
                values: new object[,]
                {
                    { 1, 48m, 256m, true, "Android", 3m, 8m },
                    { 2, 32m, 128m, true, "Android", 2m, 6m },
                    { 3, 12m, 128m, false, "IOS", 2m, 4m },
                    { 4, 20m, 128m, true, "Android", 2m, 4m }
                });

            migrationBuilder.InsertData(
                table: "Klijenti",
                columns: new[] { "KlijentId", "DatumRegistracije", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Telefon" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 11, 14, 35, 2, 784, DateTimeKind.Local), "admin@mail.com", "Admin", "admin", "msRqfae6n9ecynIZo++mdsRXI9A=", "qC8CByThGQN5qApaADFb1Q==", "Admin", "063232213" },
                    { 2, new DateTime(2021, 7, 11, 14, 35, 2, 797, DateTimeKind.Local), "user@mail.com", "User", "user", "msRqfae6n9ecynIZo++mdsRXI9A=", "IEn1ZDxWcQy4qoDhzxDN0A==", "User", "063132233" },
                    { 3, new DateTime(2021, 7, 11, 14, 35, 2, 797, DateTimeKind.Local), "amna@mail.com", "Amna", "amna123", "OZ0LPK3MjSQi6XkQy6lyH7sKeEo=", "XqhynIqes3RnrOiVRT3iLA==", "Dj", "063232245" }
                });

            migrationBuilder.InsertData(
                table: "Korisnici",
                columns: new[] { "KorisnikId", "Email", "Ime", "KorisnickoIme", "LozinkaHash", "LozinkaSalt", "Prezime", "Telefon" },
                values: new object[,]
                {
                    { 4, "amna@mail.com", "Amna", "amna136", "ltlk/W/nvtI0kYhLDJ9qq7D6vwE=", "tW3ic7sBR8UsRlydwRCKXg==", "Dj", "063132233" },
                    { 3, "user@mail.com", "User", "user", "8+rE1Ksrmut7v5h7jMKdOaOqp7M=", "XqhynIqes3RnrOiVRT3iLA==", "User", "063132233" },
                    { 1, "admin@mail.com", "Admin", "admin", "msRqfae6n9ecynIZo++mdsRXI9A=", "qC8CByThGQN5qApaADFb1Q==", "Admin", "063232983" },
                    { 2, "prodavac@mail.com", "Prodavac", "prodavac", "poYyNLHCprwOCfDqkiH2ItkdfQQ=", "IEn1ZDxWcQy4qoDhzxDN0A==", "Prodavac", "063235785" }
                });

            migrationBuilder.InsertData(
                table: "Modeli",
                columns: new[] { "ModelId", "Naziv" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Huawei" },
                    { 3, "Iphone" },
                    { 4, "Alcatel" }
                });

            migrationBuilder.InsertData(
                table: "Proizvodjaci",
                columns: new[] { "ProizvodjacId", "Naziv" },
                values: new object[,]
                {
                    { 1, "Samsung" },
                    { 2, "Huawei" },
                    { 3, "Apple" },
                    { 4, "Alcatel" }
                });

            migrationBuilder.InsertData(
                table: "Skladista",
                columns: new[] { "SkladisteId", "Adresa", "Naziv", "Opis" },
                values: new object[,]
                {
                    { 2, "Adresa 2", "Skladiste 2", "Sporedno skladiste" },
                    { 1, "Adresa 1", "Skladiste 1", "Glavno skladiste" },
                    { 3, "Adresa 3", "Skladiste 3", "skladiste" }
                });

            migrationBuilder.InsertData(
                table: "Artikli",
                columns: new[] { "ArtikalId", "Cijena", "KarakteristikeId", "ModelId", "Naziv", "ProizvodjacId", "Sifra", "Slika", "SlikaThumb", "Status" },
                values: new object[,]
                {
                    { 1, 1200m, 1, 1, "Samsung Galaxy S20+", 1, "12345", null, null, true },
                    { 3, 900m, 1, 1, "Samsung Galaxy S10+", 1, "2456", null, null, true },
                    { 2, 1800m, 3, 3, "Iphone 12", 3, "12346", null, null, true }
                });

            migrationBuilder.InsertData(
                table: "KorisniciUloge",
                columns: new[] { "KorisnikUlogaId", "DatumIzmjene", "KorisnikId", "UlogaId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local), 1, 1 },
                    { 2, new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local), 2, 2 },
                    { 3, new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Nabavka",
                columns: new[] { "NabavkaId", "BrojNabavke", "Datum", "DobavljacId", "IznosRacuna", "KorisnikId", "Napomena", "Pdv", "SkladisteId" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local), 1, 1500m, 1, "Prva nabavka", 17m, 1 },
                    { 2, "2", new DateTime(2021, 7, 11, 14, 35, 2, 800, DateTimeKind.Local), 2, 1000m, 1, "Druga nabavka", 17m, 1 },
                    { 3, "3", new DateTime(2021, 7, 11, 14, 35, 2, 800, DateTimeKind.Local), 2, 1404m, 2, "Treca nabavka", 17m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Narudzba",
                columns: new[] { "NarudzbaId", "BrojNarudzbe", "Datum", "IznosBezPdv", "IznosSaPdv", "KlijentId", "KorisnikId", "Otkazano", "SkladisteId", "Status" },
                values: new object[,]
                {
                    { 1, "1", new DateTime(2021, 7, 11, 14, 35, 2, 800, DateTimeKind.Local), 1000m, 1170m, 1, 1, false, 1, true },
                    { 2, "2", new DateTime(2021, 7, 11, 14, 35, 2, 801, DateTimeKind.Local), 900m, 1053m, 1, 3, false, 2, true }
                });

            migrationBuilder.InsertData(
                table: "NabavkaStavke",
                columns: new[] { "NabavkaStavkeId", "ArtikalId", "Cijena", "Kolicina", "NabavkaId" },
                values: new object[,]
                {
                    { 1, 1, 1200m, 1, 1 },
                    { 2, 2, 1200m, 1, 2 }
                });

            migrationBuilder.InsertData(
                table: "NarudzbaStavke",
                columns: new[] { "NarudzbaStavkaId", "ArtikalId", "Cijena", "Kolicina", "NarudzbaId", "Popust" },
                values: new object[,]
                {
                    { 1, 2, 1200m, 1, 1, 10m },
                    { 2, 1, 900m, 1, 2, 0m },
                    { 3, 3, 1800m, 1, 2, 0m }
                });

            migrationBuilder.InsertData(
                table: "Ocjene",
                columns: new[] { "OcjenaId", "ArtikalId", "Datum", "KlijentId", "Ocjena" },
                values: new object[,]
                {
                    { 2, 1, new DateTime(2021, 7, 11, 14, 35, 2, 801, DateTimeKind.Local), 1, 5 },
                    { 1, 2, new DateTime(2021, 7, 11, 14, 35, 2, 801, DateTimeKind.Local), 1, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dobavljaci",
                keyColumn: "DobavljacId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Karakteristike",
                keyColumn: "KarakteristikeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Karakteristike",
                keyColumn: "KarakteristikeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modeli",
                keyColumn: "ModelId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Modeli",
                keyColumn: "ModelId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NabavkaStavke",
                keyColumn: "NabavkaStavkeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NabavkaStavke",
                keyColumn: "NabavkaStavkeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NarudzbaStavke",
                keyColumn: "NarudzbaStavkaId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Skladista",
                keyColumn: "SkladisteId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dobavljaci",
                keyColumn: "DobavljacId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dobavljaci",
                keyColumn: "DobavljacId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Karakteristike",
                keyColumn: "KarakteristikeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Karakteristike",
                keyColumn: "KarakteristikeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Modeli",
                keyColumn: "ModelId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modeli",
                keyColumn: "ModelId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Proizvodjaci",
                keyColumn: "ProizvodjacId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Skladista",
                keyColumn: "SkladisteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Skladista",
                keyColumn: "SkladisteId",
                keyValue: 2);

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Skladista",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Skladista",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Skladista",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Proizvodjaci",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Korisnici",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaSalt",
                table: "Korisnici",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaHash",
                table: "Korisnici",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "KorisnickoIme",
                table: "Korisnici",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Korisnici",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Klijenti",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaSalt",
                table: "Klijenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LozinkaHash",
                table: "Klijenti",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "KorisnickoIme",
                table: "Klijenti",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Klijenti",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "OperativniSistem",
                table: "Karakteristike",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
