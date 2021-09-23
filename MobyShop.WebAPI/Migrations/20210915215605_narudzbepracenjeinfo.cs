using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class narudzbepracenjeinfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NarudzbePracenjeInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NarudzbaId = table.Column<int>(nullable: false),
                    StatusPracenja = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NarudzbePracenjeInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NarudzbePracenjeInfo_Narudzba_NarudzbaId",
                        column: x => x.NarudzbaId,
                        principalTable: "Narudzba",
                        principalColumn: "NarudzbaId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_NarudzbePracenjeInfo_NarudzbaId",
                table: "NarudzbePracenjeInfo",
                column: "NarudzbaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NarudzbePracenjeInfo");

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 7, 21, 456, DateTimeKind.Local), "NEENrmkBAdWxNI0fN3Ihf5cVBmw=", "aVY2L2hs+jsexU4eKgotaQ==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 7, 21, 482, DateTimeKind.Local), "Lo3bPPeIYb/2iXhQDryCIz/wFsc=", "I2/2DjnXR/31hADUXPFa6w==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 9, 15, 23, 7, 21, 483, DateTimeKind.Local), "mSSYXRweOYdYlt/cI8O2AyUGjh0=", "e+6fwCPEo7UxydTbMyn/cA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "NEENrmkBAdWxNI0fN3Ihf5cVBmw=", "aVY2L2hs+jsexU4eKgotaQ==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "Lo3bPPeIYb/2iXhQDryCIz/wFsc=", "I2/2DjnXR/31hADUXPFa6w==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "mReZlP1LxIT5qWvS0jQrJ4AGXZ8=", "e+6fwCPEo7UxydTbMyn/cA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 4,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "qRzF2g+BfRN6vdwbjnGRmGWiBiw=", "RMtMFHm4qiz1085fjYxadA==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 484, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 484, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 484, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 485, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 486, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 487, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 487, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 9, 15, 23, 7, 21, 488, DateTimeKind.Local));
        }
    }
}
