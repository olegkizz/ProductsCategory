﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProductCategory2.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240507213421_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.Property<int>("CategoriesId")
                        .HasColumnType("int");

                    b.Property<int>("ProductsId")
                        .HasColumnType("int");

                    b.HasKey("CategoriesId", "ProductsId");

                    b.HasIndex("ProductsId");

                    b.ToTable("CategoryProduct");
                });

            modelBuilder.Entity("ProductsCategory.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Fructs"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Electronic"
                        },
                        new
                        {
                            Id = 3,
                            Name = "House"
                        },
                        new
                        {
                            Id = 4,
                            Name = "NFT"
                        });
                });

            modelBuilder.Entity("ProductsCategory.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Apple"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Lemon"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cucumber"
                        },
                        new
                        {
                            Id = 4,
                            Name = "TV"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Telephone"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Pacmoon"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Ape"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Gold"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Cat"
                        });
                });

            modelBuilder.Entity("CategoryProduct", b =>
                {
                    b.HasOne("ProductsCategory.Entities.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ProductsCategory.Entities.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
