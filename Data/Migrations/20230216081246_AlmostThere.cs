using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AlmostThere : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "54862dfe-b5e0-4edc-a69e-1bf90aed4e53", "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed", "d58d8487-434c-4825-a37a-18fa7c4a88be" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "121e1b8b-597a-4260-a8df-c94ef9912a12");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ab0a9e8-3815-48dc-ac75-ef7efb75af69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5317be92-87c7-4187-b393-8ee92178501c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bb27782-41a3-4ab8-8341-49cd045adcd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6bd020ac-1964-49bd-b4aa-702bda5fbfa9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6df0e70b-054c-4654-a055-bf53760f6ed7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78ab77ea-6313-475f-a21d-137a30046576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "924dda9c-8b34-4aaf-9525-a3a2791e0958");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "98dce13e-139b-4a43-a9b2-7a130341a9d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7187e98-3c7a-48f1-8174-d1f77fa090a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2c2e2ee-876b-4d10-925e-d9d215a9da17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d65ca571-4855-40c8-86be-ff3cb016ebed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7d45c48-2e75-4d94-9b47-95b52324358c");

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "54862dfe-b5e0-4edc-a69e-1bf90aed4e53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d58d8487-434c-4825-a37a-18fa7c4a88be");

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rogelio", "Gusikowski", "Magnam eligendi molestiae officiis sit voluptas officia tempore atque. Consectetur inventore corrupti dolor. Dicta architecto maiores hic temporibus sed voluptate nulla aliquid enim. Quaerat voluptatem maxime.", "Right-sized attitude-oriented throughput", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Olga", "Larkin", "Ut quae perspiciatis. Dolores ea nam adipisci voluptates odio fugit dolor aperiam. Et et sed blanditiis nesciunt debitis dolores et possimus. Doloribus est nihil vel mollitia rerum est. Et et quas earum quia quam omnis voluptatibus.", "Innovative real-time alliance" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Peggy", "Crooks", "Omnis id accusamus quia. Aut ut assumenda iusto neque esse non ut eveniet. Nihil qui suscipit corporis iste cumque voluptas incidunt sit. Quas modi recusandae consequatur sunt modi et aliquid. Eaque odio aut itaque minima nisi accusamus.", "Fundamental directional secured line", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Darla", "Fritsch", "Enim voluptas quidem explicabo asperiores dolorem. Qui et assumenda. Et quia voluptatum eum ut et quod. Ipsum neque aperiam eligendi consequatur nostrum non laborum et qui.", "Synchronised transitional open system" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Georgia", "Zulauf", "Excepturi est omnis non nostrum accusamus ea delectus. Excepturi fugiat consectetur. Provident et quisquam quo ratione quod vero ut ut ut.", "Open-source stable encoding", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Todd", "O'Hara", "Asperiores repudiandae repellendus laborum. Adipisci omnis ducimus blanditiis reprehenderit rerum quae et aperiam. Id at aliquid veritatis consequuntur iusto eum. Sunt numquam et aspernatur corrupti quasi consequatur inventore optio. Autem voluptatem hic asperiores ea corrupti minus. Ratione quam sequi voluptatem tempore ipsam cumque.", "Exclusive methodical circuit" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jermaine", "Smith", "Totam cupiditate animi tempora inventore explicabo aut veritatis. Et inventore aut rerum qui nihil eos. Iure quaerat ut sit et. Est et similique.", "Progressive 3rd generation array", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marcella", "Maggio", "Impedit officia ut voluptatem voluptatibus. Cupiditate voluptate placeat facilis officia perferendis dolores et. Fugiat sequi voluptatibus voluptatum dolores incidunt ea. Quia excepturi molestias facere.", "Customizable needs-based infrastructure", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rosa", "Hickle", "Cupiditate alias ex exercitationem aut consequatur rerum molestias. Dignissimos maiores et dolore nemo et occaecati. Minus tempore ab fugit molestiae recusandae pariatur. Aut earum velit ut reiciendis qui quam deserunt et. Sit cupiditate reprehenderit esse.", "Ameliorated impactful matrix", false });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Brandy", "Prosacco", "Dolorum voluptatem beatae blanditiis illo voluptas rerum. Rem porro aperiam. Fugiat animi error excepturi quia.", "Realigned uniform parallelism" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "William", "Goldner", "Neque doloremque alias quo nulla. Pariatur sint commodi. Ut assumenda qui qui rerum est. Non ab est soluta non illo.", "Operative bandwidth-monitored groupware" });

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
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Clyde", "Dickinson", "Ut officiis aut aut corrupti nemo consequatur et dignissimos qui. Tenetur corrupti qui quo non autem maxime omnis possimus commodi. Sunt consequatur et quis ut veritatis laudantium voluptas excepturi voluptas.", "Organic upward-trending instruction set" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Janice", "Larson", "Minima est molestias magni minus. Doloribus nisi in. Et doloribus veritatis ipsum quo enim vel accusantium. Quia quo itaque voluptatibus exercitationem quos est officiis tempora sed. Magni tempore consequatur occaecati est soluta cum reiciendis.", "Implemented neutral open architecture", true });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "0047e381-def1-4427-9f33-21cdb93bbe7b", "1a7d3d77-7fa2-4dee-898d-c4e559fbe618" },
                    { "73c60c7b-db49-40af-bc4f-5e949f00bb8d", "23efed20-97c1-48ef-9322-e760f121ed83" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "54862dfe-b5e0-4edc-a69e-1bf90aed4e53", null, "admin", "ADMIN" },
                    { "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "121e1b8b-597a-4260-a8df-c94ef9912a12", 0, "243af548-b400-4b91-9e47-776006c33e22", "julie.vandervort21@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAt7KwKMeYd7gmgCm9Igh/aWKTvCZsVFP/YnPyMLDxDwLmbEiFrzVrEYrcukfJmNQQ==", "593.561.7518", false, "e578e423-9bf4-4a6a-8a4e-6de8cf07f87b", false, "Julie.Vandervort21" },
                    { "2ab0a9e8-3815-48dc-ac75-ef7efb75af69", 0, "f766164e-9018-4688-9da5-7cbe24aab453", "alejandro93@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEA+V+xhmTvpKDYLZPgG1cIG5vgwr3+LtHa5D7ShqOI1ZqEZuEgGEeK16Z/I9sW5hTA==", "308.696.6086", false, "930545b1-4908-4fd0-8715-eb3910b4e9f7", false, "Alejandro93" },
                    { "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d", 0, "f81b2802-b72b-4906-8ccb-2593f3fc995d", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEEZc0W5N+tVelgw2MHR/uJtgkwt2EEXazsYRISwe3ZIwJaMXLM61NzTRbViyyrT67A==", null, false, "2cabb625-c26a-4ab8-997e-3dd93ec4efff", false, "librarian@library.net" },
                    { "5317be92-87c7-4187-b393-8ee92178501c", 0, "7fdd1065-390c-444d-a30e-87ef7aa6f355", "clara.orn50@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHDY/TCLKjanN5HaXeEZ+T3JwCUvRz9/xft0RK9UcQ/PBXu6b3zS/Wo9NehmHFs3+w==", "(966) 785-3738 x292", false, "15c1f977-ee5a-489d-a4d9-eb3ef2ff2072", false, "Clara.Orn50" },
                    { "5bb27782-41a3-4ab8-8341-49cd045adcd8", 0, "b5ceffd5-cf73-4309-9f00-7c5a12d2b01b", "ruben.denesik29@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJP4Pg3Z0ihnfzKthUyZ8DFra4/cIBvtT3Y9d8LaqCKVu9tObaTD2LUFB9p/4XBMMA==", "1-942-377-6347 x7582", false, "8937cb28-e27b-4842-b2da-e7935276afee", false, "Ruben.Denesik29" },
                    { "6bd020ac-1964-49bd-b4aa-702bda5fbfa9", 0, "d8b4b5a4-cfa3-4606-83bd-324e4e331bb3", "irvin_murazik39@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIUjvl74gYFRqs9aeKkYB8WY/O6urvxkv5GIIsGETxppXGgF8olS7hmsq4Ps8nU/sw==", "(822) 575-3884", false, "fd35cb9c-d3cb-4a4f-9502-6705e1b9eb18", false, "Irvin_Murazik39" },
                    { "6df0e70b-054c-4654-a055-bf53760f6ed7", 0, "7a023de9-313a-4c26-897b-b42f643fa86b", "charlie.williamson14@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJRduwLXdIHJEO/HTkXYAEDj/5zQWcpDB8W4+S5z3bIF/hroqB4b5NkH3POxr3T22A==", "(736) 589-8192 x63940", false, "8f94d03f-c190-41bd-9f36-5bbdd1a94b8f", false, "Charlie.Williamson14" },
                    { "78ab77ea-6313-475f-a21d-137a30046576", 0, "c676ad95-073e-4e3e-ad66-3cfbe6fd2df0", "robin.pagac71@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEECKUu5qphIOrj/8zBADk+WfbKFcN2SCC9VV3oM90u7gl0sD+h520CbgkVThD/M2rQ==", "714.722.8821 x6092", false, "09dda151-cacd-444c-8236-0aaa4dea15ac", false, "Robin.Pagac71" },
                    { "924dda9c-8b34-4aaf-9525-a3a2791e0958", 0, "14fda472-83f1-4823-b023-dd60f7730646", "ernestine20@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFws2vJdydBcrK4SX2qaiO7FYD7WfmUuTRvwnKW1+ugJQPjocGYTt3BPq9Ra1fkg8A==", "510.902.0030", false, "78d18773-2822-4c60-8453-959d0f2f0a26", false, "Ernestine20" },
                    { "98dce13e-139b-4a43-a9b2-7a130341a9d4", 0, "02e07774-9691-4e07-aa3c-c07d22992462", "stanley_osinski@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJOwuWaOD/u1h36/ecM6MPlqo7W+g+GHtrwva94eAwwZFxsuc47mw0xdxQyYSrZx2g==", "879.796.0877 x436", false, "7e2d5b8b-ec23-47b0-adc8-0f3f6122f084", false, "Stanley_Osinski" },
                    { "c7187e98-3c7a-48f1-8174-d1f77fa090a6", 0, "474def5a-317d-4572-880a-546c97e04c4f", "salvatore.oconner40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ4xGQF4h0m3jr2mujmU3q1Zy6qHoycrLohVyGNTX82LVNODiQdCvtsZ+it6j9Pudg==", "370-487-8411", false, "f9d1d242-1e80-4db1-bee1-dd5891cee564", false, "Salvatore.OConner40" },
                    { "d2c2e2ee-876b-4d10-925e-d9d215a9da17", 0, "8140a178-a088-47fe-ab8e-5436b4b302b1", "rex_walter60@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPvi41aUQZFpccGpwRbEwv85KmR8cnaV0oREexkOxtmU0OtJW6UK63t2JtYgeg2dpA==", "1-556-681-2429", false, "aa264f6d-be90-414a-9164-4876675c492d", false, "Rex_Walter60" },
                    { "d58d8487-434c-4825-a37a-18fa7c4a88be", 0, "80aecb03-67c4-470f-a405-2370727fe28c", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEPCXHr4w6WboWcAfew+uagBNDH4QYDQa315sbV9nSROR+FVFnSiZdr1QRt6CIYOeMQ==", null, false, "44745bbf-5389-43ba-b6ab-956359ea8cd5", false, "borrower@library.net" },
                    { "d65ca571-4855-40c8-86be-ff3cb016ebed", 0, "201bae92-fbe8-4814-b2a4-d9b971666609", "kristie94@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDcY7WahqrleESopAsSkqxRfssGRZ7B4a7O20YUJzkG61c5CZ6PWLFhhIbNy5YpzYg==", "1-256-820-8728 x73218", false, "aeffe199-65f3-45d1-b508-ca1688437d45", false, "Kristie94" },
                    { "e7d45c48-2e75-4d94-9b47-95b52324358c", 0, "2b594cc1-7b75-4529-ba6c-8998f0d149ed", "wilbert34@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECIHSeU1+rWylph6Pp7rknHIsGEQH+yblxOhYRem3gdEC0e2y6lFhlQv8sTsppQ+cw==", "1-772-587-5402", false, "b37d410e-aa55-4a60-ad4f-0c9916da08de", false, "Wilbert34" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Viola", "Boyle", "Quas qui rem ipsa quae id. Unde ut porro. Commodi eum deleniti et modi dolor commodi aliquid. Recusandae eveniet et incidunt debitis enim enim in. Qui quo modi expedita laboriosam veniam quis aut sapiente suscipit. Tempore aut rerum eveniet dolorem et neque.", "Future-proofed zero administration time-frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kay", "Hodkiewicz", "Sit in harum eum id. Vero qui culpa itaque. Accusantium beatae eum labore corporis cumque alias. Voluptatibus rerum itaque est non.", "Centralized cohesive frame" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Patty", "Von", "Error possimus ab iure inventore blanditiis numquam totam sed. Id rerum itaque quis tempore et magnam cum iste. Facere nihil et corrupti ratione. Ut et veritatis aut voluptatibus. Ipsum voluptate impedit soluta.", "Virtual neutral extranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jodi", "Walsh", "Dignissimos non sapiente vitae autem maiores sint debitis. Atque quia deserunt numquam qui. Ut necessitatibus eaque quo pariatur rem mollitia.", "Fully-configurable coherent forecast", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "William", "Reichel", "Consequatur molestiae nostrum commodi est voluptatem possimus nulla nihil laborum. Repellendus sed reiciendis delectus. Dignissimos quae officiis autem vitae aut vitae quae. Est et autem vel ipsum eos quis incidunt.", "Horizontal homogeneous capacity", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Hattie", "Cormier", "Voluptas aliquid reprehenderit. Possimus reiciendis similique quis alias. Quibusdam molestiae quia adipisci tempora delectus adipisci. Nesciunt non est voluptatem sint. Pariatur et ut rerum dolore aut perferendis vel quia non.", "Re-contextualized holistic ability", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tyler", "Krajcik", "Minus et ut sunt molestiae iure est aspernatur provident. Eos aut magnam magnam non omnis. Delectus doloribus aperiam cum. Odit est et omnis ut consequuntur architecto sed necessitatibus. Consequatur ut accusamus.", "Pre-emptive mobile website" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jessica", "Fritsch", "Eum quia sed officia deleniti iste iusto asperiores eum. Quo omnis corporis amet quos aliquid ut architecto fugiat. Fugit asperiores dolorem ut. Deserunt dolor enim.", "Expanded 5th generation workforce", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Chris", "Emmerich", "Pariatur harum voluptatibus ducimus sint consequatur ullam in. Corporis repellendus qui dolor animi quia iste rem aperiam nemo. Quo tempora numquam laudantium nobis explicabo provident sint molestias. Distinctio facilis id dolor qui non beatae libero non.", "Synchronised 5th generation local area network" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Barbara", "Kreiger", "Ullam delectus libero et ut ducimus soluta. Modi similique omnis nesciunt odio accusantium maxime. Sequi accusamus accusantium. Neque accusantium ut non eum magni magni soluta minus non. Quam esse eius blanditiis beatae voluptatem eaque quis.", "Total local architecture", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rolando", "Doyle", "Necessitatibus ut cum eius. Est eos autem ut est. Consectetur hic praesentium occaecati atque eum. Sit dignissimos sapiente maxime sunt sit commodi dolorum voluptas omnis.", "Triple-buffered attitude-oriented process improvement" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kathryn", "Gislason", "Provident voluptas rerum. Labore aut ipsam et fugiat magni sit. Consequatur repudiandae necessitatibus minus omnis. Placeat sit nulla et illum fugiat nisi sint voluptas. Placeat blanditiis est cumque nihil quo deleniti porro.", "Universal reciprocal intranet", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Hope", "Oberbrunner", "Aut pariatur iure. Enim amet quidem assumenda et non consequatur omnis quod. Et voluptas sunt voluptates quae pariatur quod ut. At eos harum. Voluptatem temporibus facilis qui minima est voluptates quos velit similique. Odio nulla recusandae.", "Synchronised non-volatile info-mediaries" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Larry", "Kshlerin", "Enim animi quia tenetur asperiores ut quasi quam cumque molestiae. Id error et assumenda ea quia distinctio omnis. Laborum debitis voluptas beatae molestiae ratione eum accusamus.", "Secured user-facing toolset", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Phillip", "O'Connell", "Alias at repellendus autem. Inventore sit accusamus rerum consequuntur sunt velit. Distinctio eum a ut autem ducimus nihil fuga et quam. Corrupti itaque ut cum a ut est voluptas. Recusandae repellendus adipisci fugiat a animi earum. Et ut ea et minus alias eaque velit.", "Multi-channelled bi-directional migration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Joan", "Hackett", "Quisquam magnam rerum voluptatem voluptatem quasi molestias ut fugiat. Mollitia sit qui et ut repellat sapiente aut quae. Adipisci sit iure autem quia.", "Devolved stable toolset", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Sidney", "Hartmann", "Ut earum quidem aspernatur id. Sed ea ipsam dolores est dolores sit ut magni voluptatum. Aliquid minus earum deserunt magnam aut ullam consectetur. Odit similique enim occaecati exercitationem nemo assumenda autem accusantium aut. Consequatur dicta aut cupiditate sit. Iure veritatis reiciendis nostrum quisquam.", "Mandatory leading edge internet solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terrell", "Gerhold", "Aut ex earum vel possimus debitis molestiae. Eum impedit in pariatur. Dolore odio omnis impedit est asperiores rerum incidunt velit quod. Atque rerum magni maiores eius similique voluptas quidem. Reiciendis ipsa ut.", "Focused dedicated open system" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Myron", "Homenick", "Omnis ut eius ullam voluptatem et impedit recusandae cupiditate. Nulla in et qui aut aut vel. Eveniet incidunt ad iusto iste earum.", "Optimized dedicated application", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ivan", "Smitham", "Veniam voluptas et aut ipsa nihil quia autem consectetur impedit. Accusamus accusamus eum cumque. Blanditiis consequatur aliquam aut quo. Sit nobis ut voluptas rerum occaecati tempore earum.", "Object-based cohesive help-desk" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Bryan", "Thiel", "Omnis atque est quaerat aut. Incidunt earum provident in. Sapiente et dolor ab. Pariatur in illo iure. Architecto eaque aliquam quia nisi aut et eligendi vel. Ut ut provident.", "Up-sized scalable analyzer", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Wilbur", "Skiles", "Voluptate ea ullam ullam quia sed. Necessitatibus corporis illo laudantium vero. Et quam voluptates qui accusamus eligendi et nobis. Fuga corrupti veritatis delectus itaque est quaerat voluptates in est. Ut et quis.", "Automated maximized success", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Doyle", "Schroeder", "Quas ut voluptas nihil amet aut nesciunt recusandae voluptates sapiente. Incidunt laboriosam est eaque placeat aut quia. Nisi ut amet dicta ipsa. Magni incidunt est veniam. Et velit aspernatur sunt nulla consequatur et et.", "Extended mission-critical concept", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Philip", "Tremblay", "Et officiis omnis ut veritatis quam unde. Voluptate temporibus in deserunt. Totam ratione eveniet enim rerum sit consectetur eveniet. Magnam commodi odit voluptatem et amet laboriosam dolor inventore. Placeat est vel est labore ab dicta illo excepturi. Aut nulla ut debitis fuga reiciendis exercitationem sunt qui.", "Programmable neutral architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Morris", "Toy", "Ea dolorum beatae error et soluta. Doloremque sit laboriosam saepe aspernatur dolorem et. Repellendus eligendi vel et voluptas est enim corrupti. Voluptatem sint unde est nulla omnis autem vel labore possimus. Esse soluta iusto aut. Alias ut provident quia quas.", "Team-oriented system-worthy extranet", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jordan", "Williamson", "Laborum ab ea assumenda corrupti minima illo ratione. Tempora sit doloribus nobis quos quo vitae rem. Aperiam aliquid enim maxime sunt sit voluptas veniam.", "Down-sized systematic strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kristopher", "Bruen", "Hic sed sint labore architecto numquam excepturi ut voluptatem fugiat. Blanditiis deleniti dolorem optio qui. Eum quia sint debitis nihil sint nesciunt nesciunt quia pariatur. Facere doloribus dolor dicta. Delectus possimus ex. Adipisci voluptatem ut dolorem et voluptatum repudiandae blanditiis.", "Virtual demand-driven installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Woodrow", "Graham", "Similique quas velit. At rerum omnis. Molestiae repudiandae amet qui. Blanditiis quaerat neque in nostrum quia beatae cumque.", "Networked systematic paradigm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gustavo", "West", "Doloribus rerum cumque omnis a veritatis eos nisi facilis inventore. Ut quos neque animi nostrum officia. Qui sapiente praesentium eveniet dignissimos ut consequatur atque dolor. A quas tenetur est sed. Ea aut rem tenetur. Perspiciatis id quos explicabo odio omnis.", "User-friendly mission-critical pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Howard", "Franecki", "Repudiandae illo inventore quis vero totam possimus. Est veniam et quo et molestiae. Iure iusto veniam adipisci reprehenderit quis enim.", "Diverse encompassing architecture", false });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 31, "Daniel", "Swift", "Eos neque id non doloribus et molestiae non dolore voluptas. Odio et id ut ipsum nihil natus. Maiores ut laboriosam qui quia hic nobis dolorem. Non animi et delectus similique doloribus magnam. Rem accusantium totam qui a et id est quasi. Dolorem eum quod recusandae molestiae in magnam quia.", "Fully-configurable systemic productivity", true },
                    { 32, "Eddie", "Nitzsche", "Totam ullam odit et consequatur in aut. Omnis nihil ipsam quos id qui dolorum laborum. Maiores quia necessitatibus facilis expedita autem quia sit ut dicta. Illum incidunt dignissimos perferendis necessitatibus velit dolorem veritatis nam enim. Repudiandae velit nemo quos quaerat et sit quod. Aut vitae voluptates consectetur quidem ut quibusdam earum facere minima.", "Fundamental explicit portal", true },
                    { 33, "Salvatore", "Hintz", "Est aut velit perspiciatis. Autem dolor sed voluptatem doloribus. Ullam qui culpa quae ducimus odio mollitia quidem. Dolore magnam doloribus et sapiente libero enim. Voluptatum sit porro molestiae omnis aut quaerat ad molestiae quae. Ea incidunt sed aut cupiditate aliquam cupiditate eveniet.", "Upgradable client-server workforce", false },
                    { 34, "Gregg", "Armstrong", "Dolorum iste sit cum natus et. Dolorum at enim dignissimos ut consequatur odio dolorem mollitia. Voluptate ea eius fuga pariatur consequatur. Quo molestiae at quis aut.", "Customizable national core", false },
                    { 35, "Sherry", "Bernier", "Dolore veniam voluptatem laboriosam. At dolores optio. Harum quaerat maxime. Sapiente occaecati qui esse voluptas officiis et non omnis dolor.", "Right-sized 5th generation intranet", false },
                    { 36, "Salvatore", "Williamson", "Esse dignissimos et mollitia pariatur iusto voluptas nobis rerum. Et occaecati dolorem dolorem et quis. Molestiae architecto autem reprehenderit rerum hic deserunt dicta iusto corrupti. Facilis sed officia placeat voluptas. Unde id id dolor.", "Reactive composite frame", true },
                    { 37, "Robin", "Rowe", "Suscipit magni aliquam omnis quod perferendis minus at. Harum neque quo qui incidunt optio ducimus. Excepturi blanditiis aliquam a error assumenda. Id et rem aut.", "Sharable bandwidth-monitored open architecture", true },
                    { 38, "Jody", "Hills", "Debitis consectetur ut ratione rem nulla excepturi sunt harum. Quia et voluptatem ipsum officia. Qui fugit inventore.", "Reactive incremental firmware", true },
                    { 39, "Eric", "McGlynn", "Sit voluptas non. Quia fugit porro quisquam. Facere rerum inventore voluptatem iste sequi ea. Praesentium accusamus nemo non laborum qui perspiciatis vel. Et iure inventore pariatur sit dolores soluta adipisci.", "Implemented bifurcated forecast", true },
                    { 40, "Francisco", "Koss", "Maiores error quos suscipit est. Rerum consequatur a labore veniam accusantium similique veniam mollitia excepturi. Aut esse rerum blanditiis est non.", "Object-based human-resource extranet", true }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "54862dfe-b5e0-4edc-a69e-1bf90aed4e53", "4ce6b370-e611-43cc-a6a1-26b68b4b6b4d" },
                    { "9d753dac-8c3b-41f1-b6c3-ee5f8b4be3ed", "d58d8487-434c-4825-a37a-18fa7c4a88be" }
                });
        }
    }
}
