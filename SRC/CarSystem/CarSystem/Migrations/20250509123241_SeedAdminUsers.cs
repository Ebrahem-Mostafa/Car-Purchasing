using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class SeedAdminUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "d5d7b4aa-0725-4a84-a119-28c35920ff5d", "Admin", "ADMIN" },
                    { "2", "c88b58e5-4069-497b-8bdc-430ea66d6664", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Age", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1", 0, "bj jbh nbj ", 20, "c7d2b9dd-fa6a-4bdf-83d7-d1863a2041d5", "AppUser", "omar@gmail.com", true, "Omar", "Abdou", false, null, "OMAR@GMAIL.COM", null, "AQAAAAEAACcQAAAAEEC/eKqq0t8GzewIFpKa5nN4DpXvKfWy5epmFmK9ic2vWiPFxVGABXWY/aPWpSxwRg==", "01112686866", false, "19503a4e-1711-480c-946c-3d40dc3dddd6", false, null },
                    { "2", 0, "bj jbh nbj ", 20, "8e50c09e-80cd-4812-a4c9-f21a067b6fa5", "AppUser", "anas@gmail.com", true, "Anas", "Mohammed", false, null, "ANAS@GMAIL.COM", null, "AQAAAAEAACcQAAAAEBzHhQ+7xmw89TwKMjfrApAdi3/Uy2detu9pwOiYnKCZh+rDuXwZ7pWNJglIXcfglw==", "01112686866", false, "bf1c9ae5-bf92-4d7f-801d-66ed03f76b7e", false, null },
                    { "3", 0, "bj jbh nbj ", 20, "67bbf6bd-b4e2-4cf6-b4a3-8e4107511d09", "AppUser", "ebrahim@gmail.com", true, "Ebrahim", "Mustafa", false, null, "EBRAHIM@GMAIL.COM", null, "AQAAAAEAACcQAAAAELBk+dpSRGY2iaSUAakLV+rETCX48xkTEJSXYE4khNcYWeprTsnVI/LbKQXtk98WLQ==", "01112686866", false, "3c0e7334-fb39-40d7-991a-24263b8e373f", false, null },
                    { "4", 0, "bj jbh nbj ", 20, "63dab5c9-b0fa-48a6-bc50-0894a697e47c", "AppUser", "ehab@gmail.com", true, "Ehab", "Ahmed", false, null, "EHAB@GMAIL.COM", null, "AQAAAAEAACcQAAAAENTpcTtZo7PRdnyXHkCPGn5RCBEGETKEUJfIPtKlUsK/TVnmfkYHpH596nt3HP0Ovw==", "01112686866", false, "f6695d0a-ab02-463c-b0b7-de6ab414ec49", false, null },
                    { "5", 0, "bj jbh nbj ", 20, "0217482c-b916-4142-9e19-38297ac26ac4", "AppUser", "arsany@gmail.com", true, "Arsany", "Ashraf", false, null, "ARSANY@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFEUnW1oJxkaQoGwG/FiCaoZDH4f8bQRDAUzFAwRw5Lwh2gDcvDkqgQ2ndZ9PPxmxw==", "01112686866", false, "2c75c8fc-1841-4a68-865c-d53d62c814af", false, null },
                    { "6", 0, "bj jbh nbj ", 20, "8e8fe617-15f8-4634-859b-8e064145903f", "AppUser", "zoz@gmail.com", true, "Abdulaziz", "Abdou", false, null, "ZOZ@GMAIL.COM", null, "AQAAAAEAACcQAAAAEMMcbIhzuCB2sqTi11XoqYe4Etj+uJC6rvzo70c0Swo45BwmyznkhmICcfB6ibBXvg==", "01112686866", false, "1042f523-d9af-4701-88c8-18389c24354c", false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "1", "1" },
                    { "1", "2" },
                    { "1", "3" },
                    { "1", "4" },
                    { "1", "5" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "5" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5");
        }
    }
}
