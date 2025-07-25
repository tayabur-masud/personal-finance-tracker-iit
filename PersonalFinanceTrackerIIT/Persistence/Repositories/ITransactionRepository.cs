using PersonalFinanceTrackerIIT.Models.FilterModels;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public interface ITransactionRepository : IRepositoryBase<Transaction>
{
    Task<IReadOnlyCollection<Transaction>> GetTransactionsBySummaryFilterAsync(MonthlyIncomeAndExpenseSummaryFilterModel filter);
}
