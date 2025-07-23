using Microsoft.EntityFrameworkCore;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IReadOnlyCollection<Category>> GetByType(CategoryType type)
    {
        return await Query.Where(x => x.Type == type).ToListAsync();
    }
}
