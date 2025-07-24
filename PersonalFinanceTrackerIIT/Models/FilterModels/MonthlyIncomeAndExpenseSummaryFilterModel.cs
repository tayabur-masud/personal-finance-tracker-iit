namespace PersonalFinanceTrackerIIT.Models.FilterModels;

public class MonthlyIncomeAndExpenseSummaryFilterModel
{
    public IReadOnlyCollection<int> Categories { get; set; }

    public int MonthId { get; set; }
}
