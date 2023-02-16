using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class PushingForward : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f0b9ffaa-b532-49eb-8e36-267542542a9c", "019f9093-c805-4496-80c8-2a40346ee7f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c38ec56e-09f7-48e1-9cbc-205aafcc33bc", "61cd5403-658f-42a0-bb30-297210bc1e12" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39717a7f-7185-4e9f-a03c-28cc5a66da3e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "503214e4-8daa-429f-8c37-f3805639aeb7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8992c122-736f-48d7-acda-f2304252a767");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f82267dd-3453-44d8-a9b4-b82cc757fc80");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c38ec56e-09f7-48e1-9cbc-205aafcc33bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f0b9ffaa-b532-49eb-8e36-267542542a9c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "019f9093-c805-4496-80c8-2a40346ee7f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61cd5403-658f-42a0-bb30-297210bc1e12");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2d65d675-8360-4f19-9501-612587bfdc9b", null, "admin", "ADMIN" },
                    { "f2ea5bf7-9634-4a48-9433-1d4c034e12e3", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "043fe08a-d3be-42a0-8f84-c5664a52b093", 0, "1f7bc5a8-3284-4bc8-8118-27c0b684e073", "harvey.ernser@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEL29fyRckrGxOB8rnuTNjfFY7gNWWbXASOXPCYfXcG6lknbbg0EamYAln60+J06TvA==", "265.670.7012", false, "eefa3622-f5bd-433b-84e9-249dd979269c", false, "Harvey.Ernser" },
                    { "1d54692f-2edb-4016-8b14-6863fd32a7a8", 0, "5db0ebeb-6501-4b4c-b604-44c72b8c2237", "melody_corwin34@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAilhSwrsmIdaaAXTI3oLJTz/M0VUjzM6X54p4ZU67V3l8uvLF9E4Xf/6Gdk9G6B8Q==", "357-749-8370 x5028", false, "f88b9bf6-b28a-4818-827d-0db0316a1f78", false, "Melody_Corwin34" },
                    { "23f96791-e6a2-4f44-9430-439092aaf6f1", 0, "9ca37d2f-6f81-49bf-98a5-567dd8d6352e", "elsa91@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMriH8DebR2WllhKvGXIExy+lZZocRKmUl+wmBVQmLjJNZG72FVV4oZEkUG0iwwuXw==", "664.645.9004 x6656", false, "d0288a0d-75f4-434d-8923-34b8c34c5356", false, "Elsa91" },
                    { "25a851e2-d3fc-41f4-9f15-357df4c6ee54", 0, "cf8a56cf-1a85-4e79-9338-65da80738533", "henrietta_dicki32@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFUdd4a2bbHIEGipW6AoYEF11olz8mvGJoPPVj8C84x2mO7lXecpwpBW0eHuCrDGTg==", "1-847-738-0009 x3316", false, "326cf835-b05b-4b95-a020-0a9bf0e93195", false, "Henrietta_Dicki32" },
                    { "25e5f6b3-e2fc-47c6-b9ec-a2bd74a5d167", 0, "51a98254-6f10-4ea3-a951-a8a39ccf3d6e", "wilfred_hoppe@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOmvYUZJaHk/0NIv/Jq0GKp79l4Qa01PIJSWmhAEmOmX8hPuA4QFQR47c1ZOFCKn9w==", "(562) 550-1875 x0900", false, "cd13602c-928a-427e-a63d-192751fc233e", false, "Wilfred_Hoppe" },
                    { "2f61246e-ebcb-47da-8d97-d06f99a333f8", 0, "838c0d49-6a03-45b2-8422-3a6d65339788", "catherine80@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEB+kAAH6bW59vDU5t3KMaKWZWcld2xi1qx6WYpqyvDuynhR643DlDT3GHLGeS+9qJA==", "(690) 224-4210 x304", false, "0fdb9959-de10-4a6e-9bd4-2faaa5613703", false, "Catherine80" },
                    { "40f7fe38-8a55-4027-80f4-1d51baca8bd4", 0, "b73efa91-b547-4fa4-bd43-dd3bb2a2a5e1", "jean80@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEJgd2k+apxMPmvk47xe+Rf8XuxyKS1I6wEGpsB2nTsywSXNs97I38icrvwvSmv8Jw==", "1-984-771-0446 x7149", false, "c6f7cdce-3d38-445a-9dd0-0ec3b4a50ce8", false, "Jean80" },
                    { "427409d7-eb7b-47cf-8adc-98d2b5d2004c", 0, "74a2b7eb-d45f-4455-ae3d-fc322a090513", "hugo83@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFbOtbntPERw5j1BbO3NpjAPucNo6X4AafWGIE4Y2otSAMX+1SWus2MIgQJt0qW3NA==", "251-587-5760", false, "65eecd23-4657-4516-9d66-a4522cb01aea", false, "Hugo83" },
                    { "4f3bd543-0caa-4a5f-8aa8-a4a671b71642", 0, "5f782bdf-92f0-4e9c-928d-644337f127a9", "toby58@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEMWEsk80sNT7sDmZHifEJKOLEZtNT21/c2c90oEIyUX/DN4hJBx87CN44EUXY5fBQ==", "1-447-344-4408 x509", false, "905fb6ad-1082-41f7-8c1f-3a11880a1795", false, "Toby58" },
                    { "518f498d-31e2-4a57-b102-8af1545a9049", 0, "fac6253f-e6b3-4f5a-827a-209e339bea4b", "mandy84@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFldacISoMFsymP+AHIlesDjQJtZct0rKoG3kGqiQv8k+Q9Hxt4RwU4WWYfcA8HwPw==", "1-612-437-0578", false, "f6f3353f-3672-4c32-8395-d8e8245d432b", false, "Mandy84" },
                    { "5c0d0a91-659b-473b-8f2f-5a1aad0cb1fb", 0, "491c8207-b592-4fb6-ab36-b4bccbfd3cec", "stewart_little36@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAA4ai78oR512N4poAof/Z8XNpSDvtQStwhT9yMHA/0i9CQQ84qHOLygX/PHrrGE1Q==", "247.295.3480 x205", false, "d68d6028-148f-4097-b0cd-9dc49257490a", false, "Stewart_Little36" },
                    { "78f9a518-2fd5-493d-86c4-18fd16b74576", 0, "fba72e66-1284-4126-8175-f109c96e9750", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAECRF1ejUXOO5FIsh2sleLokhXlovkQl+T+LqvHr5VgWBjWMUVFV7W5gTNzJ+PWJiJw==", null, false, "a346407c-9bc3-4211-b6d9-3981ba58d848", false, "librarian@library.net" },
                    { "7a9994bd-1e89-4a6d-8fc6-e2290f57a602", 0, "ae67acfb-b87d-4b70-a4df-e15e4933192c", "elaine_armstrong43@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHkqspVzz5nIufNzdWVDGunqmrrKJZOhp1iPUweRgWyBZwZbY2v/MyaASgZZoWwbKg==", "1-649-228-6047 x7344", false, "60da4b51-c905-4a06-b5d5-b77cc3a2b30d", false, "Elaine_Armstrong43" },
                    { "89832927-8c49-4403-913d-26f7e39e1ba3", 0, "f640f1bb-b647-476b-8ffb-6c418516f40c", "dustin.mccullough@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFE0AaDyNwA1u5ok3rufPe4nB6j91XII5X1+tE/PPetGhrfZ8dnB/RKBhjAhNE1EFQ==", "(631) 842-3911 x67035", false, "f4c11736-3da8-44e2-932f-6770d5514af1", false, "Dustin.McCullough" },
                    { "99b8c212-3e64-4776-9557-dda4eb642908", 0, "3c932f18-6aa6-40fc-a7a9-170ce2a795c4", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAECqfGha0GeUlQ2TamJhnVYD6NSsEIhepg2W1RkSnb/QrYyollhvJeNRUEvSypMZtdA==", null, false, "10d5d12e-2ddd-4e3e-a899-0ea689c1e361", false, "borrower@library.net" },
                    { "cf5e7f3f-d074-46e8-b2bc-b321a74369f0", 0, "e12220fc-cebf-49bf-89a2-22ae7b4f6354", "alberta.buckridge@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELNejmHUUpST2gtwVises01/C4b03YPsv5xnab8TpH6E874ZycbCQRb/u0axSCUvgw==", "267-335-8349", false, "29e8bfca-7817-402d-b65d-13a9caeb136f", false, "Alberta.Buckridge" },
                    { "db773bef-5ea2-4fe4-81b7-dbea61ddc7be", 0, "ba9b243a-84f0-4cec-8bb9-a7bece9887c5", "sammy.goldner@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHO9P+cFXa7vV9NzmQ8i7wSo7oXli4kKPLWPY7jgEg/hk+fhdIm3tv4Wvh/eoIkc4Q==", "1-659-775-6079 x745", false, "0ea482b5-fbbd-4c4b-91da-17c7c558e55d", false, "Sammy.Goldner" },
                    { "e767e81b-80b6-4fe9-a869-f5bfc92a80e7", 0, "45cc26c0-94ad-4156-99e5-5e21a669f7f6", "alejandro_borer@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIYH5P0CGnc4zua1udue4E2ftqsepTUZxmBHvaUnWMSjCH1HnLZ+//1knphTXTUglA==", "(290) 520-6653", false, "e39b9da8-a17c-4242-809a-70fafbe22c03", false, "Alejandro_Borer" },
                    { "ed3d254c-6d5f-4393-a433-431950b2ff92", 0, "2bf95171-3988-4372-bb43-99b01a4d11fe", "phyllis.roberts@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEF392zuTm53uKj/4wfhw/Pb37QGXVvIs9sxqi3p0la3pcgLWfVgaezsOh67REl0U3Q==", "(782) 252-9599", false, "a6e8b801-8fdd-4f9c-9834-eb50408c2a30", false, "Phyllis.Roberts" },
                    { "fbffd51f-2e59-422f-97ae-f238517124f4", 0, "0472a9c1-963d-4db5-ba40-1530f47abba7", "phil62@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENKl4oAZU7MGBoxe2ocxD6JMSttjphjNgPXBs6EAiWGQ/CbH55f7TCXZ4679wASGzg==", "371.901.0022 x931", false, "624d2eb2-cc10-4d0b-9ef0-603d951f0e2e", false, "Phil62" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "George", "Kessler", "Odio voluptatem voluptatum ut et. Doloribus nihil voluptas fugit et ducimus. Doloribus blanditiis beatae. Fuga et hic. Dolore sint placeat.", "Reduced 5th generation installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Emanuel", "Gerhold", "Iusto optio dolore aut voluptas architecto consequatur dolorem nulla est. Deleniti voluptatem a vel voluptates fugiat rerum ut voluptatibus. A impedit cumque.", "Focused fresh-thinking frame", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Winston", "Mann", "Reprehenderit dolor illum temporibus dolorem dolores. Et sed autem modi dolore in sed tenetur. Beatae totam hic ut officia. Aut perferendis ut perspiciatis quia dolorem atque corporis dolor.", "Re-engineered incremental task-force" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Terry", "Flatley", "Voluptates doloremque velit magnam amet architecto voluptas. Voluptas et minus qui sed ut culpa nam iste. Nihil reiciendis ut.", "Operative logistical access", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Roosevelt", "Ernser", "Omnis amet enim rerum inventore impedit ad dicta. Impedit distinctio est optio dolor. Esse ea exercitationem sed et laboriosam. Reiciendis qui quidem sunt molestiae nobis deleniti dolorem in. Voluptas dolorem earum similique beatae velit laudantium. Dolorum sapiente unde adipisci sit.", "Grass-roots attitude-oriented application", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lyle", "Stroman", "Autem ut tenetur. Hic dicta ea ea consequatur illum ea. Atque voluptas consequuntur culpa. Cumque rerum amet omnis dolor facere iusto harum voluptas rerum. Inventore recusandae et in qui eveniet. Perferendis doloremque corporis ipsa odit sit voluptatem id.", "Multi-channelled user-facing challenge" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Irene", "Olson", "Asperiores rerum et. Omnis blanditiis nemo rerum dolor inventore. Sunt consequuntur distinctio. Aut deleniti provident suscipit sit fuga.", "Monitored attitude-oriented encoding", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Dominic", "Spinka", "Quia temporibus ipsam explicabo nesciunt quia. Ducimus error quis non qui sed architecto iusto quis distinctio. Doloremque ipsa odit quam dolores laboriosam odit facilis ducimus. Nostrum nihil laborum aut adipisci. Possimus quibusdam est iusto deleniti ea veniam. Perferendis numquam aut qui et soluta qui accusantium.", "Up-sized uniform data-warehouse", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Joan", "Crist", "Quo ut rerum et vitae sint est voluptatem expedita. Aliquid veniam quas delectus delectus. Impedit repudiandae similique eum perferendis sint commodi blanditiis. Aliquam voluptates nihil ea qui. Occaecati voluptate placeat eaque deserunt eum.", "Ergonomic well-modulated projection", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Pamela", "Sawayn", "Expedita quae quod ex dicta eos nobis nihil porro. Qui rerum soluta et autem id ut exercitationem cum. Repellat excepturi dolorem est sit ducimus maiores sit ex. Facilis et molestias reprehenderit non est. Esse officia dolor impedit illo. Quia autem ea facere excepturi id enim.", "Seamless upward-trending structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Philip", "Dare", "Velit voluptate eos maxime. Quod quia est molestiae voluptatem excepturi. Omnis qui est id et laudantium ut.", "Team-oriented secondary info-mediaries", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Leslie", "Schaden", "Perspiciatis illo est enim qui maiores ex reprehenderit vero. Id qui dolores dolorem recusandae voluptatem quia id eos. Laborum ut unde dolor cum perspiciatis. Vel omnis adipisci aut dolore qui. Voluptatem omnis eos non ut animi cum autem enim. Odio nostrum aliquid ea veniam soluta provident.", "Optimized 3rd generation monitoring" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Diane", "Graham", "Accusantium adipisci et harum est. Perspiciatis veniam quo accusamus cum nulla debitis non placeat quis. Quis qui iste modi ratione quas aut quis ea praesentium. Fugiat laboriosam dolorum cumque ut voluptas quos. Dolorem dolor autem exercitationem iste quo incidunt.", "Ergonomic client-driven implementation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jerry", "Smitham", "Totam quidem est minus excepturi voluptas est explicabo nostrum. Sed consequatur non culpa asperiores magnam deleniti saepe voluptatem commodi. Sapiente esse culpa porro voluptas et minima. Ipsa quisquam doloremque totam adipisci reiciendis eaque libero. Sapiente recusandae perferendis deleniti rerum dolores voluptatem sed veritatis.", "Integrated attitude-oriented hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sidney", "Cartwright", "Ea laborum et qui sit est sapiente aut sit porro. Molestiae a minima sequi unde. Id voluptates ut eum officia repellat eum nihil. Illo ipsam occaecati dolore perferendis a non blanditiis ut. Perspiciatis repellat cumque perferendis est.", "Programmable context-sensitive installation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lowell", "Wehner", "Excepturi et minus omnis. Enim architecto rerum dolore voluptas ullam repellat. Sed asperiores accusantium doloremque saepe illo nemo et maxime. Dolor odio molestias aut rerum rerum consequuntur provident nihil quidem.", "Reactive transitional adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Andrea", "McCullough", "Minus suscipit est ipsa alias. Architecto sint quos tenetur velit dolorem quia. Nobis placeat in et debitis id rem nisi. Rerum nulla eaque minima autem quia esse doloremque et fugiat.", "Triple-buffered bi-directional core", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Heather", "Yost", "Aliquam ut iste rerum minima excepturi voluptas sint. Inventore nostrum nostrum. Placeat consequuntur adipisci minus sapiente. Ut aut non sit tempore dignissimos nulla quia ullam minima.", "User-centric attitude-oriented knowledge user", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Roosevelt", "Wolf", "Nihil qui dolorum quia suscipit est quia. Dolorum hic enim deleniti. Quae et dolores delectus tenetur. Atque ut nulla ducimus delectus. Maiores quasi non molestias tempora est.", "Cross-group high-level intranet", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Colin", "Kuphal", "Nemo veritatis quibusdam sint alias suscipit delectus non adipisci qui. Delectus eum corporis ipsam dolorem non esse ut aliquam temporibus. Quia quos minus. Autem aliquam aut eligendi illo aperiam labore.", "Streamlined value-added encoding", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lee", "Towne", "In ullam in repudiandae pariatur beatae exercitationem porro nulla. Et aliquam distinctio ex necessitatibus deserunt quae nemo. Sunt ut sequi ipsa et asperiores magnam voluptatem dolores omnis. Occaecati voluptas porro vel culpa quia.", "Profound clear-thinking capability", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Reginald", "Donnelly", "Voluptas ut ad. Eum dolorem ad rerum voluptas aliquam est vel quis quidem. Sit eos sint et unde enim quas aut.", "Switchable systemic strategy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Betty", "Schiller", "Labore consequatur non. Animi qui omnis et fugit reprehenderit consectetur. Eligendi excepturi et pariatur in qui repudiandae. Ex ratione aliquam vero culpa fugiat porro. Molestiae explicabo molestiae esse odio qui ut qui est.", "Inverse bi-directional orchestration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Billy", "Emmerich", "Id distinctio ex natus dicta. Aut modi alias dolorem voluptatem aut exercitationem quisquam. Sed dignissimos est natus porro harum.", "Digitized explicit encryption" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Abraham", "Hodkiewicz", "Veniam enim voluptatem sint ut. Assumenda qui inventore officiis distinctio expedita. Dolorem nam aspernatur ducimus provident laborum. Et maiores velit quaerat ex. Enim minima et est.", "Fundamental client-driven hub" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Christie", "Mraz", "Et neque ipsum. Voluptate alias occaecati voluptas nobis minus repudiandae similique. Accusamus odit qui vel. Eius explicabo debitis facilis totam aperiam.", "Multi-tiered object-oriented application", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Hilda", "Cruickshank", "Ut culpa vero vel. Sunt nesciunt ex et sed in consequatur dolore. Molestias aperiam doloribus ut soluta. Dolor repudiandae velit culpa maiores ut rerum voluptas quasi ea. Magni nulla sint reiciendis enim et.", "Persistent motivating adapter", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Johnnie", "Cassin", "Fuga assumenda sapiente corporis sit corporis. Pariatur nulla nobis. Quibusdam molestias magnam provident quis. Quod rerum dolores.", "Ameliorated zero defect toolset", true });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 29, "Amber", "Larson", "Laudantium impedit accusantium sunt. Illum sit ut error ratione tempora a maiores quod officia. Quo qui beatae dolores tempora optio reprehenderit unde temporibus autem.", "Reverse-engineered even-keeled pricing structure", true },
                    { 30, "Jim", "Ernser", "Quasi atque enim veritatis quis quia molestiae. Qui quia incidunt maiores tenetur et aut quisquam. Aut voluptas consequatur vel exercitationem facere eum quae rem nulla.", "Cloned exuding conglomeration", true },
                    { 31, "Roderick", "Sipes", "Voluptas assumenda earum qui quae. A hic quo nisi consequuntur at enim magni ut. Quia sit laudantium accusantium et sunt ratione quisquam sed optio. Quas exercitationem tenetur delectus odit. Sit aut fugiat culpa nihil sit maxime rerum minima sit. Doloremque nostrum similique ipsum consequatur natus amet sit.", "Self-enabling content-based workforce", false },
                    { 32, "Donnie", "Kuhic", "Alias et tempore expedita ex unde. Laboriosam consequatur quasi eos in quia quae. Dolor sapiente ut dolore. Iusto est praesentium.", "Reduced zero tolerance local area network", true },
                    { 33, "Darnell", "Rice", "Molestias sed dolorem magnam exercitationem excepturi quae. Et officiis est voluptatibus iure velit et qui. Ipsum quis non ipsa ut et vel minus culpa voluptas.", "Decentralized context-sensitive Graphical User Interface", false },
                    { 34, "Lela", "Dicki", "Voluptatem voluptas dolores dolor quis et eos dolor. Sed mollitia possimus voluptates voluptate aut labore maxime. Dolorem ullam fuga dolorem.", "Centralized 4th generation solution", true },
                    { 35, "Cecelia", "Bartoletti", "Odit sapiente aut qui consequuntur. Esse illo porro. Voluptate iure animi reprehenderit. Est a eum reiciendis modi in architecto nisi. Totam aut in dolorum omnis suscipit qui. Pariatur eos corporis minima quae omnis dolore non.", "Multi-tiered heuristic support", true }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2d65d675-8360-4f19-9501-612587bfdc9b", "78f9a518-2fd5-493d-86c4-18fd16b74576" },
                    { "f2ea5bf7-9634-4a48-9433-1d4c034e12e3", "99b8c212-3e64-4776-9557-dda4eb642908" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2d65d675-8360-4f19-9501-612587bfdc9b", "78f9a518-2fd5-493d-86c4-18fd16b74576" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f2ea5bf7-9634-4a48-9433-1d4c034e12e3", "99b8c212-3e64-4776-9557-dda4eb642908" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "043fe08a-d3be-42a0-8f84-c5664a52b093");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d54692f-2edb-4016-8b14-6863fd32a7a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23f96791-e6a2-4f44-9430-439092aaf6f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25a851e2-d3fc-41f4-9f15-357df4c6ee54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "25e5f6b3-e2fc-47c6-b9ec-a2bd74a5d167");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2f61246e-ebcb-47da-8d97-d06f99a333f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40f7fe38-8a55-4027-80f4-1d51baca8bd4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "427409d7-eb7b-47cf-8adc-98d2b5d2004c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f3bd543-0caa-4a5f-8aa8-a4a671b71642");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "518f498d-31e2-4a57-b102-8af1545a9049");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c0d0a91-659b-473b-8f2f-5a1aad0cb1fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a9994bd-1e89-4a6d-8fc6-e2290f57a602");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "89832927-8c49-4403-913d-26f7e39e1ba3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf5e7f3f-d074-46e8-b2bc-b321a74369f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db773bef-5ea2-4fe4-81b7-dbea61ddc7be");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e767e81b-80b6-4fe9-a869-f5bfc92a80e7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3d254c-6d5f-4393-a433-431950b2ff92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fbffd51f-2e59-422f-97ae-f238517124f4");

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
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2d65d675-8360-4f19-9501-612587bfdc9b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f2ea5bf7-9634-4a48-9433-1d4c034e12e3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78f9a518-2fd5-493d-86c4-18fd16b74576");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "99b8c212-3e64-4776-9557-dda4eb642908");

            migrationBuilder.CreateTable(
                name: "LibraryAccount",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    roleId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    userId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryAccount", x => x.id);
                    table.ForeignKey(
                        name: "FK_LibraryAccount_AspNetRoles_roleId",
                        column: x => x.roleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_LibraryAccount_AspNetUsers_userId",
                        column: x => x.userId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c38ec56e-09f7-48e1-9cbc-205aafcc33bc", null, "borrower", "BORROWER" },
                    { "f0b9ffaa-b532-49eb-8e36-267542542a9c", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "019f9093-c805-4496-80c8-2a40346ee7f0", 0, "a4a218a5-e7d5-41d4-94ad-d0a24b454873", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEAhpFS/Pv1GRd9y7uxhf7GNwTpOm+AtHgMdALKiYcbO91Tf4OYkC8HNWp9nGiLwanw==", null, false, "81c35152-b23f-4be7-96d0-b3c4bd2a7bab", false, "librarian@library.net" },
                    { "39717a7f-7185-4e9f-a03c-28cc5a66da3e", 0, "91f9a8a1-ccdf-4478-b11f-8986d49d5258", "mathew12@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAED8K1j1tDqVYzUsiojmGijat96xRJZIe+6E5j6ITHa9TMEg/7LjCIv5iiI6BM0eszQ==", "626-865-6466 x63664", false, "44f348c9-cc41-462d-a6d6-f10b582d38de", false, "Mathew12" },
                    { "503214e4-8daa-429f-8c37-f3805639aeb7", 0, "c5c20397-81e6-46a9-800c-0e66d61214ed", "patrick.breitenberg53@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIY9k9sg0Y1WEpfPi6Wp1j/Hodnbc2wVgfOt7MwTXmsSXeL8q4cMMsFoJVnWmuOdwQ==", "(694) 593-8258 x16725", false, "8057915f-2836-4105-b2e9-d26b9fa0bebd", false, "Patrick.Breitenberg53" },
                    { "61cd5403-658f-42a0-bb30-297210bc1e12", 0, "2f08202f-eb7b-4244-aaee-b05f2cdd1459", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEPySGexLQYtwWWowZiUnve9UqkG874z767eT7tbRX3QOYdIwbRaob6TdyGyJxygpmg==", null, false, "9878aa2e-068f-49cf-a5c9-8c02d79f09a3", false, "borrower@library.net" },
                    { "8992c122-736f-48d7-acda-f2304252a767", 0, "a220dc20-5201-4c21-a735-e4c5c590a30a", "dale72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKclPieEpD0n87lsx7J58wV+z6orCPqfNuDU/IOudSI7pSNwyEciI5ik9YZ+84uzhg==", "588.337.8715 x83853", false, "cdc84548-69c7-4099-9eac-387ad4bc6123", false, "Dale72" },
                    { "f82267dd-3453-44d8-a9b4-b82cc757fc80", 0, "f1d95d26-d762-48da-8ed0-de490b5b7f0a", "jon_littel67@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGQdRGT7VML3g1ZGl5a8qozxDusI2k+OxQXV636nej2kI0DmqkWDzjWFLlJgBy030Q==", "847-640-8328 x0980", false, "b283d358-c65e-4daa-a3e3-93584281c18d", false, "Jon_Littel67" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rachel", "Gutmann", "Laboriosam et atque labore qui aliquam rem. Suscipit optio incidunt sunt. Magnam rerum in illum vel eveniet nisi. Nulla aut deleniti non accusantium omnis perspiciatis iusto enim consequatur. Sapiente vel odit molestiae numquam.", "Extended tangible workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Stephanie", "Lubowitz", "Harum laudantium voluptas nobis eum odit sunt. Minus necessitatibus nesciunt corrupti odit rerum. Corrupti cum et quam doloremque aliquam in vitae minus dolore. Illo nesciunt dolor est quae in nam aliquam. Adipisci eos et voluptate corporis aspernatur quod suscipit.", "Object-based local implementation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nicolas", "Kris", "Quis enim alias ut officiis amet aut vero quos omnis. Autem distinctio temporibus. Velit eveniet natus praesentium aut corrupti ut a odio blanditiis. Optio cumque rerum reiciendis tenetur atque nam sed. Harum sint iure eligendi reprehenderit est. Animi laudantium doloremque cum quasi illum deserunt et fugiat.", "Innovative needs-based pricing structure" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sylvester", "Conn", "Maiores delectus nam fuga aut aperiam. Repellat quia rerum debitis aut doloribus a fugit voluptatum. Minus voluptatem quia ut. Sed rem in perspiciatis. Saepe optio hic saepe aut pariatur velit ut.", "Polarised multi-state middleware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Randal", "Bartell", "Asperiores dolores nemo. Facere est minus aut qui fugiat sit aut. Saepe provident qui. Enim at quod optio perspiciatis ut nesciunt totam libero. Eos omnis amet eaque veritatis necessitatibus. Perferendis quos laboriosam et velit accusantium sit.", "Customizable heuristic emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Mabel", "Carter", "Fugit aliquid non ex laboriosam ut dignissimos earum natus. Sint ea praesentium quia laborum et natus qui. Est repellendus modi dolores dolorem laboriosam qui non.", "De-engineered attitude-oriented process improvement" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Terry", "Abshire", "Et neque tempore dolorum error velit reiciendis. Sint magni vel. Temporibus fugiat sed occaecati et iusto aut rerum sed non.", "Re-contextualized dedicated flexibility", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Paul", "Lang", "Dolores qui molestiae nostrum sint ipsum odio reiciendis delectus illum. Nobis qui doloremque neque labore sed repellat et pariatur eaque. Magnam est dolor doloribus eos. Quo qui est veniam necessitatibus accusamus quam. Accusamus voluptas beatae eveniet optio omnis quis suscipit. Qui quia corporis quasi nihil enim explicabo.", "Polarised leading edge infrastructure", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gayle", "Schowalter", "Et rerum provident pariatur minima a non ad nesciunt. Enim laudantium omnis fugit. Aut incidunt assumenda quisquam inventore totam ratione quo.", "Automated clear-thinking framework", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Wm", "Feil", "Aut quae voluptatem in exercitationem ut eum et quisquam. Et nemo laborum laboriosam aliquid. Et sint quod laboriosam dolorem. Vero et laboriosam tempore minus quasi voluptates. Nostrum rerum dignissimos voluptate quo quas iure. Et temporibus velit exercitationem sunt animi.", "Monitored object-oriented protocol" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lynn", "Pfannerstill", "Cum officia eos. Exercitationem itaque eveniet incidunt explicabo. Sit amet illo dolorem.", "Organic solution-oriented standardization", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Angelo", "Reichel", "Quos ad nesciunt quia aut incidunt asperiores. Porro numquam ea excepturi officia soluta. Exercitationem et fuga hic aut temporibus. Harum consectetur fugiat nobis totam. Dignissimos quos temporibus nihil.", "Reactive encompassing implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Emilio", "Roob", "Officiis aperiam nihil nemo atque dolore quo corporis et. Ea in eum dolor dolorem. Ex ut rerum quo et rem ducimus illum et.", "Multi-lateral intermediate groupware", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jared", "Murazik", "Recusandae corrupti beatae et doloribus aliquam pariatur. Iure mollitia est molestiae cupiditate. Non aut aut sed.", "Switchable needs-based groupware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tony", "Dare", "Aut nesciunt sit vero pariatur beatae modi. Qui deserunt reprehenderit et et enim aut qui quia. Officia qui qui aspernatur asperiores.", "Cross-group global encoding", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Ann", "Armstrong", "Velit ut laborum iusto quae rerum eligendi id. Sequi pariatur consectetur unde. Optio beatae veritatis adipisci aut voluptatem pariatur totam soluta. Quod sapiente saepe consequatur beatae rem sit maxime repellendus.", "Cloned holistic solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rex", "Mueller", "Atque id sit qui doloribus. Asperiores accusantium ut vel non eos. Officiis voluptas voluptate dolores delectus. Vitae id accusantium sit in distinctio fuga sed dolorem. Dolorem fugiat tempora dolore est.", "Assimilated static secured line", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Desiree", "Abernathy", "Maiores fuga porro et facilis earum ut beatae voluptas quae. Nulla dignissimos aut eum consectetur tempore alias temporibus et. In dolor atque dolorum id.", "Upgradable zero tolerance migration", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Edward", "Lakin", "Explicabo aut nam doloremque atque quaerat ipsa sunt non ut. Mollitia quia iusto sed. Exercitationem incidunt mollitia assumenda minima molestiae commodi voluptatem voluptatum nesciunt.", "Enhanced upward-trending website", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Guadalupe", "Dickinson", "Eum nihil quibusdam natus modi dolorem quisquam eveniet. Asperiores rerum dolor ratione dignissimos expedita consequatur numquam alias. Aliquam culpa sit aut ut quidem et et.", "Cross-group logistical extranet", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lorena", "Hills", "Aut harum odit provident quia ullam molestiae nemo. Non quo sit sint. Et dolor at doloremque non vel qui. Molestiae fugiat minus. Nostrum quis aliquam atque et explicabo qui qui.", "Organized directional interface", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jonathon", "Jacobi", "Nisi laudantium ducimus dicta temporibus delectus itaque aut ut nisi. Sunt eos molestiae et rem at ipsam et. Velit dolor est eveniet rem recusandae repellat et.", "Team-oriented executive solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Holly", "Wyman", "Fugiat quam hic nisi nihil laborum et. Omnis omnis dignissimos quibusdam vel quae. Ut aliquam corporis unde exercitationem. In voluptatem fugiat.", "Total high-level secured line" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Terri", "Roberts", "Animi natus et velit ut harum. Vel rerum nihil cupiditate minima. Deleniti accusantium delectus esse aut voluptatum velit dicta voluptatum dolores. Aspernatur saepe cumque excepturi animi nemo rerum. Non maiores veniam dignissimos sed soluta tempora quo. Aut ducimus maiores molestias qui.", "Multi-lateral solution-oriented conglomeration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dora", "VonRueden", "Est exercitationem suscipit accusamus alias fugit molestias rerum modi. Possimus dolorem nihil facere maxime. Voluptatem dolorem ex et voluptas possimus quam rerum libero nulla. Eaque illum quasi facilis optio nihil.", "User-friendly maximized internet solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Claude", "Keebler", "Sunt at ipsam quo sed nisi facilis et voluptatem. Ut voluptatem vitae et sed aut est et aliquam dignissimos. Corporis illo et sapiente enim nihil architecto iure autem.", "Advanced coherent knowledge user", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Enrique", "Nikolaus", "Id minus id non et eos in labore et tempora. Rerum enim aut aut provident ipsum explicabo consectetur. Sed esse dolor. Porro tenetur ratione aut consequatur. Aperiam aperiam veniam delectus omnis rerum quae vero natus deserunt. Error beatae autem est eum ea.", "Innovative impactful knowledge user", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Bessie", "Jones", "Nemo et est itaque voluptatem quia voluptas beatae error. Adipisci quis quo dicta quo ea architecto est harum commodi. Perspiciatis dolores ut voluptatem velit deleniti nesciunt magni. Numquam dolorem quisquam quo ea odit eos sit. Inventore minima tenetur ea itaque harum. Esse sapiente dolor.", "Virtual reciprocal hardware", false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "f0b9ffaa-b532-49eb-8e36-267542542a9c", "019f9093-c805-4496-80c8-2a40346ee7f0" },
                    { "c38ec56e-09f7-48e1-9cbc-205aafcc33bc", "61cd5403-658f-42a0-bb30-297210bc1e12" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAccount_roleId",
                table: "LibraryAccount",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_LibraryAccount_userId",
                table: "LibraryAccount",
                column: "userId");
        }
    }
}
