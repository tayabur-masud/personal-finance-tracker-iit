using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;

namespace PersonalFinanceTrackerIIT.Services;

public interface IReportService
{
    Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel);

    Task<IReadOnlyCollection<CategoryWiseExpenseBreakdownModel>> GetCategoryWiseExpenseBreakdownAsync(string monthId);

    Task<IReadOnlyCollection<BudgetVsActualExpenseReportModel>> GetBudgetVsActualExpenseAsync(string monthId);

    Task<IReadOnlyCollection<ExpenseOverTimeModel>> GetExpenseOverTimeReport(ExpenseOverTimeFilterModel filterModel);
}
