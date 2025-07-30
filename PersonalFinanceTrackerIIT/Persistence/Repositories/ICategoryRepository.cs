using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Persistence.Repositories;

public interface ICategoryRepository : IRepositoryBase<Category>
{
    Task<IReadOnlyCollection<Category>> GetByType(CategoryType type);

    Task<Category> GetByTypeAndName(CategoryType type, string name);
}
