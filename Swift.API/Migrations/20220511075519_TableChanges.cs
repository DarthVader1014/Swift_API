using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swift_API.Migrations
{
    public partial class TableChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryDesc",
                table: "Categories");

            migrationBuilder.RenameColumn(
                name: "CategoryTitle",
                table: "Categories",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Categories",
                newName: "Id");

            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Categories",
                newName: "CategoryTitle");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Categories",
                newName: "CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "CategoryDesc",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
