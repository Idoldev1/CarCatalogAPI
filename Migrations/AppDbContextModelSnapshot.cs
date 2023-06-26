﻿// <auto-generated />
using System;
using FirstWebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FirstWebAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.4");

            modelBuilder.Entity("FirstWebAPI.Models.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CountryMade")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DateManufactured")
                        .HasColumnType("TEXT");

                    b.Property<string>("Maker")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Seaters")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Brand = "Honda",
                            CountryMade = "Japan",
                            DateManufactured = new DateTime(2001, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Honda Motor Co. Ltd",
                            Name = "Honda Civic",
                            Quantity = 17,
                            Seaters = 5
                        },
                        new
                        {
                            Id = 2,
                            Brand = "Ford",
                            CountryMade = "United States",
                            DateManufactured = new DateTime(1993, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Ford Motor Co.",
                            Name = "Ford Mustang",
                            Quantity = 10,
                            Seaters = 4
                        },
                        new
                        {
                            Id = 3,
                            Brand = "Toyota",
                            CountryMade = "Japan",
                            DateManufactured = new DateTime(2004, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Toyota Motor Co.",
                            Name = "Toyota Camry",
                            Quantity = 7,
                            Seaters = 5
                        },
                        new
                        {
                            Id = 4,
                            Brand = "Bayerische Motoren Werke AG",
                            CountryMade = "Germany",
                            DateManufactured = new DateTime(1990, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "BMW",
                            Name = "BMW 3 Series",
                            Quantity = 7,
                            Seaters = 5
                        },
                        new
                        {
                            Id = 5,
                            Brand = "Chevrolet",
                            CountryMade = "United States",
                            DateManufactured = new DateTime(2000, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "General Motors Company",
                            Name = "Chevrolet Silverado",
                            Quantity = 18,
                            Seaters = -1
                        },
                        new
                        {
                            Id = 6,
                            Brand = "Mercedes-Benz",
                            CountryMade = "Germany",
                            DateManufactured = new DateTime(2010, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Daimler AG",
                            Name = "Mercedes Benz E-Class",
                            Quantity = 12,
                            Seaters = 4
                        },
                        new
                        {
                            Id = 7,
                            Brand = "Hyundai",
                            CountryMade = "South Korea",
                            DateManufactured = new DateTime(2012, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Hyundai Motor Co.",
                            Name = "Hyundai Sonata",
                            Quantity = 18,
                            Seaters = 5
                        },
                        new
                        {
                            Id = 8,
                            Brand = "Volkswagen",
                            CountryMade = "Germany",
                            DateManufactured = new DateTime(2020, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Volkswagen AG",
                            Name = "Volkswagen Golf",
                            Quantity = 7,
                            Seaters = 4
                        },
                        new
                        {
                            Id = 9,
                            Brand = "Nissan",
                            CountryMade = "Japan",
                            DateManufactured = new DateTime(2016, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Nissan Motor Co. Ltd.",
                            Name = "Nissan Rogue",
                            Quantity = 20,
                            Seaters = 5
                        },
                        new
                        {
                            Id = 10,
                            Brand = "Audi",
                            CountryMade = "Germany",
                            DateManufactured = new DateTime(2019, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Maker = "Audi AG",
                            Name = "Audi A4",
                            Quantity = 4,
                            Seaters = 5
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
