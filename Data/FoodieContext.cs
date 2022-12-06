using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public DbSet<Ingredient> Ingredients { get; set; }
    }
}
