using Microsoft.EntityFrameworkCore;
using Sales.Backend.Domain.Entities;

namespace Sales.Backend.Infrastructure.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Product { get; set; }
    }
}