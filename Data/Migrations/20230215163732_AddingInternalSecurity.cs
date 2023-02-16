using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingInternalSecurity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf", "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "01284a83-e74a-4206-aec5-34f385ed20a5", "cb7c76d8-1748-42bd-adcd-b307247781de" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0167720a-14b2-44c8-8f1a-9efa696bf95a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13ec32e0-5cc8-46f7-9991-d3b3b99d4774");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1515cab7-3e7c-419c-a6b9-22492de78540");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d9e5deb-ae38-4a72-b3a5-4b7742f59ce8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f8f6bb8-e9d1-4209-ac47-a404b33cd4da");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2990a32d-523f-4859-868a-62b3b58511d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ece7cf8-955e-4809-9de0-87997742460d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d83e477-fee0-410b-a764-c9dc659862b2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84ccedea-e60b-42ef-92a3-a66d5dc72830");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8be73e1d-76d6-479e-856f-03b064d4cf2f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "971371a7-feb2-400b-94b3-560c80cca99b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a86b6a8-d4bc-4927-b1bc-2e164f578c35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4781e30-cde1-42c7-ba82-c25232feb9de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aaba92a6-b157-4bc0-9bcc-c31dc58d5f2d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af0b5655-46d2-4032-93b0-a9d4fb240981");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb773360-6700-4d07-b302-69f33524b6d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f474cc19-cf5b-4fa9-b59a-e269a0303ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fea1b38c-87f2-40c7-9f2a-c94287a2329f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "01284a83-e74a-4206-aec5-34f385ed20a5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb7c76d8-1748-42bd-adcd-b307247781de");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Nicole", "Christiansen", "Natus similique reiciendis. Nulla minima beatae est qui natus dolor. Doloribus nobis rerum dicta distinctio. Maxime eveniet veritatis officiis sed est molestiae quam nobis.", "Programmable contextually-based toolset", true });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Chad", "Hyatt", "Quis est et excepturi vel. Beatae distinctio quibusdam. Deserunt natus et architecto eum eum dolores facere et accusantium. Excepturi et et pariatur ex.", "Future-proofed 5th generation service-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carl", "Hartmann", "Impedit ratione est in. Exercitationem et non alias ut voluptatem animi consequatur voluptas. Animi temporibus accusamus veritatis. Nesciunt aut aut eos ut magni consequatur et fugiat eligendi. Nemo adipisci est esse fugiat.", "Fundamental upward-trending productivity", true });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kelli", "Heathcote", "Molestiae deleniti perspiciatis ad aut voluptatem. Tempora necessitatibus qui rerum. Vel enim animi et. Ea tenetur ab quam impedit.", "Centralized hybrid customer loyalty", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carla", "Kautzer", "Qui deserunt nam adipisci corporis et facere voluptate et. Consequatur et voluptatem in ea est dolores impedit. Maxime velit quasi. Inventore in quam quis. Temporibus atque magni et commodi et. Deserunt aut vel dolor.", "Cloned zero tolerance encryption", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cassandra", "Hane", "Dolor sunt sed itaque. Dicta tempore neque repellendus praesentium magni tenetur. Consequatur dicta esse reprehenderit in doloribus doloribus necessitatibus unde a. Unde consequuntur itaque explicabo corrupti omnis saepe nemo harum. Impedit qui delectus.", "Open-source local artificial intelligence" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Leonard", "Buckridge", "Sed at autem deserunt sint inventore qui. Sunt ut sequi quod reprehenderit praesentium voluptatum ea explicabo. Et odio error odit provident dicta. Optio et dolorum. Ut doloremque numquam sapiente animi animi. Et aut odio.", "Optional didactic software", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Evan", "Wilkinson", "Sapiente ab perspiciatis cupiditate. Saepe aut doloremque corrupti. Animi facilis possimus exercitationem nesciunt architecto. Eum sapiente sed et. Assumenda sequi et quas esse.", "Re-contextualized scalable hardware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Terrance", "Cole", "Velit rerum aut veritatis labore. Quod ipsum id. Laborum architecto quaerat architecto asperiores ut qui saepe porro corporis.", "Versatile optimizing workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Bethany", "Senger", "Suscipit soluta autem quod sint qui vitae nisi. Et facilis sed. Magni optio aperiam omnis dicta similique cumque et veritatis. Voluptas error laudantium labore eum aut illo debitis. Voluptas deserunt quo. Qui quo nisi ad.", "De-engineered actuating service-desk", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Raymond", "Sawayn", "Libero iste a ipsum. Libero accusantium distinctio quaerat et assumenda dolore et accusamus aut. Cumque est non.", "Decentralized grid-enabled benchmark", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Earl", "Price", "Amet repudiandae dolorem alias. Quis excepturi consequuntur illo autem similique provident repellat quas dolor. Sunt fuga qui est sapiente ullam aut sed perferendis. Optio neque tenetur. Quas beatae minus dolorem architecto id.", "Universal system-worthy encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Irene", "Turner", "Dolor quia et eius ullam maxime vitae. Omnis dolorem fuga. Eveniet aliquam maiores quidem quas incidunt voluptates quia. Est magni consequatur quam. Ullam qui et in fugiat id. Velit minima aut animi sit voluptate.", "Cloned multi-state archive", true });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rita", "Bayer", "Sint officia nesciunt. Labore necessitatibus aut inventore quis ipsa porro id. In atque quas. Non rem non ut.", "Vision-oriented analyzing toolset", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Martha", "Boyle", "Molestiae qui nulla architecto. Consectetur non sit quod qui. Deserunt sequi illum ut labore voluptas saepe sequi. Nihil ducimus vel architecto qui. Nulla commodi velit ducimus occaecati eveniet. Esse dicta ut perferendis animi doloribus non.", "Horizontal holistic leverage", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wilbert", "Mosciski", "Consectetur ea aperiam labore. Consequatur omnis quae mollitia ut praesentium voluptatem blanditiis impedit. Consequatur quos aut eum. Ratione porro libero molestias ut ab atque. Sit et saepe nulla aliquam ratione.", "Future-proofed dedicated Graphical User Interface" });

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

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jesus", "Farrell", "Omnis nihil sint. Enim ut nihil tempora vero officia soluta excepturi dolorem. Hic mollitia omnis mollitia porro odio dignissimos repudiandae sunt. Explicabo ipsa numquam qui provident saepe. In aspernatur sed sed culpa dolorum et. Dolore vel quam sint est debitis quo tempora laboriosam amet.", "Exclusive content-based throughput", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Salvatore", "Schumm", "Possimus laudantium ipsam unde. Aut reiciendis quidem rerum illo doloribus corrupti eum. Iste pariatur ut modi illum totam numquam minima animi provident. Rem amet reprehenderit et rem neque. Qui laudantium mollitia est nam voluptate.", "Horizontal non-volatile approach" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Chad", "Wolff", "Accusamus culpa in voluptas qui incidunt. Quasi atque inventore sed vitae possimus deserunt eligendi. Vel dolores minima est aperiam incidunt iste dolores sunt laboriosam. Qui vel rerum architecto natus sint.", "Front-line explicit internet solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lola", "Torp", "Aliquam occaecati et exercitationem. Eaque quae excepturi. Ipsam ut dolore voluptatem eius. Nobis consequatur ad commodi voluptas voluptates fuga suscipit animi.", "Down-sized uniform matrix", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Taylor", "McKenzie", "Delectus quis officiis id et officia. Excepturi corrupti et ut quibusdam nihil qui saepe in omnis. Qui velit facilis quia unde.", "Business-focused uniform encryption", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Donna", "Romaguera", "Placeat voluptas ratione aspernatur debitis. Ut perspiciatis rerum est quos quam. Veritatis sapiente voluptas fugiat repudiandae laudantium nobis sit.", "Decentralized zero defect solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sidney", "Hoppe", "Culpa non placeat debitis quisquam ut assumenda quae. Non doloremque saepe aliquam tempora. Blanditiis non est eos fugiat. Eius odio quod et qui aliquid voluptatem sapiente eaque fugiat.", "Customizable next generation superstructure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Katie", "Braun", "Facere sint tempore placeat animi necessitatibus sunt ut molestiae necessitatibus. Nulla voluptatem qui. Non dolor ex ut. Aut quam repudiandae pariatur magnam qui culpa laboriosam. Unde iste veritatis dolores rerum pariatur et dolore. Eos illo consequatur quis amet.", "Re-engineered uniform adapter", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Stuart", "Krajcik", "Aperiam commodi sit et ea pariatur. Deserunt cum sit excepturi est nihil ut velit recusandae aut. Et consectetur consectetur. Soluta et doloribus eius qui alias et at. Excepturi omnis voluptas praesentium vel deserunt quia voluptas incidunt. Id sit labore qui deleniti quia rerum cumque.", "Decentralized incremental Graphic Interface", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ramiro", "Gaylord", "Quos culpa vel quis aut eius qui. Sunt ea aut eius mollitia. Vero quae ut ab dicta qui vero. Ex mollitia architecto sapiente nostrum dolor eum ad officiis incidunt. Quibusdam ipsum veritatis. Qui porro et incidunt fugiat nihil et doloribus.", "Face to face attitude-oriented support" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cora", "Friesen", "Nam id eum odit accusantium assumenda eveniet dolore in omnis. Maiores dolores voluptas est et. Maxime mollitia placeat aut ut vel rerum alias. Vero sequi dignissimos voluptate ea deserunt veritatis provident. Cumque rerum consequatur fuga omnis quia est.", "Business-focused intermediate paradigm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ivan", "Lockman", "Ducimus cum natus expedita culpa molestias beatae. Suscipit eos consequatur inventore architecto asperiores nemo. Blanditiis saepe qui animi saepe. Et facilis mollitia dolorem totam. Eligendi nesciunt non et sit sint velit.", "Phased optimizing productivity" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Mary", "Emard", "In voluptate placeat modi est mollitia. Earum ullam quod quas iusto. Deserunt quis accusantium autem voluptate sit ut.", "Programmable neutral time-frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gloria", "Hane", "Provident expedita cumque perferendis porro. Earum omnis iusto est perspiciatis laboriosam ratione. Consequatur rem dolores odio saepe autem. Facere distinctio doloremque. Quae adipisci quia deleniti deleniti voluptate quidem.", "Proactive 4th generation flexibility" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kara", "Doyle", "Ipsa sunt quis totam labore commodi nihil magni consequatur est. Voluptas sit non ab quas. Hic eos laborum qui atque velit.", "Visionary dynamic product", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Danielle", "Johnson", "Voluptas ea deserunt sed sunt labore aut neque eos. In illo aut molestiae eum neque. Veniam laudantium architecto aspernatur dolorem vel autem. Cum dolore unde rerum ipsum modi necessitatibus odit.", "Ergonomic static paradigm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Leslie", "Johnson", "Nulla ut facilis dicta vero qui. Et voluptas modi et eaque eius magnam fugit tenetur omnis. Ullam necessitatibus omnis facere. Ratione neque nostrum blanditiis aperiam.", "Open-architected client-server synergy", false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b3cc7544-b397-46ab-9db5-312e7d79512b", "1d15b6c6-a87b-49bc-8fda-c374da77b4b7" },
                    { "d5ccbfbe-422a-4b27-a8da-3f19cb372cbc", "2fe2f128-950b-456b-bed0-22bd2c6ee970" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "01284a83-e74a-4206-aec5-34f385ed20a5", null, "borrower", "BORROWER" },
                    { "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0167720a-14b2-44c8-8f1a-9efa696bf95a", 0, "5aaf5d7d-e704-4727-a62e-3f99ef86775d", "lana_shanahan68@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEG/5gEOulFH+SR17I/6XgzTznNF9h/YKmMLi/MMoSmRYX0cSecXle6eDzj0rAeuTJg==", "209-563-5094", false, "a7bd789f-3281-4373-929c-4982b28361cc", false, "Lana_Shanahan68" },
                    { "13ec32e0-5cc8-46f7-9991-d3b3b99d4774", 0, "cb7f9110-214e-46d0-815a-3b687b3e38b7", "marcus_cremin96@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECQP80H1GVSK/RoEuCgbzPyCrr60Zu45M/dljJijKAlgqFbscUmgZCw/tevh3gDKlA==", "1-850-800-7500 x0606", false, "1c78b863-d9ae-4f48-bbd0-17382b87fa55", false, "Marcus_Cremin96" },
                    { "1515cab7-3e7c-419c-a6b9-22492de78540", 0, "567b7ce7-5054-45df-ad0e-40fc102ead7a", "terry64@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGJhWKUmDci4bjkrv0Vn/ajMONn58g0ZgOSOGXSqxSnZ5V+ffFJAgcNBUv/q5gOPsA==", "1-463-608-8650", false, "78c33d05-11fe-4b3e-81dd-b21aa1185484", false, "Terry64" },
                    { "1d9e5deb-ae38-4a72-b3a5-4b7742f59ce8", 0, "0a0e0151-7c09-4136-bb68-09f3b2f35d53", "bethany56@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEES4SmXLQg3Jsa6Ee3n80cbhVCApMLixkslsKQYdYyBA9eYY/hlWAl7fL+IbBnIBCw==", "(548) 669-3960 x0467", false, "50710a9c-9274-48b5-991f-a8c7ef501bde", false, "Bethany56" },
                    { "1f8f6bb8-e9d1-4209-ac47-a404b33cd4da", 0, "4bfbabf8-fede-4844-b897-6a919a744f0e", "thomas.kuhlman@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEE1+s8jDzjWnnQtrX0H1T7faKNh52Yer4V29N5aSVUhodw3NRZN6fpNwdUNCItMG5Q==", "1-308-253-6968 x5645", false, "486ab83b-a796-4f46-97a7-42e89d538b07", false, "Thomas.Kuhlman" },
                    { "2990a32d-523f-4859-868a-62b3b58511d5", 0, "1123925c-7768-4b46-b5f6-d62a4404887a", "pat_bradtke89@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECLdi4L7G6jNU7z5XImlxGtPe9mBn3JJVoWhXmjr6pwlMMwNilDrBHKZKLce4Yzt6A==", "1-776-445-2316 x877", false, "3ecd7ade-429b-4d8a-a2ee-ab61af893d6a", false, "Pat_Bradtke89" },
                    { "5ece7cf8-955e-4809-9de0-87997742460d", 0, "5ea25569-0458-4c6f-a2ed-5f1408011902", "sophia98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELC5EOAONhrLWnYY9Vtk59Dhy5nPQ7Vv5r43ihJD+nBT3jaIty3+GBRwBSR7fXq92A==", "1-755-400-0218 x384", false, "d9b8b7ab-7b02-4df4-b234-5e16332710bb", false, "Sophia98" },
                    { "7d83e477-fee0-410b-a764-c9dc659862b2", 0, "058a5258-e457-40f7-be4a-63097d068fae", "rudolph3@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGmVf2LtkuzrEOIfhWsvP8fNuxHYyI7CT7AsvqqYUiH/0k93tgrxOHJ5lLvGVSS5Jg==", "714-442-5331", false, "3ed1bd19-9155-43d8-a019-841c55b72098", false, "Rudolph3" },
                    { "84ccedea-e60b-42ef-92a3-a66d5dc72830", 0, "79558f42-568e-44ea-a56e-0f0e168b9738", "ethel57@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKnJ1UVmpOgsiaJ/rWeOO4ptBLtos9tSh2+sa/zex9CAXPejJ7bkuqmCmmsnkRx33Q==", "865-436-6842", false, "a651eef0-f8b6-4f90-9a96-0ce71d0dcbb6", false, "Ethel57" },
                    { "8be73e1d-76d6-479e-856f-03b064d4cf2f", 0, "51b3ec55-ab3c-41fd-a1f1-3a0c0daf578a", "levi0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGWzOEEcfbnRnknCUVuyc26ENpqmp6vviX5UFDTi6Nh8E1arrAyfcqQhDzJCbXryrg==", "334.495.5255 x3235", false, "b088bcc5-9e33-4c00-b8a9-b00a46778c6d", false, "Levi0" },
                    { "971371a7-feb2-400b-94b3-560c80cca99b", 0, "3a23d2cc-fead-4c04-9b50-30d0b86fb63a", "hilda40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP0S5oB7ddaZp5OPjHmwQXLscGWj/HJ5r9PcMsjVFg9HqBI4u5qURjLEINuX7G8Bww==", "293-809-5117 x63702", false, "a0d41df2-66ac-4f32-9e6e-b511b3273953", false, "Hilda40" },
                    { "9a86b6a8-d4bc-4927-b1bc-2e164f578c35", 0, "472890e3-89c6-4557-ab20-7713a9d3e5d2", "craig90@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEO+Uc/FuFz1jyB0GjmW64ghrtMdCVemHIQwtxWW9YqbbCx+sBnGGkfbNfDeiY161aQ==", "876.452.6281", false, "f85d2bd0-77a9-480b-813a-6e62f852287c", false, "Craig90" },
                    { "a4781e30-cde1-42c7-ba82-c25232feb9de", 0, "683cd9fe-10a5-455d-bb56-e1c6bf5ebe03", "richard_ohara@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEB3KJJWC84nuEYjfKNngXCT/WzpIzh+Mv69I7+4nvEoTwgv4+8DC+ZR4SPHUu8hz0Q==", "356.309.0265 x877", false, "59130f84-0bd5-4b19-b5f1-8377f4050e10", false, "Richard_OHara" },
                    { "aaba92a6-b157-4bc0-9bcc-c31dc58d5f2d", 0, "fd826c71-d65e-444d-ae48-a7f567ddb327", "natasha_hand27@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDap+xVBNfB+1MfLOFkCnasmSIspuFSJkNZ5rqyHtXTOR/101QbnNlEPQD7pI5PGSg==", "751.208.9892 x5707", false, "0db2b154-b3d2-473e-9da7-163b6e5afdbd", false, "Natasha_Hand27" },
                    { "af0b5655-46d2-4032-93b0-a9d4fb240981", 0, "7141184e-0d6c-4fa9-933a-f187e81039f1", "josefina58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECf4SyoRnErUocjbWZvY2FuxrL4MHuwPFe/TqPC1nvgnp8PqGgOj8lVykUt0hBYRmg==", "(390) 243-0782 x2418", false, "e80077e0-0c7d-4418-a72b-8db85a1028d4", false, "Josefina58" },
                    { "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c", 0, "aca34c67-6770-487e-bc40-9439642b65eb", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAENw3sve8S29L1AvJCgIUI5PpSHQ0jVERCk6kxeACNJTrKQiqFgLgSzpcMS7R7zHRjQ==", null, false, "c778db34-e2d6-43bc-8dae-4600a59381be", false, "librarian@library.net" },
                    { "cb773360-6700-4d07-b302-69f33524b6d5", 0, "aa8e96c7-a460-42f1-9ec3-5ab74e9689c5", "danielle.parisian92@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENpsSFzNATa1oFu7uskwB/qCaXFOJTXMJeTuw3GL9SKYvpUjS5mtSndughezpjnaoA==", "664.994.6657 x32081", false, "5e5e7d30-740d-49fe-968c-0a4c4bdc4e24", false, "Danielle.Parisian92" },
                    { "cb7c76d8-1748-42bd-adcd-b307247781de", 0, "a5347f63-754d-4c6c-ad96-48f5d0f84157", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEANjKqmCooHQX5OPq7dNEo/2o6l9CbKxz8uNDPojGzgGw3sseZd/T/zWIFxN9LHTLg==", null, false, "ff3ca306-b04a-4e4f-b468-e1f3c2db8d18", false, "borrower@library.net" },
                    { "f474cc19-cf5b-4fa9-b59a-e269a0303ed7", 0, "a63190dd-bc2e-4c2f-b132-04f890dacbd4", "orville7@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI2OuifsahsHjQx5C8G89pphsU2tDZGDWr+8f29fapmYxCBym09hRri06aymCeIpEQ==", "1-947-690-1452 x5056", false, "f619b497-9748-4019-939a-a0a0ae89ab6c", false, "Orville7" },
                    { "fea1b38c-87f2-40c7-9f2a-c94287a2329f", 0, "88314052-7a19-4a82-a5ee-544b967e9779", "sherry.mayert62@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELCf237hSET7rk0xBR08tIoxoFfD6GHif7lGUQSYVJnmC+woM3dJUUFUdI0457sdkQ==", "(853) 742-1043", false, "27bd84b1-6390-4c41-919e-f24d87628d47", false, "Sherry.Mayert62" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jerome", "Koelpin", "Vitae nemo architecto assumenda tenetur porro. Nihil ea non vel. Rem est beatae quos aliquid aut et.", "Versatile directional concept", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kirk", "Haley", "Sint maiores quis pariatur soluta enim placeat sapiente. Temporibus repellat recusandae perspiciatis. Consequuntur labore veritatis perferendis.", "Secured full-range success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Warren", "Bode", "Labore eaque quasi. Maiores quia consequatur ex. Provident ratione soluta molestias voluptatibus saepe non. Delectus impedit assumenda eius voluptatum voluptates porro sapiente itaque rerum. Consequatur cumque aut voluptas cum blanditiis dolore placeat.", "Robust zero defect software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Angel", "Huels", "Aliquid corrupti consequatur molestias quibusdam qui fugit sint quia. Dolorum eos qui provident dolorum molestias. Deleniti delectus quis consequatur ratione rerum tempore voluptas repellat sint. Cumque cumque perferendis.", "Open-source 4th generation pricing structure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dianna", "Heathcote", "Illum sed qui asperiores. Officiis quam et ut excepturi quidem ut impedit qui veniam. Doloribus quo natus sed. Quisquam accusantium iure fugiat eius illo quia.", "Multi-tiered zero tolerance encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sonja", "Watsica", "Repudiandae est possimus. Illo ea libero nihil blanditiis nihil non. Autem eos et enim quis voluptate consectetur aperiam. Ex magni adipisci occaecati quasi ex id.", "Visionary static protocol", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Janie", "Davis", "Quia deleniti dignissimos eum rerum et recusandae deleniti. Vitae autem quae ex tenetur et molestiae asperiores. Ut quasi nemo iusto sed molestiae incidunt veritatis alias cumque. Vel id non sit. Qui voluptates animi ex maiores.", "Team-oriented executive info-mediaries", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ramiro", "Langworth", "Deserunt aut quis perferendis. Et qui occaecati laboriosam magnam. Consequatur eligendi inventore modi veritatis sunt quia. Deleniti tempore iusto eos perferendis dicta sapiente voluptas vitae et. Laboriosam eos eos facilis ut repellendus ipsum facilis iure. Dolores harum aut molestiae.", "Quality-focused homogeneous forecast" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Stuart", "Schulist", "Corrupti est reprehenderit accusantium corporis vero nihil. Sapiente distinctio odio alias molestias. Corrupti architecto non. Commodi esse quis ab et et. Dicta autem repellendus qui aut voluptas sed.", "Focused global frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Raquel", "Stamm", "Eos consequatur porro temporibus recusandae enim alias libero voluptatem sit. Voluptatem alias deleniti fugiat distinctio est. Rerum porro voluptate suscipit. Molestiae ut eum repudiandae corrupti.", "Triple-buffered 24/7 product", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darin", "Stanton", "Consequatur ut aliquid rerum itaque et voluptates neque. Et sint aperiam facilis temporibus sunt. Delectus sit quam.", "Fully-configurable 5th generation knowledge base" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Maurice", "Greenholt", "Magni quis exercitationem nemo. Ex ratione vel. Magni reiciendis nulla adipisci.", "Phased fault-tolerant emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Shelley", "Kessler", "Ducimus dolorum libero rerum sit quis asperiores aliquid quos. Nulla fugit quaerat placeat et in. Voluptates voluptatum veritatis sed blanditiis at. Inventore minima iure. Rerum a veritatis odio. Debitis eius voluptas error.", "Cloned actuating framework", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Warren", "Macejkovic", "Distinctio asperiores eveniet autem numquam numquam repellat mollitia. Qui est qui debitis delectus et. Et minus quia accusamus eum laboriosam nihil vero.", "Synchronised bandwidth-monitored software", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sheryl", "Kunze", "Dolore sequi dolor. A minima magnam sint veritatis in non quo. Possimus culpa et et facilis non voluptatem voluptate est qui. Quia suscipit eum illum molestiae omnis nulla repellat ad.", "Upgradable static intranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Joy", "Conroy", "Et quis possimus aut. Aperiam iste et. Soluta error atque labore doloremque voluptas iusto minus tenetur.", "Enhanced zero administration paradigm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Theodore", "Smith", "Alias unde incidunt quis accusantium. Nostrum doloribus architecto corporis modi nulla neque eos. Aut officiis nam mollitia aut quae minus.", "Configurable full-range protocol", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Elias", "Schimmel", "Quidem quo commodi assumenda odio doloremque non culpa earum quia. Aut aspernatur sed neque sed asperiores accusantium nam ut. Ullam sit ut.", "Configurable executive policy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lucy", "Leffler", "Doloremque nesciunt nihil laudantium. Sit aut totam quidem. Sint accusamus beatae odio delectus debitis.", "De-engineered solution-oriented benchmark" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sonya", "Beatty", "Qui excepturi id eum temporibus nisi neque. Explicabo nisi quaerat ratione. Et quaerat minima nobis quo eveniet qui dolorem sint. Id sunt reiciendis deserunt aperiam qui vero a ipsum autem.", "Seamless human-resource support", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Allen", "Friesen", "Voluptatem nulla aut eum id. Rerum expedita et eligendi labore. Laboriosam ut nihil sed aut ad quasi velit sint commodi. Ut sit hic natus cum odio unde consectetur consequatur. Illum beatae voluptate tenetur quaerat. Sit hic aut qui unde debitis.", "Team-oriented eco-centric instruction set" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Katrina", "Toy", "Asperiores adipisci eligendi omnis debitis. Aliquam non est facere iure sed. Libero exercitationem tempora fuga. Delectus repellat corrupti in. Sed autem voluptatibus voluptatum dolor nisi id ea.", "Adaptive methodical architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Betsy", "Hermiston", "Dicta est odit sed quia doloribus consequatur. Fuga aut et voluptas quaerat sit nobis quia. Et quas in.", "Automated optimal focus group", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Boyd", "Ledner", "Velit necessitatibus velit aut impedit et laudantium. Est voluptates voluptas itaque nihil nesciunt nostrum dicta consequatur. Eum impedit voluptates eaque consequatur. Sequi est tempore qui et sunt corrupti. Quod consequuntur doloremque minus suscipit non vel dicta sint.", "Operative hybrid orchestration", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lyle", "Metz", "Voluptatem velit voluptatem adipisci omnis culpa earum eos. Repellat atque sint qui aperiam aut alias error neque fugit. Dolore odio sit itaque velit.", "Synergized zero tolerance neural-net" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Maureen", "Huel", "Qui suscipit aut excepturi deleniti hic nemo excepturi molestiae. At modi rerum porro est praesentium adipisci itaque mollitia. Nam nihil facere.", "Advanced regional protocol", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jenny", "Skiles", "Nisi eos alias. Ut aliquid quos rerum sunt. Voluptates aperiam aperiam porro repudiandae voluptas qui mollitia temporibus.", "Re-contextualized 5th generation collaboration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carroll", "O'Conner", "Quae ea cum ullam ratione aut maxime in itaque ea. Enim animi asperiores qui sit at adipisci esse. Esse soluta laborum debitis sit ipsam voluptatibus est. Ipsum in expedita aut aut fuga et aut quaerat repellat. Dolor harum ex dolor cum numquam porro sit earum consequatur.", "Managed motivating knowledge base", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darla", "Daniel", "Ipsa sit atque mollitia qui numquam minima architecto et. Exercitationem et mollitia commodi ratione nesciunt. Provident eaque ut ut est earum exercitationem. Voluptate et quis enim quo numquam. Quisquam corporis eos molestiae.", "Multi-layered local approach" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Beulah", "Heathcote", "Perferendis placeat voluptate perspiciatis dolores consequatur tempora velit officiis. Similique ut et deserunt enim laborum eveniet. Recusandae assumenda aut. Et cum quis minima quis.", "Focused bottom-line secured line", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Olga", "Rogahn", "Ex illum cum quia dolorum cum enim. Placeat architecto suscipit est et beatae laboriosam animi facilis. Aliquid cumque a cum et sint molestiae dolorem. Qui debitis perspiciatis perferendis qui ut. Quia ex repudiandae. Et ad provident praesentium atque doloremque delectus non et qui.", "Polarised next generation core", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Leona", "Armstrong", "Excepturi id laudantium et praesentium. Quas et voluptatem quia officia. Ut nam velit. Ipsum quis voluptatem tempore perspiciatis fuga qui. Expedita dolores sed voluptatem et culpa qui et. Aut eos aut eveniet dolore non labore fugiat vero.", "Up-sized zero administration toolset", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tammy", "Morar", "Corrupti sed enim molestias et. Odit aut a amet. Dicta aut unde. Quia odit eaque id nesciunt sequi. Quaerat est nisi aut quo nisi est.", "Pre-emptive global adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Orville", "Parker", "Cupiditate autem sit hic quos ea. Expedita esse exercitationem aliquam. Est quis voluptate tempore et et. Hic amet aut neque ut quod et ab cum cumque. Laudantium veniam sunt. Non esse repellat.", "Cloned multi-tasking emulation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Forrest", "Wunsch", "Consequatur nulla molestias vel architecto voluptatibus. Corporis delectus tempore sint culpa animi. Sunt quisquam aperiam repellendus ea. Asperiores eaque magni enim minima sapiente quibusdam sunt enim. Ducimus alias tenetur et perspiciatis exercitationem consequatur eum aut voluptatem.", "Integrated incremental emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Carlton", "Carter", "Laudantium voluptatibus eligendi. Recusandae rem molestias sequi dolorem quaerat tempora quo. Inventore temporibus aut ea similique a.", "Profound hybrid archive", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Angel", "Stracke", "Vero sit officiis cum sint voluptatem hic quis reprehenderit. Quisquam voluptatem soluta tenetur. Eum non aliquam esse vero inventore harum adipisci deleniti. Suscipit deserunt minima incidunt. Earum facilis eos quia iure quia sequi rerum qui cum.", "Devolved zero administration model" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jean", "Gislason", "Cupiditate enim sequi nihil repellat eos ab. Laboriosam ipsum est et eius omnis optio tempore. In aut velit sit. Delectus ut praesentium aut sequi dolor repudiandae ea nihil. Et omnis dolores fugiat iusto assumenda id et possimus eligendi. Itaque deleniti aut.", "Adaptive zero administration encoding" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Laurence", "Reynolds", "Voluptates quasi nihil praesentium magni aut animi. Veniam praesentium sed et consequatur cum magnam ut aut. Voluptatem exercitationem sunt. Officia quibusdam qui debitis.", "Object-based multimedia installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sonia", "Raynor", "Reiciendis sint earum hic nihil. Voluptate et quisquam autem cupiditate consectetur sunt voluptatum voluptatem repudiandae. Velit blanditiis quaerat quisquam magnam molestiae rerum non. Molestiae est placeat modi earum aperiam quia non ipsa et. Sed consequatur corporis quaerat delectus rem repudiandae. Nostrum ex autem.", "Right-sized even-keeled contingency" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Shane", "Krajcik", "Voluptas dicta sapiente voluptatum recusandae aut consequuntur est aspernatur rem. Non qui incidunt at rerum necessitatibus. Assumenda sint aut quia praesentium fugiat.", "Pre-emptive incremental capability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Renee", "Sauer", "Est asperiores perspiciatis rem reprehenderit esse natus similique sed deleniti. Rerum nostrum blanditiis a quasi recusandae eaque quam et. Sit voluptate qui voluptatibus similique totam officia accusamus beatae.", "Exclusive background algorithm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Noah", "Smith", "Dolorum saepe possimus. Earum sint distinctio id dolore ipsa quod. Natus aliquam corrupti soluta laboriosam. Iure sint omnis praesentium iusto a excepturi ipsa et. Nostrum aut nam provident dolor nisi et. Mollitia qui exercitationem facere sed ratione.", "Synergized methodical attitude", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Renee", "Graham", "Optio aliquam qui eligendi voluptas quis cum. Error harum totam quae non voluptatem. Fugit et voluptatum voluptate expedita. Ut sit pariatur vel.", "Innovative leading edge installation", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "e2bcb5fc-6bf7-48a2-bdc6-8ecdd9601dcf", "c6751fa6-bbd6-43ff-8c19-c8c03de4e98c" },
                    { "01284a83-e74a-4206-aec5-34f385ed20a5", "cb7c76d8-1748-42bd-adcd-b307247781de" }
                });
        }
    }
}
