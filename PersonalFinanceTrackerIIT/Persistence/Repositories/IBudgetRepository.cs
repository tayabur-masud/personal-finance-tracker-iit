using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public interface IBudgetRepository : IRepositoryBase<Budget>
{
    Task<IReadOnlyCollection<Budget>> GetByMonthYear(int month, int year);
}
