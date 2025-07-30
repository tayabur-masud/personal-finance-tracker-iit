using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Persistence.Repositories;

namespace PersonalFinanceTrackerIIT.Services;

public class BudgetService : IBudgetService
{
    private readonly IBudgetRepository _budgetRepository;

    public BudgetService(IBudgetRepository budgetRepository)
    {
        _budgetRepository = budgetRepository;
    }

    public async Task AddOrUpdateBudget(BudgetModel model)
    {
        var budget = model.Adapt<Budget>();

        var existingBudget = await _budgetRepository.GetByMonthYearCategory(budget.Month, budget.Year, budget.CategoryId);

        if (existingBudget is not null && existingBudget.Id != budget.Id)
        {
            throw new InvalidOperationException("Budget for the specified month and category already exists.");
        }

        if (budget.Id > 0)
        {
            await _budgetRepository.Update(budget);
            return;
        }

        await _budgetRepository.Add(budget);
    }

    public async Task DeleteBudget(int id)
    {
        await _budgetRepository.Remove(id);
    }

    public async Task<IReadOnlyCollection<BudgetModel>> GetBudgetsByMonth(string monthId)
    {
        if (string.IsNullOrEmpty(monthId) || monthId.Length != 6)
        {
            throw new ArgumentException("Invalid monthId format. Expected format is 'MMYYYY'.", nameof(monthId));
        }

        if (!int.TryParse(monthId.Substring(0, 2), out int month) || !int.TryParse(monthId.Substring(2, 4), out int year))
        {
            throw new ArgumentException("Invalid monthId format. Expected format is 'MMYYYY'.", nameof(monthId));
        }
        var budgets = await _budgetRepository.GetByMonthYear(month, year);

        var budgetModels = budgets.Adapt<IReadOnlyCollection<BudgetModel>>();
        return budgetModels.OrderBy(x => x.CategoryName).ToList();
    }

    public void Dispose()
    {
        _budgetRepository.Dispose();
    }
}
