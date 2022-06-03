using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    public partial class UpdatesToStravaActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Profile_ProfileId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Profile_ProfileId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Photo",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_ProfileId",
                table: "Photo",
                newName: "IX_Photo_UserId");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Activity",
                newName: "StartDateTime");

            migrationBuilder.RenameColumn(
                name: "ProfileId",
                table: "Activity",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_ProfileId",
                table: "Activity",
                newName: "IX_Activity_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "MapPolyline",
                table: "StravaActivity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<float>(
                name: "TotalElevationGain",
                table: "StravaActivity",
                type: "real",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExternalId",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "UserProfile",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfile", x => x.UserId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_UserProfile_UserId",
                table: "Activity",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_UserProfile_UserId",
                table: "Photo",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_UserProfile_UserId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_UserProfile_UserId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "UserProfile");

            migrationBuilder.DropColumn(
                name: "TotalElevationGain",
                table: "StravaActivity");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Photo",
                newName: "ProfileId");

            migrationBuilder.RenameIndex(
                name: "IX_Photo_UserId",
                table: "Photo",
                newName: "IX_Photo_ProfileId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Activity",
                newName: "ProfileId");

            migrationBuilder.RenameColumn(
                name: "StartDateTime",
                table: "Activity",
                newName: "StartTime");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_UserId",
                table: "Activity",
                newName: "IX_Activity_ProfileId");

            migrationBuilder.AlterColumn<string>(
                name: "MapPolyline",
                table: "StravaActivity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExternalId",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    ProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.ProfileId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Profile_ProfileId",
                table: "Activity",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Profile_ProfileId",
                table: "Photo",
                column: "ProfileId",
                principalTable: "Profile",
                principalColumn: "ProfileId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
