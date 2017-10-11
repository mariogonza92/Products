using Products.Domain;
using System.Data.Entity;

namespace Products.Backend.Models
{
    public class DataContextLocal : DataContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }
    }
}