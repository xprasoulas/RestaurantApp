using Restaurant.Models;
using System.Data.Entity;

namespace Restaurant.Persistence
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        // for the connection call with the AngularProject
        public ApplicationDbContext() : base ("ApplicationDbContext")
        {
            base.Configuration.ProxyCreationEnabled = false; 
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}