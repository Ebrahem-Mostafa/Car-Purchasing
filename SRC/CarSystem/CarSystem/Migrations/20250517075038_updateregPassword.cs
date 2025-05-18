using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class updateregPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f52890f2-7b22-45a3-9268-421b81afe4c2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "79e98683-61e7-429f-9e55-53051be80c15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1817f86c-1979-4119-b50a-5fac56dc33ad", "AQAAAAEAACcQAAAAEIFY/S+jLLq3LN85zpShoBwjrkmMbInu6rO9ovQZ0xaqurJozmjCFFT4JfqYW8dlAg==", "ae34628a-a830-44b4-800c-3678bbd379fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18270e26-be36-4c78-a383-7f8c5b760c74", "AQAAAAEAACcQAAAAEEYaFRkI0Z1EyVRKnFNeM+uTAfmzgiyQuWPRNbHrl5TK6IAiFQlFS9y9GaV5i/3Vdw==", "1cf5ccf3-40f8-468a-8814-e446b29adb79" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c2c626b-20b1-4b40-b77f-ab0cf15aa7b8", "AQAAAAEAACcQAAAAEEJFPfSUAGvnG7EhGIEipAERa3R4jbFKFuQJ+D32JCZDBc2RcimREK+/4Z6ipWXn7Q==", "99c5d867-9088-4a00-935c-88327b3740b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd85ea15-b671-4733-9be1-2156ccfef0b5", "AQAAAAEAACcQAAAAEMdYFF5mN1TAW3gkBjZ2KkDlDiIXQRYDmtQ1qOIWDYuX4Dl5SYOiaGGoZPVRlmSwTA==", "cff9b3c4-1c55-4490-a4c9-b42ca5ebe07e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "114de9d1-0e7e-41cd-b8e3-7895332e67b3", "AQAAAAEAACcQAAAAEMfPxnuHbGJfAr6HZHSkPdkNd3AxfaNk2Tnv66CFH8HiRm1j90hqkYvUgGEvWvvi6w==", "1c3e092a-fdb0-479e-a9fb-e4f3d045aa91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e1dae62-9345-49dc-972a-a18da7f4262a", "AQAAAAEAACcQAAAAEGkTwDj4/gqTNh8V6mt5Dh1ZX1koG8KHSsEkdUC0jj+BO0GzI1X6UsdSt6G2gn6wKA==", "2c0bbe19-80f2-4fa5-9a59-91b434ff3dcd" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ad76ff1d-c83f-4f90-9ffd-0f6f5634aa01");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "7b5dbc03-3f7b-4ca1-9943-b6efc88cad28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b6cc8eb-1c08-4ab4-af3c-92b65ce31880", "AQAAAAEAACcQAAAAEBdr9aBSb3V0KKiLAcwQw8FPfukPWb0qeN4/uwvhxxhwr3lVNw9duduXLWuob1qXTQ==", "5a7de219-f623-45e5-8782-13ccb636aa99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b84d756d-4324-41c8-9276-51ae55576411", "AQAAAAEAACcQAAAAEBtPLK4BPt2arzWjaP3mrkQSa7ypK+C+RHliJSIrzYKGN263t6TibyhAVIKl4XjIXw==", "4e5b80e1-9f29-49bb-8818-3f2839c09513" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb693603-f135-4749-8f8c-c6511ce178f3", "AQAAAAEAACcQAAAAEAhWaYl95MUtQL2PAN3Yv05bK9ZoW74z8QQmvUSBwDdwvakLxsA9yVZHJkpeYO5GIw==", "26f57451-1735-46be-97bf-6dfc4c1850bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a39f5c36-413c-487b-906b-063524ca9702", "AQAAAAEAACcQAAAAEKM+8EIy05aswemfDGzQapJWd9U1UoItQ0Emd1X082L3DAmpGlMFlFy8v7sTZaBr+g==", "a2c0e2b8-85b1-404f-851b-c5b9319ce0a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db90ae83-c752-4cab-b203-48dfa78e6c99", "AQAAAAEAACcQAAAAELeZSHyIRvNCytD3GUdPWfiZrV/COR64y0LaxXFGe6INfdKPr5xq+8eWdtc/zwhiBg==", "7987fa6f-7eae-4435-ae91-aec8a1503e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f076e74c-876b-4e81-9299-c4d71f04b955", "AQAAAAEAACcQAAAAECdAG8uFJZj5ZYGefMybKi3tV6ctTKhAF4aC7eW+G8yAABalxMypeRuFaSql8yu8KQ==", "f5d812cf-9a11-4d40-88f8-a45fe176e147" });
        }
    }
}
