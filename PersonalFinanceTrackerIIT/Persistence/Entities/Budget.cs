namespace PersonalFinanceTrackerIIT.Persistence.Entities;

public class Budget : BaseEntity
{
    public int Month { get; set; }

    public int Year { get; set; }

    public int CategoryId { get; set; }

    public decimal Amount { get; set; }

    public virtual Category Category { get; set; }
}
