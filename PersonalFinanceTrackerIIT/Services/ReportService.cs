using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;

namespace PersonalFinanceTrackerIIT.Services;

public class ReportService : IReportService
{
    public async Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel)
    {
        throw new NotImplementedException();
    }
}
