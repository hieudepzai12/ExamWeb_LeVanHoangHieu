﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExamWeb_LeVanHoangHieu.Migrations
{
    /// <inheritdoc />
    public partial class Inschema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DiaNhacs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TuaCD = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NgheSi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TrongNuoc = table.Column<bool>(type: "bit", nullable: false),
                    GiaBan = table.Column<double>(type: "float", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaNhacs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DiaNhacs");
        }
    }
}
