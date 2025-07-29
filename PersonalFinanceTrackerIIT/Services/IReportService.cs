using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;

namespace PersonalFinanceTrackerIIT.Services;

public interface IReportService : IDisposable
{
    Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel);

    Task<IReadOnlyCollection<CategoryWiseExpenseBreakdownModel>> GetCategoryWiseExpenseBreakdownAsync();
    Task<IReadOnlyCollection<BudgetVsActualExpenseReportModel>> GetBudgetVsActualExpenseAsync(string monthId);
}
