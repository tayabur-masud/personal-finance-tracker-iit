using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;

namespace PersonalFinanceTrackerIIT.Services;

public interface IReportService
{
    Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel);
}
