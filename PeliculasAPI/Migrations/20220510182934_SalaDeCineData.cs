using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace PeliculasAPI.Migrations
{
    public partial class SalaDeCineData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalaDeCines",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 4, "Cinepolis", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-77.05783599633473 -12.006314253536946)") });

            migrationBuilder.InsertData(
                table: "SalaDeCines",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 5, "Cinemark", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-76.97546075459518 -12.08519776317504)") });

            migrationBuilder.InsertData(
                table: "SalaDeCines",
                columns: new[] { "Id", "Nombre", "Ubicacion" },
                values: new object[] { 6, "Village East Cinema", (NetTopologySuite.Geometries.Point)new NetTopologySuite.IO.WKTReader().Read("SRID=4326;POINT (-73.986227 40.730898)") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalaDeCines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SalaDeCines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SalaDeCines",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
