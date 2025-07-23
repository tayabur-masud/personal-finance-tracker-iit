using Microsoft.Extensions.Configuration;
using PersonalFinanceTrackerIIT.Models;
using System.Globalization;

namespace PersonalFinanceTrackerIIT.Utilities;

public static class MonthService
{
    public static IReadOnlyCollection<Month> GetMonths()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var budgetMonth = configuration.GetSection("BudgetMonth")
            .Get<BudgetMonth>(options => { options.BindNonPublicProperties = true; });

        var startMonthYear = GetMonthAndYear(budgetMonth.Start);
        var endMonthYear = GetMonthAndYear(budgetMonth.End);

        var months = new List<Month>();

        var current = new DateTime(startMonthYear.Item2, startMonthYear.Item1, 1);
        var end = new DateTime(endMonthYear.Item2, endMonthYear.Item1, 1);

        while (current <= end)
        {
            months.Add(new Month { Id = Convert.ToInt32(current.ToString("MMyyyy")), Name = current.ToString("MMM-yyyy") });
            current = current.AddMonths(1);
        }

        return months;
    }

    public static Month GetCurrentMonth()
    {
        return new Month { Id =  Convert.ToInt32(DateTime.Now.ToString("MMyyyy")), Name = DateTime.Now.ToString("MMM-yyyy") };
    }

    private static Tuple<int, int> GetMonthAndYear(string date)
    {
        DateTime tempDate = Convert.ToDateTime(date, CultureInfo.InvariantCulture);
        return new Tuple<int, int>(tempDate.Month, tempDate.Year);
    }
}
