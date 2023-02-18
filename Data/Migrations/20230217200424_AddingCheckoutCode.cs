using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingCheckoutCode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "35cb49a4-8020-4a0a-bce9-62b65b4cec6c", "7689312d-f4d2-4b50-9d2c-572b546c79ef" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ac3d16af-cc17-454b-b9ee-97ace89400c7", "ed10d758-5209-4add-a1ad-5c569384933a" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03ff21c8-145e-4829-9207-72946cae4151");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d0621cc-905b-40e0-bbdc-586ecfd6202b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a10c760-0a02-4843-bd9f-3b14cf5702ad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "987ddf86-7e2f-41e1-b9c7-7ba2f72ef7a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a55c850-9a75-4bbd-adf7-67e8b829dac2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af9cfd29-1af4-4115-9358-8d692132556e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "be1a89d6-c513-4621-8f46-581716a0e2d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfede864-d471-46bf-b494-55f6d05b3655");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ec62701f-cb92-4204-97e6-461ac20c0608");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f03960a4-5986-4a00-9c2d-55d545bfa5f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff34a9b0-6fa0-44fa-927f-a545387416dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "35cb49a4-8020-4a0a-bce9-62b65b4cec6c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac3d16af-cc17-454b-b9ee-97ace89400c7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7689312d-f4d2-4b50-9d2c-572b546c79ef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed10d758-5209-4add-a1ad-5c569384933a");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "57742dc2-e652-449f-b5a4-0e748a077eff", null, "admin", "ADMIN" },
                    { "c2bd6065-b3a8-4f32-995c-bf368da7cddd", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "aeb41981-a6c3-4c67-b094-25f0222ef5a1", 0, "26432798-9349-4004-81ff-94b9f1a5464c", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEE8w3Z+fj08v/D/CBpC7CcVFbK7QCOpl+mtvXN98HQC6UwYAnSm6d9brog49/lTSEQ==", "", false, "57dccdd7-ffa5-480f-9705-fb602573d6c8", false, "borrower@library.net" },
                    { "b53cb596-129e-481a-abed-46a29fc0fcdc", 0, "fe322964-f6cb-4e53-a946-e8b2717d2f68", "User", "dorothy_brown71@library.net", false, true, null, "", "dorothy_brown71", "AQAAAAIAAYagAAAAEJfdxmsvfaidSTEQi+q2DC/kMx1cwwtWjyeEXCygwX1+rp5GNp2cSBiXESbhAUN2YQ==", "257.854.1624 x898", false, "4c2b7534-6362-4018-a8bf-9b326d3d8285", false, "Dorothy_Brown71" },
                    { "c5c54cfe-33aa-4f98-8da4-4db14bcd53d8", 0, "79c4648d-c0e4-466d-b41f-4fe668fd6a31", "User", "eileen.hoeger@library.net", false, true, null, "", "eileen.hoeger", "AQAAAAIAAYagAAAAEOVhvBLxqTlwbuPBqenEB31Ra+iPR/fwFOr/7zr4/vOI2JGEWkhGkH05jTGRxuUmzA==", "(919) 858-1744 x46544", false, "e2de3da7-d1b9-43b4-b493-a4876510828f", false, "Eileen.Hoeger" },
                    { "c9d43312-63c8-4ccf-bb90-c808df44b488", 0, "78e6984e-b140-4527-b5b3-22f4aa814621", "User", "sarah_deckow86@library.net", false, true, null, "", "sarah_deckow86", "AQAAAAIAAYagAAAAELLEaAacNvFGsoR1cFeXnCT73gTM0Ym3jBvETbhctPvgtL4VNmT5Z7iRgwLKXd49aw==", "(553) 201-6073", false, "b67b162a-59ca-46ee-bdea-c1f7791b648a", false, "Sarah_Deckow86" },
                    { "d4957041-7e2c-440e-8a3a-af8d975ad80f", 0, "002e1851-a715-416c-b8dc-08738deb3028", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEKElW0+pnChpFYXSglP0triKIFaQbA3eHMLEB/vFu7wgtjCNMtjhCHnI/JRBR+YQeQ==", "", false, "4c1535dd-cef0-4ded-9842-5f1a23eaffad", false, "librarian@library.net" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Gayle", "O'Hara", "Culpa aut accusantium consequatur eligendi culpa expedita quia quia. Quo et error. Vero dolore eaque omnis veritatis dolores molestiae. Aliquid et quasi vitae. Quisquam nostrum ullam ipsam quos debitis. Repellat voluptatibus est necessitatibus omnis et.", "Enhanced empowering capability" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ira", "Sawayn", "Voluptatem adipisci omnis corporis quia mollitia laboriosam deserunt. Quod consequatur sit. Corporis voluptatum cumque deleniti nisi. Et et aut ut perspiciatis sapiente quaerat sed rerum. Quia quasi quisquam voluptatem dolor cupiditate esse.", "Compatible logistical software", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Delbert", "Roob", "Exercitationem numquam doloribus ut adipisci voluptatibus accusamus. Velit illo voluptatibus facilis non corrupti ut harum quis distinctio. Tempora suscipit eos aliquid fugiat natus ipsa sunt soluta. Eum consequatur quo quisquam. Vero sed aut nihil ea eos in velit illo et. Molestias expedita aperiam et illo aut a.", "Vision-oriented logistical open system", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Casey", "Schowalter", "A quidem et sint accusantium adipisci sunt ut. Repellendus cum sapiente nihil veniam magni nobis veniam sit nihil. Quasi molestiae explicabo qui blanditiis error blanditiis. Est iste unde magnam culpa dignissimos nostrum dolores. Optio sunt illo.", "Multi-tiered high-level attitude", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Willard", "Schamberger", "Cupiditate deleniti qui minima perspiciatis ut animi. Laboriosam est debitis quia. Quasi aut porro repellendus fuga voluptatem quae itaque. Commodi ut eos cumque. Fuga dolorem placeat dolores molestiae omnis.", "Universal system-worthy solution", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jessica", "Harris", "Quaerat beatae molestias earum expedita et. Deserunt earum velit itaque. Delectus et odit nisi necessitatibus quia dolorum cum. Laborum dignissimos voluptas et est eligendi accusamus dignissimos harum temporibus. A eaque at distinctio aut voluptates est aliquid. Accusamus at recusandae repellat cum eos consequatur.", "Open-architected discrete installation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kristopher", "Bins", "Ut quod vel sint. Reprehenderit iusto eius voluptatibus. Fuga autem expedita ratione nihil ducimus ullam aut sint repellendus. Minus provident reprehenderit eum. Fuga non culpa. Debitis sunt sint exercitationem minima possimus.", "Innovative zero defect methodology", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Beulah", "Emard", "Voluptas nostrum nihil dolorum blanditiis. Quia quia natus ut ex nesciunt qui. Dolor nobis nesciunt pariatur quis ut.", "Profound hybrid moratorium" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kirk", "Conroy", "Ullam et nihil et reiciendis voluptas nemo. Officiis quo dignissimos rem. Ad aut commodi molestiae molestiae iure quaerat. Ad commodi eos doloremque recusandae non qui voluptas dolorem. Sed deserunt accusantium neque labore quasi doloremque unde et.", "Monitored reciprocal hardware", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Dale", "Sauer", "Praesentium occaecati enim autem labore maiores. Asperiores non et harum. Corrupti quam ullam expedita saepe beatae. At commodi quis et voluptas. Enim distinctio in hic repudiandae quae.", "Pre-emptive heuristic Graphic Interface" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Nettie", "Konopelski", "Voluptatem quisquam porro cumque. Voluptas molestiae hic. Ex et ipsam quod autem maiores praesentium sequi facilis. Aliquam qui quia iste distinctio velit laborum impedit. Earum vel dolorem dolores. Voluptates vel sit minus illo.", "Polarised asynchronous intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jeremy", "Conn", "Et et optio in inventore sed non est. Magni rerum dolor eos pariatur necessitatibus omnis ut ratione. Possimus est id non laborum ratione sit perferendis. Et dolores explicabo aut iure non voluptatibus unde.", "Programmable fault-tolerant internet solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Victoria", "Armstrong", "Deserunt aut pariatur excepturi ducimus error. Quasi beatae ut quasi est voluptas temporibus. Vel ex corporis atque asperiores voluptatem vel non. Accusantium rerum aspernatur est quae quo.", "Synchronised grid-enabled adapter" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Lori", "Bayer", "In velit rem ab voluptas reiciendis ut deserunt eos sunt. Et quisquam veritatis dolor beatae non earum et commodi sint. Velit dolor at veritatis sit. Quasi non esse rerum qui saepe mollitia. Totam aut libero necessitatibus doloribus quasi debitis quibusdam sint eius.", "Vision-oriented heuristic paradigm", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Bradley", "West", "Voluptas aut ex error maiores. Iure adipisci quia unde. Quo porro commodi sed facere sit mollitia sequi dolor quisquam.", "Exclusive content-based throughput" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lisa", "Schimmel", "Nulla odio tempore. Totam rem corporis ipsam omnis id et molestiae possimus dignissimos. Culpa eligendi voluptatem quo nam cumque dolor velit.", "Virtual non-volatile open architecture" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Paulette", "Romaguera", "Veniam libero quia ex maiores quis dicta quod. Natus et consequatur eos officiis soluta. Tempore deserunt quibusdam qui modi provident. Placeat et dolor voluptatem. Atque est quis.", "Compatible zero administration contingency" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Marie", "Herman", "Cum sint aliquam minus unde omnis. Ex officiis incidunt esse pariatur ut ducimus. Sit qui unde accusamus. Amet exercitationem voluptas qui est aliquid iusto.", "Compatible context-sensitive frame", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jenna", "Veum", "Voluptatem dolor vel ut eius similique enim. Itaque facere sit molestias doloribus aut molestiae saepe. Voluptas et officiis modi dicta sapiente dolore laboriosam voluptatum. Accusantium aut laboriosam distinctio et consequatur exercitationem vitae.", "Synergized uniform success" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rudolph", "Stanton", "Qui in repellendus rem. Dolorem quas unde sed. Voluptatem et aut quo molestiae temporibus aut. Aliquid quo iusto qui ipsam.", "Decentralized background hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Raymond", "Deckow", "Et doloribus quas. Dolor consequatur nisi ad mollitia saepe velit sed esse. Hic explicabo ex est placeat exercitationem. Quia qui fugiat. Ullam ut rerum sed.", "Synergized client-server open architecture", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Georgia", "Hartmann", "Sunt alias enim quisquam veritatis dolorem quo. Beatae aut id praesentium hic facilis voluptatibus optio perferendis. Consequatur nihil aut. Ipsa eligendi omnis et qui labore tempora sint. Voluptatem eligendi est. Consectetur ex architecto.", "Enterprise-wide needs-based budgetary management", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Shawna", "Bashirian", "Corrupti aut non eius. Deserunt eum vitae sit perspiciatis. Rerum ea minima numquam sunt vitae. Voluptatibus et et dolorem beatae.", "Public-key regional standardization" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Opal", "Pfannerstill", "Qui voluptatem autem dicta reprehenderit enim ut necessitatibus. Aut eos qui. Aperiam velit necessitatibus. Hic et enim accusamus sapiente quas voluptates consectetur ut. Nesciunt aut et maxime assumenda reprehenderit. Animi esse exercitationem blanditiis deserunt dolorem consequuntur.", "Monitored bi-directional function", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "James", "Green", "Error dolor odio cupiditate voluptatem quia explicabo nemo voluptas. Dolore et temporibus saepe possimus ex magni illum voluptatum. Impedit ut pariatur eos minus aut sit. Repellat pariatur illum velit non architecto facilis adipisci. Omnis ipsum consequatur voluptatem aliquid. Laborum amet qui ad repellat deserunt dolorem nam.", "Customer-focused mobile secured line" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Fernando", "Turcotte", "Ducimus facere quo necessitatibus. Voluptatem accusantium in vitae nobis. Ad fugiat ea mollitia adipisci. Eos eaque quae dolores sit blanditiis. Quia quisquam tenetur distinctio sed reprehenderit quia inventore ullam.", "Distributed intangible core" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Amber", "Goyette", "Enim nesciunt autem a cupiditate. Ipsam sequi repellendus qui velit odio. Fugiat quia possimus eum nostrum distinctio culpa dolor omnis libero.", "Triple-buffered explicit hierarchy" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Pearl", "VonRueden", "Aliquid enim autem consequuntur voluptatum. Nihil assumenda iure repellat. Aliquid ut nesciunt omnis ab quidem ea non ab qui.", "Upgradable systemic solution" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rosemary", "Medhurst", "Atque rerum atque ipsam porro. Sed consequatur omnis ut accusantium tempore. Similique voluptas dolore sed soluta fugit repellendus.", "Synergized clear-thinking workforce", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Sonja", "Nienow", "Eaque veniam placeat laboriosam nihil magnam quisquam quas. Voluptatem neque et fugit ratione non. Distinctio explicabo praesentium iure tenetur.", "Re-contextualized 5th generation projection", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Tonya", "Schoen", "Ut placeat sint. Maiores assumenda rem totam voluptas similique. Dolor molestiae quia dolor et nihil fugit. Soluta nemo at ratione voluptatem hic delectus necessitatibus dolorum reprehenderit. Rerum fugiat iste ut ipsam cupiditate natus tempora in.", "Re-engineered multimedia emulation", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Kelly", "Dare", "Sunt tenetur explicabo debitis accusamus explicabo odit tenetur earum. Nam eos quia. Quas quod aut omnis quidem rerum voluptatem qui. Fugit dolor esse sed veritatis.", "Versatile analyzing workforce", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Javier", "Dicki", "Aut ratione tempora dolorem ratione ad. Necessitatibus perspiciatis excepturi et neque in pariatur quo. Quis a ut et quia quis et vel. Repudiandae numquam dignissimos sunt doloribus illum perspiciatis facilis.", "Intuitive reciprocal intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kenneth", "O'Connell", "Incidunt qui voluptas quia sed dignissimos explicabo fuga voluptatem blanditiis. In ullam alias deserunt incidunt in quibusdam voluptatem. Qui officiis illum officiis assumenda.", "Seamless asynchronous access" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Geoffrey", "Schoen", "Nemo repellat aut suscipit rem. Ducimus quia dolores. Error velit recusandae. Doloremque totam laboriosam cupiditate. Sed recusandae sapiente qui sunt deleniti aspernatur dolorum. Voluptatum omnis quaerat error officia architecto dolore velit.", "User-friendly reciprocal solution", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Rudy", "Hilpert", "Ab dicta praesentium animi. Et ut possimus excepturi veniam qui. Et earum molestias ut.", "Monitored client-server ability", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Adrienne", "Marvin", "Ea qui expedita aperiam accusantium eaque eos fuga porro. Fugiat asperiores enim porro praesentium. Numquam modi alias nihil. Aliquid omnis enim. Repudiandae numquam deleniti earum nesciunt dolores consequatur harum.", "Team-oriented leading edge interface", true });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[,]
                {
                    { 38, "Jimmie", "Bruen", "Quod est dolorem quo dolorum fuga tempore et. Ut rerum recusandae cum. Omnis delectus et ut ut ab quis.", "Polarised zero defect software", false },
                    { 39, "Ebony", "Hills", "Quia sit quo et quos tempora ex sed quae. Voluptatem reiciendis ipsum pariatur rerum qui sunt est. Sed ipsa aut ducimus placeat occaecati sunt quidem. Praesentium quia aperiam molestiae aliquid quidem consequatur soluta voluptas.", "Realigned asymmetric productivity", true },
                    { 40, "Kyle", "Goyette", "Laborum doloremque inventore omnis fugit ratione praesentium. Atque eligendi et voluptates libero exercitationem maxime laborum. Et odit assumenda at magnam consequuntur nihil. Rerum fugiat est odit hic similique dolores omnis. Fugit libero qui ipsum perspiciatis.", "Extended methodical middleware", false },
                    { 41, "Angel", "Brekke", "Nihil asperiores quis autem. Ipsum voluptatem corrupti ab est rem cupiditate ea. Ea earum dolorem sed ea odio aliquam consequuntur ut voluptate. Ipsam ad corrupti. Qui consectetur vel quia est deserunt similique. Asperiores est blanditiis qui error voluptates sed est laborum qui.", "Decentralized multi-tasking time-frame", true },
                    { 42, "Rodney", "Halvorson", "Et consequatur atque. Sequi consequatur illum est qui porro similique. Ut quia aut numquam sunt architecto. Ut consequatur quo ea pariatur.", "Self-enabling encompassing firmware", false },
                    { 43, "Andrea", "Nikolaus", "Sed voluptate aut sit recusandae vero temporibus. Doloribus architecto vel aut quo. Eos accusantium modi. Ipsam accusamus repudiandae illo fuga magni sapiente rerum et consequuntur.", "User-centric national approach", true },
                    { 44, "Walter", "Hartmann", "Excepturi animi dolor perferendis et impedit aperiam. Occaecati enim eos. Labore consequatur sint asperiores et qui dicta culpa.", "Advanced 24 hour implementation", false }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "c2bd6065-b3a8-4f32-995c-bf368da7cddd", "aeb41981-a6c3-4c67-b094-25f0222ef5a1" },
                    { "57742dc2-e652-449f-b5a4-0e748a077eff", "d4957041-7e2c-440e-8a3a-af8d975ad80f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c2bd6065-b3a8-4f32-995c-bf368da7cddd", "aeb41981-a6c3-4c67-b094-25f0222ef5a1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57742dc2-e652-449f-b5a4-0e748a077eff", "d4957041-7e2c-440e-8a3a-af8d975ad80f" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b53cb596-129e-481a-abed-46a29fc0fcdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5c54cfe-33aa-4f98-8da4-4db14bcd53d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c9d43312-63c8-4ccf-bb90-c808df44b488");

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
                table: "Book",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57742dc2-e652-449f-b5a4-0e748a077eff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2bd6065-b3a8-4f32-995c-bf368da7cddd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aeb41981-a6c3-4c67-b094-25f0222ef5a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4957041-7e2c-440e-8a3a-af8d975ad80f");

            migrationBuilder.AddColumn<string>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "35cb49a4-8020-4a0a-bce9-62b65b4cec6c", null, "admin", "ADMIN" },
                    { "ac3d16af-cc17-454b-b9ee-97ace89400c7", null, "borrower", "BORROWER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RoleId", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "03ff21c8-145e-4829-9207-72946cae4151", 0, "48718c27-926d-40a7-8f00-cf4886cab126", "User", "irma_cummerata@library.net", false, true, null, "", "irma_cummerata", "AQAAAAIAAYagAAAAEGv02S8qTCuBqEg8HEHJZ/NxheJifjuA8JAz8Ko5c5CUeFqbzDGTfMAwGhKV+fP83w==", "731-246-0362 x9408", false, null, "ca5046cc-73cf-4552-a3ea-b7db1807690c", false, "Irma_Cummerata" },
                    { "1d0621cc-905b-40e0-bbdc-586ecfd6202b", 0, "4a2bece3-0fca-46ee-a521-c95d4574b8ca", "User", "michelle_hand@library.net", false, true, null, "", "michelle_hand", "AQAAAAIAAYagAAAAENLVUor/8QdWziYVxDIC7E7jIAM7C7ad9ulc9MK+UqGGgjT3F0kDmk6G8e9IkJdH4g==", "1-618-876-8027", false, null, "ecc77b36-37ac-429c-a715-39cf5a4ef6a9", false, "Michelle_Hand" },
                    { "7689312d-f4d2-4b50-9d2c-572b546c79ef", 0, "3b5a80f8-0465-4f27-bc17-c9bc6cb27013", "User", "librarian@library.net", true, true, null, "librarian@library.net", "librarian@library.net", "AQAAAAIAAYagAAAAEK24Dqy3dRxPX3JEwDTLEJb7Quw8liwHAazKXO08pENVJSn0dbLeXfkY7sYGcC5ykQ==", "", false, null, "a3a30488-1a6a-4d16-9c31-6c9995680690", false, "librarian@library.net" },
                    { "7a10c760-0a02-4843-bd9f-3b14cf5702ad", 0, "91739ebf-c2eb-4303-ab14-81bc902c38ea", "User", "patrick.schmitt@library.net", false, true, null, "", "patrick.schmitt", "AQAAAAIAAYagAAAAEBNkvoDz43ByBPqqlUCbmVb9scawl0cCIU/yDYbItjXuWyEZ3rMwFvjAKlpKinA6Fw==", "938-369-6272 x219", false, null, "312032dd-0c0c-4683-bd71-0e3b7496b1ce", false, "Patrick.Schmitt" },
                    { "987ddf86-7e2f-41e1-b9c7-7ba2f72ef7a9", 0, "b7309b1a-6398-4927-8fc1-48d5b0c9e63e", "User", "jimmie51@library.net", false, true, null, "", "jimmie51", "AQAAAAIAAYagAAAAEDZbs1xjxDcM3TWlYJhGSBW9FGd5enFMYTaQ1yOGfhEvNJ9TB7WN9ZcCmMt3eaKVdA==", "1-669-268-7292", false, null, "8aab07b5-49f4-42b2-80a6-bc9199c4410e", false, "Jimmie51" },
                    { "9a55c850-9a75-4bbd-adf7-67e8b829dac2", 0, "55e6b31a-035e-45ae-9d08-f5c39afa1fb8", "User", "kenneth.stanton60@library.net", false, true, null, "", "kenneth.stanton60", "AQAAAAIAAYagAAAAEMcETxlhTpkvfdBd8jWfjBHp0x6XUHMFNnX+vlukiFkGEX0TTc4pS0Qdan3hVOna1A==", "1-659-534-8458 x4646", false, null, "a8daa67b-e2f1-4f86-b00b-686b10c200e1", false, "Kenneth.Stanton60" },
                    { "af9cfd29-1af4-4115-9358-8d692132556e", 0, "154ecdb1-8a3b-4fef-b726-80149411a533", "User", "rene.mayert@library.net", false, true, null, "", "rene.mayert", "AQAAAAIAAYagAAAAELajirFT5EnG3geEj2stSxMjTDa08prDQrZnfQSkgxHXB/RexRTVRHQ6JiLwq483wQ==", "(722) 643-4828", false, null, "d66ea289-9fcf-47dd-a9c5-058d1432bff8", false, "Rene.Mayert" },
                    { "be1a89d6-c513-4621-8f46-581716a0e2d6", 0, "1af155db-39fb-44bf-b5a9-e4e978010d3b", "User", "clayton.schulist93@library.net", false, true, null, "", "clayton.schulist93", "AQAAAAIAAYagAAAAECyQQbUq2PKv0QaZSXGzZROQjPya1o9VMHNNzUVfW0vbxSyJgiz1df9eXqA1iptsiw==", "917.815.0255 x8673", false, null, "80424c98-1d30-40b1-b8d7-29885396afb4", false, "Clayton.Schulist93" },
                    { "dfede864-d471-46bf-b494-55f6d05b3655", 0, "138ab0af-f111-4b9f-b732-86196a7e09b2", "User", "kay70@library.net", false, true, null, "", "kay70", "AQAAAAIAAYagAAAAEAXvBwkHM4j3dBmX0VjjyNRhENfoJQUOfU+N2SvC72PGrFkbjl0WbLZcddPnXLsLZw==", "1-364-611-6889", false, null, "8ce8d293-6cf7-44f6-aee1-4513df2e8cdf", false, "Kay70" },
                    { "ec62701f-cb92-4204-97e6-461ac20c0608", 0, "60b032b0-cc79-4f17-99e7-cc136f397e2b", "User", "duane99@library.net", false, true, null, "", "duane99", "AQAAAAIAAYagAAAAEB4s6PuWj6CNzKw8pLEUtWcrswexhtu4LKoMCuF4f1xIjiuy37sWuh+/ttkanrczXw==", "(235) 316-2005 x78757", false, null, "1929ccbb-2b86-41d0-8981-ccc571201bd4", false, "Duane99" },
                    { "ed10d758-5209-4add-a1ad-5c569384933a", 0, "ad42a1eb-32b4-4745-8343-010ae4039a15", "User", "borrower@library.net", true, true, null, "borrower@library.net", "borrower@library.net", "AQAAAAIAAYagAAAAEO81Ucv4h+GT3oZPNcJ0MSuI4cMwCKTQ9D2UlyyQAbOfsQEjrCaIUK6JWULeABLOnQ==", "", false, null, "56f7a234-87d1-42c9-a3bb-a6d33e75da88", false, "borrower@library.net" },
                    { "f03960a4-5986-4a00-9c2d-55d545bfa5f7", 0, "aabba045-a0e7-47ff-911e-b2365807621c", "User", "sheri_schinner97@library.net", false, true, null, "", "sheri_schinner97", "AQAAAAIAAYagAAAAECUlLmthFuJfpg8rS20IXPqHqb01zfQhu/M8yE/eVix+ryaJlxl9WNA2emXWANoJdg==", "921.558.4300 x53430", false, null, "8a4e7a37-cdfb-48e2-808e-47a993f49b60", false, "Sheri_Schinner97" },
                    { "ff34a9b0-6fa0-44fa-927f-a545387416dd", 0, "8aa6e532-0523-4637-92bc-1a81c6245545", "User", "vickie.schmeler@library.net", false, true, null, "", "vickie.schmeler", "AQAAAAIAAYagAAAAEMSC+sb3DDiQ8JCxzjRKZEuMmqhpEyLHiY6aJk5sHpsGm03UN15MsFZVEemWRKxc6Q==", "336.893.8710", false, null, "803e610d-1a65-4fbb-83d5-0ede5b46405a", false, "Vickie.Schmeler" }
                });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rafael", "Abbott", "Rerum sed in soluta aut. Et laborum perferendis nihil quia qui corrupti qui exercitationem id. Sint sit nihil. Laudantium quaerat aut voluptatem dolore quae harum et.", "Enhanced national extranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Erik", "Bernhard", "Nisi consectetur rerum et sunt. Ea ratione nesciunt consequatur. Enim molestias quisquam eum. Voluptas eum sed quaerat consequatur molestiae sit. Ut repellat veritatis et.", "Multi-tiered composite algorithm", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Cary", "Turcotte", "Distinctio voluptatem beatae enim in ducimus laborum sint quia velit. Magni omnis odio autem. Repudiandae harum tempora quas sed totam minima vel tenetur. Ea corporis eos quidem adipisci quia veritatis nemo illo qui. Recusandae molestiae atque.", "Focused 3rd generation implementation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Clay", "Olson", "Reiciendis rem nesciunt pariatur et et eaque praesentium ullam. Velit eos debitis labore quas nihil consequatur laborum aut eos. Qui dicta sed quae ea molestias alias saepe atque rerum. Possimus quia aut saepe omnis. Facilis laboriosam dolorem.", "Function-based content-based archive", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Gary", "Quigley", "Modi exercitationem quos voluptatem fugit. Voluptas pariatur quae. Aspernatur quidem dolores et dicta enim.", "Enhanced fresh-thinking open system", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Betty", "Rice", "Sapiente ducimus provident placeat delectus labore. Voluptas id nesciunt consequatur reiciendis harum est. Vel dolorum ab eveniet et cum vel corrupti modi. Non possimus sunt voluptatum velit possimus quisquam a qui. Nesciunt aliquam eius tempore dignissimos id quia dolores maiores. Possimus alias eum porro dicta ea totam voluptas et.", "Polarised 5th generation concept" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jonathon", "Turcotte", "Rerum quidem voluptatem nam est laudantium magni architecto deserunt tempora. Amet qui et minima quae accusamus molestiae. Perferendis et et sint accusamus dolore quis totam voluptas aut. Fuga modi ut vel non id autem et enim sit. Aut vero unde.", "Team-oriented coherent encryption", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jacqueline", "Little", "Nostrum dicta iusto a voluptatum labore. Culpa voluptatem commodi illo nihil. Voluptas et totam maxime accusamus. Accusamus beatae qui et et. Ea incidunt illum et dolor velit.", "Team-oriented global initiative" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Ron", "Batz", "Vitae sunt recusandae alias. Fugit eos alias. Aut pariatur dolore eos velit optio voluptas vero dolor similique. Aspernatur consequuntur quia consectetur. Aut dolorem vel et perferendis accusamus culpa qui ut. Atque dolorem nobis rerum animi.", "Innovative even-keeled service-desk", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jared", "Kshlerin", "Autem distinctio at praesentium tempora nihil. Optio cupiditate omnis est. Est omnis fugit odio dolor.", "Optional intermediate software" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Jeremy", "Cole", "Dolor aut quibusdam eum eligendi modi. Placeat ut iusto ea. Soluta quas veritatis dolorem. Quo incidunt esse necessitatibus officiis molestiae quidem id ut.", "Future-proofed directional forecast" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lucia", "Torphy", "Iusto ex a et ducimus qui nihil sit consectetur. Unde odio dolor quas est et qui enim. Eaque eos culpa doloremque. Quia voluptate fugiat nihil ut dolore impedit non et. Distinctio nobis fugit. Reprehenderit quasi repudiandae nisi libero est nesciunt.", "Stand-alone system-worthy process improvement" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Cory", "Bruen", "Sit a qui. Veritatis itaque distinctio quibusdam rerum excepturi. Nesciunt ut sit minima cum eum cum omnis facere. Quas a quos sit optio expedita voluptas. Nihil sit minus est hic. Qui praesentium consequuntur quis nulla tempore aut quibusdam amet beatae.", "Virtual upward-trending algorithm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Jaime", "Orn", "Ut quidem esse ab delectus doloremque tempore tempore officiis et. Dolore ea consequatur. Voluptatum tenetur quam voluptas reprehenderit nemo sit.", "Optional interactive customer loyalty", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kay", "Dooley", "Nobis libero minima est est dolore minus pariatur et doloremque. Totam quaerat minus aperiam. Deleniti et facere rerum eos sunt ab quo alias maxime.", "Devolved interactive analyzer" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Harriet", "Mante", "Placeat quis veniam odit perspiciatis et maxime. Ex veniam consequuntur. Velit quia dolorem deserunt dolores architecto quo qui quibusdam.", "Assimilated dedicated forecast" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Morris", "Lang", "Labore porro quia perferendis. At labore dignissimos ex vero. Labore dolores natus sint suscipit et. Veniam quidem ab. Repudiandae explicabo sunt voluptas sed voluptas. Dolores temporibus sint dolorem unde odio numquam.", "Visionary asymmetric implementation" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Julian", "Bashirian", "Rerum id autem autem aspernatur nemo eius ut quibusdam facere. Cum dolore ut delectus exercitationem numquam voluptatem labore. Quibusdam aut excepturi praesentium laboriosam doloremque. Magnam et tempore voluptatum dolor quia aut consequatur quibusdam.", "Compatible systemic projection", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Rhonda", "Paucek", "Dolores voluptas dolore a corrupti tempore incidunt. Et nihil sequi praesentium ex veritatis harum aperiam mollitia. Impedit et repellat in sit. Et et quis molestias dicta quia assumenda et. Cupiditate delectus dolor et et. Quaerat temporibus nemo voluptas.", "Public-key regional hardware" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Christie", "Moore", "Doloremque sit debitis magni officia ducimus omnis et qui. Tempora qui enim ut fugiat mollitia et accusantium. Perspiciatis repellendus natus.", "Function-based full-range initiative" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Randy", "Bahringer", "Distinctio atque vitae et. Quia ipsam repellendus. Assumenda veritatis qui asperiores aperiam quo sit. Ut dolorem dicta aliquid omnis ut labore. Consequuntur repellat doloremque. Et deleniti suscipit repellat omnis et cum eius est.", "Persevering multimedia open architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Karla", "Hudson", "Dolores rerum quia quos perferendis eius voluptas dolor fuga vitae. Deleniti in sed aut sunt harum pariatur et. Minima adipisci quod. Eveniet molestiae et.", "Multi-layered mission-critical access", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kristi", "Anderson", "Molestiae qui aut excepturi eos voluptas voluptatem consequatur reiciendis. Ipsa deserunt quo voluptate at a in optio eveniet eligendi. Alias repellendus at aspernatur adipisci ab. Perferendis asperiores soluta. Repellendus fuga facilis in. Illo nostrum repellat consequatur dolores in distinctio alias.", "Ergonomic actuating intranet" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Alice", "Ullrich", "Qui voluptatem natus placeat et cupiditate dolore aut ab officiis. Ea aliquid cupiditate distinctio maxime itaque dignissimos eveniet. Et aut assumenda.", "Organized directional attitude", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Roosevelt", "Champlin", "Ratione repellendus aperiam minima magnam sapiente neque atque qui. Debitis voluptatem animi veritatis ut nisi et possimus a repudiandae. Esse architecto debitis fugit sit vero. Nulla quibusdam possimus accusamus iusto eos velit facere quisquam et. Et voluptate provident rerum cumque sed.", "Visionary attitude-oriented workforce" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Tanya", "Grant", "Repellendus dolorum tenetur quo eligendi nobis autem nemo magni. Quo ad cumque necessitatibus debitis nihil qui. At illum dolor earum quaerat at.", "Profound solution-oriented standardization" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Lance", "Nienow", "Numquam magnam quidem sit tempora. Necessitatibus id iusto blanditiis enim voluptatem ipsam soluta. Autem explicabo sapiente quis unde porro adipisci facere eveniet. Fugit accusamus quo earum porro officiis nulla ipsum.", "Versatile foreground collaboration" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Kara", "Hagenes", "Velit adipisci et quia sequi laborum ut vel sint labore. Qui deleniti dolores. Error reiciendis alias totam.", "Profound interactive algorithm" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Annie", "Roob", "Officia quam ut vitae velit maxime. Accusantium repellat impedit. Nemo porro autem esse qui sequi dolores pariatur fuga. Ut modi blanditiis quos praesentium. Cum quidem neque deserunt enim eius consequuntur voluptatem voluptas. Laudantium reprehenderit quasi occaecati nobis.", "Team-oriented next generation monitoring", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Mercedes", "Brakus", "Explicabo incidunt fugit quidem mollitia consequuntur. Sit provident eveniet. Id at magni sit ut voluptatum. Et provident sed autem nobis eligendi sit doloribus dolorem ut.", "Streamlined analyzing synergy", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Amanda", "Effertz", "Veniam est asperiores numquam ullam. Maxime eum magnam aut cupiditate adipisci blanditiis voluptas eos placeat. Et possimus quis. Laborum qui pariatur sint accusamus ut. Eius et sed fuga iure et sequi harum.", "Exclusive bottom-line emulation", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Beverly", "Koss", "Quia quae ducimus. Et illum at fuga et. Corrupti dolor voluptas dignissimos repudiandae eum rerum distinctio. Ut consectetur a impedit consectetur optio at ut. Omnis et qui adipisci est praesentium.", "Monitored needs-based throughput", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Myron", "Gottlieb", "Aut quos id laudantium omnis voluptas. Veniam doloremque odio sit et maxime inventore error eligendi. Et ad non perspiciatis qui officiis cumque. Earum fugit quo aut cum est quia omnis qui et.", "Ameliorated executive attitude" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title" },
                values: new object[] { "Violet", "Hyatt", "Et officia error aut unde dolor. Officia eius illo laudantium non nulla praesentium. Laborum nesciunt sapiente totam molestiae sit mollitia veritatis. Dolor fuga voluptatum minima rerum eius est ad libero consequatur.", "Centralized asymmetric benchmark" });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Helen", "Bergnaum", "Est iste ut repudiandae enim qui et et neque saepe. Excepturi nisi qui explicabo quisquam. Recusandae est et dolores optio assumenda praesentium nihil aliquid.", "Universal responsive contingency", false });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Charlene", "Greenholt", "Voluptatem at animi rerum minima doloremque adipisci. Repellendus quibusdam quia consequatur. Doloremque sit totam dolorum dignissimos itaque. Accusamus rem asperiores facilis ad enim est sunt saepe totam. Cumque eius quidem.", "Multi-channelled attitude-oriented open architecture", true });

            migrationBuilder.UpdateData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "AuthorFirst", "AuthorLast", "Description", "Title", "isAvailable" },
                values: new object[] { "Larry", "Schuster", "In non aut in dolor nam occaecati voluptas sunt. Et at dolor. Ipsa esse autem illum. Incidunt consectetur explicabo impedit repellendus.", "User-friendly stable portal", false });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "35cb49a4-8020-4a0a-bce9-62b65b4cec6c", "7689312d-f4d2-4b50-9d2c-572b546c79ef" },
                    { "ac3d16af-cc17-454b-b9ee-97ace89400c7", "ed10d758-5209-4add-a1ad-5c569384933a" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }
    }
}
