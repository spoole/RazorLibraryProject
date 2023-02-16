using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class LastShot : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5da953e5-c4c8-448c-8a15-3324e65a0d8c", "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5ce731b-b22e-4a51-b8af-eaf0b488064f", "c598d09d-85a8-4f1c-90d2-80437ec3b7d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f20a043-0310-4d3b-b3e5-9a6d675186c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11492cce-a85a-41a4-88be-593bb7a294a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2033b1e8-1932-42bf-9421-4b1595b0e18c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2257a18f-f789-4fbb-9b7d-8a13531e756b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24c0d8c3-a3f9-402b-a0b0-f6923f406fa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e0c24ba-ccee-4c78-bc02-eda76176bf33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "352667be-db7f-4cf2-99a5-f0038283888c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37a0eda6-7893-4754-9992-e0c601ef9b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b69c73c-1bb4-4423-8835-ed72c8c74603");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41ac32d7-3081-48af-96dd-4321c77af640");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a4d66da-18de-4299-b007-dbd99123489f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e10ec99-21fe-4ca6-93fa-1fb6dbbe2dbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79482d20-b4f2-496c-899f-b0d000d876a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94e3e662-cd88-4abc-928d-b81efa0ac168");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ee59f3f-cb59-4289-b886-9de499278a82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcb79b15-c3a8-4849-aa10-03eca7afd5f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2ada14b-6f38-4902-ae25-75ca4d9bf9da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4877640-43fb-47be-b242-10f20c021e41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58101d2-6e97-4df4-b03f-d35aed3417fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f62740f8-12ea-4821-a7f9-f7c46241326a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5da953e5-c4c8-448c-8a15-3324e65a0d8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ce731b-b22e-4a51-b8af-eaf0b488064f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c598d09d-85a8-4f1c-90d2-80437ec3b7d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c38ec56e-09f7-48e1-9cbc-205aafcc33bc", null, "borrower", "BORROWER" },
                    { "f0b9ffaa-b532-49eb-8e36-267542542a9c", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "019f9093-c805-4496-80c8-2a40346ee7f0", 0, "a4a218a5-e7d5-41d4-94ad-d0a24b454873", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEAhpFS/Pv1GRd9y7uxhf7GNwTpOm+AtHgMdALKiYcbO91Tf4OYkC8HNWp9nGiLwanw==", null, false, "81c35152-b23f-4be7-96d0-b3c4bd2a7bab", false, "librarian@library.net" },
                    { "39717a7f-7185-4e9f-a03c-28cc5a66da3e", 0, "91f9a8a1-ccdf-4478-b11f-8986d49d5258", "mathew12@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAED8K1j1tDqVYzUsiojmGijat96xRJZIe+6E5j6ITHa9TMEg/7LjCIv5iiI6BM0eszQ==", "626-865-6466 x63664", false, "44f348c9-cc41-462d-a6d6-f10b582d38de", false, "Mathew12" },
                    { "503214e4-8daa-429f-8c37-f3805639aeb7", 0, "c5c20397-81e6-46a9-800c-0e66d61214ed", "patrick.breitenberg53@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIY9k9sg0Y1WEpfPi6Wp1j/Hodnbc2wVgfOt7MwTXmsSXeL8q4cMMsFoJVnWmuOdwQ==", "(694) 593-8258 x16725", false, "8057915f-2836-4105-b2e9-d26b9fa0bebd", false, "Patrick.Breitenberg53" },
                    { "61cd5403-658f-42a0-bb30-297210bc1e12", 0, "2f08202f-eb7b-4244-aaee-b05f2cdd1459", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEPySGexLQYtwWWowZiUnve9UqkG874z767eT7tbRX3QOYdIwbRaob6TdyGyJxygpmg==", null, false, "9878aa2e-068f-49cf-a5c9-8c02d79f09a3", false, "borrower@library.net" },
                    { "8992c122-736f-48d7-acda-f2304252a767", 0, "a220dc20-5201-4c21-a735-e4c5c590a30a", "dale72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKclPieEpD0n87lsx7J58wV+z6orCPqfNuDU/IOudSI7pSNwyEciI5ik9YZ+84uzhg==", "588.337.8715 x83853", false, "cdc84548-69c7-4099-9eac-387ad4bc6123", false, "Dale72" },
                    { "f82267dd-3453-44d8-a9b4-b82cc757fc80", 0, "f1d95d26-d762-48da-8ed0-de490b5b7f0a", "jon_littel67@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGQdRGT7VML3g1ZGl5a8qozxDusI2k+OxQXV636nej2kI0DmqkWDzjWFLlJgBy030Q==", "847-640-8328 x0980", false, "b283d358-c65e-4daa-a3e3-93584281c18d", false, "Jon_Littel67" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rachel", "Gutmann", "Laboriosam et atque labore qui aliquam rem. Suscipit optio incidunt sunt. Magnam rerum in illum vel eveniet nisi. Nulla aut deleniti non accusantium omnis perspiciatis iusto enim consequatur. Sapiente vel odit molestiae numquam.", "Extended tangible workforce", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Stephanie", "Lubowitz", "Harum laudantium voluptas nobis eum odit sunt. Minus necessitatibus nesciunt corrupti odit rerum. Corrupti cum et quam doloremque aliquam in vitae minus dolore. Illo nesciunt dolor est quae in nam aliquam. Adipisci eos et voluptate corporis aspernatur quod suscipit.", "Object-based local implementation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nicolas", "Kris", "Quis enim alias ut officiis amet aut vero quos omnis. Autem distinctio temporibus. Velit eveniet natus praesentium aut corrupti ut a odio blanditiis. Optio cumque rerum reiciendis tenetur atque nam sed. Harum sint iure eligendi reprehenderit est. Animi laudantium doloremque cum quasi illum deserunt et fugiat.", "Innovative needs-based pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sylvester", "Conn", "Maiores delectus nam fuga aut aperiam. Repellat quia rerum debitis aut doloribus a fugit voluptatum. Minus voluptatem quia ut. Sed rem in perspiciatis. Saepe optio hic saepe aut pariatur velit ut.", "Polarised multi-state middleware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Randal", "Bartell", "Asperiores dolores nemo. Facere est minus aut qui fugiat sit aut. Saepe provident qui. Enim at quod optio perspiciatis ut nesciunt totam libero. Eos omnis amet eaque veritatis necessitatibus. Perferendis quos laboriosam et velit accusantium sit.", "Customizable heuristic emulation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mabel", "Carter", "Fugit aliquid non ex laboriosam ut dignissimos earum natus. Sint ea praesentium quia laborum et natus qui. Est repellendus modi dolores dolorem laboriosam qui non.", "De-engineered attitude-oriented process improvement", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terry", "Abshire", "Et neque tempore dolorum error velit reiciendis. Sint magni vel. Temporibus fugiat sed occaecati et iusto aut rerum sed non.", "Re-contextualized dedicated flexibility" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Paul", "Lang", "Dolores qui molestiae nostrum sint ipsum odio reiciendis delectus illum. Nobis qui doloremque neque labore sed repellat et pariatur eaque. Magnam est dolor doloribus eos. Quo qui est veniam necessitatibus accusamus quam. Accusamus voluptas beatae eveniet optio omnis quis suscipit. Qui quia corporis quasi nihil enim explicabo.", "Polarised leading edge infrastructure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gayle", "Schowalter", "Et rerum provident pariatur minima a non ad nesciunt. Enim laudantium omnis fugit. Aut incidunt assumenda quisquam inventore totam ratione quo.", "Automated clear-thinking framework", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wm", "Feil", "Aut quae voluptatem in exercitationem ut eum et quisquam. Et nemo laborum laboriosam aliquid. Et sint quod laboriosam dolorem. Vero et laboriosam tempore minus quasi voluptates. Nostrum rerum dignissimos voluptate quo quas iure. Et temporibus velit exercitationem sunt animi.", "Monitored object-oriented protocol" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lynn", "Pfannerstill", "Cum officia eos. Exercitationem itaque eveniet incidunt explicabo. Sit amet illo dolorem.", "Organic solution-oriented standardization" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Angelo", "Reichel", "Quos ad nesciunt quia aut incidunt asperiores. Porro numquam ea excepturi officia soluta. Exercitationem et fuga hic aut temporibus. Harum consectetur fugiat nobis totam. Dignissimos quos temporibus nihil.", "Reactive encompassing implementation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Emilio", "Roob", "Officiis aperiam nihil nemo atque dolore quo corporis et. Ea in eum dolor dolorem. Ex ut rerum quo et rem ducimus illum et.", "Multi-lateral intermediate groupware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jared", "Murazik", "Recusandae corrupti beatae et doloribus aliquam pariatur. Iure mollitia est molestiae cupiditate. Non aut aut sed.", "Switchable needs-based groupware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tony", "Dare", "Aut nesciunt sit vero pariatur beatae modi. Qui deserunt reprehenderit et et enim aut qui quia. Officia qui qui aspernatur asperiores.", "Cross-group global encoding", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ann", "Armstrong", "Velit ut laborum iusto quae rerum eligendi id. Sequi pariatur consectetur unde. Optio beatae veritatis adipisci aut voluptatem pariatur totam soluta. Quod sapiente saepe consequatur beatae rem sit maxime repellendus.", "Cloned holistic solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rex", "Mueller", "Atque id sit qui doloribus. Asperiores accusantium ut vel non eos. Officiis voluptas voluptate dolores delectus. Vitae id accusantium sit in distinctio fuga sed dolorem. Dolorem fugiat tempora dolore est.", "Assimilated static secured line", true });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 18, "Desiree", "Abernathy", "Maiores fuga porro et facilis earum ut beatae voluptas quae. Nulla dignissimos aut eum consectetur tempore alias temporibus et. In dolor atque dolorum id.", "Upgradable zero tolerance migration", false },
                    { 19, "Edward", "Lakin", "Explicabo aut nam doloremque atque quaerat ipsa sunt non ut. Mollitia quia iusto sed. Exercitationem incidunt mollitia assumenda minima molestiae commodi voluptatem voluptatum nesciunt.", "Enhanced upward-trending website", true },
                    { 20, "Guadalupe", "Dickinson", "Eum nihil quibusdam natus modi dolorem quisquam eveniet. Asperiores rerum dolor ratione dignissimos expedita consequatur numquam alias. Aliquam culpa sit aut ut quidem et et.", "Cross-group logistical extranet", false },
                    { 21, "Lorena", "Hills", "Aut harum odit provident quia ullam molestiae nemo. Non quo sit sint. Et dolor at doloremque non vel qui. Molestiae fugiat minus. Nostrum quis aliquam atque et explicabo qui qui.", "Organized directional interface", false },
                    { 22, "Jonathon", "Jacobi", "Nisi laudantium ducimus dicta temporibus delectus itaque aut ut nisi. Sunt eos molestiae et rem at ipsam et. Velit dolor est eveniet rem recusandae repellat et.", "Team-oriented executive solution", true },
                    { 23, "Holly", "Wyman", "Fugiat quam hic nisi nihil laborum et. Omnis omnis dignissimos quibusdam vel quae. Ut aliquam corporis unde exercitationem. In voluptatem fugiat.", "Total high-level secured line", false },
                    { 24, "Terri", "Roberts", "Animi natus et velit ut harum. Vel rerum nihil cupiditate minima. Deleniti accusantium delectus esse aut voluptatum velit dicta voluptatum dolores. Aspernatur saepe cumque excepturi animi nemo rerum. Non maiores veniam dignissimos sed soluta tempora quo. Aut ducimus maiores molestias qui.", "Multi-lateral solution-oriented conglomeration", false },
                    { 25, "Dora", "VonRueden", "Est exercitationem suscipit accusamus alias fugit molestias rerum modi. Possimus dolorem nihil facere maxime. Voluptatem dolorem ex et voluptas possimus quam rerum libero nulla. Eaque illum quasi facilis optio nihil.", "User-friendly maximized internet solution", true },
                    { 26, "Claude", "Keebler", "Sunt at ipsam quo sed nisi facilis et voluptatem. Ut voluptatem vitae et sed aut est et aliquam dignissimos. Corporis illo et sapiente enim nihil architecto iure autem.", "Advanced coherent knowledge user", true },
                    { 27, "Enrique", "Nikolaus", "Id minus id non et eos in labore et tempora. Rerum enim aut aut provident ipsum explicabo consectetur. Sed esse dolor. Porro tenetur ratione aut consequatur. Aperiam aperiam veniam delectus omnis rerum quae vero natus deserunt. Error beatae autem est eum ea.", "Innovative impactful knowledge user", true },
                    { 28, "Bessie", "Jones", "Nemo et est itaque voluptatem quia voluptas beatae error. Adipisci quis quo dicta quo ea architecto est harum commodi. Perspiciatis dolores ut voluptatem velit deleniti nesciunt magni. Numquam dolorem quisquam quo ea odit eos sit. Inventore minima tenetur ea itaque harum. Esse sapiente dolor.", "Virtual reciprocal hardware", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f0b9ffaa-b532-49eb-8e36-267542542a9c", "019f9093-c805-4496-80c8-2a40346ee7f0" },
                    { "c38ec56e-09f7-48e1-9cbc-205aafcc33bc", "61cd5403-658f-42a0-bb30-297210bc1e12" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0b9ffaa-b532-49eb-8e36-267542542a9c", "019f9093-c805-4496-80c8-2a40346ee7f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c38ec56e-09f7-48e1-9cbc-205aafcc33bc", "61cd5403-658f-42a0-bb30-297210bc1e12" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39717a7f-7185-4e9f-a03c-28cc5a66da3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "503214e4-8daa-429f-8c37-f3805639aeb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8992c122-736f-48d7-acda-f2304252a767");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f82267dd-3453-44d8-a9b4-b82cc757fc80");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c38ec56e-09f7-48e1-9cbc-205aafcc33bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b9ffaa-b532-49eb-8e36-267542542a9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "019f9093-c805-4496-80c8-2a40346ee7f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61cd5403-658f-42a0-bb30-297210bc1e12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5da953e5-c4c8-448c-8a15-3324e65a0d8c", null, "admin", "ADMIN" },
                    { "d5ce731b-b22e-4a51-b8af-eaf0b488064f", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f20a043-0310-4d3b-b3e5-9a6d675186c3", 0, "abdc918e-519e-41c1-a3ca-9a518ab8357f", "eddie_torphy39@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMoX5kCW0954uQftDZ+SApfAPGdpOEsu9JQyC9rUcg3zMcMmqNUW8r6l8p6Hic4+4g==", "1-579-420-0965 x5841", false, "8b6f2780-d47d-4640-9d86-9230598344ed", false, "Eddie_Torphy39" },
                    { "11492cce-a85a-41a4-88be-593bb7a294a9", 0, "3dbdb5b3-056e-4cf8-b30b-2711f87c6571", "stephen.king@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELNnORpP1zFP8xWM6iCHI4tLJuOigrpwDOhWrpEcvyUpbdpgmHZaLNtmuq02jDAFIA==", "1-580-649-6316 x581", false, "cf42ba29-6645-46fa-b263-d28e5eaaad14", false, "Stephen.King" },
                    { "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144", 0, "f0c15a2a-964f-4b11-b2f3-46ff49b808fc", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEJcJnGHvbu68Rh33d5wg1lBw2kFGh6p1ENR95HfrGRYsEKprLgfy9WbNm9iXaDLovA==", null, false, "8cc529c2-1f61-4eef-a9b3-3cd436110575", false, "librarian@library.net" },
                    { "2033b1e8-1932-42bf-9421-4b1595b0e18c", 0, "a94ec41c-a1ff-4606-b28a-49a1704f2e6d", "meredith.feest@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI0+SfkxLpSOjQtdvbDjMU+FgfuXw8FfFEIk4KyMxZGEBbR0bT/cVnpxrzFVSLGNAg==", "1-915-565-0268", false, "69e8c200-e078-4b68-9226-259112e55f81", false, "Meredith.Feest" },
                    { "2257a18f-f789-4fbb-9b7d-8a13531e756b", 0, "ca57d11f-0aa2-48ad-be8c-aa167cd17c19", "joseph.parker38@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJPLGOg9AeQjMgFf3PnT9hexIsiLMhJJr4Xz/izc4fnxYUU/6rqZqS3rKQiG3fB72w==", "1-991-485-5247", false, "54f6627c-4e3d-47de-9e6b-5025c957e4c4", false, "Joseph.Parker38" },
                    { "24c0d8c3-a3f9-402b-a0b0-f6923f406fa8", 0, "8194539d-c50d-4e70-b0b8-48a5be849566", "carroll93@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMNrMEOxSvfVpG7dSTblhU9EHide0f+YHalwA/NcOHg97ME8LSfsRFc3n7csalwYcQ==", "975-883-6267", false, "24cf6fb7-42cf-43d3-93ce-ae143113e769", false, "Carroll93" },
                    { "2e0c24ba-ccee-4c78-bc02-eda76176bf33", 0, "234f431e-16fa-4322-a5d6-54991c22a8b6", "joe14@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH0ad7lgH4aBHk/8v+UsmU3bs+wdrjs97pcC02g0/FSEFIOWYoiCdmWXutcO3IhbSg==", "1-660-890-0595 x729", false, "0e78bec2-75de-4270-b67b-df7d51f63b17", false, "Joe14" },
                    { "352667be-db7f-4cf2-99a5-f0038283888c", 0, "44f52411-6e93-4307-9684-31828e6e1761", "jeff_ruecker67@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAxJePppYlHVHnJ1pVSPWqw6itFDcJEZwbd8wbUGYxpHT7+FDWcBwAhCV3lMMzK5mA==", "998-331-2005 x1464", false, "ea3953dc-0d41-408c-843e-6763e82cfe0e", false, "Jeff_Ruecker67" },
                    { "37a0eda6-7893-4754-9992-e0c601ef9b62", 0, "034e1218-ff8b-4f02-bb57-55be1283fa1f", "wade_ullrich@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFjtKM9fIOaZr/Yl9Dm8PlMKSgydhh19SnVhUNqChZ4TSgIkkq7nGHHIxB64dEvENw==", "998-617-4182", false, "d5b8e5ae-00ce-4a70-a3c5-293ae8887971", false, "Wade_Ullrich" },
                    { "3b69c73c-1bb4-4423-8835-ed72c8c74603", 0, "edac3058-7d3e-4350-a4e8-b632bd039f05", "darrel6@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI+co8iz3Hwr602VP3L9cGX3sun9y2cVHJNikPzuM7IknGvll/f8wtFVS2ykRAyjSA==", "524-812-9526", false, "c00e503f-e951-4e5e-bf2b-7016223316c8", false, "Darrel6" },
                    { "41ac32d7-3081-48af-96dd-4321c77af640", 0, "d21114d1-9a20-45b4-8ea9-5fdf5ecd7102", "allan_dicki@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELzVZ9cGsBnSyfdo8XBvIIj9jPME8e2rz27fgPRYm82uTlhWUJs7lQKJ3c5N2ifMMA==", "(864) 314-8160 x4559", false, "a36c29e3-5c11-456c-97a5-d138ae2570a9", false, "Allan_Dicki" },
                    { "4a4d66da-18de-4299-b007-dbd99123489f", 0, "8b9b717b-51b1-4203-8485-1f58eb3f68f6", "della.kuphal0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIqMWgflTCT1OGyfrmRamHSb1lirlru5lpMYrQRu0T+BTck6mmSkI0tcLr7e2dpmGQ==", "(642) 908-9814 x896", false, "bd78bbaf-412b-4cd9-81a4-8b19f701c4f9", false, "Della.Kuphal0" },
                    { "6e10ec99-21fe-4ca6-93fa-1fb6dbbe2dbd", 0, "2c561b9d-6dc4-40be-9eb9-f79870cd5126", "alberta30@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENWO9XX1/CVdflGEEnE5KerzvQcJvXx8QZNOB8KnzSF6+z4SdV7/7co090SnGikBKQ==", "424.692.6688 x38499", false, "b17e8234-9b67-4b76-ba9f-fbbb7267c3f5", false, "Alberta30" },
                    { "79482d20-b4f2-496c-899f-b0d000d876a1", 0, "df81f349-3683-405a-b74d-431e435268d8", "joey98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI+cazwg/QRVhlVpnRqAI4wFbJacqiff4rspbOJBIgq+hREUi9CoRuVBme3E1PrUWA==", "556.974.4446 x2942", false, "a375ee04-0cd9-41b0-81bb-7ad8e9eaa2d4", false, "Joey98" },
                    { "94e3e662-cd88-4abc-928d-b81efa0ac168", 0, "b0713351-9923-47ec-8cfd-92b720255bdd", "fernando.abernathy@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEV+uo2SgUq/tkLB/+n5/PdUMNtddXhHDP7YOq5v0+utcxQyg921OEcCbtmbLuD+nw==", "334-890-6746", false, "f3ba59bc-c82b-48c0-bf4e-f60743efc837", false, "Fernando.Abernathy" },
                    { "9ee59f3f-cb59-4289-b886-9de499278a82", 0, "0c90cb47-6af3-4644-bd25-72d1fc1e8952", "theresa_gerhold@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECRkB44EiZ7E8ZUy4Mxxx+OD4PwOAEkBVph0MFxepyKN8ZtJNS381O9VKFCeaMTOYQ==", "(754) 482-9374 x0702", false, "07687de8-d3c4-4cb9-9a3a-344b955dd4b5", false, "Theresa_Gerhold" },
                    { "c598d09d-85a8-4f1c-90d2-80437ec3b7d9", 0, "6a037b5d-0fbe-492a-af52-0b070edfeaea", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAELb7or5n+9iKC7o2ohZCMiyd5PhXS4xLOSZZRXHYmpsNT27FdvvhOcSCOYEIOc4rsA==", null, false, "0d506aa4-0a24-4fc7-8804-148f902d9482", false, "borrower@library.net" },
                    { "dcb79b15-c3a8-4849-aa10-03eca7afd5f0", 0, "82f84d58-0145-469b-aeb4-69c3e7e433e4", "lindsey_schuster@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFDLtyeLZxS3Q5f7wV4IvmMMFHKMcIleChQk9BMN9M3OzHDtqVyZLpt7fEuhr3Hv8Q==", "531-681-7967 x02032", false, "e5be6eec-b01e-4a29-8982-5ea5c6a21861", false, "Lindsey_Schuster" },
                    { "e2ada14b-6f38-4902-ae25-75ca4d9bf9da", 0, "987e5eb9-349e-453f-93bc-32070c28d492", "blanca.klein72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENGr9y3NFS2jyvMBc1H2TYn0iZMzHXK7N8VbosKny/s7B6da/HbqHaEZezO+qCHfog==", "413-479-5200", false, "bb1d8601-988d-4ad1-a124-21b537afb3c9", false, "Blanca.Klein72" },
                    { "e4877640-43fb-47be-b242-10f20c021e41", 0, "23dff3c1-f01b-4273-912c-cee59c0e8c28", "arnold18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH1E0zBetH+7cCieGjxf0QThcTjefsKXSAjlOn9tlAat/YmKLXRBEuzJreGLXVn2Ig==", "1-949-881-2518 x906", false, "00cd8e4e-7c24-4711-a86e-2f9d8400da41", false, "Arnold18" },
                    { "e58101d2-6e97-4df4-b03f-d35aed3417fe", 0, "89542210-e765-4eb6-a65b-bb5815e7a8df", "darin.brakus@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOznwN1VN/jZzm06bGGSCOmXK+rk1gZ5rhhy6qq0E1/Ah/HxnQELQ8x2lXAMlz95VQ==", "1-669-305-2058 x956", false, "1190efc2-7b9a-46a1-8ad4-e693488188a6", false, "Darin.Brakus" },
                    { "f62740f8-12ea-4821-a7f9-f7c46241326a", 0, "e8a4e5d1-fa51-4adb-9319-b38852f2ea9c", "elisa_bradtke58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENiCzwCFb8YMUwA02cHyAzQo3WwE/Ns/XWCnm7+4Ix1lusrF/sqzQxeizkWco2exiA==", "526.486.0746 x01786", false, "0af81633-c1a4-4f4c-97e2-def532e9f139", false, "Elisa_Bradtke58" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Don", "Walker", "Quia architecto dicta repellendus voluptatibus sint nemo aut ea. Nulla velit quae. Quo enim at. Perspiciatis repellat vel.", "Enhanced heuristic conglomeration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mandy", "Stiedemann", "Molestiae reprehenderit ducimus commodi adipisci vel sed quia. Optio reiciendis officiis cumque consectetur. Reiciendis ut rerum iure voluptatem vel ut quidem. Quos et culpa.", "Adaptive heuristic attitude", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Thomas", "Kozey", "Velit atque harum sunt. Reprehenderit quos iure eius itaque tenetur molestias natus fugit qui. Atque aliquid ad. Ut ad ratione sunt consequatur voluptatem qui qui accusamus quibusdam.", "Profit-focused even-keeled hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "April", "Lemke", "Magnam explicabo in suscipit velit. Occaecati sapiente aperiam velit. Non sed tempore placeat consequatur.", "Persistent foreground installation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sherry", "Corwin", "Labore ducimus delectus in voluptatem. Placeat ratione laborum omnis. Nesciunt non placeat occaecati tempora tenetur facere alias est veniam.", "Versatile discrete capacity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Daisy", "Watsica", "Occaecati fuga et sunt velit amet veritatis dolorem mollitia. Quibusdam excepturi aspernatur perspiciatis eos. In voluptatem quo est tempora voluptatum ut ad id. Sequi dolor non ut rerum dolor.", "Fundamental asymmetric framework", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dave", "Hudson", "Velit necessitatibus tempore. Neque odit amet quia ut fugiat et veniam exercitationem. Autem dolor beatae fugiat nulla voluptatem. Voluptate ut occaecati ut et minus facilis officiis necessitatibus.", "Progressive dedicated frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Josh", "Gottlieb", "Praesentium temporibus ut voluptatum eaque placeat voluptate. Minus ipsa officiis dolorum. Nemo repellat assumenda ut vel harum inventore dolorem omnis officia.", "Team-oriented asynchronous hub", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Bryan", "Senger", "In natus eaque maxime maiores. Ipsam repudiandae magnam sed beatae est quod fuga. Pariatur vero repellendus in et. Quis impedit aliquam et temporibus quia incidunt quos modi ut.", "Devolved mission-critical intranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Merle", "Bayer", "Esse odit cupiditate aliquid dolorum sit molestiae. Hic aliquid ut quia error perferendis itaque. Earum maxime quam impedit quos. Nobis quia ut ea doloribus non in.", "Persevering maximized methodology" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Erica", "Schaefer", "Dolores velit explicabo aut dolore. Distinctio repudiandae ut exercitationem ea. Fugit esse quia officia et autem eligendi error voluptate. Nostrum quos quas et. Dolorem dolor tenetur qui.", "Realigned zero defect utilisation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Genevieve", "Padberg", "Est illo provident rerum laboriosam blanditiis occaecati dolorem. Nihil esse ipsa suscipit voluptatibus inventore eius. Laborum reprehenderit porro vel sunt enim omnis aut ut est. Quo expedita omnis vero et. Aperiam inventore et distinctio similique qui sit saepe sint. Consequatur voluptates sed voluptas harum tenetur fuga accusantium.", "Centralized reciprocal collaboration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Eduardo", "McDermott", "Est error aspernatur hic natus nemo cumque corrupti adipisci. Magni omnis et voluptatem voluptatem id veritatis incidunt delectus. Odio in non magni consequatur maxime et adipisci et neque. Sunt similique animi eum culpa iste. Nam qui repellat.", "Monitored upward-trending productivity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Susie", "Satterfield", "Quasi et delectus vel facere amet non. Molestiae architecto quibusdam ut modi. Nostrum cum corporis ea et sint officia consectetur sed.", "Digitized zero defect throughput", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Vicki", "Kulas", "Error maiores commodi. Odio molestiae unde perferendis aliquam quis inventore et. Et consectetur eius accusantium laudantium. Nostrum vel ipsam sint eos aliquid eveniet deserunt nihil fuga.", "Up-sized zero defect definition", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Agnes", "Hansen", "Enim ut alias dolor minima ea. Eligendi vitae voluptatem blanditiis velit eveniet et mollitia. Dolor tempora et doloremque officiis at et.", "Managed 6th generation monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Wm", "Hilll", "Ut pariatur rerum voluptatibus officia occaecati saepe. Qui eum incidunt eum exercitationem. Ducimus porro quisquam beatae impedit magni qui rem. Aut similique ea incidunt iure dolore ipsa.", "Triple-buffered exuding internet solution", false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5da953e5-c4c8-448c-8a15-3324e65a0d8c", "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144" },
                    { "d5ce731b-b22e-4a51-b8af-eaf0b488064f", "c598d09d-85a8-4f1c-90d2-80437ec3b7d9" }
                });
        }
    }
}
