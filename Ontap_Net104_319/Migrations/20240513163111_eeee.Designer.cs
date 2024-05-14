﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ontap_Net104_319.Models;

#nullable disable

namespace Ontap_Net104_319.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240513163111_eeee")]
    partial class eeee
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Ontap_Net104_319.Models.Account", b =>
                {
                    b.Property<string>("Username")
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(true)
                        .HasColumnType("nchar(256)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("varchar(450)")
                        .HasColumnName("MatKhau");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Buil", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Money")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Usename")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Usename");

                    b.ToTable("buils");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.BuilDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BuillId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ProductID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BuillId");

                    b.HasIndex("ProductID");

                    b.ToTable("builDetails");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Cart", b =>
                {
                    b.Property<string>("UseName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("UseName");

                    b.ToTable("carts");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.CartDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Usename")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("Usename");

                    b.ToTable("cartDetails");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("products");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Account", b =>
                {
                    b.HasOne("Ontap_Net104_319.Models.Cart", "Cart")
                        .WithOne("Account")
                        .HasForeignKey("Ontap_Net104_319.Models.Account", "Username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Buil", b =>
                {
                    b.HasOne("Ontap_Net104_319.Models.Account", "Account")
                        .WithMany("Buils")
                        .HasForeignKey("Usename")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.BuilDetail", b =>
                {
                    b.HasOne("Ontap_Net104_319.Models.Buil", "Buil")
                        .WithMany("Details")
                        .HasForeignKey("BuillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ontap_Net104_319.Models.Product", "Product")
                        .WithMany("BuilDetails")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buil");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.CartDetail", b =>
                {
                    b.HasOne("Ontap_Net104_319.Models.Product", "Product")
                        .WithMany("Cartdetails")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ontap_Net104_319.Models.Cart", "Cart")
                        .WithMany("CartDetails")
                        .HasForeignKey("Usename")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Account", b =>
                {
                    b.Navigation("Buils");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Buil", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Cart", b =>
                {
                    b.Navigation("Account")
                        .IsRequired();

                    b.Navigation("CartDetails");
                });

            modelBuilder.Entity("Ontap_Net104_319.Models.Product", b =>
                {
                    b.Navigation("BuilDetails");

                    b.Navigation("Cartdetails");
                });
#pragma warning restore 612, 618
        }
    }
}