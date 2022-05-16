using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrasturcture.Migrations
{
    public partial class updatingUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LsstName",
                table: "User",
                newName: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "LsstName");
        }
    }
}
