using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RazorLibraryProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class HuntingImaginaryInserts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "1c8e7bda-f7d6-46c0-9d87-abeb5af71e23", 0, "3791e341-2149-4ec7-be8c-14be949e108f", "olga.collier24@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBrd8l5LUdsucGCNmLRd3SFpQnQtd4VgAoPaD3YUZ1FJWub9WOs6bthbUhug/7uTJg==", "(462) 843-3722 x68925", false, "05d8a12e-ba01-42b4-bb1d-0296a54277d8", false, "Olga.Collier24" },
                    { "2b465f84-28db-426b-8fc7-316b248ac687", 0, "cf55bb2c-68af-4bbe-aca5-b8248ba688b2", "maria_gusikowski@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAED/O+2iCdLPjcq/IdeHz6R0U5vMpWUMYfYia2794FljLcgJH05dBsP5CX8OW/cOoqw==", "(225) 947-0437 x323", false, "16a12a7c-9a9d-4e5f-ac0b-f9af54da89f3", false, "Maria_Gusikowski" },
                    { "2ff860db-e736-4cf7-9eab-943afce41d82", 0, "d388f2f4-c47e-4aaa-989f-e8ec0a1c3992", "sam.beahan@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEH8uRPK2lI6tolQHJNdtb6KIOEtvr1VqF6oShhsjsNU2X1cYAMs5gI67pbd7KMxRFg==", "536.919.7964", false, "ae8a1248-356b-4f83-ac47-d8dd9a4638bf", false, "Sam.Beahan" },
                    { "56518bd2-bf5b-4ab3-8f60-ad8bb78eb078", 0, "997e4eb6-6284-4654-b84b-25c2d7b2e522", "scott72@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEAzkHagWFh9F9wFkQDv+/wyW3GWuGT6PsSh1CDQsnfY/tUsrO94Pf+1ADZoSt7zOPQ==", "727-353-0733", false, "c74944c5-a366-44c2-8926-b084225fa486", false, "Scott72" },
                    { "5d172fc9-ca48-4bea-9e42-b9f53cb13da8", 0, "3254d8d1-7a19-4b48-ac96-95d9bfdf9de4", "alberto_monahan@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEK+s8Fbsmex4ivrbPUJ4lcZoC6MPuQiUDe5rNEpK4DAF9MQfz7GTfoSa2xNweSgTuQ==", "(654) 446-7490", false, "51bda9a2-2135-4a2a-822e-4a2d37823c8c", false, "Alberto_Monahan" },
                    { "935f0f58-53bd-4e65-8881-86eb3307350e", 0, "255de3bc-f23a-41c6-8bc0-829947ba9c1b", "sean_simonis83@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEDQiux+17CJ2Q8Og6MzxX91uTKOf2imjWdSPluIbQiFOef3jRViOEp13/kPYyWEs9w==", "835-983-7616 x355", false, "a75a2fd0-506c-4218-be14-b0977bddc215", false, "Sean_Simonis83" },
                    { "9a125338-b10c-465f-b06d-a1ab264de028", 0, "479362e6-fb01-4d8f-b111-867cb47d972a", "ernestine_walsh0@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJic6yypAS/ezy0f6SdWaiZJtpSMqVn8nOCW9gt/EVUOVc873Hnrdpv6bFph3odFtQ==", "1-228-722-4275 x67263", false, "6f1239f2-5fb0-48ef-8202-afd4f30a6b4f", false, "Ernestine_Walsh0" },
                    { "b70eb3a7-15e0-49f8-91f5-55635a8b0bd9", 0, "30671ecf-7ee2-40d5-bf45-cf231e81ea98", "jimmie31@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEFKDS8/hBpOMAt/67ZNEJPQdDXrfmGLsNUHhGTq0ElsCzYTw90a9VeU6O5qRD0XmSg==", "668-216-2545", false, "15db1927-b5fd-4866-a8dc-52348c1641fe", false, "Jimmie31" },
                    { "caa84dc0-9bd7-43e2-9ced-d34a11bc3916", 0, "6f62491a-01bc-407b-b2b8-b09821268e44", "gregg.donnelly@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAECwobOd6SRxHcjWTthvbhc3SGWzpBXWGY6punuksDQSzydY0zrRbW+WRtdMx98Fo6A==", "302.516.5766", false, "0f7f9c69-053d-4973-be1c-897d83db995c", false, "Gregg.Donnelly" },
                    { "d66ef5e6-7588-4e9a-abe6-605fd3ba9d0e", 0, "aa3b001d-cb4d-4e5a-a720-6630229377d9", "roosevelt.marks@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEJxtRTmTxEs1IFtILw/eIdFUoaBnQv0YyJdMa+oceSrKMuiFrv6XmuLVlgqsFnWo+w==", "(218) 947-2945 x80964", false, "e7e4ccff-9f31-4ed4-822e-002a12bf612a", false, "Roosevelt.Marks" },
                    { "e92fc800-dcbb-4065-81f7-f9fd7e67be3a", 0, "bf3863e4-0391-4b79-ba28-9557f06ab97e", "patsy_blick26@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAELSNExJF7ocnfgJGFHK/u19gSskKltDB+TIapIGdQdL6O5IvwmSX5swd6pm5Z8FjNA==", "(844) 878-9988 x9728", false, "91d8d6ca-190c-431d-a6a8-2261b402616a", false, "Patsy_Blick26" },
                    { "ef9e4561-d07b-4426-893e-41f77acb19ce", 0, "88e7bfdc-bada-4854-a2d3-7dcb951aa930", "steven56@library.net", false, false, null, null, null, "AQAAAAIAAYagAAAAEBMlGfcwSTxxLjEAZvLtnpvffE0SFClJp3+oyr5YcvHGr+Rh7lFMiwtqB62WzDPsKg==", "1-530-782-2707 x5227", false, "03ab1b94-896c-4344-9409-060c8589d24e", false, "Steven56" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c8e7bda-f7d6-46c0-9d87-abeb5af71e23");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b465f84-28db-426b-8fc7-316b248ac687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ff860db-e736-4cf7-9eab-943afce41d82");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "56518bd2-bf5b-4ab3-8f60-ad8bb78eb078");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d172fc9-ca48-4bea-9e42-b9f53cb13da8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "935f0f58-53bd-4e65-8881-86eb3307350e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a125338-b10c-465f-b06d-a1ab264de028");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b70eb3a7-15e0-49f8-91f5-55635a8b0bd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "caa84dc0-9bd7-43e2-9ced-d34a11bc3916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d66ef5e6-7588-4e9a-abe6-605fd3ba9d0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e92fc800-dcbb-4065-81f7-f9fd7e67be3a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef9e4561-d07b-4426-893e-41f77acb19ce");

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
    }
}
