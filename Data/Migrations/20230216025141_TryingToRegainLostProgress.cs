using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TryingToRegainLostProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3cc7544-b397-46ab-9db5-312e7d79512b", "1d15b6c6-a87b-49bc-8fda-c374da77b4b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5ccbfbe-422a-4b27-a8da-3f19cb372cbc", "2fe2f128-950b-456b-bed0-22bd2c6ee970" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "062bd886-4002-4a43-bece-fa51b3917cb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "197e0625-9c5e-4046-a117-3a1863084354");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1ab1af46-553a-48bd-b9cd-483b52796c4c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23feaa12-3ca9-4880-aea9-a455ce8305f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3474f72f-3eaf-44c9-b820-7c93b8235f15");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "35f5f433-8e89-4321-8cac-fa846e23348e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42ded97d-d17f-4636-ac49-1f41c358f114");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "448d5a5d-7806-45ef-940e-35881a723388");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47915afa-6d61-45b8-b52c-802969f30a51");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ace8ab6-7890-4b88-b255-73ee75c2d517");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5fb03791-44fa-4d97-896e-0b60d2b4c902");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93f155fa-5ab8-4389-81c6-6d237b24ef64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b63ed0a1-c617-4ba7-8865-60c1e1030555");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0fe901b-ca56-4265-af36-ae5707657882");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da353f27-40c4-4cf3-b5f8-6b462560ca78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dc911db3-8710-42b9-a5a7-e08a08d9a2ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e6ee688a-e9cf-47bd-aac6-e705102168ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e79ce6fe-4a21-4949-9a77-2bede44eb386");

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

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3cc7544-b397-46ab-9db5-312e7d79512b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ccbfbe-422a-4b27-a8da-3f19cb372cbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d15b6c6-a87b-49bc-8fda-c374da77b4b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fe2f128-950b-456b-bed0-22bd2c6ee970");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Elijah", "Beier", "Ut voluptas neque rerum adipisci. Veniam fugiat repellat non. Non libero sapiente harum nam excepturi. Ut animi officiis perspiciatis id corporis recusandae repellat voluptate sit.", "De-engineered bi-directional database" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marsha", "Rosenbaum", "Officia atque id aut sit sit illo sunt est. Accusantium accusantium et expedita explicabo. Veniam voluptas quia placeat fugiat placeat. Architecto velit ipsa consequatur alias eveniet tempore numquam inventore voluptatibus.", "Adaptive impactful matrix", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Olive", "Windler", "Voluptates alias fugiat odit laudantium quae iste eos. Ea et autem maiores odit pariatur optio ut eum et. Ab dolorum aut voluptates dignissimos voluptates et soluta impedit. Dolorem labore voluptatem placeat ipsam culpa distinctio voluptatem voluptas. Est odit et explicabo. Ea fugiat voluptate rerum eveniet possimus porro culpa accusamus sunt.", "Function-based bi-directional framework" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Maria", "McCullough", "A et aut soluta non nihil omnis ab culpa. Repellat magnam eaque sint amet blanditiis odit nemo nostrum. Aliquam molestiae iusto temporibus praesentium qui praesentium quia. Aspernatur qui id qui. Consequatur reiciendis eligendi facere voluptatem.", "Reverse-engineered client-driven monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jody", "Walker", "Dolor eaque rem qui iste molestiae impedit est possimus. Corporis blanditiis consequatur ut rerum est aut quaerat. Et consectetur molestias corrupti quae error explicabo natus doloribus et. Culpa in sed itaque ut eos cupiditate. Beatae illum id magni nihil.", "Multi-layered solution-oriented instruction set" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Annie", "Denesik", "Quia optio ab inventore. Voluptatum sed dicta. Explicabo atque delectus nam. Repellendus ex velit eum et. Est asperiores quia dignissimos quae magni. Sint est et repellendus amet.", "Operative well-modulated synergy", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Arturo", "Dach", "Consequuntur et est vel exercitationem occaecati qui nemo officia occaecati. Dolor delectus adipisci aut molestias. Laudantium qui quia amet.", "Centralized reciprocal attitude", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jackie", "Haag", "Labore voluptas in aut amet sunt quo quae itaque. Expedita rem corporis excepturi necessitatibus. Non sint non modi animi iure dolorum ipsa.", "Customer-focused intermediate strategy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Timmy", "Konopelski", "Perspiciatis sunt ipsam facilis rerum. Nemo veritatis voluptate minima quam eveniet ut sit. Beatae maiores a quia corrupti repellendus. Dolores doloribus labore culpa beatae nobis. Corporis ut deserunt non illo cupiditate expedita nemo distinctio.", "Cross-platform 24/7 hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Becky", "Abbott", "Quibusdam numquam qui nisi voluptatem eveniet nobis suscipit consequuntur. Quis dolores aut. Est aspernatur iure doloremque.", "Profound didactic success", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sam", "Beatty", "Quia eaque sapiente in. Quia laborum sequi occaecati aut. Nobis debitis atque ut. Dicta aperiam nulla perspiciatis quae nisi voluptatem in.", "Visionary needs-based artificial intelligence" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Archie", "Feil", "Velit occaecati aperiam voluptatem nihil minima qui. Qui provident in quis ut. Sed itaque soluta est sint eveniet ea et. Laudantium necessitatibus sequi.", "Profit-focused reciprocal task-force" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Elmer", "Green", "Autem ut ea beatae repudiandae natus nemo est et. Esse exercitationem architecto distinctio. Fuga odio sed sint quis. Asperiores optio labore ipsa ut iusto non omnis nobis voluptas. Et labore voluptatem et et. Dignissimos quibusdam corporis quo repellendus cupiditate.", "Face to face fresh-thinking methodology" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Grace", "Collier", "Quibusdam quis sunt architecto non nihil. Rem expedita ex quia aut facere est rerum voluptas asperiores. Vero assumenda animi iste sunt dignissimos sint sed. Et aut autem voluptatum enim totam.", "Vision-oriented human-resource definition", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kyle", "Carter", "Id eum soluta nam sunt rerum occaecati unde temporibus. Mollitia distinctio voluptatum soluta fuga. Dolore cupiditate aliquid voluptatem et aliquid dolor ut. Itaque qui qui.", "Profound neutral leverage", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Judith", "Gutkowski", "Voluptas voluptatum minima voluptas rem. Non eos delectus iure nemo est amet vel. Commodi est reiciendis quae debitis praesentium pariatur. Magni rerum pariatur perspiciatis nemo harum vitae non expedita.", "Mandatory coherent success" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "60de7e58-232d-4daf-9bac-f634b4bd2db8", "5f5c6238-f4ba-4c07-b507-54e49d15ce15" },
                    { "0089b683-549c-4b35-a178-9157b5598173", "9b712793-d901-4fb0-be02-2d1e09b182d9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "b3cc7544-b397-46ab-9db5-312e7d79512b", null, "borrower", "BORROWER" },
                    { "d5ccbfbe-422a-4b27-a8da-3f19cb372cbc", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "062bd886-4002-4a43-bece-fa51b3917cb7", 0, "ff388a70-b880-47e1-b001-bbd2f1abe91f", "vicky.nader@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMFB+6huG7yoY7ZPmSSOeipThSFliyK5zn4AAAmn8FLlua2Ht/9bBb3RtElla6JFUA==", "650-902-1359", false, "c1e6b679-28bf-4376-82a2-b915a7491287", false, "Vicky.Nader" },
                    { "197e0625-9c5e-4046-a117-3a1863084354", 0, "e28c09cd-3672-4e45-bcdf-a9c54578f4b3", "clayton.nikolaus63@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECnWuRBUoyxGcWjgjEWol/5KvofeGOFz0LtP1gQf4jpalV0ULCcsKZ7/yWl9DqNPvA==", "849-770-4060 x6758", false, "ee189518-da8c-4bf2-9c7b-017aff89d70c", false, "Clayton.Nikolaus63" },
                    { "1ab1af46-553a-48bd-b9cd-483b52796c4c", 0, "99117165-1ab8-4450-a9b3-7902ffe029fc", "enrique61@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPh8KseuyFZ5rb/QRsUbvXQJfj89bPitgippwosokuSGTBM0T90UvlFH2EtfWWWXpw==", "223.754.1535", false, "af866864-32cb-4c8d-9537-4999f203c5f7", false, "Enrique61" },
                    { "1d15b6c6-a87b-49bc-8fda-c374da77b4b7", 0, "44474aad-669f-4764-9d11-527a46463324", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEKr+Le4B/c0ROci1FWEyyN5PEKhY6ziN+6v4NtNFlVlLh0EGrVYSX9UFGwd2w8+/3Q==", null, false, "be840050-a503-40b5-9dd3-e95360929b13", false, "borrower@library.net" },
                    { "23feaa12-3ca9-4880-aea9-a455ce8305f1", 0, "d67d7e64-9346-4679-8883-210ba0cfd5bd", "joyce31@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECDZNnBB2fQA6oyYY/8I5TqEDhwZS/TZcSHz1LTWSKEXx/9ADiU52l5boyu2SxyXUQ==", "1-999-347-5967", false, "ba7da086-9f9e-43e8-b1a2-afc16c022886", false, "Joyce31" },
                    { "2fe2f128-950b-456b-bed0-22bd2c6ee970", 0, "31c8aadd-0b0b-4365-8768-b8f60a9aeed2", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAELJKvB3KlbJzP3xlupT4jyTUqrYJYqnxQI2q7pxDkTmXNBg5YxupMwH1qTT2/8kYxA==", null, false, "5cb665b2-ca8e-4372-a4f9-95a4affb5cd8", false, "librarian@library.net" },
                    { "3474f72f-3eaf-44c9-b820-7c93b8235f15", 0, "3d775eb4-6d0e-4acf-8141-183bcd6c6f1a", "jody_boehm@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOga8jByV29Gx0nWSSn/DsC+d0VWDvz9YuY1mqLUTp/ny+vn5cseFXQauDoqtsB6Mg==", "554-624-9174", false, "f88f28c1-ac1b-43a3-a09c-646a31396220", false, "Jody_Boehm" },
                    { "35f5f433-8e89-4321-8cac-fa846e23348e", 0, "3147f1d9-b0c3-414d-9616-c1a017a80116", "crystal.gleason@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPZX17141PvMO6jGAKxYEoZS4J99yTuHSjjtdnCovmwDz07oi30wz36JSIZJiyF+1g==", "(387) 201-8600 x47928", false, "d58de399-b433-4417-874e-1c9107b2aadc", false, "Crystal.Gleason" },
                    { "42ded97d-d17f-4636-ac49-1f41c358f114", 0, "e95e3f73-e393-454c-9ff4-6e4acbded983", "hattie80@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEN30dB/B/vRZ1lgAM+7O9/UjjrU7zEKqIskNfkhh89zLi6O090vsLsbGREo487Fu8A==", "570-917-3876", false, "c7437d56-00dd-4a87-834e-65d9ca49c39a", false, "Hattie80" },
                    { "448d5a5d-7806-45ef-940e-35881a723388", 0, "083d612c-32da-4630-a7b2-8de8b1f58925", "sabrina_bergstrom77@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGG7QKjJbeiW7pQSPlLg/DlG7rm7O2JsDcK2CHASOX7EB1pPNftnBvYWLl4Du2Ovrw==", "747-326-5863", false, "3099ef2f-f30b-4184-8460-3d3b1dd25722", false, "Sabrina_Bergstrom77" },
                    { "47915afa-6d61-45b8-b52c-802969f30a51", 0, "39c473c3-6d3d-4fb2-8efe-fcff8761051f", "jessie25@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM9d3DwNqc97dUMUSGww74SXJEnI/89L/hkRH6GdoTFxwEM6NX8hslbr7xp0RCxA0A==", "1-833-386-4578 x5371", false, "e26eb3d7-a626-4f1c-8a37-33643922c9ce", false, "Jessie25" },
                    { "5ace8ab6-7890-4b88-b255-73ee75c2d517", 0, "4d61ac1f-ff98-4fc4-b51f-0e46e41c5881", "toni90@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBb67qf20BfFEY9CCMyL6EP15CYvR4XbdilP5BaWWkxF5jeA4Nf51y3t3HzYgN+63w==", "588-441-0901", false, "904e02e9-0d49-4f39-9dea-394775ced163", false, "Toni90" },
                    { "5fb03791-44fa-4d97-896e-0b60d2b4c902", 0, "6b65e63d-5335-4a5d-b4b6-d2a4fa05094b", "rachel32@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEK/xU/YfuhseEt2V5//tuKex55DryPwfwURsCwAl+kwHMUe7W/67hhk8IHoV7bTL4w==", "848-623-9169 x88351", false, "6ae53623-3b62-4a00-b7f7-303fdc9c94dc", false, "Rachel32" },
                    { "93f155fa-5ab8-4389-81c6-6d237b24ef64", 0, "018e73ed-e49b-49d0-9197-28edf4aab37c", "nathan28@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECeUshh4prmfFGGaUC5nqYUWXgdm9LG2BDjz/12owFguZuYf2rKEGIR4jaYbzhc26Q==", "1-728-491-9341 x10633", false, "ede147e2-dfaf-4b08-a9cb-c4b498b3b595", false, "Nathan28" },
                    { "b63ed0a1-c617-4ba7-8865-60c1e1030555", 0, "d64d3c9e-022e-4cb4-aa84-72dd59937732", "bradford99@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJh70fwZ+eza8u9WjA3ZMNmgvvGIzuaoU+qyp5NIB76JTfRYlvcmh2GZtTTKBdDyTg==", "384.393.8053 x7626", false, "ee677a6a-2d9b-42b7-96c8-20bcce68502f", false, "Bradford99" },
                    { "c0fe901b-ca56-4265-af36-ae5707657882", 0, "203c51ce-4c4e-46ac-86a3-347e237a695a", "julio_oreilly60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENFDx8eykux57vX4FldA7QiqxWQpv/CqLbtSv/pSnTrEgot7sTqFQjn5V8TJlqMc0w==", "923.488.7809", false, "6f798c55-890c-4579-83b3-49f41fd0afa9", false, "Julio_OReilly60" },
                    { "da353f27-40c4-4cf3-b5f8-6b462560ca78", 0, "28675be3-61ab-4e16-b20b-036b43658391", "crystal51@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBW6Q0HXTznTU+3XeKT8M2yvOJWvI582ttQYyi3jjA1nD4SJnR+dkxeu1p5Ub8BBlA==", "424-860-0794 x116", false, "c590398a-ad0a-49ca-b44c-0510a631c72f", false, "Crystal51" },
                    { "dc911db3-8710-42b9-a5a7-e08a08d9a2ca", 0, "e3c0855a-3b8f-4cfb-9e3a-00110ab5230d", "earnest.fritsch@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGnR3uET6BsgoEdvxTkEh6ZHyP8EpIt8PTUB6jnALrkQaoAD+4Lg5/mra0HmL4pNTQ==", "294.246.1728", false, "edc72d88-0f76-4c03-82bb-c42428ed6309", false, "Earnest.Fritsch" },
                    { "e6ee688a-e9cf-47bd-aac6-e705102168ae", 0, "eb48eb43-f3b6-457c-8ab6-1278b8933cc5", "sharon_paucek91@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAzbZr6MNAZ94HZBEylfZtnck3Ci+LnsY0HYg+uhfCoUVIm8w/IvYjEiV3lHnbVHtg==", "(798) 719-8948 x7622", false, "b4b82494-12db-48a1-907c-651f3d270339", false, "Sharon_Paucek91" },
                    { "e79ce6fe-4a21-4949-9a77-2bede44eb386", 0, "b32e5f9f-d94c-4ace-9c75-7349355b23c3", "nicholas.kihn@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOlvVBd58vXsdFfISBGpU+1RIVD0p9ckZhmQ7ZD3EzGKggnaYVBdyVr2I+3Fx3g2lg==", "1-351-693-6440 x6816", false, "45a153c5-07e2-4e24-b40c-15683aaa3053", false, "Nicholas.Kihn" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nicole", "Christiansen", "Natus similique reiciendis. Nulla minima beatae est qui natus dolor. Doloribus nobis rerum dicta distinctio. Maxime eveniet veritatis officiis sed est molestiae quam nobis.", "Programmable contextually-based toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lorene", "Goldner", "Ut eos repudiandae ducimus. Molestiae sunt quasi vel. Placeat quisquam voluptas voluptatem.", "Adaptive bi-directional policy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Chad", "Hyatt", "Quis est et excepturi vel. Beatae distinctio quibusdam. Deserunt natus et architecto eum eum dolores facere et accusantium. Excepturi et et pariatur ex.", "Future-proofed 5th generation service-desk", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Carl", "Hartmann", "Impedit ratione est in. Exercitationem et non alias ut voluptatem animi consequatur voluptas. Animi temporibus accusamus veritatis. Nesciunt aut aut eos ut magni consequatur et fugiat eligendi. Nemo adipisci est esse fugiat.", "Fundamental upward-trending productivity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Karl", "Kertzmann", "Molestias et magni impedit libero sit consequuntur aut. Quia quas molestiae in dolorem ipsa eum reiciendis aut. Repellendus officiis illo ut. Ullam iure itaque earum et. Suscipit odit voluptas voluptas et excepturi officiis.", "Robust next generation array" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kelli", "Heathcote", "Molestiae deleniti perspiciatis ad aut voluptatem. Tempora necessitatibus qui rerum. Vel enim animi et. Ea tenetur ab quam impedit.", "Centralized hybrid customer loyalty" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Carla", "Kautzer", "Qui deserunt nam adipisci corporis et facere voluptate et. Consequatur et voluptatem in ea est dolores impedit. Maxime velit quasi. Inventore in quam quis. Temporibus atque magni et commodi et. Deserunt aut vel dolor.", "Cloned zero tolerance encryption" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Cassandra", "Hane", "Dolor sunt sed itaque. Dicta tempore neque repellendus praesentium magni tenetur. Consequatur dicta esse reprehenderit in doloribus doloribus necessitatibus unde a. Unde consequuntur itaque explicabo corrupti omnis saepe nemo harum. Impedit qui delectus.", "Open-source local artificial intelligence", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Caleb", "Yundt", "Repellat omnis rerum ut dolores aliquam est dolores. Deserunt quae voluptas dolores. Voluptates veritatis maxime quis assumenda tenetur.", "Reactive uniform migration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Janet", "Mraz", "Quaerat aut asperiores. Et dolor maxime. Quas voluptatem odit id id nesciunt blanditiis. Quod reprehenderit quisquam voluptatum. Aut dolorum nisi dolorem. Aut exercitationem necessitatibus suscipit quaerat cum sed.", "Fundamental well-modulated internet solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Floyd", "Nitzsche", "Iste et placeat dolores omnis laboriosam quae consectetur. Reiciendis aut autem similique doloribus officiis. Reiciendis et ut eum sit aliquid sunt. Eos eos autem hic ut. Et nobis illo qui aspernatur eaque. Neque molestiae qui odit earum doloremque.", "Organized intermediate system engine" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Billie", "Kessler", "Nisi a aut reprehenderit vitae voluptatem totam dolorum et sint. Accusamus corporis molestiae vitae id nostrum sit. Ut alias distinctio. Sunt ex itaque maiores veritatis consequatur qui.", "Total local application", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Leonard", "Buckridge", "Sed at autem deserunt sint inventore qui. Sunt ut sequi quod reprehenderit praesentium voluptatum ea explicabo. Et odio error odit provident dicta. Optio et dolorum. Ut doloremque numquam sapiente animi animi. Et aut odio.", "Optional didactic software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Evan", "Wilkinson", "Sapiente ab perspiciatis cupiditate. Saepe aut doloremque corrupti. Animi facilis possimus exercitationem nesciunt architecto. Eum sapiente sed et. Assumenda sequi et quas esse.", "Re-contextualized scalable hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terrance", "Cole", "Velit rerum aut veritatis labore. Quod ipsum id. Laborum architecto quaerat architecto asperiores ut qui saepe porro corporis.", "Versatile optimizing workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bethany", "Senger", "Suscipit soluta autem quod sint qui vitae nisi. Et facilis sed. Magni optio aperiam omnis dicta similique cumque et veritatis. Voluptas error laudantium labore eum aut illo debitis. Voluptas deserunt quo. Qui quo nisi ad.", "De-engineered actuating service-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Raymond", "Sawayn", "Libero iste a ipsum. Libero accusantium distinctio quaerat et assumenda dolore et accusamus aut. Cumque est non.", "Decentralized grid-enabled benchmark" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Amanda", "Davis", "Non commodi nam doloremque est. Ratione fugiat veniam magnam. Eos accusamus eligendi exercitationem sed natus pariatur repellat assumenda vitae.", "Realigned executive budgetary management", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Earl", "Price", "Amet repudiandae dolorem alias. Quis excepturi consequuntur illo autem similique provident repellat quas dolor. Sunt fuga qui est sapiente ullam aut sed perferendis. Optio neque tenetur. Quas beatae minus dolorem architecto id.", "Universal system-worthy encoding", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Irene", "Turner", "Dolor quia et eius ullam maxime vitae. Omnis dolorem fuga. Eveniet aliquam maiores quidem quas incidunt voluptates quia. Est magni consequatur quam. Ullam qui et in fugiat id. Velit minima aut animi sit voluptate.", "Cloned multi-state archive" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marco", "Emard", "Porro aut exercitationem distinctio velit officiis qui et. Quae quibusdam vel. Ex et quos reprehenderit et deleniti. Pariatur non sed ipsum. Earum omnis veniam et. Molestias labore et sint distinctio et autem a.", "Reactive impactful neural-net" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Paula", "Sauer", "Qui beatae vel dolor. Quia ut aperiam. Occaecati qui doloribus.", "Diverse modular structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rita", "Bayer", "Sint officia nesciunt. Labore necessitatibus aut inventore quis ipsa porro id. In atque quas. Non rem non ut.", "Vision-oriented analyzing toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Martha", "Boyle", "Molestiae qui nulla architecto. Consectetur non sit quod qui. Deserunt sequi illum ut labore voluptas saepe sequi. Nihil ducimus vel architecto qui. Nulla commodi velit ducimus occaecati eveniet. Esse dicta ut perferendis animi doloribus non.", "Horizontal holistic leverage" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Wilbert", "Mosciski", "Consectetur ea aperiam labore. Consequatur omnis quae mollitia ut praesentium voluptatem blanditiis impedit. Consequatur quos aut eum. Ratione porro libero molestias ut ab atque. Sit et saepe nulla aliquam ratione.", "Future-proofed dedicated Graphical User Interface", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Philip", "Davis", "Ut corporis molestiae qui molestiae molestias et. Non quia adipisci et id magni molestiae enim ut ut. Nesciunt repellat et vel beatae quia omnis. Vero fugiat commodi reprehenderit aspernatur corporis omnis et. Non numquam non enim enim id eius.", "Mandatory dynamic monitoring", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ross", "Harvey", "Qui sunt magni magnam perspiciatis earum iusto quia. Voluptatum doloribus suscipit aliquam qui assumenda assumenda adipisci ratione. Vel voluptas ducimus.", "Focused responsive adapter" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 28, "Jesus", "Farrell", "Omnis nihil sint. Enim ut nihil tempora vero officia soluta excepturi dolorem. Hic mollitia omnis mollitia porro odio dignissimos repudiandae sunt. Explicabo ipsa numquam qui provident saepe. In aspernatur sed sed culpa dolorum et. Dolore vel quam sint est debitis quo tempora laboriosam amet.", "Exclusive content-based throughput", false },
                    { 29, "Salvatore", "Schumm", "Possimus laudantium ipsam unde. Aut reiciendis quidem rerum illo doloribus corrupti eum. Iste pariatur ut modi illum totam numquam minima animi provident. Rem amet reprehenderit et rem neque. Qui laudantium mollitia est nam voluptate.", "Horizontal non-volatile approach", true },
                    { 30, "Chad", "Wolff", "Accusamus culpa in voluptas qui incidunt. Quasi atque inventore sed vitae possimus deserunt eligendi. Vel dolores minima est aperiam incidunt iste dolores sunt laboriosam. Qui vel rerum architecto natus sint.", "Front-line explicit internet solution", false },
                    { 31, "Lola", "Torp", "Aliquam occaecati et exercitationem. Eaque quae excepturi. Ipsam ut dolore voluptatem eius. Nobis consequatur ad commodi voluptas voluptates fuga suscipit animi.", "Down-sized uniform matrix", true },
                    { 32, "Taylor", "McKenzie", "Delectus quis officiis id et officia. Excepturi corrupti et ut quibusdam nihil qui saepe in omnis. Qui velit facilis quia unde.", "Business-focused uniform encryption", false },
                    { 33, "Donna", "Romaguera", "Placeat voluptas ratione aspernatur debitis. Ut perspiciatis rerum est quos quam. Veritatis sapiente voluptas fugiat repudiandae laudantium nobis sit.", "Decentralized zero defect solution", false },
                    { 34, "Sidney", "Hoppe", "Culpa non placeat debitis quisquam ut assumenda quae. Non doloremque saepe aliquam tempora. Blanditiis non est eos fugiat. Eius odio quod et qui aliquid voluptatem sapiente eaque fugiat.", "Customizable next generation superstructure", false },
                    { 35, "Katie", "Braun", "Facere sint tempore placeat animi necessitatibus sunt ut molestiae necessitatibus. Nulla voluptatem qui. Non dolor ex ut. Aut quam repudiandae pariatur magnam qui culpa laboriosam. Unde iste veritatis dolores rerum pariatur et dolore. Eos illo consequatur quis amet.", "Re-engineered uniform adapter", true },
                    { 36, "Stuart", "Krajcik", "Aperiam commodi sit et ea pariatur. Deserunt cum sit excepturi est nihil ut velit recusandae aut. Et consectetur consectetur. Soluta et doloribus eius qui alias et at. Excepturi omnis voluptas praesentium vel deserunt quia voluptas incidunt. Id sit labore qui deleniti quia rerum cumque.", "Decentralized incremental Graphic Interface", true },
                    { 37, "Ramiro", "Gaylord", "Quos culpa vel quis aut eius qui. Sunt ea aut eius mollitia. Vero quae ut ab dicta qui vero. Ex mollitia architecto sapiente nostrum dolor eum ad officiis incidunt. Quibusdam ipsum veritatis. Qui porro et incidunt fugiat nihil et doloribus.", "Face to face attitude-oriented support", false },
                    { 38, "Cora", "Friesen", "Nam id eum odit accusantium assumenda eveniet dolore in omnis. Maiores dolores voluptas est et. Maxime mollitia placeat aut ut vel rerum alias. Vero sequi dignissimos voluptate ea deserunt veritatis provident. Cumque rerum consequatur fuga omnis quia est.", "Business-focused intermediate paradigm", true },
                    { 39, "Ivan", "Lockman", "Ducimus cum natus expedita culpa molestias beatae. Suscipit eos consequatur inventore architecto asperiores nemo. Blanditiis saepe qui animi saepe. Et facilis mollitia dolorem totam. Eligendi nesciunt non et sit sint velit.", "Phased optimizing productivity", false },
                    { 40, "Mary", "Emard", "In voluptate placeat modi est mollitia. Earum ullam quod quas iusto. Deserunt quis accusantium autem voluptate sit ut.", "Programmable neutral time-frame", false },
                    { 41, "Gloria", "Hane", "Provident expedita cumque perferendis porro. Earum omnis iusto est perspiciatis laboriosam ratione. Consequatur rem dolores odio saepe autem. Facere distinctio doloremque. Quae adipisci quia deleniti deleniti voluptate quidem.", "Proactive 4th generation flexibility", true },
                    { 42, "Kara", "Doyle", "Ipsa sunt quis totam labore commodi nihil magni consequatur est. Voluptas sit non ab quas. Hic eos laborum qui atque velit.", "Visionary dynamic product", false },
                    { 43, "Danielle", "Johnson", "Voluptas ea deserunt sed sunt labore aut neque eos. In illo aut molestiae eum neque. Veniam laudantium architecto aspernatur dolorem vel autem. Cum dolore unde rerum ipsum modi necessitatibus odit.", "Ergonomic static paradigm", true },
                    { 44, "Leslie", "Johnson", "Nulla ut facilis dicta vero qui. Et voluptas modi et eaque eius magnam fugit tenetur omnis. Ullam necessitatibus omnis facere. Ratione neque nostrum blanditiis aperiam.", "Open-architected client-server synergy", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b3cc7544-b397-46ab-9db5-312e7d79512b", "1d15b6c6-a87b-49bc-8fda-c374da77b4b7" },
                    { "d5ccbfbe-422a-4b27-a8da-3f19cb372cbc", "2fe2f128-950b-456b-bed0-22bd2c6ee970" }
                });
        }
    }
}
