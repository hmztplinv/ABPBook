using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpBook.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AbpBookDbContextFactory : IDesignTimeDbContextFactory<AbpBookDbContext>
{
    public AbpBookDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AbpBookEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AbpBookDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AbpBookDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpBook.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
