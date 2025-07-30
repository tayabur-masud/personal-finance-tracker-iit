using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Models.ReportModels;
using PersonalFinanceTrackerIIT.Persistence.Repositories;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.Services;

public class ReportService : IReportService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly ITransactionRepository _transactionRepository;
    private readonly IBudgetRepository _budgetRepository;

    public ReportService(
        ICategoryRepository categoryRepository,
        ITransactionRepository transactionRepository,
        IBudgetRepository budgetRepository)
    {
        _categoryRepository = categoryRepository;
        _transactionRepository = transactionRepository;
        _budgetRepository=budgetRepository;
    }

    public async Task<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryModel>> GetMonthlyIncomeAndExpenseSummaryReport(MonthlyIncomeAndExpenseSummaryFilterModel filterModel)
    {
        var transactions = await _transactionRepository.GetTransactionsBySummaryFilterAsync(filterModel);
        var reportData = transactions.Adapt<IReadOnlyCollection<MonthlyIncomeAndExpenseSummaryModel>>();
        return reportData.OrderBy(x => x.Date).ToList();
    }

    public async Task<IReadOnlyCollection<CategoryWiseExpenseBreakdownModel>> GetCategoryWiseExpenseBreakdownAsync(string monthId)
    {
        var monthYear = MonthService.GetMonthAndYearFromMonthId(monthId);

        var reportData = new List<CategoryWiseExpenseBreakdownModel>();
        var categories = await _categoryRepository.GetByType(CategoryType.Expense);
        foreach (var category in categories)
        {
            var transactions = await _transactionRepository.GetByMonthYearCategory(monthYear.Item1, monthYear.Item2, category.Id);

            var data = new CategoryWiseExpenseBreakdownModel
            {
                CategoryName = category.Name,
                TotalExpense = transactions.Sum(x => x.Amount),
                TransactionCount = transactions.Count,
            };

            if (data.TotalExpense > 0)
            {
                reportData.Add(data);
            }
        }

        return reportData;
    }

    public async Task<IReadOnlyCollection<BudgetVsActualExpenseReportModel>> GetBudgetVsActualExpenseAsync(string monthId)
    {
        var monthYear = MonthService.GetMonthAndYearFromMonthId(monthId);

        var reportData = new List<BudgetVsActualExpenseReportModel>();
        var categories = await _categoryRepository.GetByType(CategoryType.Expense);

        foreach (var category in categories)
        {
            var transactions = await _transactionRepository.GetByMonthYearCategory(monthYear.Item1, monthYear.Item2, category.Id);
            var budget = await _budgetRepository.GetByMonthYearCategory(monthYear.Item1, monthYear.Item2, category.Id);

            var data = new BudgetVsActualExpenseReportModel
            {
                CategoryName = category.Name,
                ActualExpense = transactions is not null ? (double)transactions.Sum(x => x.Amount) : 0,
                BudgetAmount = budget is not null ? (double)budget.Amount : 0,
            };
            reportData.Add(data);
        }

        return reportData;
    }

    public async Task<IReadOnlyCollection<ExpenseOverTimeModel>> GetExpenseOverTimeReport(ExpenseOverTimeFilterModel filterModel)
    {
        var transactions = await _transactionRepository.GetExpenseBySummaryFilterAsync(filterModel);

        var grouped = filterModel.GroupBy switch
        {
            GroupByPeriod.Daily => transactions
                                    .GroupBy(e => e.Date.ToString(Constants.DateFormat)),
            GroupByPeriod.Weekly => transactions.GroupBy(e =>
            {
                var diff = e.Date.DayOfWeek - DayOfWeek.Monday;
                var weekStart = e.Date.AddDays(-diff);
                return weekStart.Date.ToString(Constants.DateFormat);
            }),
            GroupByPeriod.Monthly => transactions
                                    .GroupBy(e => e.Date.ToString(Constants.MonthNameFormat)),
            _ => throw new ArgumentOutOfRangeException()
        };

        List<ExpenseOverTimeModel> reportData = grouped.Select(g => new ExpenseOverTimeModel
        {
            PeriodLabel = g.Key,
            TotalExpense = (double)g.Sum(x => x.Amount)
        }).ToList();

        return reportData;
    }

    public async Task<IReadOnlyCollection<ExpenseOverTimeModel>> GetExpenseTrendReportByDays(int days)
    {
        var transactions = await _transactionRepository.GetRecentTransactionsByDay(days);
        var reportData = new List<ExpenseOverTimeModel>();

        foreach (var transaction in transactions)
        {
            reportData.Add(new ExpenseOverTimeModel
            {
                PeriodLabel = transaction.Date.ToString(Constants.DateFormat),
                TotalExpense = (double)transaction.Amount
            });
        }

        return reportData;
    }

    public async Task<IReadOnlyCollection<BudgetUtilizationReportModel>> GetBudgetUtilizationOfCurrentMonthAsync()
    {
        var reportData = new List<BudgetUtilizationReportModel>();
        var categories = await _categoryRepository.GetByType(CategoryType.Expense);
        foreach (var category in categories)
        {
            var transactions = await _transactionRepository.GetByMonthYearCategory(DateTime.Now.Month, DateTime.Now.Year, category.Id);
            var budget = await _budgetRepository.GetByMonthYearCategory(DateTime.Now.Month, DateTime.Now.Year, category.Id);

            var actualExpense = transactions is not null ? transactions.Sum(x => x.Amount) : 0;

            if (actualExpense > 0)
            {
                var data = new BudgetUtilizationReportModel
                {
                    Category = category.Name,
                    UtilizationPercentage = budget is null ? 0 : Math.Round((double)(actualExpense/budget.Amount) * 100, 2),
                };
                reportData.Add(data);
            }
        }

        return reportData;
    }

    public void Dispose()
    {
        _categoryRepository.Dispose();
        _transactionRepository.Dispose();
        _budgetRepository.Dispose();
    }
}
