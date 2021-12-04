using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherApi.Database.Migrations
{
    public partial class Data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Summaries",
                columns: new[] { "Id", "Description" },
                values: new object[,]
                {
                    { 1, "Freezing" },
                    { 2, "Bracing" },
                    { 3, "Chilly" },
                    { 4, "Cool" },
                    { 5, "Mild" },
                    { 6, "Warm" },
                    { 7, "Balmy" },
                    { 8, "Hot" },
                    { 9, "Sweltering" },
                    { 10, "Scorching" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Summaries",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
