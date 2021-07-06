using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace GeeksBakery.Data.EF
{
    class GeeksBakeryDbContextFactory : IDesignTimeDbContextFactory<GeeksBakeryDbContext>
    {
        public GeeksBakeryDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("GeeksBakeryDb");

            var optionsBuilder = new DbContextOptionsBuilder<GeeksBakeryDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new GeeksBakeryDbContext(optionsBuilder.Options);
        }
    }
}
