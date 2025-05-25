using Microsoft.EntityFrameworkCore;
using Small_product_page_C_.Models;


namespace Small_product_page_C_.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }
        public DbSet <Book> Books  { get; set; }
        public DbSet <CD> CDs { get; set; }
        public DbSet<Furniture> Furnitures { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasKey(p => p.Sku); // Set Sku as the primary key for Product
        }
    }
}
