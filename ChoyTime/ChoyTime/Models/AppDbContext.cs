
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChoyTime.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set;}
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 1, CategoryName = "Main Meals" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 2, CategoryName = "Appetizers" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 3, CategoryName = "Desserts" });
            modelBuilder.Entity<Category>().HasData(new Category { CategoryId = 4, CategoryName = "Drinks" });

            //seed pies

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 1,
                Name = "Steak",
                Price = 12.95M,
                ShortDescription = "Our famous T-Bones!",
                LongDescription = "Cooked to your specifications!",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                InStock = true,
                DishOfTheWeek = true,
                ImageThumbnailUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 2,
                Name = "Cheese Burger",
                Price = 18.95M,
                ShortDescription = "Juicy and cooked to perfection!",
                LongDescription = "An American classic! Served with bacon and a pickle as well",
                CategoryId = 1,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 3,
                Name = "Chips & Salsa",
                Price = 18.95M,
                ShortDescription = "House-made to order!",
                LongDescription = "You can always sub the salsa for queso!",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 4,
                Name = "Wings",
                Price = 18.95M,
                ShortDescription = "Crispy and covered in BBQ!",
                LongDescription = "The selection is a little sparse but they are sure to please all",
                CategoryId = 2,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                    "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 5,
                Name = "Mousse",
                Price = 18.95M,
                ShortDescription = "It ain't no meese!",
                LongDescription = "Seriously it ain't no meese, it's a chocolate paste",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                  "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 6,
                Name = "Cookie",
                Price = 18.95M,
                ShortDescription = "Plain and simple!",
                LongDescription = "Good ole fashioned chocolate chio cookie",
                CategoryId = 3,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                 "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 7,
                Name = "Coffee",
                Price = 18.95M,
                ShortDescription = "It's Bustelo...",
                LongDescription = "The staple coffee stand of the UCF Student Union!",
                CategoryId = 4,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                 "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

            modelBuilder.Entity<Dish>().HasData(new Dish
            {
                DishId = 8,
                Name = "Soda",
                Price = 18.95M,
                ShortDescription = "Coke Products",
                LongDescription = "Coke, Sprite, Lemonade and Dr. Pepper",
                CategoryId = 4,
                ImageUrl = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                InStock = true,
                DishOfTheWeek = false,
                ImageThumbnailUrl =
                 "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                AllergyInformation = ""
            });

        }
}
}
