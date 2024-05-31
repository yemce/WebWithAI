﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories;

#nullable disable

namespace Api.Migrations
{
    [DbContext(typeof(RepositoryContext))]
    [Migration("20240106082020_Start")]
    partial class Start
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AtCreatedDate")
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
                            AtCreatedDate = new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3782),
                            Name = "Laptop",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 2,
                            AtCreatedDate = new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3809),
                            Name = "Smartphone",
                            Price = 800m
                        },
                        new
                        {
                            Id = 3,
                            AtCreatedDate = new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3810),
                            Name = "Headphones",
                            Price = 100m
                        },
                        new
                        {
                            Id = 4,
                            AtCreatedDate = new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3811),
                            Name = "Tablet",
                            Price = 600m
                        },
                        new
                        {
                            Id = 5,
                            AtCreatedDate = new DateTime(2024, 1, 6, 11, 20, 20, 575, DateTimeKind.Local).AddTicks(3812),
                            Name = "Smartwatch",
                            Price = 300m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
