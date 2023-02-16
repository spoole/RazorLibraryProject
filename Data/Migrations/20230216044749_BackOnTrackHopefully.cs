using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class BackOnTrackHopefully : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                keyValue: 17);

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
                    { "1c704a00-2d23-4d68-8c00-10ed0bd45b3d", null, "admin", "ADMIN" },
                    { "208788c4-b855-4a52-9b47-074e473e811b", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "020f3518-f66a-4e6b-93bb-71871b2e8624", 0, "f46a29f0-0fa0-45c0-bf3a-be834deb9a30", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEM9/HT9I/48kWpiqb5FWUXamuG8MnABnld4TgUtrOD0lEPKHYBLgNBUHs/aNOBDu3Q==", null, false, "d9e8a802-0d35-40eb-9d12-ac813d532bdb", false, "borrower@library.net" },
                    { "128a952f-c8d4-45b9-b756-2904e095988a", 0, "98895249-3422-4268-9d20-f40962a26b66", "ginger.armstrong@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP/wKD9NdafptG+kejHKLqx0mCVOgF27rRVZIa4Wk2/HKn5Nowumq32KWTN+udqLnQ==", "1-835-764-2094", false, "7b9d41da-6fce-48bd-bde5-177f965215e2", false, "Ginger.Armstrong" },
                    { "435ee2c6-0ce6-4c70-929a-09d5f4ae41d6", 0, "730eeaee-399e-4b02-a31b-971553c2e227", "malcolm17@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECA4K+0Nj9TmwrJAkVaAN91GpgFryQE2dSbtTzPS1ebUcIu6Z5nWsM41nz0VkwdwRg==", "491.321.6745 x474", false, "29e489f8-187b-4fcd-bd9d-53e9399d03a1", false, "Malcolm17" },
                    { "47c020aa-0d7d-4f32-b22e-67c274cc428d", 0, "ed46e279-ed63-41d9-b920-893be133c267", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEJEnLIi0NqmoPM078UfejQgAD0hjqN0TL4wBZH9mZt6A1dbGu5qayOU5K+TuCMIngw==", null, false, "42d685d6-35a4-4e54-adce-1593d8c0302d", false, "librarian@library.net" },
                    { "5d2da35f-5ec4-446b-a2a5-a2eed2cd1846", 0, "a9cb9812-b1f4-45b4-a720-8f28bf6b1410", "glenda.considine71@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEK61oNQ3INwAduZY3SLMIi3+WK1Ywoo96UXNfKoVVyII+yycRdk3OH0WdMDQOKPaQg==", "(975) 958-6841", false, "49a772aa-204e-4808-a181-3ec4aeef8369", false, "Glenda.Considine71" },
                    { "a39a302a-47ef-4500-b4e7-8fdd0c2a742e", 0, "82435aeb-b4aa-47a5-8e5f-d23b05445e10", "ira1@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENSvtZ447afkyTFKdY/jc7ndfYxdH3AH4sh4TMBFtCvHH/rZla+tArxO89pn0fHWJw==", "(221) 353-0688 x977", false, "45c2d886-2c47-4ddc-98cd-29f4b92fc369", false, "Ira1" },
                    { "c98456c5-6259-4b35-a771-1315fa15145f", 0, "adc5f328-b3fb-4498-a898-28a678ad3b15", "cory46@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEExy5SRfOkUuHYYmovMVCjvzRPDM+mB5bl/KDXNPpTMnnCrH7vMWN1ciCwbtIF8WGg==", "529.713.2363", false, "430d4909-da9d-4ddf-922d-6efe3ad31c3e", false, "Cory46" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dale", "Stiedemann", "Molestiae porro earum nihil ut omnis quas voluptatem explicabo. Nemo ut voluptate esse voluptas reprehenderit dolorum esse. In ratione soluta nisi aut vitae aperiam dolorum praesentium. Facilis est quia rerum. Veniam eius pariatur sit labore.", "Face to face cohesive database" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Janis", "Kertzmann", "Facilis voluptas ad perferendis explicabo consequatur dolores delectus voluptatem. A vel libero ab non. Qui eveniet necessitatibus facilis repellat illum molestias. Id rerum exercitationem fugit corrupti. Iusto beatae ab ut. Corrupti voluptate aperiam temporibus in omnis qui quis dolorem.", "Diverse secondary database" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Raymond", "Funk", "Commodi inventore expedita est non est deserunt maiores pariatur. Possimus cupiditate et quos expedita ducimus laborum ab magni. Voluptatem et illo quo placeat voluptatem. Dolor similique id voluptate et.", "Adaptive intangible moderator", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Damon", "Rowe", "Quo odit et ipsum et. Praesentium voluptas eligendi eveniet ea incidunt dolor officia. Facilis quisquam aspernatur quod neque. Inventore eius voluptatem aut.", "Innovative 24/7 support", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rafael", "Schroeder", "Ut et voluptatem accusantium. Ut aspernatur ipsum. Quia et consequuntur similique aut accusantium reprehenderit quasi. Velit atque nemo ex nihil tempore accusamus aut. Cupiditate quae impedit nemo earum vel doloribus ipsa. Officia esse non aliquam similique incidunt.", "Phased national system engine" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Joann", "Torp", "Ad quidem et aperiam excepturi nesciunt exercitationem. Incidunt illum dolores ut sed animi dolores consequuntur sed explicabo. Sit magnam aspernatur fugit quia. Eum consequatur quas. Veniam perferendis assumenda molestias qui omnis. Aut aut sit.", "Right-sized attitude-oriented process improvement", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Debbie", "Fritsch", "Corrupti similique est consequatur inventore nulla. Inventore et est. Modi et harum iusto deserunt. Nemo in impedit eligendi ut neque culpa iure. Ab dolore enim molestias et harum velit beatae.", "Reactive explicit success", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dallas", "Hermiston", "Voluptas expedita animi occaecati reiciendis temporibus doloribus. Et ipsa minus tenetur earum modi. Quia sed praesentium quidem laboriosam voluptas dolorum aut.", "Synergized web-enabled policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jaime", "Veum", "Nemo quis labore eveniet soluta. Est ex fugiat corrupti placeat numquam perferendis ipsam accusamus. Dolorem et non quisquam soluta consectetur voluptates repellat. Consequatur qui voluptatem. Reprehenderit expedita omnis nam qui ullam voluptas nemo. Est quia laborum voluptatum sint quidem at.", "Automated discrete frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marcia", "Hamill", "Voluptatem est rerum exercitationem omnis quia ad animi dolorem. Enim dolores voluptas ratione reprehenderit quia deleniti deserunt hic. Repudiandae quae dolores possimus aliquid eos. Quae dolorum enim iste quis et soluta deleniti. Quasi et cumque molestiae ut veniam non voluptatem doloribus.", "Versatile interactive contingency" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rufus", "O'Conner", "Distinctio alias et reiciendis eum officia. Dicta ea nesciunt dolor dolores eos voluptatem. Ducimus nulla impedit recusandae animi et omnis dolores magni.", "Compatible multimedia flexibility", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Randy", "Muller", "Vero dolore assumenda minima voluptatem ut hic officiis similique natus. Molestiae facilis voluptatem. Excepturi quos quod voluptas unde.", "Advanced multi-tasking strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Mona", "Mosciski", "Praesentium dolorem enim sunt. Dolores eaque quisquam architecto est voluptatem reiciendis nostrum. Inventore impedit ab voluptatem numquam omnis.", "Progressive 24 hour frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Joyce", "Tromp", "Veritatis libero ut enim ut. Numquam totam aut earum est. Dolor optio consequuntur illum alias ex ut cumque. Architecto perferendis voluptates molestiae reprehenderit perferendis dolorum esse rerum. Ea voluptatem doloremque voluptatum.", "Monitored well-modulated database" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Edna", "Wisoky", "Exercitationem expedita reprehenderit nisi perspiciatis et molestias ut ad. Aut animi aspernatur aspernatur. Quisquam delectus aut saepe natus sit corrupti sed facere. Quis eum tempora non enim et quam.", "Universal tertiary throughput", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rachael", "Kemmer", "Quia libero repellendus dolorum aut qui deserunt. Est ex voluptatem repudiandae qui et dolore. Eligendi eos sit. Voluptatem eligendi vitae. A voluptate delectus sit.", "User-centric client-server task-force" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "208788c4-b855-4a52-9b47-074e473e811b", "020f3518-f66a-4e6b-93bb-71871b2e8624" },
                    { "1c704a00-2d23-4d68-8c00-10ed0bd45b3d", "47c020aa-0d7d-4f32-b22e-67c274cc428d" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "208788c4-b855-4a52-9b47-074e473e811b", "020f3518-f66a-4e6b-93bb-71871b2e8624" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1c704a00-2d23-4d68-8c00-10ed0bd45b3d", "47c020aa-0d7d-4f32-b22e-67c274cc428d" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "128a952f-c8d4-45b9-b756-2904e095988a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "435ee2c6-0ce6-4c70-929a-09d5f4ae41d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d2da35f-5ec4-446b-a2a5-a2eed2cd1846");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a39a302a-47ef-4500-b4e7-8fdd0c2a742e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c98456c5-6259-4b35-a771-1315fa15145f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c704a00-2d23-4d68-8c00-10ed0bd45b3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "208788c4-b855-4a52-9b47-074e473e811b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "020f3518-f66a-4e6b-93bb-71871b2e8624");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47c020aa-0d7d-4f32-b22e-67c274cc428d");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Estelle", "Bashirian", "Iusto omnis recusandae soluta totam animi voluptate. Omnis rerum omnis eius minima est quidem aut enim impedit. At ad voluptas est saepe. Magni deleniti harum veniam.", "Monitored solution-oriented system engine" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Samuel", "Conroy", "Sit deleniti facere rerum et. Expedita aliquam est voluptates et. Rerum repellat adipisci quidem veritatis repellendus explicabo soluta. Ut dolore ipsum dolorem error voluptatem sed quaerat. Occaecati eum est optio voluptatem velit aliquid.", "Balanced holistic monitoring", true });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Christy", "Strosin", "Libero neque voluptatem laborum. Adipisci quia qui qui distinctio asperiores rem. Quia atque laudantium voluptatem.", "Focused discrete interface", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jack", "Watsica", "Laborum vero aperiam. Qui omnis ut earum qui modi accusantium cumque. Cumque suscipit accusamus error voluptatem aspernatur ea.", "Virtual dedicated implementation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Claire", "Streich", "Error iusto ea velit magnam. Dicta esse debitis consectetur enim libero nostrum nam. Placeat voluptatem tempore ab. Atque ab nobis delectus consequatur itaque tenetur ipsum qui. Dolorem quia sunt culpa cumque aliquid quo vel. Ex est et soluta autem facilis cum ut est consequatur.", "Automated regional methodology" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 17, "Meredith", "O'Connell", "Odio et est porro debitis velit perspiciatis dolor molestiae. Aut aspernatur id pariatur id quia dolorem. Maiores veritatis aut recusandae qui ea nam at sunt similique.", "Versatile eco-centric instruction set", true },
                    { 18, "Matt", "Hoeger", "Doloribus ducimus architecto. Minus quaerat unde neque vel officia. Illo ut iure et aperiam officia quasi suscipit. Impedit sit explicabo id ea et soluta.", "Organized reciprocal workforce", false },
                    { 19, "Cecelia", "O'Hara", "Quo qui perferendis assumenda et ex excepturi nam quia repudiandae. Necessitatibus debitis officia ad illum quis dolorem iste. Sed optio quo possimus amet soluta. Dolorem aspernatur perspiciatis nihil est laborum ducimus. Ratione soluta fuga blanditiis vel. Modi enim omnis.", "Cross-group bi-directional neural-net", false },
                    { 20, "Joan", "Dooley", "Natus minima aut pariatur velit saepe eum dignissimos molestiae ducimus. Voluptatum aliquid voluptas voluptatem natus illum delectus occaecati vel error. Fugit quisquam quos at iusto minus commodi. Temporibus quibusdam quia qui.", "Horizontal interactive moratorium", false },
                    { 21, "Casey", "Weber", "Quasi aut ut. Ad cupiditate id labore impedit incidunt repellendus facere sit et. Et quisquam consequatur. Quaerat perspiciatis delectus atque ullam.", "Business-focused intangible alliance", true },
                    { 22, "Ronnie", "Bruen", "Alias ut laborum. Suscipit sequi quis ut ea nostrum et quia et. Accusantium minima omnis velit commodi non. Labore earum quaerat.", "Team-oriented web-enabled extranet", true },
                    { 23, "Wesley", "Krajcik", "Ut perferendis voluptate officiis laudantium ipsum minus ipsa fuga. Non laudantium voluptate voluptatum praesentium sed accusantium praesentium ipsum. Assumenda quod aut incidunt eius qui itaque enim. Voluptas est qui vel voluptatem omnis consequatur maiores sapiente dignissimos.", "Intuitive intermediate workforce", false },
                    { 24, "Jasmine", "Stokes", "In provident voluptas consequatur tempora. Repellendus ratione sit accusantium a nostrum optio. Officiis labore hic et et soluta accusamus accusantium voluptatum illum. Sit enim eaque et dolores laborum qui aut.", "Multi-layered intermediate knowledge user", false },
                    { 25, "Sophie", "Johns", "Blanditiis laudantium nulla itaque natus iure quia doloremque aut. Occaecati hic aliquam harum et quod quos maxime officia. Aut sint recusandae quas vero facere incidunt. Voluptas ipsa placeat totam soluta.", "Front-line stable toolset", false },
                    { 26, "Noah", "Kuvalis", "Voluptatum architecto est qui deleniti deleniti. Eius iure voluptas magni quia occaecati corrupti. Debitis voluptas aperiam reprehenderit est repellendus officiis qui assumenda. Omnis nisi et. Velit dolores rem.", "Synergized context-sensitive matrix", true },
                    { 27, "Benny", "Bednar", "Reprehenderit sint eos voluptatem non. Magnam velit molestiae tempore perferendis odio et ut. Repudiandae accusamus alias dolores optio et esse facilis at. Voluptatibus sunt vitae voluptatum quo. Vel eum quaerat odio et sunt et error facere qui. Id non dolor quibusdam nihil laborum nesciunt necessitatibus enim dicta.", "Intuitive even-keeled initiative", false },
                    { 28, "Lana", "Feeney", "Qui aut fugit quidem nihil accusantium doloribus qui exercitationem explicabo. Sint debitis rerum doloremque voluptatem numquam beatae est. Ex nisi nobis ut est minus. Eum sit culpa architecto pariatur perspiciatis similique tempora et vero. Ut fugit et distinctio non quia maiores et.", "Grass-roots incremental capability", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08d43237-cb18-49d2-8e28-5f869fabc870", "a3621fae-dcab-4b7b-8c4b-d5f76e82503d" },
                    { "62b5ffe0-a8b4-4d47-a0a1-3ef6301a340d", "da84a640-6d6c-46f0-a58c-3c52cfbcd67e" }
                });
        }
    }
}
