using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KinoCentar.API.Migrations
{
    public partial class addFieldsOnRezervacija2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsOtkazano",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "IsProdano",
                table: "Rezervacija");

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumOtkazano",
                table: "Rezervacija",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumProdano",
                table: "Rezervacija",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DatumOtkazano",
                table: "Rezervacija");

            migrationBuilder.DropColumn(
                name: "DatumProdano",
                table: "Rezervacija");

            migrationBuilder.AddColumn<bool>(
                name: "IsOtkazano",
                table: "Rezervacija",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsProdano",
                table: "Rezervacija",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
