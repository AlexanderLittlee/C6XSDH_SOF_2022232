using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNMwebapp.Data.Migrations
{
    public partial class cnm_base : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WorkersNeeded = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    Uid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DriversLicence = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.Uid);
                });

            migrationBuilder.CreateTable(
                name: "JobWorker",
                columns: table => new
                {
                    ScheduleUid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    WorkersUid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobWorker", x => new { x.ScheduleUid, x.WorkersUid });
                    table.ForeignKey(
                        name: "FK_JobWorker_Jobs_ScheduleUid",
                        column: x => x.ScheduleUid,
                        principalTable: "Jobs",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobWorker_Workers_WorkersUid",
                        column: x => x.WorkersUid,
                        principalTable: "Workers",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_JobWorker_WorkersUid",
                table: "JobWorker",
                column: "WorkersUid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobWorker");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Workers");
        }
    }
}
