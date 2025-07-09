using PersonalFinanceTrackerIIT.Persistence.Entities;
using PersonalFinanceTrackerIIT.Persistence.Repositories;

namespace PersonalFinanceTrackerIIT.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public void AddCategory(string name, string description)
    {
        var category = new Category
        {
            Name = name,
            Description = description
        };

        _categoryRepository.Add(category);
    }
}
