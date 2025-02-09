
using System.Reflection;
using Eticaret.Core.Entities;
using Eticaret.Data.Confugrations;
using Microsoft.EntityFrameworkCore;

namespace Eticaret.Data
{
    public class DatabaseContex : DbContext
    {
        private ModelBuilder modelBuilder;

        public DbSet<AppUser>AppUsers { get; set; }
        public DbSet<Brand>Brands { get; set; }
        public DbSet<Category>Categories { get; set; }
        public DbSet<Contact > Contacts { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Slider> Sliders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SampleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //base.OnModelCreating(modelBuilder);
        }
    }
}
