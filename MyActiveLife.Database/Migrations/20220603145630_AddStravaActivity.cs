using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyActiveLife.Database.Migrations
{
    public partial class AddStravaActivity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Activity",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "StravaActivity",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MovingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ElapsedTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    Distance = table.Column<float>(type: "real", nullable: true),
                    AverageSpeed = table.Column<float>(type: "real", nullable: true),
                    MaxSpeed = table.Column<float>(type: "real", nullable: true),
                    AverageCadence = table.Column<float>(type: "real", nullable: true),
                    AverageTemp = table.Column<float>(type: "real", nullable: true),
                    AverageWatts = table.Column<float>(type: "real", nullable: true),
                    MaxWatts = table.Column<float>(type: "real", nullable: true),
                    WeightedAverageWatts = table.Column<float>(type: "real", nullable: true),
                    Kilojoules = table.Column<float>(type: "real", nullable: true),
                    ElevationHigh = table.Column<float>(type: "real", nullable: true),
                    ElevationLow = table.Column<float>(type: "real", nullable: true),
                    SufferScore = table.Column<float>(type: "real", nullable: true),
                    Calories = table.Column<float>(type: "real", nullable: true),
                    MapPolyline = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StravaActivity", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_StravaActivity_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityId");
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StravaActivity");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Activity");
        }
    }
}
