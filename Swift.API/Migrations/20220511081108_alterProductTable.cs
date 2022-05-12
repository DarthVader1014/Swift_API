using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swift_API.Migrations
{
    public partial class alterProductTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductDesc",
                table: "Products",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Products",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "ProductDesc");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Link");
        }
    }
}
