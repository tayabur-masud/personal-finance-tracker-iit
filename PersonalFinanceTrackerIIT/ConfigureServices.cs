using Mapster;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.Mappings;
using PersonalFinanceTrackerIIT.Persistence;
using PersonalFinanceTrackerIIT.Persistence.Repositories;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.UI;
using PersonalFinanceTrackerIIT.UI.Budgets;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Reports;
using PersonalFinanceTrackerIIT.UI.Transactions;

namespace PersonalFinanceTrackerIIT;

public static class ConfigureServices
{
    public static IServiceCollection AddMappingConfigurations(this IServiceCollection services)
    {
        var config = TypeAdapterConfig.GlobalSettings;
        new CategoryMapper().Register(config);
        new TransactionMapper().Register(config);
        new BudgetMapper().Register(config);

        return services;
    }

    public static IServiceProvider AddUiServices(this IServiceCollection services)
    {
        services.AddScoped<MainUi>();
        services.AddScoped<CategoryUi>();
        services.AddScoped<IncomeUi>();
        services.AddScoped<ExpenseUi>();
        services.AddScoped<BudgetUi>();
        services.AddScoped<MonthlyIncomeAndExpenseSummaryUi>();
        services.AddScoped<CategoryWiseExpenseBreakdownUi>();
        services.AddScoped<BudgetVsActualExpenseUi>();
        services.AddScoped<ExpenseOverTimeUi>();
        return services.BuildServiceProvider();
    }

    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ITransactionRepository, TransactionRepository>();
        services.AddScoped<IBudgetRepository, BudgetRepository>();
        return services;
    }

    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ITransactionService, TransactionService>();
        services.AddScoped<IReportService, ReportService>();
        services.AddScoped<IBudgetService, BudgetService>();
        return services;
    }

    public static IServiceCollection AddApplicationDbContext(this IServiceCollection services)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .Build();
        services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("PersonalFinanceTracker"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });
        return services;
    }
}
