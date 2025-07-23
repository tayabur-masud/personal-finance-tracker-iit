using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Configurations;

public class TransactionEntityConfiguration : BaseEntityConfiguration<Transaction>
{
    protected override string Table => "Transactions";

    public override void Configure(EntityTypeBuilder<Transaction> builder)
    {
        base.Configure(builder);

        builder.Property(t => t.Date)
            .IsRequired();
       
        builder.Property(t => t.Amount)
            .IsRequired()
            .HasColumnType("decimal(10,2)");

        builder.Property(t => t.Description)
           .HasMaxLength(255);

        builder.HasOne(t => t.Category)
            .WithMany(c => c.Transactions)
            .HasForeignKey(t => t.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}