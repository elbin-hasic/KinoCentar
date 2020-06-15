using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class addFieldsOnRezervacija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Korisnik_KorisnikId",
                table: "Rezervacija");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Rezervacija",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsOtkazano",
                table: "Rezervacija",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsProdano",
                table: "Rezervacija",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Korisnik_KorisnikId",
                table: "Rezervacija",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Korisnik_KorisnikId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "IsOtkazano",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "IsProdano",
                table: "Rezervacija");

            migrationBuilder.AlterColumn<int>(
                name: "KorisnikId",
                table: "Rezervacija",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Korisnik_KorisnikId",
                table: "Rezervacija",
                column: "KorisnikId",
                principalTable: "Korisnik",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
