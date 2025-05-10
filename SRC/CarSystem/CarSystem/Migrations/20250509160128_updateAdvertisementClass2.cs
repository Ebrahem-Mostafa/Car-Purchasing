using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class updateAdvertisementClass2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "BuldingNumber",
                table: "Advertisements",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0a0ba7a1-13d7-4a67-9890-d919ae85557e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7be00559-e32b-4e18-80df-742d79fb19b3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a53cd4c-36a7-46d7-af80-3016e1b01197", "AQAAAAEAACcQAAAAEOqAgL3wE9OxGInwRpSi6rFIE2uhM+hanl62tBtayyWDE5+BFDTJFxgw6wDunH8wNw==", "5e82f1cf-fb78-46ad-996f-2882dd7a0a7f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "963dc183-0177-45cd-a5e5-3eb8149d3df6", "AQAAAAEAACcQAAAAEJqkNGPs9twYDVnzUzY/G2kxUWMfb5j60ckI2fINdZOaIB5rwX/bbFP9sKfdteATew==", "336b9a0f-b546-4aa4-a156-749679e368d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "538a0c52-99f5-4868-8b43-856ccd6cbcbb", "AQAAAAEAACcQAAAAEG4nUx8W1BKRoywF+wqtnF8qUb+FlpRGfz2GC2ZqK5quhLfrx2ZV1yg6YZxmrtjtNw==", "8bc5c200-6847-4e87-b91d-d74076ffdfe4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c1d2c7-90cf-4de0-983e-cba72da4a926", "AQAAAAEAACcQAAAAEEqix1CVj4SubejB92zNSd2ngJ009TLi6czfc0YCBYXeeiH9Lkw2fQATHiGUgf0pCg==", "d0ec4508-39b9-4636-a288-edc051f8db0e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beed15b6-98fa-4a48-a7e1-f50627f853b5", "AQAAAAEAACcQAAAAEM8jvHNjMMmP4QyWgf9t8SeP1qClblLWbLd14HOLqC228oEKqniWM5P1dV8ubuVTjQ==", "324d4e7e-a6d3-479e-9527-cc878b575150" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b65437d2-b9e3-4371-a1cd-a235773c45c5", "AQAAAAEAACcQAAAAEDobxWc8awF8lKdzYTTIaPt4JI+UPx/Ih9/bw2/nwWfoJhWFrU5QXicw4/umS/GFBA==", "168618b5-c3a5-497b-b07a-48c91163d73f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "BuldingNumber",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
