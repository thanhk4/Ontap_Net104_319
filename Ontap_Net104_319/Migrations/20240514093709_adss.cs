using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ontap_Net104_319.Migrations
{
    public partial class adss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_carts_Username",
                table: "Accounts");

            migrationBuilder.AddForeignKey(
                name: "FK_carts_Accounts_UseName",
                table: "carts",
                column: "UseName",
                principalTable: "Accounts",
                principalColumn: "Username",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carts_Accounts_UseName",
                table: "carts");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_carts_Username",
                table: "Accounts",
                column: "Username",
                principalTable: "carts",
                principalColumn: "UseName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
