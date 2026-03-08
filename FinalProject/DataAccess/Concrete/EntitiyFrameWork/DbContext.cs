using System.Data.Entity;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}