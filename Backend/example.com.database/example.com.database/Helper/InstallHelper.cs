using example.com.database.Constraint;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace example.com.database.Helper;

public static class InstallHelper
{
    public static IServiceCollection InstallDatabase(
        this IServiceCollection service,
        string connectionString
    )
    {
        service.AddDbContext<DataContext>(option =>
            {
                option.UseSqlite(connectionString);
            }
            );
        return service;
       
    }
}