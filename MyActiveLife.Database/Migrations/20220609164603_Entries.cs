using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    public partial class Entries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Source_SourceId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_UserProfile_UserId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Source_SourceId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_UserProfile_UserId",
                table: "Photo");

            migrationBuilder.AddColumn<Guid>(
                name: "EntryId",
                table: "Activity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "WeatherId",
                table: "Activity",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Diary",
                columns: table => new
                {
                    DiaryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entry = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diary", x => x.DiaryId);
                    table.ForeignKey(
                        name: "FK_Diary_UserProfile_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfile",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateTable(
                name: "Phq9s",
                columns: table => new
                {
                    Phq9Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Answer1 = table.Column<int>(type: "int", nullable: false),
                    Answer2 = table.Column<int>(type: "int", nullable: false),
                    Answer3 = table.Column<int>(type: "int", nullable: false),
                    Answer4 = table.Column<int>(type: "int", nullable: false),
                    Answer5 = table.Column<int>(type: "int", nullable: false),
                    Answer6 = table.Column<int>(type: "int", nullable: false),
                    Answer7 = table.Column<int>(type: "int", nullable: false),
                    Answer8 = table.Column<int>(type: "int", nullable: false),
                    Answer9 = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phq9s", x => x.Phq9Id);
                    table.ForeignKey(
                        name: "FK_Phq9s_UserProfile_UserId",
                        column: x => x.UserId,
                        principalTable: "UserProfile",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    WeatherId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StationId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Temperature = table.Column<float>(type: "real", nullable: true),
                    MaxTemperature = table.Column<float>(type: "real", nullable: true),
                    MinTemperature = table.Column<float>(type: "real", nullable: true),
                    Dewpoint = table.Column<float>(type: "real", nullable: true),
                    WindDirection = table.Column<int>(type: "int", nullable: true),
                    WindSpeed = table.Column<float>(type: "real", nullable: true),
                    WindGust = table.Column<float>(type: "real", nullable: true),
                    Precipitation = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.WeatherId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activity_EntryId",
                table: "Activity",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_WeatherId",
                table: "Activity",
                column: "WeatherId");

            migrationBuilder.CreateIndex(
                name: "IX_Diary_UserId",
                table: "Diary",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_UserId",
                table: "Entry",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Phq9s_UserId",
                table: "Phq9s",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeId",
                table: "Activity",
                column: "ActivityTypeId",
                principalTable: "ActivityType",
                principalColumn: "ActivityTypeId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Entry_EntryId",
                table: "Activity",
                column: "EntryId",
                principalTable: "Entry",
                principalColumn: "EntryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Source_SourceId",
                table: "Activity",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "SourceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_UserProfile_UserId",
                table: "Activity",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Weather_WeatherId",
                table: "Activity",
                column: "WeatherId",
                principalTable: "Weather",
                principalColumn: "WeatherId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Source_SourceId",
                table: "Photo",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "SourceId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_UserProfile_UserId",
                table: "Photo",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Entry_EntryId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Source_SourceId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_UserProfile_UserId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Weather_WeatherId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_Source_SourceId",
                table: "Photo");

            migrationBuilder.DropForeignKey(
                name: "FK_Photo_UserProfile_UserId",
                table: "Photo");

            migrationBuilder.DropTable(
                name: "Diary");

            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "Phq9s");

            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropIndex(
                name: "IX_Activity_EntryId",
                table: "Activity");

            migrationBuilder.DropIndex(
                name: "IX_Activity_WeatherId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "EntryId",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "WeatherId",
                table: "Activity");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_ActivityType_ActivityTypeId",
                table: "Activity",
                column: "ActivityTypeId",
                principalTable: "ActivityType",
                principalColumn: "ActivityTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Source_SourceId",
                table: "Activity",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "SourceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_UserProfile_UserId",
                table: "Activity",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_Source_SourceId",
                table: "Photo",
                column: "SourceId",
                principalTable: "Source",
                principalColumn: "SourceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Photo_UserProfile_UserId",
                table: "Photo",
                column: "UserId",
                principalTable: "UserProfile",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
