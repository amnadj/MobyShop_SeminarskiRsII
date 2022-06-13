﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class slike : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 1,
                columns: new[] { "Slika", "SlikaThumb" },

            migrationBuilder.UpdateData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 2,
                columns: new[] { "Slika", "SlikaThumb" },

            migrationBuilder.UpdateData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 3,
                columns: new[] { "Slika", "SlikaThumb" },

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 6, 13, 1, 52, 49, 11, DateTimeKind.Local), "mTqXFhlqvJuHzl315ch/r3wUHCs=", "So4JmbGvIVZEPVReavvhAA==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 6, 13, 1, 52, 49, 42, DateTimeKind.Local), "iCpD/VkkTxVAu6rDBtaUaCVoF7Y=", "QNcoQPK5kWId2EGAJYux4A==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2022, 6, 13, 1, 52, 49, 42, DateTimeKind.Local), "Ivo/gaH2JcM2QvR1nhVVvL4No2M=", "m1NU+7K/WoTLnrem5mGYMQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "mTqXFhlqvJuHzl315ch/r3wUHCs=", "So4JmbGvIVZEPVReavvhAA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "iCpD/VkkTxVAu6rDBtaUaCVoF7Y=", "QNcoQPK5kWId2EGAJYux4A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "aQ1u1XGHYbAyklC3PbvCCBIs0Kc=", "m1NU+7K/WoTLnrem5mGYMQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 4,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "1SNvSNx+TKqGY43s2gsa9uez65g=", "GY3ZQMGuBplk+C/aZcppiw==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 45, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 46, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 46, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 47, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 48, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 48, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 50, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 50, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 53, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2022, 6, 13, 1, 52, 49, 53, DateTimeKind.Local));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 1,
                columns: new[] { "Slika", "SlikaThumb" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 2,
                columns: new[] { "Slika", "SlikaThumb" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Artikli",
                keyColumn: "ArtikalId",
                keyValue: 3,
                columns: new[] { "Slika", "SlikaThumb" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 56, 2, 978, DateTimeKind.Local), "l/pb2F6ygLsYO9hDJafWfqwFVBo=", "ii1s5xHwIFUYGJi6/TOmUg==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 56, 3, 5, DateTimeKind.Local), "rq4VTFIDoFHcVXN0piYk2Lcg1D8=", "XadGYyQ+seLfAyFkXdXoCA==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 56, 3, 5, DateTimeKind.Local), "01D00KV+G5V8Sl2AZWZ7dkLkwhE=", "0S7swSCGvtdtSjddVTZe7g==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "l/pb2F6ygLsYO9hDJafWfqwFVBo=", "ii1s5xHwIFUYGJi6/TOmUg==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "rq4VTFIDoFHcVXN0piYk2Lcg1D8=", "XadGYyQ+seLfAyFkXdXoCA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "aUXWEPT9TR4Gz3DShQhqraUMGc0=", "0S7swSCGvtdtSjddVTZe7g==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 4,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "+5tkv2Ses8JeJ1dntwMV9iNoeGM=", "hYkzsJm7EQZAy+RgLBOEQA==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 8, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 8, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 8, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 9, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 10, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 11, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 12, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 56, 3, 12, DateTimeKind.Local));
        }
    }
}