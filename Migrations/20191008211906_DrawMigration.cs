using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalVar.Migrations
{
    public partial class DrawMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Festivals",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Festivals_CategoryId",
                table: "Festivals",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Festivals_Categories_CategoryId",
                table: "Festivals",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Festivals_Categories_CategoryId",
                table: "Festivals");

            migrationBuilder.DropIndex(
                name: "IX_Festivals_CategoryId",
                table: "Festivals");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Festivals");
        }
    }
}
