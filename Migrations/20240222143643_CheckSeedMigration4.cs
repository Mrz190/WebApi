using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApiCourse6_7.Migrations
{
    /// <inheritdoc />
    public partial class CheckSeedMigration4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CityDescription",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Cillum nulla culpa nisi commodo. Veniam adipisicing ipsum consectetur cupidatat exercitation nisi quis. Ea non labore dolore officia amet do commodo cupidatat. Sunt irure ut quis ea dolor labore incididunt. Elit occaecat commodo mollit ex excepteur nisi. Magna ad ipsum dolore eiusmod ea eiusmod anim in dolor incididunt labore.\r\n", "Monroe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Deserunt tempor incididunt nulla veniam cillum esse in elit. Consectetur quis laboris ut ipsum ea qui officia dolore excepteur enim quis elit cupidatat. Dolore cillum nisi incididunt laboris mollit nulla sit irure esse velit labore sunt tempor voluptate. Qui do velit nulla nulla mollit amet proident minim veniam cupidatat duis non. Incididunt Lorem ullamco ut proident commodo tempor in cillum nulla esse sunt pariatur consequat non. Mollit est commodo magna amet ipsum aute sunt amet qui ullamco dolore aliqua cupidatat.\r\n", "Anna" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[] { 3, "Est duis proident duis occaecat duis nostrud voluptate quis dolore. Anim ea velit eu elit. Minim aliqua labore est do ut elit tempor ex eu. Exercitation do cupidatat Lorem dolor fugiat commodo fugiat est. Mollit amet tempor eu consequat nisi Lorem incididunt commodo anim eiusmod sunt.\r\n", "Mae" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "CityDescription",
                table: "Cities",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Nothing", "Vitebsk" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Nothing", "Minsk" });
        }
    }
}
