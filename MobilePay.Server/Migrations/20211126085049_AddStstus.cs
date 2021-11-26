using Microsoft.EntityFrameworkCore.Migrations;

namespace MobilePay.Server.Migrations
{
    public partial class AddStstus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Successfully",
                table: "Pays",
                type: "boolean",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Successfully",
                table: "Pays");
        }
    }
}
