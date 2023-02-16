using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedBGAndFormatting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51625042-f06d-47ac-bc9e-62886d01044e", "22a44f97-6203-4035-82ff-f74166c4868c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8", "28ad7b5d-a958-4e75-849b-cd752590f760" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84756e3a-1849-4845-aa1b-8e008d2e3370");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4cd5330-0a05-4eb5-b14a-7aa56d3a9963");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de9a5d7f-723e-4db6-83e9-8ddd324bfee5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51625042-f06d-47ac-bc9e-62886d01044e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22a44f97-6203-4035-82ff-f74166c4868c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "28ad7b5d-a958-4e75-849b-cd752590f760");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Elvira", "Okuneva", "Quos harum iusto aut adipisci illum velit aut aut. Quo rem dicta facilis totam non fugiat aut consequatur cum. Commodi quis voluptatem ea.", "Organized explicit process improvement" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Heidi", "Runte", "Itaque asperiores itaque nemo cum nemo. Neque maxime consequatur. Totam est atque. Dolor quasi suscipit amet. Saepe et cupiditate qui accusamus corporis harum reprehenderit. Quo est repellendus.", "Centralized 4th generation project", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jacqueline", "Baumbach", "Voluptate quidem iste quo voluptatem adipisci ratione aut. Ex vitae ut rem quos quia ullam enim nam. Enim assumenda ex ea consectetur eum.", "Fundamental incremental superstructure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Yolanda", "Hand", "Velit et iusto beatae ullam quia ipsam. Exercitationem voluptas vel molestiae cupiditate saepe. At qui qui. Dolores pariatur consequatur magnam.", "Profit-focused client-server open system", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ernesto", "Dooley", "Magni consequatur odio. Veniam pariatur et provident nemo aut ea nemo. Doloribus est sint sed ab dolorum inventore mollitia enim. Id impedit aut sit autem dolore sunt. Expedita rerum qui.", "Visionary 4th generation encryption" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tammy", "Yundt", "Facilis dolores itaque hic a velit dolor aliquam. Voluptates animi at dolores rerum laboriosam. At ea consectetur harum ipsam autem ab et et debitis. Laboriosam quo ipsum qui. Non adipisci eos non omnis iure praesentium et in.", "Re-contextualized human-resource alliance", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Fred", "Gerhold", "Nihil ut autem sed aut beatae sapiente ut quo et. Ipsa vel beatae ipsam autem veritatis quos eveniet omnis. In et laudantium mollitia reprehenderit ipsum voluptatibus sit. Numquam autem exercitationem sit delectus nesciunt.", "Implemented non-volatile open architecture" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Louis", "Mills", "Ea et occaecati praesentium consectetur quo cumque et. Harum expedita veritatis. Quam asperiores expedita veritatis qui. Hic aut rerum deserunt magni nemo similique quos cupiditate voluptas. Ab perferendis omnis voluptatem est saepe.", "Re-contextualized regional projection" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ramon", "Borer", "Sapiente sint provident laudantium quam at et consectetur dolores. Fugiat impedit enim officia et. Eos dolores laborum ut. Est enim earum inventore voluptatem quia. Voluptatem enim quas voluptates iste ullam eius.", "Future-proofed discrete data-warehouse", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Luis", "Konopelski", "Sed eius autem et dolore consectetur consequatur ut omnis. Nisi facilis dolores et aut. Expedita aut ad praesentium officiis. Explicabo unde id pariatur quos tenetur nihil ex nihil dolorum. Illo dolorem tempore ab velit velit est et beatae. Ut sed non ut nulla rerum.", "Virtual interactive intranet", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 18, "Margaret", "Beatty", "Tempore amet quo voluptas sit placeat quas fugiat. Autem et laudantium. Dolores est tenetur.", "Integrated stable internet solution", false },
                    { 19, "Sheldon", "Schmidt", "Quo qui officiis impedit. Ullam quod autem blanditiis sit ducimus. Numquam quos ducimus et accusamus.", "Multi-tiered non-volatile strategy", true },
                    { 20, "Harold", "Ferry", "Cum aliquid eos rerum laudantium necessitatibus ut exercitationem doloribus. Tempore et dolorem nulla dolores numquam doloremque. Aperiam deleniti atque molestias qui aliquid. Et eaque quia quam dolor et sed voluptatem est expedita. Harum voluptatem voluptate eos et qui. Quis aperiam voluptatibus veniam sit eius voluptas.", "Integrated bandwidth-monitored orchestration", true },
                    { 21, "Carl", "Schiller", "Quam nisi qui. Esse blanditiis sint similique dolor consequatur nihil ab sit. Voluptas doloribus sequi molestias ipsa fugit dolores recusandae harum. Similique molestiae non repellat perspiciatis voluptatibus qui molestiae.", "Realigned responsive solution", true },
                    { 22, "Dustin", "Predovic", "Quasi non aliquam dolores animi neque cumque molestiae. Sit accusantium molestiae illo omnis voluptatem non. Quo aut ullam incidunt consequatur rerum. Repellat rerum voluptates assumenda omnis.", "Reduced multi-tasking firmware", true },
                    { 23, "Zachary", "Larson", "Sint totam facilis ut velit. Et totam deleniti debitis tempora maiores et dolore ex. Porro necessitatibus totam laboriosam quia. Repudiandae quae saepe. Sunt soluta ab ab quaerat voluptates voluptas quis incidunt sed.", "Focused system-worthy success", true },
                    { 24, "Shelly", "Lesch", "Perspiciatis possimus adipisci eum ducimus cum. Ipsa a mollitia quae est fuga earum. Qui voluptas earum voluptatem dolorem. Sint atque et sunt ut et harum et.", "Quality-focused contextually-based task-force", false },
                    { 25, "Latoya", "Beer", "Iste similique eum voluptatibus libero saepe eum sit explicabo delectus. Voluptatem porro qui odio veritatis dolore dolores voluptatem. Autem earum earum deleniti. Earum enim recusandae quaerat. Aperiam id nulla libero eum porro libero sed ut.", "Object-based even-keeled flexibility", false },
                    { 26, "Evan", "Donnelly", "Omnis molestias voluptate quis perspiciatis omnis exercitationem quae id. A adipisci nulla aut quia. Ad quaerat qui et. Quaerat quam aperiam dolor adipisci amet. Non distinctio numquam est.", "Grass-roots fault-tolerant leverage", false },
                    { 27, "Rachel", "Gutkowski", "Dolores fugit facilis amet. Earum aliquid voluptates doloribus cum quia. Hic repellat rerum aut quia iusto ratione. Voluptas fugit voluptates odio distinctio quia.", "Vision-oriented attitude-oriented protocol", false },
                    { 28, "Bert", "O'Keefe", "Voluptas voluptates corrupti est sit voluptatum provident mollitia ut. Maiores fugiat consequatur alias labore odio. Sunt placeat consectetur repudiandae dolorem voluptatibus ut. Beatae deleniti perferendis aut quas sint. Esse est dolore vel velit sint necessitatibus exercitationem. Dolor ut nam neque adipisci eligendi aut officia.", "Persistent background time-frame", true },
                    { 29, "Clifford", "Dare", "Rerum ut ut nesciunt exercitationem culpa sunt quia. Quam voluptas et vero nostrum. Minima eligendi odio delectus qui consequatur dolores dignissimos.", "Upgradable optimal superstructure", false },
                    { 30, "Emilio", "Donnelly", "Qui maiores labore. Ipsa placeat aspernatur ratione aut blanditiis. Nulla nihil similique nisi sint repudiandae a et. Iste aspernatur assumenda consectetur. Quis modi neque. Sed nobis et distinctio.", "Reverse-engineered secondary concept", true },
                    { 31, "Becky", "Daniel", "Numquam corrupti eius voluptatem fugit omnis quam distinctio dolore consectetur. At illum laborum tenetur. Error molestiae aspernatur natus.", "Centralized 5th generation success", false },
                    { 32, "Mitchell", "Stamm", "Ad culpa eos delectus a dolores error dolorum quod quis. Ut maxime in veritatis necessitatibus consequuntur quis quidem aliquam. Quasi mollitia dicta minima nostrum aut ex. Eius recusandae non dolores architecto.", "Extended bi-directional analyzer", false },
                    { 33, "Lorenzo", "Dibbert", "Quo velit eius. Minus excepturi repudiandae. Cum iusto velit laborum ut placeat fugiat. Fugiat qui qui ut voluptas quod fugiat nulla eum.", "Stand-alone executive support", true },
                    { 34, "Sadie", "Reynolds", "Quibusdam eos nostrum unde quisquam est. Error sunt in quia iure autem autem et doloremque. Laboriosam libero quisquam.", "Optimized attitude-oriented info-mediaries", false },
                    { 35, "Brett", "Medhurst", "In libero dolores iusto in quidem. Ab eum quia velit quod doloribus corrupti rem corrupti et. Libero culpa aspernatur quidem sunt pariatur perferendis velit quas. Qui voluptates aliquid fugit qui id et fugit unde.", "Fully-configurable interactive monitoring", false },
                    { 36, "Annette", "Ondricka", "Qui et laudantium quia eum placeat. Aliquid et quia ut. Modi ullam quia. Aut eligendi adipisci. Eos doloremque similique similique non quam enim et ullam. Repudiandae aut earum perspiciatis unde sed iusto minus.", "Compatible bottom-line firmware", true },
                    { 37, "Elizabeth", "Ferry", "Aliquid totam et minus sapiente cupiditate voluptatem. Blanditiis est aut in maiores doloribus laudantium. Adipisci tenetur voluptate error debitis. Ut distinctio adipisci non. Sint mollitia qui.", "Optional holistic policy", false },
                    { 38, "Gladys", "Torphy", "Fuga quis facilis qui voluptate. Labore voluptatem eos perspiciatis suscipit beatae quae id molestiae aspernatur. Ducimus excepturi ipsum eum voluptates animi iste.", "Persevering needs-based flexibility", false },
                    { 39, "Alberta", "Bogan", "Voluptate voluptas omnis et. Recusandae provident qui fugit voluptate ducimus maiores. Cumque voluptates et est veritatis. Nisi vel et incidunt corporis qui temporibus quae esse.", "Centralized systemic adapter", false },
                    { 40, "Lee", "Monahan", "Cum vitae amet ullam magni commodi. Cum nobis non dolor fugit excepturi aliquid. Ut accusantium eveniet et quia quia sit accusamus. Facilis inventore impedit. Consequatur asperiores similique sed et eos maxime.", "Networked responsive forecast", true },
                    { 41, "Pauline", "Kuhic", "Molestiae quidem quisquam aspernatur. Animi voluptas ut. Dignissimos suscipit autem culpa nemo ratione.", "Cloned regional workforce", false },
                    { 42, "Israel", "Kautzer", "Nostrum placeat dolores quis in voluptatem. Impedit earum numquam ab. Et sit optio sint nulla consequuntur consectetur quia nobis ea. Voluptatem temporibus a. Quidem qui quia non a. Atque nobis necessitatibus totam nisi et.", "Organic multimedia archive", true },
                    { 43, "Rolando", "Steuber", "Repudiandae architecto mollitia voluptatum. Repellendus ratione aliquam. Odit enim voluptates vel dolorum ea ab ab et.", "Distributed impactful functionalities", true },
                    { 44, "Abel", "Pollich", "Harum molestiae nesciunt dolor quia. Voluptatum autem ullam enim quisquam non qui. Cumque qui rem explicabo fuga rem.", "Versatile leading edge challenge", true },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "51625042-f06d-47ac-bc9e-62886d01044e", null, "admin", "ADMIN" },
                    { "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "22a44f97-6203-4035-82ff-f74166c4868c", 0, "66f69cc9-bb2f-4e30-b013-d612c1649ba0", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEBZBCBUmH8TsfJpVgUUkGXz7looM4YYBvOiPb9YLXQBkMARJyFEsPJ+kO7nF0nEZ/Q==", null, false, "36ef55c9-d503-48e4-a493-3442f05b2bf0", false, "librarian@library.net" },
                    { "28ad7b5d-a958-4e75-849b-cd752590f760", 0, "20886705-bae3-43bf-83e5-863b9cf896b4", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEDSgQ3Bv1i34tRRpnqGoQs3979guahNAL+bKQ0wr3XOkGioElXXcnXSFUAJtT2z9Dg==", null, false, "8f17845c-001c-4d7d-b465-1784bc6e5b2f", false, "borrower@library.net" },
                    { "84756e3a-1849-4845-aa1b-8e008d2e3370", 0, "590ee0d2-aa98-4c39-b933-3a34e3eac3f9", "abraham.anderson@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJR1e03HHltyWphDYT/nXcZBGdYvE7OJY7/illzDT7IcP6t1dvbWrrxHuiPVXrgAVA==", "853.296.8968 x370", false, "ec5fb77b-493a-480e-8fc1-e87ad8335ec1", false, "Abraham.Anderson" },
                    { "c4cd5330-0a05-4eb5-b14a-7aa56d3a9963", 0, "b9b574f6-b380-48a7-91a0-6eb71fba2507", "alexis.wiza@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGOgIo/fGXbZ7cTH13Rp5kCYDjLYftzYrKOoIdGAqwaSpWW2zmhN2zFE4TJvfYcwyw==", "(501) 908-2441", false, "1ab72795-dd8f-4713-9d38-0af0772ee6f6", false, "Alexis.Wiza" },
                    { "de9a5d7f-723e-4db6-83e9-8ddd324bfee5", 0, "b715e916-e1ea-415b-8be8-cdc6a8db3074", "elaine_grady@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELFlQSxdiYAKaLtHghO4ocmrAxvpJic9XJVvBBZfwBznl1TXkd4Gl2OqfnmrVuSN1w==", "1-511-685-6485", false, "6cbbc42a-6b7c-4fc3-b5d6-fd7b548d1706", false, "Elaine_Grady" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Travis", "Hamill", "Quos voluptatem odit. Repudiandae molestiae provident aut ipsum officiis vero excepturi et. Quam quas in accusantium fuga in nihil possimus perferendis.", "Devolved explicit model" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Alfonso", "Kunde", "Quidem consequatur odit corporis voluptas. Rerum accusantium illo et. Et eaque voluptas. Itaque sint culpa eveniet itaque vel officiis qui consequatur aut.", "Programmable full-range extranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dana", "Lockman", "Expedita eius ut ad libero itaque voluptates temporibus quo. Fugiat similique aut commodi. Sit cum ut suscipit nihil incidunt cupiditate.", "Horizontal bandwidth-monitored framework", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Alvin", "Boehm", "Eos non repudiandae. Voluptates animi minus a esse modi culpa voluptate tenetur. Quia ipsam aut voluptas qui cupiditate voluptatum voluptatem aut.", "Digitized eco-centric help-desk", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dora", "Schmitt", "Rerum aut omnis tempore quasi incidunt corporis et. Sed temporibus sunt accusantium veritatis animi cum quidem est assumenda. Voluptate dignissimos rerum soluta totam eveniet voluptatem architecto et minima. Nisi alias sed dicta eum exercitationem non quasi. Harum molestiae delectus qui distinctio quia hic odio ut.", "Proactive regional architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tyrone", "Lang", "Sunt sed nesciunt facere quidem numquam possimus inventore libero. Voluptates id eaque cumque qui odit. Quia delectus sunt nisi totam voluptates. Quaerat non inventore odit quia.", "Centralized bandwidth-monitored moderator", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marion", "Hudson", "Similique accusantium sequi excepturi earum voluptates odit. Odit corrupti eum voluptate et. Tempore cupiditate ullam perferendis velit ab omnis nam rerum. Qui nihil ullam deleniti iusto a ipsa sed expedita reiciendis. Alias quod et sequi.", "Devolved grid-enabled paradigm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Frankie", "Hettinger", "Molestias reprehenderit natus nisi consectetur vero soluta. Aut minus est consequatur sed dignissimos animi. Ut expedita reiciendis. Vero eum dolorem voluptatem. Et consequatur ut cupiditate. Nostrum et quia repellat repellat.", "Operative neutral function", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Victoria", "Medhurst", "Doloremque aut eos illum. Aspernatur aspernatur maxime aliquam facilis blanditiis qui voluptas delectus iusto. Incidunt quia amet eos. Est nesciunt consequatur explicabo quam omnis id cupiditate. Enim vel dignissimos sit velit eaque esse eum ratione esse. Quis nisi eaque maxime eligendi aut et ipsum.", "Enhanced methodical encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wilfred", "Hahn", "Eos corporis dignissimos aut quia. Magnam amet soluta autem neque enim rem non cum voluptate. Qui temporibus perspiciatis exercitationem.", "Cross-group background frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Manuel", "Bosco", "Ratione exercitationem sint voluptas libero illo. Ab delectus at. Sunt non quia quia nam laudantium. Suscipit delectus ullam sunt doloribus minus.", "Horizontal reciprocal structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sergio", "Ledner", "Totam vero sunt ipsum et labore esse voluptatem maiores. Non qui sit dolor molestias fugiat. Doloribus ut porro. Rem numquam velit ab incidunt et asperiores. Natus voluptates itaque qui aut commodi est et qui.", "Upgradable encompassing encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Don", "Altenwerth", "Aut suscipit ab iste quas non ullam nostrum. Ut voluptas nobis illo quae dignissimos ducimus. Expedita impedit perspiciatis nesciunt aliquid. Natus molestiae quasi et quod. Esse non consequatur dolore delectus qui. Eaque consequatur aut hic voluptatem hic sequi est et qui.", "Synergized grid-enabled parallelism", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Erin", "Lowe", "Quia nostrum iure quo et et deleniti optio nihil. Iure consequatur sequi explicabo iste ea nisi qui autem incidunt. Natus quia dolorem est. Delectus distinctio dignissimos eum quia.", "Multi-layered high-level policy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Austin", "Anderson", "Illum quia odit in magnam. Porro asperiores recusandae non aliquid explicabo id quo non. Id architecto omnis sequi exercitationem omnis vel eligendi.", "Secured intermediate customer loyalty" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Justin", "Powlowski", "Eveniet accusamus qui vitae ut eos enim voluptates ut. Et et autem veritatis. Sit fugit atque deserunt porro id. Et adipisci rem natus eum provident reiciendis sapiente deleniti. Tempora iusto est fugiat doloremque voluptas magnam nobis. Distinctio voluptatem velit autem dolorum praesentium voluptatem at.", "Synergized high-level pricing structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristin", "Bechtelar", "Laudantium atque et corporis non nam vel voluptate quis voluptatibus. Tempora autem et autem. Odit est velit veritatis repudiandae ut nihil et impedit et.", "Open-architected coherent conglomeration", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "51625042-f06d-47ac-bc9e-62886d01044e", "22a44f97-6203-4035-82ff-f74166c4868c" },
                    { "f3b2f2ae-8395-46a5-9655-f0c351d1d9f8", "28ad7b5d-a958-4e75-849b-cd752590f760" }
                });
        }
    }
}
