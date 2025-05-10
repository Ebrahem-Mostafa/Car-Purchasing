using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class updateAdvertisementClass3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ManufacturingYear",
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
                value: "796be9b3-c2be-4a54-8be9-6fb50ad81db5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "80aec4c2-aa16-4768-9d93-a7a8f16b05c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6611cb81-68d7-4c86-9b86-c452433f7c6d", "AQAAAAEAACcQAAAAEJNV+6dxk1MdvkIaykwyTXPgv+gEHyUxsuE+fv7kww2Za9U2J2a1jExvd9OXr4oI+A==", "8854ecd2-806f-483a-b877-10ca4d2e5d8d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73183d0a-df71-4d12-b83a-ea8f9e4cdc62", "AQAAAAEAACcQAAAAEMzc2nBXzu55CRI6YcJh94QcKN5/sCvFpre7TJwxzlvtIU28JcGOT5Ke5nS1l1xqNA==", "3e361ee8-3460-49a4-a3e0-ab1acaa4108d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9c0c7eb-6272-40b6-9c15-aa0f40125a34", "AQAAAAEAACcQAAAAEE150cOemX091esWHp00aI/remhog7NkHBpQFWn1IW+tR5azSOPfXqr+iErn6oLqPA==", "6b9d013f-7211-4d29-bbd0-6043df084ed1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f436f6-e5fe-46a9-b90a-3995be47e9e1", "AQAAAAEAACcQAAAAEKnHyFZgAEhj+COBkFGxt/UZC2u5i5TlAKLo87eS2JPOgqRbsWuw4vZwjIzSVBf8oQ==", "aba7eb77-8858-4d4d-b940-5624df630988" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5339721b-b993-4a4b-a307-b0447f1496d4", "AQAAAAEAACcQAAAAEDvis/DL9Gq8IXA61HZpE57lfKflWdgspR3DbkbfhM552j1iJ3ugqHouAUP0Ae03KQ==", "e12869dc-4f73-4645-a3ae-5b25edbaed0c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4745a3c1-cad6-4b55-8fb8-cdd386acf892", "AQAAAAEAACcQAAAAEI9H5oE1A+ESTIYVQ3YMroOy73U2BAumlhO051IqUDj9XsZxAmxlsk7+bP8KH5dHcw==", "d0d2c452-e038-4dde-ac8a-3034622eac49" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ManufacturingYear",
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
    }
}
