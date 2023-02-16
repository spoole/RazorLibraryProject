using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class NoMoreGhostsPlease : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01120c5d-6dc8-44f7-9150-3f30398e9591");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "068a9fef-920e-4b3b-8038-7e1943fb8bae");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14c47224-c354-4847-9c86-80aed3f33d17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "47a15d8c-ea92-4b72-8d97-26fa5dd25698");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a6d3ebf-17d9-463d-a4e6-17dedc32839f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "53abb2dc-aab1-4b4b-9c76-466e3b81655e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64f41664-a770-4e8c-be00-d7d03fae60f1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78703e8e-5784-4915-a6a8-8526834695c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8287c8a6-a077-4d8b-b6b8-65de31686c10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "964dd6d4-b1c2-473c-876c-380589dde4cb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a621b254-f6d8-40d5-bfd1-64fc5533e1a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cca482fc-9d3c-4c8f-9590-32b1fd118908");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ccfd5ba7-48d3-4991-9c58-c5fbdfb9bf79");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed59f69e-7556-496c-9553-d5a10163a105");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "114f9549-9103-41d4-91f4-52abe60d2ae8", 0, "c48bc8ff-d3e4-42a0-a9da-3ab6d641959f", "lauren.cruickshank@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJpi2tWpPwGTqhZYAUMPmhfHiSYTbOFvWYGQybJVBus3A0T44BzE/h/LBp5O6Vbd0g==", "434.989.3486 x158", false, "390459a5-1642-4e22-9ef9-6a825640292e", false, "Lauren.Cruickshank" },
                    { "17b06963-6c27-4773-8da1-7432efde4427", 0, "959d584d-fd84-4ef1-80cd-3c820e9ea927", "wesley.mann89@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJukhMKlPC+/eTR45XWywWyNBY0npaJ1HGAhfVteVqvFs0qSW/7gauh2ryrSPm/cPQ==", "1-247-835-0480 x1035", false, "3e9d8c92-22d4-4684-9ecb-bae113a9ec65", false, "Wesley.Mann89" },
                    { "24cc33c0-6820-4d09-8c7b-9761df7ba486", 0, "9867fdd7-a24b-4851-ac6e-52763bd99ac7", "becky_vonrueden@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJbXFcIhgRYH204QxWbKmPR6RxFfBUDuemxqOnR4TxNF+DMLHErEUZZz4sdhhjvIog==", "390.544.6998 x6318", false, "27e19836-4828-4d4d-bcd2-1bbe09ba35f7", false, "Becky_VonRueden" },
                    { "2ac2140a-de53-4ac5-bd54-e95f69cafd50", 0, "11a4722d-6a0b-4385-bec4-92def4416bb8", "blanche_nolan5@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGmri9NLfuXmFBQyZNkgPhDE2j6Zut/1nv9Z7eLhpD28+nSW5gQKtOGQm4sCD4oRHg==", "823-289-7878 x880", false, "52a68718-755a-4c4e-80f1-55cfcda4b4b1", false, "Blanche_Nolan5" },
                    { "484028fe-a5b6-4819-9b3a-02c595fde962", 0, "94a71e28-7f5f-4254-9f37-d102f08ba049", "vincent55@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGMSRKNkSzMUYfJu+nRV+Ef9/0iegCntRAsL/0+E6z8eb0aMutfFV9mMHUZGwsvsrQ==", "(755) 439-2329 x52642", false, "030740ba-786f-47ed-a4ef-d7a6703a23c1", false, "Vincent55" },
                    { "4f1e3218-de03-49e6-8b67-13c33f61050f", 0, "867b734c-9317-4178-9a34-9a122ff2b6dd", "alan40@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECJ/zTGsTc8O4ebJO860i6Vg7PfImCjWDaXZflELCr+iHiu25yeEO1w/PJUBxxr2hg==", "1-975-322-6972 x7598", false, "8ea12f46-918f-445a-afd2-ac4712baa768", false, "Alan40" },
                    { "4fb25888-ba86-4f10-bf6d-3c1d2b2984d3", 0, "655160e1-892a-49e7-88a2-158db5add6db", "ben.moore79@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOsCWrLla8nV1vab51wrqoojQTPwddxWxWSApd8jh1oGPvsGZdq6W1v9aS1KuClk3A==", "440.371.4783", false, "e6003113-38ce-4d5b-85be-09e50476de1a", false, "Ben.Moore79" },
                    { "534492f1-4122-4b1c-9777-db7117eedb18", 0, "0cdbd1de-81a2-4ee2-b692-b67471cba7a4", "mark.lemke38@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJ7xSRvuNwYZiFfWmmqZd4YZFEujPbTOTXJh3bUIwd1hmDABBbBMYARC8gKbQ/WGtA==", "638.816.6911 x62725", false, "5453d154-e6b4-4365-97ad-a0a5860bef22", false, "Mark.Lemke38" },
                    { "605068e9-943a-4a08-9134-212d18f17cb5", 0, "873f1d6d-389d-448c-811b-222937f15204", "rosie_ullrich85@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELqtoLX2SHqNv662pPYNbo8z+4uqsh2G+kroKM/uyF0uT+/Fzyo1bamXzV7kKIFTDg==", "(407) 385-9605 x001", false, "edd69487-e936-4aa8-aab1-c781d6ba2f72", false, "Rosie_Ullrich85" },
                    { "7b958d71-e1a3-4484-bfd9-1545f723585b", 0, "bffb06a9-30b3-43b2-a602-8aac9c1e317f", "wendell_wintheiser63@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBukSpdZuVnEx1RNUQDbeaHl1icDy8IvLRuC5L9vLEedz7vDLxFO7oO33Z6zxB7QIA==", "540-803-2208 x46238", false, "a28f1801-dfca-4c60-97c8-53c828eae86e", false, "Wendell_Wintheiser63" },
                    { "7fa86faf-7eef-4bd4-b393-34bb37cc7a69", 0, "c3f8305d-6aea-4560-a4ca-c4bf7d7ac797", "cecil_considine95@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEB7lNfs0heDl/r4J9gkEWLgT7OWPSQzikHONEGUP+uerX3Am09ngn3O10TrToma8uw==", "1-870-328-1863", false, "ee36cbf8-6449-466d-bddb-5d244cc004a1", false, "Cecil_Considine95" },
                    { "8315f3d2-5953-4402-aa93-57038429b1f6", 0, "69ed0e3d-4b1a-447f-b9fc-4c4878b92e33", "hilda_casper69@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEF8dyPVTVWJIFXJ88t3cboriGww6NsoCmmv8Q8Ww8Ib9B56tnoqIZ5YQLUlLPcFTMA==", "434-232-0195 x119", false, "a1deec16-c317-468f-b148-efdef7069710", false, "Hilda_Casper69" },
                    { "9061f5d0-bc44-4dc7-a665-34f54f113539", 0, "97a45bc9-c042-44de-87bc-21bc55b1627b", "andres.moore62@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGwpVNZS8LyfDsyKLLIOoC8dbkzKuS9ZuXnXoVNWt5+Ji296ZPcdq7DkB59LnjYhKQ==", "1-752-836-6199 x8050", false, "0646a600-3f6b-4675-802b-cf0333b7a461", false, "Andres.Moore62" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "114f9549-9103-41d4-91f4-52abe60d2ae8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17b06963-6c27-4773-8da1-7432efde4427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "24cc33c0-6820-4d09-8c7b-9761df7ba486");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ac2140a-de53-4ac5-bd54-e95f69cafd50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "484028fe-a5b6-4819-9b3a-02c595fde962");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f1e3218-de03-49e6-8b67-13c33f61050f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fb25888-ba86-4f10-bf6d-3c1d2b2984d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "534492f1-4122-4b1c-9777-db7117eedb18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "605068e9-943a-4a08-9134-212d18f17cb5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b958d71-e1a3-4484-bfd9-1545f723585b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fa86faf-7eef-4bd4-b393-34bb37cc7a69");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8315f3d2-5953-4402-aa93-57038429b1f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9061f5d0-bc44-4dc7-a665-34f54f113539");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01120c5d-6dc8-44f7-9150-3f30398e9591", 0, "b55cd304-4ca1-4778-87db-93fc3bc6a21e", "kathy.hayes20@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMEFlt2R9rE/LduI9LrQb16yDLjZ+/ztPYXqVyFPw/VsGWqrgumUxehiLEFQzmNpuw==", "287-397-8061", false, "5810e9df-e77a-4956-83d4-270fbc3e673e", false, "Kathy.Hayes20" },
                    { "068a9fef-920e-4b3b-8038-7e1943fb8bae", 0, "6cac40a9-1a79-4d77-8013-c1df4b3a68d3", "leon11@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMElH55dqxhDgCQwQ2XdLeJu+aqZQdXOwv9iW6kekapJHsIoPedUKSHAtf3l3liamg==", "1-248-765-8356", false, "bdaed841-f6c0-4ca6-8e06-8bc3c7478942", false, "Leon11" },
                    { "14c47224-c354-4847-9c86-80aed3f33d17", 0, "8536274b-2701-4987-9575-9b74cce28f9e", "drew.rau61@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAavoyt3PAtEyRc3+W5CwcfX0geLJd5IOU6b0vDPri+Q+xWIvDLY9KDnBdVCC2ql7w==", "608.288.4642", false, "e080d61a-2899-40f4-a0f1-022f8b310bfa", false, "Drew.Rau61" },
                    { "47a15d8c-ea92-4b72-8d97-26fa5dd25698", 0, "a78191fe-b0b4-4fb2-bf13-6656c031a647", "ray35@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIOPekf3gqZ6unCRBqdqqzdYdIopfIDbVPLhvnK0n93wLvlw/HjCJV8HbPvCxm4acg==", "937-423-6707 x43735", false, "3b850a1b-789d-4311-a125-07d0ec94fd4e", false, "Ray35" },
                    { "4a6d3ebf-17d9-463d-a4e6-17dedc32839f", 0, "7627450f-0080-4ef7-b586-f468ddfa6416", "gerardo.nienow72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHB8HA1gHdHlVhQCQ3sRUWIiwB+3X0n/i1yLDeWX4hQMraqxcq7L2EZEYaaP2Noduw==", "1-965-729-6416", false, "f5a8a97c-c7ae-429d-8ae5-7308059c1715", false, "Gerardo.Nienow72" },
                    { "53abb2dc-aab1-4b4b-9c76-466e3b81655e", 0, "8b8084e0-088e-42fe-9a40-47dc56e3c36d", "gustavo_abernathy@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJuyJhJsu8k+ttXrRBU3szvknBf7OxWHv0tmej2u3cM3yxS+GPfjd7CqFVxK9hxcJA==", "234-978-0072 x24267", false, "37a40676-cab5-44de-a447-a0d2ad9b5ed7", false, "Gustavo_Abernathy" },
                    { "64f41664-a770-4e8c-be00-d7d03fae60f1", 0, "9aad4ad1-e5d6-4558-a25d-04555a8a228e", "marcos_ledner@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEIX4WzW34j8lixw6L5pLzD2OIVC/uDq8IvgDnq+xkmD9+POowLxOgtKkShL11tqNaA==", "1-508-932-9281", false, "0b31db5d-a388-4feb-9fe1-e59c2006748b", false, "Marcos_Ledner" },
                    { "78703e8e-5784-4915-a6a8-8526834695c3", 0, "e2622888-ba19-4bbd-a44f-d830c90b749a", "abraham81@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHs7h4rmFZEuMsegP6/W1tB+g0mZAHJXkvLuGMClyPioC5/gaVpGJGi+Gl1WwiAGkw==", "1-542-987-0359", false, "fd41a3ed-8cb0-42d2-aae6-fef10fcefd4e", false, "Abraham81" },
                    { "8287c8a6-a077-4d8b-b6b8-65de31686c10", 0, "a2d97b1e-44c9-439f-bce6-12590e177dfe", "doug33@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKFvSw5miuw4Qjvb1fUemY5y0arPLmDSalezKJB8mvKZzxJ1PCeAU4Px8YyloZwpNw==", "821.263.3279 x3938", false, "1b0de1c3-944c-4336-aefd-413b70ea67ec", false, "Doug33" },
                    { "964dd6d4-b1c2-473c-876c-380589dde4cb", 0, "fc3fe877-2f14-4393-9c5b-3f23260c9a5c", "anna_labadie@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPPxp/GJjUATVo9SZi5P+yeeOGcZfC/2s79o/cLAZNUroydf43l1a6ZtJYnIV1t5ng==", "(362) 277-5934 x273", false, "c6324482-b208-404a-834e-6388b2248d53", false, "Anna_Labadie" },
                    { "a621b254-f6d8-40d5-bfd1-64fc5533e1a0", 0, "85e2aaef-74d1-48c1-8755-35283fbcc5e2", "bobby_block15@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEB8ATMp1py2n38Dht6FKMJTDbRKlxMMGEVzzv+nt07jQac70bz2R2QacF0Gm3IR2pA==", "352-688-1560", false, "b497268b-432d-40d3-a3f5-b6654c91460b", false, "Bobby_Block15" },
                    { "cca482fc-9d3c-4c8f-9590-32b1fd118908", 0, "d2906f4c-2d12-4168-afb8-90e2ce79c09e", "dianna_mohr@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM3hTFx48cVmjj0QLXMarhADbKLo11qjTy31TFM89QLfZB1CP6jq8UmkNVoc4fZU3w==", "(784) 216-3634", false, "d8a47083-74f0-4202-88ac-a21ae3a043f5", false, "Dianna_Mohr" },
                    { "ccfd5ba7-48d3-4991-9c58-c5fbdfb9bf79", 0, "e5fae074-da03-4fd9-8054-1a6d869a68e2", "evan_klocko38@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELnXobWnT+gOTrjBEhbyGWPwm4Fn3xFNBGj56vktSQ6BMXV5Q3GfqbYye/d3gCatMA==", "1-371-256-4490", false, "bc05fa62-d5e4-40b6-96ec-70b1e8b06e7e", false, "Evan_Klocko38" },
                    { "ed59f69e-7556-496c-9553-d5a10163a105", 0, "a8b9523b-c154-42a8-9abe-1e6ffc000842", "eric.vonrueden15@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECtHga14yo6Eax/wBnDBlY/mV9idNHv2XCgu3I97SoRlPxHj4V+D41dyHMfKTTBUyw==", "1-714-971-1123", false, "08529e6f-003f-4c16-997d-5938b88cef06", false, "Eric.VonRueden15" }
                });
        }
    }
}
