using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


using System.IO;
using Microsoft.Extensions.Configuration;


namespace Domain.EF
{
    class DataContextFactory : IDesignTimeDbContextFactory<WebOnlineDbContext>
    {
        public WebOnlineDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("Config.json")
                    .Build(); ;
                

            var connectionString = configuration.GetConnectionString("SqlServerConnection");

            var optionsBuilder = new DbContextOptionsBuilder<WebOnlineDbContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new WebOnlineDbContext(optionsBuilder.Options);
        }
    }
}
