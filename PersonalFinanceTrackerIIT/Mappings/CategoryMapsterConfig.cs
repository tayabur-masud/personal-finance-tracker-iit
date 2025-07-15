using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Mappings;

public static class CategoryMapsterConfig
{
    public static void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CategoryModel, Category>();
        config.NewConfig<Category, CategoryModel>();
    }
}
