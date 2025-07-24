using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public class TransactionRepository : RepositoryBase<Transaction>, ITransactionRepository
{
    public TransactionRepository(ApplicationDbContext context) : base(context)
    {
    }
}
