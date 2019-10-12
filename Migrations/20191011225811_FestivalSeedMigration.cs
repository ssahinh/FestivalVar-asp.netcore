using Microsoft.EntityFrameworkCore.Migrations;

namespace FestivalVar.Migrations
{
    public partial class FestivalSeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "CategoryId", "City", "Title" },
                values: new object[] { 1, 2, "Adana", "Festival1Title" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "CategoryId", "City", "Title" },
                values: new object[] { 2, 3, "Ankara", "Festival2Title" });

            migrationBuilder.InsertData(
                table: "Festivals",
                columns: new[] { "Id", "CategoryId", "City", "Title" },
                values: new object[] { 3, 4, "Istanbul", "Festival3Title" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Festivals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Festivals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Festivals",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
