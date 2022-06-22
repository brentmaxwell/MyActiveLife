using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    public partial class Days : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Entry_EntryId",
                table: "Activity");

            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.RenameColumn(
                name: "EntryId",
                table: "Activity",
                newName: "DayId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_EntryId",
                table: "Activity",
                newName: "IX_Activity_DayId");

            migrationBuilder.AddColumn<Guid>(
                name: "DayId",
                table: "Phq9s",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DayId",
                table: "Photo",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "DayId",
                table: "Diary",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Day",
                columns: table => new
                {
                    DayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false),
                    WeatherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Day", x => x.DayId);
                    table.ForeignKey(
                        name: "FK_Day_UserProfile_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfile",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Day_Weather_WeatherId",
                        column: x => x.WeatherId,
                        principalTable: "Weather",
                        principalColumn: "WeatherId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mood",
                columns: table => new
                {
                    MoodId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoodLevel = table.Column<short>(type: "smallint", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserProfileUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mood", x => x.MoodId);
                    table.ForeignKey(
                        name: "FK_Mood_Day_DayId",
                        column: x => x.DayId,
                        principalTable: "Day",
                        principalColumn: "DayId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Mood_UserProfile_UserProfileUserId",
                        column: x => x.UserProfileUserId,
                        principalTable: "UserProfile",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Phq9s_DayId",
                table: "Phq9s",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Photo_DayId",
                table: "Photo",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Diary_DayId",
                table: "Diary",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Day_UserId",
                table: "Day",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Day_WeatherId",
                table: "Day",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Mood_DayId",
                table: "Mood",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Mood_UserProfileUserId",
                table: "Mood",
                column: "UserProfileUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Day_DayId",
                table: "Activity",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diary_Day_DayId",
                table: "Diary",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Day_DayId",
                table: "Photo",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Phq9s_Day_DayId",
                table: "Phq9s",
                column: "DayId",
                principalTable: "Day",
                principalColumn: "DayId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Day_DayId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Diary_Day_DayId",
                table: "Diary");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Day_DayId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Phq9s_Day_DayId",
                table: "Phq9s");

            migrationBuilder.DropTable(
                name: "Mood");

            migrationBuilder.DropTable(
                name: "Day");

            migrationBuilder.DropIndex(
                name: "IX_Phq9s_DayId",
                table: "Phq9s");

            migrationBuilder.DropIndex(
                name: "IX_Photo_DayId",
                table: "Photo");

            migrationBuilder.DropIndex(
                name: "IX_Diary_DayId",
                table: "Diary");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Phq9s");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Photo");

            migrationBuilder.DropColumn(
                name: "DayId",
                table: "Diary");

            migrationBuilder.RenameColumn(
                name: "DayId",
                table: "Activity",
                newName: "EntryId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_DayId",
                table: "Activity",
                newName: "IX_Activity_EntryId");

            migrationBuilder.CreateTable(
                name: "Entry",
                columns: table => new
                {
                    EntryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entry", x => x.EntryId);
                    table.ForeignKey(
                        name: "FK_Entry_UserProfile_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfile",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Entry_UserId",
                table: "Entry",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Entry_EntryId",
                table: "Activity",
                column: "EntryId",
                principalTable: "Entry",
                principalColumn: "EntryId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
