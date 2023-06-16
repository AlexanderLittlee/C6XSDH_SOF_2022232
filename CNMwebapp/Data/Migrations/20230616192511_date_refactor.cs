using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNMwebapp.Data.Migrations
{
    public partial class date_refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_OwnerId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_OwnerId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Jobs");

            migrationBuilder.RenameColumn(
                name: "Start",
                table: "Jobs",
                newName: "Date");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Jobs",
                newName: "Start");

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Jobs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Jobs",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_OwnerId",
                table: "Jobs",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_AspNetUsers_OwnerId",
                table: "Jobs",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
