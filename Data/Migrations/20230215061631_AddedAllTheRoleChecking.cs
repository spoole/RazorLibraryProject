using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedAllTheRoleChecking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7c1d45f0-eca2-491f-8a94-e065704cd367", "1bd8d454-d22c-4b50-9b37-3cc3a3864617" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e4dbd695-01f4-4716-bb73-0057112f6e73", "27adeb07-a51f-4290-a04e-c04ed91609a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0fca11d3-ead1-419d-a59f-ce4ff615af7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "167e5850-b8ad-4977-ac59-e0e66935f657");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3394481a-d38b-458a-ab80-bdb7a64e7bcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46f07709-4a2a-4dbd-b173-605062411a6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ae45f19-31e7-4390-a0fc-6224ffef484c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86bcb811-db0f-4d30-b1d1-de81811ea683");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9baa8ab8-b51e-4cc0-a7b6-f13605ba515b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e241d7b8-cf3c-407a-9507-0ddab8eae918");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eafed0ab-2f68-4763-af72-82f50420c0a9");

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c1d45f0-eca2-491f-8a94-e065704cd367");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4dbd695-01f4-4716-bb73-0057112f6e73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1bd8d454-d22c-4b50-9b37-3cc3a3864617");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27adeb07-a51f-4290-a04e-c04ed91609a3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51625042-f06d-47ac-bc9e-62886d01044e", null, "admin", "ADMIN" },
                    { "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22a44f97-6203-4035-82ff-f74166c4868c", 0, "66f69cc9-bb2f-4e30-b013-d612c1649ba0", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEBZBCBUmH8TsfJpVgUUkGXz7looM4YYBvOiPb9YLXQBkMARJyFEsPJ+kO7nF0nEZ/Q==", null, false, "36ef55c9-d503-48e4-a493-3442f05b2bf0", false, "librarian@library.net" },
                    { "28ad7b5d-a958-4e75-849b-cd752590f760", 0, "20886705-bae3-43bf-83e5-863b9cf896b4", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEDSgQ3Bv1i34tRRpnqGoQs3979guahNAL+bKQ0wr3XOkGioElXXcnXSFUAJtT2z9Dg==", null, false, "8f17845c-001c-4d7d-b465-1784bc6e5b2f", false, "borrower@library.net" },
                    { "84756e3a-1849-4845-aa1b-8e008d2e3370", 0, "590ee0d2-aa98-4c39-b933-3a34e3eac3f9", "abraham.anderson@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJR1e03HHltyWphDYT/nXcZBGdYvE7OJY7/illzDT7IcP6t1dvbWrrxHuiPVXrgAVA==", "853.296.8968 x370", false, "ec5fb77b-493a-480e-8fc1-e87ad8335ec1", false, "Abraham.Anderson" },
                    { "c4cd5330-0a05-4eb5-b14a-7aa56d3a9963", 0, "b9b574f6-b380-48a7-91a0-6eb71fba2507", "alexis.wiza@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGOgIo/fGXbZ7cTH13Rp5kCYDjLYftzYrKOoIdGAqwaSpWW2zmhN2zFE4TJvfYcwyw==", "(501) 908-2441", false, "1ab72795-dd8f-4713-9d38-0af0772ee6f6", false, "Alexis.Wiza" },
                    { "de9a5d7f-723e-4db6-83e9-8ddd324bfee5", 0, "b715e916-e1ea-415b-8be8-cdc6a8db3074", "elaine_grady@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELFlQSxdiYAKaLtHghO4ocmrAxvpJic9XJVvBBZfwBznl1TXkd4Gl2OqfnmrVuSN1w==", "1-511-685-6485", false, "6cbbc42a-6b7c-4fc3-b5d6-fd7b548d1706", false, "Elaine_Grady" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Travis", "Hamill", "Quos voluptatem odit. Repudiandae molestiae provident aut ipsum officiis vero excepturi et. Quam quas in accusantium fuga in nihil possimus perferendis.", "Devolved explicit model", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Alfonso", "Kunde", "Quidem consequatur odit corporis voluptas. Rerum accusantium illo et. Et eaque voluptas. Itaque sint culpa eveniet itaque vel officiis qui consequatur aut.", "Programmable full-range extranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dana", "Lockman", "Expedita eius ut ad libero itaque voluptates temporibus quo. Fugiat similique aut commodi. Sit cum ut suscipit nihil incidunt cupiditate.", "Horizontal bandwidth-monitored framework", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Alvin", "Boehm", "Eos non repudiandae. Voluptates animi minus a esse modi culpa voluptate tenetur. Quia ipsam aut voluptas qui cupiditate voluptatum voluptatem aut.", "Digitized eco-centric help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dora", "Schmitt", "Rerum aut omnis tempore quasi incidunt corporis et. Sed temporibus sunt accusantium veritatis animi cum quidem est assumenda. Voluptate dignissimos rerum soluta totam eveniet voluptatem architecto et minima. Nisi alias sed dicta eum exercitationem non quasi. Harum molestiae delectus qui distinctio quia hic odio ut.", "Proactive regional architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tyrone", "Lang", "Sunt sed nesciunt facere quidem numquam possimus inventore libero. Voluptates id eaque cumque qui odit. Quia delectus sunt nisi totam voluptates. Quaerat non inventore odit quia.", "Centralized bandwidth-monitored moderator", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marion", "Hudson", "Similique accusantium sequi excepturi earum voluptates odit. Odit corrupti eum voluptate et. Tempore cupiditate ullam perferendis velit ab omnis nam rerum. Qui nihil ullam deleniti iusto a ipsa sed expedita reiciendis. Alias quod et sequi.", "Devolved grid-enabled paradigm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Frankie", "Hettinger", "Molestias reprehenderit natus nisi consectetur vero soluta. Aut minus est consequatur sed dignissimos animi. Ut expedita reiciendis. Vero eum dolorem voluptatem. Et consequatur ut cupiditate. Nostrum et quia repellat repellat.", "Operative neutral function", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Victoria", "Medhurst", "Doloremque aut eos illum. Aspernatur aspernatur maxime aliquam facilis blanditiis qui voluptas delectus iusto. Incidunt quia amet eos. Est nesciunt consequatur explicabo quam omnis id cupiditate. Enim vel dignissimos sit velit eaque esse eum ratione esse. Quis nisi eaque maxime eligendi aut et ipsum.", "Enhanced methodical encoding", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wilfred", "Hahn", "Eos corporis dignissimos aut quia. Magnam amet soluta autem neque enim rem non cum voluptate. Qui temporibus perspiciatis exercitationem.", "Cross-group background frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Manuel", "Bosco", "Ratione exercitationem sint voluptas libero illo. Ab delectus at. Sunt non quia quia nam laudantium. Suscipit delectus ullam sunt doloribus minus.", "Horizontal reciprocal structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sergio", "Ledner", "Totam vero sunt ipsum et labore esse voluptatem maiores. Non qui sit dolor molestias fugiat. Doloribus ut porro. Rem numquam velit ab incidunt et asperiores. Natus voluptates itaque qui aut commodi est et qui.", "Upgradable encompassing encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Don", "Altenwerth", "Aut suscipit ab iste quas non ullam nostrum. Ut voluptas nobis illo quae dignissimos ducimus. Expedita impedit perspiciatis nesciunt aliquid. Natus molestiae quasi et quod. Esse non consequatur dolore delectus qui. Eaque consequatur aut hic voluptatem hic sequi est et qui.", "Synergized grid-enabled parallelism", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Erin", "Lowe", "Quia nostrum iure quo et et deleniti optio nihil. Iure consequatur sequi explicabo iste ea nisi qui autem incidunt. Natus quia dolorem est. Delectus distinctio dignissimos eum quia.", "Multi-layered high-level policy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Austin", "Anderson", "Illum quia odit in magnam. Porro asperiores recusandae non aliquid explicabo id quo non. Id architecto omnis sequi exercitationem omnis vel eligendi.", "Secured intermediate customer loyalty" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Justin", "Powlowski", "Eveniet accusamus qui vitae ut eos enim voluptates ut. Et et autem veritatis. Sit fugit atque deserunt porro id. Et adipisci rem natus eum provident reiciendis sapiente deleniti. Tempora iusto est fugiat doloremque voluptas magnam nobis. Distinctio voluptatem velit autem dolorum praesentium voluptatem at.", "Synergized high-level pricing structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kristin", "Bechtelar", "Laudantium atque et corporis non nam vel voluptate quis voluptatibus. Tempora autem et autem. Odit est velit veritatis repudiandae ut nihil et impedit et.", "Open-architected coherent conglomeration" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "51625042-f06d-47ac-bc9e-62886d01044e", "22a44f97-6203-4035-82ff-f74166c4868c" },
                    { "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8", "28ad7b5d-a958-4e75-849b-cd752590f760" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51625042-f06d-47ac-bc9e-62886d01044e", "22a44f97-6203-4035-82ff-f74166c4868c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8", "28ad7b5d-a958-4e75-849b-cd752590f760" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84756e3a-1849-4845-aa1b-8e008d2e3370");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4cd5330-0a05-4eb5-b14a-7aa56d3a9963");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de9a5d7f-723e-4db6-83e9-8ddd324bfee5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51625042-f06d-47ac-bc9e-62886d01044e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22a44f97-6203-4035-82ff-f74166c4868c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28ad7b5d-a958-4e75-849b-cd752590f760");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c1d45f0-eca2-491f-8a94-e065704cd367", null, "admin", "ADMIN" },
                    { "e4dbd695-01f4-4716-bb73-0057112f6e73", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0fca11d3-ead1-419d-a59f-ce4ff615af7c", 0, "77572a50-e9c4-4d6c-9ea1-de63e436f4e7", "gerald99@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENtP6YXBR6EcPg7EOICdxlWB6MtSYn7UxiafUAQivuV6lFTU+R1Wu65YmGZ8WBA70Q==", "666-409-3591", false, "8fbcd84c-7339-4777-9b76-d6902903be94", false, "Gerald99" },
                    { "167e5850-b8ad-4977-ac59-e0e66935f657", 0, "1fd9fd78-1144-4dad-abf9-608b48a062d8", "frank41@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEF7CVHroSU4yFkxp/OoF9d7r3kypzE62EPPMDFu4LPtP5fujP6ogmDucQfI7YxqnpQ==", "(703) 821-2321", false, "6efcaa9d-d574-4e8f-9cb0-6431e0aab662", false, "Frank41" },
                    { "1bd8d454-d22c-4b50-9b37-3cc3a3864617", 0, "e52158e2-e675-48c8-a41c-fed4641f6463", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEB2o6ROFqgDrQGXMS9vPjDS5/wP+DB7NMmdBlSxyVTJOaF10+41YoiLZdMiJjzMGtQ==", null, false, "6ba456d8-8144-4e8f-9e5f-0cf388575c17", false, "librarian@library.net" },
                    { "27adeb07-a51f-4290-a04e-c04ed91609a3", 0, "56437e87-0cc9-4cb2-9afb-4de3eb105f7a", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEH1YgcvWDo5uYW7Ga8FJ8dyvY93I7LD3M3zNLaiheMS8ZeQcjLC5Eam52i4MhdI44A==", null, false, "e12b2d9e-7776-4768-894e-17a4fb7f90dd", false, "borrower@library.net" },
                    { "3394481a-d38b-458a-ab80-bdb7a64e7bcc", 0, "f7241e31-f256-4395-9e84-2601a077dfd4", "luther94@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH6XWh2jVx0zA7fhfNXvqreYeTM1VxGRhAP6eMiBhixwchLOYmzhb8rsVkUaUjcKaA==", "318.390.2718", false, "0d118ef9-9d9f-4347-b178-409e24a9ab94", false, "Luther94" },
                    { "46f07709-4a2a-4dbd-b173-605062411a6f", 0, "5ac23dce-9698-430e-903a-7fb25be717cd", "lucia.hilll98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBcwiQ2e5k/fwmg951en+AOeukT72YMh5/j46TgHPZsO+Ab+8i/tLGmscEVpc2gQyw==", "1-211-263-1985 x946", false, "e2f5c0b1-29cf-4c5a-b752-853ffb2e4ce4", false, "Lucia.Hilll98" },
                    { "4ae45f19-31e7-4390-a0fc-6224ffef484c", 0, "d47ac385-01ff-49c3-bd5c-7909f9c7f024", "patsy58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENFDn7YuWs0QBPnJlMukqmoo49YGn4LMdgcnbvfmqoGR93a3RbBArFYE5ZOlPWb7dQ==", "996-319-3298 x54630", false, "ecb1418c-c6a1-4859-97b7-fc446a0d63db", false, "Patsy58" },
                    { "86bcb811-db0f-4d30-b1d1-de81811ea683", 0, "3f6dec83-0211-438c-bf58-cb75dfb4a3fd", "antonio99@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJM3HhYCKqeIO/ycTsdS5+5wctbbeccgzgQfuZLq31nZR+Ey439Z3i7OGwHBeFh0eQ==", "705-407-6647 x735", false, "acb3e117-211d-4465-b3d5-cf5c91def5f1", false, "Antonio99" },
                    { "9baa8ab8-b51e-4cc0-a7b6-f13605ba515b", 0, "565f9150-b5e9-48f8-a465-9e6082decf6b", "hannah2@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELiQJsMqdyi/daDYh69Buhnzmmi3FF3FOV2Vm4mi7oZXdVYj1IWUu2TbXiNVkJIYDw==", "607.207.4824", false, "f5579e1e-8e65-45c7-b8c4-267c06a5911f", false, "Hannah2" },
                    { "e241d7b8-cf3c-407a-9507-0ddab8eae918", 0, "1aec8164-d503-4c6b-aa5d-2cd08dfef963", "dean_rosenbaum@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEItWD4nyW3xrO24Jpcjjzkt3uadAJ06saVffWgEKEenVko1uNRxHcjkueNdzVvDaIg==", "(468) 980-7134", false, "3c5993f4-7f71-4afa-b2c2-ec5317641a56", false, "Dean_Rosenbaum" },
                    { "eafed0ab-2f68-4763-af72-82f50420c0a9", 0, "75c0907a-c112-434a-8c1d-05c56e851c29", "elena.keeling@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGREnHpmhwBhZCOdWnhO7AfFMSspCL8n8GlM2GD2o+mYaEdIaWMd/3CH8Gwg1/cUdA==", "1-712-446-3128", false, "adcd6527-11ae-49b8-b1f7-aa46e496b595", false, "Elena.Keeling" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Christie", "Ferry", "Aliquam optio qui. Facere quis mollitia et voluptatem et id. Accusamus officiis dignissimos enim quod omnis. Ut quis quia id.", "Multi-layered global framework", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marvin", "Herman", "Officia quae alias ut quam officia est et. Quibusdam reprehenderit dolorum illo suscipit mollitia ut et. Nihil repellendus deserunt quaerat. Dolore debitis id magnam quidem aut odio magni nostrum et.", "Seamless multi-tasking knowledge user", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jared", "Hermann", "Quis rerum enim incidunt officia modi quia sit occaecati. Ipsa error quo a id reprehenderit itaque ut ut. Sunt cupiditate et harum sit tempora.", "Seamless value-added encryption", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Glenn", "Roberts", "Voluptates fugiat quibusdam sed et dolorem temporibus sint itaque. Aut esse pariatur aut impedit vel dicta iure. Temporibus veritatis quam est aut tempore tenetur velit. Voluptatum occaecati adipisci dicta magni dolore et facilis. Iusto magni perferendis optio harum porro delectus reprehenderit. Esse voluptate eos deleniti quia qui.", "Networked secondary support" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Phillip", "Ferry", "Eveniet qui maxime aspernatur explicabo excepturi est maxime velit. Eum qui laudantium doloremque itaque dolorem et doloremque distinctio quam. Error nemo aut commodi cumque molestias consectetur ipsa. Ut vero nisi totam qui quasi qui. Laborum molestiae aspernatur.", "Customer-focused client-server workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Anne", "Boyer", "Aut repudiandae natus nihil minima sunt eveniet debitis. Sed corporis et rem aliquam. Praesentium maiores nemo quo dolores temporibus corrupti. Rerum unde pariatur voluptas expedita esse aperiam tempore.", "Grass-roots foreground product", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rosa", "Herzog", "Qui ad et est illum. Quis reprehenderit dicta ratione. Aut rerum omnis perspiciatis dolorum expedita. Aut tenetur sed magnam odit quo asperiores ut ad ipsam. Quas est voluptatum placeat ut quia sunt corrupti est. Est qui similique quaerat occaecati voluptatum occaecati non voluptatem sapiente.", "Persistent bifurcated focus group", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rachel", "Medhurst", "Tenetur qui laudantium itaque. Aspernatur et voluptas earum qui consectetur suscipit. Labore quidem non.", "Optional high-level encoding", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Henrietta", "Casper", "Optio ut perspiciatis veritatis eos voluptates. Porro blanditiis molestiae sunt et quia. Eius ab est consequatur non pariatur. Voluptas sit eveniet hic. Nihil omnis ad inventore. Qui qui libero non repudiandae id aspernatur excepturi.", "Optimized empowering model", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Alice", "Dicki", "Consequuntur sint voluptatem id. Necessitatibus commodi eveniet eum ullam numquam omnis. Maiores repellendus debitis minus molestiae hic error consequatur eaque eum. Possimus autem suscipit sed incidunt qui dicta pariatur dolores eos. Impedit quis quia.", "Adaptive grid-enabled initiative" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Judy", "Hodkiewicz", "Quaerat commodi consequatur dolorem autem rem maiores sed et aut. Et aperiam culpa odit ut eaque culpa. At rem accusantium quam aut in eaque dolorem enim id. Totam et eveniet nesciunt consectetur et suscipit necessitatibus. Molestiae dignissimos tempore accusamus repudiandae et voluptatem consequatur.", "Devolved optimal installation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Claire", "Anderson", "Laudantium doloribus molestiae at magnam dolor. Numquam doloremque error alias fuga et. Recusandae earum illum laboriosam expedita aut voluptatum repudiandae. Et officia est beatae odio temporibus.", "Function-based dedicated core" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Erik", "Nicolas", "Totam eos nemo cumque ipsum totam corrupti. Ut excepturi dolor non sunt commodi nam sunt id veniam. Dolor eligendi molestias dolor. Accusantium tenetur et modi voluptates voluptatem eius facilis nemo.", "Persistent background local area network", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Todd", "Schultz", "Voluptatem dolorum minus quis quis qui quidem. Atque placeat voluptatem assumenda sit aut qui accusantium ut autem. At voluptatibus qui voluptatem. Molestias aut repellat eveniet voluptates et. Facilis quia quidem in et sint. Ut repellendus quaerat perspiciatis consequatur aut animi.", "Reactive bottom-line protocol" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marcos", "Krajcik", "Laborum iusto perferendis nostrum et nulla enim minima quia. Ut repudiandae facere. Sunt voluptates tempora sunt veritatis eaque labore quia dolores. Sed iusto debitis. Aspernatur velit atque maxime illum quas.", "Quality-focused dynamic hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Caroline", "Feeney", "Fugit soluta itaque accusantium quisquam ipsam aut. Voluptas hic ducimus accusamus quas consequatur. Voluptatem doloribus omnis. Rem excepturi sunt quaerat molestias quia quis nobis.", "Customer-focused holistic infrastructure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Eloise", "Boyer", "Fugiat optio quia quos quia voluptatem rerum ex aliquam voluptatum. Voluptas dicta sit ut officiis. Sit consequatur et sint sequi sed ut recusandae placeat. Explicabo facilis consequatur itaque. Adipisci voluptas harum ea hic quidem. Autem accusamus repellendus aliquam veritatis quidem voluptatem alias saepe fuga.", "Profit-focused content-based time-frame" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 18, "Carlos", "Bode", "Numquam consequuntur illo quidem reiciendis enim aliquam. Placeat reprehenderit rerum voluptate. Voluptas quas temporibus fugiat. Enim quidem delectus unde et nihil perferendis. Ratione hic qui necessitatibus nisi harum velit distinctio.", "Pre-emptive multi-tasking frame", true },
                    { 19, "Herbert", "Wisozk", "Adipisci vel eius deserunt voluptas dolorum cumque. Nihil eligendi architecto. Aut magni ut debitis alias totam. Rerum alias ut sed perspiciatis non vero pariatur in eos.", "Distributed attitude-oriented approach", false },
                    { 20, "Claire", "Mraz", "Quo accusantium recusandae aliquid sed eius excepturi. Similique et amet sed. Velit et atque quos quam accusantium eos et facilis. Tempore et aspernatur ab reiciendis aut. Eos sed fugiat ut illum sunt.", "Versatile asynchronous interface", true },
                    { 21, "Carol", "Von", "Harum ipsum explicabo consequatur quo ea corporis eveniet laudantium ut. Quaerat sit enim soluta illum voluptatem impedit voluptatem perspiciatis. Qui quia qui facere. Nihil voluptatem et sapiente eos quasi sequi minima vel.", "Horizontal 5th generation policy", true },
                    { 22, "Rhonda", "Carter", "Delectus ipsam maxime officiis modi. Dolor nostrum ipsam ut omnis qui provident suscipit. Quis facere sit sint at modi itaque maiores possimus. Autem molestias consequatur laudantium nobis reiciendis excepturi laboriosam. Hic soluta fuga autem enim. Ea aliquid reiciendis debitis in hic.", "Function-based zero defect conglomeration", true },
                    { 23, "Irving", "Brakus", "Dolorem qui sunt laboriosam nesciunt sit animi magni incidunt debitis. Inventore possimus suscipit consequuntur consequatur est facere voluptatibus repudiandae. Temporibus quas et dolorem nisi alias perspiciatis ex pariatur eos. Velit aperiam dignissimos. Rerum consectetur dolore.", "Stand-alone 24/7 open system", false },
                    { 24, "Adam", "Cormier", "Aperiam omnis non dolores quaerat eos repudiandae nihil. Accusantium accusantium laborum odit sint dolores cum cupiditate sed. Aliquam facere est ipsa vitae quia.", "Advanced well-modulated encryption", false },
                    { 25, "Casey", "Maggio", "Ipsa accusamus voluptatem sint. Dolores ut quam consectetur voluptates voluptate. Et ipsum enim inventore et odio esse quia molestiae.", "Total 5th generation focus group", true },
                    { 26, "Cassandra", "Schoen", "Saepe non consequatur voluptate autem ipsam. Hic et ipsum molestiae consequuntur qui fugiat provident voluptates similique. Illo corporis beatae sunt consequatur dicta doloribus est reprehenderit. Consequuntur dolor voluptatem quisquam quis et odio in enim dolor. Omnis reiciendis ea qui a.", "Synchronised human-resource system engine", false },
                    { 27, "Olive", "Pagac", "Ut culpa quas qui doloribus aut aut. Et dolor aut ex qui. Placeat quo odio sunt fugiat. Ea et blanditiis repudiandae cumque sit eos aut earum. Rerum velit ea nulla voluptatem officia quia excepturi illum. Adipisci enim saepe nulla quia.", "Re-contextualized well-modulated customer loyalty", true },
                    { 28, "Leona", "Nitzsche", "Libero quaerat libero autem qui sit neque. Nulla qui cum et omnis. Sed impedit et rerum molestias commodi repellendus culpa nam.", "Reduced incremental benchmark", false },
                    { 29, "Jill", "Schroeder", "Sit cupiditate quod vitae deserunt tempore omnis fuga. Dolore consequatur architecto temporibus earum omnis et deserunt voluptates. A eveniet aspernatur accusantium quis asperiores repellat numquam eos.", "Monitored executive complexity", true }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "7c1d45f0-eca2-491f-8a94-e065704cd367", "1bd8d454-d22c-4b50-9b37-3cc3a3864617" },
                    { "e4dbd695-01f4-4716-bb73-0057112f6e73", "27adeb07-a51f-4290-a04e-c04ed91609a3" }
                });
        }
    }
}
