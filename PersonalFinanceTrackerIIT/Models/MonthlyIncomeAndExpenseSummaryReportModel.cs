namespace PersonalFinanceTrackerIIT.Models;

public class MonthlyIncomeAndExpenseSummaryReportModel
{
    public DateTime Date { private get; set; }

    public string DateString
    {
        get 
        {
            return Date.ToString("dd-MMMM-yyyy"); 
        }
    }

    public decimal IncomeAmount { get; set; }

    public decimal ExpenseAmount { get; set; }

    public string Category { get; set; }

    public string Description { get; set; }
}
