namespace PersonalFinanceTrackerIIT.Persistence.Entities;

public class Transaction : BaseEntity
{
    public DateTime Date { get; set; }

    public decimal Amount { get; set; }

    public int CategoryId { get; set; }
    
    public string Description { get; set; }

    public virtual Category Category { get; set; }
}
