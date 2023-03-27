using Microsoft.EntityFrameworkCore;
using TEOAG.API.Models;

namespace TEOAG.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Product> Products { get; set; }
    }
}