using SportsStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsStore.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }

    public class DbInitializer : DropCreateDatabaseIfModelChanges<EFDbContext>
    {
        protected override void Seed(EFDbContext context)
        {
            InitData(context);
            base.Seed(context);
        }

        private void InitData(EFDbContext context)
        {
            var products = new List<Product>() { 
                new Product() { Name = "Kayak", Category = "Watersports", Description = "A boat for one person", Price = 275.00m },
                new Product() { Name = "Lifejacket", Category = "Watersports", Description = "Protective and fashionable", Price = 48.95m },
                new Product() { Name = "Soccer Ball", Category = "Soccer", Description = "FIFA-approved size and weight", Price = 19.50m },
                new Product() { Name = "Corner Flags", Category = "Soccer", Description = "Give your playing field a professional touch", Price = 34.95m },
                new Product() { Name = "Stadium", Category = "Soccer", Description = "Flat-packed 35,000-seat stadium'", Price = 79500.00m },
                new Product() { Name = "Thinking Cap", Category = "Chess", Description = "Improve your brain efficiency by 75%", Price = 16.00m },
                new Product() { Name = "Unsteady Chair", Category = "Chess", Description = "Secretly give your opponent a disadvantage", Price = 29.95m },
                new Product() { Name = "Human Chess Board", Category = "Chess", Description = "A fun game for the family", Price = 75.00m },
                new Product() { Name = "Bling-Bling King", Category = "Chess", Description = "Gold-plated, diamond-studded King", Price = 1200.00m },
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();
        }
    }
}
