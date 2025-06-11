using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExamWeb_LeVanHoangHieu.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaNhacs",
                columns: new[] { "Id", "GiaBan", "NgheSi", "SoLuong", "TrongNuoc", "TuaCD" },
                values: new object[,]
                {
                    { 1, 150000.0, "Nghệ sĩ A", 3, true, "Album 1" },
                    { 2, 200000.0, "Nghệ sĩ B", 6, false, "Album 2" },
                    { 3, 100000.0, "Nghệ sĩ C", 10, true, "Album 3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaNhacs",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
