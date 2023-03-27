using Microsoft.EntityFrameworkCore;
using TEOAG.Data.Context;
using TEOAG.Data.Mappings;
using TEOAG.Domain.Entities;

namespace TEOAG.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMap());
        }
    }
}