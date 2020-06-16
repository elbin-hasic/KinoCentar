using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class addKolicinaOnProdajaArtikalDodjela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "ProdajaArtikalDodjela",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BrojRacuna",
                table: "Prodaja",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "ProdajaArtikalDodjela");

            migrationBuilder.DropColumn(
                name: "BrojRacuna",
                table: "Prodaja");
        }
    }
}
