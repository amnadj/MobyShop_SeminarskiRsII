using Microsoft.EntityFrameworkCore.Migrations;

namespace MobyShop.WebAPI.Migrations
{
    public partial class baza2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Uloge",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Uloge",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaId", "Naziv", "Opis" },
                values: new object[] { 1, "Admin", "Upravljanje sistemom" });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaId", "Naziv", "Opis" },
                values: new object[] { 2, "Prodavac", "Rad na sistemu" });

            migrationBuilder.InsertData(
                table: "Uloge",
                columns: new[] { "UlogaId", "Naziv", "Opis" },
                values: new object[] { 3, "Skladistar", "Upravljanje robom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogaId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogaId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Uloge",
                keyColumn: "UlogaId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Uloge",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Naziv",
                table: "Uloge",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 25);
        }
    }
}
