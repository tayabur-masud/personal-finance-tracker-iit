using Microsoft.EntityFrameworkCore;
using PersonalFinanceTrackerIIT.Persistence.Configurations;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}