using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Configurations;

public abstract class BaseEntityConfiguration<T> : IEntityTypeConfiguration<T>
    where T : BaseEntity
{
    protected abstract string Table { get; }

    public virtual void Configure(EntityTypeBuilder<T> builder)
    {
        builder.ToTable(Table);

        builder.HasKey(e => e.Id);

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(c => c.CreatedOn)
            .IsRequired()
            .HasDefaultValueSql("GETDATE()");

        builder.Property(c => c.LastModifiedOn);
    }
}
