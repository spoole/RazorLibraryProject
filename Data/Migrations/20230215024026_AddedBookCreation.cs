using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "883ab2fb-fc23-48a6-8e7f-02bbc5acfd32");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd774386-0ae2-4fd2-ace5-ad0cd28c42bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "efee282e-25f1-43e0-8840-b31d1f44acc3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fb08e342-93a2-4950-ace5-f6530340e84b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "05a5712c-dfe9-4ecc-b4af-502057a631fd", 0, "c22705c9-2685-4881-895a-65a15d34f0bc", "stuart.lemke@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ5Hz/yU2Ni5ekegupm9NxSJk6zGZSAR8/Q5vvmyBbnucTicgMatAWl+SczPDC5MJQ==", "447-645-1194 x05339", false, "d45ccf5c-1644-445b-a520-64a4b15ffa1d", false, "Stuart.Lemke" },
                    { "1e09d7b5-b8e8-4912-91c0-32e4a88fae92", 0, "de71f105-4500-4e63-b5c9-e1df46ebb344", "kerry75@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBbue6Z3kpW9ockKBnYslOPBHH6ZEXwB9saZX0XLoN9dhknAE0HyyQfDYZl/vR1yQA==", "1-521-325-6521", false, "7633a351-5642-46e0-ae6c-c5ba628e4c18", false, "Kerry75" },
                    { "2cdad823-99df-4b0b-9d75-e7d9aaea1333", 0, "9240e7d2-fffc-45e4-9ebb-63261f1bb59f", "dewey.schultz4@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEINUPLi3HyqzM2O0KfRQ3aLihA6eZQMF5RxeXIrCxOJt2+hxkxDjCGk8gsOubzN1jQ==", "(833) 255-9985 x089", false, "38a0c4a2-7494-4d4b-87db-060ee15c579b", false, "Dewey.Schultz4" },
                    { "2d3d1e9d-e686-4976-af49-82bf231cbceb", 0, "4213a958-c439-42c2-8361-610c3650fccc", "delia_johnston39@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENCnGcAwXt9iEw2NaO7shmteKpyZ3DXokbatgtXoQeBFf339kcIpIsdyGaL6/7zNCA==", "(668) 610-3927 x67486", false, "f52e9889-8555-4574-bad6-7e1571da546d", false, "Delia_Johnston39" },
                    { "43f1d1a9-d9e3-44b8-ade1-2302270c34c5", 0, "04170687-5f9d-4ab5-8507-cec3c551535b", "todd.rippin@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELzjJd08NRXQ2xq4Q5a6o/2ERK05Ya/5cvAFmJ8aYHjhemslN2FKvtAexW4ajWUrFQ==", "1-527-439-2583", false, "a9dcc0cf-caac-4d7b-8961-9ebe454ad2c6", false, "Todd.Rippin" },
                    { "7b9991c4-3a88-4515-a67a-ec46e83cd29d", 0, "de2d8c24-7c83-43a4-bf3f-793b83911491", "jonathan_powlowski79@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHpni19NeLP6Y+AItykfpiH/dh+L/F+cn+EKMNHlmQHAGaoF5R4Wgt21gIxrcuifDA==", "1-517-575-3375 x432", false, "189196a9-884a-4405-90f0-76241455ac06", false, "Jonathan_Powlowski79" },
                    { "7e1edd4d-b0f8-485f-a54c-803f32519035", 0, "a2b65d57-dfc4-41b6-a1fb-b438f8da2301", "kristine18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELfU9lOS8XehxRQeD7w0RCc8qQxL9qcRdp6CemPnab8vxORN0jMsASdrACOIoXXSFw==", "1-496-302-9581 x60082", false, "288d41be-9860-499c-97cb-c0d57284abd9", false, "Kristine18" },
                    { "87c0785b-62e7-4638-ac45-671ea2a5f8d0", 0, "f000a490-a935-422c-9239-985eecdc648a", "stewart.herman@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJEeSK1fLUzOh9eXQhsgB1vzHCUvuRSTRDgbgRiQVh5eK1AXsu1B+b3AlEaKSVZ5Vg==", "587-835-8571", false, "5f36ebd8-a37e-4256-891b-c51a3f95cc54", false, "Stewart.Herman" },
                    { "8f8c2d71-1c7d-4876-8dde-d4492aca6aab", 0, "79156f5b-62c7-41aa-bb64-8bf924e352ab", "marty_kohler36@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMMzJJWHO0Eudj2z+3ICW/Sf0WbcZf4tOd6R7I10YhJPgfp/YfsCbcR86hpcPKKTSA==", "439-931-4997 x874", false, "cc9bc0a8-45b2-474a-b687-3e6a12ff8f14", false, "Marty_Kohler36" },
                    { "999eed49-bf0b-4136-b950-968a1fa71ddc", 0, "dd201912-1f47-43d7-b0b5-160c83fc6ede", "marguerite0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKoMZvgN3w2B0F1Si0T2unIvymZ14AeIl5QsYTfueVcn6qXZG+LDGUX4lOGV+9Lkbw==", "843.333.9528 x6153", false, "994e8640-41ec-4e43-9661-e55d32863cf6", false, "Marguerite0" },
                    { "b43822c5-872f-477f-bb3c-69f4b51569b0", 0, "c82c05dc-c51a-40c0-8ba6-7afd4cda0ac2", "candice_heidenreich@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGyl2/wX8r8X7vs/Smdb1l0/2HAjpEDdA68v08oxa+BhWKlm7dJmEPG178ZPvuh4vQ==", "1-651-748-7956 x670", false, "77b7e5bc-2001-48f6-a240-25346fce0a55", false, "Candice_Heidenreich" },
                    { "db593821-8e01-498c-892e-016e2bb4cfde", 0, "e9d91336-063a-4cb6-b165-84b4ce3500b7", "marvin_hartmann@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP8lTnl+Q1mirmgQiSTyS3FHkg5vMt/f0tR7wpr/hvjzN1HDd+HmaZkYXH/mhP5KBA==", "(988) 804-2661", false, "792dc47e-0495-486a-a022-7db2854af06f", false, "Marvin_Hartmann" },
                    { "e5836e75-8e2c-4d44-ba65-e5dff45cabe8", 0, "a4ef29f8-20b1-406a-acad-fef24048f714", "salvatore28@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDRMT836OK/Ovv/de94IEmbzlXjm3ym6KikXP6RpOZ8/po3YWZgr/0gsiTddutsGdQ==", "(253) 877-3269", false, "b1eebb00-1d0c-4c8b-83d9-423cc52bac5f", false, "Salvatore28" },
                    { "ea1b45ae-acc9-4569-bab5-97860e4e5dbc", 0, "5be573a0-a830-415b-9fc0-c03e96ff27c9", "rebecca48@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIdhnCYgjgdch/gTfmyRlYQue7koZSbAVgJ35O72hZBjTJn/Yoa/pOYwzvjvpVIJog==", "1-766-510-3215 x048", false, "5147f77f-8eb4-4788-be8f-c6ab5bb11c7e", false, "Rebecca48" },
                    { "ef8c9b7f-cb8c-4591-b53d-40d817054eab", 0, "3c3ad992-c040-46cb-90ba-70560f8f70a1", "priscilla45@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAED9h6YNbGjjM0W9/5vYwRQFVX+YOAuw+yOWbmIVAPkPqvSYgKIcDy0mAUxGf8jMjmw==", "460-348-9725 x4938", false, "7509b5bc-6c54-4b53-bb0f-80d6eb047e1f", false, "Priscilla45" },
                    { "f135d071-9671-4884-bfdc-dddc231706ec", 0, "6158f671-9528-4bfa-bfb2-432cebaf13ba", "kellie.rippin25@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPdzTULt9htH/POC+WfMobLGiNol/ERpiAYLMNm3w1j8vgCoka8JSSXpufWWFHf7ug==", "934.742.7434 x37367", false, "bad45237-901e-47c6-9ff6-4f0a9dae3596", false, "Kellie.Rippin25" },
                    { "f351d533-5623-4c28-aa46-5b21f667d11e", 0, "885baf5c-1956-4a67-bec7-2685129ac5a1", "thomas.hartmann@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBPIW8mP1E00PS11Dt8U15tFzU/50gg9o/XPET+TgpcKSNeItQmdQz0z24pEvXJbKg==", "490-456-8022 x183", false, "9f44490c-7d11-493a-8d3a-c3098e0a2218", false, "Thomas.Hartmann" },
                    { "fa159046-c815-4f08-b8bb-8d61bb753d7f", 0, "9a34a4c6-8ed9-46cd-b434-cd46f80d3768", "olga_jaskolski@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPeBhwapAo8Vui9cD3DmCE9/r9qMx2518mGfdoSqEB8+L/B/EcrGizBO1/OYpJQRFQ==", "719-448-7303 x69698", false, "2737b6e1-bbaa-4599-8df1-45f87f0c4837", false, "Olga_Jaskolski" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 1, "Carla", "Graham", "Necessitatibus quas aperiam pariatur et quam odit odit labore voluptatem. Asperiores modi maxime voluptatum similique assumenda excepturi quidem. Architecto et nihil voluptate saepe qui.", "Digitized holistic moderator", false },
                    { 2, "Viola", "Lemke", "Est aliquam et est tempore harum omnis quis et. Ut fugit ullam minima id fugiat recusandae eos. Et est et accusantium officia repellat excepturi.", "Realigned intangible superstructure", false },
                    { 3, "Gabriel", "Kulas", "Sit reprehenderit velit. Voluptatum ut aut sed animi. Eveniet ratione eum sed aut distinctio. Earum officia voluptatibus velit totam. Rem corporis non et perspiciatis maiores quaerat.", "Balanced holistic function", false },
                    { 4, "Reginald", "Ratke", "Facere cumque assumenda dolores quod. A deserunt rem quae. Est minima et. Tempora odio deserunt voluptatibus sed ratione. Asperiores excepturi vel voluptas eaque nostrum nam reiciendis quaerat. Debitis et sunt possimus aliquam esse praesentium expedita vitae placeat.", "Managed bandwidth-monitored utilisation", true },
                    { 5, "Pete", "Gislason", "Sapiente omnis officia sint ut est qui velit minima. A sit dolor recusandae autem repellat eveniet enim ullam. Illum rerum officiis et ea et dolor incidunt. Minus voluptas est fugit eum rerum nostrum atque sit repudiandae.", "Pre-emptive well-modulated model", true },
                    { 6, "Seth", "Okuneva", "Voluptatem vitae officia id quod excepturi. Quia numquam est ipsa voluptas. Dignissimos labore aut accusantium sint voluptatum hic blanditiis. Qui dicta cum iste nemo qui quia sit aliquid. Reprehenderit aperiam et suscipit mollitia adipisci et. Consequuntur iusto enim.", "Visionary attitude-oriented core", false },
                    { 7, "Yolanda", "Yost", "Nobis sed dolorem voluptatem. Voluptatem et quas quisquam. In eveniet omnis quo. Commodi voluptas quis.", "Operative interactive capability", false },
                    { 8, "Josefina", "Ziemann", "Odit corrupti enim iusto sapiente molestiae quos illo soluta alias. Vel est natus est deleniti blanditiis corrupti. Dolorem nulla recusandae mollitia sint qui.", "Profound system-worthy system engine", false },
                    { 9, "Faye", "Gislason", "Animi enim et reiciendis occaecati dolores ut alias laborum. Qui rerum corporis dolores eos placeat ut. Illo est ut assumenda.", "Quality-focused global challenge", true },
                    { 10, "Kate", "Witting", "Qui fugiat totam quo repellendus autem quis. In quo delectus ullam ut cumque veritatis reprehenderit iure. Ab et quia quibusdam veniam voluptate cumque quod et. Laboriosam consequuntur id quibusdam rerum libero voluptas. Non ratione deleniti omnis eum quisquam minus ab et eos. Neque eum ipsa quaerat molestiae veniam.", "Optional next generation neural-net", true },
                    { 11, "Eileen", "Bruen", "Velit velit quo iure impedit rerum odio. Dolores vel repudiandae quia ipsum dolor. Sapiente at quia et alias asperiores.", "Virtual 24 hour algorithm", false },
                    { 12, "Lori", "Von", "Sunt quisquam optio quaerat mollitia reprehenderit provident soluta quia. Dolor cumque tempore in sed assumenda et repellat. Quae facilis nulla qui illo quam.", "Synergistic web-enabled structure", true },
                    { 13, "Mona", "Hintz", "Vel qui nihil est quia eum exercitationem magni id. Ratione provident soluta recusandae. Fugit est repellendus quo sit eligendi. Dolore sint rerum voluptas quae similique.", "Inverse multimedia neural-net", true },
                    { 14, "Della", "Kuhn", "Ducimus adipisci sint maiores fuga. Nobis architecto saepe similique deserunt qui nesciunt dolorem. Accusamus dolorum aliquam aut eaque assumenda nostrum quis qui. Sit ratione non hic earum aperiam aut et dolorum. Odit qui aut repellendus dicta blanditiis. Et saepe consequatur voluptatem sunt omnis dolorem commodi vel minus.", "Distributed intermediate orchestration", false },
                    { 15, "Paul", "Lueilwitz", "Aspernatur non consequuntur iusto aut omnis ipsam nemo qui aliquam. Voluptatem tempore non ex et quas cupiditate ipsam cumque recusandae. Tenetur omnis quasi in ducimus et ex.", "Down-sized high-level encoding", false },
                    { 16, "Stacy", "Prosacco", "Temporibus est quo nam esse aut molestias sapiente. Asperiores veniam itaque distinctio esse qui. Nesciunt a qui qui dolorem est adipisci saepe. Similique dolorem quia.", "Switchable actuating help-desk", true },
                    { 17, "Olivia", "Hilpert", "Quasi odit ea quae nam quibusdam laudantium provident itaque labore. Tempore est nihil reprehenderit itaque tempora voluptas ullam et totam. Aut asperiores quibusdam delectus voluptas velit alias officiis dicta. Quam omnis ratione aut.", "Integrated context-sensitive challenge", true },
                    { 18, "Vanessa", "Roob", "Laudantium doloribus quibusdam vel exercitationem quo. Aut quis nihil odit. Molestiae iusto dolores eos blanditiis officia aspernatur explicabo sed. Nesciunt doloremque voluptatem recusandae dolorem. Voluptatum aut sit. Perspiciatis magnam debitis.", "Automated analyzing toolset", false },
                    { 19, "Chester", "Tromp", "Similique et ex at delectus itaque. Alias et provident. Reiciendis dolorum iure omnis. Optio voluptatem sed sapiente veniam a.", "Vision-oriented empowering throughput", false },
                    { 20, "Rickey", "Ankunding", "Fugit sunt qui voluptatem maxime quidem minima et quisquam. Molestias et consectetur aliquam quam voluptatibus odio sapiente. Maiores nihil quod pariatur ullam quas a.", "Focused regional extranet", true },
                    { 21, "Hubert", "Ritchie", "Maiores omnis officiis alias libero. Magni debitis sequi consequatur distinctio placeat aspernatur. Qui quia fugiat consequatur. Et quod molestias et ut.", "Programmable contextually-based circuit", true },
                    { 22, "Orville", "Jast", "Sunt quae similique aut libero architecto velit explicabo. Delectus exercitationem omnis est et vitae tempora. Sunt rem omnis perferendis cupiditate autem hic sapiente.", "Automated static info-mediaries", true },
                    { 23, "Courtney", "Wiza", "Inventore voluptas iste atque. Consequatur et nesciunt temporibus voluptas. Ut consequatur consequatur aliquid incidunt nulla velit. Nobis fugit nostrum quibusdam architecto eius non. Asperiores consequatur laudantium.", "Upgradable hybrid software", false },
                    { 24, "Gina", "Gusikowski", "Voluptatem voluptatem voluptatum velit est perferendis quae consequuntur. Omnis voluptatem dolorem sit iste consequatur maiores corporis odit. Et qui asperiores deserunt.", "Synergistic empowering capability", true }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05a5712c-dfe9-4ecc-b4af-502057a631fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e09d7b5-b8e8-4912-91c0-32e4a88fae92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2cdad823-99df-4b0b-9d75-e7d9aaea1333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d3d1e9d-e686-4976-af49-82bf231cbceb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43f1d1a9-d9e3-44b8-ade1-2302270c34c5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b9991c4-3a88-4515-a67a-ec46e83cd29d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e1edd4d-b0f8-485f-a54c-803f32519035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87c0785b-62e7-4638-ac45-671ea2a5f8d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f8c2d71-1c7d-4876-8dde-d4492aca6aab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "999eed49-bf0b-4136-b950-968a1fa71ddc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b43822c5-872f-477f-bb3c-69f4b51569b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db593821-8e01-498c-892e-016e2bb4cfde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5836e75-8e2c-4d44-ba65-e5dff45cabe8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea1b45ae-acc9-4569-bab5-97860e4e5dbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef8c9b7f-cb8c-4591-b53d-40d817054eab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f135d071-9671-4884-bfdc-dddc231706ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f351d533-5623-4c28-aa46-5b21f667d11e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa159046-c815-4f08-b8bb-8d61bb753d7f");

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10);

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "883ab2fb-fc23-48a6-8e7f-02bbc5acfd32", 0, "b254c66d-95cc-40d3-afe2-8c225a781449", "boyd79@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENz+FK0/MlPE8rjkanz9+DhnfaO12pY38eJV4ZM98CLX9AQaSxGiRepYkmj29hAMjw==", "(891) 490-6184 x58733", false, "cd54dae7-782c-4853-a698-d29e42d42e71", false, "Boyd79" },
                    { "dd774386-0ae2-4fd2-ace5-ad0cd28c42bb", 0, "755d193e-459a-4988-8a84-b11436024a7a", "amy_wisozk15@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJLBUlQBJcVFTM/QuQdrSCf16kAF7sV0cyN1jVs0KTogbzRB9Um5VXlNHunrEiXYqw==", "(843) 914-1403", false, "f916601d-2003-48e4-bafb-307655b946a7", false, "Amy_Wisozk15" },
                    { "efee282e-25f1-43e0-8840-b31d1f44acc3", 0, "edec86c0-680d-4058-94fb-6246d0672ed7", "susie20@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH/3uNCQ0kYGlyrI2RdE9cBozgXAhyHhGxDvDAn+7O9MuS1L120awXVPdiMbjCgstw==", "1-539-673-6319", false, "5515ef8f-ca5f-46c5-bed1-17dc4c91ab5d", false, "Susie20" },
                    { "fb08e342-93a2-4950-ace5-f6530340e84b", 0, "6210c5ae-12e6-4f33-b75b-2c45ddb4bd00", "fannie_sauer40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMLW6SbhtLx2I2moCL7p2QN6RybCxiIisFc4Q3JJmqUpkPDB0gWK4h4crqD9IIrf1g==", "406.972.5184 x9067", false, "178fafde-fe0a-4e44-83f1-73e7973ff067", false, "Fannie_Sauer40" }
                });
        }
    }
}
