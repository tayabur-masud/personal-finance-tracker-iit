using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Utilities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
{
    protected override IQueryable<Transaction> QueryWithIncludes => base.QueryWithIncludes.Include(x => x.Category);

    public TransactionRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IReadOnlyCollection<Transaction>> GetTransactionsBySummaryFilterAsync(MonthlyIncomeAndExpenseSummaryFilterModel filter)
    {
        var query = QueryWithIncludes;

        if (filter.Categories != null && filter.Categories.Count > 0)
        {
            query = query.Where(t => filter.Categories.Contains(t.CategoryId));
        }
        if (!filter.MonthId.IsNullOrEmpty())
        {
            var monthYear = MonthService.GetMonthAndYearFromMonthId(filter.MonthId);
            query = query.Where(t => t.Date.Year == monthYear.Item2 && t.Date.Month == monthYear.Item1);
        }
        return await query.ToListAsync();
    }

    public async Task<IReadOnlyCollection<Transaction>> GetByCategory(int categoryId)
    {
        return await QueryWithIncludes
            .Where(t => t.CategoryId == categoryId)
            .ToListAsync();
    }

    public async Task<IReadOnlyCollection<Transaction>> GetByMonthYearCategory(int month, int year, int categoryId)
    {
        var fromDate = MonthService.GetFirstDayOfMonth(year, month);
        var toDate = MonthService.GetLastDayOfMonth(year, month);
        if (fromDate == DateTime.MinValue || toDate == DateTime.MinValue)
        {
            throw new ArgumentException("Invalid month or year provided.");
        }
        if (categoryId <= 0)
        {
            throw new ArgumentException("Invalid category ID provided.");
        }

        return await QueryWithIncludes
            .Where(t => t.CategoryId == categoryId
                    && t.Date.Date >= fromDate.Date
                    && t.Date.Date <= toDate.Date)
            .ToListAsync();
    }

    public async Task<IReadOnlyCollection<Transaction>> GetByCategoryType(CategoryType categoryType)
    {
        return await QueryWithIncludes
            .Where(t => t.Category.Type == (int)categoryType)
            .ToListAsync();
    }

    public async Task<IReadOnlyCollection<Transaction>> GetExpenseBySummaryFilterAsync(ExpenseOverTimeFilterModel filter)
    {
        var query = QueryWithIncludes.Where(x => x.Category.Type == (int)CategoryType.Expense
            && x.Date.Date >= filter.From.Date
            && x.Date.Date <= filter.To.Date);

        if (filter.Categories != null && filter.Categories.Count > 0)
        {
            query = query.Where(t => filter.Categories.Contains(t.CategoryId));
        }

        return await query.OrderBy(x => x.Date).ToListAsync();
    }

    public async Task<decimal> GetCurrentBalance()
    {
        var income = await QueryWithIncludes.Where(x => x.Category.Type == (int)CategoryType.Income).SumAsync(x => x.Amount);
        var expense = await QueryWithIncludes.Where(x => x.Category.Type == (int)CategoryType.Expense).SumAsync(x => x.Amount);
        return income - expense;
    }

    public async Task<IReadOnlyCollection<Transaction>> GetLast10Transactions()
    {
        return await QueryWithIncludes
            .OrderByDescending(t => t.Date)
            .Take(10)
            .ToListAsync();
    }

    public async Task<IReadOnlyCollection<Transaction>> GetRecentTransactionsByDay(int days)
    {
        
        var toDate = DateTime.Now.Date;
        var fromDate = toDate.AddDays(-days);

        var query = QueryWithIncludes.Where(x => x.Category.Type == (int)CategoryType.Expense
            && x.Date.Date >= fromDate.Date
            && x.Date.Date <= toDate.Date);

        return await query.OrderBy(x => x.Date).ToListAsync();
    }
}
