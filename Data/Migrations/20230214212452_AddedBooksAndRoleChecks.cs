using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedBooksAndRoleChecks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorLast = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorFirst = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book", x => x.Id);
                });

            
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "82e88c98-0927-48f2-b8a9-e36c34e37992", 0, "1f4cc411-4c86-4a52-bb2e-e17d97508d35", "lydia_gottlieb51@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEOGJG+p+IeP+MsWJqIvps+ZJNnXXS95rkrynldq4BrVUb8GTkL7IHwfymKe8VFRwrg==", "1-712-568-6773 x028", false, "0f6bc8a8-081a-460c-b8de-f116042d149e", false, "Lydia_Gottlieb51" },
                    { "9ad53060-f55e-4159-8ecf-06dd20640bfa", 0, "dbf573f8-da8f-4ff0-9c41-95ee282a3563", "jodi11@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAENHDYS0LiorDyHkJY02fYT4p2zxSha8Wlnxerl9HzJZGiW+o/kNpeIOLWb1JjbGUAw==", "(989) 200-7997 x798", false, "fded5893-172b-4b26-9f79-1e7d400dd996", false, "Jodi11" },
                    { "cd5b1bab-34ce-4203-865f-0e8aa1640c69", 0, "2a19df18-57f6-4be1-be15-b28b422e8527", "victoria_hansen73@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJOlPAD0KEeYmklG5Py+rag00/shEcozNY3aXcSh6BnFqSCZNZMx2rKeo1bgffLr4w==", "506-774-0027 x47837", false, "40f330c0-7b38-40de-8e67-2115c77cb3e8", false, "Victoria_Hansen73" },
                    { "e51b29c5-dbdd-4798-8fe3-6e6c7d49a86a", 0, "337ef67f-54c4-4767-a7c6-e31bb4a3be09", "librarian@library.net", true, false, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEAYjea/F6dldH9uiy3IhS/08q33a273g2jYCSBkwUGQjhj7uExtVUytKj3H9Xyllyw==", null, false, "13c0c493-86bd-40da-b543-fa98a2978ca0", false, "librarian@library.net" }
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book");

            migrationBuilder.DeleteData(
                table: "AspNetRoleClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "e8567d36-dbd1-4e6d-a758-1b748fabd0df", "e51b29c5-dbdd-4798-8fe3-6e6c7d49a86a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82e88c98-0927-48f2-b8a9-e36c34e37992");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9ad53060-f55e-4159-8ecf-06dd20640bfa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cd5b1bab-34ce-4203-865f-0e8aa1640c69");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e8567d36-dbd1-4e6d-a758-1b748fabd0df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e51b29c5-dbdd-4798-8fe3-6e6c7d49a86a");
        }
    }
}
