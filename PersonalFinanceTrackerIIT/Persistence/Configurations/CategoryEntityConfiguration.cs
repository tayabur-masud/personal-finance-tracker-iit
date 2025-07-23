using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Configurations;

public class CategoryEntityConfiguration : BaseEntityConfiguration<Category>
{
    protected override string Table => "Categories";

    public override void Configure(EntityTypeBuilder<Category> builder)
    {
        base.Configure(builder);

        builder.Property(c => c.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.Description)
            .HasMaxLength(255);

        builder.Property(c => c.Type)
            .IsRequired();
    }
}
