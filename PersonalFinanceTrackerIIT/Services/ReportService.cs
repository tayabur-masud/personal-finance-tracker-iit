using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Persistence.Repositories;

namespace PersonalFinanceTrackerIIT.Services;

public class ReportService : IReportService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ITransactionRepository _transactionRepository;

    public ReportService(
        ICategoryRepository categoryRepository, 
        ITransactionRepository transactionRepository)
    {
        _categoryRepository = categoryRepository;
        _transactionRepository = transactionRepository;
    }

    public async Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel)
    {
        var transactions = await _transactionRepository.GetTransactionsBySummaryFilterAsync(filterModel);
        var reportData = transactions.Adapt<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryReportModel>>();
        return reportData;
    }

    public async Task<IReadOnlyCollection<CategoryWiseExpenseBreakdownModel>> GetCategoryWiseExpenseBreakdownAsync()
    {
        var reportData = new List<CategoryWiseExpenseBreakdownModel>();
        var categories = await _categoryRepository.GetByType(CategoryType.Expense);
        foreach (var category in categories)
        {
            var totalExpense = await _transactionRepository.GetByCategory(category.Id);
            
            var data = new CategoryWiseExpenseBreakdownModel
            {
                CategoryName = category.Name,
                TotalExpense = totalExpense.Sum(x => x.Amount),
                TransactionCount = totalExpense.Count,
            };
            reportData.Add(data);
        }
        
        return reportData;
    }
}
