using example.com.database;
using example.com.database.Helper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = (new ConfigurationBuilder())
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", false, true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", true, true)
    .AddEnvironmentVariables()
    .Build();

var dbConnection = configuration.GetConnectionString("Connection");
var dbProvider = configuration.GetConnectionString("Provider");

builder.Services.InstallDatabase(dbConnection, dbProvider);


var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    try
    {
        var context = scope.ServiceProvider.GetRequiredService<DataContext>();
        Console.WriteLine("Start Migrating database schema");
            await context.Database.MigrateAsync();
        Console.WriteLine("Migrated database completed");
        Console.WriteLine("Applying Seed Data");
        await context.ResetData();
        Console.WriteLine("Apply Seed Data Successful");
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Close in {(10 - i)} seconds");
            Thread.Sleep(1000);
        }
    }
    catch (Exception x)
    {
        Console.WriteLine(x);
    }
}

return 0;
