using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AttemptingToDisplayRoleList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1f64995b-39ec-4c2c-8336-fd5021591e6d", "4234d126-d647-4482-9841-77864c658378" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a40e89f9-a525-408b-b4e0-fe944e27b9ae", "e875cd1e-7799-4ab2-b9d7-6330a4910fee" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15e5ce7b-bb2d-4e1e-b1a0-57070bf9becc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15eb433a-10ec-47c8-8b75-ad775e128d35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2461ccb9-c40d-4bd9-b34a-99e7169e132e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ff600ae-8ef6-4825-bfc5-44d5f05778c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d56b72b-4e3c-4811-993f-c721e1ed1b75");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6954806f-9dd5-4fdd-a722-09d374bcb875");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89456b0e-8b1a-469a-ad8f-689f60651fb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9464446a-64a3-4ad0-9d90-c4f100413bfa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c140fa64-70f7-4a5e-a079-662cb8e7be11");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc122faa-16b0-487d-960a-2f6da75a7dd5");

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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1f64995b-39ec-4c2c-8336-fd5021591e6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a40e89f9-a525-408b-b4e0-fe944e27b9ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4234d126-d647-4482-9841-77864c658378");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e875cd1e-7799-4ab2-b9d7-6330a4910fee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "01284a83-e74a-4206-aec5-34f385ed20a5", null, "borrower", "BORROWER" },
                    { "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0167720a-14b2-44c8-8f1a-9efa696bf95a", 0, "5aaf5d7d-e704-4727-a62e-3f99ef86775d", "lana_shanahan68@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEG/5gEOulFH+SR17I/6XgzTznNF9h/YKmMLi/MMoSmRYX0cSecXle6eDzj0rAeuTJg==", "209-563-5094", false, "a7bd789f-3281-4373-929c-4982b28361cc", false, "Lana_Shanahan68" },
                    { "13ec32e0-5cc8-46f7-9991-d3b3b99d4774", 0, "cb7f9110-214e-46d0-815a-3b687b3e38b7", "marcus_cremin96@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECQP80H1GVSK/RoEuCgbzPyCrr60Zu45M/dljJijKAlgqFbscUmgZCw/tevh3gDKlA==", "1-850-800-7500 x0606", false, "1c78b863-d9ae-4f48-bbd0-17382b87fa55", false, "Marcus_Cremin96" },
                    { "1515cab7-3e7c-419c-a6b9-22492de78540", 0, "567b7ce7-5054-45df-ad0e-40fc102ead7a", "terry64@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGJhWKUmDci4bjkrv0Vn/ajMONn58g0ZgOSOGXSqxSnZ5V+ffFJAgcNBUv/q5gOPsA==", "1-463-608-8650", false, "78c33d05-11fe-4b3e-81dd-b21aa1185484", false, "Terry64" },
                    { "1d9e5deb-ae38-4a72-b3a5-4b7742f59ce8", 0, "0a0e0151-7c09-4136-bb68-09f3b2f35d53", "bethany56@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEES4SmXLQg3Jsa6Ee3n80cbhVCApMLixkslsKQYdYyBA9eYY/hlWAl7fL+IbBnIBCw==", "(548) 669-3960 x0467", false, "50710a9c-9274-48b5-991f-a8c7ef501bde", false, "Bethany56" },
                    { "1f8f6bb8-e9d1-4209-ac47-a404b33cd4da", 0, "4bfbabf8-fede-4844-b897-6a919a744f0e", "thomas.kuhlman@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEE1+s8jDzjWnnQtrX0H1T7faKNh52Yer4V29N5aSVUhodw3NRZN6fpNwdUNCItMG5Q==", "1-308-253-6968 x5645", false, "486ab83b-a796-4f46-97a7-42e89d538b07", false, "Thomas.Kuhlman" },
                    { "2990a32d-523f-4859-868a-62b3b58511d5", 0, "1123925c-7768-4b46-b5f6-d62a4404887a", "pat_bradtke89@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECLdi4L7G6jNU7z5XImlxGtPe9mBn3JJVoWhXmjr6pwlMMwNilDrBHKZKLce4Yzt6A==", "1-776-445-2316 x877", false, "3ecd7ade-429b-4d8a-a2ee-ab61af893d6a", false, "Pat_Bradtke89" },
                    { "5ece7cf8-955e-4809-9de0-87997742460d", 0, "5ea25569-0458-4c6f-a2ed-5f1408011902", "sophia98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELC5EOAONhrLWnYY9Vtk59Dhy5nPQ7Vv5r43ihJD+nBT3jaIty3+GBRwBSR7fXq92A==", "1-755-400-0218 x384", false, "d9b8b7ab-7b02-4df4-b234-5e16332710bb", false, "Sophia98" },
                    { "7d83e477-fee0-410b-a764-c9dc659862b2", 0, "058a5258-e457-40f7-be4a-63097d068fae", "rudolph3@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGmVf2LtkuzrEOIfhWsvP8fNuxHYyI7CT7AsvqqYUiH/0k93tgrxOHJ5lLvGVSS5Jg==", "714-442-5331", false, "3ed1bd19-9155-43d8-a019-841c55b72098", false, "Rudolph3" },
                    { "84ccedea-e60b-42ef-92a3-a66d5dc72830", 0, "79558f42-568e-44ea-a56e-0f0e168b9738", "ethel57@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKnJ1UVmpOgsiaJ/rWeOO4ptBLtos9tSh2+sa/zex9CAXPejJ7bkuqmCmmsnkRx33Q==", "865-436-6842", false, "a651eef0-f8b6-4f90-9a96-0ce71d0dcbb6", false, "Ethel57" },
                    { "8be73e1d-76d6-479e-856f-03b064d4cf2f", 0, "51b3ec55-ab3c-41fd-a1f1-3a0c0daf578a", "levi0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGWzOEEcfbnRnknCUVuyc26ENpqmp6vviX5UFDTi6Nh8E1arrAyfcqQhDzJCbXryrg==", "334.495.5255 x3235", false, "b088bcc5-9e33-4c00-b8a9-b00a46778c6d", false, "Levi0" },
                    { "971371a7-feb2-400b-94b3-560c80cca99b", 0, "3a23d2cc-fead-4c04-9b50-30d0b86fb63a", "hilda40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP0S5oB7ddaZp5OPjHmwQXLscGWj/HJ5r9PcMsjVFg9HqBI4u5qURjLEINuX7G8Bww==", "293-809-5117 x63702", false, "a0d41df2-66ac-4f32-9e6e-b511b3273953", false, "Hilda40" },
                    { "9a86b6a8-d4bc-4927-b1bc-2e164f578c35", 0, "472890e3-89c6-4557-ab20-7713a9d3e5d2", "craig90@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEO+Uc/FuFz1jyB0GjmW64ghrtMdCVemHIQwtxWW9YqbbCx+sBnGGkfbNfDeiY161aQ==", "876.452.6281", false, "f85d2bd0-77a9-480b-813a-6e62f852287c", false, "Craig90" },
                    { "a4781e30-cde1-42c7-ba82-c25232feb9de", 0, "683cd9fe-10a5-455d-bb56-e1c6bf5ebe03", "richard_ohara@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEB3KJJWC84nuEYjfKNngXCT/WzpIzh+Mv69I7+4nvEoTwgv4+8DC+ZR4SPHUu8hz0Q==", "356.309.0265 x877", false, "59130f84-0bd5-4b19-b5f1-8377f4050e10", false, "Richard_OHara" },
                    { "aaba92a6-b157-4bc0-9bcc-c31dc58d5f2d", 0, "fd826c71-d65e-444d-ae48-a7f567ddb327", "natasha_hand27@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDap+xVBNfB+1MfLOFkCnasmSIspuFSJkNZ5rqyHtXTOR/101QbnNlEPQD7pI5PGSg==", "751.208.9892 x5707", false, "0db2b154-b3d2-473e-9da7-163b6e5afdbd", false, "Natasha_Hand27" },
                    { "af0b5655-46d2-4032-93b0-a9d4fb240981", 0, "7141184e-0d6c-4fa9-933a-f187e81039f1", "josefina58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECf4SyoRnErUocjbWZvY2FuxrL4MHuwPFe/TqPC1nvgnp8PqGgOj8lVykUt0hBYRmg==", "(390) 243-0782 x2418", false, "e80077e0-0c7d-4418-a72b-8db85a1028d4", false, "Josefina58" },
                    { "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c", 0, "aca34c67-6770-487e-bc40-9439642b65eb", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAENw3sve8S29L1AvJCgIUI5PpSHQ0jVERCk6kxeACNJTrKQiqFgLgSzpcMS7R7zHRjQ==", null, false, "c778db34-e2d6-43bc-8dae-4600a59381be", false, "librarian@library.net" },
                    { "cb773360-6700-4d07-b302-69f33524b6d5", 0, "aa8e96c7-a460-42f1-9ec3-5ab74e9689c5", "danielle.parisian92@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENpsSFzNATa1oFu7uskwB/qCaXFOJTXMJeTuw3GL9SKYvpUjS5mtSndughezpjnaoA==", "664.994.6657 x32081", false, "5e5e7d30-740d-49fe-968c-0a4c4bdc4e24", false, "Danielle.Parisian92" },
                    { "cb7c76d8-1748-42bd-adcd-b307247781de", 0, "a5347f63-754d-4c6c-ad96-48f5d0f84157", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEANjKqmCooHQX5OPq7dNEo/2o6l9CbKxz8uNDPojGzgGw3sseZd/T/zWIFxN9LHTLg==", null, false, "ff3ca306-b04a-4e4f-b468-e1f3c2db8d18", false, "borrower@library.net" },
                    { "f474cc19-cf5b-4fa9-b59a-e269a0303ed7", 0, "a63190dd-bc2e-4c2f-b132-04f890dacbd4", "orville7@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI2OuifsahsHjQx5C8G89pphsU2tDZGDWr+8f29fapmYxCBym09hRri06aymCeIpEQ==", "1-947-690-1452 x5056", false, "f619b497-9748-4019-939a-a0a0ae89ab6c", false, "Orville7" },
                    { "fea1b38c-87f2-40c7-9f2a-c94287a2329f", 0, "88314052-7a19-4a82-a5ee-544b967e9779", "sherry.mayert62@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELCf237hSET7rk0xBR08tIoxoFfD6GHif7lGUQSYVJnmC+woM3dJUUFUdI0457sdkQ==", "(853) 742-1043", false, "27bd84b1-6390-4c41-919e-f24d87628d47", false, "Sherry.Mayert62" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jerome", "Koelpin", "Vitae nemo architecto assumenda tenetur porro. Nihil ea non vel. Rem est beatae quos aliquid aut et.", "Versatile directional concept", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kirk", "Haley", "Sint maiores quis pariatur soluta enim placeat sapiente. Temporibus repellat recusandae perspiciatis. Consequuntur labore veritatis perferendis.", "Secured full-range success", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Warren", "Bode", "Labore eaque quasi. Maiores quia consequatur ex. Provident ratione soluta molestias voluptatibus saepe non. Delectus impedit assumenda eius voluptatum voluptates porro sapiente itaque rerum. Consequatur cumque aut voluptas cum blanditiis dolore placeat.", "Robust zero defect software", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Angel", "Huels", "Aliquid corrupti consequatur molestias quibusdam qui fugit sint quia. Dolorum eos qui provident dolorum molestias. Deleniti delectus quis consequatur ratione rerum tempore voluptas repellat sint. Cumque cumque perferendis.", "Open-source 4th generation pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dianna", "Heathcote", "Illum sed qui asperiores. Officiis quam et ut excepturi quidem ut impedit qui veniam. Doloribus quo natus sed. Quisquam accusantium iure fugiat eius illo quia.", "Multi-tiered zero tolerance encoding", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sonja", "Watsica", "Repudiandae est possimus. Illo ea libero nihil blanditiis nihil non. Autem eos et enim quis voluptate consectetur aperiam. Ex magni adipisci occaecati quasi ex id.", "Visionary static protocol" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Janie", "Davis", "Quia deleniti dignissimos eum rerum et recusandae deleniti. Vitae autem quae ex tenetur et molestiae asperiores. Ut quasi nemo iusto sed molestiae incidunt veritatis alias cumque. Vel id non sit. Qui voluptates animi ex maiores.", "Team-oriented executive info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ramiro", "Langworth", "Deserunt aut quis perferendis. Et qui occaecati laboriosam magnam. Consequatur eligendi inventore modi veritatis sunt quia. Deleniti tempore iusto eos perferendis dicta sapiente voluptas vitae et. Laboriosam eos eos facilis ut repellendus ipsum facilis iure. Dolores harum aut molestiae.", "Quality-focused homogeneous forecast", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Stuart", "Schulist", "Corrupti est reprehenderit accusantium corporis vero nihil. Sapiente distinctio odio alias molestias. Corrupti architecto non. Commodi esse quis ab et et. Dicta autem repellendus qui aut voluptas sed.", "Focused global frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Raquel", "Stamm", "Eos consequatur porro temporibus recusandae enim alias libero voluptatem sit. Voluptatem alias deleniti fugiat distinctio est. Rerum porro voluptate suscipit. Molestiae ut eum repudiandae corrupti.", "Triple-buffered 24/7 product", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darin", "Stanton", "Consequatur ut aliquid rerum itaque et voluptates neque. Et sint aperiam facilis temporibus sunt. Delectus sit quam.", "Fully-configurable 5th generation knowledge base" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Maurice", "Greenholt", "Magni quis exercitationem nemo. Ex ratione vel. Magni reiciendis nulla adipisci.", "Phased fault-tolerant emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shelley", "Kessler", "Ducimus dolorum libero rerum sit quis asperiores aliquid quos. Nulla fugit quaerat placeat et in. Voluptates voluptatum veritatis sed blanditiis at. Inventore minima iure. Rerum a veritatis odio. Debitis eius voluptas error.", "Cloned actuating framework", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Warren", "Macejkovic", "Distinctio asperiores eveniet autem numquam numquam repellat mollitia. Qui est qui debitis delectus et. Et minus quia accusamus eum laboriosam nihil vero.", "Synchronised bandwidth-monitored software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sheryl", "Kunze", "Dolore sequi dolor. A minima magnam sint veritatis in non quo. Possimus culpa et et facilis non voluptatem voluptate est qui. Quia suscipit eum illum molestiae omnis nulla repellat ad.", "Upgradable static intranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Joy", "Conroy", "Et quis possimus aut. Aperiam iste et. Soluta error atque labore doloremque voluptas iusto minus tenetur.", "Enhanced zero administration paradigm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Theodore", "Smith", "Alias unde incidunt quis accusantium. Nostrum doloribus architecto corporis modi nulla neque eos. Aut officiis nam mollitia aut quae minus.", "Configurable full-range protocol", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elias", "Schimmel", "Quidem quo commodi assumenda odio doloremque non culpa earum quia. Aut aspernatur sed neque sed asperiores accusantium nam ut. Ullam sit ut.", "Configurable executive policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lucy", "Leffler", "Doloremque nesciunt nihil laudantium. Sit aut totam quidem. Sint accusamus beatae odio delectus debitis.", "De-engineered solution-oriented benchmark", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sonya", "Beatty", "Qui excepturi id eum temporibus nisi neque. Explicabo nisi quaerat ratione. Et quaerat minima nobis quo eveniet qui dolorem sint. Id sunt reiciendis deserunt aperiam qui vero a ipsum autem.", "Seamless human-resource support", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Allen", "Friesen", "Voluptatem nulla aut eum id. Rerum expedita et eligendi labore. Laboriosam ut nihil sed aut ad quasi velit sint commodi. Ut sit hic natus cum odio unde consectetur consequatur. Illum beatae voluptate tenetur quaerat. Sit hic aut qui unde debitis.", "Team-oriented eco-centric instruction set" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Katrina", "Toy", "Asperiores adipisci eligendi omnis debitis. Aliquam non est facere iure sed. Libero exercitationem tempora fuga. Delectus repellat corrupti in. Sed autem voluptatibus voluptatum dolor nisi id ea.", "Adaptive methodical architecture", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Betsy", "Hermiston", "Dicta est odit sed quia doloribus consequatur. Fuga aut et voluptas quaerat sit nobis quia. Et quas in.", "Automated optimal focus group" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Boyd", "Ledner", "Velit necessitatibus velit aut impedit et laudantium. Est voluptates voluptas itaque nihil nesciunt nostrum dicta consequatur. Eum impedit voluptates eaque consequatur. Sequi est tempore qui et sunt corrupti. Quod consequuntur doloremque minus suscipit non vel dicta sint.", "Operative hybrid orchestration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lyle", "Metz", "Voluptatem velit voluptatem adipisci omnis culpa earum eos. Repellat atque sint qui aperiam aut alias error neque fugit. Dolore odio sit itaque velit.", "Synergized zero tolerance neural-net", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Maureen", "Huel", "Qui suscipit aut excepturi deleniti hic nemo excepturi molestiae. At modi rerum porro est praesentium adipisci itaque mollitia. Nam nihil facere.", "Advanced regional protocol", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jenny", "Skiles", "Nisi eos alias. Ut aliquid quos rerum sunt. Voluptates aperiam aperiam porro repudiandae voluptas qui mollitia temporibus.", "Re-contextualized 5th generation collaboration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Carroll", "O'Conner", "Quae ea cum ullam ratione aut maxime in itaque ea. Enim animi asperiores qui sit at adipisci esse. Esse soluta laborum debitis sit ipsam voluptatibus est. Ipsum in expedita aut aut fuga et aut quaerat repellat. Dolor harum ex dolor cum numquam porro sit earum consequatur.", "Managed motivating knowledge base" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Darla", "Daniel", "Ipsa sit atque mollitia qui numquam minima architecto et. Exercitationem et mollitia commodi ratione nesciunt. Provident eaque ut ut est earum exercitationem. Voluptate et quis enim quo numquam. Quisquam corporis eos molestiae.", "Multi-layered local approach", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Beulah", "Heathcote", "Perferendis placeat voluptate perspiciatis dolores consequatur tempora velit officiis. Similique ut et deserunt enim laborum eveniet. Recusandae assumenda aut. Et cum quis minima quis.", "Focused bottom-line secured line" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Olga", "Rogahn", "Ex illum cum quia dolorum cum enim. Placeat architecto suscipit est et beatae laboriosam animi facilis. Aliquid cumque a cum et sint molestiae dolorem. Qui debitis perspiciatis perferendis qui ut. Quia ex repudiandae. Et ad provident praesentium atque doloremque delectus non et qui.", "Polarised next generation core" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Leona", "Armstrong", "Excepturi id laudantium et praesentium. Quas et voluptatem quia officia. Ut nam velit. Ipsum quis voluptatem tempore perspiciatis fuga qui. Expedita dolores sed voluptatem et culpa qui et. Aut eos aut eveniet dolore non labore fugiat vero.", "Up-sized zero administration toolset", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tammy", "Morar", "Corrupti sed enim molestias et. Odit aut a amet. Dicta aut unde. Quia odit eaque id nesciunt sequi. Quaerat est nisi aut quo nisi est.", "Pre-emptive global adapter", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Orville", "Parker", "Cupiditate autem sit hic quos ea. Expedita esse exercitationem aliquam. Est quis voluptate tempore et et. Hic amet aut neque ut quod et ab cum cumque. Laudantium veniam sunt. Non esse repellat.", "Cloned multi-tasking emulation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Forrest", "Wunsch", "Consequatur nulla molestias vel architecto voluptatibus. Corporis delectus tempore sint culpa animi. Sunt quisquam aperiam repellendus ea. Asperiores eaque magni enim minima sapiente quibusdam sunt enim. Ducimus alias tenetur et perspiciatis exercitationem consequatur eum aut voluptatem.", "Integrated incremental emulation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carlton", "Carter", "Laudantium voluptatibus eligendi. Recusandae rem molestias sequi dolorem quaerat tempora quo. Inventore temporibus aut ea similique a.", "Profound hybrid archive", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Angel", "Stracke", "Vero sit officiis cum sint voluptatem hic quis reprehenderit. Quisquam voluptatem soluta tenetur. Eum non aliquam esse vero inventore harum adipisci deleniti. Suscipit deserunt minima incidunt. Earum facilis eos quia iure quia sequi rerum qui cum.", "Devolved zero administration model" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jean", "Gislason", "Cupiditate enim sequi nihil repellat eos ab. Laboriosam ipsum est et eius omnis optio tempore. In aut velit sit. Delectus ut praesentium aut sequi dolor repudiandae ea nihil. Et omnis dolores fugiat iusto assumenda id et possimus eligendi. Itaque deleniti aut.", "Adaptive zero administration encoding", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Laurence", "Reynolds", "Voluptates quasi nihil praesentium magni aut animi. Veniam praesentium sed et consequatur cum magnam ut aut. Voluptatem exercitationem sunt. Officia quibusdam qui debitis.", "Object-based multimedia installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sonia", "Raynor", "Reiciendis sint earum hic nihil. Voluptate et quisquam autem cupiditate consectetur sunt voluptatum voluptatem repudiandae. Velit blanditiis quaerat quisquam magnam molestiae rerum non. Molestiae est placeat modi earum aperiam quia non ipsa et. Sed consequatur corporis quaerat delectus rem repudiandae. Nostrum ex autem.", "Right-sized even-keeled contingency", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shane", "Krajcik", "Voluptas dicta sapiente voluptatum recusandae aut consequuntur est aspernatur rem. Non qui incidunt at rerum necessitatibus. Assumenda sint aut quia praesentium fugiat.", "Pre-emptive incremental capability", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Renee", "Sauer", "Est asperiores perspiciatis rem reprehenderit esse natus similique sed deleniti. Rerum nostrum blanditiis a quasi recusandae eaque quam et. Sit voluptate qui voluptatibus similique totam officia accusamus beatae.", "Exclusive background algorithm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Noah", "Smith", "Dolorum saepe possimus. Earum sint distinctio id dolore ipsa quod. Natus aliquam corrupti soluta laboriosam. Iure sint omnis praesentium iusto a excepturi ipsa et. Nostrum aut nam provident dolor nisi et. Mollitia qui exercitationem facere sed ratione.", "Synergized methodical attitude", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Renee", "Graham", "Optio aliquam qui eligendi voluptas quis cum. Error harum totam quae non voluptatem. Fugit et voluptatum voluptate expedita. Ut sit pariatur vel.", "Innovative leading edge installation" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf", "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c" },
                    { "01284a83-e74a-4206-aec5-34f385ed20a5", "cb7c76d8-1748-42bd-adcd-b307247781de" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf", "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "01284a83-e74a-4206-aec5-34f385ed20a5", "cb7c76d8-1748-42bd-adcd-b307247781de" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0167720a-14b2-44c8-8f1a-9efa696bf95a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13ec32e0-5cc8-46f7-9991-d3b3b99d4774");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1515cab7-3e7c-419c-a6b9-22492de78540");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d9e5deb-ae38-4a72-b3a5-4b7742f59ce8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8f6bb8-e9d1-4209-ac47-a404b33cd4da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2990a32d-523f-4859-868a-62b3b58511d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ece7cf8-955e-4809-9de0-87997742460d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d83e477-fee0-410b-a764-c9dc659862b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84ccedea-e60b-42ef-92a3-a66d5dc72830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8be73e1d-76d6-479e-856f-03b064d4cf2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "971371a7-feb2-400b-94b3-560c80cca99b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a86b6a8-d4bc-4927-b1bc-2e164f578c35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4781e30-cde1-42c7-ba82-c25232feb9de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaba92a6-b157-4bc0-9bcc-c31dc58d5f2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af0b5655-46d2-4032-93b0-a9d4fb240981");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb773360-6700-4d07-b302-69f33524b6d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f474cc19-cf5b-4fa9-b59a-e269a0303ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea1b38c-87f2-40c7-9f2a-c94287a2329f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01284a83-e74a-4206-aec5-34f385ed20a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb7c76d8-1748-42bd-adcd-b307247781de");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1f64995b-39ec-4c2c-8336-fd5021591e6d", null, "admin", "ADMIN" },
                    { "a40e89f9-a525-408b-b4e0-fe944e27b9ae", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "15e5ce7b-bb2d-4e1e-b1a0-57070bf9becc", 0, "dfc65ecd-178c-48d7-ada2-f8c8a5992381", "may.swift@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM84BNjK+OV3tpNK9B4XziujK8OvqXcqKoZeWp8pnP+vRV9tAHxHX71mXBDfdHlLWA==", "1-667-351-5749", false, "0c2be1d8-fad5-47a8-a70c-acb24f519d49", false, "May.Swift" },
                    { "15eb433a-10ec-47c8-8b75-ad775e128d35", 0, "98f106d1-dde9-4a21-a6d5-b37f660822cf", "earl_cronin85@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKQHXRd61qSuvMJDxadAKwUgiCl76iMkk/fPt7PIUBO9JKiyfXnIwjMCqQZKkPckNg==", "1-498-348-6914", false, "37f622d0-487b-4727-a9dd-88832431efc7", false, "Earl_Cronin85" },
                    { "2461ccb9-c40d-4bd9-b34a-99e7169e132e", 0, "e86751ef-66c6-49f3-9c09-9c8136b88ce3", "margaret5@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMxt9wllR9jJ6lz8RWukqhE0v6NDgGarEL3N2g5WlhInZzYkiRWQwz7oGiR7L29vTA==", "938.569.5854", false, "24b42399-9c80-4c8f-ad3e-d1f9255a32c7", false, "Margaret5" },
                    { "2ff600ae-8ef6-4825-bfc5-44d5f05778c6", 0, "4bbfb20e-db9e-4ff0-91f0-12b7427310a7", "ana2@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMWxhrpp8d4pzByTJ7fKt3+YaHf2Klqr4xY/QgVyW51qWvEj7DGGUc9AUEe6Y8MLTg==", "820-408-9750 x2152", false, "b287370a-e66f-4e35-9205-55022ed0363b", false, "Ana2" },
                    { "3d56b72b-4e3c-4811-993f-c721e1ed1b75", 0, "f24fc573-05e5-4d36-bda8-edc014e0db71", "adrian_swift41@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEA1niQnECgLY/DGZKJT05NdaCLt0tO+hzLLAz7eAPigJRckbKQ29E7pr0l4ezTgFBg==", "680-550-0266 x51712", false, "bb385e56-d139-4e22-bee1-369038694829", false, "Adrian_Swift41" },
                    { "4234d126-d647-4482-9841-77864c658378", 0, "d01b598d-cfdb-4e8e-8f75-c9cd24d312b1", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEB4A1hHudO8UtI56rwmvSvPRygxGvtWk5f5RB47DzFWqZv8NvbxIO3ramKS+SEWOGQ==", null, false, "dadf040f-1b65-44b6-bd78-33a8340f1cb7", false, "librarian@library.net" },
                    { "6954806f-9dd5-4fdd-a722-09d374bcb875", 0, "2367f981-ffb5-4718-a859-ceb4a5fd0998", "angelica.vonrueden@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFjg1ujyjdyjTJeMb/xZa1q1ZAtwORg0HNH739emy4YRPAQ/8QnzTXN4kQkI/YJGjg==", "(857) 587-3975", false, "c58e2edb-cb7c-46ec-8e3d-cf14e3f5a3d9", false, "Angelica.VonRueden" },
                    { "89456b0e-8b1a-469a-ad8f-689f60651fb5", 0, "f1e77abc-95d2-40c2-b5a0-0ea63db16830", "janie_von@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPYsC9/8w1wHdU+oFJHSV9JcwGS+FMNs2FqLFSJwMm/Lz1niyF4lQOZQ3i15vi3RSw==", "529-340-9673 x5460", false, "1eb1105d-9565-4c12-80f4-bb52c3fe1ce1", false, "Janie_Von" },
                    { "9464446a-64a3-4ad0-9d90-c4f100413bfa", 0, "b12fae19-8ecb-48f3-843a-9335d519e404", "darla57@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ7h3Qpkvh5f7L3ZzTm3fnUubl/VgAMvGZqafUxsn1FW7G3F2in7ywbcjUhXsw7vWA==", "(886) 254-6593 x31076", false, "a3574d2f-7ee5-4f35-8467-174c9dda62b5", false, "Darla57" },
                    { "c140fa64-70f7-4a5e-a079-662cb8e7be11", 0, "32f53893-550a-44d6-915c-1d08092fc073", "melanie78@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELuQJAJ3xPLJpRCggbEdieagUA0OIQPESZvABjggcb50f7Tfzua7DqocJ2SkXMMSCg==", "1-282-549-6022", false, "8d1bf404-221e-4919-a3b3-47a8e915b3e0", false, "Melanie78" },
                    { "cc122faa-16b0-487d-960a-2f6da75a7dd5", 0, "ddd6ffe7-115d-476e-abf7-bfc57b1a96d2", "irving_berge@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEN4ucawPmknIi3E/hR971Ttk42JMwuOWUHNxVG7blL9CWx3VhOwSqrzEUVNo+yjGug==", "380.208.3112 x68099", false, "48de68e6-305c-4a36-aac3-d67497698e18", false, "Irving_Berge" },
                    { "e875cd1e-7799-4ab2-b9d7-6330a4910fee", 0, "ef2091ad-4ed1-48f7-a9a2-5d2145a91a6a", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEDiEAAz2BILaZh9+8G08WL9oXSEfuT7eSUwIbxtLaLomgXVVJd2RjQ48tDlkoETV6A==", null, false, "7e310749-eb59-43ed-a719-1f074c4b8bf0", false, "borrower@library.net" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elvira", "Okuneva", "Quos harum iusto aut adipisci illum velit aut aut. Quo rem dicta facilis totam non fugiat aut consequatur cum. Commodi quis voluptatem ea.", "Organized explicit process improvement", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Moses", "Cole", "Atque quod laborum doloribus quia consequuntur est qui dolor. Eaque atque explicabo. Ullam atque sed minima in repudiandae dolorem autem dolor natus. Ex et est quidem natus beatae.", "Face to face local moderator", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Archie", "Brown", "Ut doloremque autem incidunt reiciendis dicta rerum magnam porro. Eum nemo inventore aliquam quaerat nihil animi architecto odit ab. Totam qui porro illo adipisci.", "Sharable zero administration implementation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Heidi", "Runte", "Itaque asperiores itaque nemo cum nemo. Neque maxime consequatur. Totam est atque. Dolor quasi suscipit amet. Saepe et cupiditate qui accusamus corporis harum reprehenderit. Quo est repellendus.", "Centralized 4th generation project" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jacqueline", "Baumbach", "Voluptate quidem iste quo voluptatem adipisci ratione aut. Ex vitae ut rem quos quia ullam enim nam. Enim assumenda ex ea consectetur eum.", "Fundamental incremental superstructure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Yolanda", "Hand", "Velit et iusto beatae ullam quia ipsam. Exercitationem voluptas vel molestiae cupiditate saepe. At qui qui. Dolores pariatur consequatur magnam.", "Profit-focused client-server open system" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Danielle", "Kunze", "Qui amet aut vel qui aliquam. Neque aspernatur neque et cum cumque voluptatem nemo illum. Explicabo error omnis voluptatem magni pariatur. Sit similique fugiat et. Amet perferendis et aperiam vitae suscipit provident aperiam.", "Mandatory global artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Cheryl", "Schamberger", "Laudantium voluptas ullam minus eaque. Voluptas facere libero placeat tempore eveniet consequuntur. Et quo vel veritatis tenetur voluptas dolor occaecati eaque. Reprehenderit sint quibusdam veritatis. Ipsam doloribus accusantium fuga est et ratione ex.", "Object-based web-enabled contingency", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Shane", "Franecki", "Atque architecto aut distinctio provident dolores labore laudantium nesciunt minus. Et rerum ad. Aut aut excepturi et sed. Aut ipsam non. Sapiente maiores amet in natus velit accusantium voluptas aut dolores. Labore qui voluptatem perspiciatis ut ipsam quo.", "Triple-buffered 24/7 contingency" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ernesto", "Dooley", "Magni consequatur odio. Veniam pariatur et provident nemo aut ea nemo. Doloribus est sint sed ab dolorum inventore mollitia enim. Id impedit aut sit autem dolore sunt. Expedita rerum qui.", "Visionary 4th generation encryption", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tammy", "Yundt", "Facilis dolores itaque hic a velit dolor aliquam. Voluptates animi at dolores rerum laboriosam. At ea consectetur harum ipsam autem ab et et debitis. Laboriosam quo ipsum qui. Non adipisci eos non omnis iure praesentium et in.", "Re-contextualized human-resource alliance" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Fred", "Gerhold", "Nihil ut autem sed aut beatae sapiente ut quo et. Ipsa vel beatae ipsam autem veritatis quos eveniet omnis. In et laudantium mollitia reprehenderit ipsum voluptatibus sit. Numquam autem exercitationem sit delectus nesciunt.", "Implemented non-volatile open architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Freda", "Goodwin", "Et est aliquid repudiandae error non laboriosam molestiae aliquid labore. Nulla minima dolorem sit aliquam numquam consequuntur. Quasi temporibus non voluptas eligendi possimus saepe ad.", "Cross-group modular initiative", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sheldon", "Hessel", "Nostrum eum libero neque voluptatem possimus. Iste eos dolorem sed. Nihil unde error dolorum eos placeat perferendis qui iure.", "Cross-platform homogeneous policy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Louis", "Mills", "Ea et occaecati praesentium consectetur quo cumque et. Harum expedita veritatis. Quam asperiores expedita veritatis qui. Hic aut rerum deserunt magni nemo similique quos cupiditate voluptas. Ab perferendis omnis voluptatem est saepe.", "Re-contextualized regional projection", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ramon", "Borer", "Sapiente sint provident laudantium quam at et consectetur dolores. Fugiat impedit enim officia et. Eos dolores laborum ut. Est enim earum inventore voluptatem quia. Voluptatem enim quas voluptates iste ullam eius.", "Future-proofed discrete data-warehouse" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Luis", "Konopelski", "Sed eius autem et dolore consectetur consequatur ut omnis. Nisi facilis dolores et aut. Expedita aut ad praesentium officiis. Explicabo unde id pariatur quos tenetur nihil ex nihil dolorum. Illo dolorem tempore ab velit velit est et beatae. Ut sed non ut nulla rerum.", "Virtual interactive intranet", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Margaret", "Beatty", "Tempore amet quo voluptas sit placeat quas fugiat. Autem et laudantium. Dolores est tenetur.", "Integrated stable internet solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sheldon", "Schmidt", "Quo qui officiis impedit. Ullam quod autem blanditiis sit ducimus. Numquam quos ducimus et accusamus.", "Multi-tiered non-volatile strategy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Harold", "Ferry", "Cum aliquid eos rerum laudantium necessitatibus ut exercitationem doloribus. Tempore et dolorem nulla dolores numquam doloremque. Aperiam deleniti atque molestias qui aliquid. Et eaque quia quam dolor et sed voluptatem est expedita. Harum voluptatem voluptate eos et qui. Quis aperiam voluptatibus veniam sit eius voluptas.", "Integrated bandwidth-monitored orchestration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Carl", "Schiller", "Quam nisi qui. Esse blanditiis sint similique dolor consequatur nihil ab sit. Voluptas doloribus sequi molestias ipsa fugit dolores recusandae harum. Similique molestiae non repellat perspiciatis voluptatibus qui molestiae.", "Realigned responsive solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dustin", "Predovic", "Quasi non aliquam dolores animi neque cumque molestiae. Sit accusantium molestiae illo omnis voluptatem non. Quo aut ullam incidunt consequatur rerum. Repellat rerum voluptates assumenda omnis.", "Reduced multi-tasking firmware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Zachary", "Larson", "Sint totam facilis ut velit. Et totam deleniti debitis tempora maiores et dolore ex. Porro necessitatibus totam laboriosam quia. Repudiandae quae saepe. Sunt soluta ab ab quaerat voluptates voluptas quis incidunt sed.", "Focused system-worthy success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shelly", "Lesch", "Perspiciatis possimus adipisci eum ducimus cum. Ipsa a mollitia quae est fuga earum. Qui voluptas earum voluptatem dolorem. Sint atque et sunt ut et harum et.", "Quality-focused contextually-based task-force", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Latoya", "Beer", "Iste similique eum voluptatibus libero saepe eum sit explicabo delectus. Voluptatem porro qui odio veritatis dolore dolores voluptatem. Autem earum earum deleniti. Earum enim recusandae quaerat. Aperiam id nulla libero eum porro libero sed ut.", "Object-based even-keeled flexibility", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Evan", "Donnelly", "Omnis molestias voluptate quis perspiciatis omnis exercitationem quae id. A adipisci nulla aut quia. Ad quaerat qui et. Quaerat quam aperiam dolor adipisci amet. Non distinctio numquam est.", "Grass-roots fault-tolerant leverage", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rachel", "Gutkowski", "Dolores fugit facilis amet. Earum aliquid voluptates doloribus cum quia. Hic repellat rerum aut quia iusto ratione. Voluptas fugit voluptates odio distinctio quia.", "Vision-oriented attitude-oriented protocol", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bert", "O'Keefe", "Voluptas voluptates corrupti est sit voluptatum provident mollitia ut. Maiores fugiat consequatur alias labore odio. Sunt placeat consectetur repudiandae dolorem voluptatibus ut. Beatae deleniti perferendis aut quas sint. Esse est dolore vel velit sint necessitatibus exercitationem. Dolor ut nam neque adipisci eligendi aut officia.", "Persistent background time-frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Clifford", "Dare", "Rerum ut ut nesciunt exercitationem culpa sunt quia. Quam voluptas et vero nostrum. Minima eligendi odio delectus qui consequatur dolores dignissimos.", "Upgradable optimal superstructure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Emilio", "Donnelly", "Qui maiores labore. Ipsa placeat aspernatur ratione aut blanditiis. Nulla nihil similique nisi sint repudiandae a et. Iste aspernatur assumenda consectetur. Quis modi neque. Sed nobis et distinctio.", "Reverse-engineered secondary concept" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Becky", "Daniel", "Numquam corrupti eius voluptatem fugit omnis quam distinctio dolore consectetur. At illum laborum tenetur. Error molestiae aspernatur natus.", "Centralized 5th generation success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mitchell", "Stamm", "Ad culpa eos delectus a dolores error dolorum quod quis. Ut maxime in veritatis necessitatibus consequuntur quis quidem aliquam. Quasi mollitia dicta minima nostrum aut ex. Eius recusandae non dolores architecto.", "Extended bi-directional analyzer", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lorenzo", "Dibbert", "Quo velit eius. Minus excepturi repudiandae. Cum iusto velit laborum ut placeat fugiat. Fugiat qui qui ut voluptas quod fugiat nulla eum.", "Stand-alone executive support", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sadie", "Reynolds", "Quibusdam eos nostrum unde quisquam est. Error sunt in quia iure autem autem et doloremque. Laboriosam libero quisquam.", "Optimized attitude-oriented info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Brett", "Medhurst", "In libero dolores iusto in quidem. Ab eum quia velit quod doloribus corrupti rem corrupti et. Libero culpa aspernatur quidem sunt pariatur perferendis velit quas. Qui voluptates aliquid fugit qui id et fugit unde.", "Fully-configurable interactive monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Annette", "Ondricka", "Qui et laudantium quia eum placeat. Aliquid et quia ut. Modi ullam quia. Aut eligendi adipisci. Eos doloremque similique similique non quam enim et ullam. Repudiandae aut earum perspiciatis unde sed iusto minus.", "Compatible bottom-line firmware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Elizabeth", "Ferry", "Aliquid totam et minus sapiente cupiditate voluptatem. Blanditiis est aut in maiores doloribus laudantium. Adipisci tenetur voluptate error debitis. Ut distinctio adipisci non. Sint mollitia qui.", "Optional holistic policy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gladys", "Torphy", "Fuga quis facilis qui voluptate. Labore voluptatem eos perspiciatis suscipit beatae quae id molestiae aspernatur. Ducimus excepturi ipsum eum voluptates animi iste.", "Persevering needs-based flexibility", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Alberta", "Bogan", "Voluptate voluptas omnis et. Recusandae provident qui fugit voluptate ducimus maiores. Cumque voluptates et est veritatis. Nisi vel et incidunt corporis qui temporibus quae esse.", "Centralized systemic adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lee", "Monahan", "Cum vitae amet ullam magni commodi. Cum nobis non dolor fugit excepturi aliquid. Ut accusantium eveniet et quia quia sit accusamus. Facilis inventore impedit. Consequatur asperiores similique sed et eos maxime.", "Networked responsive forecast", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Pauline", "Kuhic", "Molestiae quidem quisquam aspernatur. Animi voluptas ut. Dignissimos suscipit autem culpa nemo ratione.", "Cloned regional workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Israel", "Kautzer", "Nostrum placeat dolores quis in voluptatem. Impedit earum numquam ab. Et sit optio sint nulla consequuntur consectetur quia nobis ea. Voluptatem temporibus a. Quidem qui quia non a. Atque nobis necessitatibus totam nisi et.", "Organic multimedia archive" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rolando", "Steuber", "Repudiandae architecto mollitia voluptatum. Repellendus ratione aliquam. Odit enim voluptates vel dolorum ea ab ab et.", "Distributed impactful functionalities", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Abel", "Pollich", "Harum molestiae nesciunt dolor quia. Voluptatum autem ullam enim quisquam non qui. Cumque qui rem explicabo fuga rem.", "Versatile leading edge challenge" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 45, "Pablo", "Adams", "Quibusdam unde quam harum aut et. Sed eos laborum aut maiores praesentium quo velit ducimus. Eum officiis qui sed qui omnis eligendi. Aut quibusdam doloremque cum aspernatur quibusdam dolores.", "Future-proofed modular task-force", false },
                    { 46, "Jay", "Senger", "Modi vero ab facilis quis quia quis iusto ad. Impedit omnis eligendi id non et placeat in eum. Nemo exercitationem amet dignissimos ab nisi laborum. Enim excepturi nihil numquam cumque id blanditiis qui. Voluptatem aliquam repellendus officiis vel.", "Customer-focused clear-thinking focus group", true },
                    { 47, "Vernon", "Collins", "Est libero asperiores et pariatur rerum aliquam est voluptatibus in. Culpa impedit non cupiditate illo non. Voluptates adipisci temporibus quis nesciunt et nesciunt quam. Amet quo molestiae qui excepturi ea dignissimos ad enim aut. Quae aut sed animi velit et. Impedit magni sit.", "Fundamental stable forecast", true },
                    { 48, "Blanca", "Veum", "Id aliquam sunt. Voluptatem maiores est nisi quam libero accusantium deleniti. Corporis et natus aspernatur molestias repudiandae delectus aut tenetur fugiat. A itaque expedita sint architecto laborum occaecati. Dolores sit iste expedita aliquam ipsum iste.", "Self-enabling analyzing ability", false },
                    { 49, "Colleen", "Skiles", "Eos neque odit temporibus illo sed quaerat alias animi vel. Voluptatibus sit quaerat unde qui qui. Enim et et iste. Animi voluptatem rerum consequatur nam. Consequuntur id inventore laborum tenetur eos quis.", "Multi-tiered leading edge instruction set", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1f64995b-39ec-4c2c-8336-fd5021591e6d", "4234d126-d647-4482-9841-77864c658378" },
                    { "a40e89f9-a525-408b-b4e0-fe944e27b9ae", "e875cd1e-7799-4ab2-b9d7-6330a4910fee" }
                });
        }
    }
}
