using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplicationWithSwagger.Migrations
{
    public partial class BookTableUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "Books",
                newName: "BookId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Books",
                newName: "Key");
        }
    }
}
