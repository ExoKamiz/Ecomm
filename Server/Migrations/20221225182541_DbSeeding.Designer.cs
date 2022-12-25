﻿// <auto-generated />
using Ecomm.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ecomm.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20221225182541_DbSeeding")]
    partial class DbSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ecomm.Shared.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductsC");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "70% wool / 30% polyester. The Pork Pie from Stetson deliberately dispenses with elaborate details.",
                            ImageUrl = "https://hatroom.pl/images/zoom/802970.jpg",
                            Price = 99.99m,
                            Title = "Uni Pork Pie Wool Hat"
                        },
                        new
                        {
                            Id = 2,
                            Description = "50% wool / 50% polyester. Fully lined. Unisex model.",
                            ImageUrl = "https://www.crafters.fr/images/stories/virtuemart/tt2016/PS_B635_GREY.jpg",
                            Price = 75.5m,
                            Title = "Chapeau Urban Trilby Grey"
                        },
                        new
                        {
                            Id = 3,
                            Description = "89% paper fiber / 11% polyester - 6cm brim - Supplied with removable black fabric strip.",
                            ImageUrl = "https://images.crafters.fr/bo/16951_60b0a8a70fd08_PS_KP068_NATURAL.png",
                            Price = 59.99m,
                            Title = "Chapeau Panama Natural"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
