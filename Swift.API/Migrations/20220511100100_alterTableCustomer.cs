using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Swift_API.Migrations
{
    public partial class alterTableCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Customers",
                newName: "Username");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Customers",
                newName: "Email");
        }
    }
}
