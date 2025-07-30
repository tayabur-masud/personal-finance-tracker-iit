using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.Enums;

namespace PersonalFinanceTrackerIIT.Services;

public interface ITransactionService : IDisposable
{
    Task AddOrUpdateTransaction(TransactionModel model, CategoryType categoryType);

    Task DeleteTransaction(int id);

    Task<IReadOnlyCollection<TransactionModel>> GetIncomeTransactions();

    Task<IReadOnlyCollection<TransactionModel>> GetExpenseTransactions();

    Task<decimal> GetCurrentBalance();

    Task<IReadOnlyCollection<TransactionModel>> GetLast10Transactions();

    Task<IReadOnlyCollection<TransactionModel>> GetRecentTransactionsByDay(int days);
}
