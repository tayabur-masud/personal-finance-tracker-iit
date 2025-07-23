using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Configurations;

internal class BudgetEntityConfiguration : BaseEntityConfiguration<Budget>
{
    protected override string Table => "Budgets";

    public override void Configure(EntityTypeBuilder<Budget> builder)
    {
        base.Configure(builder);

        builder.Property(b => b.Month)
            .IsRequired();

        builder.Property(b => b.Year)
            .IsRequired();

        builder.Property(b => b.Amount)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.HasOne(b => b.Category)
            .WithMany(c => c.Budgets)
            .HasForeignKey(b => b.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
