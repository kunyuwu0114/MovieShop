using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrasturcture.Migrations
{
    public partial class updatingCastTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cast",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<int>(type: "int", maxLength: 128, nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    TmdbUrl = table.Column<int>(type: "int", nullable: true),
                    ProfilePath = table.Column<int>(type: "int", maxLength: 2048, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cast", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cast");
        }
    }
}
