using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace kanija_database.EF
{
    public class FmDbContextFactory : IDesignTimeDbContextFactory<KanijaDbContext>
    {
        public KanijaDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot congifuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var connectionString = "Server=CHUNGHOKAGE\\SQLEXPRESS;Database=Kanija;Trusted_Connection=true;Encrypt=True;TrustServerCertificate=True";
            var optionBuilder = new DbContextOptionsBuilder<KanijaDbContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new KanijaDbContext(optionBuilder.Options);
        }
    }
}