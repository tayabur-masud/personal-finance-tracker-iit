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

        //var reportData = new List<MonthlyIncomeAndExpenseSummaryReportModel>();

        //foreach (var transaction in transactions) 
        //{
        //    var data = new MonthlyIncomeAndExpenseSummaryReportModel();

        //    data.Date = transaction.Date;
        //    data.Category = transaction.Category.Name;
        //    data.Description = transaction.Description;
        //    if (transaction.Category.Type == (int)Persistence.Entities.CategoryType.Income)
        //    {
        //        data.IncomeAmount = transaction.Amount;
        //    }
        //    else
        //    {
        //        data.ExpenseAmount = transaction.Amount;
        //    }
        //    reportData.Add(data);
        //}

        var reportData = transactions.Adapt<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>>();
        return reportData;
    }
}
