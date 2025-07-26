namespace PersonalFinanceTrackerIIT.Persistence.Entities;

public class Category : BaseEntity
{
    public Category()
    {
        Transactions = new List<Transaction>();

        Budgets = new List<Budget>();
    }

    public string Name { get; set; }

    public string Description { get; set; }

    public int Type { get; set; }

    public virtual ICollection<Transaction> Transactions { get; set; }

    public virtual ICollection<Budget> Budgets { get; set; }
}
