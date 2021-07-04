using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
