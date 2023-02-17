using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoleToUserCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "84b96d08-e0ee-40a4-abeb-9cdc42620f98", "34000bb7-ea15-4d1b-884f-35171e140e24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "10c11c67-13d9-4400-9adc-0d7ed3e6a411", "bce806c0-99b8-4f82-b5e8-fa33996e12f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28752060-0a72-4550-986a-63696bf52f9d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "def0d338-2fbb-48f6-b653-5a29c4815a46");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "10c11c67-13d9-4400-9adc-0d7ed3e6a411");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "84b96d08-e0ee-40a4-abeb-9cdc42620f98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34000bb7-ea15-4d1b-884f-35171e140e24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bce806c0-99b8-4f82-b5e8-fa33996e12f4");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35cb49a4-8020-4a0a-bce9-62b65b4cec6c", null, "admin", "ADMIN" },
                    { "ac3d16af-cc17-454b-b9ee-97ace89400c7", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03ff21c8-145e-4829-9207-72946cae4151", 0, "48718c27-926d-40a7-8f00-cf4886cab126", "User", "irma_cummerata@library.net", false, true, null, "", "irma_cummerata", "AQAAAAIAAYagAAAAEGv02S8qTCuBqEg8HEHJZ/NxheJifjuA8JAz8Ko5c5CUeFqbzDGTfMAwGhKV+fP83w==", "731-246-0362 x9408", false, null, "ca5046cc-73cf-4552-a3ea-b7db1807690c", false, "Irma_Cummerata" },
                    { "1d0621cc-905b-40e0-bbdc-586ecfd6202b", 0, "4a2bece3-0fca-46ee-a521-c95d4574b8ca", "User", "michelle_hand@library.net", false, true, null, "", "michelle_hand", "AQAAAAIAAYagAAAAENLVUor/8QdWziYVxDIC7E7jIAM7C7ad9ulc9MK+UqGGgjT3F0kDmk6G8e9IkJdH4g==", "1-618-876-8027", false, null, "ecc77b36-37ac-429c-a715-39cf5a4ef6a9", false, "Michelle_Hand" },
                    { "7689312d-f4d2-4b50-9d2c-572b546c79ef", 0, "3b5a80f8-0465-4f27-bc17-c9bc6cb27013", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEK24Dqy3dRxPX3JEwDTLEJb7Quw8liwHAazKXO08pENVJSn0dbLeXfkY7sYGcC5ykQ==", "", false, null, "a3a30488-1a6a-4d16-9c31-6c9995680690", false, "librarian@library.net" },
                    { "7a10c760-0a02-4843-bd9f-3b14cf5702ad", 0, "91739ebf-c2eb-4303-ab14-81bc902c38ea", "User", "patrick.schmitt@library.net", false, true, null, "", "patrick.schmitt", "AQAAAAIAAYagAAAAEBNkvoDz43ByBPqqlUCbmVb9scawl0cCIU/yDYbItjXuWyEZ3rMwFvjAKlpKinA6Fw==", "938-369-6272 x219", false, null, "312032dd-0c0c-4683-bd71-0e3b7496b1ce", false, "Patrick.Schmitt" },
                    { "987ddf86-7e2f-41e1-b9c7-7ba2f72ef7a9", 0, "b7309b1a-6398-4927-8fc1-48d5b0c9e63e", "User", "jimmie51@library.net", false, true, null, "", "jimmie51", "AQAAAAIAAYagAAAAEDZbs1xjxDcM3TWlYJhGSBW9FGd5enFMYTaQ1yOGfhEvNJ9TB7WN9ZcCmMt3eaKVdA==", "1-669-268-7292", false, null, "8aab07b5-49f4-42b2-80a6-bc9199c4410e", false, "Jimmie51" },
                    { "9a55c850-9a75-4bbd-adf7-67e8b829dac2", 0, "55e6b31a-035e-45ae-9d08-f5c39afa1fb8", "User", "kenneth.stanton60@library.net", false, true, null, "", "kenneth.stanton60", "AQAAAAIAAYagAAAAEMcETxlhTpkvfdBd8jWfjBHp0x6XUHMFNnX+vlukiFkGEX0TTc4pS0Qdan3hVOna1A==", "1-659-534-8458 x4646", false, null, "a8daa67b-e2f1-4f86-b00b-686b10c200e1", false, "Kenneth.Stanton60" },
                    { "af9cfd29-1af4-4115-9358-8d692132556e", 0, "154ecdb1-8a3b-4fef-b726-80149411a533", "User", "rene.mayert@library.net", false, true, null, "", "rene.mayert", "AQAAAAIAAYagAAAAELajirFT5EnG3geEj2stSxMjTDa08prDQrZnfQSkgxHXB/RexRTVRHQ6JiLwq483wQ==", "(722) 643-4828", false, null, "d66ea289-9fcf-47dd-a9c5-058d1432bff8", false, "Rene.Mayert" },
                    { "be1a89d6-c513-4621-8f46-581716a0e2d6", 0, "1af155db-39fb-44bf-b5a9-e4e978010d3b", "User", "clayton.schulist93@library.net", false, true, null, "", "clayton.schulist93", "AQAAAAIAAYagAAAAECyQQbUq2PKv0QaZSXGzZROQjPya1o9VMHNNzUVfW0vbxSyJgiz1df9eXqA1iptsiw==", "917.815.0255 x8673", false, null, "80424c98-1d30-40b1-b8d7-29885396afb4", false, "Clayton.Schulist93" },
                    { "dfede864-d471-46bf-b494-55f6d05b3655", 0, "138ab0af-f111-4b9f-b732-86196a7e09b2", "User", "kay70@library.net", false, true, null, "", "kay70", "AQAAAAIAAYagAAAAEAXvBwkHM4j3dBmX0VjjyNRhENfoJQUOfU+N2SvC72PGrFkbjl0WbLZcddPnXLsLZw==", "1-364-611-6889", false, null, "8ce8d293-6cf7-44f6-aee1-4513df2e8cdf", false, "Kay70" },
                    { "ec62701f-cb92-4204-97e6-461ac20c0608", 0, "60b032b0-cc79-4f17-99e7-cc136f397e2b", "User", "duane99@library.net", false, true, null, "", "duane99", "AQAAAAIAAYagAAAAEB4s6PuWj6CNzKw8pLEUtWcrswexhtu4LKoMCuF4f1xIjiuy37sWuh+/ttkanrczXw==", "(235) 316-2005 x78757", false, null, "1929ccbb-2b86-41d0-8981-ccc571201bd4", false, "Duane99" },
                    { "ed10d758-5209-4add-a1ad-5c569384933a", 0, "ad42a1eb-32b4-4745-8343-010ae4039a15", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEO81Ucv4h+GT3oZPNcJ0MSuI4cMwCKTQ9D2UlyyQAbOfsQEjrCaIUK6JWULeABLOnQ==", "", false, null, "56f7a234-87d1-42c9-a3bb-a6d33e75da88", false, "borrower@library.net" },
                    { "f03960a4-5986-4a00-9c2d-55d545bfa5f7", 0, "aabba045-a0e7-47ff-911e-b2365807621c", "User", "sheri_schinner97@library.net", false, true, null, "", "sheri_schinner97", "AQAAAAIAAYagAAAAECUlLmthFuJfpg8rS20IXPqHqb01zfQhu/M8yE/eVix+ryaJlxl9WNA2emXWANoJdg==", "921.558.4300 x53430", false, null, "8a4e7a37-cdfb-48e2-808e-47a993f49b60", false, "Sheri_Schinner97" },
                    { "ff34a9b0-6fa0-44fa-927f-a545387416dd", 0, "8aa6e532-0523-4637-92bc-1a81c6245545", "User", "vickie.schmeler@library.net", false, true, null, "", "vickie.schmeler", "AQAAAAIAAYagAAAAEMSC+sb3DDiQ8JCxzjRKZEuMmqhpEyLHiY6aJk5sHpsGm03UN15MsFZVEemWRKxc6Q==", "336.893.8710", false, null, "803e610d-1a65-4fbb-83d5-0ede5b46405a", false, "Vickie.Schmeler" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rafael", "Abbott", "Rerum sed in soluta aut. Et laborum perferendis nihil quia qui corrupti qui exercitationem id. Sint sit nihil. Laudantium quaerat aut voluptatem dolore quae harum et.", "Enhanced national extranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Erik", "Bernhard", "Nisi consectetur rerum et sunt. Ea ratione nesciunt consequatur. Enim molestias quisquam eum. Voluptas eum sed quaerat consequatur molestiae sit. Ut repellat veritatis et.", "Multi-tiered composite algorithm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cary", "Turcotte", "Distinctio voluptatem beatae enim in ducimus laborum sint quia velit. Magni omnis odio autem. Repudiandae harum tempora quas sed totam minima vel tenetur. Ea corporis eos quidem adipisci quia veritatis nemo illo qui. Recusandae molestiae atque.", "Focused 3rd generation implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Clay", "Olson", "Reiciendis rem nesciunt pariatur et et eaque praesentium ullam. Velit eos debitis labore quas nihil consequatur laborum aut eos. Qui dicta sed quae ea molestias alias saepe atque rerum. Possimus quia aut saepe omnis. Facilis laboriosam dolorem.", "Function-based content-based archive" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gary", "Quigley", "Modi exercitationem quos voluptatem fugit. Voluptas pariatur quae. Aspernatur quidem dolores et dicta enim.", "Enhanced fresh-thinking open system" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Betty", "Rice", "Sapiente ducimus provident placeat delectus labore. Voluptas id nesciunt consequatur reiciendis harum est. Vel dolorum ab eveniet et cum vel corrupti modi. Non possimus sunt voluptatum velit possimus quisquam a qui. Nesciunt aliquam eius tempore dignissimos id quia dolores maiores. Possimus alias eum porro dicta ea totam voluptas et.", "Polarised 5th generation concept", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jonathon", "Turcotte", "Rerum quidem voluptatem nam est laudantium magni architecto deserunt tempora. Amet qui et minima quae accusamus molestiae. Perferendis et et sint accusamus dolore quis totam voluptas aut. Fuga modi ut vel non id autem et enim sit. Aut vero unde.", "Team-oriented coherent encryption" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jacqueline", "Little", "Nostrum dicta iusto a voluptatum labore. Culpa voluptatem commodi illo nihil. Voluptas et totam maxime accusamus. Accusamus beatae qui et et. Ea incidunt illum et dolor velit.", "Team-oriented global initiative" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ron", "Batz", "Vitae sunt recusandae alias. Fugit eos alias. Aut pariatur dolore eos velit optio voluptas vero dolor similique. Aspernatur consequuntur quia consectetur. Aut dolorem vel et perferendis accusamus culpa qui ut. Atque dolorem nobis rerum animi.", "Innovative even-keeled service-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jared", "Kshlerin", "Autem distinctio at praesentium tempora nihil. Optio cupiditate omnis est. Est omnis fugit odio dolor.", "Optional intermediate software", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jeremy", "Cole", "Dolor aut quibusdam eum eligendi modi. Placeat ut iusto ea. Soluta quas veritatis dolorem. Quo incidunt esse necessitatibus officiis molestiae quidem id ut.", "Future-proofed directional forecast" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lucia", "Torphy", "Iusto ex a et ducimus qui nihil sit consectetur. Unde odio dolor quas est et qui enim. Eaque eos culpa doloremque. Quia voluptate fugiat nihil ut dolore impedit non et. Distinctio nobis fugit. Reprehenderit quasi repudiandae nisi libero est nesciunt.", "Stand-alone system-worthy process improvement", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cory", "Bruen", "Sit a qui. Veritatis itaque distinctio quibusdam rerum excepturi. Nesciunt ut sit minima cum eum cum omnis facere. Quas a quos sit optio expedita voluptas. Nihil sit minus est hic. Qui praesentium consequuntur quis nulla tempore aut quibusdam amet beatae.", "Virtual upward-trending algorithm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jaime", "Orn", "Ut quidem esse ab delectus doloremque tempore tempore officiis et. Dolore ea consequatur. Voluptatum tenetur quam voluptas reprehenderit nemo sit.", "Optional interactive customer loyalty", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kay", "Dooley", "Nobis libero minima est est dolore minus pariatur et doloremque. Totam quaerat minus aperiam. Deleniti et facere rerum eos sunt ab quo alias maxime.", "Devolved interactive analyzer" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Harriet", "Mante", "Placeat quis veniam odit perspiciatis et maxime. Ex veniam consequuntur. Velit quia dolorem deserunt dolores architecto quo qui quibusdam.", "Assimilated dedicated forecast", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Morris", "Lang", "Labore porro quia perferendis. At labore dignissimos ex vero. Labore dolores natus sint suscipit et. Veniam quidem ab. Repudiandae explicabo sunt voluptas sed voluptas. Dolores temporibus sint dolorem unde odio numquam.", "Visionary asymmetric implementation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Julian", "Bashirian", "Rerum id autem autem aspernatur nemo eius ut quibusdam facere. Cum dolore ut delectus exercitationem numquam voluptatem labore. Quibusdam aut excepturi praesentium laboriosam doloremque. Magnam et tempore voluptatum dolor quia aut consequatur quibusdam.", "Compatible systemic projection" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rhonda", "Paucek", "Dolores voluptas dolore a corrupti tempore incidunt. Et nihil sequi praesentium ex veritatis harum aperiam mollitia. Impedit et repellat in sit. Et et quis molestias dicta quia assumenda et. Cupiditate delectus dolor et et. Quaerat temporibus nemo voluptas.", "Public-key regional hardware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Christie", "Moore", "Doloremque sit debitis magni officia ducimus omnis et qui. Tempora qui enim ut fugiat mollitia et accusantium. Perspiciatis repellendus natus.", "Function-based full-range initiative" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Randy", "Bahringer", "Distinctio atque vitae et. Quia ipsam repellendus. Assumenda veritatis qui asperiores aperiam quo sit. Ut dolorem dicta aliquid omnis ut labore. Consequuntur repellat doloremque. Et deleniti suscipit repellat omnis et cum eius est.", "Persevering multimedia open architecture" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 22, "Karla", "Hudson", "Dolores rerum quia quos perferendis eius voluptas dolor fuga vitae. Deleniti in sed aut sunt harum pariatur et. Minima adipisci quod. Eveniet molestiae et.", "Multi-layered mission-critical access", true },
                    { 23, "Kristi", "Anderson", "Molestiae qui aut excepturi eos voluptas voluptatem consequatur reiciendis. Ipsa deserunt quo voluptate at a in optio eveniet eligendi. Alias repellendus at aspernatur adipisci ab. Perferendis asperiores soluta. Repellendus fuga facilis in. Illo nostrum repellat consequatur dolores in distinctio alias.", "Ergonomic actuating intranet", false },
                    { 24, "Alice", "Ullrich", "Qui voluptatem natus placeat et cupiditate dolore aut ab officiis. Ea aliquid cupiditate distinctio maxime itaque dignissimos eveniet. Et aut assumenda.", "Organized directional attitude", true },
                    { 25, "Roosevelt", "Champlin", "Ratione repellendus aperiam minima magnam sapiente neque atque qui. Debitis voluptatem animi veritatis ut nisi et possimus a repudiandae. Esse architecto debitis fugit sit vero. Nulla quibusdam possimus accusamus iusto eos velit facere quisquam et. Et voluptate provident rerum cumque sed.", "Visionary attitude-oriented workforce", true },
                    { 26, "Tanya", "Grant", "Repellendus dolorum tenetur quo eligendi nobis autem nemo magni. Quo ad cumque necessitatibus debitis nihil qui. At illum dolor earum quaerat at.", "Profound solution-oriented standardization", false },
                    { 27, "Lance", "Nienow", "Numquam magnam quidem sit tempora. Necessitatibus id iusto blanditiis enim voluptatem ipsam soluta. Autem explicabo sapiente quis unde porro adipisci facere eveniet. Fugit accusamus quo earum porro officiis nulla ipsum.", "Versatile foreground collaboration", true },
                    { 28, "Kara", "Hagenes", "Velit adipisci et quia sequi laborum ut vel sint labore. Qui deleniti dolores. Error reiciendis alias totam.", "Profound interactive algorithm", false },
                    { 29, "Annie", "Roob", "Officia quam ut vitae velit maxime. Accusantium repellat impedit. Nemo porro autem esse qui sequi dolores pariatur fuga. Ut modi blanditiis quos praesentium. Cum quidem neque deserunt enim eius consequuntur voluptatem voluptas. Laudantium reprehenderit quasi occaecati nobis.", "Team-oriented next generation monitoring", true },
                    { 30, "Mercedes", "Brakus", "Explicabo incidunt fugit quidem mollitia consequuntur. Sit provident eveniet. Id at magni sit ut voluptatum. Et provident sed autem nobis eligendi sit doloribus dolorem ut.", "Streamlined analyzing synergy", true },
                    { 31, "Amanda", "Effertz", "Veniam est asperiores numquam ullam. Maxime eum magnam aut cupiditate adipisci blanditiis voluptas eos placeat. Et possimus quis. Laborum qui pariatur sint accusamus ut. Eius et sed fuga iure et sequi harum.", "Exclusive bottom-line emulation", false },
                    { 32, "Beverly", "Koss", "Quia quae ducimus. Et illum at fuga et. Corrupti dolor voluptas dignissimos repudiandae eum rerum distinctio. Ut consectetur a impedit consectetur optio at ut. Omnis et qui adipisci est praesentium.", "Monitored needs-based throughput", false },
                    { 33, "Myron", "Gottlieb", "Aut quos id laudantium omnis voluptas. Veniam doloremque odio sit et maxime inventore error eligendi. Et ad non perspiciatis qui officiis cumque. Earum fugit quo aut cum est quia omnis qui et.", "Ameliorated executive attitude", true },
                    { 34, "Violet", "Hyatt", "Et officia error aut unde dolor. Officia eius illo laudantium non nulla praesentium. Laborum nesciunt sapiente totam molestiae sit mollitia veritatis. Dolor fuga voluptatum minima rerum eius est ad libero consequatur.", "Centralized asymmetric benchmark", true },
                    { 35, "Helen", "Bergnaum", "Est iste ut repudiandae enim qui et et neque saepe. Excepturi nisi qui explicabo quisquam. Recusandae est et dolores optio assumenda praesentium nihil aliquid.", "Universal responsive contingency", false },
                    { 36, "Charlene", "Greenholt", "Voluptatem at animi rerum minima doloremque adipisci. Repellendus quibusdam quia consequatur. Doloremque sit totam dolorum dignissimos itaque. Accusamus rem asperiores facilis ad enim est sunt saepe totam. Cumque eius quidem.", "Multi-channelled attitude-oriented open architecture", true },
                    { 37, "Larry", "Schuster", "In non aut in dolor nam occaecati voluptas sunt. Et at dolor. Ipsa esse autem illum. Incidunt consectetur explicabo impedit repellendus.", "User-friendly stable portal", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "35cb49a4-8020-4a0a-bce9-62b65b4cec6c", "7689312d-f4d2-4b50-9d2c-572b546c79ef" },
                    { "ac3d16af-cc17-454b-b9ee-97ace89400c7", "ed10d758-5209-4add-a1ad-5c569384933a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35cb49a4-8020-4a0a-bce9-62b65b4cec6c", "7689312d-f4d2-4b50-9d2c-572b546c79ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac3d16af-cc17-454b-b9ee-97ace89400c7", "ed10d758-5209-4add-a1ad-5c569384933a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03ff21c8-145e-4829-9207-72946cae4151");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d0621cc-905b-40e0-bbdc-586ecfd6202b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a10c760-0a02-4843-bd9f-3b14cf5702ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "987ddf86-7e2f-41e1-b9c7-7ba2f72ef7a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a55c850-9a75-4bbd-adf7-67e8b829dac2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af9cfd29-1af4-4115-9358-8d692132556e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be1a89d6-c513-4621-8f46-581716a0e2d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfede864-d471-46bf-b494-55f6d05b3655");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec62701f-cb92-4204-97e6-461ac20c0608");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f03960a4-5986-4a00-9c2d-55d545bfa5f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff34a9b0-6fa0-44fa-927f-a545387416dd");

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35cb49a4-8020-4a0a-bce9-62b65b4cec6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac3d16af-cc17-454b-b9ee-97ace89400c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7689312d-f4d2-4b50-9d2c-572b546c79ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed10d758-5209-4add-a1ad-5c569384933a");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "10c11c67-13d9-4400-9adc-0d7ed3e6a411", null, "admin", "ADMIN" },
                    { "84b96d08-e0ee-40a4-abeb-9cdc42620f98", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "28752060-0a72-4550-986a-63696bf52f9d", 0, "9c7b4eae-120d-41ce-a13c-8c66098a5388", "User", "glenn_hammes@library.net", false, true, null, "", "glenn_hammes", "AQAAAAIAAYagAAAAEM1GyKb5KpA6og2O6KaBoAgHtvpwVD1vq/Ou8B+0ucR2JQZ8fltTP9Vaw/i6cuCrhg==", "1-438-334-2584 x16319", false, "c5160c61-7df3-418e-b894-151f504f0360", false, "Glenn_Hammes" },
                    { "34000bb7-ea15-4d1b-884f-35171e140e24", 0, "e2383821-93d2-401a-b68e-5e9188ddd537", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEFDDOc7XPaV8JIStU/xSh9s9tgmBrheWtouVhkKcu2Xpe5FsuwBYUspqBCj7FlAbsw==", "", false, "aa693015-1881-4262-8857-61992b90c61e", false, "borrower@library.net" },
                    { "bce806c0-99b8-4f82-b5e8-fa33996e12f4", 0, "ee8b7e47-b57c-4693-a3cc-e0bebe6a1537", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEMNi4NfyuO/0np8GrQtSxWW+nwBfDUoF/GaCzFTRVZa3HR7VQuO9fNlY5gC8gDzegg==", "", false, "c7154aa7-ca39-455f-bede-55cbb193df01", false, "librarian@library.net" },
                    { "def0d338-2fbb-48f6-b653-5a29c4815a46", 0, "96ccdcb0-765d-4275-baef-d7f98e17f130", "User", "ernesto18@library.net", false, true, null, "", "ernesto18", "AQAAAAIAAYagAAAAEBRYtdyd7D5m4emamc1uheTpji+fIeeRfSHL2U0xcTk47RrPVd4ayzL5tmxpS27Beg==", "555.720.5472 x52565", false, "4274cd4e-49b1-466c-b647-423dc0fb25da", false, "Ernesto18" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cary", "Donnelly", "Est et quam dolore ipsa debitis officia eaque. Delectus harum voluptates eligendi dolores explicabo. Magnam incidunt sit eius adipisci architecto voluptatem placeat. Harum praesentium voluptatum qui rerum nisi nihil sunt molestias dolorem.", "Inverse impactful monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Loretta", "Marquardt", "Officiis et sunt aliquid maiores reprehenderit sed fugit est aperiam. Quam laudantium et commodi ut sit. In laboriosam sequi. Doloremque repudiandae eos aliquid quia quos expedita.", "Pre-emptive leading edge policy", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Charlene", "Hoppe", "Amet rerum qui et incidunt delectus tenetur accusamus dolores est. Autem nihil doloribus quam. Iste neque eos quam corrupti. Unde iusto ad voluptatibus consequuntur est perspiciatis non assumenda in. Cupiditate qui dolor asperiores.", "Universal empowering Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Juanita", "Tillman", "Recusandae est ut magnam incidunt quis natus consequatur. Quis cum voluptatem qui laboriosam dolorem. Ut numquam nulla maxime. Sapiente quod totam itaque voluptatem voluptatem. Occaecati incidunt optio.", "Up-sized global encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Milton", "Bradtke", "Facere eveniet ut non molestiae omnis et qui. Iure corrupti dignissimos voluptatibus qui. Provident aut et vel. Aliquam illo sit quaerat inventore dolores dolore similique eos. Magnam cum et aut aperiam ducimus dolores.", "Exclusive directional intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Terence", "Wilkinson", "Ut enim quo repellendus sed. Dolorem ut unde aut quis qui tenetur aspernatur. Repellat illo nostrum delectus magnam qui ipsum.", "Enterprise-wide uniform internet solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Shelly", "Oberbrunner", "Rerum deleniti excepturi quas numquam praesentium. In repellendus sint soluta. Et aliquam deserunt rem suscipit. Dolores est qui numquam omnis maxime consequatur. Iure odio sapiente. Dolore sit aspernatur laudantium.", "Cross-group non-volatile leverage" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Muriel", "Connelly", "Ut aliquam aliquam consectetur consequuntur. Ut voluptates possimus aut sint officiis iusto sequi sed vitae. Odio omnis eveniet reiciendis sunt autem dolorem ipsam quasi. A beatae quia.", "Customer-focused mobile monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Roger", "Hessel", "Tempora est rem fugiat qui accusantium sapiente. Quis qui omnis et quae fugit sequi accusamus. Quia ea est nihil. Magnam eos maxime quasi veniam praesentium quaerat quaerat.", "Centralized local encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Domingo", "Wyman", "Veritatis eius aperiam. Et laborum quos quis labore. Soluta eos dolor eos et eveniet ea placeat.", "Monitored optimal parallelism", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Felicia", "Fay", "Quae adipisci accusamus at voluptas esse ad expedita vel. Eligendi sequi cumque eveniet tempora numquam perferendis. At harum dolores vel hic.", "Upgradable global challenge" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ricardo", "Stroman", "Illo nobis quasi maxime reprehenderit velit itaque eos. In dolorem voluptatem commodi qui est dolores officia molestiae. Qui aut cupiditate illo dolorem beatae veniam architecto eos.", "De-engineered zero administration productivity", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Helen", "Reilly", "Molestiae blanditiis voluptatem est corporis qui aut quisquam. Tempore debitis sed accusamus fuga nulla enim dolores laboriosam. Qui quas sequi repellendus. Impedit non qui enim est vero rerum. Itaque consequatur earum eligendi sint et distinctio.", "Horizontal holistic utilisation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristopher", "Hyatt", "Eaque ipsam adipisci et a similique veritatis autem voluptatem aliquam. Voluptatem dignissimos repudiandae ratione rerum repudiandae incidunt. Sed sed est suscipit explicabo non quibusdam qui. Ratione quia a et. Quae non et voluptatem laudantium distinctio velit qui.", "Self-enabling mobile migration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Alejandro", "Nikolaus", "Harum itaque reprehenderit maiores. Voluptas dolores minus architecto aut debitis. Dolor cumque dolores nobis qui unde eum qui qui animi. Est unde delectus incidunt tenetur.", "Object-based 24/7 array" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Glenda", "Hills", "Adipisci fugiat sapiente repellat ut. Qui molestiae sed provident. Non sint asperiores laborum est exercitationem suscipit. Iste numquam repudiandae quod cumque reprehenderit velit dicta nihil facere.", "Innovative secondary database", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dustin", "Quigley", "Aut fuga et est. Quis quo repellat ex numquam et ut doloremque. Voluptatum facilis voluptatibus voluptatem voluptatem nihil velit. In debitis iste repudiandae eligendi et ab pariatur consequatur error. Odio recusandae sunt labore eos et quidem inventore ut qui.", "Universal bandwidth-monitored structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Doyle", "Emard", "Ullam unde neque velit sed id veritatis sit doloribus. Nesciunt labore tempora nisi. Deleniti qui exercitationem occaecati dolor illum doloribus.", "Ergonomic regional success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mike", "Lebsack", "Officiis blanditiis magni dolor omnis quia ipsam ipsum. Vitae non voluptatem. Non facilis nulla. Excepturi quibusdam corrupti dolorem ut vero dolor quia possimus ducimus. Odit et error dolores consequuntur velit sequi aspernatur qui.", "Optional optimizing superstructure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Evelyn", "Bosco", "At ea voluptatem asperiores iusto. Tempore et aut quam expedita quia nisi ad. Est qui perferendis sint vero tempore aut molestiae alias atque. Mollitia aut corrupti nulla. Est totam libero nulla ut facere eum doloribus. Error laborum ut ut beatae eligendi recusandae quaerat molestiae perferendis.", "Front-line mission-critical product" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Yvette", "Kris", "At impedit deleniti adipisci eum magnam autem assumenda natus. Voluptate non doloribus delectus provident et. Voluptates earum vel eveniet. Quisquam cumque esse corporis deleniti ut illum officia praesentium.", "Enhanced tangible projection" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "84b96d08-e0ee-40a4-abeb-9cdc42620f98", "34000bb7-ea15-4d1b-884f-35171e140e24" },
                    { "10c11c67-13d9-4400-9adc-0d7ed3e6a411", "bce806c0-99b8-4f82-b5e8-fa33996e12f4" }
                });
        }
    }
}
