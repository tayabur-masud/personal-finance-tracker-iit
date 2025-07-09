namespace PersonalFinanceTrackerIIT.Persistence.Entities;

public class BaseEntity
{
    public int Id { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? LastModifiedOn { get; set; }
}
