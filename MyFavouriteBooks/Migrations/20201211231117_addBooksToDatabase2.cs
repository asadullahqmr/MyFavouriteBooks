using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFavouriteBooks.Migrations
{
    public partial class addBooksToDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filename",
                table: "Books");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Filename",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
