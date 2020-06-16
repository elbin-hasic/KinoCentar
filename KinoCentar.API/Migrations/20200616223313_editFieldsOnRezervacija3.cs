using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class editFieldsOnRezervacija3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodaja_Korisnik_KorisnikId",
                table: "Prodaja");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Prodaja",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Prodaja_Korisnik_KorisnikId",
                table: "Prodaja",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prodaja_Korisnik_KorisnikId",
                table: "Prodaja");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Prodaja",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Prodaja_Korisnik_KorisnikId",
                table: "Prodaja",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
