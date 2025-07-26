using PersonalFinanceTrackerIIT.Models;

namespace PersonalFinanceTrackerIIT.Services;

public interface ITransactionService
{
    Task AddTransaction(TransactionModel model);

    Task<IReadOnlyCollection<TransactionModel>> GetIncomeTransactions();

    Task<IReadOnlyCollection<TransactionModel>> GetExpenseTransactions();
}
