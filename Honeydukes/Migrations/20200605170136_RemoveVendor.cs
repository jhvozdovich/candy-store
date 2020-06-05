using Microsoft.EntityFrameworkCore.Migrations;

namespace Honeydukes.Migrations
{
    public partial class RemoveVendor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Vendor",
                table: "Treats");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Vendor",
                table: "Treats",
                nullable: true);
        }
    }
}
