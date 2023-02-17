using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedNormalizedUsernameToBogus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5236a21a-4938-44ec-a5f0-b4c9a6b5c3d7", "22f6049b-2ebf-40ae-a151-426290c73f9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "60337d3d-0648-4d4e-9544-515326ebae39", "34540300-c10b-47a1-b9f6-75991fd8a470" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26130aa7-a79b-453a-9965-c3182130c2c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b182691-d00d-4989-9d03-023c57ab3406");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f1275c0-2826-4392-b2f2-7612b92cda94");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "67ca206d-bf7a-4824-8f88-4a30fd3b8bd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78f03171-e8ea-4d3e-ba9f-9f6f388e0e98");

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
                keyValue: "5236a21a-4938-44ec-a5f0-b4c9a6b5c3d7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60337d3d-0648-4d4e-9544-515326ebae39");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22f6049b-2ebf-40ae-a151-426290c73f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "34540300-c10b-47a1-b9f6-75991fd8a470");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Loretta", "Marquardt", "Officiis et sunt aliquid maiores reprehenderit sed fugit est aperiam. Quam laudantium et commodi ut sit. In laboriosam sequi. Doloremque repudiandae eos aliquid quia quos expedita.", "Pre-emptive leading edge policy" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Roger", "Hessel", "Tempora est rem fugiat qui accusantium sapiente. Quis qui omnis et quae fugit sequi accusamus. Quia ea est nihil. Magnam eos maxime quasi veniam praesentium quaerat quaerat.", "Centralized local encoding", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Felicia", "Fay", "Quae adipisci accusamus at voluptas esse ad expedita vel. Eligendi sequi cumque eveniet tempora numquam perferendis. At harum dolores vel hic.", "Upgradable global challenge", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Helen", "Reilly", "Molestiae blanditiis voluptatem est corporis qui aut quisquam. Tempore debitis sed accusamus fuga nulla enim dolores laboriosam. Qui quas sequi repellendus. Impedit non qui enim est vero rerum. Itaque consequatur earum eligendi sint et distinctio.", "Horizontal holistic utilisation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kristopher", "Hyatt", "Eaque ipsam adipisci et a similique veritatis autem voluptatem aliquam. Voluptatem dignissimos repudiandae ratione rerum repudiandae incidunt. Sed sed est suscipit explicabo non quibusdam qui. Ratione quia a et. Quae non et voluptatem laudantium distinctio velit qui.", "Self-enabling mobile migration" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Glenda", "Hills", "Adipisci fugiat sapiente repellat ut. Qui molestiae sed provident. Non sint asperiores laborum est exercitationem suscipit. Iste numquam repudiandae quod cumque reprehenderit velit dicta nihil facere.", "Innovative secondary database" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dustin", "Quigley", "Aut fuga et est. Quis quo repellat ex numquam et ut doloremque. Voluptatum facilis voluptatibus voluptatem voluptatem nihil velit. In debitis iste repudiandae eligendi et ab pariatur consequatur error. Odio recusandae sunt labore eos et quidem inventore ut qui.", "Universal bandwidth-monitored structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Doyle", "Emard", "Ullam unde neque velit sed id veritatis sit doloribus. Nesciunt labore tempora nisi. Deleniti qui exercitationem occaecati dolor illum doloribus.", "Ergonomic regional success", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Evelyn", "Bosco", "At ea voluptatem asperiores iusto. Tempore et aut quam expedita quia nisi ad. Est qui perferendis sint vero tempore aut molestiae alias atque. Mollitia aut corrupti nulla. Est totam libero nulla ut facere eum doloribus. Error laborum ut ut beatae eligendi recusandae quaerat molestiae perferendis.", "Front-line mission-critical product", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Yvette", "Kris", "At impedit deleniti adipisci eum magnam autem assumenda natus. Voluptate non doloribus delectus provident et. Voluptates earum vel eveniet. Quisquam cumque esse corporis deleniti ut illum officia praesentium.", "Enhanced tangible projection", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "84b96d08-e0ee-40a4-abeb-9cdc42620f98", "34000bb7-ea15-4d1b-884f-35171e140e24" },
                    { "10c11c67-13d9-4400-9adc-0d7ed3e6a411", "bce806c0-99b8-4f82-b5e8-fa33996e12f4" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5236a21a-4938-44ec-a5f0-b4c9a6b5c3d7", null, "borrower", "BORROWER" },
                    { "60337d3d-0648-4d4e-9544-515326ebae39", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22f6049b-2ebf-40ae-a151-426290c73f9f", 0, "9ae76bfc-d1fc-48e9-8bde-b720a2408841", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEE6On6WmjL7rgIII6LPJmfQ+6GygeMBdyXoLqNY/BnSjjMMcqiF+6mH1PQ6lNuOz8A==", "", false, "addff3e8-85a4-4bf4-abfe-4e1b2504ef05", false, "borrower@library.net" },
                    { "26130aa7-a79b-453a-9965-c3182130c2c8", 0, "5bf691e0-3903-437b-a801-ac9292eff514", "User", "ian_anderson@library.net", false, true, null, "", "", "AQAAAAIAAYagAAAAEHZERVgbPI/9DDri9WUwj61ZXygx/FlRI68xhz4OWITC5G/YoNMHsZ3d5cuRcGdKmw==", "1-547-292-0799", false, "6459c1b6-a1f7-4348-9c78-257ca50db840", false, "Ian_Anderson" },
                    { "34540300-c10b-47a1-b9f6-75991fd8a470", 0, "86dc3662-e5ac-403e-9e3d-81a142afdef4", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEAv+NeaY01RekOBHrEP4gwOEYOQwbcZFrlZKGzddUYw4X88+Za+xj11rvDosfD3WMg==", "", false, "60da0391-cd20-4231-8006-74c9c227932f", false, "librarian@library.net" },
                    { "5b182691-d00d-4989-9d03-023c57ab3406", 0, "43b3240a-d78e-4560-a460-6030a336cbbd", "User", "estelle_kiehn84@library.net", false, true, null, "", "", "AQAAAAIAAYagAAAAEAc2t6TOrnjQGwSz+E0c8NJ8CLUuTJJhz5CqB0dkGP5kXQqWJ9pD/v4/vtk69m2MBw==", "596-711-2004", false, "e6705ee3-5622-4312-8fb7-c5370bd03064", false, "Estelle_Kiehn84" },
                    { "5f1275c0-2826-4392-b2f2-7612b92cda94", 0, "ea118263-5ed3-4f12-a99d-d94c6d1b4e49", "User", "clara.hilll17@library.net", false, true, null, "", "", "AQAAAAIAAYagAAAAEAw1Uf/YTrifF5RpSuNPtoJO9v5JB7ytfBPHQZRVxgT5FYhm9/i3/w6HVzzh9yJHyA==", "1-969-402-3431", false, "3b6f1e7b-290c-4e1d-ae69-bb495594d300", false, "Clara.Hilll17" },
                    { "67ca206d-bf7a-4824-8f88-4a30fd3b8bd4", 0, "71027a08-0277-4766-a302-06dc5dd285e1", "User", "constance.mitchell@library.net", false, true, null, "", "", "AQAAAAIAAYagAAAAEOFSW/iO4f6lRPmZt2/g2xCSeK4WKwFYX4h5CGHNyq4ZJdNsjcaJhmZy4XVe9rOiaQ==", "(673) 719-2519 x905", false, "26726024-c963-48ce-a075-35f264009431", false, "Constance.Mitchell" },
                    { "78f03171-e8ea-4d3e-ba9f-9f6f388e0e98", 0, "4326c49d-a182-4784-9209-3151547c71d6", "User", "misty.macgyver@library.net", false, true, null, "", "", "AQAAAAIAAYagAAAAEJJSqpwC57fUz6fZgVvzjcm+HU8yMgmLYf8kT99vPfS7Kn3A8cZYp7pFt0/D1nGSGg==", "784.628.6586 x550", false, "0619fbb4-5473-41a1-8528-f03be03dd18a", false, "Misty.MacGyver" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Otis", "Lang", "Aliquid laborum architecto distinctio eos veniam provident. Aut ipsum voluptas molestias deserunt. At a eligendi eveniet fuga facilis aperiam qui labore. Et molestias facilis perspiciatis neque officiis rerum ex qui quaerat. Aut quia quia culpa esse.", "Progressive 6th generation data-warehouse" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Morris", "McLaughlin", "Distinctio quasi voluptatum aliquam rem dolores laboriosam inventore illum et. Eaque quis ratione qui occaecati beatae ullam est. Et dolorem possimus dolorem dolores consequatur facere et vel ipsum. Necessitatibus quidem doloremque deleniti nisi et quidem voluptas sed et.", "Robust object-oriented implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Judy", "Walter", "Excepturi illo et voluptas. Optio cum recusandae porro deleniti enim non molestiae minima dolorum. Iure molestiae similique optio ut.", "Self-enabling 6th generation toolset" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Barbara", "Sanford", "Culpa est neque harum aut at ex dolor nemo beatae. Et facere et nemo rerum aut. Esse similique aperiam doloribus facilis laboriosam quae reprehenderit ab repellat. Sunt nesciunt rerum ab consequatur. Corporis maiores quasi omnis quis doloremque iste minus et et. Repellendus quia optio unde sunt consectetur.", "Realigned empowering software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marshall", "Gulgowski", "Aperiam quia non qui. Quo quaerat soluta error. Consequatur quia voluptates fuga reprehenderit optio inventore rerum.", "Exclusive actuating flexibility" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Penny", "O'Keefe", "Esse mollitia quo consequatur tenetur deserunt sed maxime rerum quia. Error sunt impedit velit aperiam quae. Dolores est est reiciendis temporibus doloremque quibusdam aut explicabo. Rerum suscipit dolor quidem dolorem et sit.", "Organic object-oriented structure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ernestine", "Robel", "Odio rerum repudiandae. Optio eius id atque et dolorem quos in incidunt. Facilis maxime aliquam debitis voluptas.", "Vision-oriented tangible hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marie", "Mann", "Ex incidunt nesciunt qui quidem deleniti id asperiores. Eligendi non assumenda voluptas vel similique laboriosam. Sed quaerat et delectus eum. Doloremque debitis voluptas iste et sed quia qui fugiat.", "Multi-channelled 24/7 leverage" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jasmine", "Hand", "Consectetur ab quasi molestiae illum laborum doloremque dolores vero. Ab vitae eos quod est. Nihil et iusto in dolores rem ea minus reprehenderit iure. Repudiandae quis quibusdam quaerat fuga autem rem dicta. Dolorum eum fugiat omnis aut iusto corporis quia itaque molestiae. Voluptas ut est laudantium asperiores nihil ratione dolorem excepturi.", "Customer-focused responsive migration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Craig", "Wilkinson", "Porro voluptates at placeat. Corporis quos vel commodi voluptates id. Ipsum occaecati labore voluptatibus harum ut voluptatem qui nihil ipsum. Iusto et ut enim. Esse inventore ut doloremque voluptatibus quibusdam sed. Quod est ab quia.", "Advanced zero administration artificial intelligence", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ralph", "Altenwerth", "Reprehenderit cum magnam impedit est deserunt. Molestias corporis sed et adipisci vel. Distinctio ad deleniti dolorem necessitatibus qui. Aperiam eius quam doloremque culpa cumque facere at.", "Object-based next generation pricing structure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Caleb", "Mann", "Aut debitis natus iure. Laborum et aliquid laboriosam vel nisi. Et ut accusantium est. Et sint rerum et ex est consequatur. Ullam eum qui magni qui sed ipsam eius quam.", "Business-focused impactful info-mediaries", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Omar", "Ferry", "Omnis id eum temporibus officia velit ut quae. Voluptatum aut rerum ab vel. Molestias sit qui. Quasi ipsum rerum doloribus odit dolorem voluptatem odit est natus. Praesentium incidunt at incidunt maxime ea deserunt aliquam dolor. Tenetur iure qui voluptatem ducimus.", "Digitized uniform monitoring", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Preston", "Block", "Nisi repudiandae consequatur aliquam ad eveniet. In cumque vel aut qui inventore qui. Consequuntur nihil ut ut. Ut consequatur reiciendis accusantium aliquid reprehenderit omnis.", "Sharable high-level matrices" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Constance", "Nienow", "Velit laboriosam sed aliquid vel dolore. Facilis minima voluptatem esse ducimus illo fugiat est quaerat odit. Laborum officia eos accusantium et odit cum. Ullam deserunt dolorum eius. Et rerum odit sint veniam.", "Ergonomic bi-directional access" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cornelius", "Goldner", "Quaerat error nostrum ut rem non ullam tempore molestias at. Expedita nesciunt et est delectus. Et odit iusto enim quia ea itaque voluptatem. Qui ex sed ut fugit quidem optio nobis. Consequuntur rerum aut. Facere reiciendis doloremque non eum quidem sunt occaecati quo.", "Multi-layered client-driven infrastructure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kay", "Lehner", "Odit ab quis nulla veniam ducimus a. Eligendi eum nisi. Aut sit corporis sapiente cupiditate blanditiis. Blanditiis quos veritatis aliquid fugiat ducimus. Consequuntur ea sed pariatur error eaque.", "Synergistic fresh-thinking portal" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Charlotte", "Sauer", "Doloremque aut assumenda iure tempora esse quo cupiditate. Nesciunt culpa unde ea. Harum recusandae earum expedita vel corrupti similique et deserunt. Blanditiis aut est corrupti et a blanditiis.", "Business-focused tangible superstructure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jean", "Medhurst", "Veniam delectus distinctio sequi itaque voluptas ut incidunt. Saepe cum eos expedita. Explicabo eveniet aliquid voluptas quas ut iste. Sunt corrupti eos qui non vel ut. Fugiat recusandae dolorem sed aliquid dolores voluptates natus debitis.", "Profit-focused mission-critical hub", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Seth", "Kling", "Eius esse eos deleniti at. Est veritatis incidunt. Quod non repudiandae architecto quibusdam deserunt nulla omnis fuga corporis. Perferendis cum optio repellat consequuntur. Optio error sed aut suscipit.", "Reverse-engineered client-server Graphic Interface", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Joanne", "Langosh", "Adipisci quia iure sunt eveniet aut ut quidem quam ipsa. Est ducimus tenetur quibusdam aspernatur. Accusamus doloremque illum sunt ea laboriosam voluptates. Nostrum quo dolor.", "Optional explicit definition", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 22, "Gayle", "Daugherty", "Quia ipsum nemo dolores et. Suscipit dolores aut esse labore occaecati harum deserunt molestiae quae. Nisi similique voluptatum illo ad dignissimos.", "Grass-roots bifurcated projection", true },
                    { 23, "Stanley", "Rogahn", "Exercitationem nemo rerum similique odio incidunt voluptas nulla sit itaque. Iure pariatur est. Tempore est consequatur totam alias omnis asperiores consequuntur ea. Velit harum perferendis accusantium.", "Reduced next generation success", false },
                    { 24, "Carole", "Hilll", "Nulla necessitatibus enim vitae alias reprehenderit sit veritatis. Sed ex et nisi et unde porro qui. Ex incidunt non distinctio consequatur totam autem modi iure. Aut qui consequatur.", "Configurable solution-oriented Graphic Interface", false },
                    { 25, "Felix", "Hyatt", "Saepe ipsa ab sunt deserunt. Harum quidem rerum. Est illo ducimus ut error ex hic fuga minima. Quia vero quo libero accusamus assumenda dolor porro iure.", "Managed zero administration Graphic Interface", true },
                    { 26, "Yolanda", "Schamberger", "Commodi qui a. Omnis voluptatum necessitatibus autem debitis sed nobis tempore fuga ut. Saepe consectetur unde rem perspiciatis illo et tempore voluptatem aspernatur. Perspiciatis aspernatur cupiditate atque fugit et dolor sint delectus explicabo. Omnis voluptate voluptas harum blanditiis ut temporibus distinctio ex.", "Switchable didactic emulation", true },
                    { 27, "Erika", "Hahn", "Et sapiente qui tenetur ea. Autem sapiente beatae id repellendus quos ex non et sed. Vel suscipit quam necessitatibus. Omnis ut nisi et autem quia dicta qui. Sed minima corporis repudiandae inventore corporis aspernatur ipsum. Eaque commodi eveniet non expedita nulla itaque qui dolore.", "Stand-alone bottom-line knowledge base", false },
                    { 28, "Mike", "Gaylord", "Nesciunt sapiente ipsam molestiae qui velit optio. Possimus id aut aut. Veniam perferendis voluptas deleniti aut laudantium enim laboriosam corrupti dolor. Ea recusandae est totam porro corporis. Nobis autem in dignissimos modi dolorem.", "Programmable solution-oriented leverage", true },
                    { 29, "Rhonda", "Nikolaus", "Maiores et autem quia similique reiciendis. Atque suscipit sed illo voluptatem eveniet. Velit neque fuga dolores voluptatibus praesentium quo aut error. Minus totam rerum error. Numquam et explicabo.", "Reverse-engineered 6th generation implementation", true },
                    { 30, "Wilfred", "Stracke", "Quibusdam sint dolorem nisi laborum provident tenetur consequuntur. Repellat voluptate ea at nam voluptatem numquam aliquam quisquam doloremque. Voluptas aperiam necessitatibus exercitationem quo alias itaque deserunt.", "Multi-layered encompassing initiative", true },
                    { 31, "Walter", "Mann", "Et harum provident quae debitis. Quaerat temporibus sed debitis. Vero quo minima repellendus suscipit quidem fugiat. Nisi unde est molestiae sit temporibus sunt consequuntur corrupti tempora. Quia quis nulla voluptatem et ex ea sint. Quisquam adipisci nihil a itaque doloremque tempora debitis et consequatur.", "Multi-layered fault-tolerant concept", true },
                    { 32, "Jose", "Kovacek", "Unde nisi quibusdam sed suscipit. Voluptatibus earum explicabo eaque aperiam magni. Dolor ea dolorem eum dolor officiis. Debitis ut sequi libero sit ut suscipit est sed. Ad aut odit modi provident totam maxime enim fugit.", "Seamless regional encryption", true },
                    { 33, "Felicia", "Ortiz", "Laboriosam sit quo. Quos sapiente nostrum enim sequi neque quo. Animi accusantium sit sed et. Est libero ut quisquam voluptatem omnis quidem eius.", "Fully-configurable tertiary moderator", false },
                    { 34, "Raul", "Tromp", "Sed commodi repellendus nihil est. Ut iusto dolor. Sunt explicabo sit et et error. Qui velit nulla quo nostrum et iusto.", "Switchable modular strategy", false },
                    { 35, "Ramiro", "Powlowski", "Facere autem veritatis commodi in consequatur sit quam. Optio qui tenetur maxime est est aut. Aut et ipsam.", "Extended 3rd generation framework", false },
                    { 36, "May", "Fisher", "Odio perspiciatis similique in porro et at. Illo vel consequuntur dolorem et ducimus magnam possimus quam. Voluptatum et sapiente totam consequatur unde rem.", "Re-engineered mission-critical internet solution", true },
                    { 37, "Tamara", "Gutkowski", "Rerum unde corrupti a rerum quidem quam labore amet sed. Vel voluptas est aut sit et aut earum perspiciatis dolore. Voluptates molestiae aut ipsum itaque. Voluptas fuga voluptates nulla. Aut aliquid ut.", "Total web-enabled utilisation", false },
                    { 38, "Daisy", "Schamberger", "Fuga consequuntur recusandae. Odio rerum repellendus amet dolores aperiam quaerat natus. Fugit provident similique quia aut quos dolor. Consequatur omnis occaecati eligendi accusamus rerum minima odit harum doloremque. Omnis odit et optio.", "Organized modular budgetary management", false },
                    { 39, "Lila", "Sipes", "Doloribus repellendus corrupti ab quia atque quidem quae. Quaerat velit sunt excepturi a. Repellat sint delectus at minus. Dolores sit officia qui nostrum eum facilis. Est ad eius fuga debitis. Eius accusantium eos voluptate adipisci quis voluptatem.", "Object-based zero defect instruction set", true },
                    { 40, "Jennifer", "Mohr", "Quos soluta velit et dicta praesentium consequatur nihil commodi optio. Saepe ad ea dolorum aliquam excepturi. Rerum doloremque nesciunt.", "Team-oriented clear-thinking solution", true },
                    { 41, "Ella", "Gulgowski", "Culpa expedita facere nulla nesciunt officiis mollitia. Autem quibusdam odit sit aut. Ratione fuga quia facere nesciunt odio sed molestias sequi.", "Multi-layered grid-enabled array", false },
                    { 42, "Warren", "Purdy", "Unde deleniti animi placeat perferendis. Sunt magnam sint similique omnis saepe. Natus et facere nihil.", "Quality-focused secondary intranet", false },
                    { 43, "Pamela", "Gorczany", "Non ut omnis repudiandae repellat. Modi reiciendis qui atque dolore tenetur. Ullam incidunt laborum suscipit cumque. Odit facere autem dolore dignissimos non earum eaque cum. Asperiores iure distinctio hic ut.", "Digitized demand-driven local area network", false },
                    { 44, "Priscilla", "Boyle", "Explicabo excepturi reprehenderit voluptatem corporis sapiente sed exercitationem tenetur consequatur. Magni a molestiae omnis animi fuga et. Voluptatem laborum et aut mollitia repellat iusto. Consequatur distinctio corporis totam tempore reiciendis sint. Et nihil consectetur fugiat aliquam reprehenderit natus officiis facere consequatur.", "Proactive 3rd generation adapter", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5236a21a-4938-44ec-a5f0-b4c9a6b5c3d7", "22f6049b-2ebf-40ae-a151-426290c73f9f" },
                    { "60337d3d-0648-4d4e-9544-515326ebae39", "34540300-c10b-47a1-b9f6-75991fd8a470" }
                });
        }
    }
}
