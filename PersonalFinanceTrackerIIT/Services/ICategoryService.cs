using PersonalFinanceTrackerIIT.Models;

namespace PersonalFinanceTrackerIIT.Services;

public interface ICategoryService
{
    Task AddCategory(CategoryModel model);

    Task<IReadOnlyCollection<CategoryModel>> GetCategories();
}
