using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class NoMoreGhosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e2125bf-8d24-4a67-ac50-f6cc0e4f9900");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30993f15-8f91-4846-9560-d5078695aa21");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5bb60d79-ac4f-44c5-9fb6-fde7a76b0740");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "676b2a08-cbb1-49d3-b228-1cab7d907e2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73063a80-ae2c-40fd-aec2-50cf6e6bd432");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d978303b-28bc-4f7b-bda8-c92f4d350725");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dbe27119-b95d-4fec-8566-c1752ec7beea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e39c8685-9c1f-4a75-9e86-898219b7c6b1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e90528a2-275c-4622-8049-1bee9a8cd017");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "2e2125bf-8d24-4a67-ac50-f6cc0e4f9900", 0, "6418428b-d8ae-4327-8ef0-32238045c703", "shelia71@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBL5yVo2ujd+AYRYMgP2G7iiYNmK4PU6j9Y1B5n8+4N8t8dIGLFLuM9+IKxLEGe4Gw==", "380-506-7117 x10421", false, "71cee0b2-851d-480a-ac01-5ae3dff11e26", false, "Shelia71" },
                    { "30993f15-8f91-4846-9560-d5078695aa21", 0, "542558e6-954d-4b93-8e16-3ed531d90c42", "blanca76@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHf+nVGL9xmvYk0srZcfd5wGddeev6F0cms34dXYEAI3PIk/o5dP5sEpDMEdyuXvCA==", "975-693-3701 x88783", false, "b485fcd0-2ff2-4fa8-98d6-5b9f801315db", false, "Blanca76" },
                    { "5bb60d79-ac4f-44c5-9fb6-fde7a76b0740", 0, "72c2e89b-d92d-47a4-9d81-522ace4965a9", "ricky_effertz@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKDNx9lDoufytIRskq7RBwdA6tnuo58UYLBqywSit51kOh9Q7n//a8iHFMSnYSM9rw==", "273.722.9536", false, "ff6680d4-c772-4537-81b5-c61a1c6a70ca", false, "Ricky_Effertz" },
                    { "676b2a08-cbb1-49d3-b228-1cab7d907e2e", 0, "fc13fe06-5689-42e2-af2d-e2ced785b907", "lucas.rogahn17@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECIschFVry4inVPxUxOlFnlCzF83TYC7Ktx3pqHfmrleHoNe60g37wxx3twnEXjiJA==", "201-426-7674", false, "d9bc68ff-748f-4340-a0dc-891adef4a1f3", false, "Lucas.Rogahn17" },
                    { "73063a80-ae2c-40fd-aec2-50cf6e6bd432", 0, "c8e31804-e128-42c7-99d2-47fbf50cc751", "toby96@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAgTaV3bh+pAXLc2lxuYX+RQGJhekpEjbt0/Lz7Boax5g6RMH9hI/iYhmpwDfUsZcg==", "1-963-836-1200 x342", false, "35de3439-fb7f-484a-b649-3a8f41f7ae0f", false, "Toby96" },
                    { "d978303b-28bc-4f7b-bda8-c92f4d350725", 0, "9b492821-4b5c-49c8-92dc-2b2bfc67c774", "paulette.stiedemann99@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPSdtgK3dYOtCilkA6BPae4kUHOfW2CzRyP0TUGlSHTR86CG6LRw6vV+giexSY2FNQ==", "1-522-236-7877", false, "4e39ae4a-a7cc-4987-a029-2f503fa86199", false, "Paulette.Stiedemann99" },
                    { "dbe27119-b95d-4fec-8566-c1752ec7beea", 0, "7a6dea2e-8ff8-4b9e-905a-722f8c985670", "seth_lueilwitz29@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKLW43miKVVE9dHxCHPt9DI4w9rwYllemh854W3GsyoNxKUNZ4BXf8sIrg6qxXatNw==", "1-477-302-0434 x39703", false, "039c4257-f3bf-49b7-bf90-2e94807ed7ef", false, "Seth_Lueilwitz29" },
                    { "e39c8685-9c1f-4a75-9e86-898219b7c6b1", 0, "1a922383-5ad7-4241-8d8a-9636baf2c306", "kristine0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECgcnxI1L47vWy73pZqwE0GY6JEbVaY+FAge/eTaKZuR9rFAE+9zmm9AIDr6Ewv6qQ==", "(365) 309-5607", false, "dd44d3f7-50af-4389-912b-e06a4aeebd78", false, "Kristine0" },
                    { "e90528a2-275c-4622-8049-1bee9a8cd017", 0, "73261beb-609d-42fb-9539-0b52cf1f26f6", "randy_hegmann0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAI1I9Ag29fmDNsdSuvP5jihik8TAo/IwVY2rp64jBsu2NireYnkem3LqRQBFAWpsA==", "827-439-8278", false, "0b29048d-b64e-4ef8-aa16-a4a6532302a1", false, "Randy_Hegmann0" }
                });
        }
    }
}
