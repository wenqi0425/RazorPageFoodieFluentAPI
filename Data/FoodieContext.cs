using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using RazorPageFoodie.Models;

namespace RazorPageFoodie.Data
{
    public class FoodieContext : DbContext
    {
        public FoodieContext (DbContextOptions<FoodieContext> options)
            : base(options)
        {
        }

        // DbSet<EntityName> properties
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<DefaultUser> AppUsers { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Fluent API to map composite key of RecipeIngredient
            builder.Entity<RecipeIngredient>()
                .HasKey(r => new { r.RecipeId, r.IngredientId });

            // Seeding a 'Admin' role to AspNetRoles table
            builder.Entity<IdentityRole<int>>()
                .HasData(new IdentityRole<int>
                {
                    Id = 1,
                    Name = "Admin",
                    NormalizedName = "ADMIN".ToUpper()
                });

            // Password hasher
            //var hasher = new PasswordHasher<DefaultUser>();

            //Seeding the User to AspNetUsers table
            /*
            builder.Entity<DefaultUser>()
                .HasData(new DefaultUser
                {
                    Id = 1,
                    FirstName = "Wenqi",
                    LastName = "Huang",
                    Email = "wenqi100@gmail.com",
                    UserName = "Admin",
                    NormalizedUserName = "ADMIN",
                    NormalizedEmail = "WENQI100@GMAIL.COM",
                    SecurityStamp = Guid.NewGuid().ToString("D"),
                    PasswordHash = hasher.HashPassword(null, "Test123!"),
                    LockoutEnabled = true,
                });*/

            // Seeding the relation between the admin user and admin role to AspNetUserRoles table
            builder.Entity<IdentityUserRole<int>>().HasData(
                new IdentityUserRole<int>
                {
                    RoleId = 1,
                    UserId = 1
                });

            builder.Entity<Ingredient>()
                .HasData(

                new Ingredient
                {
                    Id = 1,
                    Name = "Lotus Rod",
                    Description = "Lotus Rod is an edible rhizome, a bulb from the flower of the same name that can be peeled, sliced, and eaten raw or cooked. It's an ancient ingredient used by emperors and villagers alike and proves so versatile, chefs have used the lotus root in salads and soups, in the main course, and also in many snack foods.",
                    ImageData = { }
                },

                new Ingredient
                {
                    Id = 2,
                    Name = "Pak Choi",
                    Description = "Dark green, large spoon-shaped leaves with wide, light green midribs and mild flavor. Pak Choi is also called as Shanghai Green forms densely packed, vase-like heads. Plants can be spaced closely for baby choi, which is in demand with chefs for its tenderness and mild flavor.",
                    ImageData = { }
                },

                new Ingredient
                {
                    Id = 3,
                    Name = "Shiitake",
                    Description = "Shiitake are rich in polysaccharides like lentinans and other beta-glucans. These compounds protect against cell damage, help your immune system, and boost white blood cell production for fighting off microbes. Polysaccharides also have anti-inflammatory properties.",
                    ImageData = { }
                },

                new Ingredient
                {
                    Id = 4,
                    Name = "Tofu",
                    Description = "Tofu is a food prepared by coagulating soy milk and then pressing the resulting curds into solid white blocks of varying softness; it can be silken, soft, firm, extra firm or super firm. Beyond these broad textural categories, there are many varieties of tofu. It has a subtle flavor, so it can be used in savory and sweet dishes. It is often seasoned or marinated to suit the dish and its flavors, and due to its spongy texture, it absorbs flavors well.",
                    ImageData = { }
                },

                new Ingredient
                {
                    Id = 5,
                    Name = "Østerssauce",
                    Description = "Oyster sauce is a sweet and salty condiment made primarily from oyster juices, salt, and sugar. It also boasts umami, which is a savory, tangy flavor. It's commonly used in Asian cuisines, including Chinese and Thai dishes, for stir-fries, meat marinades, and dipping sauces.",
                    ImageData = { }
                });
        }
    }
}
