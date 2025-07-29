namespace PersonalFinanceTrackerIIT.Models.FilterModels;

public class ExpenseOverTimeFilterModel
{
    public DateTime From { get; set; }

    public DateTime To { get; set; }

    public GroupByPeriod GroupBy { get; set; }

    public IReadOnlyCollection<int> Categories { get; set; }
}
