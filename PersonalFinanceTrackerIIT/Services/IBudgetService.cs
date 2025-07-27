using PersonalFinanceTrackerIIT.Models;

namespace PersonalFinanceTrackerIIT.Services;

public interface IBudgetService
{
    Task AddOrUpdateBudget(BudgetModel model);

    Task DeleteBudget(int id);

    Task<IReadOnlyCollection<BudgetModel>> GetBudgetsByMonth(string monthId);
}
