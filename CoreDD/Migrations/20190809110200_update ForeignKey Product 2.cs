using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDD.Migrations
{
    public partial class updateForeignKeyProduct2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCategory_ID",
                table: "Products",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategory_ID",
                table: "Products",
                column: "ProductCategory_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_ProductCategory_ID",
                table: "Products",
                column: "ProductCategory_ID",
                principalTable: "ProductCategories",
                principalColumn: "ProductCategory_ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_ProductCategory_ID",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductCategory_ID",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductCategory_ID",
                table: "Products");
        }
    }
}
