using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiCourse6_7.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CityDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                });

            migrationBuilder.CreateTable(
                name: "Photo",
                columns: table => new
                {
                    PhotoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photo", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PointOfInterests",
                columns: table => new
                {
                    PointId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PointName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PointDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PointOfInterests", x => x.PointId);
                    table.ForeignKey(
                        name: "FK_PointOfInterests_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WasCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserPhotoPhotoId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Photo_UserPhotoPhotoId",
                        column: x => x.UserPhotoPhotoId,
                        principalTable: "Photo",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityDescription", "CityName" },
                values: new object[,]
                {
                    { 1, "Laboris qui sit irure minim est. Et sit Lorem qui do irure esse aliqua eiusmod ex ullamco ullamco sunt exercitation. Occaecat enim consequat reprehenderit in proident officia irure cillum. Dolor pariatur consequat officia tempor in. Exercitation Lorem in occaecat pariatur amet. Excepteur minim veniam est laboris labore Lorem non cupidatat dolore enim.\r\n", "Kennedy" },
                    { 2, "Deserunt adipisicing ullamco officia Lorem mollit officia eu sit. Voluptate in elit commodo elit sit veniam sunt mollit ea labore duis laborum tempor nulla. Aute Lorem tempor et dolore cupidatat enim elit cupidatat aliqua in dolor cillum. Ad voluptate eiusmod id ut.\r\n", "Hull" },
                    { 3, "Officia aliqua id adipisicing elit sint aliquip consectetur do eiusmod. Occaecat ipsum ex nisi reprehenderit exercitation non proident occaecat aliquip anim ut veniam. Cupidatat irure eiusmod ex nostrud consectetur aliquip nostrud magna sint ullamco anim Lorem. Eiusmod consectetur culpa nostrud reprehenderit et commodo occaecat aute exercitation aute do. Duis sunt irure quis labore consectetur nulla consequat incididunt velit. Mollit ex commodo incididunt qui.\r\n", "Gilliam" },
                    { 4, "Eu consequat occaecat Lorem incididunt sit fugiat ex duis cupidatat. Ea deserunt cupidatat nostrud pariatur fugiat. Velit exercitation veniam aliquip nulla quis ex ipsum quis voluptate mollit duis incididunt. Aliquip nostrud cupidatat Lorem sit amet ea. Ipsum id consectetur ex consectetur. Consectetur ipsum id eiusmod officia esse ea. Ut tempor enim veniam ipsum irure sunt.\r\n", "Corrine" },
                    { 5, "Culpa duis eiusmod do eu amet in ea laborum aliqua. Ad eiusmod magna minim dolor ullamco quis nulla do mollit eu magna. Mollit nulla magna culpa voluptate cupidatat proident incididunt aute Lorem nisi eu laborum. Aliqua do mollit esse duis ad sunt ipsum adipisicing nulla tempor sit.\r\n", "Hughes" },
                    { 6, "Quis labore ipsum sunt est. Ex sunt culpa tempor duis duis irure excepteur. Occaecat officia deserunt in aliqua. Aliquip consequat labore elit nulla velit cillum anim commodo ea et incididunt ex est velit. Ad sunt ea velit culpa minim.\r\n", "Lindsey" },
                    { 7, "Eu culpa est consequat ut irure eu incididunt ad reprehenderit ullamco cillum cillum. Amet sint deserunt do in mollit. Cupidatat do anim elit sit et elit.\r\n", "Christi" },
                    { 8, "Laborum aliquip laborum qui commodo commodo eiusmod mollit reprehenderit ipsum ex dolor culpa. Officia nostrud dolor eiusmod ut amet. Sit ut elit nulla ex pariatur nulla do et aliqua deserunt quis irure excepteur et. Officia consectetur tempor mollit ullamco.\r\n", "Dale" },
                    { 9, "Aute cillum eu aliquip consequat nostrud officia sunt proident cillum eiusmod voluptate dolore exercitation ut. Dolore sunt sunt dolore nulla aute. Qui amet laborum est deserunt aliquip duis duis sunt. Do laborum fugiat ad laborum tempor. Incididunt in ex labore esse irure. Aliquip sunt proident commodo irure. Labore cupidatat est et sint aute laborum ex ea ullamco minim et incididunt laborum.\r\n", "Krystal" },
                    { 10, "Fugiat est ad magna ipsum. Officia veniam minim mollit ipsum voluptate ipsum ea aliquip labore adipisicing duis aute non. Excepteur consectetur quis fugiat incididunt cupidatat culpa ut est commodo non qui sit amet. Adipisicing commodo velit Lorem laboris adipisicing. Consequat ea fugiat enim nulla eiusmod non laboris duis aliquip ea. Cupidatat adipisicing esse aute Lorem est nisi ipsum ut ad consectetur incididunt sunt sint. Enim tempor culpa incididunt consequat Lorem cupidatat irure est ipsum.\r\n", "Sawyer" }
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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_UserPhotoPhotoId",
                table: "AspNetUsers",
                column: "UserPhotoPhotoId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PointOfInterests_CityId",
                table: "PointOfInterests",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "PointOfInterests");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Photo");
        }
    }
}
