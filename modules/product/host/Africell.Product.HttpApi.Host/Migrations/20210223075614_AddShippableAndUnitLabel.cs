using Microsoft.EntityFrameworkCore.Migrations;

namespace Africell.Product.Migrations
{
    public partial class AddShippableAndUnitLabel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UnitLabel",
                table: "ProductProducts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitLabel",
                table: "ProductProducts");
        }
    }
}
