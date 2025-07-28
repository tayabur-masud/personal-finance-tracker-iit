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

    public async Task AddOrUpdateTransaction(TransactionModel model)
    {
        var transaction = model.Adapt<Transaction>();

        if (transaction.Id > 0)
        {
            await _transactionRepository.Update(transaction);
            return;
        }

        await _transactionRepository.Add(transaction);
    }

    public async Task DeleteTransaction(int id)
    {
        await _transactionRepository.Remove(id);
    }

    public async Task<IReadOnlyCollection<TransactionModel>> GetExpenseTransactions()
    {
        var transactions = await _transactionRepository.GetByCategoryType(CategoryType.Expense);
        var transactionModels = transactions.Adapt<IReadOnlyCollection<TransactionModel>>();
        return transactionModels.OrderByDescending(x => x.Date).ToList();
    }

    public async Task<IReadOnlyCollection<TransactionModel>> GetIncomeTransactions()
    {
        var transactions = await _transactionRepository.GetByCategoryType(CategoryType.Income);
        var transactionModels = transactions.Adapt<IReadOnlyCollection<TransactionModel>>();
        return transactionModels.OrderByDescending(x => x.Date).ToList();
    }
}
