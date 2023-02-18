using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedWhoHasFielToBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2bd6065-b3a8-4f32-995c-bf368da7cddd", "aeb41981-a6c3-4c67-b094-25f0222ef5a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57742dc2-e652-449f-b5a4-0e748a077eff", "d4957041-7e2c-440e-8a3a-af8d975ad80f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53cb596-129e-481a-abed-46a29fc0fcdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5c54cfe-33aa-4f98-8da4-4db14bcd53d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d43312-63c8-4ccf-bb90-c808df44b488");

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
                keyValue: "57742dc2-e652-449f-b5a4-0e748a077eff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2bd6065-b3a8-4f32-995c-bf368da7cddd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeb41981-a6c3-4c67-b094-25f0222ef5a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4957041-7e2c-440e-8a3a-af8d975ad80f");

            migrationBuilder.AddColumn<string>(
                name: "whoHas",
                table: "Book",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "08f08c0f-385f-45b0-80d5-2fc49cb4b561", null, "admin", "ADMIN" },
                    { "d706a9d8-ba64-4219-b862-79ba4d233da1", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "36326f0f-380a-473f-8796-9c79ecdf72c5", 0, "4fcacb42-2820-4c7c-b4ae-d0913b12965e", "User", "bryant.hamill@library.net", false, true, null, "", "bryant.hamill", "AQAAAAIAAYagAAAAECBN07mSYisKA1SYHbpelLK3nn+zyomleQX1gw6oZynN9ooCq0E2GSTOiCamzvm09w==", "631.450.6285", false, "76d4c052-bf2a-4d98-9b1d-6a6202130510", false, "Bryant.Hamill" },
                    { "5f66c37e-215a-420c-b0e7-90be51306276", 0, "7395609c-3669-4c49-ad4e-68e886d56733", "User", "craig_koelpin@library.net", false, true, null, "", "craig_koelpin", "AQAAAAIAAYagAAAAEOuoY9mLCu9KHqLQY8RcibL6fIqq6MKQKBjuhUNy9eM+L+1osmPlYzViIeDxleFk8g==", "1-977-565-5121", false, "b906caa2-fec7-4ea4-9b17-ebfe6e0ac9e8", false, "Craig_Koelpin" },
                    { "61d1ec7b-1098-4d98-acdc-4bc2b2b7ce44", 0, "a54c04d4-762a-4092-b26d-1625c0b214f2", "User", "brooke.rutherford62@library.net", false, true, null, "", "brooke.rutherford62", "AQAAAAIAAYagAAAAENdAzQemXtXLn4x9Cr3VoupVKLCjqapExTmFs9uYd4yPFnOlrZ/yj76638xbDT0acg==", "1-823-659-2382 x2852", false, "eec9a836-d0e2-4900-9d7a-c282c16dd103", false, "Brooke.Rutherford62" },
                    { "6b12c7e1-934a-4bfa-8a1f-910f056af348", 0, "9f551ca8-eb4d-4247-afa8-c73bdb5b977e", "User", "bessie_tillman62@library.net", false, true, null, "", "bessie_tillman62", "AQAAAAIAAYagAAAAELDMF02ZbbbeDpQMp+HOE+C0h0wYg2QLQcRVA5eymEgbNpP53csVNTbeDUfKoPpWDA==", "(796) 767-6043 x638", false, "bfefd396-e2d0-42d7-8f13-3e80d0c79065", false, "Bessie_Tillman62" },
                    { "713725ee-1e0f-4462-80e2-7fc17ed6c291", 0, "d45b5f51-d45a-44a2-9e66-dfb68c6f9db4", "User", "deanna.kuhlman72@library.net", false, true, null, "", "deanna.kuhlman72", "AQAAAAIAAYagAAAAEF+Sj06vDryoyC/MQCuYk9CLQmb8kCSTAq/lNfouD9kfLt9xxr/k2DZKw6HmeYaRww==", "(209) 449-5842", false, "2ce2445b-0945-4809-b365-519977d06f70", false, "Deanna.Kuhlman72" },
                    { "90e80050-92d0-4d08-b383-d54f109a1a34", 0, "44a92510-8c0a-4128-9893-8b7b5f664345", "User", "jose60@library.net", false, true, null, "", "jose60", "AQAAAAIAAYagAAAAEAf1uudZ3Ud0+QxkkKOTKWP3WZdn8OG7zbnocXktwIPGTTa+JCsxB3IXNAA9rshlRQ==", "(732) 200-6098", false, "2a32070a-8883-4b45-b809-8d86021b0fcd", false, "Jose60" },
                    { "92e7559a-6932-456a-8985-e7f13328c0e3", 0, "25ece436-b386-4836-b5a1-654cc4027348", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEFetLLjKGSdBq2Vo+7dlzeZFVtPVM9/MIQe+P+So63ok9vD/6EKi1Qk2oIZ88L68JQ==", "", false, "da03a8c5-4d2e-4f41-b33f-55b0f6f6ca37", false, "librarian@library.net" },
                    { "9a03ef48-6d85-432d-a3fd-7232c270cd70", 0, "1dd62d93-9524-41f8-b193-b895d1ad369a", "User", "guillermo6@library.net", false, true, null, "", "guillermo6", "AQAAAAIAAYagAAAAEDYo57rtNGb4NGwtfRoAsbOZYicZgtyWeW17uOcZ/Iqpqa/zLu1jmljpHpqaBfIW4w==", "1-408-918-8666 x92348", false, "db7464b1-7b0a-4e34-9260-a0cfea3dbb60", false, "Guillermo6" },
                    { "cff3401e-9704-42bf-9d31-db541cacecf9", 0, "f8f3451e-d06e-4210-8c76-7f4ee171adcc", "User", "travis5@library.net", false, true, null, "", "travis5", "AQAAAAIAAYagAAAAEOteD29U8BHOeSP5BWg4amprl32pL9OyQBf5Zg5kvFAbbQW3R1WT/yAokF97qXDBUg==", "529-322-3525", false, "617c0b5a-f414-4e8b-9a6d-8aa3923e389c", false, "Travis5" },
                    { "d388aee2-0d99-480a-a892-dc5fd6795f02", 0, "cba634d8-4edc-44eb-aeda-5e0257e36925", "User", "phil.reichel47@library.net", false, true, null, "", "phil.reichel47", "AQAAAAIAAYagAAAAEOm/NHSyLO2tvtxzMcZK3jLq2m33MY8bvSCBlyU4dNzD109j11qvuNx0loTJqf1h8w==", "735.406.4435 x27389", false, "3c1d8332-2079-415f-879f-715a54b568b3", false, "Phil.Reichel47" },
                    { "d687b52d-c16a-499f-83b0-e12edfb77215", 0, "b73abff1-076e-4055-81e5-8be7a2361307", "User", "allen.jacobs@library.net", false, true, null, "", "allen.jacobs", "AQAAAAIAAYagAAAAEBKXnJlyjoPbTdzaE/NHm/trCIR9xO777Yi586SYWQKH8JBPD/XHSysdG50Q2l8eOA==", "971-260-8349", false, "5f32283a-bdab-4def-839a-cd200944ad05", false, "Allen.Jacobs" },
                    { "db0c6dac-2401-4dfc-9709-3086ddba7a3b", 0, "048c3de6-23d5-46be-a7ab-3a0a6f523ace", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEPmig42pAc7c5SN7mxVUld76kdL8/8DeGpAYQABTvaTYj/FNJgu14L92zMK+xUhSRw==", "", false, "9e301608-0b89-4789-b619-0e0dde271885", false, "borrower@library.net" },
                    { "e89bf3ec-9a78-4764-aa28-81369aba62fb", 0, "5abf0aa5-a9bb-4d2d-b4e2-9caa229e8cc9", "User", "laura.harber@library.net", false, true, null, "", "laura.harber", "AQAAAAIAAYagAAAAELkpZZDbHdVrO7FUI4y0mEXOBdi3b3aT38m60iyikb9xxq7gZESfDZtsbUWpeorTtA==", "1-403-697-5388 x3217", false, "7472cf7c-4225-415d-bb6c-989cd5272913", false, "Laura.Harber" },
                    { "f05a509e-c087-4da2-9808-5abe4176e426", 0, "0f3068d5-0a0d-4c31-a789-25036b5aff0d", "User", "jody.aufderhar@library.net", false, true, null, "", "jody.aufderhar", "AQAAAAIAAYagAAAAENANFxpMlRyq5yxpMcdh6Brlw9lpnTR/bcrGy2PJDDf8FE+EZZIAHxoKOTiEX0CkLw==", "1-890-683-9973 x022", false, "18e0ef44-d8d6-486e-bcad-b528d7a7fac0", false, "Jody.Aufderhar" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Hannah", "Hickle", "Earum in aut reiciendis et optio. Aliquam est quisquam. Non aliquid quam possimus et laboriosam quo quidem architecto. Vel neque dolorum reiciendis adipisci quisquam sunt. Neque aliquid vel sint iusto facilis suscipit nulla. Aperiam expedita minus.", "Reduced context-sensitive product", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Rolando", "Boyer", "Asperiores rerum voluptas. Et unde consequatur et. Voluptas dolore tempore explicabo fugit nisi placeat possimus. Consectetur nostrum repellat non consectetur consequatur rerum. Sint autem itaque. Officiis recusandae qui recusandae corrupti ut quia magnam.", "Balanced analyzing hierarchy", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Kristine", "Muller", "Cum omnis reiciendis iusto aut blanditiis iste est. Aut ullam dolor vel ut delectus itaque fugiat. Commodi magnam debitis vel. Voluptatum quisquam reiciendis et officia harum. Assumenda tenetur dolore consequuntur et voluptas repellat quod qui doloribus. Quia et doloremque eligendi expedita.", "Fundamental multimedia complexity", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Jesus", "McDermott", "Et optio atque rerum sint qui animi. Sint et aut vitae eos non. Nulla laudantium laborum. Vitae quidem nostrum. Similique nostrum repellat vel sint et sint illo. Velit molestiae velit natus et voluptas.", "Innovative logistical help-desk", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Laurie", "Ward", "Repudiandae animi vel omnis. Omnis dolorem adipisci veniam laborum saepe sunt dolor cum similique. Accusamus accusantium consequatur repellendus aut quis at atque atque.", "Multi-lateral dynamic collaboration", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Bernadette", "Hoeger", "Id nostrum hic esse sit. Sit culpa quod soluta consectetur numquam numquam earum enim voluptas. Quam facilis provident quas nisi nam qui numquam eligendi sed. Quibusdam mollitia sed soluta.", "Customizable leading edge open system", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Lana", "Pfannerstill", "Hic quam placeat nulla ut a id rerum. Laborum voluptas rem velit possimus eos laboriosam ut. Nisi asperiores quos a porro nam excepturi dolores. Et ad nemo quasi qui.", "Multi-layered bi-directional contingency", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Erica", "Marvin", "In quas mollitia earum modi. Maiores rerum eaque itaque quasi. Aut officia laudantium iste eum.", "Grass-roots methodical circuit", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Deborah", "Johnston", "Nobis incidunt recusandae consequatur. Vel corporis nulla iste. Est pariatur qui ullam quia autem ea ea molestiae optio. Soluta delectus molestiae et.", "Triple-buffered uniform matrix", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Nelson", "Ritchie", "Voluptatem autem sequi. Eum iste in et. Qui velit saepe soluta voluptatum sit. Ut iste sed ullam qui. Quia fuga sint. Molestiae est aut et sapiente.", "Mandatory non-volatile capability", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Lee", "Koepp", "Reiciendis ab quia odio natus neque beatae. Recusandae velit est exercitationem labore reprehenderit beatae. Odio nobis minus dignissimos fuga voluptatibus accusantium illum magnam. Exercitationem tempore quae in soluta rerum. Et aliquam non asperiores. Recusandae aliquam quasi temporibus.", "Cloned exuding flexibility", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Jeff", "Hessel", "Odit aut vitae placeat dicta autem deleniti laudantium. Architecto maiores et rerum harum quia veritatis quo. Dolores ullam dicta dolorem nesciunt necessitatibus in quae possimus dolorem. Est dolorum velit est sed beatae. Sequi quos dolores blanditiis dolorem. Vitae alias rerum fugiat rem provident corrupti ab.", "Enterprise-wide multi-tasking complexity", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Laverne", "Ritchie", "Aperiam quis sint. Soluta repudiandae sed. Perspiciatis ut aspernatur dolores sunt sunt doloribus consequatur distinctio. Reprehenderit ut nihil nisi aperiam vitae optio dolorem. Neque mollitia ex quia facere et at.", "Open-source homogeneous hub", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Mamie", "Schowalter", "Est inventore quos et sunt explicabo. Eaque doloribus impedit omnis labore esse et. Qui nobis corporis non sit quo error ea eos est. Voluptate consequatur cumque labore aut ratione omnis quaerat ipsa quod. Non sequi voluptate quae illum. Deserunt nihil sed amet reiciendis minima.", "Horizontal radical solution", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Sally", "Williamson", "Illo asperiores eius et fuga provident et. Omnis labore explicabo. Aspernatur cupiditate nihil facilis voluptatibus voluptatem incidunt aut. Culpa consequuntur nemo impedit eum ipsam non ut. Sed eum delectus autem eos consequatur possimus velit deleniti fugit. Veritatis distinctio et temporibus ullam non deserunt ducimus sed quis.", "Face to face solution-oriented alliance", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Terri", "Funk", "Aut sint rerum quasi expedita in. Qui corrupti illum. Quas numquam illum tenetur qui. Est qui aliquam blanditiis voluptatem. Maxime et ea ipsam velit explicabo occaecati.", "Compatible zero administration ability", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Josefina", "Cremin", "Architecto tempora expedita perferendis dicta velit. Quo cum ad iure odio nisi voluptatem qui autem temporibus. Sunt quisquam facilis quas dicta nihil eum non. Eius recusandae aspernatur quisquam perferendis. Harum beatae minima vel dolorem. Expedita aut sequi et cum ea architecto et doloribus id.", "Synergized demand-driven ability", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Jill", "Ortiz", "Sit voluptas et. Reiciendis dicta molestias. Explicabo voluptatem assumenda dolor rem.", "Front-line cohesive monitoring", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Zachary", "Conn", "Quis sed unde aut dicta. Totam consectetur tempora occaecati. Vitae voluptatem facilis autem quos ut sint temporibus tempore ipsum.", "Automated user-facing utilisation", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Krista", "Gulgowski", "Fuga impedit ipsum quam quaerat aut aut. Omnis consequuntur nemo modi totam minima et a possimus. Deleniti et dolor labore tempore qui aut consequatur laudantium. Est libero impedit.", "Innovative optimal toolset", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Anna", "Wilderman", "Temporibus assumenda voluptate aut ut eos. Omnis quia nemo. Enim blanditiis suscipit molestias nulla quibusdam sed ut dicta sint.", "Ameliorated directional implementation", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Noel", "Will", "Doloribus sed cum officia qui odit est placeat explicabo neque. Laboriosam cum et doloribus quam iusto. Optio accusamus distinctio provident maiores.", "Cross-platform global core", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Elena", "Howe", "Aspernatur incidunt repellat mollitia dolor qui quisquam dolor quia. Ratione sed qui ipsum id iste aliquam. Cupiditate repudiandae et odio et alias ab in. Neque porro quam tempore.", "Versatile actuating protocol", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Bobbie", "Rolfson", "Unde ullam voluptas voluptates sed. Unde sint ullam nam dolor suscipit maxime nihil qui quia. Eligendi aut qui ut sunt natus corrupti voluptas sit aut. Voluptatem enim rem iure excepturi architecto facilis dicta reprehenderit.", "Adaptive stable support", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Dorothy", "Cummerata", "Est at tenetur dolores. Hic ut pariatur magni iusto enim. Velit culpa nam maiores. Quos et molestiae autem nisi laudantium dolores. Vel voluptates optio veritatis consequatur minima autem. Atque itaque officiis ut eum non ipsam voluptate voluptas.", "Team-oriented tangible utilisation", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Jeannette", "Klocko", "Voluptas hic dolor. Ipsum rerum consequatur quo omnis vel adipisci. Eum magni maiores assumenda. Dolorem est in inventore beatae.", "Monitored optimizing groupware", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Bruce", "Fahey", "Et in id quo sit quia delectus sint. Nulla perferendis et. Nihil reprehenderit officiis enim accusantium eaque. At ducimus impedit voluptatem ab illum nemo. Pariatur natus omnis excepturi nihil et nulla. Est iure optio tenetur eveniet sit velit vel sequi iste.", "Adaptive object-oriented help-desk", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Melanie", "Schneider", "Sit quam cumque et perferendis ratione ea pariatur. Dolorem error ea est. Deleniti aliquid similique voluptas. Ratione aut et neque velit autem qui molestiae. Voluptatem incidunt velit voluptatem.", "Innovative bi-directional Graphical User Interface", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Teri", "Hilpert", "Inventore maiores reprehenderit molestias nemo. Quas est quasi aperiam. Blanditiis ipsum cupiditate ducimus nam et.", "Exclusive contextually-based artificial intelligence", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Guadalupe", "O'Connell", "Quam assumenda et consequatur nihil rerum molestiae et dolores. Beatae aperiam dolores labore iusto cum. Unde rerum eaque veritatis pariatur.", "Compatible logistical conglomeration", true, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Esther", "Stark", "Ipsam perspiciatis et consequatur ipsam vel eligendi magnam. Iusto laboriosam quo. Quia aut optio ut quo excepturi. Ratione harum numquam veniam nemo fugiat.", "Managed optimal customer loyalty", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Betty", "Lind", "Nobis sapiente eius enim nam dolorem aut voluptas. Et et distinctio nostrum dolores. Blanditiis aspernatur consectetur tempore sint.", "Self-enabling optimal focus group", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Sandy", "Ryan", "Modi nemo maxime voluptas veniam ut inventore quibusdam. Amet nobis rem laboriosam ea mollitia. Ut eos consequatur cupiditate est repellat. Similique dignissimos sed qui consequatur. Sint eveniet inventore consequatur dicta magnam harum dolores voluptatibus ut. Minus aut praesentium aut voluptas ut corrupti est.", "Total modular alliance", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Steven", "Hermann", "In in dolore sit. Facere sint voluptas enim adipisci debitis ducimus ea velit. Quia qui totam corporis. Fugit accusamus officiis cumque soluta aut aliquid quis id inventore.", "Customizable zero administration neural-net", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Bryan", "Fisher", "Distinctio omnis id unde. Molestias id consequatur. Facere in expedita eius est et. Similique tenetur dolorem sit nesciunt impedit reprehenderit.", "Multi-lateral tertiary groupware", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "whoHas" },
                values: new object[] { "Denise", "Kuhn", "Sit reprehenderit voluptas aut et eaque necessitatibus magni. Unde vitae eum pariatur omnis. Est magnam eos. Quas sunt et omnis consectetur assumenda exercitationem animi. Id id facilis. Occaecati harum beatae velit atque voluptatem.", "Grass-roots dynamic artificial intelligence", "admin" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable", "whoHas" },
                values: new object[] { "Jeanne", "Hettinger", "Id et earum. Debitis et harum cum accusantium amet pariatur deserunt. Nobis sed soluta ratione odio porro.", "Enhanced uniform utilisation", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "08f08c0f-385f-45b0-80d5-2fc49cb4b561", "92e7559a-6932-456a-8985-e7f13328c0e3" },
                    { "d706a9d8-ba64-4219-b862-79ba4d233da1", "db0c6dac-2401-4dfc-9709-3086ddba7a3b" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08f08c0f-385f-45b0-80d5-2fc49cb4b561", "92e7559a-6932-456a-8985-e7f13328c0e3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d706a9d8-ba64-4219-b862-79ba4d233da1", "db0c6dac-2401-4dfc-9709-3086ddba7a3b" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "36326f0f-380a-473f-8796-9c79ecdf72c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5f66c37e-215a-420c-b0e7-90be51306276");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d1ec7b-1098-4d98-acdc-4bc2b2b7ce44");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b12c7e1-934a-4bfa-8a1f-910f056af348");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "713725ee-1e0f-4462-80e2-7fc17ed6c291");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "90e80050-92d0-4d08-b383-d54f109a1a34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a03ef48-6d85-432d-a3fd-7232c270cd70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cff3401e-9704-42bf-9d31-db541cacecf9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d388aee2-0d99-480a-a892-dc5fd6795f02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d687b52d-c16a-499f-83b0-e12edfb77215");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e89bf3ec-9a78-4764-aa28-81369aba62fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f05a509e-c087-4da2-9808-5abe4176e426");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08f08c0f-385f-45b0-80d5-2fc49cb4b561");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d706a9d8-ba64-4219-b862-79ba4d233da1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "92e7559a-6932-456a-8985-e7f13328c0e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db0c6dac-2401-4dfc-9709-3086ddba7a3b");

            migrationBuilder.DropColumn(
                name: "whoHas",
                table: "Book");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57742dc2-e652-449f-b5a4-0e748a077eff", null, "admin", "ADMIN" },
                    { "c2bd6065-b3a8-4f32-995c-bf368da7cddd", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aeb41981-a6c3-4c67-b094-25f0222ef5a1", 0, "26432798-9349-4004-81ff-94b9f1a5464c", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEE8w3Z+fj08v/D/CBpC7CcVFbK7QCOpl+mtvXN98HQC6UwYAnSm6d9brog49/lTSEQ==", "", false, "57dccdd7-ffa5-480f-9705-fb602573d6c8", false, "borrower@library.net" },
                    { "b53cb596-129e-481a-abed-46a29fc0fcdc", 0, "fe322964-f6cb-4e53-a946-e8b2717d2f68", "User", "dorothy_brown71@library.net", false, true, null, "", "dorothy_brown71", "AQAAAAIAAYagAAAAEJfdxmsvfaidSTEQi+q2DC/kMx1cwwtWjyeEXCygwX1+rp5GNp2cSBiXESbhAUN2YQ==", "257.854.1624 x898", false, "4c2b7534-6362-4018-a8bf-9b326d3d8285", false, "Dorothy_Brown71" },
                    { "c5c54cfe-33aa-4f98-8da4-4db14bcd53d8", 0, "79c4648d-c0e4-466d-b41f-4fe668fd6a31", "User", "eileen.hoeger@library.net", false, true, null, "", "eileen.hoeger", "AQAAAAIAAYagAAAAEOVhvBLxqTlwbuPBqenEB31Ra+iPR/fwFOr/7zr4/vOI2JGEWkhGkH05jTGRxuUmzA==", "(919) 858-1744 x46544", false, "e2de3da7-d1b9-43b4-b493-a4876510828f", false, "Eileen.Hoeger" },
                    { "c9d43312-63c8-4ccf-bb90-c808df44b488", 0, "78e6984e-b140-4527-b5b3-22f4aa814621", "User", "sarah_deckow86@library.net", false, true, null, "", "sarah_deckow86", "AQAAAAIAAYagAAAAELLEaAacNvFGsoR1cFeXnCT73gTM0Ym3jBvETbhctPvgtL4VNmT5Z7iRgwLKXd49aw==", "(553) 201-6073", false, "b67b162a-59ca-46ee-bdea-c1f7791b648a", false, "Sarah_Deckow86" },
                    { "d4957041-7e2c-440e-8a3a-af8d975ad80f", 0, "002e1851-a715-416c-b8dc-08738deb3028", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEKElW0+pnChpFYXSglP0triKIFaQbA3eHMLEB/vFu7wgtjCNMtjhCHnI/JRBR+YQeQ==", "", false, "4c1535dd-cef0-4ded-9842-5f1a23eaffad", false, "librarian@library.net" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gayle", "O'Hara", "Culpa aut accusantium consequatur eligendi culpa expedita quia quia. Quo et error. Vero dolore eaque omnis veritatis dolores molestiae. Aliquid et quasi vitae. Quisquam nostrum ullam ipsam quos debitis. Repellat voluptatibus est necessitatibus omnis et.", "Enhanced empowering capability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ira", "Sawayn", "Voluptatem adipisci omnis corporis quia mollitia laboriosam deserunt. Quod consequatur sit. Corporis voluptatum cumque deleniti nisi. Et et aut ut perspiciatis sapiente quaerat sed rerum. Quia quasi quisquam voluptatem dolor cupiditate esse.", "Compatible logistical software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Delbert", "Roob", "Exercitationem numquam doloribus ut adipisci voluptatibus accusamus. Velit illo voluptatibus facilis non corrupti ut harum quis distinctio. Tempora suscipit eos aliquid fugiat natus ipsa sunt soluta. Eum consequatur quo quisquam. Vero sed aut nihil ea eos in velit illo et. Molestias expedita aperiam et illo aut a.", "Vision-oriented logistical open system", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Casey", "Schowalter", "A quidem et sint accusantium adipisci sunt ut. Repellendus cum sapiente nihil veniam magni nobis veniam sit nihil. Quasi molestiae explicabo qui blanditiis error blanditiis. Est iste unde magnam culpa dignissimos nostrum dolores. Optio sunt illo.", "Multi-tiered high-level attitude" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Willard", "Schamberger", "Cupiditate deleniti qui minima perspiciatis ut animi. Laboriosam est debitis quia. Quasi aut porro repellendus fuga voluptatem quae itaque. Commodi ut eos cumque. Fuga dolorem placeat dolores molestiae omnis.", "Universal system-worthy solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jessica", "Harris", "Quaerat beatae molestias earum expedita et. Deserunt earum velit itaque. Delectus et odit nisi necessitatibus quia dolorum cum. Laborum dignissimos voluptas et est eligendi accusamus dignissimos harum temporibus. A eaque at distinctio aut voluptates est aliquid. Accusamus at recusandae repellat cum eos consequatur.", "Open-architected discrete installation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristopher", "Bins", "Ut quod vel sint. Reprehenderit iusto eius voluptatibus. Fuga autem expedita ratione nihil ducimus ullam aut sint repellendus. Minus provident reprehenderit eum. Fuga non culpa. Debitis sunt sint exercitationem minima possimus.", "Innovative zero defect methodology", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Beulah", "Emard", "Voluptas nostrum nihil dolorum blanditiis. Quia quia natus ut ex nesciunt qui. Dolor nobis nesciunt pariatur quis ut.", "Profound hybrid moratorium" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kirk", "Conroy", "Ullam et nihil et reiciendis voluptas nemo. Officiis quo dignissimos rem. Ad aut commodi molestiae molestiae iure quaerat. Ad commodi eos doloremque recusandae non qui voluptas dolorem. Sed deserunt accusantium neque labore quasi doloremque unde et.", "Monitored reciprocal hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dale", "Sauer", "Praesentium occaecati enim autem labore maiores. Asperiores non et harum. Corrupti quam ullam expedita saepe beatae. At commodi quis et voluptas. Enim distinctio in hic repudiandae quae.", "Pre-emptive heuristic Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nettie", "Konopelski", "Voluptatem quisquam porro cumque. Voluptas molestiae hic. Ex et ipsam quod autem maiores praesentium sequi facilis. Aliquam qui quia iste distinctio velit laborum impedit. Earum vel dolorem dolores. Voluptates vel sit minus illo.", "Polarised asynchronous intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jeremy", "Conn", "Et et optio in inventore sed non est. Magni rerum dolor eos pariatur necessitatibus omnis ut ratione. Possimus est id non laborum ratione sit perferendis. Et dolores explicabo aut iure non voluptatibus unde.", "Programmable fault-tolerant internet solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Victoria", "Armstrong", "Deserunt aut pariatur excepturi ducimus error. Quasi beatae ut quasi est voluptas temporibus. Vel ex corporis atque asperiores voluptatem vel non. Accusantium rerum aspernatur est quae quo.", "Synchronised grid-enabled adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lori", "Bayer", "In velit rem ab voluptas reiciendis ut deserunt eos sunt. Et quisquam veritatis dolor beatae non earum et commodi sint. Velit dolor at veritatis sit. Quasi non esse rerum qui saepe mollitia. Totam aut libero necessitatibus doloribus quasi debitis quibusdam sint eius.", "Vision-oriented heuristic paradigm", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bradley", "West", "Voluptas aut ex error maiores. Iure adipisci quia unde. Quo porro commodi sed facere sit mollitia sequi dolor quisquam.", "Exclusive content-based throughput" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lisa", "Schimmel", "Nulla odio tempore. Totam rem corporis ipsam omnis id et molestiae possimus dignissimos. Culpa eligendi voluptatem quo nam cumque dolor velit.", "Virtual non-volatile open architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Paulette", "Romaguera", "Veniam libero quia ex maiores quis dicta quod. Natus et consequatur eos officiis soluta. Tempore deserunt quibusdam qui modi provident. Placeat et dolor voluptatem. Atque est quis.", "Compatible zero administration contingency" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marie", "Herman", "Cum sint aliquam minus unde omnis. Ex officiis incidunt esse pariatur ut ducimus. Sit qui unde accusamus. Amet exercitationem voluptas qui est aliquid iusto.", "Compatible context-sensitive frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jenna", "Veum", "Voluptatem dolor vel ut eius similique enim. Itaque facere sit molestias doloribus aut molestiae saepe. Voluptas et officiis modi dicta sapiente dolore laboriosam voluptatum. Accusantium aut laboriosam distinctio et consequatur exercitationem vitae.", "Synergized uniform success", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rudolph", "Stanton", "Qui in repellendus rem. Dolorem quas unde sed. Voluptatem et aut quo molestiae temporibus aut. Aliquid quo iusto qui ipsam.", "Decentralized background hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Raymond", "Deckow", "Et doloribus quas. Dolor consequatur nisi ad mollitia saepe velit sed esse. Hic explicabo ex est placeat exercitationem. Quia qui fugiat. Ullam ut rerum sed.", "Synergized client-server open architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Georgia", "Hartmann", "Sunt alias enim quisquam veritatis dolorem quo. Beatae aut id praesentium hic facilis voluptatibus optio perferendis. Consequatur nihil aut. Ipsa eligendi omnis et qui labore tempora sint. Voluptatem eligendi est. Consectetur ex architecto.", "Enterprise-wide needs-based budgetary management", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shawna", "Bashirian", "Corrupti aut non eius. Deserunt eum vitae sit perspiciatis. Rerum ea minima numquam sunt vitae. Voluptatibus et et dolorem beatae.", "Public-key regional standardization", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Opal", "Pfannerstill", "Qui voluptatem autem dicta reprehenderit enim ut necessitatibus. Aut eos qui. Aperiam velit necessitatibus. Hic et enim accusamus sapiente quas voluptates consectetur ut. Nesciunt aut et maxime assumenda reprehenderit. Animi esse exercitationem blanditiis deserunt dolorem consequuntur.", "Monitored bi-directional function" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "James", "Green", "Error dolor odio cupiditate voluptatem quia explicabo nemo voluptas. Dolore et temporibus saepe possimus ex magni illum voluptatum. Impedit ut pariatur eos minus aut sit. Repellat pariatur illum velit non architecto facilis adipisci. Omnis ipsum consequatur voluptatem aliquid. Laborum amet qui ad repellat deserunt dolorem nam.", "Customer-focused mobile secured line" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Fernando", "Turcotte", "Ducimus facere quo necessitatibus. Voluptatem accusantium in vitae nobis. Ad fugiat ea mollitia adipisci. Eos eaque quae dolores sit blanditiis. Quia quisquam tenetur distinctio sed reprehenderit quia inventore ullam.", "Distributed intangible core", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Amber", "Goyette", "Enim nesciunt autem a cupiditate. Ipsam sequi repellendus qui velit odio. Fugiat quia possimus eum nostrum distinctio culpa dolor omnis libero.", "Triple-buffered explicit hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Pearl", "VonRueden", "Aliquid enim autem consequuntur voluptatum. Nihil assumenda iure repellat. Aliquid ut nesciunt omnis ab quidem ea non ab qui.", "Upgradable systemic solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rosemary", "Medhurst", "Atque rerum atque ipsam porro. Sed consequatur omnis ut accusantium tempore. Similique voluptas dolore sed soluta fugit repellendus.", "Synergized clear-thinking workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sonja", "Nienow", "Eaque veniam placeat laboriosam nihil magnam quisquam quas. Voluptatem neque et fugit ratione non. Distinctio explicabo praesentium iure tenetur.", "Re-contextualized 5th generation projection", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tonya", "Schoen", "Ut placeat sint. Maiores assumenda rem totam voluptas similique. Dolor molestiae quia dolor et nihil fugit. Soluta nemo at ratione voluptatem hic delectus necessitatibus dolorum reprehenderit. Rerum fugiat iste ut ipsam cupiditate natus tempora in.", "Re-engineered multimedia emulation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kelly", "Dare", "Sunt tenetur explicabo debitis accusamus explicabo odit tenetur earum. Nam eos quia. Quas quod aut omnis quidem rerum voluptatem qui. Fugit dolor esse sed veritatis.", "Versatile analyzing workforce", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Javier", "Dicki", "Aut ratione tempora dolorem ratione ad. Necessitatibus perspiciatis excepturi et neque in pariatur quo. Quis a ut et quia quis et vel. Repudiandae numquam dignissimos sunt doloribus illum perspiciatis facilis.", "Intuitive reciprocal intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kenneth", "O'Connell", "Incidunt qui voluptas quia sed dignissimos explicabo fuga voluptatem blanditiis. In ullam alias deserunt incidunt in quibusdam voluptatem. Qui officiis illum officiis assumenda.", "Seamless asynchronous access" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Geoffrey", "Schoen", "Nemo repellat aut suscipit rem. Ducimus quia dolores. Error velit recusandae. Doloremque totam laboriosam cupiditate. Sed recusandae sapiente qui sunt deleniti aspernatur dolorum. Voluptatum omnis quaerat error officia architecto dolore velit.", "User-friendly reciprocal solution", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rudy", "Hilpert", "Ab dicta praesentium animi. Et ut possimus excepturi veniam qui. Et earum molestias ut.", "Monitored client-server ability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Adrienne", "Marvin", "Ea qui expedita aperiam accusantium eaque eos fuga porro. Fugiat asperiores enim porro praesentium. Numquam modi alias nihil. Aliquid omnis enim. Repudiandae numquam deleniti earum nesciunt dolores consequatur harum.", "Team-oriented leading edge interface", true });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 38, "Jimmie", "Bruen", "Quod est dolorem quo dolorum fuga tempore et. Ut rerum recusandae cum. Omnis delectus et ut ut ab quis.", "Polarised zero defect software", false },
                    { 39, "Ebony", "Hills", "Quia sit quo et quos tempora ex sed quae. Voluptatem reiciendis ipsum pariatur rerum qui sunt est. Sed ipsa aut ducimus placeat occaecati sunt quidem. Praesentium quia aperiam molestiae aliquid quidem consequatur soluta voluptas.", "Realigned asymmetric productivity", true },
                    { 40, "Kyle", "Goyette", "Laborum doloremque inventore omnis fugit ratione praesentium. Atque eligendi et voluptates libero exercitationem maxime laborum. Et odit assumenda at magnam consequuntur nihil. Rerum fugiat est odit hic similique dolores omnis. Fugit libero qui ipsum perspiciatis.", "Extended methodical middleware", false },
                    { 41, "Angel", "Brekke", "Nihil asperiores quis autem. Ipsum voluptatem corrupti ab est rem cupiditate ea. Ea earum dolorem sed ea odio aliquam consequuntur ut voluptate. Ipsam ad corrupti. Qui consectetur vel quia est deserunt similique. Asperiores est blanditiis qui error voluptates sed est laborum qui.", "Decentralized multi-tasking time-frame", true },
                    { 42, "Rodney", "Halvorson", "Et consequatur atque. Sequi consequatur illum est qui porro similique. Ut quia aut numquam sunt architecto. Ut consequatur quo ea pariatur.", "Self-enabling encompassing firmware", false },
                    { 43, "Andrea", "Nikolaus", "Sed voluptate aut sit recusandae vero temporibus. Doloribus architecto vel aut quo. Eos accusantium modi. Ipsam accusamus repudiandae illo fuga magni sapiente rerum et consequuntur.", "User-centric national approach", true },
                    { 44, "Walter", "Hartmann", "Excepturi animi dolor perferendis et impedit aperiam. Occaecati enim eos. Labore consequatur sint asperiores et qui dicta culpa.", "Advanced 24 hour implementation", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c2bd6065-b3a8-4f32-995c-bf368da7cddd", "aeb41981-a6c3-4c67-b094-25f0222ef5a1" },
                    { "57742dc2-e652-449f-b5a4-0e748a077eff", "d4957041-7e2c-440e-8a3a-af8d975ad80f" }
                });
        }
    }
}
