using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Mappings;

public class BudgetMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<BudgetModel, Budget>()
            .Map(dest => dest.Month, src => Convert.ToInt32(src.MonthId.Substring(0, 2)))
            .Map(dest => dest.Year, src => Convert.ToInt32(src.MonthId.Substring(2, 4)));

        config.NewConfig<Budget, BudgetModel>()
            .Map(dest => dest.CategoryName, src => src.Category.Name)
            .Map(dest => dest.MonthId, src => src.Month.ToString("00") + src.Year.ToString("0000"));
    }
}
