using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TryingToBanishAGhost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64b1e282-fb43-4816-9b85-87495593042a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7048da70-5d10-4ea2-ad43-6df724d648d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "912f264c-613a-4f1a-983d-69e1041babca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e127b79d-9286-4c91-a0b3-32cd58b7da26");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "64b1e282-fb43-4816-9b85-87495593042a", 0, "d6011010-8609-43d8-8634-0e71379da427", "eva_jerde@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMEuZInatJt8DM7xzJnpltve51CmrhMDM6vmwb8jVZ03FYKyX0EaJ49m2CBbwZe0RQ==", "608-415-2184 x471", false, "03828f80-9869-49f6-a0aa-e04cd5a0396c", false, "Eva_Jerde" },
                    { "7048da70-5d10-4ea2-ad43-6df724d648d9", 0, "ae310d3f-67c5-4234-a413-3937c7aa4677", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEGtH5pYDjqaXehHKh5zyWwIMRnlHez+fzJRregmUwWjENu+fk9ImXKtyRb8Px23a6g==", null, false, "8ee94dc4-c0d5-4861-8334-b78df89d2f40", false, "librarian@library.net" },
                    { "912f264c-613a-4f1a-983d-69e1041babca", 0, "7ff47c87-53ac-4757-a0c6-3eea85317c7a", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEMaUGm74DyM80D1l4dveaiD1PjyZEgFGQPBLGgFj5rTdoWz539jud2FbzLKtM+c4DQ==", null, false, "0f339756-7e62-4a2c-b857-721cc74d1f01", false, "borrower@library.net" },
                    { "e127b79d-9286-4c91-a0b3-32cd58b7da26", 0, "d7fa4fcc-7d69-48c9-bb0d-8c83113a3ac2", "aaron47@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENlmev7m2PImice3E2uzdNjKsB217oMHEfHE/yrHtqHXOj1/AQHOhqSqxktHRWKGOQ==", "659-435-7459 x93421", false, "68f096cf-53db-442d-8dd3-a660e9dd70dd", false, "Aaron47" }
                });
        }
    }
}
