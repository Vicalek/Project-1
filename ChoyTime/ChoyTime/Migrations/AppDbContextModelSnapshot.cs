﻿// <auto-generated />
using System;
using ChoyTime.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChoyTime.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChoyTime.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Main Meals"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Appetizers"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Desserts"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Drinks"
                        });
                });

            modelBuilder.Entity("ChoyTime.Models.Dish", b =>
                {
                    b.Property<int>("DishId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("DishOfTheWeek")
                        .HasColumnType("bit");

                    b.Property<string>("ImageThumbnailUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("InStock")
                        .HasColumnType("bit");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DishId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Dishes");

                    b.HasData(
                        new
                        {
                            DishId = 1,
                            AllergyInformation = "",
                            CategoryId = 1,
                            DishOfTheWeek = true,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            InStock = true,
                            LongDescription = "Cooked to your specifications!",
                            Name = "Steak",
                            Price = 12.95m,
                            ShortDescription = "Our famous T-Bones!"
                        },
                        new
                        {
                            DishId = 2,
                            AllergyInformation = "",
                            CategoryId = 1,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "An American classic! Served with bacon and a pickle as well",
                            Name = "Cheese Burger",
                            Price = 18.95m,
                            ShortDescription = "Juicy and cooked to perfection!"
                        },
                        new
                        {
                            DishId = 3,
                            AllergyInformation = "",
                            CategoryId = 2,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "You can always sub the salsa for queso!",
                            Name = "Chips & Salsa",
                            Price = 18.95m,
                            ShortDescription = "House-made to order!"
                        },
                        new
                        {
                            DishId = 4,
                            AllergyInformation = "",
                            CategoryId = 2,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "The selection is a little sparse but they are sure to please all",
                            Name = "Wings",
                            Price = 18.95m,
                            ShortDescription = "Crispy and covered in BBQ!"
                        },
                        new
                        {
                            DishId = 5,
                            AllergyInformation = "",
                            CategoryId = 3,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "Seriously it ain't no meese, it's a chocolate paste",
                            Name = "Mousse",
                            Price = 18.95m,
                            ShortDescription = "It ain't no meese!"
                        },
                        new
                        {
                            DishId = 6,
                            AllergyInformation = "",
                            CategoryId = 3,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "Good ole fashioned chocolate chio cookie",
                            Name = "Cookie",
                            Price = 18.95m,
                            ShortDescription = "Plain and simple!"
                        },
                        new
                        {
                            DishId = 7,
                            AllergyInformation = "",
                            CategoryId = 4,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "The staple coffee stand of the UCF Student Union!",
                            Name = "Coffee",
                            Price = 18.95m,
                            ShortDescription = "It's Bustelo..."
                        },
                        new
                        {
                            DishId = 8,
                            AllergyInformation = "",
                            CategoryId = 4,
                            DishOfTheWeek = false,
                            ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            InStock = true,
                            LongDescription = "Coke, Sprite, Lemonade and Dr. Pepper",
                            Name = "Soda",
                            Price = 18.95m,
                            ShortDescription = "Coke Products"
                        });
                });

            modelBuilder.Entity("ChoyTime.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(25)")
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ChoyTime.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("DishId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("DishId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ChoyTime.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int?>("DishId")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("DishId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("ChoyTime.Models.Dish", b =>
                {
                    b.HasOne("ChoyTime.Models.Category", "Category")
                        .WithMany("Dishes")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChoyTime.Models.OrderDetail", b =>
                {
                    b.HasOne("ChoyTime.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ChoyTime.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ChoyTime.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ChoyTime.Models.Dish", "Dish")
                        .WithMany()
                        .HasForeignKey("DishId");
                });
#pragma warning restore 612, 618
        }
    }
}