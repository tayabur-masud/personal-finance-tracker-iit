using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Models.ReportModels;

namespace PersonalFinanceTrackerIIT.Services;

public interface IReportService : IDisposable
{
    Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel);

    Task<IReadOnlyCollection<CategoryWiseExpenseBreakdownModel>> GetCategoryWiseExpenseBreakdownAsync(string monthId);

    Task<IReadOnlyCollection<BudgetVsActualExpenseReportModel>> GetBudgetVsActualExpenseAsync(string monthId);

    Task<IReadOnlyCollection<ExpenseOverTimeModel>> GetExpenseOverTimeReport(ExpenseOverTimeFilterModel filterModel);

    Task<IReadOnlyCollection<ExpenseOverTimeModel>> GetExpenseTrendReportByDays(int days);

    Task<IReadOnlyCollection<BudgetUtilizationReportModel>> GetBudgetUtilizationOfCurrentMonthAsync();
}
