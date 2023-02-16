using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class PushingForwardAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d65d675-8360-4f19-9501-612587bfdc9b", "78f9a518-2fd5-493d-86c4-18fd16b74576" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2ea5bf7-9634-4a48-9433-1d4c034e12e3", "99b8c212-3e64-4776-9557-dda4eb642908" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "043fe08a-d3be-42a0-8f84-c5664a52b093");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d54692f-2edb-4016-8b14-6863fd32a7a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23f96791-e6a2-4f44-9430-439092aaf6f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25a851e2-d3fc-41f4-9f15-357df4c6ee54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25e5f6b3-e2fc-47c6-b9ec-a2bd74a5d167");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f61246e-ebcb-47da-8d97-d06f99a333f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40f7fe38-8a55-4027-80f4-1d51baca8bd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "427409d7-eb7b-47cf-8adc-98d2b5d2004c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f3bd543-0caa-4a5f-8aa8-a4a671b71642");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "518f498d-31e2-4a57-b102-8af1545a9049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c0d0a91-659b-473b-8f2f-5a1aad0cb1fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a9994bd-1e89-4a6d-8fc6-e2290f57a602");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89832927-8c49-4403-913d-26f7e39e1ba3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf5e7f3f-d074-46e8-b2bc-b321a74369f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db773bef-5ea2-4fe4-81b7-dbea61ddc7be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e767e81b-80b6-4fe9-a869-f5bfc92a80e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3d254c-6d5f-4393-a433-431950b2ff92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbffd51f-2e59-422f-97ae-f238517124f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d65d675-8360-4f19-9501-612587bfdc9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ea5bf7-9634-4a48-9433-1d4c034e12e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78f9a518-2fd5-493d-86c4-18fd16b74576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99b8c212-3e64-4776-9557-dda4eb642908");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "54862dfe-b5e0-4edc-a69e-1bf90aed4e53", null, "admin", "ADMIN" },
                    { "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "121e1b8b-597a-4260-a8df-c94ef9912a12", 0, "243af548-b400-4b91-9e47-776006c33e22", "julie.vandervort21@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAt7KwKMeYd7gmgCm9Igh/aWKTvCZsVFP/YnPyMLDxDwLmbEiFrzVrEYrcukfJmNQQ==", "593.561.7518", false, "e578e423-9bf4-4a6a-8a4e-6de8cf07f87b", false, "Julie.Vandervort21" },
                    { "2ab0a9e8-3815-48dc-ac75-ef7efb75af69", 0, "f766164e-9018-4688-9da5-7cbe24aab453", "alejandro93@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEA+V+xhmTvpKDYLZPgG1cIG5vgwr3+LtHa5D7ShqOI1ZqEZuEgGEeK16Z/I9sW5hTA==", "308.696.6086", false, "930545b1-4908-4fd0-8715-eb3910b4e9f7", false, "Alejandro93" },
                    { "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d", 0, "f81b2802-b72b-4906-8ccb-2593f3fc995d", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEEZc0W5N+tVelgw2MHR/uJtgkwt2EEXazsYRISwe3ZIwJaMXLM61NzTRbViyyrT67A==", null, false, "2cabb625-c26a-4ab8-997e-3dd93ec4efff", false, "librarian@library.net" },
                    { "5317be92-87c7-4187-b393-8ee92178501c", 0, "7fdd1065-390c-444d-a30e-87ef7aa6f355", "clara.orn50@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHDY/TCLKjanN5HaXeEZ+T3JwCUvRz9/xft0RK9UcQ/PBXu6b3zS/Wo9NehmHFs3+w==", "(966) 785-3738 x292", false, "15c1f977-ee5a-489d-a4d9-eb3ef2ff2072", false, "Clara.Orn50" },
                    { "5bb27782-41a3-4ab8-8341-49cd045adcd8", 0, "b5ceffd5-cf73-4309-9f00-7c5a12d2b01b", "ruben.denesik29@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJP4Pg3Z0ihnfzKthUyZ8DFra4/cIBvtT3Y9d8LaqCKVu9tObaTD2LUFB9p/4XBMMA==", "1-942-377-6347 x7582", false, "8937cb28-e27b-4842-b2da-e7935276afee", false, "Ruben.Denesik29" },
                    { "6bd020ac-1964-49bd-b4aa-702bda5fbfa9", 0, "d8b4b5a4-cfa3-4606-83bd-324e4e331bb3", "irvin_murazik39@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIUjvl74gYFRqs9aeKkYB8WY/O6urvxkv5GIIsGETxppXGgF8olS7hmsq4Ps8nU/sw==", "(822) 575-3884", false, "fd35cb9c-d3cb-4a4f-9502-6705e1b9eb18", false, "Irvin_Murazik39" },
                    { "6df0e70b-054c-4654-a055-bf53760f6ed7", 0, "7a023de9-313a-4c26-897b-b42f643fa86b", "charlie.williamson14@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJRduwLXdIHJEO/HTkXYAEDj/5zQWcpDB8W4+S5z3bIF/hroqB4b5NkH3POxr3T22A==", "(736) 589-8192 x63940", false, "8f94d03f-c190-41bd-9f36-5bbdd1a94b8f", false, "Charlie.Williamson14" },
                    { "78ab77ea-6313-475f-a21d-137a30046576", 0, "c676ad95-073e-4e3e-ad66-3cfbe6fd2df0", "robin.pagac71@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEECKUu5qphIOrj/8zBADk+WfbKFcN2SCC9VV3oM90u7gl0sD+h520CbgkVThD/M2rQ==", "714.722.8821 x6092", false, "09dda151-cacd-444c-8236-0aaa4dea15ac", false, "Robin.Pagac71" },
                    { "924dda9c-8b34-4aaf-9525-a3a2791e0958", 0, "14fda472-83f1-4823-b023-dd60f7730646", "ernestine20@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFws2vJdydBcrK4SX2qaiO7FYD7WfmUuTRvwnKW1+ugJQPjocGYTt3BPq9Ra1fkg8A==", "510.902.0030", false, "78d18773-2822-4c60-8453-959d0f2f0a26", false, "Ernestine20" },
                    { "98dce13e-139b-4a43-a9b2-7a130341a9d4", 0, "02e07774-9691-4e07-aa3c-c07d22992462", "stanley_osinski@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJOwuWaOD/u1h36/ecM6MPlqo7W+g+GHtrwva94eAwwZFxsuc47mw0xdxQyYSrZx2g==", "879.796.0877 x436", false, "7e2d5b8b-ec23-47b0-adc8-0f3f6122f084", false, "Stanley_Osinski" },
                    { "c7187e98-3c7a-48f1-8174-d1f77fa090a6", 0, "474def5a-317d-4572-880a-546c97e04c4f", "salvatore.oconner40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ4xGQF4h0m3jr2mujmU3q1Zy6qHoycrLohVyGNTX82LVNODiQdCvtsZ+it6j9Pudg==", "370-487-8411", false, "f9d1d242-1e80-4db1-bee1-dd5891cee564", false, "Salvatore.OConner40" },
                    { "d2c2e2ee-876b-4d10-925e-d9d215a9da17", 0, "8140a178-a088-47fe-ab8e-5436b4b302b1", "rex_walter60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPvi41aUQZFpccGpwRbEwv85KmR8cnaV0oREexkOxtmU0OtJW6UK63t2JtYgeg2dpA==", "1-556-681-2429", false, "aa264f6d-be90-414a-9164-4876675c492d", false, "Rex_Walter60" },
                    { "d58d8487-434c-4825-a37a-18fa7c4a88be", 0, "80aecb03-67c4-470f-a405-2370727fe28c", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEPCXHr4w6WboWcAfew+uagBNDH4QYDQa315sbV9nSROR+FVFnSiZdr1QRt6CIYOeMQ==", null, false, "44745bbf-5389-43ba-b6ab-956359ea8cd5", false, "borrower@library.net" },
                    { "d65ca571-4855-40c8-86be-ff3cb016ebed", 0, "201bae92-fbe8-4814-b2a4-d9b971666609", "kristie94@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDcY7WahqrleESopAsSkqxRfssGRZ7B4a7O20YUJzkG61c5CZ6PWLFhhIbNy5YpzYg==", "1-256-820-8728 x73218", false, "aeffe199-65f3-45d1-b508-ca1688437d45", false, "Kristie94" },
                    { "e7d45c48-2e75-4d94-9b47-95b52324358c", 0, "2b594cc1-7b75-4529-ba6c-8998f0d149ed", "wilbert34@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECIHSeU1+rWylph6Pp7rknHIsGEQH+yblxOhYRem3gdEC0e2y6lFhlQv8sTsppQ+cw==", "1-772-587-5402", false, "b37d410e-aa55-4a60-ad4f-0c9916da08de", false, "Wilbert34" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Viola", "Boyle", "Quas qui rem ipsa quae id. Unde ut porro. Commodi eum deleniti et modi dolor commodi aliquid. Recusandae eveniet et incidunt debitis enim enim in. Qui quo modi expedita laboriosam veniam quis aut sapiente suscipit. Tempore aut rerum eveniet dolorem et neque.", "Future-proofed zero administration time-frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kay", "Hodkiewicz", "Sit in harum eum id. Vero qui culpa itaque. Accusantium beatae eum labore corporis cumque alias. Voluptatibus rerum itaque est non.", "Centralized cohesive frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Patty", "Von", "Error possimus ab iure inventore blanditiis numquam totam sed. Id rerum itaque quis tempore et magnam cum iste. Facere nihil et corrupti ratione. Ut et veritatis aut voluptatibus. Ipsum voluptate impedit soluta.", "Virtual neutral extranet", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jodi", "Walsh", "Dignissimos non sapiente vitae autem maiores sint debitis. Atque quia deserunt numquam qui. Ut necessitatibus eaque quo pariatur rem mollitia.", "Fully-configurable coherent forecast", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "William", "Reichel", "Consequatur molestiae nostrum commodi est voluptatem possimus nulla nihil laborum. Repellendus sed reiciendis delectus. Dignissimos quae officiis autem vitae aut vitae quae. Est et autem vel ipsum eos quis incidunt.", "Horizontal homogeneous capacity", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Hattie", "Cormier", "Voluptas aliquid reprehenderit. Possimus reiciendis similique quis alias. Quibusdam molestiae quia adipisci tempora delectus adipisci. Nesciunt non est voluptatem sint. Pariatur et ut rerum dolore aut perferendis vel quia non.", "Re-contextualized holistic ability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tyler", "Krajcik", "Minus et ut sunt molestiae iure est aspernatur provident. Eos aut magnam magnam non omnis. Delectus doloribus aperiam cum. Odit est et omnis ut consequuntur architecto sed necessitatibus. Consequatur ut accusamus.", "Pre-emptive mobile website" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jessica", "Fritsch", "Eum quia sed officia deleniti iste iusto asperiores eum. Quo omnis corporis amet quos aliquid ut architecto fugiat. Fugit asperiores dolorem ut. Deserunt dolor enim.", "Expanded 5th generation workforce", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Chris", "Emmerich", "Pariatur harum voluptatibus ducimus sint consequatur ullam in. Corporis repellendus qui dolor animi quia iste rem aperiam nemo. Quo tempora numquam laudantium nobis explicabo provident sint molestias. Distinctio facilis id dolor qui non beatae libero non.", "Synchronised 5th generation local area network" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Barbara", "Kreiger", "Ullam delectus libero et ut ducimus soluta. Modi similique omnis nesciunt odio accusantium maxime. Sequi accusamus accusantium. Neque accusantium ut non eum magni magni soluta minus non. Quam esse eius blanditiis beatae voluptatem eaque quis.", "Total local architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rolando", "Doyle", "Necessitatibus ut cum eius. Est eos autem ut est. Consectetur hic praesentium occaecati atque eum. Sit dignissimos sapiente maxime sunt sit commodi dolorum voluptas omnis.", "Triple-buffered attitude-oriented process improvement", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kathryn", "Gislason", "Provident voluptas rerum. Labore aut ipsam et fugiat magni sit. Consequatur repudiandae necessitatibus minus omnis. Placeat sit nulla et illum fugiat nisi sint voluptas. Placeat blanditiis est cumque nihil quo deleniti porro.", "Universal reciprocal intranet", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Hope", "Oberbrunner", "Aut pariatur iure. Enim amet quidem assumenda et non consequatur omnis quod. Et voluptas sunt voluptates quae pariatur quod ut. At eos harum. Voluptatem temporibus facilis qui minima est voluptates quos velit similique. Odio nulla recusandae.", "Synchronised non-volatile info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Larry", "Kshlerin", "Enim animi quia tenetur asperiores ut quasi quam cumque molestiae. Id error et assumenda ea quia distinctio omnis. Laborum debitis voluptas beatae molestiae ratione eum accusamus.", "Secured user-facing toolset", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Phillip", "O'Connell", "Alias at repellendus autem. Inventore sit accusamus rerum consequuntur sunt velit. Distinctio eum a ut autem ducimus nihil fuga et quam. Corrupti itaque ut cum a ut est voluptas. Recusandae repellendus adipisci fugiat a animi earum. Et ut ea et minus alias eaque velit.", "Multi-channelled bi-directional migration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Joan", "Hackett", "Quisquam magnam rerum voluptatem voluptatem quasi molestias ut fugiat. Mollitia sit qui et ut repellat sapiente aut quae. Adipisci sit iure autem quia.", "Devolved stable toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sidney", "Hartmann", "Ut earum quidem aspernatur id. Sed ea ipsam dolores est dolores sit ut magni voluptatum. Aliquid minus earum deserunt magnam aut ullam consectetur. Odit similique enim occaecati exercitationem nemo assumenda autem accusantium aut. Consequatur dicta aut cupiditate sit. Iure veritatis reiciendis nostrum quisquam.", "Mandatory leading edge internet solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terrell", "Gerhold", "Aut ex earum vel possimus debitis molestiae. Eum impedit in pariatur. Dolore odio omnis impedit est asperiores rerum incidunt velit quod. Atque rerum magni maiores eius similique voluptas quidem. Reiciendis ipsa ut.", "Focused dedicated open system" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Myron", "Homenick", "Omnis ut eius ullam voluptatem et impedit recusandae cupiditate. Nulla in et qui aut aut vel. Eveniet incidunt ad iusto iste earum.", "Optimized dedicated application" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ivan", "Smitham", "Veniam voluptas et aut ipsa nihil quia autem consectetur impedit. Accusamus accusamus eum cumque. Blanditiis consequatur aliquam aut quo. Sit nobis ut voluptas rerum occaecati tempore earum.", "Object-based cohesive help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bryan", "Thiel", "Omnis atque est quaerat aut. Incidunt earum provident in. Sapiente et dolor ab. Pariatur in illo iure. Architecto eaque aliquam quia nisi aut et eligendi vel. Ut ut provident.", "Up-sized scalable analyzer" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wilbur", "Skiles", "Voluptate ea ullam ullam quia sed. Necessitatibus corporis illo laudantium vero. Et quam voluptates qui accusamus eligendi et nobis. Fuga corrupti veritatis delectus itaque est quaerat voluptates in est. Ut et quis.", "Automated maximized success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Doyle", "Schroeder", "Quas ut voluptas nihil amet aut nesciunt recusandae voluptates sapiente. Incidunt laboriosam est eaque placeat aut quia. Nisi ut amet dicta ipsa. Magni incidunt est veniam. Et velit aspernatur sunt nulla consequatur et et.", "Extended mission-critical concept", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Philip", "Tremblay", "Et officiis omnis ut veritatis quam unde. Voluptate temporibus in deserunt. Totam ratione eveniet enim rerum sit consectetur eveniet. Magnam commodi odit voluptatem et amet laboriosam dolor inventore. Placeat est vel est labore ab dicta illo excepturi. Aut nulla ut debitis fuga reiciendis exercitationem sunt qui.", "Programmable neutral architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Morris", "Toy", "Ea dolorum beatae error et soluta. Doloremque sit laboriosam saepe aspernatur dolorem et. Repellendus eligendi vel et voluptas est enim corrupti. Voluptatem sint unde est nulla omnis autem vel labore possimus. Esse soluta iusto aut. Alias ut provident quia quas.", "Team-oriented system-worthy extranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jordan", "Williamson", "Laborum ab ea assumenda corrupti minima illo ratione. Tempora sit doloribus nobis quos quo vitae rem. Aperiam aliquid enim maxime sunt sit voluptas veniam.", "Down-sized systematic strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristopher", "Bruen", "Hic sed sint labore architecto numquam excepturi ut voluptatem fugiat. Blanditiis deleniti dolorem optio qui. Eum quia sint debitis nihil sint nesciunt nesciunt quia pariatur. Facere doloribus dolor dicta. Delectus possimus ex. Adipisci voluptatem ut dolorem et voluptatum repudiandae blanditiis.", "Virtual demand-driven installation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Woodrow", "Graham", "Similique quas velit. At rerum omnis. Molestiae repudiandae amet qui. Blanditiis quaerat neque in nostrum quia beatae cumque.", "Networked systematic paradigm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gustavo", "West", "Doloribus rerum cumque omnis a veritatis eos nisi facilis inventore. Ut quos neque animi nostrum officia. Qui sapiente praesentium eveniet dignissimos ut consequatur atque dolor. A quas tenetur est sed. Ea aut rem tenetur. Perspiciatis id quos explicabo odio omnis.", "User-friendly mission-critical pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Howard", "Franecki", "Repudiandae illo inventore quis vero totam possimus. Est veniam et quo et molestiae. Iure iusto veniam adipisci reprehenderit quis enim.", "Diverse encompassing architecture", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Daniel", "Swift", "Eos neque id non doloribus et molestiae non dolore voluptas. Odio et id ut ipsum nihil natus. Maiores ut laboriosam qui quia hic nobis dolorem. Non animi et delectus similique doloribus magnam. Rem accusantium totam qui a et id est quasi. Dolorem eum quod recusandae molestiae in magnam quia.", "Fully-configurable systemic productivity", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Eddie", "Nitzsche", "Totam ullam odit et consequatur in aut. Omnis nihil ipsam quos id qui dolorum laborum. Maiores quia necessitatibus facilis expedita autem quia sit ut dicta. Illum incidunt dignissimos perferendis necessitatibus velit dolorem veritatis nam enim. Repudiandae velit nemo quos quaerat et sit quod. Aut vitae voluptates consectetur quidem ut quibusdam earum facere minima.", "Fundamental explicit portal" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Salvatore", "Hintz", "Est aut velit perspiciatis. Autem dolor sed voluptatem doloribus. Ullam qui culpa quae ducimus odio mollitia quidem. Dolore magnam doloribus et sapiente libero enim. Voluptatum sit porro molestiae omnis aut quaerat ad molestiae quae. Ea incidunt sed aut cupiditate aliquam cupiditate eveniet.", "Upgradable client-server workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gregg", "Armstrong", "Dolorum iste sit cum natus et. Dolorum at enim dignissimos ut consequatur odio dolorem mollitia. Voluptate ea eius fuga pariatur consequatur. Quo molestiae at quis aut.", "Customizable national core", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sherry", "Bernier", "Dolore veniam voluptatem laboriosam. At dolores optio. Harum quaerat maxime. Sapiente occaecati qui esse voluptas officiis et non omnis dolor.", "Right-sized 5th generation intranet", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 36, "Salvatore", "Williamson", "Esse dignissimos et mollitia pariatur iusto voluptas nobis rerum. Et occaecati dolorem dolorem et quis. Molestiae architecto autem reprehenderit rerum hic deserunt dicta iusto corrupti. Facilis sed officia placeat voluptas. Unde id id dolor.", "Reactive composite frame", true },
                    { 37, "Robin", "Rowe", "Suscipit magni aliquam omnis quod perferendis minus at. Harum neque quo qui incidunt optio ducimus. Excepturi blanditiis aliquam a error assumenda. Id et rem aut.", "Sharable bandwidth-monitored open architecture", true },
                    { 38, "Jody", "Hills", "Debitis consectetur ut ratione rem nulla excepturi sunt harum. Quia et voluptatem ipsum officia. Qui fugit inventore.", "Reactive incremental firmware", true },
                    { 39, "Eric", "McGlynn", "Sit voluptas non. Quia fugit porro quisquam. Facere rerum inventore voluptatem iste sequi ea. Praesentium accusamus nemo non laborum qui perspiciatis vel. Et iure inventore pariatur sit dolores soluta adipisci.", "Implemented bifurcated forecast", true },
                    { 40, "Francisco", "Koss", "Maiores error quos suscipit est. Rerum consequatur a labore veniam accusantium similique veniam mollitia excepturi. Aut esse rerum blanditiis est non.", "Object-based human-resource extranet", true }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "54862dfe-b5e0-4edc-a69e-1bf90aed4e53", "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d" },
                    { "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed", "d58d8487-434c-4825-a37a-18fa7c4a88be" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54862dfe-b5e0-4edc-a69e-1bf90aed4e53", "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed", "d58d8487-434c-4825-a37a-18fa7c4a88be" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121e1b8b-597a-4260-a8df-c94ef9912a12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab0a9e8-3815-48dc-ac75-ef7efb75af69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5317be92-87c7-4187-b393-8ee92178501c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bb27782-41a3-4ab8-8341-49cd045adcd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd020ac-1964-49bd-b4aa-702bda5fbfa9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6df0e70b-054c-4654-a055-bf53760f6ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78ab77ea-6313-475f-a21d-137a30046576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "924dda9c-8b34-4aaf-9525-a3a2791e0958");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98dce13e-139b-4a43-a9b2-7a130341a9d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7187e98-3c7a-48f1-8174-d1f77fa090a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c2e2ee-876b-4d10-925e-d9d215a9da17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d65ca571-4855-40c8-86be-ff3cb016ebed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7d45c48-2e75-4d94-9b47-95b52324358c");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54862dfe-b5e0-4edc-a69e-1bf90aed4e53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d58d8487-434c-4825-a37a-18fa7c4a88be");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d65d675-8360-4f19-9501-612587bfdc9b", null, "admin", "ADMIN" },
                    { "f2ea5bf7-9634-4a48-9433-1d4c034e12e3", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "043fe08a-d3be-42a0-8f84-c5664a52b093", 0, "1f7bc5a8-3284-4bc8-8118-27c0b684e073", "harvey.ernser@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEL29fyRckrGxOB8rnuTNjfFY7gNWWbXASOXPCYfXcG6lknbbg0EamYAln60+J06TvA==", "265.670.7012", false, "eefa3622-f5bd-433b-84e9-249dd979269c", false, "Harvey.Ernser" },
                    { "1d54692f-2edb-4016-8b14-6863fd32a7a8", 0, "5db0ebeb-6501-4b4c-b604-44c72b8c2237", "melody_corwin34@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAilhSwrsmIdaaAXTI3oLJTz/M0VUjzM6X54p4ZU67V3l8uvLF9E4Xf/6Gdk9G6B8Q==", "357-749-8370 x5028", false, "f88b9bf6-b28a-4818-827d-0db0316a1f78", false, "Melody_Corwin34" },
                    { "23f96791-e6a2-4f44-9430-439092aaf6f1", 0, "9ca37d2f-6f81-49bf-98a5-567dd8d6352e", "elsa91@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMriH8DebR2WllhKvGXIExy+lZZocRKmUl+wmBVQmLjJNZG72FVV4oZEkUG0iwwuXw==", "664.645.9004 x6656", false, "d0288a0d-75f4-434d-8923-34b8c34c5356", false, "Elsa91" },
                    { "25a851e2-d3fc-41f4-9f15-357df4c6ee54", 0, "cf8a56cf-1a85-4e79-9338-65da80738533", "henrietta_dicki32@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFUdd4a2bbHIEGipW6AoYEF11olz8mvGJoPPVj8C84x2mO7lXecpwpBW0eHuCrDGTg==", "1-847-738-0009 x3316", false, "326cf835-b05b-4b95-a020-0a9bf0e93195", false, "Henrietta_Dicki32" },
                    { "25e5f6b3-e2fc-47c6-b9ec-a2bd74a5d167", 0, "51a98254-6f10-4ea3-a951-a8a39ccf3d6e", "wilfred_hoppe@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOmvYUZJaHk/0NIv/Jq0GKp79l4Qa01PIJSWmhAEmOmX8hPuA4QFQR47c1ZOFCKn9w==", "(562) 550-1875 x0900", false, "cd13602c-928a-427e-a63d-192751fc233e", false, "Wilfred_Hoppe" },
                    { "2f61246e-ebcb-47da-8d97-d06f99a333f8", 0, "838c0d49-6a03-45b2-8422-3a6d65339788", "catherine80@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEB+kAAH6bW59vDU5t3KMaKWZWcld2xi1qx6WYpqyvDuynhR643DlDT3GHLGeS+9qJA==", "(690) 224-4210 x304", false, "0fdb9959-de10-4a6e-9bd4-2faaa5613703", false, "Catherine80" },
                    { "40f7fe38-8a55-4027-80f4-1d51baca8bd4", 0, "b73efa91-b547-4fa4-bd43-dd3bb2a2a5e1", "jean80@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEJgd2k+apxMPmvk47xe+Rf8XuxyKS1I6wEGpsB2nTsywSXNs97I38icrvwvSmv8Jw==", "1-984-771-0446 x7149", false, "c6f7cdce-3d38-445a-9dd0-0ec3b4a50ce8", false, "Jean80" },
                    { "427409d7-eb7b-47cf-8adc-98d2b5d2004c", 0, "74a2b7eb-d45f-4455-ae3d-fc322a090513", "hugo83@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFbOtbntPERw5j1BbO3NpjAPucNo6X4AafWGIE4Y2otSAMX+1SWus2MIgQJt0qW3NA==", "251-587-5760", false, "65eecd23-4657-4516-9d66-a4522cb01aea", false, "Hugo83" },
                    { "4f3bd543-0caa-4a5f-8aa8-a4a671b71642", 0, "5f782bdf-92f0-4e9c-928d-644337f127a9", "toby58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEMWEsk80sNT7sDmZHifEJKOLEZtNT21/c2c90oEIyUX/DN4hJBx87CN44EUXY5fBQ==", "1-447-344-4408 x509", false, "905fb6ad-1082-41f7-8c1f-3a11880a1795", false, "Toby58" },
                    { "518f498d-31e2-4a57-b102-8af1545a9049", 0, "fac6253f-e6b3-4f5a-827a-209e339bea4b", "mandy84@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFldacISoMFsymP+AHIlesDjQJtZct0rKoG3kGqiQv8k+Q9Hxt4RwU4WWYfcA8HwPw==", "1-612-437-0578", false, "f6f3353f-3672-4c32-8395-d8e8245d432b", false, "Mandy84" },
                    { "5c0d0a91-659b-473b-8f2f-5a1aad0cb1fb", 0, "491c8207-b592-4fb6-ab36-b4bccbfd3cec", "stewart_little36@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAA4ai78oR512N4poAof/Z8XNpSDvtQStwhT9yMHA/0i9CQQ84qHOLygX/PHrrGE1Q==", "247.295.3480 x205", false, "d68d6028-148f-4097-b0cd-9dc49257490a", false, "Stewart_Little36" },
                    { "78f9a518-2fd5-493d-86c4-18fd16b74576", 0, "fba72e66-1284-4126-8175-f109c96e9750", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAECRF1ejUXOO5FIsh2sleLokhXlovkQl+T+LqvHr5VgWBjWMUVFV7W5gTNzJ+PWJiJw==", null, false, "a346407c-9bc3-4211-b6d9-3981ba58d848", false, "librarian@library.net" },
                    { "7a9994bd-1e89-4a6d-8fc6-e2290f57a602", 0, "ae67acfb-b87d-4b70-a4df-e15e4933192c", "elaine_armstrong43@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHkqspVzz5nIufNzdWVDGunqmrrKJZOhp1iPUweRgWyBZwZbY2v/MyaASgZZoWwbKg==", "1-649-228-6047 x7344", false, "60da4b51-c905-4a06-b5d5-b77cc3a2b30d", false, "Elaine_Armstrong43" },
                    { "89832927-8c49-4403-913d-26f7e39e1ba3", 0, "f640f1bb-b647-476b-8ffb-6c418516f40c", "dustin.mccullough@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFE0AaDyNwA1u5ok3rufPe4nB6j91XII5X1+tE/PPetGhrfZ8dnB/RKBhjAhNE1EFQ==", "(631) 842-3911 x67035", false, "f4c11736-3da8-44e2-932f-6770d5514af1", false, "Dustin.McCullough" },
                    { "99b8c212-3e64-4776-9557-dda4eb642908", 0, "3c932f18-6aa6-40fc-a7a9-170ce2a795c4", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAECqfGha0GeUlQ2TamJhnVYD6NSsEIhepg2W1RkSnb/QrYyollhvJeNRUEvSypMZtdA==", null, false, "10d5d12e-2ddd-4e3e-a899-0ea689c1e361", false, "borrower@library.net" },
                    { "cf5e7f3f-d074-46e8-b2bc-b321a74369f0", 0, "e12220fc-cebf-49bf-89a2-22ae7b4f6354", "alberta.buckridge@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELNejmHUUpST2gtwVises01/C4b03YPsv5xnab8TpH6E874ZycbCQRb/u0axSCUvgw==", "267-335-8349", false, "29e8bfca-7817-402d-b65d-13a9caeb136f", false, "Alberta.Buckridge" },
                    { "db773bef-5ea2-4fe4-81b7-dbea61ddc7be", 0, "ba9b243a-84f0-4cec-8bb9-a7bece9887c5", "sammy.goldner@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHO9P+cFXa7vV9NzmQ8i7wSo7oXli4kKPLWPY7jgEg/hk+fhdIm3tv4Wvh/eoIkc4Q==", "1-659-775-6079 x745", false, "0ea482b5-fbbd-4c4b-91da-17c7c558e55d", false, "Sammy.Goldner" },
                    { "e767e81b-80b6-4fe9-a869-f5bfc92a80e7", 0, "45cc26c0-94ad-4156-99e5-5e21a669f7f6", "alejandro_borer@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIYH5P0CGnc4zua1udue4E2ftqsepTUZxmBHvaUnWMSjCH1HnLZ+//1knphTXTUglA==", "(290) 520-6653", false, "e39b9da8-a17c-4242-809a-70fafbe22c03", false, "Alejandro_Borer" },
                    { "ed3d254c-6d5f-4393-a433-431950b2ff92", 0, "2bf95171-3988-4372-bb43-99b01a4d11fe", "phyllis.roberts@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEF392zuTm53uKj/4wfhw/Pb37QGXVvIs9sxqi3p0la3pcgLWfVgaezsOh67REl0U3Q==", "(782) 252-9599", false, "a6e8b801-8fdd-4f9c-9834-eb50408c2a30", false, "Phyllis.Roberts" },
                    { "fbffd51f-2e59-422f-97ae-f238517124f4", 0, "0472a9c1-963d-4db5-ba40-1530f47abba7", "phil62@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENKl4oAZU7MGBoxe2ocxD6JMSttjphjNgPXBs6EAiWGQ/CbH55f7TCXZ4679wASGzg==", "371.901.0022 x931", false, "624d2eb2-cc10-4d0b-9ef0-603d951f0e2e", false, "Phil62" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "George", "Kessler", "Odio voluptatem voluptatum ut et. Doloribus nihil voluptas fugit et ducimus. Doloribus blanditiis beatae. Fuga et hic. Dolore sint placeat.", "Reduced 5th generation installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Emanuel", "Gerhold", "Iusto optio dolore aut voluptas architecto consequatur dolorem nulla est. Deleniti voluptatem a vel voluptates fugiat rerum ut voluptatibus. A impedit cumque.", "Focused fresh-thinking frame", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Winston", "Mann", "Reprehenderit dolor illum temporibus dolorem dolores. Et sed autem modi dolore in sed tenetur. Beatae totam hic ut officia. Aut perferendis ut perspiciatis quia dolorem atque corporis dolor.", "Re-engineered incremental task-force", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Terry", "Flatley", "Voluptates doloremque velit magnam amet architecto voluptas. Voluptas et minus qui sed ut culpa nam iste. Nihil reiciendis ut.", "Operative logistical access", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Roosevelt", "Ernser", "Omnis amet enim rerum inventore impedit ad dicta. Impedit distinctio est optio dolor. Esse ea exercitationem sed et laboriosam. Reiciendis qui quidem sunt molestiae nobis deleniti dolorem in. Voluptas dolorem earum similique beatae velit laudantium. Dolorum sapiente unde adipisci sit.", "Grass-roots attitude-oriented application", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lyle", "Stroman", "Autem ut tenetur. Hic dicta ea ea consequatur illum ea. Atque voluptas consequuntur culpa. Cumque rerum amet omnis dolor facere iusto harum voluptas rerum. Inventore recusandae et in qui eveniet. Perferendis doloremque corporis ipsa odit sit voluptatem id.", "Multi-channelled user-facing challenge" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Irene", "Olson", "Asperiores rerum et. Omnis blanditiis nemo rerum dolor inventore. Sunt consequuntur distinctio. Aut deleniti provident suscipit sit fuga.", "Monitored attitude-oriented encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dominic", "Spinka", "Quia temporibus ipsam explicabo nesciunt quia. Ducimus error quis non qui sed architecto iusto quis distinctio. Doloremque ipsa odit quam dolores laboriosam odit facilis ducimus. Nostrum nihil laborum aut adipisci. Possimus quibusdam est iusto deleniti ea veniam. Perferendis numquam aut qui et soluta qui accusantium.", "Up-sized uniform data-warehouse", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Joan", "Crist", "Quo ut rerum et vitae sint est voluptatem expedita. Aliquid veniam quas delectus delectus. Impedit repudiandae similique eum perferendis sint commodi blanditiis. Aliquam voluptates nihil ea qui. Occaecati voluptate placeat eaque deserunt eum.", "Ergonomic well-modulated projection" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Pamela", "Sawayn", "Expedita quae quod ex dicta eos nobis nihil porro. Qui rerum soluta et autem id ut exercitationem cum. Repellat excepturi dolorem est sit ducimus maiores sit ex. Facilis et molestias reprehenderit non est. Esse officia dolor impedit illo. Quia autem ea facere excepturi id enim.", "Seamless upward-trending structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Philip", "Dare", "Velit voluptate eos maxime. Quod quia est molestiae voluptatem excepturi. Omnis qui est id et laudantium ut.", "Team-oriented secondary info-mediaries", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Leslie", "Schaden", "Perspiciatis illo est enim qui maiores ex reprehenderit vero. Id qui dolores dolorem recusandae voluptatem quia id eos. Laborum ut unde dolor cum perspiciatis. Vel omnis adipisci aut dolore qui. Voluptatem omnis eos non ut animi cum autem enim. Odio nostrum aliquid ea veniam soluta provident.", "Optimized 3rd generation monitoring", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Diane", "Graham", "Accusantium adipisci et harum est. Perspiciatis veniam quo accusamus cum nulla debitis non placeat quis. Quis qui iste modi ratione quas aut quis ea praesentium. Fugiat laboriosam dolorum cumque ut voluptas quos. Dolorem dolor autem exercitationem iste quo incidunt.", "Ergonomic client-driven implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jerry", "Smitham", "Totam quidem est minus excepturi voluptas est explicabo nostrum. Sed consequatur non culpa asperiores magnam deleniti saepe voluptatem commodi. Sapiente esse culpa porro voluptas et minima. Ipsa quisquam doloremque totam adipisci reiciendis eaque libero. Sapiente recusandae perferendis deleniti rerum dolores voluptatem sed veritatis.", "Integrated attitude-oriented hierarchy", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sidney", "Cartwright", "Ea laborum et qui sit est sapiente aut sit porro. Molestiae a minima sequi unde. Id voluptates ut eum officia repellat eum nihil. Illo ipsam occaecati dolore perferendis a non blanditiis ut. Perspiciatis repellat cumque perferendis est.", "Programmable context-sensitive installation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lowell", "Wehner", "Excepturi et minus omnis. Enim architecto rerum dolore voluptas ullam repellat. Sed asperiores accusantium doloremque saepe illo nemo et maxime. Dolor odio molestias aut rerum rerum consequuntur provident nihil quidem.", "Reactive transitional adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Andrea", "McCullough", "Minus suscipit est ipsa alias. Architecto sint quos tenetur velit dolorem quia. Nobis placeat in et debitis id rem nisi. Rerum nulla eaque minima autem quia esse doloremque et fugiat.", "Triple-buffered bi-directional core" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Heather", "Yost", "Aliquam ut iste rerum minima excepturi voluptas sint. Inventore nostrum nostrum. Placeat consequuntur adipisci minus sapiente. Ut aut non sit tempore dignissimos nulla quia ullam minima.", "User-centric attitude-oriented knowledge user" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Roosevelt", "Wolf", "Nihil qui dolorum quia suscipit est quia. Dolorum hic enim deleniti. Quae et dolores delectus tenetur. Atque ut nulla ducimus delectus. Maiores quasi non molestias tempora est.", "Cross-group high-level intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Colin", "Kuphal", "Nemo veritatis quibusdam sint alias suscipit delectus non adipisci qui. Delectus eum corporis ipsam dolorem non esse ut aliquam temporibus. Quia quos minus. Autem aliquam aut eligendi illo aperiam labore.", "Streamlined value-added encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lee", "Towne", "In ullam in repudiandae pariatur beatae exercitationem porro nulla. Et aliquam distinctio ex necessitatibus deserunt quae nemo. Sunt ut sequi ipsa et asperiores magnam voluptatem dolores omnis. Occaecati voluptas porro vel culpa quia.", "Profound clear-thinking capability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Reginald", "Donnelly", "Voluptas ut ad. Eum dolorem ad rerum voluptas aliquam est vel quis quidem. Sit eos sint et unde enim quas aut.", "Switchable systemic strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Betty", "Schiller", "Labore consequatur non. Animi qui omnis et fugit reprehenderit consectetur. Eligendi excepturi et pariatur in qui repudiandae. Ex ratione aliquam vero culpa fugiat porro. Molestiae explicabo molestiae esse odio qui ut qui est.", "Inverse bi-directional orchestration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Billy", "Emmerich", "Id distinctio ex natus dicta. Aut modi alias dolorem voluptatem aut exercitationem quisquam. Sed dignissimos est natus porro harum.", "Digitized explicit encryption", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Abraham", "Hodkiewicz", "Veniam enim voluptatem sint ut. Assumenda qui inventore officiis distinctio expedita. Dolorem nam aspernatur ducimus provident laborum. Et maiores velit quaerat ex. Enim minima et est.", "Fundamental client-driven hub" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Christie", "Mraz", "Et neque ipsum. Voluptate alias occaecati voluptas nobis minus repudiandae similique. Accusamus odit qui vel. Eius explicabo debitis facilis totam aperiam.", "Multi-tiered object-oriented application" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Hilda", "Cruickshank", "Ut culpa vero vel. Sunt nesciunt ex et sed in consequatur dolore. Molestias aperiam doloribus ut soluta. Dolor repudiandae velit culpa maiores ut rerum voluptas quasi ea. Magni nulla sint reiciendis enim et.", "Persistent motivating adapter", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Johnnie", "Cassin", "Fuga assumenda sapiente corporis sit corporis. Pariatur nulla nobis. Quibusdam molestias magnam provident quis. Quod rerum dolores.", "Ameliorated zero defect toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Amber", "Larson", "Laudantium impedit accusantium sunt. Illum sit ut error ratione tempora a maiores quod officia. Quo qui beatae dolores tempora optio reprehenderit unde temporibus autem.", "Reverse-engineered even-keeled pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jim", "Ernser", "Quasi atque enim veritatis quis quia molestiae. Qui quia incidunt maiores tenetur et aut quisquam. Aut voluptas consequatur vel exercitationem facere eum quae rem nulla.", "Cloned exuding conglomeration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Roderick", "Sipes", "Voluptas assumenda earum qui quae. A hic quo nisi consequuntur at enim magni ut. Quia sit laudantium accusantium et sunt ratione quisquam sed optio. Quas exercitationem tenetur delectus odit. Sit aut fugiat culpa nihil sit maxime rerum minima sit. Doloremque nostrum similique ipsum consequatur natus amet sit.", "Self-enabling content-based workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Donnie", "Kuhic", "Alias et tempore expedita ex unde. Laboriosam consequatur quasi eos in quia quae. Dolor sapiente ut dolore. Iusto est praesentium.", "Reduced zero tolerance local area network" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darnell", "Rice", "Molestias sed dolorem magnam exercitationem excepturi quae. Et officiis est voluptatibus iure velit et qui. Ipsum quis non ipsa ut et vel minus culpa voluptas.", "Decentralized context-sensitive Graphical User Interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lela", "Dicki", "Voluptatem voluptas dolores dolor quis et eos dolor. Sed mollitia possimus voluptates voluptate aut labore maxime. Dolorem ullam fuga dolorem.", "Centralized 4th generation solution", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Cecelia", "Bartoletti", "Odit sapiente aut qui consequuntur. Esse illo porro. Voluptate iure animi reprehenderit. Est a eum reiciendis modi in architecto nisi. Totam aut in dolorum omnis suscipit qui. Pariatur eos corporis minima quae omnis dolore non.", "Multi-tiered heuristic support", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d65d675-8360-4f19-9501-612587bfdc9b", "78f9a518-2fd5-493d-86c4-18fd16b74576" },
                    { "f2ea5bf7-9634-4a48-9433-1d4c034e12e3", "99b8c212-3e64-4776-9557-dda4eb642908" }
                });
        }
    }
}
