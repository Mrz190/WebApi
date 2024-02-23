using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCourse6_7.Migrations
{
    /// <inheritdoc />
    public partial class CheckSeedMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[] { 2, "Nothing", "Minsk" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);
        }
    }
}
