using Microsoft.EntityFrameworkCore;
using Howest.DeVarens.Core.Entities;
using Howest.DeVarens.Web.Data.Seeding;

namespace Howest.DeVarens.Web.Data
{
    public class WebshopContext : DbContext
    {
        public DbSet<FormOfEducation> FormOfEducation { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Product> Products { get; set; }

        public WebshopContext(DbContextOptions<WebshopContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configure the Form Entity
            modelBuilder.Entity<FormOfEducation>()
                .HasKey(f => f.Id);

            //Configure the Category Entity
            modelBuilder.Entity<Category>()
                .HasKey(c => c.Id);

            //Configure the Order Entity
            modelBuilder.Entity<Order>()
                .HasKey(o => o.Id);

            //Configure the OrderItem Entity
            modelBuilder.Entity<OrderItem>()
                .HasKey(o => o.Id);

            //Configure the Media Entity
            modelBuilder.Entity<Media>()
                .HasKey(m => m.Id);

            //Configure the Product Entity
            modelBuilder.Entity<Product>()
                .HasKey(p => p.Id);

            //finally, seed this db
            Seeder.Seed(modelBuilder);
        }

    }
}
