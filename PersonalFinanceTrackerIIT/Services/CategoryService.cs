using PersonalFinanceTrackerIIT.Models;
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

    public void AddCategory(CategoryModel model)
    {
        var category = new Category
        {
            Name = model.Name,
            Description = model.Description
        };

        _categoryRepository.Add(category);
    }

    public IReadOnlyCollection<CategoryModel> GetCategories()
    {
        _categoryRepository.GetAll();
        throw new NotImplementedException();
    }
}
