namespace PersonalFinanceTrackerIIT.Models.ReportModels;

public class CategoryWiseExpenseBreakdownModel
{
    public string CategoryName { get; set; }
    
    public decimal TotalExpense { get; set; }
    
    public int TransactionCount { get; set; }
}
