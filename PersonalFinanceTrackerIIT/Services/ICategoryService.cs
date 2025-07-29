using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Services;

public interface ICategoryService : IDisposable
{
    Task AddOrUpdateCategory(CategoryModel model);

    Task DeleteCategory(int id);

    Task<IReadOnlyCollection<CategoryModel>> GetCategories();

    Task<IReadOnlyCollection<CategoryModel>> GetCategoriesByType(CategoryType type);
}
