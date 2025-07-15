using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.Handlers;
using PersonalFinanceTrackerIIT.Persistence;
using PersonalFinanceTrackerIIT.Persistence.Repositories;
using PersonalFinanceTrackerIIT.Services;
using PersonalFinanceTrackerIIT.UI;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Transactions;

namespace PersonalFinanceTrackerIIT;

internal static class Program
{
    public static IServiceProvider ServiceProvider { get; private set; }

    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        var services = new ServiceCollection();

        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.

        services.AddApplicationDbContext();

        services.AddMappingConfigurations();

        services.AddRepositories();

        services.AddServices();

        services.AddUiServices();

        var serviceProvider = services.BuildServiceProvider();

        Application.ThreadException += new ThreadExceptionEventHandler(GlobalExceptionHandler.ThreadException);
        AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(GlobalExceptionHandler.UnhandledException);

        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        ApplicationConfiguration.Initialize();
        var mainUi = serviceProvider.GetRequiredService<MainUi>();
        Application.Run(mainUi);
    }
}