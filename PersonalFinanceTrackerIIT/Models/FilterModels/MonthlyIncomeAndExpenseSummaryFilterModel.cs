namespace PersonalFinanceTrackerIIT.Models.FilterModels;

public class MonthlyIncomeAndExpenseSummaryFilterModel
{
    public IReadOnlyCollection<int> Categories { get; set; }

    public string MonthId { get; set; }
}
