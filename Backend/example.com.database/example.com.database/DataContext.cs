using example.com.database.Entity;
using Microsoft.EntityFrameworkCore;

namespace example.com.database;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Approval>()
            .HasIndex(i => i.Name).IsUnique();
        modelBuilder.Entity<Approval>()
            .HasIndex(i => new { i.ApproveDate, i.IsPending, i.ApproveStatus });
        base.OnModelCreating(modelBuilder); 
    }
    public DbSet<Approval>  Approvals { get; set; }
}