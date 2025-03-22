﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StoreApp.Data.Conrete;

#nullable disable

namespace StoreApp.Web.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("StoreApp.Data.Conrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("Url")
                        .IsUnique();

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Telefon",
                            Url = "telefon"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Bilgisayar",
                            Url = "bilgisayar"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Elektronik",
                            Url = "elektronik"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Beyaz Esya",
                            Url = "beyaz-esya"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Moda",
                            Url = "moda"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Kitap",
                            Url = "kitap"
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Conrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "guzel telefon",
                            Name = "Samsung S24",
                            Price = 40000m
                        },
                        new
                        {
                            Id = 2,
                            Description = "guzel telefon",
                            Name = "Samsung S25",
                            Price = 50000m
                        },
                        new
                        {
                            Id = 3,
                            Description = "guzel telefon",
                            Name = "Samsung S26",
                            Price = 60000m
                        },
                        new
                        {
                            Id = 4,
                            Description = "guzel telefon",
                            Name = "Samsung S27",
                            Price = 70000m
                        },
                        new
                        {
                            Id = 5,
                            Description = "guzel telefon",
                            Name = "Samsung S28",
                            Price = 80000m
                        },
                        new
                        {
                            Id = 6,
                            Description = "guzel telefon",
                            Name = "Samsung S29",
                            Price = 90000m
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Conrete.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProductId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 3
                        },
                        new
                        {
                            CategoryId = 1,
                            ProductId = 4
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 5
                        },
                        new
                        {
                            CategoryId = 2,
                            ProductId = 6
                        });
                });

            modelBuilder.Entity("StoreApp.Data.Conrete.ProductCategory", b =>
                {
                    b.HasOne("StoreApp.Data.Conrete.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StoreApp.Data.Conrete.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
