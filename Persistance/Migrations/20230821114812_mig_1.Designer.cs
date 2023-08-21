﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance.Contexts;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(CatalogAPIDbContext))]
    [Migration("20230821114812_mig_1")]
    partial class mig_1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CatalogAPI.Domain.Entities.Common.BaseEntitiy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BaseEntities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntitiy");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("CatalogAPI.Domain.Entities.Category", b =>
                {
                    b.HasBaseType("CatalogAPI.Domain.Entities.Common.BaseEntitiy");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("Category");
                });

            modelBuilder.Entity("CatalogAPI.Domain.Entities.Product", b =>
                {
                    b.HasBaseType("CatalogAPI.Domain.Entities.Common.BaseEntitiy");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("StockStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CategoryId");

                    b.ToTable("BaseEntities", t =>
                        {
                            t.Property("CategoryId")
                                .HasColumnName("Product_CategoryId");

                            t.Property("Description")
                                .HasColumnName("Product_Description");
                        });

                    b.HasDiscriminator().HasValue("Product");
                });

            modelBuilder.Entity("CatalogAPI.Domain.Entities.Category", b =>
                {
                    b.HasOne("CatalogAPI.Domain.Entities.Category", null)
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("CatalogAPI.Domain.Entities.Product", b =>
                {
                    b.HasOne("CatalogAPI.Domain.Entities.Category", null)
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("CatalogAPI.Domain.Entities.Category", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("SubCategories");
                });
#pragma warning restore 612, 618
        }
    }
}
