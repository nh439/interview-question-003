using example.com.database.Constraint;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace example.com.database.Helper;

public static class InstallHelper
{
    public static IServiceCollection InstallDatabase(
        this IServiceCollection service,
        string connectionString,
        string providerName
    )
    {
        service.AddDbContext<DataContext>(option =>
            {
                switch (providerName.ToLower())
                {
                    case DatabaseProviderConstraint.MySql:
                        option.UseMySQL(connectionString);
                        break;
                    case  DatabaseProviderConstraint.PostgreSQL:
                        option.UseNpgsql(connectionString);
                        break;
                    case DatabaseProviderConstraint.Sqlite:
                        option.UseSqlite(connectionString);
                        break;
                    case DatabaseProviderConstraint.SqlServer:
                        option.UseSqlServer(connectionString);
                        break;
                    default:
                        Console.WriteLine($"Unknown database provider '{providerName}'.");
                        throw new NotSupportedException("This Provider Not Supported");
                        
                
                };
            }
            );
        return service;
       
    }
}