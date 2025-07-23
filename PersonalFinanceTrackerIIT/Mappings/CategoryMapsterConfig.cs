using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Mappings;

public static class CategoryMapsterConfig
{
    public static void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CategoryModel, Category>()
            .Map(dest => dest.Type, src => src.TypeId);

        config.NewConfig<Category, CategoryModel>()
            .Map(dest => dest.TypeName, src => src.Type.ToString());
    }
}
