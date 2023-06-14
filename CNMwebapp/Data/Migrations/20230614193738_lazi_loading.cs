using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CNMwebapp.Data.Migrations
{
    public partial class lazi_loading : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Jobs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_AspNetUsers_OwnerId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_OwnerId",
                table: "Jobs");

            migrationBuilder.AlterColumn<string>(
                name: "OwnerId",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
