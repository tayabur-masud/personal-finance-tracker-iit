using PersonalFinanceTrackerIIT.Models;

namespace PersonalFinanceTrackerIIT.Services;

public interface ICategoryService
{
    void AddCategory(CategoryModel model);

    IReadOnlyCollection<CategoryModel> GetCategories();
}
