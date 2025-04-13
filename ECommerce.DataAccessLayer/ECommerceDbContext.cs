using ECommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.DataAccessLayer
{
    public class ECommerceDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) 
            : base(options) 
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasKey(p => p.Id);
        }

    }
}
