using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Persistence.Repositories;

namespace PersonalFinanceTrackerIIT.Services;

public class ReportService : IReportService
{
    private readonly ITransactionRepository _transactionRepository;

    public ReportService(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public async Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel)
    {
        var transactions = await _transactionRepository.GetTransactionsBySummaryFilterAsync(filterModel);
        var reportData = transactions.Adapt<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>>();
        return reportData;
    }
}
