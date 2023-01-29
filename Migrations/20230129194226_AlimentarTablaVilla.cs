using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AlimentarTablaVilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de Villa Real", new DateTime(2023, 1, 29, 14, 42, 26, 734, DateTimeKind.Local).AddTicks(6812), new DateTime(2023, 1, 29, 14, 42, 26, 734, DateTimeKind.Local).AddTicks(6801), "", 50, "Villa Real", 5, 200 },
                    { 2, "", "Detalle Premium Villa Real", new DateTime(2023, 1, 29, 14, 42, 26, 734, DateTimeKind.Local).AddTicks(6815), new DateTime(2023, 1, 29, 14, 42, 26, 734, DateTimeKind.Local).AddTicks(6814), "", 40, "Premium Vista a la piscina", 4, 215 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
