using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class SoCloseNow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0047e381-def1-4427-9f33-21cdb93bbe7b", "1a7d3d77-7fa2-4dee-898d-c4e559fbe618" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73c60c7b-db49-40af-bc4f-5e949f00bb8d", "23efed20-97c1-48ef-9322-e760f121ed83" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05a53617-4f77-46c8-a74a-e3d6e0009d5f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "138d5a12-8841-45c0-82a3-96076946cfe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24e5ba0d-2d9b-4afa-8198-9612e4b9e1f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2fcb633e-0a14-4500-8011-5e7823e63454");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "317668b5-4640-4bc6-98f2-efedfd9de84b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c431cd2-9ee3-455d-a41e-da0761a123d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509f0faa-954d-42f2-b809-49ae183bb1ae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "607201b4-7b7d-4b56-a617-48dfd6b30733");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80776260-5bdf-46b9-b76e-b995f4f04550");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81d5b7aa-b5ed-4966-830f-334ebf4b877f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91ecd0d5-0d9d-407e-8ef6-202f1b4ad542");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96b79f9e-2ca5-4f02-952a-32ba4a2e6aac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b109a1fc-20cd-4322-9a81-7292e331732c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be0e6a96-5211-4cd2-8c12-f5c11b7308d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d256b63a-5b48-4a3e-8300-a0e6b686ad95");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3c91ac1-fb7a-4449-9a68-a38cd8cc6042");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3cdad2e-759e-4263-acb0-cbe311236959");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f026ae1a-d918-4a13-99d4-7db612e4c2d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6bd17ea-dc2c-4bfd-bc9c-c453278a8af7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0047e381-def1-4427-9f33-21cdb93bbe7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73c60c7b-db49-40af-bc4f-5e949f00bb8d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a7d3d77-7fa2-4dee-898d-c4e559fbe618");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23efed20-97c1-48ef-9322-e760f121ed83");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gilberto", "O'Kon", "Architecto eos esse quo explicabo rerum. Eveniet ut voluptate. Est quisquam nobis recusandae velit et magnam. Vero voluptatum molestias molestias. Sed incidunt saepe.", "Future-proofed stable functionalities" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Perry", "VonRueden", "Ut dolores ullam illo rerum iusto sit earum nulla voluptas. Illum et itaque omnis id nam reiciendis id rerum. Beatae ut alias et sunt. Enim aspernatur sit eum quo blanditiis quos et sit.", "Object-based systemic utilisation", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Inez", "Hand", "Doloremque temporibus eveniet et sunt et est consequatur dolor. Quas maiores deleniti laudantium vero ad veritatis maxime. Quod error beatae error ut delectus.", "Horizontal mobile capacity" });

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

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gayle", "Bradtke", "Consequatur in dolore illo. Et nemo eligendi libero error odit. Vel sint cum ut facilis autem et est. Qui quisquam cum eos omnis.", "Exclusive even-keeled hierarchy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Hazel", "Schultz", "Ea dolores ut distinctio eveniet. Soluta non dolores. Vel exercitationem voluptas harum provident.", "Stand-alone mobile website" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Catherine", "Zemlak", "Minus fugit ipsum sapiente sunt at. Temporibus dignissimos amet asperiores rem minima enim reiciendis occaecati sit. Impedit optio harum cupiditate aut recusandae et ut.", "Streamlined intangible framework" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Violet", "Parker", "Quia repellat qui ad autem. Eius sapiente eius consequuntur repellendus aut eligendi eos et ducimus. Maiores voluptatibus enim rerum. Non voluptatibus omnis mollitia maxime quasi consequatur. Nisi aut id nisi ex in est. Ea iste dolorum earum aut voluptas in laborum accusamus.", "Fully-configurable fresh-thinking info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Allison", "Kreiger", "Modi recusandae amet. Temporibus sit quidem aut repudiandae. Sequi corporis rerum qui. Et eius dolorem. Nam possimus facilis.", "Business-focused empowering hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Clayton", "Brown", "Eos qui cupiditate et vel qui provident aliquam numquam sed. Sed quia vel omnis hic qui qui. Quidem est laudantium facilis at optio hic corporis omnis. Nisi quis vel. Iste ut quasi libero et aut nesciunt voluptatibus vitae. Reiciendis omnis eum qui molestias odio veritatis possimus voluptatum et.", "Re-engineered 24/7 forecast", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Louis", "Christiansen", "Commodi ut laudantium adipisci assumenda unde. Quisquam quia tenetur non perferendis labore. Alias dolor quis ad recusandae perferendis tempore velit repudiandae. Quo maxime quod sit sunt ipsum nostrum quia.", "Monitored background benchmark", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Olga", "Mosciski", "Est voluptates dolorum eius. Iusto ad quae ut ut dolores odit. Aut consequatur sint reprehenderit ab quo. Quam dolorum porro.", "Grass-roots mobile intranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Javier", "Hoeger", "Et tempora quia laboriosam deserunt recusandae sit nam sapiente et. Officiis delectus itaque labore perferendis omnis et. Quo fuga est cupiditate aut ducimus.", "Open-source national matrix" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lauren", "Feest", "Non odio omnis et eum asperiores et exercitationem. Vel eveniet veniam eveniet recusandae sunt sequi assumenda. Fugit modi dolor culpa dolores quasi ut. Ea ut recusandae eveniet necessitatibus ut nobis debitis voluptatibus praesentium. Fugiat eveniet eaque quo aut dolores sit rerum. A earum reiciendis.", "Profound upward-trending analyzer" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Karl", "Schuppe", "Mollitia rem quo corporis ab assumenda et rem fuga id. Consequatur laboriosam deserunt corporis optio. Voluptas quis animi dolorum sed nam fugit inventore. Iusto non doloremque laboriosam ad aut sed neque.", "Switchable heuristic strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gordon", "Mertz", "Aut sit dolor voluptatem modi fugiat. Vel id in. Est aliquam quia neque. Enim et quisquam velit.", "Innovative attitude-oriented policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Annie", "Stokes", "Qui id vel et tempora commodi quibusdam. Non at maiores minus sit quod sed voluptatem totam dolores. Laboriosam in soluta.", "Synchronised intangible structure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rosie", "Dach", "Voluptatem atque dolores dolorem quos. Esse laboriosam rerum deleniti iure quos commodi fuga et facilis. Magni et minus tempora omnis.", "Adaptive zero defect flexibility", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lora", "Flatley", "Distinctio atque culpa dolorem neque similique velit hic. Tenetur vel id amet quibusdam vero consectetur. Aperiam reprehenderit aliquam ab doloremque ut vel. Labore ex maiores aut quis veniam beatae exercitationem.", "Networked multi-state model", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristie", "Metz", "Omnis aperiam aut officiis. Debitis repellendus nostrum magni. Ab dolor voluptatem dolor. Laboriosam repellendus omnis ut alias praesentium.", "Configurable asynchronous emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Arthur", "Bashirian", "Reprehenderit pariatur doloremque quia voluptatibus ipsa. Animi fugiat libero minima tempora qui. Libero quis animi. Et recusandae et numquam quasi molestiae harum est alias itaque. Eos officia qui omnis quos reiciendis consequatur est.", "Grass-roots attitude-oriented structure" });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0047e381-def1-4427-9f33-21cdb93bbe7b", null, "borrower", "BORROWER" },
                    { "73c60c7b-db49-40af-bc4f-5e949f00bb8d", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05a53617-4f77-46c8-a74a-e3d6e0009d5f", 0, "5531cfc5-f642-415b-a026-b3b038cbfa89", "randy_padberg@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHgSZwBn7phRBdnIQMh2bVPMqou0TDkwiGIFuaOXcXjQOM82mUEYfUSBVmGkY6tafw==", "383.709.4384 x5744", false, "5681b128-5db9-46d4-8035-b03e880fe0c8", false, "Randy_Padberg" },
                    { "138d5a12-8841-45c0-82a3-96076946cfe2", 0, "54f7908d-5a21-4bf5-842f-4012e174c957", "delores.sipes@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFWDvaxwjKat+j3308EqkdPjFnO5su7jKdxuf92D3fUGyBtB4kqd+Qy0OeoHLDk+qg==", "499.755.5632 x878", false, "cf402f14-491b-420d-8fae-3c57dd07eb2b", false, "Delores.Sipes" },
                    { "1a7d3d77-7fa2-4dee-898d-c4e559fbe618", 0, "5842dd9d-b959-4757-898e-829fda225f29", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEM0GECVJVNSbExJX7+MqnMrNSQGXjmp/6enefxEDGA16kvHHSU+PRIndemzOF194dA==", null, false, "349eb7cb-2e8c-47a7-95ec-437d3bcc0c54", false, "borrower@library.net" },
                    { "23efed20-97c1-48ef-9322-e760f121ed83", 0, "c21baaed-ae41-4421-8f98-c74bdb8b002b", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEN7bfKwdtgD8P+IuowbSI8GBj4+0EDkLsi8Nc2MXkgFahKKiIcdlzPMUfFAddE7R6Q==", null, false, "14f67882-ecb9-44f7-810e-e72cf6587d55", false, "librarian@library.net" },
                    { "24e5ba0d-2d9b-4afa-8198-9612e4b9e1f1", 0, "1ffe93d4-1a6e-406d-9551-d260443290eb", "blanca6@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHbhBLV1vAuZwywWka83d5tcHX/mS8JbLXErQ4LgXyH/pdxYkZru8EKLtAVPBTUozw==", "(271) 912-6691 x7476", false, "0211a71f-be48-421d-a915-9143d8379b73", false, "Blanca6" },
                    { "2fcb633e-0a14-4500-8011-5e7823e63454", 0, "77c96bbd-3397-4c8e-a328-8bd0a701c6c5", "suzanne_turner69@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKPgMjOiRbRnW4Un0RnFt4u06IyAfHrfSZMqmxV40bQGSJM8WAaBGJ+jm/RdxfwaAA==", "837.499.2090", false, "12a7aae3-4af2-45fa-aaf4-8fd5ffff3045", false, "Suzanne_Turner69" },
                    { "317668b5-4640-4bc6-98f2-efedfd9de84b", 0, "bf5db6b2-3fbc-4868-9ccc-e034dc27577e", "jeff.lind@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIS98FjBiuafLDBsJ/eQHyUvZbeMrzUqkhSP6+KgIshuB/0z1h6iz/AcgrhcfoCIVg==", "1-689-330-5896 x992", false, "592feb1b-96b0-465c-91ac-62fb38bf8104", false, "Jeff.Lind" },
                    { "3c431cd2-9ee3-455d-a41e-da0761a123d4", 0, "4c2ed5c9-d785-4b9c-9657-457afc422986", "abraham44@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECH0ok3WFWfP0tJmoHn2shsqjVsEI1a/sRhKyh+gyYt1OpjEisWsIeyLjO4Q6uyWRg==", "(782) 408-3910 x11078", false, "13ebfe24-0125-4e19-9a05-388e62f5b3d7", false, "Abraham44" },
                    { "509f0faa-954d-42f2-b809-49ae183bb1ae", 0, "57aeaeae-2712-4d13-adc4-b1596769144f", "charlene40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKThmNkm3AeePiU1DKvApeu/s6VZsS8Yr/ebtU+FmbMANee8wujBkp7HWz5gGp+Bcg==", "1-518-474-0142 x998", false, "252f0a29-1fde-46cb-a980-ef7506e03e36", false, "Charlene40" },
                    { "607201b4-7b7d-4b56-a617-48dfd6b30733", 0, "db7ef7ef-50ab-49ca-b727-2c8579d0c372", "gretchen.mills@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDvvtWQ7dsK5WQgEBfmeSLFL130C6h5Oc4tr6JpOf8OLq0wBrSKkE/kkd/tQz+GXfg==", "1-817-317-9414", false, "b140d2d6-c9f9-4ab7-943f-5c6389a2bd98", false, "Gretchen.Mills" },
                    { "80776260-5bdf-46b9-b76e-b995f4f04550", 0, "b46463fd-73c2-498e-b61d-be1372e547fc", "bryant_von69@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEExsLXBWHvquOzCo/8yuB5VLn4DrFqE2eACLqUS8h0Ime5VmQRMiCbwWm9sHxny7Zg==", "1-716-922-2689 x057", false, "ef07cda2-fb6c-482f-968b-b5253357f95f", false, "Bryant_Von69" },
                    { "81d5b7aa-b5ed-4966-830f-334ebf4b877f", 0, "838236ae-3339-49e9-8e55-c19c89fcc3cc", "juanita17@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOgPzzCh4fizTlTsCMK0oTTotpiqfT1peOp02MZ+QNLMFWb5A1WGDyVvzhPVMm8E/A==", "(208) 928-1699 x247", false, "86ab727a-8044-4d14-85bc-3cb028f18670", false, "Juanita17" },
                    { "91ecd0d5-0d9d-407e-8ef6-202f1b4ad542", 0, "a2a03101-033d-4480-8fb3-99acfa4f15d5", "ellen.howe9@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIx7ZOAh2gID5nujhefshgmz1QORD3sfm39k7m/q6nBkdGvf7SDzL0dt1P7zAwrAdw==", "(923) 289-2929", false, "0bdfe391-72a4-4bc1-9953-881b09eb86de", false, "Ellen.Howe9" },
                    { "96b79f9e-2ca5-4f02-952a-32ba4a2e6aac", 0, "b6d67724-55e2-4c6e-971b-a5b699bc784b", "lillie_okon@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFuJKxZ1XvjluGUK8C6RcDk87BI6NiKiwIFGqiY29M6ZtidERD/dLx8nO+CTqBbkXQ==", "(498) 861-5588", false, "b8c97e2a-b1c1-4d46-86b9-67325cd2d707", false, "Lillie_OKon" },
                    { "b109a1fc-20cd-4322-9a81-7292e331732c", 0, "8455eb91-7546-467d-a387-635baee194c9", "geoffrey_dibbert15@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENvGlXvSHb1WJamCkGCq55m6sTudSQYJEz+qu9wJOO7Ud1U2iJhEOSicNFjwcwEBCA==", "277.411.6777 x2412", false, "19bbb30e-10d5-4ec4-ab55-5412cb1b7022", false, "Geoffrey_Dibbert15" },
                    { "be0e6a96-5211-4cd2-8c12-f5c11b7308d0", 0, "02422073-de58-44bf-9587-2544457b858e", "julius15@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDNXOaY6wR4dA9JJB9Teum7ZR8OY6YEsmFeEk26zG7SlXMN6oQ6o15FVjbNx3T3ucA==", "864.541.9695 x947", false, "944f2d8d-8960-4d69-8254-a4aa2ee98670", false, "Julius15" },
                    { "d256b63a-5b48-4a3e-8300-a0e6b686ad95", 0, "c3c99ff9-9138-4d4a-8d2a-e96583a05039", "brett33@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBL8aYyHcMg9rkRZqjYln2FNMbtIjt6Pn6GWRPesAN87uiWP9nXCvn6bdxSNU6zmTA==", "798-746-1927", false, "851dc907-6358-4eb4-bb52-8a2c5e80a507", false, "Brett33" },
                    { "d3c91ac1-fb7a-4449-9a68-a38cd8cc6042", 0, "69902400-af04-43e1-926f-3d2ad82ff5c9", "bobby76@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHS7m+YB1zJ4enVDugehqlD00zvJlXhSJd3kuz1zOjlYd+6v10t77EDapgBM1BhJyw==", "(647) 511-1321 x147", false, "5a35ebf4-e1c5-45b2-94a7-774f3a7f9b29", false, "Bobby76" },
                    { "e3cdad2e-759e-4263-acb0-cbe311236959", 0, "1b07849e-d28e-40d5-969b-0d58269b9b8c", "paula.reynolds76@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEATVZk9N+PnpFpCJ965DBakfG7G0pgB7sUypOVnfjmszS//Eg2U/uCktWwgCy6GLnQ==", "(909) 403-8896 x238", false, "6cdb8723-28ce-4168-80b7-2575c29af811", false, "Paula.Reynolds76" },
                    { "f026ae1a-d918-4a13-99d4-7db612e4c2d2", 0, "1b5e515a-1ffb-45b7-8e92-904bef4f608b", "ollie.tremblay76@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJUsckKd+LyCgZZ9aF3fi9hUxip4wuZnCRn+p0EgGFTAzKg5vlo+97Kgjwj25DjQ4A==", "693-965-5794 x610", false, "e22b2c33-5ebd-4721-859a-7cce241413ca", false, "Ollie.Tremblay76" },
                    { "f6bd17ea-dc2c-4bfd-bc9c-c453278a8af7", 0, "29b88112-e580-43be-aa8e-bdaf58d5953d", "winifred_metz12@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOEmgBB8NSrO9yR0vML1IJSuakGav6Zrlln7HYCRMeBRJwhsj9f5lTqFRJ0lfwoazQ==", "1-864-786-9031 x585", false, "565e30b4-df33-4ba1-93f3-7be8a5a3bff1", false, "Winifred_Metz12" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Guadalupe", "Brekke", "Dicta possimus consequuntur praesentium et voluptatem provident qui. Doloremque ea unde nihil ut minus eos et illum. Autem voluptatem atque aliquid aut. Quasi minima eos voluptates.", "Focused zero defect productivity", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lewis", "Hand", "Voluptates magnam ipsa ipsum. Recusandae est ut quidem eum reiciendis non. Accusamus corrupti eveniet. Dolorem maxime voluptas.", "Secured incremental customer loyalty" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terry", "Jacobson", "Quia vel quasi totam rem vero temporibus iusto velit. Rerum nostrum et corporis consequuntur sed vel atque. Ad perferendis nobis dolores nisi quisquam vero dignissimos et. Adipisci ut odit doloremque perspiciatis blanditiis nobis. Eum animi et laudantium nostrum architecto velit distinctio. Voluptas corporis soluta quas corrupti velit similique esse laudantium.", "Customer-focused value-added Graphical User Interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Levi", "Hegmann", "Doloremque harum dolor numquam. Aut quibusdam et incidunt est perferendis voluptatum et atque consequatur. Ullam suscipit quam qui eos id aut ut sit. Eum consequatur iste iusto provident repellat magni. Accusantium dolor qui vero.", "Proactive encompassing policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jodi", "Doyle", "Praesentium animi dolorem voluptas velit consequatur. Est nostrum optio. Omnis quia est. Minus autem sunt laudantium ut aspernatur voluptatum explicabo aut. Impedit ut nostrum asperiores qui consequatur rerum facere reiciendis accusamus.", "Proactive fresh-thinking project", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Nancy", "Mann", "Adipisci sint et quia nulla iste veritatis voluptas voluptatem. Ut consequuntur laborum aut. Libero sint quia autem magni est ex et voluptate.", "Monitored radical product", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Robyn", "Mann", "Quo quis ducimus neque ea est iste. Quisquam architecto ea ex. Eum id dolores rerum voluptates et corrupti distinctio et. In repellat dolores et quos repudiandae.", "Implemented asymmetric interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Wilbur", "Hahn", "Nostrum labore veniam et quam aut architecto. Soluta eum tempore odio quibusdam vitae est. Dolor omnis consequuntur cupiditate quis sapiente itaque fuga minus.", "Down-sized 4th generation initiative", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Percy", "Lang", "Consequatur aperiam veniam culpa velit repudiandae et. Culpa mollitia quibusdam pariatur magnam iure natus voluptatum. Fuga aliquam pariatur veritatis.", "Programmable dedicated local area network" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rogelio", "Gusikowski", "Magnam eligendi molestiae officiis sit voluptas officia tempore atque. Consectetur inventore corrupti dolor. Dicta architecto maiores hic temporibus sed voluptate nulla aliquid enim. Quaerat voluptatem maxime.", "Right-sized attitude-oriented throughput" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Olga", "Larkin", "Ut quae perspiciatis. Dolores ea nam adipisci voluptates odio fugit dolor aperiam. Et et sed blanditiis nesciunt debitis dolores et possimus. Doloribus est nihil vel mollitia rerum est. Et et quas earum quia quam omnis voluptatibus.", "Innovative real-time alliance", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Peggy", "Crooks", "Omnis id accusamus quia. Aut ut assumenda iusto neque esse non ut eveniet. Nihil qui suscipit corporis iste cumque voluptas incidunt sit. Quas modi recusandae consequatur sunt modi et aliquid. Eaque odio aut itaque minima nisi accusamus.", "Fundamental directional secured line" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Darla", "Fritsch", "Enim voluptas quidem explicabo asperiores dolorem. Qui et assumenda. Et quia voluptatum eum ut et quod. Ipsum neque aperiam eligendi consequatur nostrum non laborum et qui.", "Synchronised transitional open system", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Reginald", "Schmidt", "Laboriosam sunt illum quos deleniti. Doloribus quo nesciunt. Beatae veniam ut cum. Sapiente itaque enim dolor asperiores aut non rem sequi.", "Intuitive leading edge open system", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Richard", "Hand", "Quaerat corrupti magni optio ex. Sit cum deleniti magni. Aut voluptate ipsum labore eveniet cum voluptas pariatur.", "Polarised bottom-line hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Georgia", "Zulauf", "Excepturi est omnis non nostrum accusamus ea delectus. Excepturi fugiat consectetur. Provident et quisquam quo ratione quod vero ut ut ut.", "Open-source stable encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Francis", "Kshlerin", "Sint est maxime magnam explicabo non. Ea omnis eius fuga nulla atque dolor sunt voluptas. Et fugit at aspernatur rerum dicta iste aspernatur perspiciatis repellat. Est id non id sequi dignissimos blanditiis. Facere eaque nobis et magni aperiam fuga minus voluptates.", "Progressive mission-critical protocol" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Veronica", "Harris", "Sapiente totam itaque tempora et. Quis quos voluptate tempore aut et repudiandae autem. Nihil est mollitia quis. Repellat quasi ut beatae. Enim tempore nemo nemo sunt. Voluptas amet aperiam temporibus omnis at repellat temporibus facilis qui.", "Implemented zero tolerance approach" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shannon", "Nader", "Ratione exercitationem consequatur qui qui. Voluptas quisquam animi. In ab eos.", "Expanded mission-critical open system", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Todd", "O'Hara", "Asperiores repudiandae repellendus laborum. Adipisci omnis ducimus blanditiis reprehenderit rerum quae et aperiam. Id at aliquid veritatis consequuntur iusto eum. Sunt numquam et aspernatur corrupti quasi consequatur inventore optio. Autem voluptatem hic asperiores ea corrupti minus. Ratione quam sequi voluptatem tempore ipsam cumque.", "Exclusive methodical circuit", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Geneva", "Schmeler", "Nihil et neque cupiditate. Porro expedita consequatur inventore deleniti aut dolores. Fuga fuga aut incidunt et repellat magnam. Nobis placeat atque voluptate. Non recusandae veniam. Voluptatem ad et eligendi.", "Face to face transitional open system", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jermaine", "Smith", "Totam cupiditate animi tempora inventore explicabo aut veritatis. Et inventore aut rerum qui nihil eos. Iure quaerat ut sit et. Est et similique.", "Progressive 3rd generation array" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Marcella", "Maggio", "Impedit officia ut voluptatem voluptatibus. Cupiditate voluptate placeat facilis officia perferendis dolores et. Fugiat sequi voluptatibus voluptatum dolores incidunt ea. Quia excepturi molestias facere.", "Customizable needs-based infrastructure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rosa", "Hickle", "Cupiditate alias ex exercitationem aut consequatur rerum molestias. Dignissimos maiores et dolore nemo et occaecati. Minus tempore ab fugit molestiae recusandae pariatur. Aut earum velit ut reiciendis qui quam deserunt et. Sit cupiditate reprehenderit esse.", "Ameliorated impactful matrix" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Minnie", "Schneider", "Nulla deleniti blanditiis non alias quas nihil autem qui. Consequatur aliquam harum magnam consequatur pariatur alias cum deserunt veniam. Nostrum modi voluptatum recusandae tenetur quidem ut perferendis.", "Enterprise-wide incremental knowledge user", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Brandy", "Prosacco", "Dolorum voluptatem beatae blanditiis illo voluptas rerum. Rem porro aperiam. Fugiat animi error excepturi quia.", "Realigned uniform parallelism", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "William", "Goldner", "Neque doloremque alias quo nulla. Pariatur sint commodi. Ut assumenda qui qui rerum est. Non ab est soluta non illo.", "Operative bandwidth-monitored groupware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kate", "Osinski", "Autem et non asperiores illum sint iusto autem ipsum. Nobis sit consequatur sed nemo atque eum. Molestiae in aut saepe molestiae.", "Expanded stable leverage", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Clyde", "Dickinson", "Ut officiis aut aut corrupti nemo consequatur et dignissimos qui. Tenetur corrupti qui quo non autem maxime omnis possimus commodi. Sunt consequatur et quis ut veritatis laudantium voluptas excepturi voluptas.", "Organic upward-trending instruction set", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Janice", "Larson", "Minima est molestias magni minus. Doloribus nisi in. Et doloribus veritatis ipsum quo enim vel accusantium. Quia quo itaque voluptatibus exercitationem quos est officiis tempora sed. Magni tempore consequatur occaecati est soluta cum reiciendis.", "Implemented neutral open architecture" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0047e381-def1-4427-9f33-21cdb93bbe7b", "1a7d3d77-7fa2-4dee-898d-c4e559fbe618" },
                    { "73c60c7b-db49-40af-bc4f-5e949f00bb8d", "23efed20-97c1-48ef-9322-e760f121ed83" }
                });
        }
    }
}
