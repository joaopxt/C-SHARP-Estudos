using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nba.Db.Migrations
{
    /// <inheritdoc />
    public partial class nbaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trofeus = table.Column<int>(type: "int", nullable: false),
                    Conferencia = table.Column<string>(type: "varchar(5)", maxLength: 5, nullable: true),
                    Star = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
