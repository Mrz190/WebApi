using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCourse6_7.Migrations
{
    /// <inheritdoc />
    public partial class CheckSeedMigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[] { 1, "Nothing", "Vitebsk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[] { 11, "Nothing", "Vitebsk" });
        }
    }
}
