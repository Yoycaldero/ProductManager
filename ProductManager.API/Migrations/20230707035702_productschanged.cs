using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductManager.API.Migrations
{
    /// <inheritdoc />
    public partial class productschanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Products",
                newName: "Price3");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "Image3");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Products",
                newName: "Image2");

            migrationBuilder.AddColumn<string>(
                name: "Description1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description2",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description3",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Image1",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price1",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Price2",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description2",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Description3",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Image1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price1",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Price2",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Price3",
                table: "Products",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Image3",
                table: "Products",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "Image2",
                table: "Products",
                newName: "Description");
        }
    }
}
