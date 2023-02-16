using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TimeForAHailMary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60de7e58-232d-4daf-9bac-f634b4bd2db8", "5f5c6238-f4ba-4c07-b507-54e49d15ce15" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0089b683-549c-4b35-a178-9157b5598173", "9b712793-d901-4fb0-be02-2d1e09b182d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bd7a767-7e56-49ac-86e0-f12ca2d96358");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b869c7-a09d-4568-9caa-55e5745e8247");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "420cfc75-d671-4bb9-83e8-2f9f845f8d5b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66e70e5e-a750-456c-8418-405fee9e6dfd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0c2db33-d6bf-4fc4-bb5f-51e32129ae03");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e62207db-787e-46aa-94b9-06013ef49302");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0089b683-549c-4b35-a178-9157b5598173");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60de7e58-232d-4daf-9bac-f634b4bd2db8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f5c6238-f4ba-4c07-b507-54e49d15ce15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9b712793-d901-4fb0-be02-2d1e09b182d9");

            migrationBuilder.CreateTable(
                name: "LibraryAccount",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    roleId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryAccount", x => x.id);
                    table.ForeignKey(
                        name: "FK_LibraryAccount_AspNetRoles_roleId",
                        column: x => x.roleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LibraryAccount_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08d43237-cb18-49d2-8e28-5f869fabc870", null, "borrower", "BORROWER" },
                    { "62b5ffe0-a8b4-4d47-a0a1-3ef6301a340d", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34b49c0a-31a5-4080-9cdd-81efc7ad00e9", 0, "ebe6b623-29f8-4e96-93b4-346b1d0bf416", "jamie.koss@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEN0QJewhDoG8omcGi90hbVgxKEByiB2vCWjcghj+C3nIW16Rre08gkKqHHTBywXYuA==", "567-929-3837 x112", false, "c9b652b0-a4d2-4137-9646-c4fc7b041d43", false, "Jamie.Koss" },
                    { "356bbcaf-dafa-4a7d-b854-b3166de75abf", 0, "74e40d7a-b1e9-4ab1-9c3d-bd137a91f2fa", "mack_macejkovic@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHVCiIT/WybuMPmJRIcN7ayF0v/Em3ZqM1SDh8mDXfoWLqmZMhC+lGLhjAomw/PEag==", "536-631-1362", false, "6aeb7c80-f9ae-4c8b-937e-b47500aad1ab", false, "Mack_Macejkovic" },
                    { "3c9a4436-3772-4abb-88b8-9ee540b20892", 0, "5796ca3f-b64a-4042-b42e-087fec535f19", "sean35@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKE3uVZ0ePAMYvdV9Js3vOgx2jKtPFSzdlfaBGOJcbXGF8xBgBKvr5oLio9q8FU6Cw==", "1-851-279-1852 x6515", false, "8f19bcb9-0da0-4ef2-bd25-02aa085e9d85", false, "Sean35" },
                    { "427351be-1b26-4626-b357-c5ae84eead05", 0, "be4267b3-2608-4fef-b577-3346dd672c20", "mae_okeefe96@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEC2DpvTBz09B7XAqR+CvfRUHVjvaquQo6qk1OdOJfmfgzToW6wVSZxG/IL7U9/b7cQ==", "687-873-4392 x182", false, "f4f07c32-7960-47d2-876a-cd5f7c54b965", false, "Mae_OKeefe96" },
                    { "4cc72103-7d4f-4f7a-90cd-a2b4fb84ec05", 0, "9c034321-a506-415e-93ea-0aee19bd2c09", "jose.torphy58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGtZY+YIBeEon71zWTYbkGkiSn18fcppnE/QYOc3bZEDL1DcpWEFNXK4JkrOqt4ttQ==", "372-553-3796 x546", false, "a1cb8d2b-5567-4234-a809-0348dccd7753", false, "Jose.Torphy58" },
                    { "4fe8d111-8318-4b0e-ab47-aa9f0ae4cd44", 0, "b38f27f0-b020-446f-91e0-a3c9b0b940ed", "jaime63@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELy/fYQ7CBJGELRW9+7c/0N2QqSABFOVUUSmOLWiQpmCmxQbbKkGAOktZGqWFsm7EQ==", "1-929-552-2936 x2998", false, "f1e32d40-02ce-4361-9cb2-14dc79f947ea", false, "Jaime63" },
                    { "58102116-995a-45b0-8c24-4208d18fe01a", 0, "3aada88b-6154-4714-9e92-79cc96655115", "fredrick.nitzsche92@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDRS0Gi4ulNXp5IUWKUCJc9CWcWHBOuZBtaBksIyUG1c2qcNr+lWOXDS9FVQwLhDIg==", "943.359.1523 x2159", false, "ba6086f3-0b96-4c2e-b7dd-0fc6f7143eaa", false, "Fredrick.Nitzsche92" },
                    { "5de06156-fa27-463d-8586-b63f0a8801c7", 0, "4666a64a-6ff4-4e84-ac27-1f5bbec60e9d", "pamela.kreiger32@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGrrar4dVNxO0t+GPmeFcKafmDKMHw79RvMSRqutIaxn2FSdQCCJ4DLgUhdUlDL0Qw==", "684.565.2269 x80579", false, "27aa5b87-8c60-4eae-98d3-5a62e17f635b", false, "Pamela.Kreiger32" },
                    { "62d86fd9-faa7-48a1-948e-43bad649a2cc", 0, "b610b1b8-2831-4968-bf48-3ccde558c0cc", "cassandra_stokes58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBE8bDzqHeGxI6sCGzHc06y4uT3uCLrpv4y5gE47jxnkPbz1v9F+zhA83e+B5QD8wQ==", "689-803-1873", false, "01b1c996-2e9b-472b-85bc-bb479c0d3747", false, "Cassandra_Stokes58" },
                    { "81ef8a18-f69d-4975-86ff-f236e3e01396", 0, "636fa142-0b3b-41fd-8a7b-ec997437c483", "damon_hamill60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ1kReb1nTcV4Xpqfm81A5SXTitIbajvNnh59FZCVDWKKodi3ff8fWdKeCVYNZwIpg==", "956-615-7855", false, "ba6b566d-f69d-4279-8a01-942f91eeb234", false, "Damon_Hamill60" },
                    { "a3621fae-dcab-4b7b-8c4b-d5f76e82503d", 0, "bf9f33c1-e227-400a-a480-10a1f1d983da", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEGdX18xuqJGFJ4K+21n3C4Gvnnt4ymgPwpv3OtmdjgyA4b9v6UUfUpaJGf4XtsiKsw==", null, false, "09302555-dbde-4dfa-8e62-97f43ac1d038", false, "borrower@library.net" },
                    { "ae0d72e4-3ee3-4bae-aecc-c2db78546794", 0, "04faf49f-5360-496b-8d90-3491dc0492e7", "erma9@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKHfY2wa67cOE+zlG0rTFO78/CTCclvOBX7auxAujscKiW3pm31/KRVMJQkBM+3ToQ==", "212.996.6115", false, "461417fb-a452-4cf1-95c0-5f006b2a49f8", false, "Erma9" },
                    { "da84a640-6d6c-46f0-a58c-3c52cfbcd67e", 0, "5202175a-bfee-4fff-acf4-07827e77dbb1", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEI7TU3HNdIwlcNwFxO1QJdG1w8E6iK4cjx5r/lsjL/ifhz8TdqYgUOWuSa08SQ0bbA==", null, false, "94b8d769-4eb6-48e0-b810-2719ec8fc3f3", false, "librarian@library.net" },
                    { "e2e61828-9f0f-4e29-ae15-51d6846e7225", 0, "1e9cdc53-eb22-4bfc-9f1f-1447e92b3e7e", "christine.kautzer@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMOM34UZXaY6jpnsW78U8MhGULLdwCexKMzBH+7Tz4EPFPI9JrITxtsXVpiFGAoQzQ==", "(275) 577-2958", false, "73df5370-c8f7-4f41-bc0d-3462fdbc16bd", false, "Christine.Kautzer" },
                    { "e860048f-4f5f-4ef0-8e36-00d2e1fb667b", 0, "bbe10cfc-4b5b-4921-9d61-a043a7cbde33", "penny57@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJjjmtF6aqiiJWoD1mHU7A675QiqBKd+7kFFO5uXXFT2qCf8xgwX9TitVWD46oNJBg==", "448-335-7238 x47707", false, "79dc5b24-7b0c-4096-af7c-466f18eabd5d", false, "Penny57" },
                    { "ef3f0fa0-24bd-4947-a26b-d45c15281915", 0, "f1905ee5-4763-474d-b3ba-f1859423b092", "horace.jacobi@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOTpBwsWX7b0spZJ1jX05N/PKkokF01hy1ZKj6JkBIpadGz5pVeOrVC/sLC5v4Zunw==", "667.928.2271", false, "0f9a5bec-16be-4b5c-80ee-d90a99904e88", false, "Horace.Jacobi" },
                    { "f72a97b6-24da-41b8-a010-58f5612381fe", 0, "d721cf1f-a91e-404d-b2e6-54b394b5168f", "debra.sipes@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOTM7LD8Go/At9HUTrhhmlbXIaxIbjL1JhIE1KyQfcOAkt8w/2rGsmZfx1T8/QMlyw==", "(209) 471-5532", false, "4596039d-dc7d-47a7-a47d-555525fa0b1c", false, "Debra.Sipes" },
                    { "fe93a57a-54a7-4b93-a522-681ec7a444c0", 0, "a883976c-514c-4cf0-8fa8-d5821492665c", "julie.lubowitz@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOvRgPaS1jaxeKor0jtKmXgharhLX84H6y7+/3RHjAvFeGt9FsZ4c+IHog3H/bl/qQ==", "581.569.7578", false, "9cfffbb6-c072-4ae5-b450-43b82e258b78", false, "Julie.Lubowitz" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Estelle", "Bashirian", "Iusto omnis recusandae soluta totam animi voluptate. Omnis rerum omnis eius minima est quidem aut enim impedit. At ad voluptas est saepe. Magni deleniti harum veniam.", "Monitored solution-oriented system engine", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Laurence", "Price", "Libero et aut vitae autem. Iste nemo non quia qui praesentium sed. Eos sequi voluptatem et voluptatem aliquam id quaerat voluptatem aut.", "Integrated cohesive task-force" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Samuel", "Conroy", "Sit deleniti facere rerum et. Expedita aliquam est voluptates et. Rerum repellat adipisci quidem veritatis repellendus explicabo soluta. Ut dolore ipsum dolorem error voluptatem sed quaerat. Occaecati eum est optio voluptatem velit aliquid.", "Balanced holistic monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Verna", "Goldner", "Rerum eum corrupti ea aut ex nihil cumque minima. Voluptas et nulla qui voluptatum qui et. Quidem quas incidunt perspiciatis sit quis maxime sit deserunt. Dolor dolor omnis. Autem ut ad cupiditate.", "Optimized leading edge hierarchy", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Craig", "Bednar", "Odio magni quis deleniti officia vero. Sit saepe quos voluptas et quod animi. Dolorum incidunt nihil provident et cumque voluptatem est. Dolorem sequi fugit in alias deleniti sint autem.", "Down-sized bifurcated projection" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Salvador", "Lockman", "Earum facilis laborum perspiciatis doloremque fugit qui placeat. Dolores vel a eos sint iste porro. Nostrum dicta sit quia aut quibusdam eum aut vitae aliquam.", "Visionary multi-tasking standardization", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Johnny", "Hessel", "Occaecati est architecto. Molestias inventore repudiandae temporibus amet. Omnis quo eveniet deleniti.", "Quality-focused directional Graphical User Interface", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Christy", "Strosin", "Libero neque voluptatem laborum. Adipisci quia qui qui distinctio asperiores rem. Quia atque laudantium voluptatem.", "Focused discrete interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Oliver", "Reinger", "Inventore sunt ut aliquid et nulla laudantium est sit ab. Repudiandae enim aperiam eos expedita fugit iste. Voluptates quas at illo. Magni ut molestiae aliquam earum id nostrum perspiciatis nulla fugit.", "Total secondary orchestration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kristen", "Upton", "Aut eveniet facilis. Unde officiis provident et molestiae. Est praesentium exercitationem ut totam enim autem voluptatem magni earum. Odit suscipit sit minus et voluptate sapiente saepe quia maxime. Velit quis et nihil maiores nam voluptatem soluta rerum. Commodi dignissimos nihil nihil corporis explicabo accusantium molestias rerum.", "Implemented global toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Maria", "Lindgren", "Ea omnis sit aut ut nemo ut quia. Veniam ex error harum eum sit provident voluptas incidunt autem. Aut dolore ex esse minus vero. Et voluptatibus debitis tenetur. Hic tempore necessitatibus rerum dolorem molestiae alias esse excepturi quae. Accusantium est dolorum.", "Future-proofed regional capability", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Antonia", "Turner", "Ut veritatis cumque. Id libero et sint sit sapiente optio aut quia voluptatum. Voluptatem consequatur aliquid omnis rerum at aut vel minus assumenda. Voluptatibus commodi exercitationem dolor quae voluptatem dolor ipsum.", "Organic global pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Justin", "Howe", "Quos et quaerat quisquam eum non saepe possimus consequatur. Quam minima voluptate minima magni sapiente excepturi nesciunt. Nobis ut sint exercitationem in. Dolor et esse deserunt libero dolores. Nulla aspernatur nihil alias.", "Enterprise-wide asynchronous time-frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Patrick", "Christiansen", "Illum est qui. Non suscipit porro assumenda quis vel. Doloremque ad ut qui voluptas aut. Vero illo tenetur corrupti nulla excepturi possimus cupiditate accusantium.", "Ameliorated 4th generation utilisation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jack", "Watsica", "Laborum vero aperiam. Qui omnis ut earum qui modi accusantium cumque. Cumque suscipit accusamus error voluptatem aspernatur ea.", "Virtual dedicated implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Claire", "Streich", "Error iusto ea velit magnam. Dicta esse debitis consectetur enim libero nostrum nam. Placeat voluptatem tempore ab. Atque ab nobis delectus consequatur itaque tenetur ipsum qui. Dolorem quia sunt culpa cumque aliquid quo vel. Ex est et soluta autem facilis cum ut est consequatur.", "Automated regional methodology" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Meredith", "O'Connell", "Odio et est porro debitis velit perspiciatis dolor molestiae. Aut aspernatur id pariatur id quia dolorem. Maiores veritatis aut recusandae qui ea nam at sunt similique.", "Versatile eco-centric instruction set", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Matt", "Hoeger", "Doloribus ducimus architecto. Minus quaerat unde neque vel officia. Illo ut iure et aperiam officia quasi suscipit. Impedit sit explicabo id ea et soluta.", "Organized reciprocal workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Cecelia", "O'Hara", "Quo qui perferendis assumenda et ex excepturi nam quia repudiandae. Necessitatibus debitis officia ad illum quis dolorem iste. Sed optio quo possimus amet soluta. Dolorem aspernatur perspiciatis nihil est laborum ducimus. Ratione soluta fuga blanditiis vel. Modi enim omnis.", "Cross-group bi-directional neural-net", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Joan", "Dooley", "Natus minima aut pariatur velit saepe eum dignissimos molestiae ducimus. Voluptatum aliquid voluptas voluptatem natus illum delectus occaecati vel error. Fugit quisquam quos at iusto minus commodi. Temporibus quibusdam quia qui.", "Horizontal interactive moratorium", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Casey", "Weber", "Quasi aut ut. Ad cupiditate id labore impedit incidunt repellendus facere sit et. Et quisquam consequatur. Quaerat perspiciatis delectus atque ullam.", "Business-focused intangible alliance" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ronnie", "Bruen", "Alias ut laborum. Suscipit sequi quis ut ea nostrum et quia et. Accusantium minima omnis velit commodi non. Labore earum quaerat.", "Team-oriented web-enabled extranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wesley", "Krajcik", "Ut perferendis voluptate officiis laudantium ipsum minus ipsa fuga. Non laudantium voluptate voluptatum praesentium sed accusantium praesentium ipsum. Assumenda quod aut incidunt eius qui itaque enim. Voluptas est qui vel voluptatem omnis consequatur maiores sapiente dignissimos.", "Intuitive intermediate workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jasmine", "Stokes", "In provident voluptas consequatur tempora. Repellendus ratione sit accusantium a nostrum optio. Officiis labore hic et et soluta accusamus accusantium voluptatum illum. Sit enim eaque et dolores laborum qui aut.", "Multi-layered intermediate knowledge user" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sophie", "Johns", "Blanditiis laudantium nulla itaque natus iure quia doloremque aut. Occaecati hic aliquam harum et quod quos maxime officia. Aut sint recusandae quas vero facere incidunt. Voluptas ipsa placeat totam soluta.", "Front-line stable toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Noah", "Kuvalis", "Voluptatum architecto est qui deleniti deleniti. Eius iure voluptas magni quia occaecati corrupti. Debitis voluptas aperiam reprehenderit est repellendus officiis qui assumenda. Omnis nisi et. Velit dolores rem.", "Synergized context-sensitive matrix" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Benny", "Bednar", "Reprehenderit sint eos voluptatem non. Magnam velit molestiae tempore perferendis odio et ut. Repudiandae accusamus alias dolores optio et esse facilis at. Voluptatibus sunt vitae voluptatum quo. Vel eum quaerat odio et sunt et error facere qui. Id non dolor quibusdam nihil laborum nesciunt necessitatibus enim dicta.", "Intuitive even-keeled initiative", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { 28, "Lana", "Feeney", "Qui aut fugit quidem nihil accusantium doloribus qui exercitationem explicabo. Sint debitis rerum doloremque voluptatem numquam beatae est. Ex nisi nobis ut est minus. Eum sit culpa architecto pariatur perspiciatis similique tempora et vero. Ut fugit et distinctio non quia maiores et.", "Grass-roots incremental capability", false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08d43237-cb18-49d2-8e28-5f869fabc870", "a3621fae-dcab-4b7b-8c4b-d5f76e82503d" },
                    { "62b5ffe0-a8b4-4d47-a0a1-3ef6301a340d", "da84a640-6d6c-46f0-a58c-3c52cfbcd67e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAccount_roleId",
                table: "LibraryAccount",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAccount_userId",
                table: "LibraryAccount",
                column: "userId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryAccount");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08d43237-cb18-49d2-8e28-5f869fabc870", "a3621fae-dcab-4b7b-8c4b-d5f76e82503d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "62b5ffe0-a8b4-4d47-a0a1-3ef6301a340d", "da84a640-6d6c-46f0-a58c-3c52cfbcd67e" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34b49c0a-31a5-4080-9cdd-81efc7ad00e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "356bbcaf-dafa-4a7d-b854-b3166de75abf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c9a4436-3772-4abb-88b8-9ee540b20892");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "427351be-1b26-4626-b357-c5ae84eead05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4cc72103-7d4f-4f7a-90cd-a2b4fb84ec05");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fe8d111-8318-4b0e-ab47-aa9f0ae4cd44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58102116-995a-45b0-8c24-4208d18fe01a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5de06156-fa27-463d-8586-b63f0a8801c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62d86fd9-faa7-48a1-948e-43bad649a2cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81ef8a18-f69d-4975-86ff-f236e3e01396");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae0d72e4-3ee3-4bae-aecc-c2db78546794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2e61828-9f0f-4e29-ae15-51d6846e7225");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e860048f-4f5f-4ef0-8e36-00d2e1fb667b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef3f0fa0-24bd-4947-a26b-d45c15281915");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f72a97b6-24da-41b8-a010-58f5612381fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe93a57a-54a7-4b93-a522-681ec7a444c0");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08d43237-cb18-49d2-8e28-5f869fabc870");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62b5ffe0-a8b4-4d47-a0a1-3ef6301a340d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3621fae-dcab-4b7b-8c4b-d5f76e82503d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da84a640-6d6c-46f0-a58c-3c52cfbcd67e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0089b683-549c-4b35-a178-9157b5598173", null, "admin", "ADMIN" },
                    { "60de7e58-232d-4daf-9bac-f634b4bd2db8", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1bd7a767-7e56-49ac-86e0-f12ca2d96358", 0, "dfc89dd2-25d1-4781-8b40-a8032ac7dfd1", "bruce18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ5FbluddC+H22gzQamnwaSkpWzEhYOa1aHGhuOg/cBHVerpc49hPXr9ehnhcHPQ/Q==", "(521) 984-5384", false, "9963dac9-aecb-40fd-9c7d-b112f67010c4", false, "Bruce18" },
                    { "39b869c7-a09d-4568-9caa-55e5745e8247", 0, "699ebca9-ed10-41b4-b8d9-42545968d1e7", "doris_kassulke@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECp4DIKbYCxv1M2R6QuFiy7RGE/78/A+aXiljF2cbQqgKtCAVIOhvF6ZqdqRSPi8RQ==", "556-391-9785", false, "1d920ef5-8d0a-4b32-9dfe-5a2676e94cab", false, "Doris_Kassulke" },
                    { "420cfc75-d671-4bb9-83e8-2f9f845f8d5b", 0, "5aaa2f7e-522e-4afc-ade6-fe005e3a2855", "tricia45@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP/pFACcQYIsdo+50Rl3K0RGa4EfAe23ZeKOJLsEG0MxceZEsp57MfBAHmEO3RLx8w==", "(671) 905-0780 x846", false, "2b1ddaa1-b0e4-4840-bb17-30c300269cd5", false, "Tricia45" },
                    { "5f5c6238-f4ba-4c07-b507-54e49d15ce15", 0, "71cb4541-0e75-44f3-9573-0462fde49d10", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEMPPXx4hPiub8hQyI6x9sWcJL1SHlGzJ/VHLvkyt7osy2YKHg6y6OpcCCbUQCSITog==", null, false, "2df788a3-01a3-4c8b-927f-12e196675b06", false, "borrower@library.net" },
                    { "66e70e5e-a750-456c-8418-405fee9e6dfd", 0, "07c3c641-c083-4d4f-af9f-9073b5be51fa", "nellie60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPutpvAjuR7RkRfDLHyEf78CIs+B2nfI9Wk4w2wzg9Wdkxg/i/s9/ABj6abF8+fvUA==", "(252) 751-1334 x33386", false, "6250c100-b941-4a9d-8559-bbcd8b5ed921", false, "Nellie60" },
                    { "9b712793-d901-4fb0-be02-2d1e09b182d9", 0, "32e0cfd7-7c31-4c38-b83f-ba6ff5288ffb", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEIL1e56oW6RBKPhWaZ0G9Yf9ZsTY5xcMsV+nqmuyd6rQcj2bCkGX7Rym9eaLXB5JWA==", null, false, "ef3fcd76-1ad7-43f8-9bc3-ef41d97b81a6", false, "librarian@library.net" },
                    { "e0c2db33-d6bf-4fc4-bb5f-51e32129ae03", 0, "b12fd656-f2c2-4c97-9199-799d986755c9", "viola_daugherty@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBXEU70Dsr0+/8YehKsiJELJjUwRtNXWpcfFzLLtwewVxe2BO5cDrPPLXcf6HqXmwA==", "1-286-706-6935", false, "98a8962e-ba46-43bc-aaec-0a2a1169fdf9", false, "Viola_Daugherty" },
                    { "e62207db-787e-46aa-94b9-06013ef49302", 0, "790ebe5c-5bfd-43c2-93eb-c9b17e0f053a", "bethany78@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECJTt9ELN9vtkT1hR3F1fa96tzcsjh0FPTPYC46dUzTLjvc/VOxO+E9eUy8oKBteww==", "310-935-8145 x1136", false, "f7fe46b2-8ef9-46e4-b4b6-83e0ac8b8388", false, "Bethany78" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elijah", "Beier", "Ut voluptas neque rerum adipisci. Veniam fugiat repellat non. Non libero sapiente harum nam excepturi. Ut animi officiis perspiciatis id corporis recusandae repellat voluptate sit.", "De-engineered bi-directional database", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Charlie", "Tromp", "Magni est rerum vel eos quisquam unde ex. Qui dolorem labore voluptas aliquam adipisci ad sunt. Inventore in corrupti corporis eligendi eius hic tenetur. Velit fugiat et aut. Non et maxime rerum quasi exercitationem explicabo.", "Digitized eco-centric capacity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marsha", "Rosenbaum", "Officia atque id aut sit sit illo sunt est. Accusantium accusantium et expedita explicabo. Veniam voluptas quia placeat fugiat placeat. Architecto velit ipsa consequatur alias eveniet tempore numquam inventore voluptatibus.", "Adaptive impactful matrix" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Olive", "Windler", "Voluptates alias fugiat odit laudantium quae iste eos. Ea et autem maiores odit pariatur optio ut eum et. Ab dolorum aut voluptates dignissimos voluptates et soluta impedit. Dolorem labore voluptatem placeat ipsam culpa distinctio voluptatem voluptas. Est odit et explicabo. Ea fugiat voluptate rerum eveniet possimus porro culpa accusamus sunt.", "Function-based bi-directional framework", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Madeline", "Mitchell", "Culpa quaerat alias impedit est sunt. Quod eligendi et itaque enim asperiores autem consequatur aut unde. Vitae consequatur illum nihil id et eos dolorum. Quasi sint et sint ipsam ea nam nobis aut. Vel aut laudantium nisi aut culpa assumenda impedit aliquid quaerat.", "Balanced neutral capacity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Maria", "McCullough", "A et aut soluta non nihil omnis ab culpa. Repellat magnam eaque sint amet blanditiis odit nemo nostrum. Aliquam molestiae iusto temporibus praesentium qui praesentium quia. Aspernatur qui id qui. Consequatur reiciendis eligendi facere voluptatem.", "Reverse-engineered client-driven monitoring", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jody", "Walker", "Dolor eaque rem qui iste molestiae impedit est possimus. Corporis blanditiis consequatur ut rerum est aut quaerat. Et consectetur molestias corrupti quae error explicabo natus doloribus et. Culpa in sed itaque ut eos cupiditate. Beatae illum id magni nihil.", "Multi-layered solution-oriented instruction set", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Annie", "Denesik", "Quia optio ab inventore. Voluptatum sed dicta. Explicabo atque delectus nam. Repellendus ex velit eum et. Est asperiores quia dignissimos quae magni. Sint est et repellendus amet.", "Operative well-modulated synergy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Arturo", "Dach", "Consequuntur et est vel exercitationem occaecati qui nemo officia occaecati. Dolor delectus adipisci aut molestias. Laudantium qui quia amet.", "Centralized reciprocal attitude" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jackie", "Haag", "Labore voluptas in aut amet sunt quo quae itaque. Expedita rem corporis excepturi necessitatibus. Non sint non modi animi iure dolorum ipsa.", "Customer-focused intermediate strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Timmy", "Konopelski", "Perspiciatis sunt ipsam facilis rerum. Nemo veritatis voluptate minima quam eveniet ut sit. Beatae maiores a quia corrupti repellendus. Dolores doloribus labore culpa beatae nobis. Corporis ut deserunt non illo cupiditate expedita nemo distinctio.", "Cross-platform 24/7 hardware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Becky", "Abbott", "Quibusdam numquam qui nisi voluptatem eveniet nobis suscipit consequuntur. Quis dolores aut. Est aspernatur iure doloremque.", "Profound didactic success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Crystal", "Sipes", "Exercitationem quas illum et enim magni voluptates. Sapiente architecto id consequatur rerum maiores facere sint. Aperiam aut magnam quaerat exercitationem a autem. Ut voluptatem et incidunt facilis non delectus dolorem.", "Configurable regional benchmark" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ervin", "Miller", "Deleniti facere vitae labore consectetur nulla ad est. Ad alias eum eveniet sunt accusamus dignissimos omnis. Incidunt aut et ut dicta possimus earum. Rerum error alias. Aperiam repellendus ea est et id temporibus qui voluptas. Aut molestiae consequatur ratione nihil et.", "Self-enabling neutral solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Abel", "Langworth", "Non perspiciatis dolorem et in voluptate commodi non magni. Corporis optio et explicabo id voluptas consequuntur occaecati quis. Qui ducimus itaque cumque et doloribus.", "Ameliorated content-based access" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ida", "Vandervort", "Sit cum eum ex rerum repellendus repellendus dolorem. Delectus ea vel et reiciendis. Et veritatis quo. Et praesentium omnis aliquam occaecati et voluptas debitis qui.", "Total tertiary capacity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sam", "Beatty", "Quia eaque sapiente in. Quia laborum sequi occaecati aut. Nobis debitis atque ut. Dicta aperiam nulla perspiciatis quae nisi voluptatem in.", "Visionary needs-based artificial intelligence", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Cheryl", "Dibbert", "Eveniet blanditiis similique aut quis. Magnam ipsum voluptas sint. Est adipisci explicabo.", "Cross-platform solution-oriented hub", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Clarence", "Quigley", "Earum libero numquam impedit veniam mollitia quaerat numquam in. Nesciunt dolorem illo ad. Rerum dignissimos ut dignissimos nobis iure nam. Et iure quos.", "Seamless grid-enabled open system", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Archie", "Feil", "Velit occaecati aperiam voluptatem nihil minima qui. Qui provident in quis ut. Sed itaque soluta est sint eveniet ea et. Laudantium necessitatibus sequi.", "Profit-focused reciprocal task-force", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kelli", "Spencer", "Porro facilis voluptatem iste dolorem. Id et iste. Sed nostrum cupiditate nisi velit sint tempore quibusdam. Eum adipisci voluptatum velit illo aut vel pariatur aut.", "Devolved systemic neural-net" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elmer", "Green", "Autem ut ea beatae repudiandae natus nemo est et. Esse exercitationem architecto distinctio. Fuga odio sed sint quis. Asperiores optio labore ipsa ut iusto non omnis nobis voluptas. Et labore voluptatem et et. Dignissimos quibusdam corporis quo repellendus cupiditate.", "Face to face fresh-thinking methodology", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Richard", "Legros", "In ut blanditiis et itaque. Dicta voluptatem voluptas et minima omnis aliquam. Tempore excepturi excepturi eos tenetur maiores sed quasi. Aut nesciunt esse dolorem.", "Cloned intermediate knowledge base" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Derrick", "VonRueden", "Sapiente provident delectus. Odio commodi dolor magni ratione nulla. Quidem rerum sed esse nihil aut assumenda eveniet amet quaerat.", "Right-sized real-time help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Grace", "Collier", "Quibusdam quis sunt architecto non nihil. Rem expedita ex quia aut facere est rerum voluptas asperiores. Vero assumenda animi iste sunt dignissimos sint sed. Et aut autem voluptatum enim totam.", "Vision-oriented human-resource definition" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kyle", "Carter", "Id eum soluta nam sunt rerum occaecati unde temporibus. Mollitia distinctio voluptatum soluta fuga. Dolore cupiditate aliquid voluptatem et aliquid dolor ut. Itaque qui qui.", "Profound neutral leverage" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Judith", "Gutkowski", "Voluptas voluptatum minima voluptas rem. Non eos delectus iure nemo est amet vel. Commodi est reiciendis quae debitis praesentium pariatur. Magni rerum pariatur perspiciatis nemo harum vitae non expedita.", "Mandatory coherent success", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "60de7e58-232d-4daf-9bac-f634b4bd2db8", "5f5c6238-f4ba-4c07-b507-54e49d15ce15" },
                    { "0089b683-549c-4b35-a178-9157b5598173", "9b712793-d901-4fb0-be02-2d1e09b182d9" }
                });
        }
    }
}
