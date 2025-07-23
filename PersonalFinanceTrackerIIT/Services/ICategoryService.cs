using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Services;

public interface ICategoryService
{
    Task AddCategory(CategoryModel model);

    Task<IReadOnlyCollection<CategoryModel>> GetCategories();

    Task<IReadOnlyCollection<CategoryModel>> GetCategoriesByType(CategoryType type);
}
