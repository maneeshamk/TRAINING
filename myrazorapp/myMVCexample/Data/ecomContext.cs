using Microsoft.EntityFrameworkCore;
using myMVCexample.Models;

namespace MyEcomMvcApp.Data
{
    public class EcomContext : DbContext
    {
        public EcomContext(DbContextOptions<EcomContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
