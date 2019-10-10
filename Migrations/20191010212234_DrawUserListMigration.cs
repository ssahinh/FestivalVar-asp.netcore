using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalVar.Migrations
{
    public partial class DrawUserListMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DrawId",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_DrawId",
                table: "AspNetUsers",
                column: "DrawId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Draws_DrawId",
                table: "AspNetUsers",
                column: "DrawId",
                principalTable: "Draws",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Draws_DrawId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_DrawId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DrawId",
                table: "AspNetUsers");
        }
    }
}
