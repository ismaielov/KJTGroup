using KJTGroup.Entities;
using Microsoft.EntityFrameworkCore;

namespace KJTGroup.EFCore
{
    public class ApplicationDbContext : DbContext

    {
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }




        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>()
                        .HasIndex(product => product.Id)
                        .IsUnique();

            modelBuilder.Entity<Product>()
                        .Property(p => p.Price)
                        .HasColumnType("decimal(18,4)");

            modelBuilder.Entity<Order>()
                        .Property(o => o.Price)
                        .HasColumnType("decimal(18,4)");


            modelBuilder.Entity<Product>()
                        .Property(w => w.Weight)
                        .HasColumnType("decimal(10, 4)");

        }


    }
}
