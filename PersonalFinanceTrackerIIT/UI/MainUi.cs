using Microsoft.Extensions.DependencyInjection;
using PersonalFinanceTrackerIIT.UI.Budgets;
using PersonalFinanceTrackerIIT.UI.Categories;
using PersonalFinanceTrackerIIT.UI.Reports;
using PersonalFinanceTrackerIIT.UI.Transactions;

namespace PersonalFinanceTrackerIIT.UI;

public partial class MainUi : Form
{
    private readonly IServiceProvider _serviceProvider;

    public MainUi(IServiceProvider serviceProvider)
    {
        InitializeComponent();
        _serviceProvider=serviceProvider;
    }

    private void incomeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var incomeUi = _serviceProvider.GetRequiredService<IncomeUi>();
        incomeUi.ShowDialog();
    }

    private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var expenseUi = _serviceProvider.GetRequiredService<ExpenseUi>();
        expenseUi.ShowDialog();
    }

    private void categoryAddUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var categoryUi = _serviceProvider.GetRequiredService<CategoryUi>();
        categoryUi.ShowDialog();
    }

    private void monthlyIncomeExpenseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var monthlyIncomeAndExpenseSummaryUi = _serviceProvider.GetRequiredService<MonthlyIncomeAndExpenseSummaryUi>();
        monthlyIncomeAndExpenseSummaryUi.ShowDialog();
    }

    private void addUpdateDeleteToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var budgetUi = _serviceProvider.GetRequiredService<BudgetUi>();
        budgetUi.ShowDialog();
    }

    private void categoryWiseExpenseBreakdownToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var categoryWiseExpenseBreakdownUi = _serviceProvider.GetRequiredService<CategoryWiseExpenseBreakdownUi>();
        categoryWiseExpenseBreakdownUi.ShowDialog();
    }

    private void budgetVsActualExpenseReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var budgetVsActualExpenseUi = _serviceProvider.GetRequiredService<BudgetVsActualExpenseUi>();
        budgetVsActualExpenseUi.ShowDialog();
    }

    private void expenseOverTimeReportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var expenseOverTimeUi = _serviceProvider.GetRequiredService<ExpenseOverTimeUi>();
        expenseOverTimeUi.ShowDialog();
    }
}
