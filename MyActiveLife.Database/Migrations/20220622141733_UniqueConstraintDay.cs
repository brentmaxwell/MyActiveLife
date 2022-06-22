using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    public partial class UniqueConstraintDay : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Day_UserId",
                table: "Day");

            migrationBuilder.CreateIndex(
                name: "IX_Day_UserId_Date",
                table: "Day",
                columns: new[] { "UserId", "Date" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Day_UserId_Date",
                table: "Day");

            migrationBuilder.CreateIndex(
                name: "IX_Day_UserId",
                table: "Day",
                column: "UserId");
        }
    }
}
