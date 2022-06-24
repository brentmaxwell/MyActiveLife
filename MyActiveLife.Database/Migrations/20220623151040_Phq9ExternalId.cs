using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    public partial class Phq9ExternalId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "Phq9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "Phq9s");
        }
    }
}
