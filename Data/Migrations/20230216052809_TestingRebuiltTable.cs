using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TestingRebuiltTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "5da953e5-c4c8-448c-8a15-3324e65a0d8c", null, "admin", "ADMIN" },
                    { "d5ce731b-b22e-4a51-b8af-eaf0b488064f", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0f20a043-0310-4d3b-b3e5-9a6d675186c3", 0, "abdc918e-519e-41c1-a3ca-9a518ab8357f", "eddie_torphy39@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMoX5kCW0954uQftDZ+SApfAPGdpOEsu9JQyC9rUcg3zMcMmqNUW8r6l8p6Hic4+4g==", "1-579-420-0965 x5841", false, "8b6f2780-d47d-4640-9d86-9230598344ed", false, "Eddie_Torphy39" },
                    { "11492cce-a85a-41a4-88be-593bb7a294a9", 0, "3dbdb5b3-056e-4cf8-b30b-2711f87c6571", "stephen.king@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELNnORpP1zFP8xWM6iCHI4tLJuOigrpwDOhWrpEcvyUpbdpgmHZaLNtmuq02jDAFIA==", "1-580-649-6316 x581", false, "cf42ba29-6645-46fa-b263-d28e5eaaad14", false, "Stephen.King" },
                    { "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144", 0, "f0c15a2a-964f-4b11-b2f3-46ff49b808fc", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEJcJnGHvbu68Rh33d5wg1lBw2kFGh6p1ENR95HfrGRYsEKprLgfy9WbNm9iXaDLovA==", null, false, "8cc529c2-1f61-4eef-a9b3-3cd436110575", false, "librarian@library.net" },
                    { "2033b1e8-1932-42bf-9421-4b1595b0e18c", 0, "a94ec41c-a1ff-4606-b28a-49a1704f2e6d", "meredith.feest@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI0+SfkxLpSOjQtdvbDjMU+FgfuXw8FfFEIk4KyMxZGEBbR0bT/cVnpxrzFVSLGNAg==", "1-915-565-0268", false, "69e8c200-e078-4b68-9226-259112e55f81", false, "Meredith.Feest" },
                    { "2257a18f-f789-4fbb-9b7d-8a13531e756b", 0, "ca57d11f-0aa2-48ad-be8c-aa167cd17c19", "joseph.parker38@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJPLGOg9AeQjMgFf3PnT9hexIsiLMhJJr4Xz/izc4fnxYUU/6rqZqS3rKQiG3fB72w==", "1-991-485-5247", false, "54f6627c-4e3d-47de-9e6b-5025c957e4c4", false, "Joseph.Parker38" },
                    { "24c0d8c3-a3f9-402b-a0b0-f6923f406fa8", 0, "8194539d-c50d-4e70-b0b8-48a5be849566", "carroll93@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMNrMEOxSvfVpG7dSTblhU9EHide0f+YHalwA/NcOHg97ME8LSfsRFc3n7csalwYcQ==", "975-883-6267", false, "24cf6fb7-42cf-43d3-93ce-ae143113e769", false, "Carroll93" },
                    { "2e0c24ba-ccee-4c78-bc02-eda76176bf33", 0, "234f431e-16fa-4322-a5d6-54991c22a8b6", "joe14@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH0ad7lgH4aBHk/8v+UsmU3bs+wdrjs97pcC02g0/FSEFIOWYoiCdmWXutcO3IhbSg==", "1-660-890-0595 x729", false, "0e78bec2-75de-4270-b67b-df7d51f63b17", false, "Joe14" },
                    { "352667be-db7f-4cf2-99a5-f0038283888c", 0, "44f52411-6e93-4307-9684-31828e6e1761", "jeff_ruecker67@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAxJePppYlHVHnJ1pVSPWqw6itFDcJEZwbd8wbUGYxpHT7+FDWcBwAhCV3lMMzK5mA==", "998-331-2005 x1464", false, "ea3953dc-0d41-408c-843e-6763e82cfe0e", false, "Jeff_Ruecker67" },
                    { "37a0eda6-7893-4754-9992-e0c601ef9b62", 0, "034e1218-ff8b-4f02-bb57-55be1283fa1f", "wade_ullrich@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFjtKM9fIOaZr/Yl9Dm8PlMKSgydhh19SnVhUNqChZ4TSgIkkq7nGHHIxB64dEvENw==", "998-617-4182", false, "d5b8e5ae-00ce-4a70-a3c5-293ae8887971", false, "Wade_Ullrich" },
                    { "3b69c73c-1bb4-4423-8835-ed72c8c74603", 0, "edac3058-7d3e-4350-a4e8-b632bd039f05", "darrel6@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI+co8iz3Hwr602VP3L9cGX3sun9y2cVHJNikPzuM7IknGvll/f8wtFVS2ykRAyjSA==", "524-812-9526", false, "c00e503f-e951-4e5e-bf2b-7016223316c8", false, "Darrel6" },
                    { "41ac32d7-3081-48af-96dd-4321c77af640", 0, "d21114d1-9a20-45b4-8ea9-5fdf5ecd7102", "allan_dicki@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELzVZ9cGsBnSyfdo8XBvIIj9jPME8e2rz27fgPRYm82uTlhWUJs7lQKJ3c5N2ifMMA==", "(864) 314-8160 x4559", false, "a36c29e3-5c11-456c-97a5-d138ae2570a9", false, "Allan_Dicki" },
                    { "4a4d66da-18de-4299-b007-dbd99123489f", 0, "8b9b717b-51b1-4203-8485-1f58eb3f68f6", "della.kuphal0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIqMWgflTCT1OGyfrmRamHSb1lirlru5lpMYrQRu0T+BTck6mmSkI0tcLr7e2dpmGQ==", "(642) 908-9814 x896", false, "bd78bbaf-412b-4cd9-81a4-8b19f701c4f9", false, "Della.Kuphal0" },
                    { "6e10ec99-21fe-4ca6-93fa-1fb6dbbe2dbd", 0, "2c561b9d-6dc4-40be-9eb9-f79870cd5126", "alberta30@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENWO9XX1/CVdflGEEnE5KerzvQcJvXx8QZNOB8KnzSF6+z4SdV7/7co090SnGikBKQ==", "424.692.6688 x38499", false, "b17e8234-9b67-4b76-ba9f-fbbb7267c3f5", false, "Alberta30" },
                    { "79482d20-b4f2-496c-899f-b0d000d876a1", 0, "df81f349-3683-405a-b74d-431e435268d8", "joey98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI+cazwg/QRVhlVpnRqAI4wFbJacqiff4rspbOJBIgq+hREUi9CoRuVBme3E1PrUWA==", "556.974.4446 x2942", false, "a375ee04-0cd9-41b0-81bb-7ad8e9eaa2d4", false, "Joey98" },
                    { "94e3e662-cd88-4abc-928d-b81efa0ac168", 0, "b0713351-9923-47ec-8cfd-92b720255bdd", "fernando.abernathy@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEV+uo2SgUq/tkLB/+n5/PdUMNtddXhHDP7YOq5v0+utcxQyg921OEcCbtmbLuD+nw==", "334-890-6746", false, "f3ba59bc-c82b-48c0-bf4e-f60743efc837", false, "Fernando.Abernathy" },
                    { "9ee59f3f-cb59-4289-b886-9de499278a82", 0, "0c90cb47-6af3-4644-bd25-72d1fc1e8952", "theresa_gerhold@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECRkB44EiZ7E8ZUy4Mxxx+OD4PwOAEkBVph0MFxepyKN8ZtJNS381O9VKFCeaMTOYQ==", "(754) 482-9374 x0702", false, "07687de8-d3c4-4cb9-9a3a-344b955dd4b5", false, "Theresa_Gerhold" },
                    { "c598d09d-85a8-4f1c-90d2-80437ec3b7d9", 0, "6a037b5d-0fbe-492a-af52-0b070edfeaea", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAELb7or5n+9iKC7o2ohZCMiyd5PhXS4xLOSZZRXHYmpsNT27FdvvhOcSCOYEIOc4rsA==", null, false, "0d506aa4-0a24-4fc7-8804-148f902d9482", false, "borrower@library.net" },
                    { "dcb79b15-c3a8-4849-aa10-03eca7afd5f0", 0, "82f84d58-0145-469b-aeb4-69c3e7e433e4", "lindsey_schuster@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFDLtyeLZxS3Q5f7wV4IvmMMFHKMcIleChQk9BMN9M3OzHDtqVyZLpt7fEuhr3Hv8Q==", "531-681-7967 x02032", false, "e5be6eec-b01e-4a29-8982-5ea5c6a21861", false, "Lindsey_Schuster" },
                    { "e2ada14b-6f38-4902-ae25-75ca4d9bf9da", 0, "987e5eb9-349e-453f-93bc-32070c28d492", "blanca.klein72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENGr9y3NFS2jyvMBc1H2TYn0iZMzHXK7N8VbosKny/s7B6da/HbqHaEZezO+qCHfog==", "413-479-5200", false, "bb1d8601-988d-4ad1-a124-21b537afb3c9", false, "Blanca.Klein72" },
                    { "e4877640-43fb-47be-b242-10f20c021e41", 0, "23dff3c1-f01b-4273-912c-cee59c0e8c28", "arnold18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH1E0zBetH+7cCieGjxf0QThcTjefsKXSAjlOn9tlAat/YmKLXRBEuzJreGLXVn2Ig==", "1-949-881-2518 x906", false, "00cd8e4e-7c24-4711-a86e-2f9d8400da41", false, "Arnold18" },
                    { "e58101d2-6e97-4df4-b03f-d35aed3417fe", 0, "89542210-e765-4eb6-a65b-bb5815e7a8df", "darin.brakus@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOznwN1VN/jZzm06bGGSCOmXK+rk1gZ5rhhy6qq0E1/Ah/HxnQELQ8x2lXAMlz95VQ==", "1-669-305-2058 x956", false, "1190efc2-7b9a-46a1-8ad4-e693488188a6", false, "Darin.Brakus" },
                    { "f62740f8-12ea-4821-a7f9-f7c46241326a", 0, "e8a4e5d1-fa51-4adb-9319-b38852f2ea9c", "elisa_bradtke58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENiCzwCFb8YMUwA02cHyAzQo3WwE/Ns/XWCnm7+4Ix1lusrF/sqzQxeizkWco2exiA==", "526.486.0746 x01786", false, "0af81633-c1a4-4f4c-97e2-def532e9f139", false, "Elisa_Bradtke58" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Don", "Walker", "Quia architecto dicta repellendus voluptatibus sint nemo aut ea. Nulla velit quae. Quo enim at. Perspiciatis repellat vel.", "Enhanced heuristic conglomeration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Mandy", "Stiedemann", "Molestiae reprehenderit ducimus commodi adipisci vel sed quia. Optio reiciendis officiis cumque consectetur. Reiciendis ut rerum iure voluptatem vel ut quidem. Quos et culpa.", "Adaptive heuristic attitude" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Thomas", "Kozey", "Velit atque harum sunt. Reprehenderit quos iure eius itaque tenetur molestias natus fugit qui. Atque aliquid ad. Ut ad ratione sunt consequatur voluptatem qui qui accusamus quibusdam.", "Profit-focused even-keeled hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "April", "Lemke", "Magnam explicabo in suscipit velit. Occaecati sapiente aperiam velit. Non sed tempore placeat consequatur.", "Persistent foreground installation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sherry", "Corwin", "Labore ducimus delectus in voluptatem. Placeat ratione laborum omnis. Nesciunt non placeat occaecati tempora tenetur facere alias est veniam.", "Versatile discrete capacity", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Daisy", "Watsica", "Occaecati fuga et sunt velit amet veritatis dolorem mollitia. Quibusdam excepturi aspernatur perspiciatis eos. In voluptatem quo est tempora voluptatum ut ad id. Sequi dolor non ut rerum dolor.", "Fundamental asymmetric framework" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dave", "Hudson", "Velit necessitatibus tempore. Neque odit amet quia ut fugiat et veniam exercitationem. Autem dolor beatae fugiat nulla voluptatem. Voluptate ut occaecati ut et minus facilis officiis necessitatibus.", "Progressive dedicated frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Josh", "Gottlieb", "Praesentium temporibus ut voluptatum eaque placeat voluptate. Minus ipsa officiis dolorum. Nemo repellat assumenda ut vel harum inventore dolorem omnis officia.", "Team-oriented asynchronous hub" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bryan", "Senger", "In natus eaque maxime maiores. Ipsam repudiandae magnam sed beatae est quod fuga. Pariatur vero repellendus in et. Quis impedit aliquam et temporibus quia incidunt quos modi ut.", "Devolved mission-critical intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Merle", "Bayer", "Esse odit cupiditate aliquid dolorum sit molestiae. Hic aliquid ut quia error perferendis itaque. Earum maxime quam impedit quos. Nobis quia ut ea doloribus non in.", "Persevering maximized methodology", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 11, "Erica", "Schaefer", "Dolores velit explicabo aut dolore. Distinctio repudiandae ut exercitationem ea. Fugit esse quia officia et autem eligendi error voluptate. Nostrum quos quas et. Dolorem dolor tenetur qui.", "Realigned zero defect utilisation", true },
                    { 12, "Genevieve", "Padberg", "Est illo provident rerum laboriosam blanditiis occaecati dolorem. Nihil esse ipsa suscipit voluptatibus inventore eius. Laborum reprehenderit porro vel sunt enim omnis aut ut est. Quo expedita omnis vero et. Aperiam inventore et distinctio similique qui sit saepe sint. Consequatur voluptates sed voluptas harum tenetur fuga accusantium.", "Centralized reciprocal collaboration", false },
                    { 13, "Eduardo", "McDermott", "Est error aspernatur hic natus nemo cumque corrupti adipisci. Magni omnis et voluptatem voluptatem id veritatis incidunt delectus. Odio in non magni consequatur maxime et adipisci et neque. Sunt similique animi eum culpa iste. Nam qui repellat.", "Monitored upward-trending productivity", false },
                    { 14, "Susie", "Satterfield", "Quasi et delectus vel facere amet non. Molestiae architecto quibusdam ut modi. Nostrum cum corporis ea et sint officia consectetur sed.", "Digitized zero defect throughput", true },
                    { 15, "Vicki", "Kulas", "Error maiores commodi. Odio molestiae unde perferendis aliquam quis inventore et. Et consectetur eius accusantium laudantium. Nostrum vel ipsam sint eos aliquid eveniet deserunt nihil fuga.", "Up-sized zero defect definition", false },
                    { 16, "Agnes", "Hansen", "Enim ut alias dolor minima ea. Eligendi vitae voluptatem blanditiis velit eveniet et mollitia. Dolor tempora et doloremque officiis at et.", "Managed 6th generation monitoring", true },
                    { 17, "Wm", "Hilll", "Ut pariatur rerum voluptatibus officia occaecati saepe. Qui eum incidunt eum exercitationem. Ducimus porro quisquam beatae impedit magni qui rem. Aut similique ea incidunt iure dolore ipsa.", "Triple-buffered exuding internet solution", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5da953e5-c4c8-448c-8a15-3324e65a0d8c", "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144" },
                    { "d5ce731b-b22e-4a51-b8af-eaf0b488064f", "c598d09d-85a8-4f1c-90d2-80437ec3b7d9" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5da953e5-c4c8-448c-8a15-3324e65a0d8c", "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5ce731b-b22e-4a51-b8af-eaf0b488064f", "c598d09d-85a8-4f1c-90d2-80437ec3b7d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f20a043-0310-4d3b-b3e5-9a6d675186c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11492cce-a85a-41a4-88be-593bb7a294a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2033b1e8-1932-42bf-9421-4b1595b0e18c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2257a18f-f789-4fbb-9b7d-8a13531e756b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24c0d8c3-a3f9-402b-a0b0-f6923f406fa8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e0c24ba-ccee-4c78-bc02-eda76176bf33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "352667be-db7f-4cf2-99a5-f0038283888c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37a0eda6-7893-4754-9992-e0c601ef9b62");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b69c73c-1bb4-4423-8835-ed72c8c74603");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41ac32d7-3081-48af-96dd-4321c77af640");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a4d66da-18de-4299-b007-dbd99123489f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e10ec99-21fe-4ca6-93fa-1fb6dbbe2dbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79482d20-b4f2-496c-899f-b0d000d876a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "94e3e662-cd88-4abc-928d-b81efa0ac168");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ee59f3f-cb59-4289-b886-9de499278a82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dcb79b15-c3a8-4849-aa10-03eca7afd5f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2ada14b-6f38-4902-ae25-75ca4d9bf9da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4877640-43fb-47be-b242-10f20c021e41");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e58101d2-6e97-4df4-b03f-d35aed3417fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f62740f8-12ea-4821-a7f9-f7c46241326a");

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5da953e5-c4c8-448c-8a15-3324e65a0d8c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5ce731b-b22e-4a51-b8af-eaf0b488064f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1fa75cb8-fc5e-4cb8-ad8d-387bb4898144");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c598d09d-85a8-4f1c-90d2-80437ec3b7d9");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jon", "Jacobson", "Nobis enim et praesentium corporis rerum delectus sint veritatis. Dolor nulla in. Officia veritatis a accusantium a aliquam soluta temporibus ullam. Adipisci eius aperiam et voluptatem sed. Eveniet perspiciatis cumque dicta et. Esse maiores provident quia aperiam.", "Reverse-engineered scalable product" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kari", "Koch", "Molestiae qui non laudantium doloribus magni. Iste ducimus libero temporibus repellendus non ipsam in quibusdam. Ullam nostrum sed neque vel. Rerum quibusdam reiciendis ipsa enim et.", "Streamlined clear-thinking time-frame" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Felicia", "Cole", "Incidunt in sit a eum sed laudantium enim. Dolores est suscipit id fugiat sint fugiat molestiae. Voluptatem aut dolore maxime corrupti. Eum nostrum ut non eum cum sit eum. Inventore aut ipsa beatae dolorem blanditiis dolorum.", "Monitored disintermediate array" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ira", "Heller", "Itaque enim expedita voluptatibus. Enim molestiae aut omnis magnam commodi. Omnis omnis totam ipsa id. Quia eveniet consectetur. Assumenda quo nihil necessitatibus maxime qui quod harum excepturi.", "Open-architected multi-state middleware" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shelly", "Thompson", "Voluptatibus possimus blanditiis vero. Et possimus qui laborum alias quaerat. Esse incidunt labore quia reiciendis vel harum itaque.", "User-friendly multimedia groupware", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b1f9f862-d433-4f4f-8e16-f496e529e2b9", "2a1f2574-6eae-4e74-b7ed-ae2ee445a001" },
                    { "654313e4-aa45-450a-939e-c242549715cc", "75e584fc-58b0-4082-82ed-e05f0cfbfc5b" }
                });
        }
    }
}
