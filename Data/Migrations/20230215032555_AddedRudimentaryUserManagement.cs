using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRudimentaryUserManagement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05a5712c-dfe9-4ecc-b4af-502057a631fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e09d7b5-b8e8-4912-91c0-32e4a88fae92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cdad823-99df-4b0b-9d75-e7d9aaea1333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d3d1e9d-e686-4976-af49-82bf231cbceb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43f1d1a9-d9e3-44b8-ade1-2302270c34c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b9991c4-3a88-4515-a67a-ec46e83cd29d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e1edd4d-b0f8-485f-a54c-803f32519035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87c0785b-62e7-4638-ac45-671ea2a5f8d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f8c2d71-1c7d-4876-8dde-d4492aca6aab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999eed49-bf0b-4136-b950-968a1fa71ddc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b43822c5-872f-477f-bb3c-69f4b51569b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db593821-8e01-498c-892e-016e2bb4cfde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5836e75-8e2c-4d44-ba65-e5dff45cabe8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea1b45ae-acc9-4569-bab5-97860e4e5dbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef8c9b7f-cb8c-4591-b53d-40d817054eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f135d071-9671-4884-bfdc-dddc231706ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f351d533-5623-4c28-aa46-5b21f667d11e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa159046-c815-4f08-b8bb-8d61bb753d7f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "34687220-75e2-4c7a-a611-00611a722734", 0, "61de51b2-6b68-451b-bb0a-fd32143d0112", "bruce_wehner@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECDHnrz8aQV9q68szQ9HT74PCnOQjMKKoo75+98BeuD/PmDfl9+OOaUKbgone4Fqjw==", "1-725-790-9771 x0068", false, "c777c902-6a33-4990-8c94-2465487bd19a", false, "Bruce_Wehner" },
                    { "3ceaf5aa-79dc-4e9f-8db8-c279aa621f3b", 0, "848768d8-8391-44bd-8c8b-6b918ef41175", "geraldine50@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIRh0KMYJR1sM2aI30hIUf7lvqXcyw49P1DqmKKT7MRX15U90grCb90fJLckMZpiCQ==", "1-216-886-7400", false, "d2ff7c8f-e9ed-43b1-abc5-ad46bec387c9", false, "Geraldine50" },
                    { "3d1f7a9c-3eb6-40cb-890d-17cadadb5d22", 0, "c19e848b-c4e6-4aac-9ddf-c06c051b57c3", "andrea27@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDyTHhExAo0t88f3ZiFJTV98zDyipQch+UOgqj04Brivkla+z6fwOMpbGCNw2dOqRQ==", "1-322-317-9917", false, "3ef4b51d-ffbd-47e6-bd35-43e8abf5222a", false, "Andrea27" },
                    { "4d21c93e-dfb6-45b1-8b69-56fd85562541", 0, "2a06963f-069f-4158-a2c3-24fe75a16261", "billie.okeefe46@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDmEmw+KMYjqoe4Js35tce/Vfd1eA1ZdOjOVokuUr3ATCXfgWoenM3UnYbHstmwt3w==", "1-925-382-8930", false, "b038a224-69dc-4e75-b671-bd801a34cd85", false, "Billie.OKeefe46" },
                    { "507656bd-cdca-4815-a323-9c13952750a3", 0, "0f610663-4462-4aa1-b6ab-1a109db38c0f", "isaac43@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDdRb/ZJ390D6mTdRZBcizMFYkqpPaVKAWzC7NbKjj0DCh5xnhcSij8qu+XnQtC8KQ==", "555-702-7260", false, "03de44d3-7350-4edb-86cd-4aa07caa66e8", false, "Isaac43" },
                    { "79ceb9f2-ca5c-447e-b8be-43b02bbd040b", 0, "d8395e52-bcfb-4646-9d05-604969a18efb", "jennifer_funk47@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIGTWaEYb7SzWeNJNqADM9KOkMVUI8rviV3qoftTaHhF6PQD8vxJdrLUo7AetEuUsw==", "516-300-7732 x62614", false, "5e977d44-eceb-4594-9c25-557e0b31f632", false, "Jennifer_Funk47" },
                    { "b896daf6-1c49-409c-8bb2-ebcd7d96f513", 0, "ca83a3b5-f24b-463b-b863-a24999470990", "silvia_waelchi2@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENMbQn2AeUKf7ljagJuzFg4uMCIOrH+CpkmADaSo/Gi1uK3adwbjTd51/7i6Nntbtg==", "(853) 331-8558 x8864", false, "c5f62123-d02b-448e-ab5a-3d471fe5e679", false, "Silvia_Waelchi2" },
                    { "c0263d13-93bd-449f-b42c-e3e60b2f405c", 0, "46e39f4a-0286-4a8c-b6ab-c593d1c8b419", "wanda_lemke11@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHX20lIWe4f0gx0DRA9MNffQ5dBDzuv1gc8j2WO9lDvYjIXwI1G6abMqIHNsWlEwLg==", "533-937-4418 x485", false, "e3cb397e-c574-4765-a57b-7bbcd50ebd57", false, "Wanda_Lemke11" },
                    { "c5f0b141-afc3-458b-85c5-668ac70d936b", 0, "ae2facc1-62af-40f4-8b63-3e6b823b3928", "ada_towne60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEND/nFGB4P4crD/Y2ZPwEfLvCEXCptfWOAhx2ML1fY6HPXPyBP3x2h7q4rLAA+4rAA==", "(712) 999-2883 x952", false, "fcabb36f-84b8-465d-9b7c-3fefe3c02381", false, "Ada_Towne60" },
                    { "d7e2572c-4a84-4996-9cf7-c8e819406f88", 0, "a28fc60c-4743-44d5-a3a7-dc83442e4f9e", "lee.runte95@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEC7RZqTETcjmLmu4Gw+yCQU0xEgQH7eIj1t8LwUE2nen95IndEFOiB1C3Wx37QzGDA==", "295.960.5513", false, "4cf2f03f-2052-4dee-8f91-3b0740fd8ee7", false, "Lee.Runte95" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Verna", "Berge", "Omnis sit ratione voluptas maiores non. Natus minima aliquid blanditiis pariatur cum sequi delectus molestiae. Ea assumenda aperiam est voluptatem dolore consequuntur. Quidem alias voluptas rerum eum nam incidunt. Ipsa tempora amet impedit. Possimus commodi quidem et et iste porro.", "Customer-focused upward-trending pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Glenn", "Price", "Nam quo rem rem distinctio unde voluptatem omnis. Labore animi aut enim nam libero ullam amet. Ipsam omnis vel.", "Multi-lateral real-time pricing structure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Suzanne", "Rosenbaum", "Accusantium et saepe sapiente minus ut. Expedita aut rerum voluptatibus cum accusamus. Deleniti consequatur doloribus voluptas. Velit debitis inventore labore eos accusantium. Esse expedita a labore aperiam a delectus.", "Cross-group actuating throughput" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Beverly", "Moen", "Ipsam quos dolor vel consequatur temporibus. Unde dolor voluptatem recusandae vitae repudiandae reiciendis inventore recusandae quae. Enim inventore mollitia esse expedita. At laboriosam libero suscipit.", "Versatile asynchronous leverage", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristina", "Hilll", "Dolores animi quam ad odio vero facere. Fugit odio animi ut vero corporis ullam consequatur. Maiores magnam rem enim nisi. Tempora ea cum rerum eos dolorem aut eaque.", "Digitized client-driven productivity", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Eunice", "Haag", "Ex quia inventore placeat. Sed repellat ipsum inventore. Voluptatibus repellat autem.", "Function-based upward-trending support" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Keith", "Bode", "Omnis nisi dolores quod at voluptatem. Quia praesentium quasi eius ad. Omnis illum qui est quidem similique eum delectus. Harum repellendus eius aspernatur nobis eius recusandae vitae. Sit placeat aperiam fugiat unde libero.", "Right-sized web-enabled forecast" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ollie", "Gusikowski", "Perspiciatis magni dolores est expedita perferendis cupiditate ut. Dolorem nesciunt laudantium molestiae aliquam exercitationem dolorum nisi. Numquam earum ipsa voluptatum corporis soluta qui ut quia ea. Sit ut quo in quia iure perferendis dolorem quam neque.", "Synergized high-level secured line" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ricky", "Okuneva", "Debitis qui ut. Et voluptas libero aperiam similique odio. Aspernatur voluptatum tempora voluptates. Et assumenda molestias quia sit voluptas.", "Down-sized upward-trending application", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Megan", "Brekke", "Dolor vel veniam facilis laborum voluptatibus. Nesciunt dolorum natus illo adipisci consectetur error debitis nihil. Ut sit consequatur nisi et ea corporis quas omnis. Sunt veniam quaerat repudiandae veritatis. Qui qui inventore vel provident quis nesciunt nam. Saepe quidem error non.", "User-friendly discrete encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Erick", "Bogisich", "Id commodi consequatur maxime error quia sapiente. Rem velit non quo quidem eum aut ut. Id voluptatem rerum eveniet. Enim nesciunt nesciunt autem. Molestiae pariatur non. Odio consequatur dolores et laborum culpa.", "Synergistic modular extranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Woodrow", "Haley", "Itaque ut rerum excepturi. Modi id numquam omnis. Numquam voluptate sint quam ad est aut.", "Centralized local architecture", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Johnnie", "Ritchie", "Autem est consequatur eveniet dicta ad molestiae quisquam error quos. Est non est aspernatur voluptatem reiciendis nesciunt. Earum molestiae reiciendis consequatur.", "Optional web-enabled matrices", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Myron", "Paucek", "Natus voluptatem delectus nihil eligendi harum placeat. Ut eos itaque laborum voluptatem non. Sequi qui dolor ut sint. Possimus ea maiores cumque odio deserunt inventore occaecati adipisci.", "Mandatory motivating conglomeration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jill", "Paucek", "Molestias ut est et molestias est aspernatur. Et voluptas deserunt voluptas et velit nisi. Nulla non iure commodi eos voluptas aut. Sunt autem numquam vel est est ullam sequi qui. Quia ratione et voluptatem consectetur molestias laudantium.", "Organic demand-driven ability", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Teri", "Smitham", "Dignissimos tempora labore explicabo ea. Alias sit molestias. Blanditiis incidunt ea recusandae minima. Est ut qui quisquam nihil iusto fugiat. Iusto maiores est deserunt aliquam.", "Focused regional groupware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jerome", "Bradtke", "Reiciendis rem ipsa molestias esse. Ab aliquam ipsam possimus quo quia occaecati repudiandae beatae. Et architecto vitae numquam perspiciatis id quia et porro vel.", "Re-engineered needs-based Graphical User Interface", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Antonio", "Bergstrom", "Ab nemo ut nihil illum sint dicta. Quae ut dolore odit maxime ea. Harum nostrum aut tempora tempore quam porro quas nesciunt. Accusamus id laboriosam quaerat hic quia esse consequatur. Et voluptatem in vel ut iure dolores. Accusantium doloribus et.", "Ergonomic cohesive toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Owen", "West", "Ducimus harum nulla vel voluptatibus. Provident deleniti ipsa laudantium eos est fugiat dicta dolores atque. Minus facere reiciendis ipsum enim maiores velit et. Et nesciunt qui aliquam voluptatem dicta exercitationem esse qui. Voluptas perspiciatis voluptas. Eveniet doloribus aperiam fugiat voluptas architecto.", "Re-engineered national website", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Keith", "Bechtelar", "Voluptatem et molestiae est corporis perspiciatis molestiae. Adipisci vero magni exercitationem magni consequatur. Ab autem ipsum inventore nam facere voluptas laboriosam quisquam.", "Adaptive discrete neural-net" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Connie", "Jacobs", "Hic voluptas nam aut placeat. Dolores sint assumenda ipsa velit quos. Expedita debitis aut consequatur autem. Occaecati facilis voluptas vero. Autem repellat qui delectus saepe ut exercitationem.", "Function-based multimedia migration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristie", "King", "Ratione laudantium tenetur ad in. Ut laborum inventore repudiandae maxime a sequi neque et vel. Deleniti aut officia praesentium debitis sint. Dolores accusamus velit perferendis in voluptatum recusandae omnis aut. Quia qui necessitatibus ut et reprehenderit voluptatem id accusantium quis.", "Devolved fresh-thinking paradigm", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Vera", "Mertz", "Voluptatibus eum distinctio incidunt nemo blanditiis. In optio sit sint sunt est accusantium amet id. Amet odio consectetur molestiae repellat tenetur ea sed. Ipsa esse magnam eum aut. Quae itaque eos fuga consequatur sequi eos et occaecati.", "Polarised local info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Laurie", "Johnson", "Reprehenderit fugiat alias dolor nam sit. Quo eveniet est. Magni voluptatum enim harum voluptatem veritatis in omnis assumenda aut. Totam voluptas sint iste aut. Voluptatum et voluptatum.", "Centralized coherent artificial intelligence", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 25, "Kelley", "Baumbach", "Beatae adipisci reiciendis. Doloribus corporis ut nihil facilis. Quis ut ab facere sed perferendis aut reprehenderit maxime sed. Omnis debitis animi commodi. Suscipit iure nihil aut esse molestias incidunt possimus.", "Cross-platform mission-critical hardware", true },
                    { 26, "Marian", "Abernathy", "Vitae aperiam quas molestiae sint aspernatur nam aliquam porro fuga. Ut sit vitae repellendus voluptates fugiat sit illo distinctio fuga. Quia fuga ab reprehenderit. Ratione quidem deserunt mollitia excepturi voluptates. Vel praesentium cum sit sit sed facere. Magni dolorem voluptate ducimus sit labore consequuntur quo.", "Monitored exuding budgetary management", false },
                    { 27, "Stanley", "Schamberger", "Ea sit voluptas veritatis dolor unde sequi. Ipsa adipisci qui dolorum dolor rem. Omnis soluta laudantium ab voluptatem alias maxime excepturi. Delectus vero cum.", "Phased multi-tasking workforce", true },
                    { 28, "Alexis", "Parisian", "Iusto ea eum voluptatibus beatae qui. Et totam fugiat. Maiores quas eos autem et perferendis iure distinctio doloribus blanditiis. Ut esse eius adipisci omnis et temporibus repellat asperiores. Consequatur vitae sunt cum molestiae rerum ut rerum. Eius ea repudiandae magni quos qui expedita.", "Up-sized methodical local area network", true },
                    { 29, "Johanna", "Reinger", "Quia et reprehenderit modi sit quia beatae. Repellendus facere dolor eius voluptas incidunt. Dolorum iusto hic.", "Front-line empowering open system", true },
                    { 30, "Glenn", "Morar", "Architecto aut sed quaerat et aut quos veritatis. Pariatur distinctio non ut laboriosam consequuntur cupiditate dolores dolorum. Nesciunt sint nostrum laudantium aut itaque voluptatem voluptas non ipsa.", "Managed needs-based archive", false },
                    { 31, "Bonnie", "Rutherford", "Sunt adipisci nisi iure totam vel sunt. Ipsam doloribus voluptatem minima ut iste. Autem neque at quisquam est recusandae eos qui magni. Recusandae officia a in sunt et sit quos omnis. Ut et itaque. Beatae eum laborum excepturi.", "Customer-focused zero tolerance paradigm", false },
                    { 32, "Sabrina", "Zulauf", "A inventore et aut et labore. Culpa accusantium voluptas harum nisi voluptatem quasi placeat. Impedit ea saepe beatae. Corporis temporibus enim qui fuga necessitatibus consequatur saepe qui. Nihil odio est provident dolor voluptate qui dolore. Eos quibusdam fugit ipsum.", "Versatile 5th generation success", false },
                    { 33, "Grady", "Nienow", "Porro qui iusto odit odit natus omnis debitis est. Libero natus numquam beatae esse eaque alias. Doloremque at tempora dignissimos sit perspiciatis possimus culpa omnis. Autem dolores quam quidem et. Qui sit tempora itaque reprehenderit sint. Sed id cupiditate rerum veritatis perspiciatis optio eius repudiandae voluptatem.", "Innovative well-modulated synergy", true },
                    { 34, "Winifred", "Paucek", "Rem error et. Qui et est fugit optio. Et a maxime vitae accusamus quas ut. Rem qui porro porro optio numquam et nostrum quam voluptate. Sed fugit deleniti quis nulla sapiente corrupti. Aut facere sed eos laborum cum.", "Inverse client-driven data-warehouse", true },
                    { 35, "Donald", "Hagenes", "Hic exercitationem incidunt velit dolores iure quisquam enim explicabo. Dolore enim veniam alias laborum aliquid esse. Earum consectetur rem et cumque cupiditate dolores recusandae. Non voluptatem perspiciatis. Aliquid quasi vel ab aut. Hic aut a nemo qui voluptatem veritatis quasi.", "Switchable radical Graphical User Interface", true },
                    { 36, "Laurence", "Leffler", "Sed eligendi sint nesciunt sint ipsum ut commodi aliquid consectetur. Non vel est voluptatem non necessitatibus dignissimos. Dolorum velit veritatis autem molestias.", "Multi-tiered bi-directional policy", true },
                    { 37, "Beth", "Borer", "Sed nemo aperiam necessitatibus ipsa. Odit cumque voluptas provident. Neque quas ipsum repellat eligendi in facilis aut quos.", "Ameliorated grid-enabled adapter", true },
                    { 38, "Emanuel", "Langworth", "Soluta est totam sequi quasi hic vel et omnis. Porro sequi ad qui. Et error quisquam dolorum ea quod doloribus laudantium quidem nisi.", "Distributed fresh-thinking structure", false },
                    { 39, "Beatrice", "Schinner", "Et suscipit sunt quo suscipit. Esse illo voluptatem autem laudantium non earum consectetur et incidunt. Vel officiis animi dolorem qui voluptatem in saepe aut. Pariatur dignissimos odit tempore.", "Vision-oriented incremental concept", true },
                    { 40, "Carrie", "Johnston", "Reprehenderit eos eos non dicta sit dolores facilis vitae. Accusamus accusantium cumque beatae libero et officia molestiae. Rerum eveniet rerum dolore quae consequatur quisquam expedita. Veniam sit quia repellendus. Sunt asperiores autem eius qui. Corrupti molestiae voluptatibus aperiam vero nesciunt.", "Universal responsive matrices", true },
                    { 41, "Terry", "Gibson", "Ut voluptatem id recusandae aut. Quia esse tempora esse non est sed. Cumque magnam omnis corporis labore. Illum voluptatem non rem sint totam dolores aliquid velit.", "Enterprise-wide 4th generation migration", false },
                    { 42, "Carlton", "White", "Et eum fuga quia voluptatem et. Qui eveniet voluptas animi rerum culpa natus ut eum. Et debitis odio aut amet culpa cum enim ipsam. Eveniet dolorem distinctio officiis nam repellendus. Adipisci cum molestiae enim quos quasi. Ea libero atque.", "Multi-layered holistic success", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34687220-75e2-4c7a-a611-00611a722734");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ceaf5aa-79dc-4e9f-8db8-c279aa621f3b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d1f7a9c-3eb6-40cb-890d-17cadadb5d22");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d21c93e-dfb6-45b1-8b69-56fd85562541");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "507656bd-cdca-4815-a323-9c13952750a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79ceb9f2-ca5c-447e-b8be-43b02bbd040b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b896daf6-1c49-409c-8bb2-ebcd7d96f513");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0263d13-93bd-449f-b42c-e3e60b2f405c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5f0b141-afc3-458b-85c5-668ac70d936b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7e2572c-4a84-4996-9cf7-c8e819406f88");

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35);

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05a5712c-dfe9-4ecc-b4af-502057a631fd", 0, "c22705c9-2685-4881-895a-65a15d34f0bc", "stuart.lemke@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ5Hz/yU2Ni5ekegupm9NxSJk6zGZSAR8/Q5vvmyBbnucTicgMatAWl+SczPDC5MJQ==", "447-645-1194 x05339", false, "d45ccf5c-1644-445b-a520-64a4b15ffa1d", false, "Stuart.Lemke" },
                    { "1e09d7b5-b8e8-4912-91c0-32e4a88fae92", 0, "de71f105-4500-4e63-b5c9-e1df46ebb344", "kerry75@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBbue6Z3kpW9ockKBnYslOPBHH6ZEXwB9saZX0XLoN9dhknAE0HyyQfDYZl/vR1yQA==", "1-521-325-6521", false, "7633a351-5642-46e0-ae6c-c5ba628e4c18", false, "Kerry75" },
                    { "2cdad823-99df-4b0b-9d75-e7d9aaea1333", 0, "9240e7d2-fffc-45e4-9ebb-63261f1bb59f", "dewey.schultz4@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEINUPLi3HyqzM2O0KfRQ3aLihA6eZQMF5RxeXIrCxOJt2+hxkxDjCGk8gsOubzN1jQ==", "(833) 255-9985 x089", false, "38a0c4a2-7494-4d4b-87db-060ee15c579b", false, "Dewey.Schultz4" },
                    { "2d3d1e9d-e686-4976-af49-82bf231cbceb", 0, "4213a958-c439-42c2-8361-610c3650fccc", "delia_johnston39@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENCnGcAwXt9iEw2NaO7shmteKpyZ3DXokbatgtXoQeBFf339kcIpIsdyGaL6/7zNCA==", "(668) 610-3927 x67486", false, "f52e9889-8555-4574-bad6-7e1571da546d", false, "Delia_Johnston39" },
                    { "43f1d1a9-d9e3-44b8-ade1-2302270c34c5", 0, "04170687-5f9d-4ab5-8507-cec3c551535b", "todd.rippin@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELzjJd08NRXQ2xq4Q5a6o/2ERK05Ya/5cvAFmJ8aYHjhemslN2FKvtAexW4ajWUrFQ==", "1-527-439-2583", false, "a9dcc0cf-caac-4d7b-8961-9ebe454ad2c6", false, "Todd.Rippin" },
                    { "7b9991c4-3a88-4515-a67a-ec46e83cd29d", 0, "de2d8c24-7c83-43a4-bf3f-793b83911491", "jonathan_powlowski79@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHpni19NeLP6Y+AItykfpiH/dh+L/F+cn+EKMNHlmQHAGaoF5R4Wgt21gIxrcuifDA==", "1-517-575-3375 x432", false, "189196a9-884a-4405-90f0-76241455ac06", false, "Jonathan_Powlowski79" },
                    { "7e1edd4d-b0f8-485f-a54c-803f32519035", 0, "a2b65d57-dfc4-41b6-a1fb-b438f8da2301", "kristine18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELfU9lOS8XehxRQeD7w0RCc8qQxL9qcRdp6CemPnab8vxORN0jMsASdrACOIoXXSFw==", "1-496-302-9581 x60082", false, "288d41be-9860-499c-97cb-c0d57284abd9", false, "Kristine18" },
                    { "87c0785b-62e7-4638-ac45-671ea2a5f8d0", 0, "f000a490-a935-422c-9239-985eecdc648a", "stewart.herman@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJEeSK1fLUzOh9eXQhsgB1vzHCUvuRSTRDgbgRiQVh5eK1AXsu1B+b3AlEaKSVZ5Vg==", "587-835-8571", false, "5f36ebd8-a37e-4256-891b-c51a3f95cc54", false, "Stewart.Herman" },
                    { "8f8c2d71-1c7d-4876-8dde-d4492aca6aab", 0, "79156f5b-62c7-41aa-bb64-8bf924e352ab", "marty_kohler36@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMMzJJWHO0Eudj2z+3ICW/Sf0WbcZf4tOd6R7I10YhJPgfp/YfsCbcR86hpcPKKTSA==", "439-931-4997 x874", false, "cc9bc0a8-45b2-474a-b687-3e6a12ff8f14", false, "Marty_Kohler36" },
                    { "999eed49-bf0b-4136-b950-968a1fa71ddc", 0, "dd201912-1f47-43d7-b0b5-160c83fc6ede", "marguerite0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKoMZvgN3w2B0F1Si0T2unIvymZ14AeIl5QsYTfueVcn6qXZG+LDGUX4lOGV+9Lkbw==", "843.333.9528 x6153", false, "994e8640-41ec-4e43-9661-e55d32863cf6", false, "Marguerite0" },
                    { "b43822c5-872f-477f-bb3c-69f4b51569b0", 0, "c82c05dc-c51a-40c0-8ba6-7afd4cda0ac2", "candice_heidenreich@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGyl2/wX8r8X7vs/Smdb1l0/2HAjpEDdA68v08oxa+BhWKlm7dJmEPG178ZPvuh4vQ==", "1-651-748-7956 x670", false, "77b7e5bc-2001-48f6-a240-25346fce0a55", false, "Candice_Heidenreich" },
                    { "db593821-8e01-498c-892e-016e2bb4cfde", 0, "e9d91336-063a-4cb6-b165-84b4ce3500b7", "marvin_hartmann@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP8lTnl+Q1mirmgQiSTyS3FHkg5vMt/f0tR7wpr/hvjzN1HDd+HmaZkYXH/mhP5KBA==", "(988) 804-2661", false, "792dc47e-0495-486a-a022-7db2854af06f", false, "Marvin_Hartmann" },
                    { "e5836e75-8e2c-4d44-ba65-e5dff45cabe8", 0, "a4ef29f8-20b1-406a-acad-fef24048f714", "salvatore28@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDRMT836OK/Ovv/de94IEmbzlXjm3ym6KikXP6RpOZ8/po3YWZgr/0gsiTddutsGdQ==", "(253) 877-3269", false, "b1eebb00-1d0c-4c8b-83d9-423cc52bac5f", false, "Salvatore28" },
                    { "ea1b45ae-acc9-4569-bab5-97860e4e5dbc", 0, "5be573a0-a830-415b-9fc0-c03e96ff27c9", "rebecca48@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIdhnCYgjgdch/gTfmyRlYQue7koZSbAVgJ35O72hZBjTJn/Yoa/pOYwzvjvpVIJog==", "1-766-510-3215 x048", false, "5147f77f-8eb4-4788-be8f-c6ab5bb11c7e", false, "Rebecca48" },
                    { "ef8c9b7f-cb8c-4591-b53d-40d817054eab", 0, "3c3ad992-c040-46cb-90ba-70560f8f70a1", "priscilla45@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAED9h6YNbGjjM0W9/5vYwRQFVX+YOAuw+yOWbmIVAPkPqvSYgKIcDy0mAUxGf8jMjmw==", "460-348-9725 x4938", false, "7509b5bc-6c54-4b53-bb0f-80d6eb047e1f", false, "Priscilla45" },
                    { "f135d071-9671-4884-bfdc-dddc231706ec", 0, "6158f671-9528-4bfa-bfb2-432cebaf13ba", "kellie.rippin25@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPdzTULt9htH/POC+WfMobLGiNol/ERpiAYLMNm3w1j8vgCoka8JSSXpufWWFHf7ug==", "934.742.7434 x37367", false, "bad45237-901e-47c6-9ff6-4f0a9dae3596", false, "Kellie.Rippin25" },
                    { "f351d533-5623-4c28-aa46-5b21f667d11e", 0, "885baf5c-1956-4a67-bec7-2685129ac5a1", "thomas.hartmann@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBPIW8mP1E00PS11Dt8U15tFzU/50gg9o/XPET+TgpcKSNeItQmdQz0z24pEvXJbKg==", "490-456-8022 x183", false, "9f44490c-7d11-493a-8d3a-c3098e0a2218", false, "Thomas.Hartmann" },
                    { "fa159046-c815-4f08-b8bb-8d61bb753d7f", 0, "9a34a4c6-8ed9-46cd-b434-cd46f80d3768", "olga_jaskolski@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPeBhwapAo8Vui9cD3DmCE9/r9qMx2518mGfdoSqEB8+L/B/EcrGizBO1/OYpJQRFQ==", "719-448-7303 x69698", false, "2737b6e1-bbaa-4599-8df1-45f87f0c4837", false, "Olga_Jaskolski" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Carla", "Graham", "Necessitatibus quas aperiam pariatur et quam odit odit labore voluptatem. Asperiores modi maxime voluptatum similique assumenda excepturi quidem. Architecto et nihil voluptate saepe qui.", "Digitized holistic moderator" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Viola", "Lemke", "Est aliquam et est tempore harum omnis quis et. Ut fugit ullam minima id fugiat recusandae eos. Et est et accusantium officia repellat excepturi.", "Realigned intangible superstructure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gabriel", "Kulas", "Sit reprehenderit velit. Voluptatum ut aut sed animi. Eveniet ratione eum sed aut distinctio. Earum officia voluptatibus velit totam. Rem corporis non et perspiciatis maiores quaerat.", "Balanced holistic function" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Reginald", "Ratke", "Facere cumque assumenda dolores quod. A deserunt rem quae. Est minima et. Tempora odio deserunt voluptatibus sed ratione. Asperiores excepturi vel voluptas eaque nostrum nam reiciendis quaerat. Debitis et sunt possimus aliquam esse praesentium expedita vitae placeat.", "Managed bandwidth-monitored utilisation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Pete", "Gislason", "Sapiente omnis officia sint ut est qui velit minima. A sit dolor recusandae autem repellat eveniet enim ullam. Illum rerum officiis et ea et dolor incidunt. Minus voluptas est fugit eum rerum nostrum atque sit repudiandae.", "Pre-emptive well-modulated model", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Seth", "Okuneva", "Voluptatem vitae officia id quod excepturi. Quia numquam est ipsa voluptas. Dignissimos labore aut accusantium sint voluptatum hic blanditiis. Qui dicta cum iste nemo qui quia sit aliquid. Reprehenderit aperiam et suscipit mollitia adipisci et. Consequuntur iusto enim.", "Visionary attitude-oriented core" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Yolanda", "Yost", "Nobis sed dolorem voluptatem. Voluptatem et quas quisquam. In eveniet omnis quo. Commodi voluptas quis.", "Operative interactive capability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Josefina", "Ziemann", "Odit corrupti enim iusto sapiente molestiae quos illo soluta alias. Vel est natus est deleniti blanditiis corrupti. Dolorem nulla recusandae mollitia sint qui.", "Profound system-worthy system engine" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Faye", "Gislason", "Animi enim et reiciendis occaecati dolores ut alias laborum. Qui rerum corporis dolores eos placeat ut. Illo est ut assumenda.", "Quality-focused global challenge", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kate", "Witting", "Qui fugiat totam quo repellendus autem quis. In quo delectus ullam ut cumque veritatis reprehenderit iure. Ab et quia quibusdam veniam voluptate cumque quod et. Laboriosam consequuntur id quibusdam rerum libero voluptas. Non ratione deleniti omnis eum quisquam minus ab et eos. Neque eum ipsa quaerat molestiae veniam.", "Optional next generation neural-net" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Eileen", "Bruen", "Velit velit quo iure impedit rerum odio. Dolores vel repudiandae quia ipsum dolor. Sapiente at quia et alias asperiores.", "Virtual 24 hour algorithm", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lori", "Von", "Sunt quisquam optio quaerat mollitia reprehenderit provident soluta quia. Dolor cumque tempore in sed assumenda et repellat. Quae facilis nulla qui illo quam.", "Synergistic web-enabled structure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mona", "Hintz", "Vel qui nihil est quia eum exercitationem magni id. Ratione provident soluta recusandae. Fugit est repellendus quo sit eligendi. Dolore sint rerum voluptas quae similique.", "Inverse multimedia neural-net", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Della", "Kuhn", "Ducimus adipisci sint maiores fuga. Nobis architecto saepe similique deserunt qui nesciunt dolorem. Accusamus dolorum aliquam aut eaque assumenda nostrum quis qui. Sit ratione non hic earum aperiam aut et dolorum. Odit qui aut repellendus dicta blanditiis. Et saepe consequatur voluptatem sunt omnis dolorem commodi vel minus.", "Distributed intermediate orchestration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Paul", "Lueilwitz", "Aspernatur non consequuntur iusto aut omnis ipsam nemo qui aliquam. Voluptatem tempore non ex et quas cupiditate ipsam cumque recusandae. Tenetur omnis quasi in ducimus et ex.", "Down-sized high-level encoding", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Stacy", "Prosacco", "Temporibus est quo nam esse aut molestias sapiente. Asperiores veniam itaque distinctio esse qui. Nesciunt a qui qui dolorem est adipisci saepe. Similique dolorem quia.", "Switchable actuating help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Olivia", "Hilpert", "Quasi odit ea quae nam quibusdam laudantium provident itaque labore. Tempore est nihil reprehenderit itaque tempora voluptas ullam et totam. Aut asperiores quibusdam delectus voluptas velit alias officiis dicta. Quam omnis ratione aut.", "Integrated context-sensitive challenge", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Vanessa", "Roob", "Laudantium doloribus quibusdam vel exercitationem quo. Aut quis nihil odit. Molestiae iusto dolores eos blanditiis officia aspernatur explicabo sed. Nesciunt doloremque voluptatem recusandae dolorem. Voluptatum aut sit. Perspiciatis magnam debitis.", "Automated analyzing toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Chester", "Tromp", "Similique et ex at delectus itaque. Alias et provident. Reiciendis dolorum iure omnis. Optio voluptatem sed sapiente veniam a.", "Vision-oriented empowering throughput", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rickey", "Ankunding", "Fugit sunt qui voluptatem maxime quidem minima et quisquam. Molestias et consectetur aliquam quam voluptatibus odio sapiente. Maiores nihil quod pariatur ullam quas a.", "Focused regional extranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Hubert", "Ritchie", "Maiores omnis officiis alias libero. Magni debitis sequi consequatur distinctio placeat aspernatur. Qui quia fugiat consequatur. Et quod molestias et ut.", "Programmable contextually-based circuit", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Orville", "Jast", "Sunt quae similique aut libero architecto velit explicabo. Delectus exercitationem omnis est et vitae tempora. Sunt rem omnis perferendis cupiditate autem hic sapiente.", "Automated static info-mediaries", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Courtney", "Wiza", "Inventore voluptas iste atque. Consequatur et nesciunt temporibus voluptas. Ut consequatur consequatur aliquid incidunt nulla velit. Nobis fugit nostrum quibusdam architecto eius non. Asperiores consequatur laudantium.", "Upgradable hybrid software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gina", "Gusikowski", "Voluptatem voluptatem voluptatum velit est perferendis quae consequuntur. Omnis voluptatem dolorem sit iste consequatur maiores corporis odit. Et qui asperiores deserunt.", "Synergistic empowering capability", true });
        }
    }
}
