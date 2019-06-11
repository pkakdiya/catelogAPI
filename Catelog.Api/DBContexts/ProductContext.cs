using Catelog.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Catelog.Api.DBContexts
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder.Entity<Category>().HasData(
          new Category
          {
              Id = 1,
              Name = "Electronics",
              Description = "Electronic Items",
          },
          new Category
          {
              Id = 2,
              Name = "Clothes",
              Description = "Dresses",
          },
          new Category
          {
              Id = 3,
              Name = "Grocery",
              Description = "Grocery Items",
          }
      );
    }
}
