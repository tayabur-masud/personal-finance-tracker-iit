namespace PersonalFinanceTrackerIIT.Models;

public class CategoryWiseExpenseBreakdownModel
{
    public string CategoryName { get; set; }
    
    public decimal TotalExpense { get; set; }
    
    public int TransactionCount { get; set; }
    
    public string CategoryColor { get; set; } // Optional, if you want to include color information for the category
}
