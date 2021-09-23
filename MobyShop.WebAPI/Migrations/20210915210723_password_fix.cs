using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class password_fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 1,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 35, 2, 784, DateTimeKind.Local), "msRqfae6n9ecynIZo++mdsRXI9A=", "qC8CByThGQN5qApaADFb1Q==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 2,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 35, 2, 797, DateTimeKind.Local), "msRqfae6n9ecynIZo++mdsRXI9A=", "IEn1ZDxWcQy4qoDhzxDN0A==" });

            migrationBuilder.UpdateData(
                table: "Klijenti",
                keyColumn: "KlijentId",
                keyValue: 3,
                columns: new[] { "DatumRegistracije", "LozinkaHash", "LozinkaSalt" },
                values: new object[] { new DateTime(2021, 7, 11, 14, 35, 2, 797, DateTimeKind.Local), "OZ0LPK3MjSQi6XkQy6lyH7sKeEo=", "XqhynIqes3RnrOiVRT3iLA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 1,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "msRqfae6n9ecynIZo++mdsRXI9A=", "qC8CByThGQN5qApaADFb1Q==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 2,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "poYyNLHCprwOCfDqkiH2ItkdfQQ=", "IEn1ZDxWcQy4qoDhzxDN0A==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 3,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "8+rE1Ksrmut7v5h7jMKdOaOqp7M=", "XqhynIqes3RnrOiVRT3iLA==" });

            migrationBuilder.UpdateData(
                table: "Korisnici",
                keyColumn: "KorisnikId",
                keyValue: 4,
                columns: new[] { "LozinkaHash", "LozinkaSalt" },
                values: new object[] { "ltlk/W/nvtI0kYhLDJ9qq7D6vwE=", "tW3ic7sBR8UsRlydwRCKXg==" });

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 1,
                column: "DatumIzmjene",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 2,
                column: "DatumIzmjene",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "KorisniciUloge",
                keyColumn: "KorisnikUlogaId",
                keyValue: 3,
                column: "DatumIzmjene",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 799, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 800, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Nabavka",
                keyColumn: "NabavkaId",
                keyValue: 3,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 800, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 800, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Narudzba",
                keyColumn: "NarudzbaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 801, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 1,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 801, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Ocjene",
                keyColumn: "OcjenaId",
                keyValue: 2,
                column: "Datum",
                value: new DateTime(2021, 7, 11, 14, 35, 2, 801, DateTimeKind.Local));
        }
    }
}
