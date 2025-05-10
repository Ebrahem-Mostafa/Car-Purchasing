using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CarSystem.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "price",
                table: "Advertisements",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Advertisements",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "manufacturingYear",
                table: "Advertisements",
                newName: "ManufacturingYear");

            migrationBuilder.RenameColumn(
                name: "licenceExpirationDate",
                table: "Advertisements",
                newName: "LicenceExpirationDate");

            migrationBuilder.RenameColumn(
                name: "carName",
                table: "Advertisements",
                newName: "CarName");

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Advertisements",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Advertisements");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Advertisements",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Advertisements",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "ManufacturingYear",
                table: "Advertisements",
                newName: "manufacturingYear");

            migrationBuilder.RenameColumn(
                name: "LicenceExpirationDate",
                table: "Advertisements",
                newName: "licenceExpirationDate");

            migrationBuilder.RenameColumn(
                name: "CarName",
                table: "Advertisements",
                newName: "carName");
        }
    }
}
