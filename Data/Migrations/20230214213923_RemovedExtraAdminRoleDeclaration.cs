using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class RemovedExtraAdminRoleDeclaration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0d03ed3e-8290-44f9-b622-f9188c2bc0e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f219d7e-d201-481c-a504-bf95b02f1082");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11549e1e-4de4-48bb-8258-e332b3694b31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1f985bbb-f0f4-4261-bd61-4db9d43a5790");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d6b4aa5-9d5f-4ba1-90f4-087dcf63b44c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37fe4428-c64b-434f-8ab9-e1fd4d1df1fd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cce72d0-12d6-459c-98d2-8464534ebfe1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46444bff-c29d-4e74-8a10-cb17c60aba08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5e06b5ef-dc60-429d-ac24-3ea25eeb7722");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7ffe40bf-593c-4c87-864f-ffd6d2f4f5ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87017339-1666-4581-af15-49a3557063c3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87943e6c-60e9-4940-aeb6-7ebee74c20c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3436cb7-16ec-42d0-81e0-89c58a98d3ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6f9580f-c5fc-4154-927b-26c342d26c70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf896219-1f27-4d58-84f0-ab459aa0d5f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d593ca41-b0fd-4600-b141-f8b39b8a867a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9c2664a-8885-400b-8437-095c6d9662bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e0afed5b-2829-4e7f-833f-818281ff3dd0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7fde6c2-a1cd-46a1-90a1-456bdc6e1886");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0c3e46b-141b-4353-96c7-e9e35d185044");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1ac65b0-d535-487b-953d-03bcb5fe86ec");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "0d03ed3e-8290-44f9-b622-f9188c2bc0e8", 0, "2fe47e8d-c5c6-40b9-971d-0b56452021ac", "borrower@library.net", true, false, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEPf4ppGF2/N/7HrPe5kLdYK7Ndf5RxZnHbr1pMtawHifGDkF39Fm/W/iDXeBiqTlLQ==", null, false, "bedcab12-c338-48a3-9fe4-fc5248a22f63", false, "borrower@library.net" },
                    { "0f219d7e-d201-481c-a504-bf95b02f1082", 0, "fb5a1f1c-0e93-4405-85d0-ebfe8c314e93", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEGumgrKXROxmZvKA8kohgyue2igz+FRZr7v0ZAATyFc/UWFxwgA7oHqm4bITiZKEmw==", null, false, "c4af566d-17fb-4031-9dab-513f13b5aef5", false, "librarian@library.net" },
                    { "11549e1e-4de4-48bb-8258-e332b3694b31", 0, "492dbfa6-2849-4fac-b395-ba85653c57c0", "courtney.renner92@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOaEjXhL/KnbWhc7ckKwvca+9M5FKjZn8R8Ya3W+ukRwxg2tzyMTRzOjVHlWjpVzXg==", "1-795-248-8802 x224", false, "85346bad-5317-4b69-86cb-860acafb98d5", false, "Courtney.Renner92" },
                    { "1f985bbb-f0f4-4261-bd61-4db9d43a5790", 0, "111b00cc-545d-4498-ae29-08789a5892a8", "ada4@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJinRzDPoMs4LwgmnzpIcCKG3Zs+BJWP/wpsbw2Zf0Lqf1k1zzwNjGuMNbuX/rLyHQ==", "(256) 680-5178", false, "1b382177-26ce-4ed0-a440-a0f96cc3f3c6", false, "Ada4" },
                    { "2d6b4aa5-9d5f-4ba1-90f4-087dcf63b44c", 0, "76394bb4-6cf5-4922-8b50-d69f792d9cfc", "pearl.glover22@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMbwP8wxcDmrSt13ai8pcOWa3b+X5JQx2Gq070bnGJ/iYnu5TQq9X09ia7bOyB2UKg==", "289.642.4229 x970", false, "63cc5ef3-3b65-4b57-84b7-e8ff2bb7116e", false, "Pearl.Glover22" },
                    { "37fe4428-c64b-434f-8ab9-e1fd4d1df1fd", 0, "04b0775a-d6b5-4463-ae6f-d21bdb9f4580", "marilyn.prosacco@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGdVkg+lHg2SUjD1/8anHQImKuSTlyigJvDChw3XyReOo0ghXMRfSnxKblqMyhd/+w==", "749-965-5619 x34458", false, "5329f6f0-f7a8-4d57-ada5-0a9b590c9c4d", false, "Marilyn.Prosacco" },
                    { "3cce72d0-12d6-459c-98d2-8464534ebfe1", 0, "7ca2a7e4-7232-47ff-87d1-380bc9014c6c", "garry17@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEHamyt0i/id9PcWC7dZ7UvP1THDQ98iUVtBnbHCuaZtuZwFliwlJYVY+cEqrBXOYXg==", "(930) 996-9389 x60898", false, "cb6a4102-1dd3-44c9-9d16-28e966eac208", false, "Garry17" },
                    { "46444bff-c29d-4e74-8a10-cb17c60aba08", 0, "fe07945f-015e-4132-8438-3513c64959b8", "antonio43@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEGHM+KhnoM7GeXkuwB7ENhb8ftvdDKW6rOa/lzOm2F83AQqe+7Jh4z1j5zoYFC8JOA==", "1-849-305-3101", false, "93bb0aeb-49ad-4fb7-9b94-70e47995c424", false, "Antonio43" },
                    { "5e06b5ef-dc60-429d-ac24-3ea25eeb7722", 0, "8e7845e4-54ec-4b8b-9987-6910f33795d5", "tyrone_oreilly72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEPM1mnclAN/a/QE5t30blnoOYjiiz+cco25PuVpgs5h4DndR1Xe0hAgdpMYdqcIzgg==", "737-527-7995 x1618", false, "2244c754-973c-494b-9c9b-9fbec3af7513", false, "Tyrone_OReilly72" },
                    { "7ffe40bf-593c-4c87-864f-ffd6d2f4f5ef", 0, "99974948-c1cd-4ee8-8a0a-c69010e0010c", "wilfred_zemlak98@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEKzDUYsVbleh2YqOiXPnZseul/mHxqCROv9gJqSPQ8dPD1wMZrZm8RH3lAg0/7kCEA==", "869-615-9085", false, "cdc40774-af4d-44d4-ad1b-ad8dc58a640d", false, "Wilfred_Zemlak98" },
                    { "87017339-1666-4581-af15-49a3557063c3", 0, "d290ab75-5456-4770-a62a-86a3ab318d1d", "katherine.herman@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEP9iQV28F2OvIJQlDl/cw/43yVUkRjU4+ZLLafw9URuj4o0WgCiMeDwvg+lZvOUiNQ==", "892.907.3049", false, "1acc5472-8ad9-40da-9bd3-b4c3cb08f1b5", false, "Katherine.Herman" },
                    { "87943e6c-60e9-4940-aeb6-7ebee74c20c2", 0, "c5101aeb-8215-46ab-9609-91050eda7f9e", "kathleen.morar@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEM8DuusJcfAtrKWt3AySIMJUfJf6KDGXGmSxhEr2rdANdJnUNmbVeEf19L0U+AtPBw==", "(572) 786-7488 x0789", false, "d690f51d-77ff-4569-a485-728b041490e6", false, "Kathleen.Morar" },
                    { "a3436cb7-16ec-42d0-81e0-89c58a98d3ad", 0, "4849e9b2-07cb-4e3c-843b-4e0be75d5a56", "jackie_langworth12@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEDKue9CxFfVGDZXEqRSAHmkuqBGMjHZa5LVKEp0Uqn8mHnyicHTZ7rRNUW1HeRFNQ==", "1-553-249-0524", false, "ee2dd0fd-808e-43d0-a918-68e34cbec8d0", false, "Jackie_Langworth12" },
                    { "b6f9580f-c5fc-4154-927b-26c342d26c70", 0, "68062f91-5bb6-477a-b9fc-80811240b09e", "corey.ebert26@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJjkTEEAjEJnVnFBeTx8qi+jc+7iKln3Lpt338eavkuSF38rZ5eLRk+ZASwF7IBVVA==", "529-410-6571 x5059", false, "9fcc5743-1c4e-4903-9357-ac6c9cf88d7b", false, "Corey.Ebert26" },
                    { "bf896219-1f27-4d58-84f0-ab459aa0d5f6", 0, "44f15a82-b3c1-4693-9700-f2467580618c", "camille_lehner@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEMifHweSQ0tgEKte/YpDg3LQb+OxFtT3XB55rOEy8m6fUlvQb7FPnv+bETfFpbYy6A==", "627-240-1093", false, "0e54a26d-96a6-424a-81a9-44b190ac155b", false, "Camille_Lehner" },
                    { "d593ca41-b0fd-4600-b141-f8b39b8a867a", 0, "ad00f397-b680-438d-ad18-508d091a6fdb", "guadalupe_jerde@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEEuuXBDRcYisolJsJWbZVebXVc6sNa09GYO3EbtUjshXIIBT66XMHDNwlmBAoRy9Tw==", "(822) 597-0569 x22190", false, "5309c9cb-a531-4b79-a08c-b48a22da8875", false, "Guadalupe_Jerde" },
                    { "d9c2664a-8885-400b-8437-095c6d9662bd", 0, "d53f8435-6213-401f-a3a3-a4923115593f", "susan.homenick50@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEK4VzOrtX8PbKOB+TjHuykHN7W0jcVCxr24q5N6kG67/OnkEQfRhsbc2/ggkkc2Znw==", "968.323.1256 x5228", false, "59dae62e-a569-4612-9129-61d506ec3e9e", false, "Susan.Homenick50" },
                    { "e0afed5b-2829-4e7f-833f-818281ff3dd0", 0, "2383887d-7d90-4c65-baa3-08f3ed208a32", "micheal_kassulke18@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENtuROQ9RJpHT4AjLa3q6y0dfCnH2S/HnWRukQMqTw4j+/KwPUiYPJNraHmz7juQyQ==", "483-368-9618 x366", false, "6dbcf47a-40c8-4d87-a60f-8805baa8498f", false, "Micheal_Kassulke18" },
                    { "e7fde6c2-a1cd-46a1-90a1-456bdc6e1886", 0, "498266aa-cbf5-4518-827a-6aff756192bc", "lamar.wisozk@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENo/zdaWdx+0WexxzIPQj6U4HUpb+VJsifCnpRywUU2B4D9arHdBBxlNKoFTFbbA7A==", "967-967-6373 x25565", false, "807f8c99-d9f9-45e6-bca5-14d9f5c3c71a", false, "Lamar.Wisozk" },
                    { "f0c3e46b-141b-4353-96c7-e9e35d185044", 0, "9d5d288d-da9a-46c0-92ab-f60869c5af8b", "eileen.rice81@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECc+kMp+pKUyIy+u4OR0v0HPhublLzrf1luZIMFG9eqnNOmYpVgevJruz9jugLqhXg==", "992.221.8568 x8600", false, "12629ca7-e131-41eb-95a4-6a6919044d66", false, "Eileen.Rice81" },
                    { "f1ac65b0-d535-487b-953d-03bcb5fe86ec", 0, "0da3bd90-27d3-4b42-bb7d-18574c1d13c3", "gail_lang86@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDW/SLzjzh8eGdbfWJUe4Mysw+4EWmL7tD9v6W0eDX6BH+3L/7bkxbJ4ZnjnmVq/BA==", "393.885.6613 x28676", false, "13af97b9-df23-41ea-8bff-012a003f8806", false, "Gail_Lang86" }
                });
        }
    }
}
