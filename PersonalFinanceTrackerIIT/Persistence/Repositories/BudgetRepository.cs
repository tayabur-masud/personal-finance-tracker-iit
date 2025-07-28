using Microsoft.EntityFrameworkCore;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public class BudgetRepository : RepositoryBase<Budget>, IBudgetRepository
{
    protected override IQueryable<Budget> QueryWithIncludes => base.QueryWithIncludes.Include(x => x.Category);

    public BudgetRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IReadOnlyCollection<Budget>> GetByMonthYear(int month, int year)
    {
        return await QueryWithIncludes.Where(x => x.Month == month && x.Year == year).ToListAsync();
    }

    public async Task<Budget> GetByMonthYearCategory(int month, int year, int categoryId)
    {
        return await QueryWithIncludes.FirstOrDefaultAsync(x => x.Month == month && x.Year == year && x.CategoryId == categoryId);
    }
}
