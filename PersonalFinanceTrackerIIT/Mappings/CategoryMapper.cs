using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Mappings;

public class CategoryMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<CategoryModel, Category>()
            .Map(dest => dest.Type, src => src.TypeId);

        config.NewConfig<Category, CategoryModel>()
            .Map(dest => dest.TypeId, src => src.Type)
            .Map(dest => dest.TypeName, src => ((CategoryType)src.Type).ToString());
    }
}
