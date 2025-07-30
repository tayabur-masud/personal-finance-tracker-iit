using Mapster;
using PersonalFinanceTrackerIIT.Models;
using PersonalFinanceTrackerIIT.Models.Enums;
using PersonalFinanceTrackerIIT.Models.ReportModels;
using PersonalFinanceTrackerIIT.Persistence.Entities;

namespace PersonalFinanceTrackerIIT.Mappings;

public class TransactionMapper : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Transaction, TransactionModel>()
            .Map(dest => dest.CategoryName, src => src.Category.Name);

        config.NewConfig<TransactionModel, Transaction>();

        config.NewConfig<Transaction, MonthlyIncomeAndExpenseSummaryModel>()
            .Map(dest => dest.IncomeAmount, src => src.Amount, src => src.Category.Type == (int)CategoryType.Income)
            .Map(dest => dest.ExpenseAmount, src => src.Amount, src => src.Category.Type == (int)CategoryType.Expense)
            .Map(dest => dest.Category, src => src.Category.Name);
    }
}
