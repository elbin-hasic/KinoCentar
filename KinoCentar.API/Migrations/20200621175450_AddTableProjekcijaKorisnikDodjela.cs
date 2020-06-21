using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class AddTableProjekcijaKorisnikDodjela : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjekcijaKorisnikDodjela",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjekcijaId = table.Column<int>(nullable: false),
                    KorisnikId = table.Column<int>(nullable: false),
                    DatumPosjete = table.Column<DateTime>(nullable: false),
                    DatumPosljednjePosjete = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekcijaKorisnikDodjela", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjekcijaKorisnikDodjela_Korisnik_KorisnikId",
                        column: x => x.KorisnikId,
                        principalTable: "Korisnik",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjekcijaKorisnikDodjela_Projekcija_ProjekcijaId",
                        column: x => x.ProjekcijaId,
                        principalTable: "Projekcija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProjekcijaKorisnikDodjela_KorisnikId",
                table: "ProjekcijaKorisnikDodjela",
                column: "KorisnikId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekcijaKorisnikDodjela_ProjekcijaId",
                table: "ProjekcijaKorisnikDodjela",
                column: "ProjekcijaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjekcijaKorisnikDodjela");
        }
    }
}
