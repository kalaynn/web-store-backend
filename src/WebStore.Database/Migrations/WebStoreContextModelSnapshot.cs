﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebStore.Database;

#nullable disable

namespace WebStore.Database.Migrations
{
    [DbContext(typeof(WebStoreContext))]
    partial class WebStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("WebStore.Core.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

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
                            Id = new Guid("675a1baf-627f-41a1-944f-bd79f1a17a45"),
                            Category = "food",
                            Description = "Premium, delicious, kibble made from free range, grass-fed horses. 1 kilogram of kibble.",
                            Name = "Dry Food",
                            Price = 12.34m
                        },
                        new
                        {
                            Id = new Guid("b441d184-dad8-4dd2-a51c-87237626d5a2"),
                            Category = "food",
                            Description = "Wet Food",
                            Name = "Hearty, chunky, pieces of 84% mercury-free tuna. 1 kilogram of wet food.",
                            Price = 23.45m
                        },
                        new
                        {
                            Id = new Guid("7f7dbbbe-c233-4883-a2d8-4dc1b79f97dd"),
                            Category = "food",
                            Description = "It's rainbows and unicorns with our most luxury wet food - literally! Made from 100% queer horse/narwhal hybrids. 1 kilogram of wet food.",
                            Name = "Superpremium Wet Food",
                            Price = 34.56m
                        },
                        new
                        {
                            Id = new Guid("93cff757-4e73-4cdc-9b82-301487279973"),
                            Category = "accessories",
                            Description = "Have your cat eat in style out of this 100% titanium Legacy™ branded food bowl!",
                            Name = "Legacy™ Cat Food Bowl",
                            Price = 45.67m
                        },
                        new
                        {
                            Id = new Guid("56fbbf63-72a6-4b90-9e20-a4ded12023ca"),
                            Category = "accessories",
                            Description = "Have your cat bother the robot instead of you in the morning! Connect the Legacy™ Automated Cat Feeder to your stupid home IoT network for extra functionality. Singularity kill-switch sold separately.",
                            Name = "Legacy™ Automated Cat Feeder",
                            Price = 56.78m
                        },
                        new
                        {
                            Id = new Guid("d030401f-a23d-4dfb-b9ed-e4dbb5592229"),
                            Category = "medical",
                            Description = "Say \"no\" to painful teeth cleanings, and \"Yes!\" to Beigies™ feline dental treats! Pack of 24.",
                            Name = "Beigies™ Rodent-Shaped Dental Treats",
                            Price = 67.89m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}