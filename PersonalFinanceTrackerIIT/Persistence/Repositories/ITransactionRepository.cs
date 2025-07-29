using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public interface ITransactionRepository : IRepositoryBase<Transaction>
{
    Task<IReadOnlyCollection<Transaction>> GetTransactionsBySummaryFilterAsync(MonthlyIncomeAndExpenseSummaryFilterModel filter);

    Task<IReadOnlyCollection<Transaction>> GetByCategory(int categoryId);

    Task<IReadOnlyCollection<Transaction>> GetByMonthYearCategory(int month, int year, int categoryId);

    Task<IReadOnlyCollection<Transaction>> GetByCategoryType(CategoryType categoryType);

    Task<IReadOnlyCollection<Transaction>> GetExpenseBySummaryFilterAsync(ExpenseOverTimeFilterModel filter);
}
