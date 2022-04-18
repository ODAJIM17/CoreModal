﻿// <auto-generated />
using System;
using CoreModal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreModal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220417140443_InitialDB")]
    partial class InitialDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sales_Mgmt.Common.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("VARCHAR(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("VARCHAR(20)");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("VARCHAR(70)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("VARCHAR(30)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("InputBy")
                        .HasColumnType("VARCHAR(70)");

                    b.Property<DateTime?>("InputDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(30)");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("VARCHAR(70)");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("VARCHAR(2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("VARCHAR(15)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("VARCHAR(6)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
