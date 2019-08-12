using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDD.Migrations
{
    public partial class addproductcategoryname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "ProductCategory",
                table: "Products",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "PD_Name",
                table: "ProductCategories",
                type: "nvarchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "Products");

            migrationBuilder.AlterColumn<string>(
                name: "PD_Name",
                table: "ProductCategories",
                type: "varchar(150)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Employees",
                type: "nvarchar(250)",
                nullable: false,
                defaultValue: "");
        }
    }
}
