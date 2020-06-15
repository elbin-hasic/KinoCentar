using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class AddThumbImagesOnTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Korisnik",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PlakatThumb",
                table: "Film",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "SlikaThumb",
                table: "Artikal",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Korisnik");

            migrationBuilder.DropColumn(
                name: "PlakatThumb",
                table: "Film");

            migrationBuilder.DropColumn(
                name: "SlikaThumb",
                table: "Artikal");
        }
    }
}
