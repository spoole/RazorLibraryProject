using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class StillTryingToBanishAGhost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0ad53729-1314-46d3-8f4f-2fa499525c91");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1da45ebd-49ab-48c9-b268-787dd2497da2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ff78f33-a346-4713-9891-25c2b20a9176");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "358009c4-8400-4173-9de5-9633cfd6c572");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "58dcc74c-6e31-422a-a07b-aa3bed7f479d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73f66cba-1235-4c7e-b6c2-c2fefc313c02");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7528a3d9-f7c7-407d-bd92-0113ddf0eaf2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7dee2f60-9809-47ca-ab37-d86286eb8f87");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "904bb7b5-f858-4843-bd13-356cc7759cac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8203c88-3cd7-4234-be61-f2f74c4083bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba094d66-cb8a-4abd-9236-a8df21d5e794");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc7a0ded-9f75-4962-b6c6-2ab9d1025fd2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3db598e-ce24-400f-93ba-11201eb12dbb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3298230-9ef8-40da-abbe-693baceb37d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2f361cc-080a-47b0-a558-8d7712200c72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f876f6fa-e106-417a-a3ba-326c9d4c9352");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0ad53729-1314-46d3-8f4f-2fa499525c91", 0, "d3400202-35b8-4345-8fdb-7ae4c7acf953", "dewey.gleason14@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOwRJVIuQl+TOvJ1oVcL3trBZ4PdJvKc6cv5PEbB7aQqoSD6gXY0Q+Gy/ZUa+gkqog==", "778-371-2138", false, "49d888c4-8312-44c6-a472-013b9340c5cb", false, "Dewey.Gleason14" },
                    { "1da45ebd-49ab-48c9-b268-787dd2497da2", 0, "6515130d-40dc-4de9-9010-73db48ef42c7", "flora_bins27@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOMJpPd/gx8psGM+RE/Hyx4PhWwcSH1P1RUmfZ3GaKHs8RA9eWmU8jrKFGcORKn60A==", "647.665.0465", false, "b71508f5-6c6c-4481-ae6c-a940fd3f2c9d", false, "Flora_Bins27" },
                    { "2ff78f33-a346-4713-9891-25c2b20a9176", 0, "f8b7f011-6816-428b-90f7-c16ab8515cb0", "paula_runte@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKiFYSJIAYP3KA5a/bgH/+SiRllI7IB3O+P4hkQfO0BeJjZWVoCeve/3xsuC+XddAw==", "792.956.5367 x242", false, "43b8f783-a702-4971-8a38-f81e705589ca", false, "Paula_Runte" },
                    { "358009c4-8400-4173-9de5-9633cfd6c572", 0, "dbd8ef57-0a57-4497-a844-022025bb50e5", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEGoEtuGnGTkRN6gi7RvNSBMh1MLDxyUqXZhX4PxfnheWCiu9TS30vQqyI/JMUNRHcQ==", null, false, "c2e4ec34-7362-4d32-868f-409ec2af8b78", false, "borrower@library.net" },
                    { "58dcc74c-6e31-422a-a07b-aa3bed7f479d", 0, "b6746b18-c177-437a-a799-e229c5092197", "omar22@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKrwx6iHIrpGlYJWFyfolTH8S0iLVIP9w5hVZkNOLzEt4e7ccpQA4s+fr20hdbaRtQ==", "593-443-9525 x78602", false, "66b08b06-f6f2-4bdf-b916-e69e8d3d940f", false, "Omar22" },
                    { "73f66cba-1235-4c7e-b6c2-c2fefc313c02", 0, "9eefd121-81af-49eb-a037-d04ea8c80fe8", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEEPGCuglh19MtGYZ4TBThehRlL/Q7pdSLuRINJrNddStrY3Z1r8S8qIKB+MsBHa/+A==", null, false, "407cccfb-9703-4c2a-9af4-2718ca7669b0", false, "librarian@library.net" },
                    { "7528a3d9-f7c7-407d-bd92-0113ddf0eaf2", 0, "fe486823-44d7-4ee4-bc42-7259cc379d90", "randy_hand@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHcSgjmSDt7fz9Qi4ZzsS6F1XOrxqU2/d5aGaLnzeV2AWcnWtKbxJ6RdbAQhOVnZOQ==", "1-835-926-0521 x17363", false, "6b690fff-7f49-42e5-b170-67aa6e5b1353", false, "Randy_Hand" },
                    { "7dee2f60-9809-47ca-ab37-d86286eb8f87", 0, "420ea4e0-1a9e-4125-a7d2-ed82bdf18e45", "jean24@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDSwUVgRKTR4uZrlEg7YcEF5JIY75s/3V3pRQPjVu+2whq3seFHzcY5ecn+BDHGMUA==", "872.846.5181 x753", false, "6a333e57-fe4e-437f-86c9-594b0691312a", false, "Jean24" },
                    { "904bb7b5-f858-4843-bd13-356cc7759cac", 0, "4134d6b4-dbbc-474c-b850-1f8da24eeea7", "mamie.ward26@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEDJlWEqURGdfNdTVj7I/u2RgyGNkClW6ZOj4J7oC7TPZ7tKoc0vBFpyZnkXtNAQZQ==", "275-663-5290", false, "ca1f4dca-094f-4ce0-9a25-4bd5a4416115", false, "Mamie.Ward26" },
                    { "a8203c88-3cd7-4234-be61-f2f74c4083bb", 0, "73eee3d3-c8fd-4d26-a3f8-88571ceec6eb", "tina.torp@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEmrAHju11boZ5Kp5l0vSL+LRwKBIXXlkS44Yera2Pr+Yf1UcdK7vdd+SE/1iH8+0A==", "708-923-6449", false, "ae0da6fc-2ef5-4c49-98e5-ad8b3e707cbb", false, "Tina.Torp" },
                    { "ba094d66-cb8a-4abd-9236-a8df21d5e794", 0, "af7f286a-ea65-4db0-8b36-da8c9be2ac23", "jody_quitzon8@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELBGVF8oWfjvuyVfmyXim4S6xxSgJRXE0fyqiqxkbMk2uoflNLwmpA6EcIt4ch/3PQ==", "994.315.4592", false, "79f8cbe6-1672-43c9-bd92-934f7103c262", false, "Jody_Quitzon8" },
                    { "bc7a0ded-9f75-4962-b6c6-2ab9d1025fd2", 0, "b9931e34-0aec-401f-9079-3c7ab481fa13", "virgil.keebler@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKFqIWL4XMJoERnx2VIDe4/6jtRVycvjVjacLNo+0qjJXeGe9gkIPLg+TyGrk5MFUw==", "1-888-552-8394", false, "dc1fb45e-fc40-4034-a5b7-e9d52cd389ef", false, "Virgil.Keebler" },
                    { "d3db598e-ce24-400f-93ba-11201eb12dbb", 0, "d8c391c3-b121-4637-9319-2f1d424ecc6d", "wilson_hegmann@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDfINMW87lnjTeMomhUecHS8bFJt6ZoYgCdUxREuTYufH9CB5WXo2mOz28EKPjWntQ==", "(492) 785-7142 x9850", false, "5d847c9d-9064-40e6-ab8b-cc24525343de", false, "Wilson_Hegmann" },
                    { "e3298230-9ef8-40da-abbe-693baceb37d2", 0, "7d2197d6-3b5e-4850-9c50-469b0d0a300b", "eleanor_conn@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDmE8GudwpfuPo0lBWzVxcDYssZn8qhts5+nKuu8tgrzey+BbM0tauPlJE3d9bn+HQ==", "(422) 841-6168 x1086", false, "19b1ba85-a496-4824-9b1e-ee72d8754007", false, "Eleanor_Conn" },
                    { "f2f361cc-080a-47b0-a558-8d7712200c72", 0, "e4d7fa20-2648-4709-a703-34cf181a5fa6", "myra.hauck@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPKstFtdBNzmO5R2X8p2coD4A4AjC6nJ2NiiJ9ybjN2JtB9hSmwIr/JVLOV/nwsykA==", "205-893-6991", false, "6eb2778a-e0fd-44d2-b9c9-271be10c3ad7", false, "Myra.Hauck" },
                    { "f876f6fa-e106-417a-a3ba-326c9d4c9352", 0, "5b38091c-64d1-4b86-9c86-d66b81e9b21e", "felix5@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEI5UUFw51W/jlygKfUz3+PBOt7Euskqo0CtEpeF5wz9l7056UJmZwEnxPfvAl/5ZAQ==", "(956) 712-4170", false, "f77a6c10-b004-4b75-bda0-a98fdc929bb0", false, "Felix5" }
                });
        }
    }
}
