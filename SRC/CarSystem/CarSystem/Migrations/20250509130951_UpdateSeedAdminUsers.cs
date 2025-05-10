using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class UpdateSeedAdminUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "b4c5a6b8-4a90-4b63-b2e5-e962cb14bdeb");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "280f3653-92e1-439b-8e45-449828e06ebf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f61b5337-7c93-4b0c-86d9-595eac6873c9", "OMAR@GMAIL.COM", "AQAAAAEAACcQAAAAEOnv6Csag4qd6LvTiuAHbbTwIwYj4qSIIxSd8Ontq3/bb2GCpvIgPERIHjrXUjgGPA==", "21a84bcf-661b-4327-acf8-452d3f61843c", "omar@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "805f60c2-78b4-4172-9b32-0ba3c786c966", "ANAS@GMAIL.COM", "AQAAAAEAACcQAAAAEHCjLdv288ooDFHr2RAhbx+5AgqawsM3UJDLv5zkLMXh4qF1ILEPceCrNaFERgg3LA==", "13fd7d9e-6b1e-4918-b506-205f1d728c18", "anas@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "08d67d04-8bd0-4437-80b9-0d67f53e65dc", "EBRAHIM@GMAIL.COM", "AQAAAAEAACcQAAAAECpjjBFjrn7If6La9uoo0Qz4YS4GdWceo4QNRJ4azqJqhh4fs+dAgUGfbQqwQZupUw==", "87cc2700-2ed4-4e79-a507-1a20eb706eb2", "ebrahim@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b6a51a5d-1e88-4163-96ab-5b5b4edfdc6b", "EHAB@GMAIL.COM", "AQAAAAEAACcQAAAAEBCS6h5Xs1n6RLb3Z2Lg5kaqq2lVyD4H70StpZVLO76M35z0BvzZm37u/QPYVRIJYg==", "f07a6560-883d-4d7c-bd99-d88b73b007aa", "ehab@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "4c814e6a-da4e-4d09-b3c3-0a4df1922b90", "ARSANY@GMAIL.COM", "AQAAAAEAACcQAAAAEGtXOCM4llNH24R5dDqVDDsMKcOw2uaE2Dgbs5Rukbvz7AoFl0qeBSbzdJ6Xhoqxkw==", "d176a5e0-46ac-45e3-9f5b-4f3f30cee584", "arsany@gmail.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "b3c85c27-a75f-4398-8c1c-6822a35a9ab9", "ZOZ@GMAIL.COM", "AQAAAAEAACcQAAAAEOvXBZh3w03KUGfvqKJBKO+H3vJ6PfmofrSMD2/Xb/dIdd1qZBDi7zaLgxX5wTGHVg==", "09303b9e-54b9-45fa-8332-73e22a6e2d16", "zoz@gmail.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d5d7b4aa-0725-4a84-a119-28c35920ff5d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "c88b58e5-4069-497b-8bdc-430ea66d6664");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "c7d2b9dd-fa6a-4bdf-83d7-d1863a2041d5", null, "AQAAAAEAACcQAAAAEEC/eKqq0t8GzewIFpKa5nN4DpXvKfWy5epmFmK9ic2vWiPFxVGABXWY/aPWpSxwRg==", "19503a4e-1711-480c-946c-3d40dc3dddd6", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8e50c09e-80cd-4812-a4c9-f21a067b6fa5", null, "AQAAAAEAACcQAAAAEBzHhQ+7xmw89TwKMjfrApAdi3/Uy2detu9pwOiYnKCZh+rDuXwZ7pWNJglIXcfglw==", "bf1c9ae5-bf92-4d7f-801d-66ed03f76b7e", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "67bbf6bd-b4e2-4cf6-b4a3-8e4107511d09", null, "AQAAAAEAACcQAAAAELBk+dpSRGY2iaSUAakLV+rETCX48xkTEJSXYE4khNcYWeprTsnVI/LbKQXtk98WLQ==", "3c0e7334-fb39-40d7-991a-24263b8e373f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "63dab5c9-b0fa-48a6-bc50-0894a697e47c", null, "AQAAAAEAACcQAAAAENTpcTtZo7PRdnyXHkCPGn5RCBEGETKEUJfIPtKlUsK/TVnmfkYHpH596nt3HP0Ovw==", "f6695d0a-ab02-463c-b0b7-de6ab414ec49", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "0217482c-b916-4142-9e19-38297ac26ac4", null, "AQAAAAEAACcQAAAAEFEUnW1oJxkaQoGwG/FiCaoZDH4f8bQRDAUzFAwRw5Lwh2gDcvDkqgQ2ndZ9PPxmxw==", "2c75c8fc-1841-4a68-865c-d53d62c814af", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "8e8fe617-15f8-4634-859b-8e064145903f", null, "AQAAAAEAACcQAAAAEMMcbIhzuCB2sqTi11XoqYe4Etj+uJC6rvzo70c0Swo45BwmyznkhmICcfB6ibBXvg==", "1042f523-d9af-4701-88c8-18389c24354c", null });
        }
    }
}
