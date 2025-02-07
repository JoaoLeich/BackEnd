using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class LivroDBContextFactory : IDesignTimeDbContextFactory<LivroDbContext>
{

    public LivroDbContext CreateDbContext(string[] args)
    {

        var optionsBuilder = new DbContextOptionsBuilder<LivroDbContext>();

        IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

        var ConnectionString = configuration.GetConnectionString("DefaultConnection");
        optionsBuilder.UseMySql(ConnectionString, new MySqlServerVersion(new Version(8, 0, 26)));

        return new LivroDbContext(optionsBuilder.Options);
    }

}