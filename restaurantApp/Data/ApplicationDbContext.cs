using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using restaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurantApp.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {

        }
        public DbSet<AddOn> AddOns { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<ItemIngredient> ItemIngredients { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }
        public DbSet<OrderItemAddOn> OrderItemAddOns { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AddOn>().HasData(
            new AddOn() { Id = 1, Name = "Extra spicy", Price = 0 },
            new AddOn() { Id = 2, Name = "Extra chicken", Price = 1 },
            new AddOn() { Id = 3, Name = "Extra Broccoli", Price = (decimal)0.50 }
                );
            builder.Entity<Category>().HasData(
                 new Category() { Id = 1, Name = "Appetizer" },
                 new Category() { Id = 2, Name = "Main Dish" },
                 new Category() { Id = 3, Name = "Dessert" }
                );
            builder.Entity<Ingredient>().HasData(
                 new Ingredient() { Id = 1, Name = "Broccoli" },
                 new Ingredient() { Id = 2, Name = "Chicken" },
                 new Ingredient() { Id = 3, Name = "Ketchup" }
                );
            builder.Entity<Item>().HasData(
                new Item() { Id = 1, Name = "Chicken and broccoli",  ImageUrl = "https://selecthealth.org/-/media/selecthealth/blogs/post/2020/10/chicken_broccoli_blog_lg.ashx?h=533&w=800", Description = "Chicken and broccoli stir fry.", CategoryId = 2 },
                new Item() { Id = 2, Name = "Fried Shrimp", ImageUrl = "https://s4i9q7n8.rocketcdn.me/wordpress/wp-content/uploads/2016/05/Mrs-Fridays-Pouch-Butterfly-011230-1192x542.jpg", Description = "Fried jumbo shrimp", CategoryId = 1 },
                new Item() { Id = 3, Name = "Ice Cream Cake", ImageUrl = "https://goldbelly.imgix.net/uploads/showcase_media_asset/image/96109/chocolate-buttercream-frosting-cake.0e9d3271850adca83740d049c1777048.jpg?ixlib=react-9.0.2&auto=format&ar=1%3A1&w=1946", Description = "Cake made with Ice cream", CategoryId = 3 }
                    );
            builder.Entity<ItemIngredient>().HasData(
                 new ItemIngredient() { Id = 1, ItemId = 1, IngredientId = 1 },
                 new ItemIngredient() { Id = 2, ItemId = 1, IngredientId = 2 },
                 new ItemIngredient() { Id = 3, ItemId = 2, IngredientId = 3 }
                );
            builder.Entity<Size>().HasData(
             new Size() { Id = 1, Name = "Small" },
             new Size() { Id = 2, Name = "Median" },
             new Size() { Id = 3, Name = "Large" }
            );
            builder.Entity<ItemSize>().HasData(
     new ItemSize() { Id = 1, ItemId = 1, SizeId = 3, Price = (decimal)8.5 },
     new ItemSize() { Id = 2, ItemId = 2, SizeId = 2, Price = (decimal)5.5 },
     new ItemSize() { Id = 3, ItemId = 3, SizeId = 1, Price = (decimal)3.5 }
    );
        }
    }
}