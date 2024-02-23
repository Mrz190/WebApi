using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiCourse6_7.Migrations
{
    /// <inheritdoc />
    public partial class UpdateJsonPointsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PointDescription",
                table: "PointOfInterests",
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
                values: new object[] { "Aute et labore do magna voluptate aute et anim. Voluptate minim id consectetur nostrud. Velit eiusmod commodo tempor voluptate aliquip aliquip sit aliquip nisi dolore aute eiusmod deserunt commodo. Exercitation Lorem sunt consectetur dolor esse eu commodo non quis eu ipsum incididunt ut labore. Magna consectetur sit cillum culpa et nostrud dolor excepteur veniam. Ullamco aliqua consectetur aute nisi occaecat.\r\n", "Morris" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Nisi non velit elit tempor minim minim qui pariatur et. Duis minim magna laborum est. Elit in commodo commodo labore laborum ullamco sunt qui laboris id eiusmod qui in. Esse est magna ad officia sint tempor fugiat dolore nostrud aute labore. Tempor dolore veniam nulla aliqua aliquip excepteur commodo voluptate proident cillum. Adipisicing ad enim aliquip ex voluptate sunt velit cupidatat.\r\n", "Staci" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Consectetur nostrud quis eiusmod amet sunt pariatur consectetur. Ut dolor laboris qui quis ex veniam labore nisi in consectetur. Ex elit id excepteur velit aute tempor.\r\n", "Davis" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[,]
                {
                    { 4, "Et adipisicing ut aute nostrud qui esse. Excepteur aliquip aute proident nisi. Irure ut cupidatat veniam adipisicing elit dolor mollit elit veniam non. Aute aute exercitation sit enim quis commodo sit ullamco amet ad esse tempor.\r\n", "Olivia" },
                    { 5, "Sint enim velit fugiat pariatur minim est voluptate ullamco cillum aute nostrud. Proident nostrud quis est voluptate esse. Tempor mollit amet adipisicing adipisicing ex minim quis commodo ex excepteur fugiat cupidatat cupidatat. Eiusmod laborum aute consectetur pariatur. Nostrud non ea amet voluptate. Ex elit sit nisi irure laboris laboris est cupidatat in consectetur exercitation tempor.\r\n", "Klein" },
                    { 6, "Dolor elit proident consectetur ullamco cillum dolore exercitation cupidatat consectetur consectetur ex incididunt ullamco consectetur. Ut tempor minim irure elit non eiusmod eu magna sint nisi nisi excepteur cillum nisi. Irure cupidatat nisi elit eiusmod laboris consectetur incididunt excepteur qui enim fugiat.\r\n", "Young" },
                    { 7, "Culpa quis deserunt culpa excepteur ea ullamco id nisi irure. Consectetur veniam ullamco quis eu ullamco eiusmod. Ipsum aute fugiat nulla exercitation id eu reprehenderit ut incididunt dolor in pariatur. Tempor elit in cillum dolor labore consectetur in velit exercitation reprehenderit.\r\n", "Roach" },
                    { 8, "Aliqua cupidatat anim irure nostrud nostrud sint reprehenderit anim nisi ullamco labore amet. Amet eiusmod quis pariatur incididunt incididunt reprehenderit et tempor qui consequat laboris labore. Eu aute ipsum in minim exercitation sint. Culpa laborum tempor labore mollit pariatur tempor sint. Qui deserunt aliqua duis adipisicing esse commodo excepteur exercitation dolor excepteur commodo. Et culpa pariatur irure aliquip sunt qui tempor mollit magna commodo laborum in commodo.\r\n", "Paula" },
                    { 9, "Dolor id id enim minim pariatur sunt exercitation. Ut esse officia quis consequat pariatur commodo mollit. In aliquip reprehenderit incididunt ex esse eiusmod est anim veniam fugiat laboris officia. Amet ex dolore in voluptate excepteur. Voluptate sint ipsum ut consectetur cillum. In reprehenderit magna officia ipsum elit adipisicing enim exercitation adipisicing.\r\n", "Sherrie" },
                    { 10, "Velit aliquip eiusmod ex fugiat et excepteur sit voluptate laboris aute officia. Aliqua proident reprehenderit aliqua mollit aliqua consequat anim. Cupidatat irure pariatur reprehenderit nisi veniam.\r\n", "Blair" }
                });

            migrationBuilder.InsertData(
                table: "PointOfInterests",
                columns: new[] { "PointId", "CityId", "PointDescription", "PointName" },
                values: new object[,]
                {
                    { 1, 1, "Ex qui aliquip aliqua velit eiusmod. Lorem consequat proident cupidatat duis consequat. Tempor eiusmod magna minim aliqua Lorem magna incididunt voluptate in consectetur enim ex. Cillum duis qui occaecat consectetur non proident consequat proident laborum ex incididunt quis. Irure exercitation sunt minim tempor laborum.\r\n", "Fleming" },
                    { 2, 1, "Veniam velit eiusmod sit aute non. Ullamco officia in consectetur Lorem tempor ipsum ullamco laboris voluptate minim proident. Cupidatat id dolore deserunt magna cupidatat non incididunt. Eu commodo cillum laborum laborum in duis incididunt duis laboris. Deserunt enim reprehenderit exercitation occaecat aute cillum voluptate nisi ad ex sint irure do. Reprehenderit labore eu id proident ad occaecat aute sunt.\r\n", "Ortiz" },
                    { 3, 10, "Anim laboris minim elit consectetur. Proident duis ut dolor amet sunt veniam pariatur laborum esse exercitation adipisicing sunt adipisicing. Exercitation veniam tempor labore veniam consequat anim laboris labore qui mollit do cillum duis.\r\n", "Ashlee" },
                    { 4, 10, "Ad cillum occaecat consectetur id do. Irure deserunt aute anim magna proident duis reprehenderit enim aliqua aliquip do labore. Esse commodo elit deserunt laborum sit.\r\n", "Carey" },
                    { 5, 10, "Elit amet labore aute aliqua pariatur proident fugiat dolore non ut pariatur ut. Esse Lorem veniam dolor dolor ea. Enim et sunt nisi ut culpa aute ea et pariatur irure labore ad. Occaecat labore ea in adipisicing cupidatat. Adipisicing Lorem consectetur eu laborum sit cupidatat ullamco eiusmod.\r\n", "Hattie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9);

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
                table: "PointOfInterests",
                keyColumn: "PointId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PointOfInterests",
                keyColumn: "PointId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "PointDescription",
                table: "PointOfInterests",
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
                values: new object[] { "Cillum nulla culpa nisi commodo. Veniam adipisicing ipsum consectetur cupidatat exercitation nisi quis. Ea non labore dolore officia amet do commodo cupidatat. Sunt irure ut quis ea dolor labore incididunt. Elit occaecat commodo mollit ex excepteur nisi. Magna ad ipsum dolore eiusmod ea eiusmod anim in dolor incididunt labore.\r\n", "Monroe" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Deserunt tempor incididunt nulla veniam cillum esse in elit. Consectetur quis laboris ut ipsum ea qui officia dolore excepteur enim quis elit cupidatat. Dolore cillum nisi incididunt laboris mollit nulla sit irure esse velit labore sunt tempor voluptate. Qui do velit nulla nulla mollit amet proident minim veniam cupidatat duis non. Incididunt Lorem ullamco ut proident commodo tempor in cillum nulla esse sunt pariatur consequat non. Mollit est commodo magna amet ipsum aute sunt amet qui ullamco dolore aliqua cupidatat.\r\n", "Anna" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "CityDescription", "CityName" },
                values: new object[] { "Est duis proident duis occaecat duis nostrud voluptate quis dolore. Anim ea velit eu elit. Minim aliqua labore est do ut elit tempor ex eu. Exercitation do cupidatat Lorem dolor fugiat commodo fugiat est. Mollit amet tempor eu consequat nisi Lorem incididunt commodo anim eiusmod sunt.\r\n", "Mae" });
        }
    }
}
