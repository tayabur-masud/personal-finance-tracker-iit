using PersonalFinanceTrackerIIT.Models;

namespace PersonalFinanceTrackerIIT.Services;

public interface ITransactionService : IDisposable
{
    Task AddOrUpdateTransaction(TransactionModel model);

    Task DeleteTransaction(int id);

    Task<IReadOnlyCollection<TransactionModel>> GetIncomeTransactions();

    Task<IReadOnlyCollection<TransactionModel>> GetExpenseTransactions();
}
