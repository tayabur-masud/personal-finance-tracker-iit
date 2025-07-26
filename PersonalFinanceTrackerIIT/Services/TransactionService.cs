using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Persistence.Repositories;

namespace PersonalFinanceTrackerIIT.Services;

public class TransactionService : ITransactionService
{
    private readonly ITransactionRepository _transactionRepository;

    public TransactionService(ITransactionRepository transactionRepository)
    {
        _transactionRepository = transactionRepository;
    }

    public async Task AddTransaction(TransactionModel model)
    {
        var transaction = model.Adapt<Transaction>();

        await _transactionRepository.Add(transaction);
    }

    public Task<IReadOnlyCollection<TransactionModel>> GetExpenseTransactions()
    {
        throw new NotImplementedException();
    }

    public Task<IReadOnlyCollection<TransactionModel>> GetIncomeTransactions()
    {
        throw new NotImplementedException();
    }
}
