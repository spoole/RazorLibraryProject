using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedLibrarianAndBorrower : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6ffc0068-2d8d-49bd-a8b5-3a081459915a", null, "admin", "ADMIN" },
                    { "749a694d-5fd0-49dc-bca5-5c5d87ab5b4a", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9bb03ad0-83c3-4bba-bb2a-1c8deb7ae6a1", 0, "bec293ae-99be-4524-b089-3a893c5ce93f", "joanna63@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM2gQSQPwYtnCZX92+CMIpgwHCcR1697fmO+InKS7DeTnlEQAR0UOW36RcWJQmvT4g==", "531.826.4233", false, "2a0282f2-7cbd-419c-a725-4f7f4a46f376", false, "Joanna63" },
                    { "b8eee965-6ea3-4e53-af6a-f4d801ed49e6", 0, "7c0dc020-40c7-410f-a7b3-8eb646277e79", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEI2VWeCM99BAklv0AKs2Ah22nGmX3ULfIkKp8yATENRz4avzJddKbHvmvjH6KCyvmw==", null, false, "9ba06c69-4818-4ec9-b5eb-0a1e8a20634a", false, "borrower@library.net" },
                    { "ccc39330-df41-49d3-b774-b75162115eaf", 0, "f24cdac4-7748-49cf-a2e5-dfc317bb03d8", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEF9OXppcoEwc4BYpZX2JvWGn5fYraV4aCdmbK692vHAluAImPEQfnFFbt1/3aT8bzg==", null, false, "a2fc9a02-7e70-46a9-a42f-cd5fce369153", false, "librarian@library.net" },
                    { "dbe77f51-efd5-4095-a013-aefe4f0259c5", 0, "1fb48b4f-862e-4097-88e8-fb72a536803b", "gertrude70@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM39xcl8CVAI3dtTw1pq0MI+Klsl77BvW22ChzyRPJN3nYlVSuJT8dZYQlEfxSo0EQ==", "1-456-773-1315", false, "676a4935-c7ef-430b-b761-ba829eeda021", false, "Gertrude70" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Alicia", "Walsh", "Ut fugiat aut non et a aut ipsum itaque. Dolorem aut error esse. Veritatis perferendis molestias voluptas eveniet laborum et ipsum aliquam qui.", "Sharable client-driven initiative", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rene", "Moore", "Sapiente neque ut aut beatae consequuntur earum magnam repudiandae. Sint et et voluptas cupiditate porro similique nam rerum officia. Dolores qui in molestiae architecto corrupti. Repudiandae eius totam ut at. Voluptatem nobis labore temporibus consectetur. Qui tempora voluptates iure quia corrupti officiis voluptatem voluptatem.", "Persistent optimal help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ryan", "Morar", "Omnis commodi dolore tempore ipsum delectus asperiores facilis quis. Aperiam distinctio ab sit omnis omnis. Ratione libero commodi quaerat. Cumque id mollitia tenetur dolor dolores nihil aliquid maiores qui. Veniam distinctio reprehenderit sed aut tempore autem et sint. Consequatur iure natus dignissimos non magnam aut earum qui in.", "Multi-tiered explicit interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Roderick", "Moen", "Voluptate est reiciendis asperiores voluptatem non repudiandae sed dolores culpa. Dolorem vel fugit laboriosam. Debitis illum et nostrum tenetur nihil iusto.", "Innovative web-enabled open system", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Samuel", "Leuschke", "Aut libero vel exercitationem non voluptatum facilis occaecati. Quia tenetur eveniet adipisci fugiat accusamus rerum. Consequatur sit iure minima voluptas. Numquam ut aspernatur sint aut blanditiis minus tempora culpa. Error ut ut voluptas culpa culpa rerum eos laudantium harum. Atque beatae quia porro et eaque repudiandae dolorem.", "User-friendly responsive functionalities" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mable", "Von", "Cum quia accusantium sit facilis reiciendis. Dolores tempora quasi ut iusto officiis dolorum qui. Omnis dolor laborum at explicabo quo. Ab ipsa in labore ea eveniet perspiciatis accusantium voluptates. Et voluptatibus eligendi earum itaque at eum dolor fugit omnis.", "Streamlined dedicated superstructure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Richard", "Oberbrunner", "Optio commodi quae et et deleniti eaque provident voluptate modi. Ea quo alias eum quia. Praesentium sunt aut quis id reprehenderit animi nam.", "Organized exuding projection" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marvin", "Haley", "Eligendi est qui vel sed dolores minus. Ex placeat nisi enim aliquam dolorum quis iure aspernatur. Velit fugit reiciendis qui eius exercitationem.", "Multi-channelled intermediate collaboration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kenneth", "Hodkiewicz", "Nesciunt repudiandae sed qui quis. Vitae quidem ipsum eos aut unde est. Ullam expedita repellendus et repellendus adipisci vero est eaque minus. Nisi rerum in aliquam officia porro non consectetur.", "Programmable full-range benchmark", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darrel", "Denesik", "Numquam nesciunt quaerat exercitationem facere dolorem sequi nihil. Quod quos dolorem laborum perferendis voluptate. In est exercitationem et similique sunt fuga. Exercitationem eum dolore at. Accusantium rerum qui ut sit.", "Quality-focused systemic success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rudy", "Yundt", "Nemo animi ut repellat officia temporibus dicta molestiae. Quia nulla earum sint nihil minus reiciendis in laborum. Soluta mollitia qui perspiciatis reiciendis officiis nihil facere.", "Virtual intangible orchestration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dominick", "Ritchie", "Temporibus officia sit voluptas qui dolor vel assumenda cupiditate repellendus. Soluta praesentium natus asperiores temporibus culpa qui similique. Sequi non itaque explicabo adipisci rerum voluptates. Magni ipsa voluptatem earum totam laborum consequatur et. Accusantium vel aperiam deleniti aut reiciendis distinctio.", "Devolved motivating array" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sandy", "Ondricka", "Corporis et atque magni. Aut quia quibusdam consectetur delectus mollitia aut et. Aut facere fuga voluptas quo blanditiis. Voluptatem fugit delectus rem totam et perferendis possimus. Perspiciatis praesentium facilis sint voluptates. Sequi nostrum omnis mollitia.", "Decentralized composite support", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Patty", "Windler", "Voluptates voluptatum quibusdam labore. Ipsam aut ipsum fugiat rerum sit. Asperiores occaecati dolor culpa deserunt.", "De-engineered 4th generation database" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kara", "Glover", "Amet ex explicabo ipsam rerum laudantium libero omnis. Ratione ut sapiente iusto enim et ab. Libero voluptates eum quis magni veritatis dolores iusto consequuntur. Ut et accusamus. Id nam facilis.", "Proactive well-modulated challenge", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Erika", "Brakus", "Iure eaque natus magni veritatis veritatis nisi. Blanditiis vel aliquam. Expedita sapiente nihil omnis.", "Reactive regional capacity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Allan", "Stanton", "Magni accusamus odio voluptatem quas perferendis. Odit reprehenderit rerum libero accusamus natus natus. Omnis laudantium quia impedit. Et cumque rerum aut officia. Neque quos est temporibus.", "Optional bi-directional adapter", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gordon", "Morissette", "Commodi sint sit et exercitationem qui occaecati autem accusamus dicta. Et et aspernatur necessitatibus excepturi tempore eos voluptas. Perspiciatis ut doloribus molestiae impedit aut aut et deserunt consequatur.", "Self-enabling even-keeled function", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Robin", "Littel", "Delectus repellat explicabo commodi vero. In reprehenderit ut magni nulla architecto odit qui ex doloribus. Sint iure modi quis beatae. Eveniet omnis est voluptates commodi esse blanditiis consequatur quasi. Ea eius sunt.", "Optional scalable matrices", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carla", "Osinski", "Non qui repellendus. Aperiam commodi cupiditate et est. Optio placeat maiores consequuntur nihil deleniti quis dolores. Officiis itaque sit quia provident distinctio placeat aliquam.", "Profound zero administration approach", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "749a694d-5fd0-49dc-bca5-5c5d87ab5b4a", "b8eee965-6ea3-4e53-af6a-f4d801ed49e6" },
                    { "6ffc0068-2d8d-49bd-a8b5-3a081459915a", "ccc39330-df41-49d3-b774-b75162115eaf" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "749a694d-5fd0-49dc-bca5-5c5d87ab5b4a", "b8eee965-6ea3-4e53-af6a-f4d801ed49e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6ffc0068-2d8d-49bd-a8b5-3a081459915a", "ccc39330-df41-49d3-b774-b75162115eaf" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bb03ad0-83c3-4bba-bb2a-1c8deb7ae6a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbe77f51-efd5-4095-a013-aefe4f0259c5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6ffc0068-2d8d-49bd-a8b5-3a081459915a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "749a694d-5fd0-49dc-bca5-5c5d87ab5b4a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8eee965-6ea3-4e53-af6a-f4d801ed49e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccc39330-df41-49d3-b774-b75162115eaf");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Philip", "Kling", "Mollitia perferendis quod necessitatibus cumque. Enim voluptate libero commodi non est officia beatae odio occaecati. Atque quos vero repellat dolores rerum consequatur.", "Networked motivating adapter", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bridget", "Hoppe", "Et et ipsum maiores illum non ut molestias minus doloremque. Rerum numquam modi. Architecto laboriosam quidem et voluptates. Dolorum ea iusto nemo enim et aut modi.", "Enterprise-wide asynchronous Graphic Interface" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Nathan", "Kris", "Est modi occaecati sit libero ut ad cum qui nihil. Omnis sit numquam impedit atque voluptas temporibus ut suscipit dolorem. Voluptate consequuntur veniam sit eos ipsam vitae. Minus saepe incidunt dolor voluptate repellendus repudiandae corrupti quibusdam. Incidunt eius magni mollitia consequatur minus cum. Delectus perspiciatis eos.", "Face to face leading edge interface", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Neil", "Yundt", "Autem aut quos repudiandae nam facere voluptas ullam distinctio. Sint molestiae nemo. Sunt dolor provident magnam amet reiciendis tempora facilis qui. Ut porro neque voluptas consectetur temporibus dolorum perferendis.", "Up-sized 6th generation migration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Connie", "Dickens", "Est error consequatur. Rerum porro quia possimus voluptatem. Non facere dolor ipsam voluptatem fugit provident ipsam est velit. Qui quo perspiciatis nisi repudiandae.", "Networked regional info-mediaries" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tami", "Schamberger", "Et libero laborum. Laboriosam voluptates vel aspernatur ut repudiandae in. Aut dolor numquam. Tenetur facere ut aut culpa temporibus. Aut aut libero et similique unde sed sit doloremque.", "Diverse demand-driven alliance", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gina", "Metz", "Est et nulla dolore rem eos consequatur accusamus. Sed non et. Accusamus in nisi laudantium enim praesentium sunt hic unde praesentium. Accusamus sint sapiente dolor. Saepe sint veniam sed nam impedit rerum modi maiores et.", "Function-based transitional installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dexter", "Langworth", "Quo aut quam ut aut. Aut iste quis hic quia. Adipisci magni ad quod quis dolorum doloremque eius. Officiis facilis incidunt. Qui incidunt eos quia assumenda aut quo.", "Distributed asymmetric process improvement", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kent", "Stoltenberg", "Repellendus totam repellendus dolores. Doloremque ut molestiae voluptas numquam aliquam odit. Blanditiis corporis optio corrupti sapiente et qui qui eos reprehenderit. Et in eos eum et id. Ut qui incidunt.", "Synchronised stable emulation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Beulah", "Heaney", "Corrupti quos quaerat asperiores. At maxime voluptas quidem voluptatum provident. Voluptas dolor accusantium fuga ex doloremque provident velit. A temporibus et eos cum quis. Cumque in amet numquam ea nostrum aut non ratione.", "Multi-channelled reciprocal pricing structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Edmund", "Bayer", "Vel dolorem laudantium eveniet quia repudiandae. Accusamus nemo suscipit error nihil non est voluptatem sint illum. Quam voluptatem id cum sit autem laboriosam eaque ex. At vel nam consectetur quaerat expedita.", "Diverse attitude-oriented hardware", false });

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

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 21, "Stacey", "Sanford", "Autem eius quis non quas nihil rerum dolorem velit aperiam. Consequatur corrupti aliquam magnam quas voluptatem odit expedita laudantium ut. Doloremque blanditiis quia officiis rerum enim. Omnis vitae suscipit. Laboriosam consequatur rerum iste enim corporis non nostrum id dolorum. Ut et ad est harum debitis vitae.", "Re-contextualized fresh-thinking access", false },
                    { 22, "Caroline", "Howe", "Eos magnam molestias esse consectetur quidem tempore deleniti earum qui. Quaerat non assumenda molestiae incidunt aut dolor. Maiores sequi at expedita minus molestiae cumque sunt est necessitatibus. Ad ut et quaerat fugiat reprehenderit officiis quam eius.", "Ameliorated reciprocal parallelism", true },
                    { 23, "Owen", "Trantow", "Et quaerat deserunt officiis. Magnam dolore voluptas et voluptatem eveniet architecto enim aut dignissimos. Et enim dolores sit necessitatibus et eveniet. Quis suscipit molestiae beatae repellendus veniam dolores.", "Virtual real-time policy", true },
                    { 24, "Rose", "Schimmel", "Dolorum eius dolorum error natus facilis. Inventore saepe qui nihil vel et eligendi molestias. Veritatis praesentium velit non laboriosam animi ut veniam. Debitis consequatur laudantium. Blanditiis aut cupiditate labore.", "Cloned national matrices", true },
                    { 25, "Sara", "Funk", "Ratione quos provident tempore placeat quibusdam molestiae animi earum. Ipsam qui sint et. Culpa aut quidem alias fugiat. Et commodi accusamus debitis dolorem maxime nam ut vero. Numquam quod quia quasi. Error ullam quia consequatur et suscipit sed.", "Reduced disintermediate methodology", true },
                    { 26, "Noah", "Murazik", "Magnam fugiat nesciunt maiores. Dolores rem sit esse ut id. Debitis sint odio non. Recusandae consequatur necessitatibus ab incidunt. Sunt ea quo repellendus. Expedita beatae ab vel adipisci.", "Streamlined national software", true },
                    { 27, "Beatrice", "Mills", "Magni dolorem ut quis et consequatur id perspiciatis delectus. Iure quos distinctio earum earum voluptatem. Et modi tenetur omnis vel vitae sunt repellat et.", "Future-proofed client-server help-desk", true },
                    { 28, "Faye", "Grady", "Animi fuga quas similique autem consequatur ducimus non similique alias. Dolor est eos consequuntur veniam dolor recusandae in. Molestiae quaerat omnis.", "Re-contextualized attitude-oriented product", false },
                    { 29, "Karla", "Jakubowski", "Veniam ipsa esse ipsum reiciendis ea aut. Repellendus omnis temporibus voluptatem maiores. At voluptatem provident quisquam.", "Face to face disintermediate strategy", true },
                    { 30, "Maggie", "McLaughlin", "Sint nihil aut. Illum error fugit qui nam ut sed inventore assumenda voluptatem. Similique doloremque et. Laborum incidunt suscipit earum aut consequuntur hic ipsam dolores laborum. Omnis dolor aut delectus quasi natus. Reiciendis exercitationem praesentium neque.", "Fully-configurable human-resource website", false },
                    { 31, "Joyce", "Heaney", "Nihil modi nobis sapiente iusto asperiores hic veritatis. Repellat et maiores nihil quaerat. Voluptatem vero maiores odio quis sunt. Quia unde reiciendis quia quia. Maiores accusamus voluptatum.", "Synergistic zero administration collaboration", false },
                    { 32, "Tabitha", "Kunde", "Laborum est expedita itaque consequatur tempora. Et totam sint aut nesciunt est atque. Odit eos fugiat ut suscipit reprehenderit possimus dolores aspernatur. Maxime fugit beatae suscipit fugit. Corrupti eius ullam qui temporibus molestias doloribus ut sunt eligendi. Eaque sint et inventore.", "Phased client-driven product", false },
                    { 33, "Ryan", "Predovic", "Ut quia accusantium quia nostrum. Iste perspiciatis magnam sapiente mollitia omnis id. Laboriosam iure voluptatem. Quisquam veniam numquam. Quod ipsam exercitationem aliquid accusamus tempora.", "Realigned uniform system engine", false },
                    { 34, "Nelson", "Rau", "Suscipit ut explicabo illum rem. Consequatur qui quia dolorum corporis eum deleniti quia. Commodi et nemo perferendis vitae. A ducimus quia et voluptates aut cumque. Eos repellendus dolor enim. Sed molestias sint aut quia at.", "Innovative methodical concept", false },
                    { 35, "Miranda", "Stark", "Nihil eligendi vel ut. Cumque doloremque quia molestias. Accusantium ipsum in neque nihil praesentium. Autem a blanditiis veritatis eaque necessitatibus sed. Nihil non earum. Quisquam qui iure vero eveniet recusandae laborum repellendus.", "Down-sized next generation installation", false },
                    { 36, "Blanca", "Smith", "Est deleniti omnis quibusdam esse velit. Dignissimos distinctio tenetur ipsa dolorum impedit nemo nulla pariatur deleniti. Ducimus dolore rerum omnis nam numquam quaerat perspiciatis et nemo.", "Devolved asynchronous monitoring", false },
                    { 37, "Lela", "Mosciski", "Enim officia temporibus voluptate neque placeat repudiandae ea nobis possimus. Esse aut voluptates est tenetur fuga ratione eius. Doloribus dignissimos quia incidunt ex laudantium aut natus. Tempore ea minima nostrum rerum.", "Secured 5th generation local area network", true },
                    { 38, "Miguel", "Schimmel", "Magnam sunt totam autem ut distinctio ut qui nostrum. A rem ipsum eos enim. Cupiditate officiis nobis deserunt dolore laudantium ut possimus. Beatae voluptas magnam quae dolores. Nihil ea cupiditate vitae minima iste. Ea est recusandae.", "Integrated background capacity", true },
                    { 39, "Marsha", "Bednar", "Ea eaque delectus et qui eum enim ullam. Quos dicta earum. Dolor consequatur et vel maiores dolores iusto cupiditate nulla incidunt. Impedit voluptatum ut laudantium nobis.", "Multi-tiered fault-tolerant Graphic Interface", false },
                    { 40, "Betty", "Ferry", "Minus voluptas omnis delectus facere deleniti aperiam nemo. Dolore eos voluptas possimus molestiae corporis enim quisquam sit id. Et aut vel non earum libero quis est at incidunt. Et natus inventore voluptas sed. Nihil deleniti velit illum nobis. Quas atque magni hic omnis tempora iusto et.", "Switchable national policy", false },
                    { 41, "Edith", "Balistreri", "Ad voluptatem consequuntur sequi ipsa vel corporis. Voluptatem illum est laborum sequi architecto. Perspiciatis recusandae voluptate aut recusandae itaque numquam expedita et ut. Blanditiis et eligendi placeat qui et. Labore molestiae accusamus laboriosam doloribus quas cupiditate.", "Synchronised coherent open architecture", true },
                    { 42, "Johnathan", "Davis", "Magnam et vitae nisi laborum voluptates explicabo. Corrupti vero aliquid magni fuga nobis illo culpa rem harum. Vero ducimus necessitatibus.", "Reduced non-volatile methodology", false },
                    { 43, "Michelle", "Carter", "Voluptatem perferendis hic repellendus mollitia fuga vero. Repellendus eligendi eos dolorum fugit dicta eos id accusamus a. Omnis in consequatur maxime velit ut quasi harum vel amet. Eaque vel esse nihil porro fugiat ipsum. Perferendis quisquam provident quibusdam ad voluptate.", "Digitized coherent flexibility", true },
                    { 44, "Lorraine", "Hintz", "Nihil eaque velit deleniti temporibus. Quae consequatur et praesentium nihil non reprehenderit. Error non est iusto ea eaque saepe officia nulla quia. Totam modi consequatur voluptatem.", "Mandatory high-level benchmark", false },
                    { 45, "Leona", "Becker", "Ut vitae similique voluptas praesentium. Sed odio voluptas. Sed qui modi facere sed at rerum repudiandae. Non ipsam harum debitis cum hic voluptatibus aspernatur nihil in. Voluptatum numquam porro suscipit nulla exercitationem et libero optio nemo.", "Proactive system-worthy groupware", false },
                    { 46, "Stephen", "Keebler", "Esse ea non enim numquam et eveniet. Voluptatum occaecati facilis. Consequatur officia odit.", "Fully-configurable needs-based infrastructure", true },
                    { 47, "Lorraine", "Wilderman", "Et adipisci autem quia maiores molestias molestiae qui. Tempora similique sit officiis. Aut ea aliquid voluptatum. Ad alias omnis commodi occaecati et cumque voluptatum explicabo. Illum voluptatem quia magni.", "Reverse-engineered analyzing project", true },
                    { 48, "Heather", "Windler", "Error ad fugiat qui et aut quibusdam omnis. Et sapiente dolor. Aut ipsam assumenda rem ea aut neque qui.", "Visionary logistical support", true },
                    { 49, "Belinda", "Feeney", "Mollitia illo impedit reprehenderit sunt. Quis illum blanditiis saepe rerum molestiae. Illo fugiat alias qui et eum corporis voluptatem. Labore quia placeat amet veniam quam sit.", "Switchable homogeneous toolset", false }
                });
        }
    }
}
