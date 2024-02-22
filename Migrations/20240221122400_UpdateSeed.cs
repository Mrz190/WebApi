using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiCourse6_7.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[,]
                {
                    { 1, "Great Business City", "Moscow" },
                    { 2, "Live City", "NewYork" }
                });

            migrationBuilder.InsertData(
                table: "PointOfInterests",
                columns: new[] { "PointId", "CityId", "PointDescription", "PointName" },
                values: new object[,]
                {
                    { 1, 1, null, "Moscow City" },
                    { 2, 1, null, "Kreml" },
                    { 3, 2, null, "Central Park" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "PointId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "PointId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "PointId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2);
        }
    }
}
