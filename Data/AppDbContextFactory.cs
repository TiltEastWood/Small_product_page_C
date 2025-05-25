using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Small_product_page_C_.Data;

namespace Small_product_page_C_.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args = null)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SmallProductDb;Trusted_Connection=True;");
            return new AppDbContext(optionsBuilder.Options);
        }
    }
}

