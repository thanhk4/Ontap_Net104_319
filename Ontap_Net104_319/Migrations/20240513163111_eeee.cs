using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ontap_Net104_319.Migrations
{
    public partial class eeee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "products");
        }
    }
}
