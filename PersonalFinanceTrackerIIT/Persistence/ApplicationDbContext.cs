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

    public DbSet<Budget> Budgets { get; set; }

    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CategoryEntityConfiguration());
        modelBuilder.ApplyConfiguration(new BudgetEntityConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionEntityConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}