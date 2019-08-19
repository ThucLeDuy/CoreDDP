using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDD.Migrations
{
    public partial class addDbSetinjectforProductInvoiceInvoice_detailStore_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoice_Employees_EmployeeId",
                table: "Invoice");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_Invoice_InvoiceId",
                table: "InvoiceDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetail_Products_ProductId",
                table: "InvoiceDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetail",
                table: "InvoiceDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceDetail",
                newName: "InvoiceDetails");

            migrationBuilder.RenameTable(
                name: "Invoice",
                newName: "Invoices");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_ProductId",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetail_InvoiceId",
                table: "InvoiceDetails",
                newName: "IX_InvoiceDetails_InvoiceId");

            migrationBuilder.RenameIndex(
                name: "IX_Invoice_EmployeeId",
                table: "Invoices",
                newName: "IX_Invoices_EmployeeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetails",
                table: "InvoiceDetails",
                column: "Id_Invoice");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "StoreUsers",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(type: "nvarchar(250)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime", nullable: false),
                    Phonenumber = table.Column<string>(type: "varchar(50)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(550)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(750)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreUsers", x => x.UserId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetails_Products_ProductId",
                table: "InvoiceDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Employees_EmployeeId",
                table: "Invoices",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_StoreUsers_UserId",
                table: "Invoices",
                column: "UserId",
                principalTable: "StoreUsers",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Invoices_InvoiceId",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_InvoiceDetails_Products_ProductId",
                table: "InvoiceDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Employees_EmployeeId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_StoreUsers_UserId",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "StoreUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Invoices",
                table: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_UserId",
                table: "Invoices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InvoiceDetails",
                table: "InvoiceDetails");

            migrationBuilder.RenameTable(
                name: "Invoices",
                newName: "Invoice");

            migrationBuilder.RenameTable(
                name: "InvoiceDetails",
                newName: "InvoiceDetail");

            migrationBuilder.RenameIndex(
                name: "IX_Invoices_EmployeeId",
                table: "Invoice",
                newName: "IX_Invoice_EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_ProductId",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_InvoiceDetails_InvoiceId",
                table: "InvoiceDetail",
                newName: "IX_InvoiceDetail_InvoiceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Invoice",
                table: "Invoice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InvoiceDetail",
                table: "InvoiceDetail",
                column: "Id_Invoice");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoice_Employees_EmployeeId",
                table: "Invoice",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_Invoice_InvoiceId",
                table: "InvoiceDetail",
                column: "InvoiceId",
                principalTable: "Invoice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_InvoiceDetail_Products_ProductId",
                table: "InvoiceDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
