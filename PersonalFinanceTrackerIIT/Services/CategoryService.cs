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

    public async Task AddOrUpdateCategory(CategoryModel model)
    {
        var category = model.Adapt<Category>();

        if(category.Id > 0)
        {
            await _categoryRepository.Update(category);
            return;
        }

        await _categoryRepository.Add(category);
    }

    public async Task DeleteCategory(int id)
    {
        await _categoryRepository.Remove(id);
    }

    public async Task<IReadOnlyCollection<CategoryModel>> GetCategories()
    {
        var categories = await _categoryRepository.GetAll();
        var categoryModels = categories.Adapt<IReadOnlyCollection<CategoryModel>>();
        return categoryModels;
    }

    public async Task<IReadOnlyCollection<CategoryModel>> GetCategoriesByType(CategoryType type)
    {
        var categories = await _categoryRepository.GetByType(type);
        var categoryModels = categories.Adapt<IReadOnlyCollection<CategoryModel>>();
        return categoryModels;
    }
}
