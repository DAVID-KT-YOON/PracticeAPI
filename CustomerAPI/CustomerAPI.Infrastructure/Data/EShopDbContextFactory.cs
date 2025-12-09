using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CustomerAPI.Infrastructure.Data
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<EShopDbContext>
    {
        public EShopDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EShopDbContext>();

            // Use any valid connection string for migrations
            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=EShopDb;Trusted_Connection=True;TrustServerCertificate=True;");

            return new EShopDbContext(optionsBuilder.Options);
        }
    }
}
