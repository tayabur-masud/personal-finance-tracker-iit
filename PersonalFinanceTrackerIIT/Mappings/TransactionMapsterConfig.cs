using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Mappings;

public static class TransactionMapsterConfig
{
    public static void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Transaction, MonthlyIncomeAndExpenseSummaryReportModel>()
            .Map(dest => dest.IncomeAmount, src => src.Amount, src => src.Category.Type == CategoryType.Income)
            .Map(dest => dest.ExpenseAmount, src => src.Amount, src => src.Category.Type == CategoryType.Expense)
            .Map(dest => dest.Category, src => src.Category.Name);
    }
}
