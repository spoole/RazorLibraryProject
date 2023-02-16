using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class DroppedConflictingIndices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "Book",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16);

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
                    { "654313e4-aa45-450a-939e-c242549715cc", null, "admin", "ADMIN" },
                    { "b1f9f862-d433-4f4f-8e16-f496e529e2b9", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "056f53ea-e872-405b-8ff5-bce8d30f6f9f", 0, "e051d72b-c71a-42b3-8fc7-e30c9844efb8", "leah_windler34@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEN+XODmv93HmpTC5gghAvEcnT4it8eNdUxidfas53wQ4weG+DoODkDNwZhK+MJw/WA==", "1-565-465-2580", false, "4c3dfebb-79ba-4c3c-b0d3-03231c2b2879", false, "Leah_Windler34" },
                    { "2a1f2574-6eae-4e74-b7ed-ae2ee445a001", 0, "6c9e7880-82d7-4fac-b2ba-0ba3a2faa60f", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAELi2mPOfbno5Sb9VD2h/LW2TdRJkCHoTvhjK0Yw1A765TyilGhEpI6qdY8U57nYdrg==", null, false, "6f211fe0-530a-4e50-a799-5c0c5234b1fd", false, "borrower@library.net" },
                    { "2d13adae-9cd5-41b9-8e7b-8039fb436aea", 0, "1174a25b-acd9-458f-9418-449ebea73958", "guy98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGEA0SBJnLDzt2GroGC2JspNXx29ymqty9VCk7QHNaW21Pd4YpvUdL/NS6m+enGUhA==", "491.260.4628 x25164", false, "d2d558b9-7521-4836-9e7b-58d6bac0cef9", false, "Guy98" },
                    { "3a7ae8c8-a666-47cd-bc82-c6ad1f445018", 0, "335296d9-81a7-4048-a67c-96566b6f9333", "daisy25@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGewxH8qXAmwOf6ZK+iaQn05cXg7hf9BGG4VLMleAYwtAWR1+pU/Ire9tkvy+1fE3A==", "(826) 741-9472", false, "7d48ec9b-1e09-4d21-832f-dcc9cf205934", false, "Daisy25" },
                    { "5abd030a-9a2e-436e-b9aa-7096804d7f9c", 0, "c64a4f83-d7de-49c1-9d35-2bc7918379b0", "marguerite69@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEVdkoews7yjZhzWDDVhZpqZd9BBIwHUkHAqLcRwMQyXEzLPgWT04qg0nEREbWwx3w==", "(314) 543-0900", false, "3e81dc16-7966-4740-965c-d8dc83ba23dc", false, "Marguerite69" },
                    { "5d4daaa1-02d7-4570-b9bb-32571136941e", 0, "068bfe4c-631e-4898-b47f-42f765ad3fb7", "jose50@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGsWtorXBfp0Gte0Lh9kQ+BO0bwXcfYuW8VHhlEPnjYs6PN+jtHQL/upKvM/gLY7fw==", "813-402-6150 x854", false, "289275b8-5cce-45e7-b965-93a4e96be685", false, "Jose50" },
                    { "5f303b56-994f-4aa8-892d-420e6343bcff", 0, "50f04c93-fbab-4d10-8c23-204baa755a78", "pamela42@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPnITyxGfHgoeaMcvPLnULeJbLXvul8XUl2EdrYnV64dCl29XFoRajgCb1OWzQfqDw==", "772.534.8154 x86587", false, "fe4e9a6f-6660-4c0b-aaee-555a95dc621f", false, "Pamela42" },
                    { "62b23b3b-9931-4543-af7c-32e18b47539d", 0, "e3fc749c-6216-4b8c-ab98-c15d7be7c21a", "judy_pfeffer10@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFOC1dX6Py5med4ClFQO88jDlS/BA4IjXZz3fn2E+BgfkW1S6FiXt4WnFU6TGnxWKQ==", "890-911-2590 x802", false, "d6256ad8-db5c-4c43-9518-c18b3044a6d7", false, "Judy_Pfeffer10" },
                    { "63e8b31d-3e97-4898-a365-7179bbdae6e0", 0, "8c7dce75-6960-4add-95a6-ff31b8c087a3", "sally_conroy@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBJ8x/b25W17KBYziAAUcdyxz2gNo81EjtxqEX0haCkc9SyDZaFuVrzZGg97ZX/lzA==", "1-748-935-2588", false, "710ea91b-bea5-4b51-8b9c-019b896ea768", false, "Sally_Conroy" },
                    { "75e584fc-58b0-4082-82ed-e05f0cfbfc5b", 0, "b7955fc5-d0e6-432c-b2c0-59e8da47ff99", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEENsF9QsapTdXSuDCyVcMshI9i62zg/7GXIAjO7LyTXdz6LWFbAde9cqmmWT2mNB8Q==", null, false, "8fe38cc3-b1da-46d8-af86-8a3782be3e21", false, "librarian@library.net" },
                    { "9628aacd-0e09-4431-bbf8-788930459cc7", 0, "345a3a6b-a123-4fc8-9d47-7bffd2e261e3", "ray_wisoky@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDnVFX8p1Rro12t7gNKB0rooPhOPcQV9JajWMlOM2Dku1Zr202RXZaIHdmooFifyAA==", "912-840-3632", false, "a5bef532-13cd-400f-97b3-6a9715acfff5", false, "Ray_Wisoky" },
                    { "96f678dc-b5fb-4f04-9760-b4445f5f7fcc", 0, "81abaa21-e8f9-40d4-a1a8-1187da2ac1ba", "eula.oconner62@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFaiFgt1HnQF9yH0RTzvJRt9izyL+FwQKo96R3vk0mtfvk4xAiDCceLW/HzWSlQQnw==", "843-598-1308 x67577", false, "d8ee111a-614a-4cae-9c54-c70cd5dd3621", false, "Eula.OConner62" },
                    { "9cce5578-b6f1-4508-9f2b-8b0dfabb2441", 0, "2a222cc1-4583-45c9-86fe-ce52a411f2ba", "sammy.dicki@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENaY+/r3iZpbumT5FJ/B27k49lSia6kRzbQ1aD9iidepjfUPbTOUEyBIKXAqTiBjKw==", "497.351.4409 x4051", false, "44efc88b-86f0-44a0-a32f-cfaa8a74f5be", false, "Sammy.Dicki" },
                    { "a0558f9c-7d49-4f94-a60c-c961a67bac95", 0, "b0de0467-94a6-47a7-ae3f-8213779d8713", "yvette.adams@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELav3ifgkcuN2iJOAv7kq+QB+KpWkIY44pSCn0DNIiRev6xgnPeVoEbChbVmXZzSLw==", "1-801-381-7913 x0596", false, "ac8bce37-0cd0-43b1-adee-15c09959cb97", false, "Yvette.Adams" },
                    { "b095b5f0-3971-40c0-8df0-09970e5b6aea", 0, "d272ac93-abce-41e5-b21c-96e8e7340598", "jennie_gorczany37@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEARl05k7NJuGgoxjW6I/atCtoPLCSIGQzZEupynJBLm6as9mMquCiTJM3XXcia+e7A==", "(365) 435-6055 x7134", false, "baa66eb3-c55b-4b50-8477-6a46ca7bb905", false, "Jennie_Gorczany37" },
                    { "b8674337-ea1b-4888-99ef-57651b553367", 0, "fb1b2da7-f9d5-4c28-81ce-fc3dab6d39cb", "ron.bahringer24@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAkFLnBcUXz+a6cTv09mPtnosIyicmWtk2d/M7cEvYDGaJeHAC8v9BFNG3kjutF3Cw==", "(987) 542-7030 x4587", false, "a1033b07-cea5-4733-bec3-1468904ef5e5", false, "Ron.Bahringer24" },
                    { "c7e56052-d51b-466d-a2d0-c67b8ae73d32", 0, "bb253cbc-d723-4ba2-84aa-d0eeb2a55abe", "clara.zemlak@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDAelQ1Tcega13xmgeUSTfdnFf8ZOHtuMg8Hk3Z6vCw9B6Y/taDKqs560tsi77PV6Q==", "972.763.6599", false, "5d97c518-dd9f-41c7-942d-023b3a993b93", false, "Clara.Zemlak" },
                    { "e0db06e1-4165-41d3-a078-aff2343b48a1", 0, "c2de2629-f2db-4429-825c-2d9364efecf5", "loretta_ernser6@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEE3T7qnm/9kWgUAKVcuvnc2wqJVPR42PRZ/nM2joumKOAIFBLt1T3mqVVcNv7U7YJA==", "531.585.3552", false, "39e98eb9-dcf5-490d-b367-fe1bc4f75ad7", false, "Loretta_Ernser6" },
                    { "e5d014d7-40de-48e7-91f8-3e817e1bc845", 0, "24787854-4562-4a36-bb5f-bf15e8be7f53", "clinton13@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPLYgCZGt3bAoFumCJc64xBTUK0OykV+6HlOKX9ygNkXrdpd1ujKgtA/mt8WRTrpew==", "(691) 443-6316", false, "5d35b841-075b-4381-b9d3-b73dd4395291", false, "Clinton13" },
                    { "f0b78923-ce49-49e8-af55-6a3b567b7329", 0, "be48a1e7-c215-4344-8ab6-c086e015ae35", "samuel_bauch@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJqBdrFq1bordBrf6Aeyn0L9+XPnQPVfKdy3Kz3lCJjc7engeG0ZwykNduucNJOWgA==", "1-405-658-4814 x10007", false, "ebd83ddd-9625-4161-9aa3-b0976c7568bf", false, "Samuel_Bauch" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Angie", "Wilderman", "Autem voluptate dolorem cumque ea ut tempora explicabo est. Dolor vel consectetur dolorem dolorem nostrum eius ex hic dicta. Laudantium quam est commodi ipsa placeat quae enim qui. Minima itaque alias eius voluptatem similique et nam quia dolor. Accusamus vitae sed vel id. Reprehenderit ad aliquam.", "Face to face motivating initiative" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jon", "Jacobson", "Nobis enim et praesentium corporis rerum delectus sint veritatis. Dolor nulla in. Officia veritatis a accusantium a aliquam soluta temporibus ullam. Adipisci eius aperiam et voluptatem sed. Eveniet perspiciatis cumque dicta et. Esse maiores provident quia aperiam.", "Reverse-engineered scalable product", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kari", "Koch", "Molestiae qui non laudantium doloribus magni. Iste ducimus libero temporibus repellendus non ipsam in quibusdam. Ullam nostrum sed neque vel. Rerum quibusdam reiciendis ipsa enim et.", "Streamlined clear-thinking time-frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tomas", "Rohan", "Eius nihil dolorum voluptatum qui ut non et excepturi. Corrupti beatae voluptatibus numquam beatae unde voluptatibus rerum sed iste. Quis quis praesentium sed et quidem quod quo quibusdam.", "Assimilated multimedia forecast", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ed", "Cassin", "Qui aspernatur atque aut. Earum iure error odio doloribus. Accusamus et esse non consequuntur est laudantium. Dolor voluptas in qui est ut adipisci deserunt veniam deserunt. Consequuntur quo in aut sint. Quidem iste quisquam aut tempore ab debitis.", "Organized fresh-thinking middleware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dora", "Walker", "Aut accusamus aut. In nemo ipsam hic consequatur. Quasi pariatur magnam. Et atque qui nesciunt est.", "Profit-focused mission-critical workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Felicia", "Cole", "Incidunt in sit a eum sed laudantium enim. Dolores est suscipit id fugiat sint fugiat molestiae. Voluptatem aut dolore maxime corrupti. Eum nostrum ut non eum cum sit eum. Inventore aut ipsa beatae dolorem blanditiis dolorum.", "Monitored disintermediate array", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ira", "Heller", "Itaque enim expedita voluptatibus. Enim molestiae aut omnis magnam commodi. Omnis omnis totam ipsa id. Quia eveniet consectetur. Assumenda quo nihil necessitatibus maxime qui quod harum excepturi.", "Open-architected multi-state middleware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lorraine", "Hoppe", "Quibusdam modi at veritatis aut sapiente recusandae. Inventore at et. Neque omnis id autem. Quo est aut exercitationem molestiae voluptas. Doloremque numquam laudantium est eum soluta et.", "Pre-emptive encompassing data-warehouse" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Shelly", "Thompson", "Voluptatibus possimus blanditiis vero. Et possimus qui laborum alias quaerat. Esse incidunt labore quia reiciendis vel harum itaque.", "User-friendly multimedia groupware" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1f9f862-d433-4f4f-8e16-f496e529e2b9", "2a1f2574-6eae-4e74-b7ed-ae2ee445a001" },
                    { "654313e4-aa45-450a-939e-c242549715cc", "75e584fc-58b0-4082-82ed-e05f0cfbfc5b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b1f9f862-d433-4f4f-8e16-f496e529e2b9", "2a1f2574-6eae-4e74-b7ed-ae2ee445a001" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "654313e4-aa45-450a-939e-c242549715cc", "75e584fc-58b0-4082-82ed-e05f0cfbfc5b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "056f53ea-e872-405b-8ff5-bce8d30f6f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d13adae-9cd5-41b9-8e7b-8039fb436aea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a7ae8c8-a666-47cd-bc82-c6ad1f445018");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5abd030a-9a2e-436e-b9aa-7096804d7f9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d4daaa1-02d7-4570-b9bb-32571136941e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f303b56-994f-4aa8-892d-420e6343bcff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "62b23b3b-9931-4543-af7c-32e18b47539d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63e8b31d-3e97-4898-a365-7179bbdae6e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9628aacd-0e09-4431-bbf8-788930459cc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96f678dc-b5fb-4f04-9760-b4445f5f7fcc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9cce5578-b6f1-4508-9f2b-8b0dfabb2441");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0558f9c-7d49-4f94-a60c-c961a67bac95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b095b5f0-3971-40c0-8df0-09970e5b6aea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8674337-ea1b-4888-99ef-57651b553367");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7e56052-d51b-466d-a2d0-c67b8ae73d32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0db06e1-4165-41d3-a078-aff2343b48a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5d014d7-40de-48e7-91f8-3e817e1bc845");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0b78923-ce49-49e8-af55-6a3b567b7329");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "654313e4-aa45-450a-939e-c242549715cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1f9f862-d433-4f4f-8e16-f496e529e2b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a1f2574-6eae-4e74-b7ed-ae2ee445a001");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75e584fc-58b0-4082-82ed-e05f0cfbfc5b");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Janis", "Kertzmann", "Facilis voluptas ad perferendis explicabo consequatur dolores delectus voluptatem. A vel libero ab non. Qui eveniet necessitatibus facilis repellat illum molestias. Id rerum exercitationem fugit corrupti. Iusto beatae ab ut. Corrupti voluptate aperiam temporibus in omnis qui quis dolorem.", "Diverse secondary database", true });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rafael", "Schroeder", "Ut et voluptatem accusantium. Ut aspernatur ipsum. Quia et consequuntur similique aut accusantium reprehenderit quasi. Velit atque nemo ex nihil tempore accusamus aut. Cupiditate quae impedit nemo earum vel doloribus ipsa. Officia esse non aliquam similique incidunt.", "Phased national system engine", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Joann", "Torp", "Ad quidem et aperiam excepturi nesciunt exercitationem. Incidunt illum dolores ut sed animi dolores consequuntur sed explicabo. Sit magnam aspernatur fugit quia. Eum consequatur quas. Veniam perferendis assumenda molestias qui omnis. Aut aut sit.", "Right-sized attitude-oriented process improvement" });

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

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 11, "Rufus", "O'Conner", "Distinctio alias et reiciendis eum officia. Dicta ea nesciunt dolor dolores eos voluptatem. Ducimus nulla impedit recusandae animi et omnis dolores magni.", "Compatible multimedia flexibility", true },
                    { 12, "Randy", "Muller", "Vero dolore assumenda minima voluptatem ut hic officiis similique natus. Molestiae facilis voluptatem. Excepturi quos quod voluptas unde.", "Advanced multi-tasking strategy", false },
                    { 13, "Mona", "Mosciski", "Praesentium dolorem enim sunt. Dolores eaque quisquam architecto est voluptatem reiciendis nostrum. Inventore impedit ab voluptatem numquam omnis.", "Progressive 24 hour frame", false },
                    { 14, "Joyce", "Tromp", "Veritatis libero ut enim ut. Numquam totam aut earum est. Dolor optio consequuntur illum alias ex ut cumque. Architecto perferendis voluptates molestiae reprehenderit perferendis dolorum esse rerum. Ea voluptatem doloremque voluptatum.", "Monitored well-modulated database", true },
                    { 15, "Edna", "Wisoky", "Exercitationem expedita reprehenderit nisi perspiciatis et molestias ut ad. Aut animi aspernatur aspernatur. Quisquam delectus aut saepe natus sit corrupti sed facere. Quis eum tempora non enim et quam.", "Universal tertiary throughput", true },
                    { 16, "Rachael", "Kemmer", "Quia libero repellendus dolorum aut qui deserunt. Est ex voluptatem repudiandae qui et dolore. Eligendi eos sit. Voluptatem eligendi vitae. A voluptate delectus sit.", "User-centric client-server task-force", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "208788c4-b855-4a52-9b47-074e473e811b", "020f3518-f66a-4e6b-93bb-71871b2e8624" },
                    { "1c704a00-2d23-4d68-8c00-10ed0bd45b3d", "47c020aa-0d7d-4f32-b22e-67c274cc428d" }
                });
        }
    }
}
