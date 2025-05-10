using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class updateAdvertisementClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Advertisements",
                newName: "Street");

            migrationBuilder.AddColumn<string>(
                name: "Area",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BuldingNumber",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Governorate",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "6b8b0e6d-0075-4385-98d9-fb207666503a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7b09c3b0-d5ca-4497-8999-fb3f095d38a8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "347a6b87-be1a-431a-b55e-998069332170", "AQAAAAEAACcQAAAAEPY7BZ2A9YWjxZgJr+zE1JoYPRZqnqARY+Rvn3zQ1F4eFogwiOux9hhyAbE/hpCWbQ==", "619c8912-0629-42cd-a440-efd510df545b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed1bace-33a7-4760-b45a-8eaf3976dd99", "AQAAAAEAACcQAAAAEO13U1u7RWDx3Sx+hmkLNd+0hwVfZbntfkRoeUvsnZk/+ZulUTyL1ALtWoZxujiIJw==", "c99abd30-c548-4506-b3c1-847450fa50a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5cb94dc-ec1a-40c8-8bdd-86a12b723941", "AQAAAAEAACcQAAAAEKUW4lVjR/waE2IHxbLWvLatlkOS4HR8qsv1oB20tUhNnXHZCvA50C3VXyG44JnHtw==", "cdef522a-1b9b-4ef5-8df4-8e086f71fb7d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e7f064c-57d1-4989-b0ed-0e6e4a4ce58e", "AQAAAAEAACcQAAAAEJomiRZcaqSePdk7Oh3UXWGiDkcXbmapxabc0hlJThH2ZrZ6uo1jWq5mS6fc5CK8ag==", "5092ce38-e7bb-4f4d-bd8b-b7bcf60b1b0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27e152fa-f0e2-4d6d-b3a4-f0df1be8324d", "AQAAAAEAACcQAAAAEEtWhyP63zSGGa5+P9vg8Wsv+908/q41yq5yv0BTaf6pKZTcV9BGQ4mn7chGxX8bBw==", "9c67800a-0fe7-4386-b945-b11f435aeef5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4941f0f-f936-4ed9-bc5e-3e788ebbfe5a", "AQAAAAEAACcQAAAAEEZ1pMQQIev+XqF3ghtGj/hjYUMAvpCHqfceWj37ea+TefaKLWVTSyBpyaPTp5I4Ew==", "2844f269-419b-47cb-baaa-521452d485d1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Area",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "BuldingNumber",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Advertisements");

            migrationBuilder.DropColumn(
                name: "Governorate",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Advertisements",
                newName: "Address");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f61b5337-7c93-4b0c-86d9-595eac6873c9", "AQAAAAEAACcQAAAAEOnv6Csag4qd6LvTiuAHbbTwIwYj4qSIIxSd8Ontq3/bb2GCpvIgPERIHjrXUjgGPA==", "21a84bcf-661b-4327-acf8-452d3f61843c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "805f60c2-78b4-4172-9b32-0ba3c786c966", "AQAAAAEAACcQAAAAEHCjLdv288ooDFHr2RAhbx+5AgqawsM3UJDLv5zkLMXh4qF1ILEPceCrNaFERgg3LA==", "13fd7d9e-6b1e-4918-b506-205f1d728c18" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d67d04-8bd0-4437-80b9-0d67f53e65dc", "AQAAAAEAACcQAAAAECpjjBFjrn7If6La9uoo0Qz4YS4GdWceo4QNRJ4azqJqhh4fs+dAgUGfbQqwQZupUw==", "87cc2700-2ed4-4e79-a507-1a20eb706eb2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6a51a5d-1e88-4163-96ab-5b5b4edfdc6b", "AQAAAAEAACcQAAAAEBCS6h5Xs1n6RLb3Z2Lg5kaqq2lVyD4H70StpZVLO76M35z0BvzZm37u/QPYVRIJYg==", "f07a6560-883d-4d7c-bd99-d88b73b007aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c814e6a-da4e-4d09-b3c3-0a4df1922b90", "AQAAAAEAACcQAAAAEGtXOCM4llNH24R5dDqVDDsMKcOw2uaE2Dgbs5Rukbvz7AoFl0qeBSbzdJ6Xhoqxkw==", "d176a5e0-46ac-45e3-9f5b-4f3f30cee584" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c85c27-a75f-4398-8c1c-6822a35a9ab9", "AQAAAAEAACcQAAAAEOvXBZh3w03KUGfvqKJBKO+H3vJ6PfmofrSMD2/Xb/dIdd1qZBDi7zaLgxX5wTGHVg==", "09303b9e-54b9-45fa-8332-73e22a6e2d16" });
        }
    }
}
