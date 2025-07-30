namespace PersonalFinanceTrackerIIT.Models.ReportModels;

public class BudgetVsActualExpenseReportModel
{
    public string CategoryName { get; set; }

    public double BudgetAmount { get; set; }

    public double ActualExpense { get; set; }
}
