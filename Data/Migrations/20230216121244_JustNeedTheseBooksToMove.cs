using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class JustNeedTheseBooksToMove : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5164b750-e7dc-4e7f-9b8a-2388bbd16774", "3add4d20-f790-49e2-a335-b024b85f340a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3f2a536-34ba-4a13-a28c-360a220d2335", "73b538d5-3afb-4534-95dc-1e66e24d4047" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13649cb6-3979-4417-94f6-fc78f5f2ed4e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fe467a3-6c36-4ba6-964a-044627c69426");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "392c2b6b-cb7f-492e-8f46-e1cb5584e2bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "644a3614-7dee-4d8e-8138-79cc44df686d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf101aa7-9dad-4f88-ade4-e2a29277aa0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8e0094d-7c7a-4490-b2ef-49dc202ad3b0");

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20);

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5164b750-e7dc-4e7f-9b8a-2388bbd16774");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3f2a536-34ba-4a13-a28c-360a220d2335");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3add4d20-f790-49e2-a335-b024b85f340a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73b538d5-3afb-4534-95dc-1e66e24d4047");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "79def9d3-b27b-4b61-8760-5a203989e66d", null, "admin", "ADMIN" },
                    { "d514ddad-c571-4f8c-9f98-feb64cf43687", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "000d28c2-28e6-4127-be2f-6dcd021798bb", 0, "d495bc51-60a8-475f-aff3-22af1147be2a", "christopher11@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJAAM9jAiwh/eo+MncygmWqBYyQ9t3AGmXd/dxCbMSYob+e2+bC/tkIWHqMmhpIlUg==", "782-271-1673 x36499", false, "455f9e34-8ffc-44b1-bc53-139c1f624aa9", false, "Christopher11" },
                    { "02f36c4e-cc0a-4cad-8123-fce64015a172", 0, "d6a0a076-f464-4a78-be71-f492c8222657", "karla.pollich@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENwJM5R38pzmmcWC3xVWkMxVCmgVzmsmzj153paCspR2mRnpHhol3gCmtbjRJM8Rpg==", "660-954-6311", false, "52a098e5-6203-453b-b9ea-5538cf0714d5", false, "Karla.Pollich" },
                    { "13033fa8-5218-4c9a-9ede-0232ac02cb2a", 0, "b43315e1-a60f-4f57-84e6-2639b072e45e", "brian25@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDgreTDnbux5x1kWEX3mFzSOKz1ytOYsZlX9xaQZXyXTzS0HOKcguWncdN/9Yhm3bA==", "959-277-8479", false, "b90996cd-86c9-43c3-8d87-9f9c264c5fe1", false, "Brian25" },
                    { "177e0c79-3da8-404a-9621-103021a01cd4", 0, "d2f485e1-9ee6-45bf-85e2-71ac023088de", "terrence.steuber@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHYMGU0KCYB7S2Oc3ASlJrqU9DP4GO46TNm4RH24Pb8XQYMjno/fcnmUXaT1V9QN5A==", "553.272.1085 x35658", false, "d7962c28-c8d1-4133-8a16-27d233aa912f", false, "Terrence.Steuber" },
                    { "6c053872-0689-4309-ba4e-8e3e9054a0cc", 0, "a3297eac-7a5f-4382-b90b-848a5945f0d9", "gilberto52@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMhzTu3XSbY1adRwdifkIvMxmRB4ymuHNWaewU4KvxQDHgGE+kmXCo68myk6cNwSqQ==", "256.589.0625 x44813", false, "85c290f2-e9e4-44cf-92ef-385c8605c1b9", false, "Gilberto52" },
                    { "7cb4926d-b477-4e08-b943-7379702870fc", 0, "30cbbc5d-f840-4d1d-8934-762d755cb236", "raquel_kirlin@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENJTAjOqSgei9tviKe8vVGVc/s6K/xtP5b+nYf3N0aPTD57yW1/w5NpRYVteiWaItg==", "(268) 578-3031 x40175", false, "e138184b-18d3-49e8-8d32-f04072b9b48e", false, "Raquel_Kirlin" },
                    { "7fb6815b-00a5-4873-ad30-e486699fae3c", 0, "70cbdb32-9b1b-41fc-8cd1-1f1fbd99aa56", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEDKVVvMiSxl25d4MBd4R2IOiBDyWvnjAKGAcfEIPoZP1G7IfTkYAg4ae+WLBhOW3nA==", null, false, "8f755460-2149-49b4-a45d-c0a63b1820b6", false, "borrower@library.net" },
                    { "86167717-26ab-4728-8fca-a8fcc5d0ab47", 0, "04269e92-d6ca-460d-b427-a241a1f4d8b5", "pat73@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBnui3CRPdbYJHfBwsQRBkccvxoVlUHCeRah9bYuXehI6boc5G49sMatCMxo2pxtZg==", "929-866-9309", false, "9153d666-9eb8-43b8-b730-611af1ac5f67", false, "Pat73" },
                    { "8fde4435-b65c-4118-9b07-777dc36de1ec", 0, "212290d9-22d0-4d21-a05b-f62a230a923e", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEOwd8m/UGdkzqZ7tTAScqJYi8nuKlqDt7mf6VixkAzUSsIK61oePGrlpM+m75h1Ssg==", null, false, "ad68a1bf-cdef-4cdc-b6ef-fa5be7822fd8", false, "librarian@library.net" },
                    { "9d1c7649-4187-4ff9-aa24-7cbf72533d56", 0, "9de576b4-340f-4222-b8c1-0a0dda132795", "brandon.oberbrunner18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM7qImjf8hINcJUnNuoU1jaOni3+OvaJSVTw09VPqSpDlUZePoCmpOXXfYykolY8QA==", "581-635-9342 x752", false, "e0d4708a-90bb-4c98-bb1f-2d9e3b8308d7", false, "Brandon.Oberbrunner18" },
                    { "a5a0ea15-a7be-4c51-9f97-91a0b9e8b5aa", 0, "0237fe14-357f-4a78-ba67-52f0eac9c2ed", "debbie.konopelski@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDpWvNyfrDNNLPs3bbcWudx+d2BOARftJcup+fw48oXmOBBZcjkG/FHQrkncD8OCBw==", "888-530-7928 x949", false, "91fd3751-1ddd-4127-954a-70df9342afd2", false, "Debbie.Konopelski" },
                    { "b6fbeaf2-5abe-44a8-b5dc-83c5d3a1f7b3", 0, "e69aebb3-83db-404a-8bc0-d12f3cb92cbf", "jeremiah.schoen50@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMihyRFW/GOTQnvtaKWCeKkklSpN88DV8WEeeiKtnBmr4FUFxwSpDdNuPcbkh4RqBQ==", "1-264-664-7726 x958", false, "4edc7c74-d423-42d1-a3a9-211710b76101", false, "Jeremiah.Schoen50" },
                    { "d7cda298-606f-4d4d-9b31-c795df3f90ed", 0, "d7c6c910-4144-48a3-976f-77340449d8ad", "leonard60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFSdXGRQIzeiw0EWvSUhU+z9KUIWt7S+eLl7zu5xv4uhlzpomY/2Y4K/CNyv2fEGgA==", "(839) 768-9207 x78327", false, "f7361e54-ecb1-4c82-a513-f56e2a64dfb6", false, "Leonard60" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Patrick", "Zemlak", "Possimus explicabo dignissimos minima aspernatur. Occaecati aut ipsum quia ex. In sint qui. Quod aut veniam soluta laudantium earum facere ducimus.", "Expanded zero defect matrices", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Linda", "Heidenreich", "Nulla et laboriosam laborum sunt qui similique dolor. Eius hic alias minima laudantium et quisquam architecto et sit. Molestiae quibusdam necessitatibus amet et sed dolores adipisci.", "Triple-buffered foreground hub", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terrance", "Leffler", "Harum et vel tempore suscipit veniam voluptatum quia. Dolor voluptatem est voluptas assumenda ut tenetur sunt expedita reiciendis. Autem quia molestiae. Id rerum omnis consequatur vero et dolore ab. Repudiandae aliquam tenetur dolore iusto inventore et nesciunt. Quas sit recusandae quo.", "Ergonomic motivating intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lydia", "Cummerata", "Et et ut eveniet alias et. Et expedita omnis distinctio ad distinctio. Minus consequatur fugiat incidunt assumenda officiis autem. Et ratione animi. Qui molestiae omnis perferendis porro dolorem veritatis. Beatae fugit omnis voluptas aliquam accusamus.", "Advanced grid-enabled implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elizabeth", "Dickens", "Dolorum quidem reprehenderit cum. Facere corporis quia rerum enim. Est iusto dolor eaque quia et laboriosam iusto est. Eius et reprehenderit modi.", "Re-contextualized full-range success", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kimberly", "Daniel", "Optio quo dolorem aut. Quia animi labore rem. Doloremque et vero sunt quod ex quia quasi accusantium. Esse eos facere vel et. Neque minus repellat et necessitatibus harum consequatur corporis sunt pariatur.", "Right-sized object-oriented frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kristin", "Hermann", "Optio in quae animi. Impedit est sint consequatur doloremque vel aut eveniet. Error cupiditate asperiores similique non doloribus tempora voluptatem eligendi eos.", "Total non-volatile attitude" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Victoria", "Wunsch", "Dolor ullam autem animi qui vero. Earum et et veritatis et ut et. Iusto laboriosam modi commodi cumque sed eligendi. Nobis debitis nesciunt perferendis quo. Quo earum eum autem voluptate libero ut rerum minus temporibus. Voluptatem magnam dolorem excepturi.", "Secured regional support", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lydia", "Wintheiser", "Vel est deserunt voluptates laborum doloremque ea cupiditate perferendis. Commodi laudantium dicta rerum quas quasi ea nemo optio. Ex eligendi fuga. Possimus repellendus est corporis nostrum qui consequuntur exercitationem. Exercitationem deserunt ducimus excepturi est unde qui sit.", "Polarised asymmetric capability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dan", "Wintheiser", "Voluptatem velit voluptatibus. Minima eos sed. Repellendus id eos nihil ullam.", "Front-line secondary implementation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristen", "Wunsch", "Deleniti sint quia at sed facilis nulla aut rerum. Rerum illum ex in repellat quis ab ex odio nihil. Officiis dolorem qui non sunt molestias fuga suscipit dolorum et. Soluta tenetur voluptatem odit voluptas libero omnis est aliquam. Eveniet itaque et molestiae sequi maiores.", "Centralized responsive archive", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gabriel", "Schmidt", "Ut quo autem. Iure quos odit rem et consequatur a vitae sapiente ipsum. Soluta voluptatem minus est quae ut ipsam veniam dolorem nobis. Illum cumque sed nesciunt incidunt et aut corporis. Natus sed consequuntur et aperiam sit cumque recusandae et quo.", "Focused asymmetric benchmark" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Julia", "Shanahan", "Sunt qui perspiciatis nihil. Voluptatem fuga aliquid sit commodi dolorum accusamus ad a. Dolores dolor dignissimos. Tenetur sunt fugiat blanditiis quam consequuntur. Accusantium ut quisquam quod perspiciatis debitis a excepturi vel. Commodi in recusandae est iusto ut.", "Reduced 24/7 projection", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d514ddad-c571-4f8c-9f98-feb64cf43687", "7fb6815b-00a5-4873-ad30-e486699fae3c" },
                    { "79def9d3-b27b-4b61-8760-5a203989e66d", "8fde4435-b65c-4118-9b07-777dc36de1ec" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d514ddad-c571-4f8c-9f98-feb64cf43687", "7fb6815b-00a5-4873-ad30-e486699fae3c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "79def9d3-b27b-4b61-8760-5a203989e66d", "8fde4435-b65c-4118-9b07-777dc36de1ec" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "000d28c2-28e6-4127-be2f-6dcd021798bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02f36c4e-cc0a-4cad-8123-fce64015a172");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13033fa8-5218-4c9a-9ede-0232ac02cb2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "177e0c79-3da8-404a-9621-103021a01cd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6c053872-0689-4309-ba4e-8e3e9054a0cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7cb4926d-b477-4e08-b943-7379702870fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86167717-26ab-4728-8fca-a8fcc5d0ab47");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d1c7649-4187-4ff9-aa24-7cbf72533d56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5a0ea15-a7be-4c51-9f97-91a0b9e8b5aa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6fbeaf2-5abe-44a8-b5dc-83c5d3a1f7b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7cda298-606f-4d4d-9b31-c795df3f90ed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79def9d3-b27b-4b61-8760-5a203989e66d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d514ddad-c571-4f8c-9f98-feb64cf43687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fb6815b-00a5-4873-ad30-e486699fae3c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8fde4435-b65c-4118-9b07-777dc36de1ec");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5164b750-e7dc-4e7f-9b8a-2388bbd16774", null, "borrower", "BORROWER" },
                    { "b3f2a536-34ba-4a13-a28c-360a220d2335", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "13649cb6-3979-4417-94f6-fc78f5f2ed4e", 0, "a746bdb0-4b00-4a8f-8cd0-4c73cfa29d45", "natalie.becker@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDC/YEMBlawoC6jFS6B2OuR55lo0+wwlRtrYN+Xzix7muH3qL28yzjb/sUIPuwfTRQ==", "442.371.4794 x4060", false, "a5d9ef69-bb4c-452d-8e54-20c7260cc7df", false, "Natalie.Becker" },
                    { "2fe467a3-6c36-4ba6-964a-044627c69426", 0, "2b7cae12-ecab-47fe-8d43-6905c53dcc46", "philip_runte@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOTWFZ6YL5+4IhKopUvwXyT74fJUfUKZGMzMYzJz2BmilustmUbee9wjE3jeoY9mDQ==", "1-632-238-7547", false, "4ee67cfb-b386-4684-8f2c-417fa92d245c", false, "Philip_Runte" },
                    { "392c2b6b-cb7f-492e-8f46-e1cb5584e2bc", 0, "0c052891-56a7-4af8-a907-f3299dbab0fe", "marion_hudson@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJYjNsOuwXadGfAqXX+5y1Xgzh4ki53qIir86rrvrgtNthoBqDSZuItqpr/g4T1t4Q==", "1-683-882-3546", false, "cbcfb0de-34a9-4f8b-94c5-d46b7805e7c5", false, "Marion_Hudson" },
                    { "3add4d20-f790-49e2-a335-b024b85f340a", 0, "b62aa9c2-f955-43b2-beb5-4cef28cd9c5b", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEHm+aQY9kk+8EyMdkHnL/KzuV+hDsX9mdKrUfyrO1sVuvim1p6ua/AYMua8l5f08uQ==", null, false, "fc4b169f-ab75-4f07-9318-5ff0b8969a6e", false, "borrower@library.net" },
                    { "644a3614-7dee-4d8e-8138-79cc44df686d", 0, "6a780559-9d18-4998-8915-95e64a42dc5c", "ellis32@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGAi49mvr7aArMM6ZYOXTPl5k37hysfOjJdTNnDtjk4lVpAumrKkvW4tSO8LFa+ZTQ==", "278.246.9438", false, "7e5c8894-4573-4841-96d6-3f27073d854b", false, "Ellis32" },
                    { "73b538d5-3afb-4534-95dc-1e66e24d4047", 0, "fb16fa09-8512-486c-b036-60fb4e0c5b99", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEKwPHcoEziRzERDhisz4hTeEkvxh+vhl6P3tD6fyoyxSt5nXiQDDYs+icmHD6j+Hbw==", null, false, "7170eede-ccf0-4008-841c-2cdd85e92162", false, "librarian@library.net" },
                    { "cf101aa7-9dad-4f88-ade4-e2a29277aa0e", 0, "7914d598-65d3-4540-a365-2a23e5811a58", "marcos_runolfsson63@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDCEEs3UphJ8P++CmoaTz6T9heGoDIuji6iDKwxUB9Bq+ULgmx603FVzoU1UGZqNJA==", "(869) 243-5642 x05761", false, "e7267340-927d-4b58-b7ae-e1ef45175ea4", false, "Marcos_Runolfsson63" },
                    { "f8e0094d-7c7a-4490-b2ef-49dc202ad3b0", 0, "a4e87cd3-7b75-4cde-a9de-0b873c034d47", "arnold_rohan@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGvodtkvFZtHdceKNXTdXanG0h/8enQ3qAJdhgsKLUYOs8c//5hBEMPHVYDz0S7ipg==", "652.697.2941 x73718", false, "e8c2ac30-e6f6-42b7-9492-d082f2d12044", false, "Arnold_Rohan" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mindy", "West", "Qui officiis quod aliquid est tenetur itaque. Inventore enim voluptatem vero ea ab necessitatibus deserunt. Et et reiciendis in eaque. Eligendi consequuntur qui sit perspiciatis.", "Diverse upward-trending matrices", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gilberto", "O'Kon", "Architecto eos esse quo explicabo rerum. Eveniet ut voluptate. Est quisquam nobis recusandae velit et magnam. Vero voluptatum molestias molestias. Sed incidunt saepe.", "Future-proofed stable functionalities", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Fred", "Prosacco", "Optio quia quisquam laudantium voluptatem quia omnis. Iste commodi et. Dolores et vitae dolores similique est aliquam sapiente. Consequatur fuga veniam neque aspernatur suscipit tempore illo enim.", "Reactive mission-critical portal" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Perry", "VonRueden", "Ut dolores ullam illo rerum iusto sit earum nulla voluptas. Illum et itaque omnis id nam reiciendis id rerum. Beatae ut alias et sunt. Enim aspernatur sit eum quo blanditiis quos et sit.", "Object-based systemic utilisation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Laurie", "White", "Laudantium sint est. Blanditiis dicta omnis est. Dicta quo qui alias occaecati sapiente et ut blanditiis voluptas. Hic doloribus dolorum impedit. Ex iste vitae. Et reprehenderit voluptas expedita possimus neque animi unde voluptas suscipit.", "Ameliorated regional hub", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Thomas", "Kerluke", "Culpa omnis aut sequi illum. Perspiciatis itaque culpa dicta iure voluptates cupiditate error est. Eaque quia excepturi ut repellendus cupiditate. Qui nostrum eos rerum laborum voluptates.", "Profit-focused demand-driven complexity", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ricky", "Herzog", "Tenetur qui pariatur possimus ratione animi cumque. Necessitatibus aliquam adipisci. Et consequatur hic. Magni fugit culpa vel facilis veniam est.", "Inverse multi-tasking strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sadie", "Leffler", "Ipsum excepturi sed consequatur enim. Ducimus modi accusamus sint velit officia. Mollitia reprehenderit pariatur.", "Versatile reciprocal function", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kelley", "Collins", "Veniam debitis natus maiores consequatur. Ullam mollitia eius dolorem et non enim. Occaecati nesciunt eum id excepturi. Officia aut molestias velit. Et voluptas suscipit possimus voluptatum voluptatibus.", "Vision-oriented full-range service-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Inez", "Hand", "Doloremque temporibus eveniet et sunt et est consequatur dolor. Quas maiores deleniti laudantium vero ad veritatis maxime. Quod error beatae error ut delectus.", "Horizontal mobile capacity", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jenna", "Breitenberg", "Ratione modi rerum aut rem et. Iusto voluptate facilis autem sequi dolores quia. Atque est voluptatem sed cum sed atque rerum et rem. Voluptas neque inventore repellendus.", "Reduced object-oriented middleware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Laverne", "Treutel", "Amet iusto est et ut vel debitis minus et. Nam hic et quis quos minus. Sunt consequatur et eius modi dolorem hic quae repudiandae qui. Cumque eveniet dolorum sed officiis veritatis labore tempore asperiores at.", "De-engineered mission-critical monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Javier", "Conroy", "Id qui eius voluptatum quae. Eveniet ratione perspiciatis reprehenderit perspiciatis minus et sapiente a illum. Nihil accusamus laborum et ut deserunt ut tempora et rerum. Optio sint et harum. Est accusantium eos quia qui tempora atque totam. Asperiores tenetur et qui asperiores quis.", "Sharable dedicated task-force", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 14, "Gayle", "Bradtke", "Consequatur in dolore illo. Et nemo eligendi libero error odit. Vel sint cum ut facilis autem et est. Qui quisquam cum eos omnis.", "Exclusive even-keeled hierarchy", true },
                    { 15, "Hazel", "Schultz", "Ea dolores ut distinctio eveniet. Soluta non dolores. Vel exercitationem voluptas harum provident.", "Stand-alone mobile website", true },
                    { 16, "Catherine", "Zemlak", "Minus fugit ipsum sapiente sunt at. Temporibus dignissimos amet asperiores rem minima enim reiciendis occaecati sit. Impedit optio harum cupiditate aut recusandae et ut.", "Streamlined intangible framework", false },
                    { 17, "Violet", "Parker", "Quia repellat qui ad autem. Eius sapiente eius consequuntur repellendus aut eligendi eos et ducimus. Maiores voluptatibus enim rerum. Non voluptatibus omnis mollitia maxime quasi consequatur. Nisi aut id nisi ex in est. Ea iste dolorum earum aut voluptas in laborum accusamus.", "Fully-configurable fresh-thinking info-mediaries", false },
                    { 18, "Allison", "Kreiger", "Modi recusandae amet. Temporibus sit quidem aut repudiandae. Sequi corporis rerum qui. Et eius dolorem. Nam possimus facilis.", "Business-focused empowering hierarchy", true },
                    { 19, "Clayton", "Brown", "Eos qui cupiditate et vel qui provident aliquam numquam sed. Sed quia vel omnis hic qui qui. Quidem est laudantium facilis at optio hic corporis omnis. Nisi quis vel. Iste ut quasi libero et aut nesciunt voluptatibus vitae. Reiciendis omnis eum qui molestias odio veritatis possimus voluptatum et.", "Re-engineered 24/7 forecast", false },
                    { 20, "Louis", "Christiansen", "Commodi ut laudantium adipisci assumenda unde. Quisquam quia tenetur non perferendis labore. Alias dolor quis ad recusandae perferendis tempore velit repudiandae. Quo maxime quod sit sunt ipsum nostrum quia.", "Monitored background benchmark", false },
                    { 21, "Olga", "Mosciski", "Est voluptates dolorum eius. Iusto ad quae ut ut dolores odit. Aut consequatur sint reprehenderit ab quo. Quam dolorum porro.", "Grass-roots mobile intranet", true },
                    { 22, "Javier", "Hoeger", "Et tempora quia laboriosam deserunt recusandae sit nam sapiente et. Officiis delectus itaque labore perferendis omnis et. Quo fuga est cupiditate aut ducimus.", "Open-source national matrix", false },
                    { 23, "Lauren", "Feest", "Non odio omnis et eum asperiores et exercitationem. Vel eveniet veniam eveniet recusandae sunt sequi assumenda. Fugit modi dolor culpa dolores quasi ut. Ea ut recusandae eveniet necessitatibus ut nobis debitis voluptatibus praesentium. Fugiat eveniet eaque quo aut dolores sit rerum. A earum reiciendis.", "Profound upward-trending analyzer", false },
                    { 24, "Karl", "Schuppe", "Mollitia rem quo corporis ab assumenda et rem fuga id. Consequatur laboriosam deserunt corporis optio. Voluptas quis animi dolorum sed nam fugit inventore. Iusto non doloremque laboriosam ad aut sed neque.", "Switchable heuristic strategy", false },
                    { 25, "Gordon", "Mertz", "Aut sit dolor voluptatem modi fugiat. Vel id in. Est aliquam quia neque. Enim et quisquam velit.", "Innovative attitude-oriented policy", true },
                    { 26, "Annie", "Stokes", "Qui id vel et tempora commodi quibusdam. Non at maiores minus sit quod sed voluptatem totam dolores. Laboriosam in soluta.", "Synchronised intangible structure", true },
                    { 27, "Rosie", "Dach", "Voluptatem atque dolores dolorem quos. Esse laboriosam rerum deleniti iure quos commodi fuga et facilis. Magni et minus tempora omnis.", "Adaptive zero defect flexibility", false },
                    { 28, "Lora", "Flatley", "Distinctio atque culpa dolorem neque similique velit hic. Tenetur vel id amet quibusdam vero consectetur. Aperiam reprehenderit aliquam ab doloremque ut vel. Labore ex maiores aut quis veniam beatae exercitationem.", "Networked multi-state model", true },
                    { 29, "Kristie", "Metz", "Omnis aperiam aut officiis. Debitis repellendus nostrum magni. Ab dolor voluptatem dolor. Laboriosam repellendus omnis ut alias praesentium.", "Configurable asynchronous emulation", false },
                    { 30, "Arthur", "Bashirian", "Reprehenderit pariatur doloremque quia voluptatibus ipsa. Animi fugiat libero minima tempora qui. Libero quis animi. Et recusandae et numquam quasi molestiae harum est alias itaque. Eos officia qui omnis quos reiciendis consequatur est.", "Grass-roots attitude-oriented structure", true },
                    { 31, "Roderick", "Kilback", "Minus aut reiciendis optio magni. Qui possimus maiores. Eveniet voluptatem qui et optio officiis mollitia. Excepturi qui aut quia ex expedita vel et natus voluptas. Est quidem asperiores facere fuga aut autem eveniet pariatur. Aspernatur nesciunt illum itaque nemo.", "Multi-lateral attitude-oriented help-desk", false },
                    { 32, "Vickie", "Reichert", "Modi sit ut aliquam deserunt rerum. Ullam ad accusantium consequatur ullam dolorem culpa. Vel nobis error nesciunt accusantium. Quia aut provident voluptas. Voluptates ut eius eaque dolores delectus. Nostrum eius est facere omnis rerum reiciendis unde et.", "Robust demand-driven secured line", false },
                    { 33, "Rafael", "Friesen", "Officia ullam et placeat iusto. Laboriosam quos porro nihil dolorum. Libero molestias delectus. Et a placeat et tempora possimus eius repudiandae.", "Virtual exuding function", false },
                    { 34, "Nick", "Bins", "Quo accusantium enim repellendus eius nisi et itaque. Dignissimos ducimus qui impedit occaecati. Impedit consequatur nihil eveniet facere ex autem.", "Progressive modular utilisation", true },
                    { 35, "Sergio", "Tremblay", "Omnis asperiores qui distinctio facilis dolorem nesciunt nihil aut assumenda. Qui delectus sed cumque corrupti occaecati incidunt sed et. Sunt sapiente in necessitatibus asperiores dolor. Molestiae incidunt earum sint in quidem. Aut praesentium magni aliquam voluptas veniam et velit. Sit id voluptatem vel ipsa aut numquam itaque.", "Customer-focused actuating artificial intelligence", true },
                    { 36, "Olivia", "Howell", "Debitis repellat aut cupiditate voluptatem animi cum iure. Cum ut magnam et necessitatibus. Similique dolor perspiciatis impedit ut.", "Inverse interactive encoding", false },
                    { 37, "Kristin", "Christiansen", "Provident illo aliquid vero quia. Impedit quisquam ullam totam sunt. Omnis at dicta quis et libero illum deserunt et. Voluptates sequi omnis maiores similique ab culpa. Reprehenderit debitis quis pariatur ex.", "Down-sized regional circuit", false },
                    { 38, "Aubrey", "Ferry", "Et amet exercitationem repellendus quia nihil alias beatae. Explicabo qui cupiditate sapiente iste. Voluptas error vitae. Optio pariatur laudantium debitis rerum aut fugiat assumenda error a. Aut dolorum delectus temporibus aliquam id ducimus esse.", "Seamless content-based migration", true },
                    { 39, "Holly", "Torp", "Deleniti quos sed sit et fugiat perferendis beatae rerum velit. Exercitationem eaque voluptatem aut tenetur nisi est id. Qui doloribus libero nisi eum nemo earum veritatis quam. Sit omnis voluptate eos dolore laborum assumenda in et. Soluta et sed dolorem facere quae minima.", "Enterprise-wide real-time moratorium", false },
                    { 40, "Dana", "Monahan", "Deserunt quaerat et ipsam perspiciatis dolor. Iste nihil consectetur aliquid. Omnis provident aut iste mollitia adipisci vero minima porro.", "Virtual asymmetric archive", true },
                    { 41, "Shelly", "Hagenes", "Suscipit ut ullam laboriosam libero eligendi temporibus. Deleniti deserunt dicta magnam maiores blanditiis eos. Voluptatem cumque vero minus ad veniam fugiat aperiam. Qui est itaque cupiditate. Aut quos voluptas natus illum alias hic voluptatem non. Expedita facere soluta dolorum soluta dolore corporis.", "Integrated next generation help-desk", true },
                    { 42, "Henrietta", "Rolfson", "Ullam deserunt voluptas est velit molestias numquam vitae nemo. Neque provident omnis consequatur non laborum. Nulla cum eius eveniet consectetur sed perspiciatis et. Cupiditate ipsa saepe rem cupiditate incidunt occaecati quia corporis.", "Automated dynamic system engine", true },
                    { 43, "Leticia", "Metz", "Iure aut deleniti nesciunt repellendus iure fuga. Ea quo dolores illo autem. Iste dicta et aut sed assumenda facere sed. Odit fuga vitae ut unde aliquid blanditiis totam qui neque. Modi quis possimus ut rerum at odio impedit enim excepturi. Enim a earum aut modi eligendi nobis vitae.", "Cross-platform optimizing alliance", false },
                    { 44, "Lillie", "Kertzmann", "Nisi nihil aut. Voluptates maxime in dignissimos rerum illo. Dignissimos nemo tenetur occaecati esse rerum aut. Dolore at id molestias est tempora ad similique. Qui ut et est eos fugiat.", "Pre-emptive disintermediate groupware", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5164b750-e7dc-4e7f-9b8a-2388bbd16774", "3add4d20-f790-49e2-a335-b024b85f340a" },
                    { "b3f2a536-34ba-4a13-a28c-360a220d2335", "73b538d5-3afb-4534-95dc-1e66e24d4047" }
                });
        }
    }
}
