using Microsoft.EntityFrameworkCore;

namespace example.com.database;

public class DataContext : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 
    }
}