﻿// <auto-generated />
using System;
using CoreDD.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDD.Migrations
{
    [DbContext(typeof(DBFoodContext))]
    [Migration("20190819074828_add invoice & invoice_detail, add constraint for product, Store_User, Emp")]
    partial class addinvoiceinvoice_detailaddconstraintforproductStore_UserEmp
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDD.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal?>("BaseSalary")
                        .HasColumnType("money");

                    b.Property<string>("EmpCode")
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime>("HireDate")
                        .HasColumnType("datetime");

                    b.Property<string>("OfficeLocation")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Position")
                        .HasColumnType("varchar(100)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CoreDD.Models.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(550)");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("datetime");

                    b.Property<decimal?>("Total")
                        .HasColumnType("money");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Invoice");
                });

            modelBuilder.Entity("CoreDD.Models.InvoiceDetail", b =>
                {
                    b.Property<int>("Id_Invoice")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("InvoiceId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id_Invoice");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("InvoiceDetail");
                });

            modelBuilder.Entity("CoreDD.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(550)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(550)");

                    b.Property<string>("ProductCategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("ProductCategory_ID");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal?>("SalePrice")
                        .HasColumnType("money");

                    b.Property<int?>("TimesBooked")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductCategory_ID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("CoreDD.Models.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategory_ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PD_Description")
                        .HasColumnType("varchar(250)");

                    b.Property<string>("PD_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("ProductCategory_ID");

                    b.ToTable("ProductCategories");
                });

            modelBuilder.Entity("CoreDD.Models.Invoice", b =>
                {
                    b.HasOne("CoreDD.Models.Employee")
                        .WithMany("Invoices")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreDD.Models.InvoiceDetail", b =>
                {
                    b.HasOne("CoreDD.Models.Invoice")
                        .WithMany("InvoicesDetails")
                        .HasForeignKey("InvoiceId");

                    b.HasOne("CoreDD.Models.Product")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CoreDD.Models.Product", b =>
                {
                    b.HasOne("CoreDD.Models.ProductCategory")
                        .WithMany("Products")
                        .HasForeignKey("ProductCategory_ID");
                });
#pragma warning restore 612, 618
        }
    }
}
