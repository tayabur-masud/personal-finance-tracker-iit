using Microsoft.EntityFrameworkCore;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IReadOnlyCollection<Category>> GetByType(CategoryType type)
    {
        return await Query.AsNoTracking().Where(x => x.Type == (int)type).OrderBy(x => x.Name).ToListAsync();
    }

    public async Task<Category> GetByTypeAndName(CategoryType type, string name)
    {
        return await Query.AsNoTracking().FirstOrDefaultAsync(x => x.Type == (int)type
            && x.Name.ToLower().Equals(name.ToLower()));
    }
}
