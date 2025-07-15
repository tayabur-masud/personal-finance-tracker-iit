using Mapster;
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

    public async Task AddCategory(CategoryModel model)
    {
        var category = model.Adapt<Category>();

        await _categoryRepository.Add(category);
    }

    public async Task<IReadOnlyCollection<CategoryModel>> GetCategories()
    {
        var categories = await _categoryRepository.GetAll();
        var categoryModels = categories.Adapt<IReadOnlyCollection<CategoryModel>>();
        return categoryModels;
    }
}
