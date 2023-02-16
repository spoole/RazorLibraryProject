using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class LocatingUserMgtIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00feabea-5d77-487a-910a-ad1ac6f01cd9", 0, "3546c69d-0e25-46e1-8e91-db6e2780f6a2", "opal_schmidt@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFPX34kCZH9PSXotryHcqQaD0S/Lpgs0gWAX7+umg6fMg3qPb0JQsErOBz/RD3xSEg==", "398-843-4172", false, "b8c1a097-f4a3-4ad5-a4b0-bbf00e451964", false, "Opal_Schmidt" },
                    { "10a4adf5-30d2-4f72-9449-535b124745f4", 0, "701c7215-0876-480e-af3a-c745f732402e", "julia_feest65@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEF+Jhz0eL01n20ekfMo9o4cqVNNGbVP/SKVhyPWEQLICne1sNgq93iLX6DLuuWsrSw==", "590.653.9337 x33613", false, "ab3f3236-f7bf-4c43-b8fb-b92d4fa87cda", false, "Julia_Feest65" },
                    { "2dd53dd8-8fc6-445c-9340-a93213f423c0", 0, "eb3ac415-7ef5-43bc-a749-04dbcf91b0dc", "julie_hoppe23@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEK2VZ8knydw6ydSXgHUXns8H8PjlfMhf0LgA3k/9f2ZFjNSlpHr9J34zVhoKfnh1jA==", "649-747-9272", false, "41014200-37ee-4ce3-b721-ff0e74c6fdf3", false, "Julie_Hoppe23" },
                    { "3ff31a82-1ab0-47b2-b283-c275ab33ab68", 0, "2e53ee25-3679-424b-aeb9-eef0aed53585", "bert6@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDlV/BQSyd0OlKmnUqMteRmN9lVyzzRlZlwv8kMqXmWZeXy5xophqmUwInq8eRGBbw==", "1-969-430-7500 x079", false, "58278855-629f-48ca-86f5-39e0dc266b5e", false, "Bert6" },
                    { "426dcaf0-b484-4857-a61f-de5c73d01687", 0, "b00238cd-d90b-43e7-9b27-345326d55752", "theresa_medhurst@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHw6Jvlnnvt0KryvIhbcrwG9WldrNZbQBy9JYTxsXG8m5ZERYrnuIz2KRvNB9LqyBA==", "397-858-8066", false, "870bdf35-301f-4920-973b-3dd180cd8edc", false, "Theresa_Medhurst" },
                    { "480964bf-910b-4679-91b0-db57eb9e99bf", 0, "585a387f-68ff-4495-8491-4da1718268d5", "kathy71@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEO99moHxfGpKnaOsg2eaxRjPintNmmIjGqt17NPZO79sGsqs8LRt9MMsNQauuWrPig==", "(828) 667-4284", false, "60f8cb2f-9266-4480-a648-4f000425e53f", false, "Kathy71" },
                    { "50feac1c-43ee-4263-bd96-a92f72544841", 0, "5234feab-edb7-401b-8a1f-05cd2c547cfc", "candice_ernser@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELLlYh4IyYLtWLOZTl2i/wcOwLGuypbcmgSTmyWqcsE1NkkFG/G/IVDIkf5DiNsKTQ==", "483-310-3291", false, "60b4cad7-732e-463f-9150-0bf9e10ead36", false, "Candice_Ernser" },
                    { "55261b27-b36b-4658-aea1-e885c3618082", 0, "d8b296b4-ba29-4af3-9e67-278d5cc3828e", "chris29@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGRy+l/7beOBY/oMmNmLTHkw/vHf/Nt28RDFQDI7n9YtZGpm8ildla4cCg9nYm+/JQ==", "1-902-848-5518 x9739", false, "699af088-9893-486e-ad42-4ce5eee8afce", false, "Chris29" },
                    { "5a9e224a-b176-431b-ae28-c51e3e8c0fcb", 0, "442fb344-bb18-4a41-83d3-517d93ba4309", "curtis_stanton@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKwJfQsWVAolBL8UaXNZ801g8BCVv6k/hkzYd9xzokcNJ3Uu5ztCBsZE5NXtvPjWvw==", "847.593.0840 x51632", false, "72120d8c-bfb3-44b0-adf4-471c96285141", false, "Curtis_Stanton" },
                    { "7babd443-efba-4e29-8ebb-5e8c93cb7cce", 0, "6a8abb8a-d58c-46bc-a2a9-0f5e3e7ee9dd", "carrie.shields15@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPihM9Q07xFcI+E3mb0K5/yday8fXAtIj11UJ7XZ3/mxA1s1k2dX+5ugsiqugAJR3w==", "1-504-832-1724 x96307", false, "5e531b81-37e0-4f4a-ac1d-c447a0943f14", false, "Carrie.Shields15" },
                    { "87719dd7-fc5d-4d54-bb65-975fd99e10bd", 0, "aab39bcc-9662-4960-a422-0e3b3307a505", "kenneth.feil@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAED2s1BsEB91cj4xp6T/bEdGWnGt9iovBMOFwbuFlT8eYqiFjErRIlCu2oynjnazlAg==", "778.934.0944", false, "9dc85d34-29a8-4c82-821b-1a3853bc4fe2", false, "Kenneth.Feil" },
                    { "89292d12-e113-4157-b165-45a7a3ed14f9", 0, "4957d8fb-11d3-4f6f-9c9b-e7e14edac1d7", "travis32@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGL3Lgi12t72ZUTI0wRUu50RufcicprsRwMEglgx6IhGGnRWaUoUdjdegGTBjGjV4A==", "(259) 842-4236", false, "67f38d1b-0574-4f76-95c5-331cb970f33b", false, "Travis32" },
                    { "ae337196-626d-4761-b806-68a0e2312c28", 0, "0aaf6442-f507-4857-b86c-d66797a78afa", "ella81@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKRkeRVDrZnKEY471ARJJ+Ojjpb32iSeg3bPSDJTIS0Xa7sAKGBkkeLs5Y55zEckPA==", "(285) 471-5902", false, "19796347-143e-4d9f-9fab-9645ad9aa8b4", false, "Ella81" },
                    { "e710dfb1-2992-42f3-9d04-263491f007d2", 0, "14ea49aa-68d0-44e0-baa3-54d35fb46b2e", "ray_bernier98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENswjZgd7IQFMNk2+kWApQUzqRefwOou+PjefFWeIABzC8cbQQfPquoVtau9VVpsLg==", "(308) 693-1696 x10050", false, "5036eed0-237e-4643-8385-a4f013d60d66", false, "Ray_Bernier98" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Philip", "Kling", "Mollitia perferendis quod necessitatibus cumque. Enim voluptate libero commodi non est officia beatae odio occaecati. Atque quos vero repellat dolores rerum consequatur.", "Networked motivating adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gerardo", "Effertz", "Aperiam nostrum sed quis. Qui corrupti dolor velit. Temporibus dolores aut nihil nobis error et molestiae.", "Monitored multi-tasking open architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Doug", "Bogan", "Nostrum aliquam rerum. Recusandae facilis ad ut eius. Odio optio culpa odit. Aliquam quidem nobis alias quo deleniti consequatur natus molestiae. Velit accusantium odio sint. Harum illo et ea vero aut dignissimos.", "Re-engineered global matrix" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Irving", "Welch", "Inventore est corrupti voluptatem libero. Nostrum qui distinctio aperiam sit ullam. Debitis dolor officia voluptas possimus. Odio consectetur et hic vel consequatur culpa corrupti quas. Dolor commodi necessitatibus distinctio unde odio ullam dolores nisi.", "Multi-channelled object-oriented conglomeration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Bridget", "Hoppe", "Et et ipsum maiores illum non ut molestias minus doloremque. Rerum numquam modi. Architecto laboriosam quidem et voluptates. Dolorum ea iusto nemo enim et aut modi.", "Enterprise-wide asynchronous Graphic Interface", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lynne", "Koelpin", "Quo odit tenetur voluptas hic sed sed. Laboriosam asperiores saepe repellat. Consequuntur numquam aut animi magni neque voluptas aspernatur nesciunt.", "Integrated well-modulated software", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nicolas", "Kohler", "Rerum ullam in corporis earum voluptate quis illo et consequatur. Facere nobis dolorum itaque laborum cupiditate tenetur aut in. Esse error non dignissimos voluptas. Eaque quo maxime sed sit qui.", "Function-based mission-critical architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nathan", "Kris", "Est modi occaecati sit libero ut ad cum qui nihil. Omnis sit numquam impedit atque voluptas temporibus ut suscipit dolorem. Voluptate consequuntur veniam sit eos ipsam vitae. Minus saepe incidunt dolor voluptate repellendus repudiandae corrupti quibusdam. Incidunt eius magni mollitia consequatur minus cum. Delectus perspiciatis eos.", "Face to face leading edge interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Neil", "Yundt", "Autem aut quos repudiandae nam facere voluptas ullam distinctio. Sint molestiae nemo. Sunt dolor provident magnam amet reiciendis tempora facilis qui. Ut porro neque voluptas consectetur temporibus dolorum perferendis.", "Up-sized 6th generation migration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Connie", "Dickens", "Est error consequatur. Rerum porro quia possimus voluptatem. Non facere dolor ipsam voluptatem fugit provident ipsam est velit. Qui quo perspiciatis nisi repudiandae.", "Networked regional info-mediaries", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Karla", "Hills", "Fuga tempora sed eveniet error necessitatibus rem possimus. Earum occaecati nihil. Eligendi laudantium cum. Eos fugiat illum vel sint praesentium sunt dolorem.", "Synergized grid-enabled instruction set", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darnell", "Hettinger", "Similique ut commodi facere. Esse omnis eligendi commodi numquam. Accusamus quidem sunt incidunt eum. Et voluptatum magni qui tenetur nostrum possimus sit aut.", "Reverse-engineered regional concept" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tami", "Schamberger", "Et libero laborum. Laboriosam voluptates vel aspernatur ut repudiandae in. Aut dolor numquam. Tenetur facere ut aut culpa temporibus. Aut aut libero et similique unde sed sit doloremque.", "Diverse demand-driven alliance" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gina", "Metz", "Est et nulla dolore rem eos consequatur accusamus. Sed non et. Accusamus in nisi laudantium enim praesentium sunt hic unde praesentium. Accusamus sint sapiente dolor. Saepe sint veniam sed nam impedit rerum modi maiores et.", "Function-based transitional installation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dexter", "Langworth", "Quo aut quam ut aut. Aut iste quis hic quia. Adipisci magni ad quod quis dolorum doloremque eius. Officiis facilis incidunt. Qui incidunt eos quia assumenda aut quo.", "Distributed asymmetric process improvement" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kent", "Stoltenberg", "Repellendus totam repellendus dolores. Doloremque ut molestiae voluptas numquam aliquam odit. Blanditiis corporis optio corrupti sapiente et qui qui eos reprehenderit. Et in eos eum et id. Ut qui incidunt.", "Synchronised stable emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Beulah", "Heaney", "Corrupti quos quaerat asperiores. At maxime voluptas quidem voluptatum provident. Voluptas dolor accusantium fuga ex doloremque provident velit. A temporibus et eos cum quis. Cumque in amet numquam ea nostrum aut non ratione.", "Multi-channelled reciprocal pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Edmund", "Bayer", "Vel dolorem laudantium eveniet quia repudiandae. Accusamus nemo suscipit error nihil non est voluptatem sint illum. Quam voluptatem id cum sit autem laboriosam eaque ex. At vel nam consectetur quaerat expedita.", "Diverse attitude-oriented hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lowell", "Daugherty", "Recusandae accusantium quo. Incidunt id asperiores beatae ut. Perspiciatis quo voluptas.", "Right-sized mobile database", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elsa", "Koch", "Veniam harum incidunt illum maiores placeat. Qui dolores iste. Aut eos iste qui sit quasi consequatur. Voluptas non quidem. Soluta nesciunt repudiandae voluptatum cum est voluptatibus et.", "Synergized object-oriented hardware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Stacey", "Sanford", "Autem eius quis non quas nihil rerum dolorem velit aperiam. Consequatur corrupti aliquam magnam quas voluptatem odit expedita laudantium ut. Doloremque blanditiis quia officiis rerum enim. Omnis vitae suscipit. Laboriosam consequatur rerum iste enim corporis non nostrum id dolorum. Ut et ad est harum debitis vitae.", "Re-contextualized fresh-thinking access" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Caroline", "Howe", "Eos magnam molestias esse consectetur quidem tempore deleniti earum qui. Quaerat non assumenda molestiae incidunt aut dolor. Maiores sequi at expedita minus molestiae cumque sunt est necessitatibus. Ad ut et quaerat fugiat reprehenderit officiis quam eius.", "Ameliorated reciprocal parallelism", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Owen", "Trantow", "Et quaerat deserunt officiis. Magnam dolore voluptas et voluptatem eveniet architecto enim aut dignissimos. Et enim dolores sit necessitatibus et eveniet. Quis suscipit molestiae beatae repellendus veniam dolores.", "Virtual real-time policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rose", "Schimmel", "Dolorum eius dolorum error natus facilis. Inventore saepe qui nihil vel et eligendi molestias. Veritatis praesentium velit non laboriosam animi ut veniam. Debitis consequatur laudantium. Blanditiis aut cupiditate labore.", "Cloned national matrices", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sara", "Funk", "Ratione quos provident tempore placeat quibusdam molestiae animi earum. Ipsam qui sint et. Culpa aut quidem alias fugiat. Et commodi accusamus debitis dolorem maxime nam ut vero. Numquam quod quia quasi. Error ullam quia consequatur et suscipit sed.", "Reduced disintermediate methodology" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Noah", "Murazik", "Magnam fugiat nesciunt maiores. Dolores rem sit esse ut id. Debitis sint odio non. Recusandae consequatur necessitatibus ab incidunt. Sunt ea quo repellendus. Expedita beatae ab vel adipisci.", "Streamlined national software", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Beatrice", "Mills", "Magni dolorem ut quis et consequatur id perspiciatis delectus. Iure quos distinctio earum earum voluptatem. Et modi tenetur omnis vel vitae sunt repellat et.", "Future-proofed client-server help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Faye", "Grady", "Animi fuga quas similique autem consequatur ducimus non similique alias. Dolor est eos consequuntur veniam dolor recusandae in. Molestiae quaerat omnis.", "Re-contextualized attitude-oriented product", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Karla", "Jakubowski", "Veniam ipsa esse ipsum reiciendis ea aut. Repellendus omnis temporibus voluptatem maiores. At voluptatem provident quisquam.", "Face to face disintermediate strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Maggie", "McLaughlin", "Sint nihil aut. Illum error fugit qui nam ut sed inventore assumenda voluptatem. Similique doloremque et. Laborum incidunt suscipit earum aut consequuntur hic ipsam dolores laborum. Omnis dolor aut delectus quasi natus. Reiciendis exercitationem praesentium neque.", "Fully-configurable human-resource website" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Joyce", "Heaney", "Nihil modi nobis sapiente iusto asperiores hic veritatis. Repellat et maiores nihil quaerat. Voluptatem vero maiores odio quis sunt. Quia unde reiciendis quia quia. Maiores accusamus voluptatum.", "Synergistic zero administration collaboration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tabitha", "Kunde", "Laborum est expedita itaque consequatur tempora. Et totam sint aut nesciunt est atque. Odit eos fugiat ut suscipit reprehenderit possimus dolores aspernatur. Maxime fugit beatae suscipit fugit. Corrupti eius ullam qui temporibus molestias doloribus ut sunt eligendi. Eaque sint et inventore.", "Phased client-driven product" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ryan", "Predovic", "Ut quia accusantium quia nostrum. Iste perspiciatis magnam sapiente mollitia omnis id. Laboriosam iure voluptatem. Quisquam veniam numquam. Quod ipsam exercitationem aliquid accusamus tempora.", "Realigned uniform system engine", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Nelson", "Rau", "Suscipit ut explicabo illum rem. Consequatur qui quia dolorum corporis eum deleniti quia. Commodi et nemo perferendis vitae. A ducimus quia et voluptates aut cumque. Eos repellendus dolor enim. Sed molestias sint aut quia at.", "Innovative methodical concept", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Miranda", "Stark", "Nihil eligendi vel ut. Cumque doloremque quia molestias. Accusantium ipsum in neque nihil praesentium. Autem a blanditiis veritatis eaque necessitatibus sed. Nihil non earum. Quisquam qui iure vero eveniet recusandae laborum repellendus.", "Down-sized next generation installation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Blanca", "Smith", "Est deleniti omnis quibusdam esse velit. Dignissimos distinctio tenetur ipsa dolorum impedit nemo nulla pariatur deleniti. Ducimus dolore rerum omnis nam numquam quaerat perspiciatis et nemo.", "Devolved asynchronous monitoring", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lela", "Mosciski", "Enim officia temporibus voluptate neque placeat repudiandae ea nobis possimus. Esse aut voluptates est tenetur fuga ratione eius. Doloribus dignissimos quia incidunt ex laudantium aut natus. Tempore ea minima nostrum rerum.", "Secured 5th generation local area network" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Miguel", "Schimmel", "Magnam sunt totam autem ut distinctio ut qui nostrum. A rem ipsum eos enim. Cupiditate officiis nobis deserunt dolore laudantium ut possimus. Beatae voluptas magnam quae dolores. Nihil ea cupiditate vitae minima iste. Ea est recusandae.", "Integrated background capacity", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marsha", "Bednar", "Ea eaque delectus et qui eum enim ullam. Quos dicta earum. Dolor consequatur et vel maiores dolores iusto cupiditate nulla incidunt. Impedit voluptatum ut laudantium nobis.", "Multi-tiered fault-tolerant Graphic Interface", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Betty", "Ferry", "Minus voluptas omnis delectus facere deleniti aperiam nemo. Dolore eos voluptas possimus molestiae corporis enim quisquam sit id. Et aut vel non earum libero quis est at incidunt. Et natus inventore voluptas sed. Nihil deleniti velit illum nobis. Quas atque magni hic omnis tempora iusto et.", "Switchable national policy", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Edith", "Balistreri", "Ad voluptatem consequuntur sequi ipsa vel corporis. Voluptatem illum est laborum sequi architecto. Perspiciatis recusandae voluptate aut recusandae itaque numquam expedita et ut. Blanditiis et eligendi placeat qui et. Labore molestiae accusamus laboriosam doloribus quas cupiditate.", "Synchronised coherent open architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Johnathan", "Davis", "Magnam et vitae nisi laborum voluptates explicabo. Corrupti vero aliquid magni fuga nobis illo culpa rem harum. Vero ducimus necessitatibus.", "Reduced non-volatile methodology", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 43, "Michelle", "Carter", "Voluptatem perferendis hic repellendus mollitia fuga vero. Repellendus eligendi eos dolorum fugit dicta eos id accusamus a. Omnis in consequatur maxime velit ut quasi harum vel amet. Eaque vel esse nihil porro fugiat ipsum. Perferendis quisquam provident quibusdam ad voluptate.", "Digitized coherent flexibility", true },
                    { 44, "Lorraine", "Hintz", "Nihil eaque velit deleniti temporibus. Quae consequatur et praesentium nihil non reprehenderit. Error non est iusto ea eaque saepe officia nulla quia. Totam modi consequatur voluptatem.", "Mandatory high-level benchmark", false },
                    { 45, "Leona", "Becker", "Ut vitae similique voluptas praesentium. Sed odio voluptas. Sed qui modi facere sed at rerum repudiandae. Non ipsam harum debitis cum hic voluptatibus aspernatur nihil in. Voluptatum numquam porro suscipit nulla exercitationem et libero optio nemo.", "Proactive system-worthy groupware", false },
                    { 46, "Stephen", "Keebler", "Esse ea non enim numquam et eveniet. Voluptatum occaecati facilis. Consequatur officia odit.", "Fully-configurable needs-based infrastructure", true },
                    { 47, "Lorraine", "Wilderman", "Et adipisci autem quia maiores molestias molestiae qui. Tempora similique sit officiis. Aut ea aliquid voluptatum. Ad alias omnis commodi occaecati et cumque voluptatum explicabo. Illum voluptatem quia magni.", "Reverse-engineered analyzing project", true },
                    { 48, "Heather", "Windler", "Error ad fugiat qui et aut quibusdam omnis. Et sapiente dolor. Aut ipsam assumenda rem ea aut neque qui.", "Visionary logistical support", true },
                    { 49, "Belinda", "Feeney", "Mollitia illo impedit reprehenderit sunt. Quis illum blanditiis saepe rerum molestiae. Illo fugiat alias qui et eum corporis voluptatem. Labore quia placeat amet veniam quam sit.", "Switchable homogeneous toolset", false }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00feabea-5d77-487a-910a-ad1ac6f01cd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "10a4adf5-30d2-4f72-9449-535b124745f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2dd53dd8-8fc6-445c-9340-a93213f423c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ff31a82-1ab0-47b2-b283-c275ab33ab68");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "426dcaf0-b484-4857-a61f-de5c73d01687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "480964bf-910b-4679-91b0-db57eb9e99bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50feac1c-43ee-4263-bd96-a92f72544841");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55261b27-b36b-4658-aea1-e885c3618082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a9e224a-b176-431b-ae28-c51e3e8c0fcb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7babd443-efba-4e29-8ebb-5e8c93cb7cce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87719dd7-fc5d-4d54-bb65-975fd99e10bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89292d12-e113-4157-b165-45a7a3ed14f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae337196-626d-4761-b806-68a0e2312c28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e710dfb1-2992-42f3-9d04-263491f007d2");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 49);

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Glenn", "Price", "Nam quo rem rem distinctio unde voluptatem omnis. Labore animi aut enim nam libero ullam amet. Ipsam omnis vel.", "Multi-lateral real-time pricing structure" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Eunice", "Haag", "Ex quia inventore placeat. Sed repellat ipsum inventore. Voluptatibus repellat autem.", "Function-based upward-trending support", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ricky", "Okuneva", "Debitis qui ut. Et voluptas libero aperiam similique odio. Aspernatur voluptatum tempora voluptates. Et assumenda molestias quia sit voluptas.", "Down-sized upward-trending application" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Megan", "Brekke", "Dolor vel veniam facilis laborum voluptatibus. Nesciunt dolorum natus illo adipisci consectetur error debitis nihil. Ut sit consequatur nisi et ea corporis quas omnis. Sunt veniam quaerat repudiandae veritatis. Qui qui inventore vel provident quis nesciunt nam. Saepe quidem error non.", "User-friendly discrete encoding", true });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Woodrow", "Haley", "Itaque ut rerum excepturi. Modi id numquam omnis. Numquam voluptate sint quam ad est aut.", "Centralized local architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Johnnie", "Ritchie", "Autem est consequatur eveniet dicta ad molestiae quisquam error quos. Est non est aspernatur voluptatem reiciendis nesciunt. Earum molestiae reiciendis consequatur.", "Optional web-enabled matrices" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Myron", "Paucek", "Natus voluptatem delectus nihil eligendi harum placeat. Ut eos itaque laborum voluptatem non. Sequi qui dolor ut sint. Possimus ea maiores cumque odio deserunt inventore occaecati adipisci.", "Mandatory motivating conglomeration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jill", "Paucek", "Molestias ut est et molestias est aspernatur. Et voluptas deserunt voluptas et velit nisi. Nulla non iure commodi eos voluptas aut. Sunt autem numquam vel est est ullam sequi qui. Quia ratione et voluptatem consectetur molestias laudantium.", "Organic demand-driven ability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Teri", "Smitham", "Dignissimos tempora labore explicabo ea. Alias sit molestias. Blanditiis incidunt ea recusandae minima. Est ut qui quisquam nihil iusto fugiat. Iusto maiores est deserunt aliquam.", "Focused regional groupware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jerome", "Bradtke", "Reiciendis rem ipsa molestias esse. Ab aliquam ipsam possimus quo quia occaecati repudiandae beatae. Et architecto vitae numquam perspiciatis id quia et porro vel.", "Re-engineered needs-based Graphical User Interface" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Keith", "Bechtelar", "Voluptatem et molestiae est corporis perspiciatis molestiae. Adipisci vero magni exercitationem magni consequatur. Ab autem ipsum inventore nam facere voluptas laboriosam quisquam.", "Adaptive discrete neural-net", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Connie", "Jacobs", "Hic voluptas nam aut placeat. Dolores sint assumenda ipsa velit quos. Expedita debitis aut consequatur autem. Occaecati facilis voluptas vero. Autem repellat qui delectus saepe ut exercitationem.", "Function-based multimedia migration" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Vera", "Mertz", "Voluptatibus eum distinctio incidunt nemo blanditiis. In optio sit sint sunt est accusantium amet id. Amet odio consectetur molestiae repellat tenetur ea sed. Ipsa esse magnam eum aut. Quae itaque eos fuga consequatur sequi eos et occaecati.", "Polarised local info-mediaries", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Laurie", "Johnson", "Reprehenderit fugiat alias dolor nam sit. Quo eveniet est. Magni voluptatum enim harum voluptatem veritatis in omnis assumenda aut. Totam voluptas sint iste aut. Voluptatum et voluptatum.", "Centralized coherent artificial intelligence", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kelley", "Baumbach", "Beatae adipisci reiciendis. Doloribus corporis ut nihil facilis. Quis ut ab facere sed perferendis aut reprehenderit maxime sed. Omnis debitis animi commodi. Suscipit iure nihil aut esse molestias incidunt possimus.", "Cross-platform mission-critical hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marian", "Abernathy", "Vitae aperiam quas molestiae sint aspernatur nam aliquam porro fuga. Ut sit vitae repellendus voluptates fugiat sit illo distinctio fuga. Quia fuga ab reprehenderit. Ratione quidem deserunt mollitia excepturi voluptates. Vel praesentium cum sit sit sed facere. Magni dolorem voluptate ducimus sit labore consequuntur quo.", "Monitored exuding budgetary management", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Stanley", "Schamberger", "Ea sit voluptas veritatis dolor unde sequi. Ipsa adipisci qui dolorum dolor rem. Omnis soluta laudantium ab voluptatem alias maxime excepturi. Delectus vero cum.", "Phased multi-tasking workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Alexis", "Parisian", "Iusto ea eum voluptatibus beatae qui. Et totam fugiat. Maiores quas eos autem et perferendis iure distinctio doloribus blanditiis. Ut esse eius adipisci omnis et temporibus repellat asperiores. Consequatur vitae sunt cum molestiae rerum ut rerum. Eius ea repudiandae magni quos qui expedita.", "Up-sized methodical local area network", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Johanna", "Reinger", "Quia et reprehenderit modi sit quia beatae. Repellendus facere dolor eius voluptas incidunt. Dolorum iusto hic.", "Front-line empowering open system" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Glenn", "Morar", "Architecto aut sed quaerat et aut quos veritatis. Pariatur distinctio non ut laboriosam consequuntur cupiditate dolores dolorum. Nesciunt sint nostrum laudantium aut itaque voluptatem voluptas non ipsa.", "Managed needs-based archive" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bonnie", "Rutherford", "Sunt adipisci nisi iure totam vel sunt. Ipsam doloribus voluptatem minima ut iste. Autem neque at quisquam est recusandae eos qui magni. Recusandae officia a in sunt et sit quos omnis. Ut et itaque. Beatae eum laborum excepturi.", "Customer-focused zero tolerance paradigm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sabrina", "Zulauf", "A inventore et aut et labore. Culpa accusantium voluptas harum nisi voluptatem quasi placeat. Impedit ea saepe beatae. Corporis temporibus enim qui fuga necessitatibus consequatur saepe qui. Nihil odio est provident dolor voluptate qui dolore. Eos quibusdam fugit ipsum.", "Versatile 5th generation success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Grady", "Nienow", "Porro qui iusto odit odit natus omnis debitis est. Libero natus numquam beatae esse eaque alias. Doloremque at tempora dignissimos sit perspiciatis possimus culpa omnis. Autem dolores quam quidem et. Qui sit tempora itaque reprehenderit sint. Sed id cupiditate rerum veritatis perspiciatis optio eius repudiandae voluptatem.", "Innovative well-modulated synergy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Winifred", "Paucek", "Rem error et. Qui et est fugit optio. Et a maxime vitae accusamus quas ut. Rem qui porro porro optio numquam et nostrum quam voluptate. Sed fugit deleniti quis nulla sapiente corrupti. Aut facere sed eos laborum cum.", "Inverse client-driven data-warehouse", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Donald", "Hagenes", "Hic exercitationem incidunt velit dolores iure quisquam enim explicabo. Dolore enim veniam alias laborum aliquid esse. Earum consectetur rem et cumque cupiditate dolores recusandae. Non voluptatem perspiciatis. Aliquid quasi vel ab aut. Hic aut a nemo qui voluptatem veritatis quasi.", "Switchable radical Graphical User Interface", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Laurence", "Leffler", "Sed eligendi sint nesciunt sint ipsum ut commodi aliquid consectetur. Non vel est voluptatem non necessitatibus dignissimos. Dolorum velit veritatis autem molestias.", "Multi-tiered bi-directional policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Beth", "Borer", "Sed nemo aperiam necessitatibus ipsa. Odit cumque voluptas provident. Neque quas ipsum repellat eligendi in facilis aut quos.", "Ameliorated grid-enabled adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Emanuel", "Langworth", "Soluta est totam sequi quasi hic vel et omnis. Porro sequi ad qui. Et error quisquam dolorum ea quod doloribus laudantium quidem nisi.", "Distributed fresh-thinking structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Beatrice", "Schinner", "Et suscipit sunt quo suscipit. Esse illo voluptatem autem laudantium non earum consectetur et incidunt. Vel officiis animi dolorem qui voluptatem in saepe aut. Pariatur dignissimos odit tempore.", "Vision-oriented incremental concept", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carrie", "Johnston", "Reprehenderit eos eos non dicta sit dolores facilis vitae. Accusamus accusantium cumque beatae libero et officia molestiae. Rerum eveniet rerum dolore quae consequatur quisquam expedita. Veniam sit quia repellendus. Sunt asperiores autem eius qui. Corrupti molestiae voluptatibus aperiam vero nesciunt.", "Universal responsive matrices", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Terry", "Gibson", "Ut voluptatem id recusandae aut. Quia esse tempora esse non est sed. Cumque magnam omnis corporis labore. Illum voluptatem non rem sint totam dolores aliquid velit.", "Enterprise-wide 4th generation migration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carlton", "White", "Et eum fuga quia voluptatem et. Qui eveniet voluptas animi rerum culpa natus ut eum. Et debitis odio aut amet culpa cum enim ipsam. Eveniet dolorem distinctio officiis nam repellendus. Adipisci cum molestiae enim quos quasi. Ea libero atque.", "Multi-layered holistic success", true });
        }
    }
}
