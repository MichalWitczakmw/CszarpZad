using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wpflab7B.Migrations
{
    /// <inheritdoc />
    public partial class DodanieStudentow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Studenci",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Imie = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Nazwisko = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Ocena = table.Column<decimal>(type: "DECIMAL(2,1)", nullable: true),
                    Wiek = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studenci", x => x.StudentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studenci");
        }
    }
}
