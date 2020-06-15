using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class updateRezervacijeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_ProjekcijaRasporedVrijeme_ProjekcijaRasporedVrijemeId",
                table: "Rezervacija");

            migrationBuilder.DropTable(
                name: "ProjekcijaRasporedVrijeme");

            migrationBuilder.DropTable(
                name: "ProjekcijaRaspored");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_ProjekcijaRasporedVrijemeId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "ProjekcijaRasporedVrijemeId",
                table: "Rezervacija");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumProjekcije",
                table: "Rezervacija",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ProjekcijaId",
                table: "Rezervacija",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_ProjekcijaId",
                table: "Rezervacija",
                column: "ProjekcijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_Projekcija_ProjekcijaId",
                table: "Rezervacija",
                column: "ProjekcijaId",
                principalTable: "Projekcija",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rezervacija_Projekcija_ProjekcijaId",
                table: "Rezervacija");

            migrationBuilder.DropIndex(
                name: "IX_Rezervacija_ProjekcijaId",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "DatumProjekcije",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "ProjekcijaId",
                table: "Rezervacija");

            migrationBuilder.AddColumn<int>(
                name: "ProjekcijaRasporedVrijemeId",
                table: "Rezervacija",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ProjekcijaRaspored",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProjekcijaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekcijaRaspored", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjekcijaRaspored_Projekcija_ProjekcijaId",
                        column: x => x.ProjekcijaId,
                        principalTable: "Projekcija",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjekcijaRasporedVrijeme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjekcijaRasporedId = table.Column<int>(type: "int", nullable: false),
                    Vrijeme = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjekcijaRasporedVrijeme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjekcijaRasporedVrijeme_ProjekcijaRaspored_ProjekcijaRasporedId",
                        column: x => x.ProjekcijaRasporedId,
                        principalTable: "ProjekcijaRaspored",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rezervacija_ProjekcijaRasporedVrijemeId",
                table: "Rezervacija",
                column: "ProjekcijaRasporedVrijemeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekcijaRaspored_ProjekcijaId",
                table: "ProjekcijaRaspored",
                column: "ProjekcijaId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjekcijaRasporedVrijeme_ProjekcijaRasporedId",
                table: "ProjekcijaRasporedVrijeme",
                column: "ProjekcijaRasporedId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rezervacija_ProjekcijaRasporedVrijeme_ProjekcijaRasporedVrijemeId",
                table: "Rezervacija",
                column: "ProjekcijaRasporedVrijemeId",
                principalTable: "ProjekcijaRasporedVrijeme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
